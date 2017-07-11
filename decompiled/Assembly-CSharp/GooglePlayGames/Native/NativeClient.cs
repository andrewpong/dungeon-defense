// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.NativeClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.Quests;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Native
{
  public class NativeClient : IPlayGamesClient
  {
    private readonly object GameServicesLock = new object();
    private readonly object AuthStateLock = new object();
    private int webclientWarningFreq = 100000;
    private readonly IClientImpl clientImpl;
    private readonly PlayGamesClientConfiguration mConfiguration;
    private GooglePlayGames.Native.PInvoke.GameServices mServices;
    private volatile NativeTurnBasedMultiplayerClient mTurnBasedClient;
    private volatile NativeRealtimeMultiplayerClient mRealTimeClient;
    private volatile ISavedGameClient mSavedGameClient;
    private volatile IEventsClient mEventsClient;
    private volatile IQuestsClient mQuestsClient;
    private volatile TokenClient mTokenClient;
    private volatile Action<Invitation, bool> mInvitationDelegate;
    private volatile Dictionary<string, GooglePlayGames.BasicApi.Achievement> mAchievements;
    private volatile GooglePlayGames.BasicApi.Multiplayer.Player mUser;
    private volatile List<GooglePlayGames.BasicApi.Multiplayer.Player> mFriends;
    private volatile Action<bool, string> mPendingAuthCallbacks;
    private volatile Action<bool, string> mSilentAuthCallbacks;
    private volatile NativeClient.AuthState mAuthState;
    private volatile uint mAuthGeneration;
    private volatile bool mSilentAuthFailed;
    private volatile bool friendsLoading;
    private string rationale;
    private int noWebClientIdWarningCount;

    internal NativeClient(PlayGamesClientConfiguration configuration, IClientImpl clientImpl)
    {
      PlayGamesHelperObject.CreateObject();
      this.mConfiguration = Misc.CheckNotNull<PlayGamesClientConfiguration>(configuration);
      this.clientImpl = clientImpl;
      this.rationale = configuration.PermissionRationale;
      if (!string.IsNullOrEmpty(this.rationale))
        return;
      this.rationale = "Select email address to send to this game or hit cancel to not share.";
    }

    private GooglePlayGames.Native.PInvoke.GameServices GameServices()
    {
      lock (this.GameServicesLock)
        return this.mServices;
    }

    public void Authenticate(Action<bool, string> callback, bool silent)
    {
      lock (this.AuthStateLock)
      {
        if (this.mAuthState == NativeClient.AuthState.Authenticated)
        {
          NativeClient.InvokeCallbackOnGameThread<bool, string>(callback, true, (string) null);
          return;
        }
        if (this.mSilentAuthFailed && silent)
        {
          NativeClient.InvokeCallbackOnGameThread<bool, string>(callback, false, "silent auth failed");
          return;
        }
        if (callback != null)
        {
          if (silent)
            this.mSilentAuthCallbacks += callback;
          else
            this.mPendingAuthCallbacks += callback;
        }
      }
      this.InitializeGameServices();
      this.friendsLoading = false;
      if (silent)
        return;
      this.GameServices().StartAuthorizationUI();
    }

    private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CAsOnGameThreadCallback\u003Ec__AnonStorey0<T> callbackCAnonStorey0 = new NativeClient.\u003CAsOnGameThreadCallback\u003Ec__AnonStorey0<T>();
      // ISSUE: reference to a compiler-generated field
      callbackCAnonStorey0.callback = callback;
      // ISSUE: reference to a compiler-generated field
      if (callbackCAnonStorey0.callback == null)
        return (Action<T>) (param0 => {});
      // ISSUE: reference to a compiler-generated method
      return new Action<T>(callbackCAnonStorey0.\u003C\u003Em__0);
    }

    private static void InvokeCallbackOnGameThread<T, S>(Action<T, S> callback, T data, S msg)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CInvokeCallbackOnGameThread\u003Ec__AnonStorey1<T, S> threadCAnonStorey1 = new NativeClient.\u003CInvokeCallbackOnGameThread\u003Ec__AnonStorey1<T, S>();
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey1.callback = callback;
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey1.data = data;
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey1.msg = msg;
      // ISSUE: reference to a compiler-generated field
      if (threadCAnonStorey1.callback == null)
        return;
      // ISSUE: reference to a compiler-generated method
      PlayGamesHelperObject.RunOnGameThread(new Action(threadCAnonStorey1.\u003C\u003Em__0));
    }

    private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CInvokeCallbackOnGameThread\u003Ec__AnonStorey2<T> threadCAnonStorey2 = new NativeClient.\u003CInvokeCallbackOnGameThread\u003Ec__AnonStorey2<T>();
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey2.callback = callback;
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey2.data = data;
      // ISSUE: reference to a compiler-generated field
      if (threadCAnonStorey2.callback == null)
        return;
      // ISSUE: reference to a compiler-generated method
      PlayGamesHelperObject.RunOnGameThread(new Action(threadCAnonStorey2.\u003C\u003Em__0));
    }

    private void InitializeGameServices()
    {
      lock (this.GameServicesLock)
      {
        if (this.mServices != null)
          return;
        using (GameServicesBuilder gameServicesBuilder = GameServicesBuilder.Create())
        {
          using (PlatformConfiguration platformConfiguration = this.clientImpl.CreatePlatformConfiguration())
          {
            this.RegisterInvitationDelegate(this.mConfiguration.InvitationDelegate);
            gameServicesBuilder.SetOnAuthFinishedCallback(new GameServicesBuilder.AuthFinishedCallback(this.HandleAuthTransition));
            gameServicesBuilder.SetOnTurnBasedMatchEventCallback((Action<GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent, string, NativeTurnBasedMatch>) ((eventType, matchId, match) => this.mTurnBasedClient.HandleMatchEvent(eventType, matchId, match)));
            gameServicesBuilder.SetOnMultiplayerInvitationEventCallback(new Action<GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent, string, GooglePlayGames.Native.PInvoke.MultiplayerInvitation>(this.HandleInvitation));
            if (this.mConfiguration.EnableSavedGames)
              gameServicesBuilder.EnableSnapshots();
            if (this.mConfiguration.RequireGooglePlus)
              gameServicesBuilder.RequireGooglePlus();
            foreach (string scope in this.mConfiguration.Scopes)
              gameServicesBuilder.AddOauthScope(scope);
            Debug.Log((object) "Building GPG services, implicitly attempts silent auth");
            this.mAuthState = NativeClient.AuthState.SilentPending;
            this.mServices = gameServicesBuilder.Build(platformConfiguration);
            this.mEventsClient = (IEventsClient) new NativeEventClient(new GooglePlayGames.Native.PInvoke.EventManager(this.mServices));
            this.mQuestsClient = (IQuestsClient) new NativeQuestClient(new GooglePlayGames.Native.PInvoke.QuestManager(this.mServices));
            this.mTurnBasedClient = new NativeTurnBasedMultiplayerClient(this, new TurnBasedManager(this.mServices));
            this.mTurnBasedClient.RegisterMatchDelegate(this.mConfiguration.MatchDelegate);
            this.mRealTimeClient = new NativeRealtimeMultiplayerClient(this, new RealtimeManager(this.mServices));
            this.mSavedGameClient = !this.mConfiguration.EnableSavedGames ? (ISavedGameClient) new UnsupportedSavedGamesClient("You must enable saved games before it can be used. See PlayGamesClientConfiguration.Builder.EnableSavedGames.") : (ISavedGameClient) new NativeSavedGameClient(new GooglePlayGames.Native.PInvoke.SnapshotManager(this.mServices));
            this.mAuthState = NativeClient.AuthState.SilentPending;
            this.mTokenClient = this.clientImpl.CreateTokenClient(this.mUser != null ? this.mUser.id : (string) null, false);
          }
        }
      }
    }

    internal void HandleInvitation(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string invitationId, GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CHandleInvitation\u003Ec__AnonStorey3 invitationCAnonStorey3 = new NativeClient.\u003CHandleInvitation\u003Ec__AnonStorey3();
      // ISSUE: reference to a compiler-generated field
      invitationCAnonStorey3.currentHandler = this.mInvitationDelegate;
      // ISSUE: reference to a compiler-generated field
      if (invitationCAnonStorey3.currentHandler == null)
        GooglePlayGames.OurUtils.Logger.d("Received " + (object) eventType + " for invitation " + invitationId + " but no handler was registered.");
      else if (eventType == GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent.REMOVED)
      {
        GooglePlayGames.OurUtils.Logger.d("Ignoring REMOVED for invitation " + invitationId);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        invitationCAnonStorey3.shouldAutolaunch = eventType == GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent.UPDATED_FROM_APP_LAUNCH;
        // ISSUE: reference to a compiler-generated field
        invitationCAnonStorey3.invite = invitation.AsInvitation();
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(invitationCAnonStorey3.\u003C\u003Em__0));
      }
    }

    public string GetUserEmail()
    {
      if (!this.IsAuthenticated())
      {
        Debug.Log((object) "Cannot get API client - not authenticated");
        return (string) null;
      }
      this.mTokenClient.SetRationale(this.rationale);
      return this.mTokenClient.GetEmail();
    }

    public void GetUserEmail(Action<CommonStatusCodes, string> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CGetUserEmail\u003Ec__AnonStorey4 emailCAnonStorey4 = new NativeClient.\u003CGetUserEmail\u003Ec__AnonStorey4();
      // ISSUE: reference to a compiler-generated field
      emailCAnonStorey4.callback = callback;
      if (!this.IsAuthenticated())
      {
        Debug.Log((object) "Cannot get API client - not authenticated");
        // ISSUE: reference to a compiler-generated field
        if (emailCAnonStorey4.callback != null)
        {
          // ISSUE: reference to a compiler-generated method
          PlayGamesHelperObject.RunOnGameThread(new Action(emailCAnonStorey4.\u003C\u003Em__0));
          return;
        }
      }
      this.mTokenClient.SetRationale(this.rationale);
      // ISSUE: reference to a compiler-generated method
      this.mTokenClient.GetEmail(new Action<CommonStatusCodes, string>(emailCAnonStorey4.\u003C\u003Em__1));
    }

    [Obsolete("Use GetServerAuthCode() then exchange it for a token")]
    public string GetAccessToken()
    {
      if (!this.IsAuthenticated())
      {
        Debug.Log((object) "Cannot get API client - not authenticated");
        return (string) null;
      }
      if (!GameInfo.WebClientIdInitialized())
      {
        if (this.noWebClientIdWarningCount++ % this.webclientWarningFreq == 0)
        {
          Debug.LogError((object) "Web client ID has not been set, cannot request access token.");
          this.noWebClientIdWarningCount = this.noWebClientIdWarningCount / this.webclientWarningFreq + 1;
        }
        return (string) null;
      }
      this.mTokenClient.SetRationale(this.rationale);
      return this.mTokenClient.GetAccessToken();
    }

    [Obsolete("Use GetServerAuthCode() then exchange it for a token")]
    public void GetIdToken(Action<string> idTokenCallback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CGetIdToken\u003Ec__AnonStorey6 tokenCAnonStorey6 = new NativeClient.\u003CGetIdToken\u003Ec__AnonStorey6();
      // ISSUE: reference to a compiler-generated field
      tokenCAnonStorey6.idTokenCallback = idTokenCallback;
      if (!this.IsAuthenticated())
      {
        Debug.Log((object) "Cannot get API client - not authenticated");
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(tokenCAnonStorey6.\u003C\u003Em__0));
      }
      if (!GameInfo.WebClientIdInitialized())
      {
        if (this.noWebClientIdWarningCount++ % this.webclientWarningFreq == 0)
        {
          Debug.LogError((object) "Web client ID has not been set, cannot request id token.");
          this.noWebClientIdWarningCount = this.noWebClientIdWarningCount / this.webclientWarningFreq + 1;
        }
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(tokenCAnonStorey6.\u003C\u003Em__1));
      }
      this.mTokenClient.SetRationale(this.rationale);
      // ISSUE: reference to a compiler-generated field
      this.mTokenClient.GetIdToken(string.Empty, NativeClient.AsOnGameThreadCallback<string>(tokenCAnonStorey6.idTokenCallback));
    }

    public void GetServerAuthCode(string serverClientId, Action<CommonStatusCodes, string> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.mServices.FetchServerAuthCode(serverClientId, new Action<GooglePlayGames.Native.PInvoke.GameServices.FetchServerAuthCodeResponse>(new NativeClient.\u003CGetServerAuthCode\u003Ec__AnonStorey7()
      {
        callback = callback
      }.\u003C\u003Em__0));
    }

    public bool IsAuthenticated()
    {
      lock (this.AuthStateLock)
        return this.mAuthState == NativeClient.AuthState.Authenticated;
    }

    public void LoadFriends(Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CLoadFriends\u003Ec__AnonStoreyA friendsCAnonStoreyA = new NativeClient.\u003CLoadFriends\u003Ec__AnonStoreyA();
      // ISSUE: reference to a compiler-generated field
      friendsCAnonStoreyA.callback = callback;
      // ISSUE: reference to a compiler-generated field
      friendsCAnonStoreyA.\u0024this = this;
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.d("Cannot loadFriends when not authenticated");
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(friendsCAnonStoreyA.\u003C\u003Em__0));
      }
      else if (this.mFriends != null)
      {
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(friendsCAnonStoreyA.\u003C\u003Em__1));
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mServices.PlayerManager().FetchFriends(new Action<GooglePlayGames.BasicApi.ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>>(friendsCAnonStoreyA.\u003C\u003Em__2));
      }
    }

    public IUserProfile[] GetFriends()
    {
      if (this.mFriends == null && !this.friendsLoading)
      {
        GooglePlayGames.OurUtils.Logger.w("Getting friends before they are loaded!!!");
        this.friendsLoading = true;
        this.LoadFriends((Action<bool>) (ok =>
        {
          GooglePlayGames.OurUtils.Logger.d("loading: " + (object) ok + " mFriends = " + (object) this.mFriends);
          if (!ok)
            GooglePlayGames.OurUtils.Logger.e("Friends list did not load successfully.  Disabling loading until re-authenticated");
          this.friendsLoading = !ok;
        }));
      }
      if (this.mFriends == null)
        return new IUserProfile[0];
      return (IUserProfile[]) this.mFriends.ToArray();
    }

    private void PopulateAchievements(uint authGeneration, GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse response)
    {
      if ((int) authGeneration != (int) this.mAuthGeneration)
      {
        GooglePlayGames.OurUtils.Logger.d("Received achievement callback after signout occurred, ignoring");
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("Populating Achievements, status = " + (object) response.Status());
        lock (this.AuthStateLock)
        {
          if (response.Status() != CommonErrorStatus.ResponseStatus.VALID && response.Status() != CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
          {
            GooglePlayGames.OurUtils.Logger.e("Error retrieving achievements - check the log for more information. Failing signin.");
            Action<bool, string> pendingAuthCallbacks = this.mPendingAuthCallbacks;
            this.mPendingAuthCallbacks = (Action<bool, string>) null;
            if (pendingAuthCallbacks != null)
              NativeClient.InvokeCallbackOnGameThread<bool, string>(pendingAuthCallbacks, false, "Cannot load achievements, Authenication failing");
            this.SignOut();
            return;
          }
          Dictionary<string, GooglePlayGames.BasicApi.Achievement> dictionary = new Dictionary<string, GooglePlayGames.BasicApi.Achievement>();
          foreach (NativeAchievement nativeAchievement in response)
          {
            using (nativeAchievement)
              dictionary[nativeAchievement.Id()] = nativeAchievement.AsAchievement();
          }
          GooglePlayGames.OurUtils.Logger.d("Found " + (object) dictionary.Count + " Achievements");
          this.mAchievements = dictionary;
        }
        GooglePlayGames.OurUtils.Logger.d("Maybe finish for Achievements");
        this.MaybeFinishAuthentication();
      }
    }

    private void MaybeFinishAuthentication()
    {
      Action<bool, string> callback = (Action<bool, string>) null;
      lock (this.AuthStateLock)
      {
        if (this.mUser == null || this.mAchievements == null)
        {
          GooglePlayGames.OurUtils.Logger.d("Auth not finished. User=" + (object) this.mUser + " achievements=" + (object) this.mAchievements);
          return;
        }
        GooglePlayGames.OurUtils.Logger.d("Auth finished. Proceeding.");
        callback = this.mPendingAuthCallbacks;
        this.mPendingAuthCallbacks = (Action<bool, string>) null;
        this.mAuthState = NativeClient.AuthState.Authenticated;
      }
      if (callback == null)
        return;
      GooglePlayGames.OurUtils.Logger.d("Invoking Callbacks: " + (object) callback);
      NativeClient.InvokeCallbackOnGameThread<bool, string>(callback, true, (string) null);
    }

    private void PopulateUser(uint authGeneration, GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse response)
    {
      GooglePlayGames.OurUtils.Logger.d("Populating User");
      if ((int) authGeneration != (int) this.mAuthGeneration)
      {
        GooglePlayGames.OurUtils.Logger.d("Received user callback after signout occurred, ignoring");
      }
      else
      {
        lock (this.AuthStateLock)
        {
          if (response.Status() != CommonErrorStatus.ResponseStatus.VALID && response.Status() != CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
          {
            GooglePlayGames.OurUtils.Logger.e("Error retrieving user, signing out");
            Action<bool, string> pendingAuthCallbacks = this.mPendingAuthCallbacks;
            this.mPendingAuthCallbacks = (Action<bool, string>) null;
            if (pendingAuthCallbacks != null)
              NativeClient.InvokeCallbackOnGameThread<bool, string>(pendingAuthCallbacks, false, "Cannot load user profile");
            this.SignOut();
            return;
          }
          this.mUser = response.Self().AsPlayer();
          this.mFriends = (List<GooglePlayGames.BasicApi.Multiplayer.Player>) null;
          this.mTokenClient = this.clientImpl.CreateTokenClient(this.mUser.id, true);
        }
        GooglePlayGames.OurUtils.Logger.d("Found User: " + (object) this.mUser);
        GooglePlayGames.OurUtils.Logger.d("Maybe finish for User");
        this.MaybeFinishAuthentication();
      }
    }

    private void HandleAuthTransition(GooglePlayGames.Native.Cwrapper.Types.AuthOperation operation, CommonErrorStatus.AuthStatus status)
    {
      GooglePlayGames.OurUtils.Logger.d("Starting Auth Transition. Op: " + (object) operation + " status: " + (object) status);
      lock (this.AuthStateLock)
      {
        if (operation != GooglePlayGames.Native.Cwrapper.Types.AuthOperation.SIGN_IN)
        {
          if (operation == GooglePlayGames.Native.Cwrapper.Types.AuthOperation.SIGN_OUT)
            this.ToUnauthenticated();
          else
            GooglePlayGames.OurUtils.Logger.e("Unknown AuthOperation " + (object) operation);
        }
        else if (status == CommonErrorStatus.AuthStatus.VALID)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          NativeClient.\u003CHandleAuthTransition\u003Ec__AnonStoreyB transitionCAnonStoreyB = new NativeClient.\u003CHandleAuthTransition\u003Ec__AnonStoreyB();
          // ISSUE: reference to a compiler-generated field
          transitionCAnonStoreyB.\u0024this = this;
          if (this.mSilentAuthCallbacks != null)
          {
            this.mPendingAuthCallbacks += this.mSilentAuthCallbacks;
            this.mSilentAuthCallbacks = (Action<bool, string>) null;
          }
          // ISSUE: reference to a compiler-generated field
          transitionCAnonStoreyB.currentAuthGeneration = this.mAuthGeneration;
          // ISSUE: reference to a compiler-generated method
          this.mServices.AchievementManager().FetchAll(new Action<GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse>(transitionCAnonStoreyB.\u003C\u003Em__0));
          // ISSUE: reference to a compiler-generated method
          this.mServices.PlayerManager().FetchSelf(new Action<GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse>(transitionCAnonStoreyB.\u003C\u003Em__1));
        }
        else if (this.mAuthState == NativeClient.AuthState.SilentPending)
        {
          this.mSilentAuthFailed = true;
          this.mAuthState = NativeClient.AuthState.Unauthenticated;
          Action<bool, string> silentAuthCallbacks = this.mSilentAuthCallbacks;
          this.mSilentAuthCallbacks = (Action<bool, string>) null;
          GooglePlayGames.OurUtils.Logger.d("Invoking callbacks, AuthState changed from silentPending to Unauthenticated.");
          NativeClient.InvokeCallbackOnGameThread<bool, string>(silentAuthCallbacks, false, "silent auth failed");
          if (this.mPendingAuthCallbacks == null)
            return;
          GooglePlayGames.OurUtils.Logger.d("there are pending auth callbacks - starting AuthUI");
          this.GameServices().StartAuthorizationUI();
        }
        else
        {
          GooglePlayGames.OurUtils.Logger.d("AuthState == " + (object) this.mAuthState + " calling auth callbacks with failure");
          this.UnpauseUnityPlayer();
          Action<bool, string> pendingAuthCallbacks = this.mPendingAuthCallbacks;
          this.mPendingAuthCallbacks = (Action<bool, string>) null;
          NativeClient.InvokeCallbackOnGameThread<bool, string>(pendingAuthCallbacks, false, "Authentication failed");
        }
      }
    }

    private void UnpauseUnityPlayer()
    {
    }

    private void ToUnauthenticated()
    {
      lock (this.AuthStateLock)
      {
        this.mUser = (GooglePlayGames.BasicApi.Multiplayer.Player) null;
        this.mFriends = (List<GooglePlayGames.BasicApi.Multiplayer.Player>) null;
        this.mAchievements = (Dictionary<string, GooglePlayGames.BasicApi.Achievement>) null;
        this.mAuthState = NativeClient.AuthState.Unauthenticated;
        this.mTokenClient = this.clientImpl.CreateTokenClient((string) null, true);
        ++this.mAuthGeneration;
      }
    }

    public void SignOut()
    {
      this.ToUnauthenticated();
      if (this.GameServices() == null)
        return;
      this.GameServices().SignOut();
    }

    public string GetUserId()
    {
      if (this.mUser == null)
        return (string) null;
      return this.mUser.id;
    }

    public string GetUserDisplayName()
    {
      if (this.mUser == null)
        return (string) null;
      return this.mUser.userName;
    }

    public string GetUserImageUrl()
    {
      if (this.mUser == null)
        return (string) null;
      return this.mUser.AvatarURL;
    }

    public void GetPlayerStats(Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      PlayGamesHelperObject.RunOnGameThread(new Action(new NativeClient.\u003CGetPlayerStats\u003Ec__AnonStoreyC()
      {
        callback = callback,
        \u0024this = this
      }.\u003C\u003Em__0));
    }

    public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.mServices.PlayerManager().FetchList(userIds, new Action<NativePlayer[]>(new NativeClient.\u003CLoadUsers\u003Ec__AnonStoreyD()
      {
        callback = callback
      }.\u003C\u003Em__0));
    }

    public GooglePlayGames.BasicApi.Achievement GetAchievement(string achId)
    {
      if (this.mAchievements == null || !this.mAchievements.ContainsKey(achId))
        return (GooglePlayGames.BasicApi.Achievement) null;
      return this.mAchievements[achId];
    }

    public void LoadAchievements(Action<GooglePlayGames.BasicApi.Achievement[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CLoadAchievements\u003Ec__AnonStoreyF achievementsCAnonStoreyF = new NativeClient.\u003CLoadAchievements\u003Ec__AnonStoreyF();
      // ISSUE: reference to a compiler-generated field
      achievementsCAnonStoreyF.callback = callback;
      // ISSUE: reference to a compiler-generated field
      achievementsCAnonStoreyF.data = new GooglePlayGames.BasicApi.Achievement[this.mAchievements.Count];
      // ISSUE: reference to a compiler-generated field
      this.mAchievements.Values.CopyTo(achievementsCAnonStoreyF.data, 0);
      // ISSUE: reference to a compiler-generated method
      PlayGamesHelperObject.RunOnGameThread(new Action(achievementsCAnonStoreyF.\u003C\u003Em__0));
    }

    public void UnlockAchievement(string achId, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CUnlockAchievement\u003Ec__AnonStorey10 achievementCAnonStorey10 = new NativeClient.\u003CUnlockAchievement\u003Ec__AnonStorey10();
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey10.achId = achId;
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey10.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.UpdateAchievement("Unlock", achievementCAnonStorey10.achId, callback, (Predicate<GooglePlayGames.BasicApi.Achievement>) (a => a.IsUnlocked), new Action<GooglePlayGames.BasicApi.Achievement>(achievementCAnonStorey10.\u003C\u003Em__0));
    }

    public void RevealAchievement(string achId, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CRevealAchievement\u003Ec__AnonStorey11 achievementCAnonStorey11 = new NativeClient.\u003CRevealAchievement\u003Ec__AnonStorey11();
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey11.achId = achId;
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey11.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.UpdateAchievement("Reveal", achievementCAnonStorey11.achId, callback, (Predicate<GooglePlayGames.BasicApi.Achievement>) (a => a.IsRevealed), new Action<GooglePlayGames.BasicApi.Achievement>(achievementCAnonStorey11.\u003C\u003Em__0));
    }

    private void UpdateAchievement(string updateType, string achId, Action<bool> callback, Predicate<GooglePlayGames.BasicApi.Achievement> alreadyDone, Action<GooglePlayGames.BasicApi.Achievement> updateAchievment)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CUpdateAchievement\u003Ec__AnonStorey12 achievementCAnonStorey12 = new NativeClient.\u003CUpdateAchievement\u003Ec__AnonStorey12();
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey12.achId = achId;
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey12.callback = callback;
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey12.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey12.callback = NativeClient.AsOnGameThreadCallback<bool>(achievementCAnonStorey12.callback);
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<string>(achievementCAnonStorey12.achId);
      this.InitializeGameServices();
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.BasicApi.Achievement achievement = this.GetAchievement(achievementCAnonStorey12.achId);
      if (achievement == null)
      {
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.d("Could not " + updateType + ", no achievement with ID " + achievementCAnonStorey12.achId);
        // ISSUE: reference to a compiler-generated field
        achievementCAnonStorey12.callback(false);
      }
      else if (alreadyDone(achievement))
      {
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.d("Did not need to perform " + updateType + ": on achievement " + achievementCAnonStorey12.achId);
        // ISSUE: reference to a compiler-generated field
        achievementCAnonStorey12.callback(true);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.d("Performing " + updateType + " on " + achievementCAnonStorey12.achId);
        updateAchievment(achievement);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        this.GameServices().AchievementManager().Fetch(achievementCAnonStorey12.achId, new Action<GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse>(achievementCAnonStorey12.\u003C\u003Em__0));
      }
    }

    public void IncrementAchievement(string achId, int steps, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CIncrementAchievement\u003Ec__AnonStorey13 achievementCAnonStorey13 = new NativeClient.\u003CIncrementAchievement\u003Ec__AnonStorey13();
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey13.achId = achId;
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey13.callback = callback;
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey13.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<string>(achievementCAnonStorey13.achId);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      achievementCAnonStorey13.callback = NativeClient.AsOnGameThreadCallback<bool>(achievementCAnonStorey13.callback);
      this.InitializeGameServices();
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.BasicApi.Achievement achievement = this.GetAchievement(achievementCAnonStorey13.achId);
      if (achievement == null)
      {
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.e("Could not increment, no achievement with ID " + achievementCAnonStorey13.achId);
        // ISSUE: reference to a compiler-generated field
        achievementCAnonStorey13.callback(false);
      }
      else if (!achievement.IsIncremental)
      {
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.e("Could not increment, achievement with ID " + achievementCAnonStorey13.achId + " was not incremental");
        // ISSUE: reference to a compiler-generated field
        achievementCAnonStorey13.callback(false);
      }
      else if (steps < 0)
      {
        GooglePlayGames.OurUtils.Logger.e("Attempted to increment by negative steps");
        // ISSUE: reference to a compiler-generated field
        achievementCAnonStorey13.callback(false);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.GameServices().AchievementManager().Increment(achievementCAnonStorey13.achId, Convert.ToUInt32(steps));
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        this.GameServices().AchievementManager().Fetch(achievementCAnonStorey13.achId, new Action<GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse>(achievementCAnonStorey13.\u003C\u003Em__0));
      }
    }

    public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CSetStepsAtLeast\u003Ec__AnonStorey14 leastCAnonStorey14 = new NativeClient.\u003CSetStepsAtLeast\u003Ec__AnonStorey14();
      // ISSUE: reference to a compiler-generated field
      leastCAnonStorey14.achId = achId;
      // ISSUE: reference to a compiler-generated field
      leastCAnonStorey14.callback = callback;
      // ISSUE: reference to a compiler-generated field
      leastCAnonStorey14.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<string>(leastCAnonStorey14.achId);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      leastCAnonStorey14.callback = NativeClient.AsOnGameThreadCallback<bool>(leastCAnonStorey14.callback);
      this.InitializeGameServices();
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.BasicApi.Achievement achievement = this.GetAchievement(leastCAnonStorey14.achId);
      if (achievement == null)
      {
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.e("Could not increment, no achievement with ID " + leastCAnonStorey14.achId);
        // ISSUE: reference to a compiler-generated field
        leastCAnonStorey14.callback(false);
      }
      else if (!achievement.IsIncremental)
      {
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.e("Could not increment, achievement with ID " + leastCAnonStorey14.achId + " is not incremental");
        // ISSUE: reference to a compiler-generated field
        leastCAnonStorey14.callback(false);
      }
      else if (steps < 0)
      {
        GooglePlayGames.OurUtils.Logger.e("Attempted to increment by negative steps");
        // ISSUE: reference to a compiler-generated field
        leastCAnonStorey14.callback(false);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.GameServices().AchievementManager().SetStepsAtLeast(leastCAnonStorey14.achId, Convert.ToUInt32(steps));
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        this.GameServices().AchievementManager().Fetch(leastCAnonStorey14.achId, new Action<GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse>(leastCAnonStorey14.\u003C\u003Em__0));
      }
    }

    public void ShowAchievementsUI(Action<GooglePlayGames.BasicApi.UIStatus> cb)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CShowAchievementsUI\u003Ec__AnonStorey15 achievementsUiCAnonStorey15 = new NativeClient.\u003CShowAchievementsUI\u003Ec__AnonStorey15();
      // ISSUE: reference to a compiler-generated field
      achievementsUiCAnonStorey15.cb = cb;
      if (!this.IsAuthenticated())
        return;
      Action<CommonErrorStatus.UIStatus> callback = Callbacks.NoopUICallback;
      // ISSUE: reference to a compiler-generated field
      if (achievementsUiCAnonStorey15.cb != null)
      {
        // ISSUE: reference to a compiler-generated method
        callback = new Action<CommonErrorStatus.UIStatus>(achievementsUiCAnonStorey15.\u003C\u003Em__0);
      }
      this.GameServices().AchievementManager().ShowAllUI(NativeClient.AsOnGameThreadCallback<CommonErrorStatus.UIStatus>(callback));
    }

    public int LeaderboardMaxResults()
    {
      return this.GameServices().LeaderboardManager().LeaderboardMaxResults;
    }

    public void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, Action<GooglePlayGames.BasicApi.UIStatus> cb)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CShowLeaderboardUI\u003Ec__AnonStorey16 leaderboardUiCAnonStorey16 = new NativeClient.\u003CShowLeaderboardUI\u003Ec__AnonStorey16();
      // ISSUE: reference to a compiler-generated field
      leaderboardUiCAnonStorey16.cb = cb;
      if (!this.IsAuthenticated())
        return;
      Action<CommonErrorStatus.UIStatus> callback1 = Callbacks.NoopUICallback;
      // ISSUE: reference to a compiler-generated field
      if (leaderboardUiCAnonStorey16.cb != null)
      {
        // ISSUE: reference to a compiler-generated method
        callback1 = new Action<CommonErrorStatus.UIStatus>(leaderboardUiCAnonStorey16.\u003C\u003Em__0);
      }
      Action<CommonErrorStatus.UIStatus> callback2 = NativeClient.AsOnGameThreadCallback<CommonErrorStatus.UIStatus>(callback1);
      if (leaderboardId == null)
        this.GameServices().LeaderboardManager().ShowAllUI(callback2);
      else
        this.GameServices().LeaderboardManager().ShowUI(leaderboardId, span, callback2);
    }

    public void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
    {
      callback = NativeClient.AsOnGameThreadCallback<LeaderboardScoreData>(callback);
      this.GameServices().LeaderboardManager().LoadLeaderboardData(leaderboardId, start, rowCount, collection, timeSpan, this.mUser.id, callback);
    }

    public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
    {
      callback = NativeClient.AsOnGameThreadCallback<LeaderboardScoreData>(callback);
      this.GameServices().LeaderboardManager().LoadScorePage((LeaderboardScoreData) null, rowCount, token, callback);
    }

    public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
    {
      callback = NativeClient.AsOnGameThreadCallback<bool>(callback);
      if (!this.IsAuthenticated())
        callback(false);
      this.InitializeGameServices();
      if (leaderboardId == null)
        throw new ArgumentNullException("leaderboardId");
      this.GameServices().LeaderboardManager().SubmitScore(leaderboardId, score, (string) null);
      callback(true);
    }

    public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
    {
      callback = NativeClient.AsOnGameThreadCallback<bool>(callback);
      if (!this.IsAuthenticated())
        callback(false);
      this.InitializeGameServices();
      if (leaderboardId == null)
        throw new ArgumentNullException("leaderboardId");
      this.GameServices().LeaderboardManager().SubmitScore(leaderboardId, score, metadata);
      callback(true);
    }

    public IRealTimeMultiplayerClient GetRtmpClient()
    {
      if (!this.IsAuthenticated())
        return (IRealTimeMultiplayerClient) null;
      lock (this.GameServicesLock)
        return (IRealTimeMultiplayerClient) this.mRealTimeClient;
    }

    public ITurnBasedMultiplayerClient GetTbmpClient()
    {
      lock (this.GameServicesLock)
        return (ITurnBasedMultiplayerClient) this.mTurnBasedClient;
    }

    public ISavedGameClient GetSavedGameClient()
    {
      lock (this.GameServicesLock)
        return this.mSavedGameClient;
    }

    public IEventsClient GetEventsClient()
    {
      lock (this.GameServicesLock)
        return this.mEventsClient;
    }

    public IQuestsClient GetQuestsClient()
    {
      lock (this.GameServicesLock)
        return this.mQuestsClient;
    }

    public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeClient.\u003CRegisterInvitationDelegate\u003Ec__AnonStorey17 delegateCAnonStorey17 = new NativeClient.\u003CRegisterInvitationDelegate\u003Ec__AnonStorey17();
      // ISSUE: reference to a compiler-generated field
      delegateCAnonStorey17.invitationDelegate = invitationDelegate;
      // ISSUE: reference to a compiler-generated field
      if (delegateCAnonStorey17.invitationDelegate == null)
      {
        this.mInvitationDelegate = (Action<Invitation, bool>) null;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mInvitationDelegate = Callbacks.AsOnGameThreadCallback<Invitation, bool>(new Action<Invitation, bool>(delegateCAnonStorey17.\u003C\u003Em__0));
      }
    }

    public string GetToken()
    {
      if (this.mTokenClient != null)
        return this.mTokenClient.GetAccessToken();
      return (string) null;
    }

    public IntPtr GetApiClient()
    {
      return InternalHooks.InternalHooks_GetApiClient(this.mServices.AsHandle());
    }

    private enum AuthState
    {
      Unauthenticated,
      Authenticated,
      SilentPending,
    }
  }
}
