// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.PlayGamesPlatform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.Quests;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
  public class PlayGamesPlatform : ISocialPlatform
  {
    private Dictionary<string, string> mIdMap = new Dictionary<string, string>();
    private static volatile PlayGamesPlatform sInstance;
    private static volatile bool sNearbyInitializePending;
    private static volatile INearbyConnectionClient sNearbyConnectionClient;
    private readonly PlayGamesClientConfiguration mConfiguration;
    private PlayGamesLocalUser mLocalUser;
    private IPlayGamesClient mClient;
    private string mDefaultLbUi;

    public static bool DebugLogEnabled
    {
      get
      {
        return GooglePlayGames.OurUtils.Logger.DebugLogEnabled;
      }
      set
      {
        GooglePlayGames.OurUtils.Logger.DebugLogEnabled = value;
      }
    }

    public static PlayGamesPlatform Instance
    {
      get
      {
        if (PlayGamesPlatform.sInstance == null)
        {
          GooglePlayGames.OurUtils.Logger.d("Instance was not initialized, using default configuration.");
          PlayGamesPlatform.InitializeInstance(PlayGamesClientConfiguration.DefaultConfiguration);
        }
        return PlayGamesPlatform.sInstance;
      }
    }

    public static INearbyConnectionClient Nearby
    {
      get
      {
        if (PlayGamesPlatform.sNearbyConnectionClient == null && !PlayGamesPlatform.sNearbyInitializePending)
        {
          PlayGamesPlatform.sNearbyInitializePending = true;
          PlayGamesPlatform.InitializeNearby((Action<INearbyConnectionClient>) null);
        }
        return PlayGamesPlatform.sNearbyConnectionClient;
      }
    }

    public IRealTimeMultiplayerClient RealTime
    {
      get
      {
        return this.mClient.GetRtmpClient();
      }
    }

    public ITurnBasedMultiplayerClient TurnBased
    {
      get
      {
        return this.mClient.GetTbmpClient();
      }
    }

    public ISavedGameClient SavedGame
    {
      get
      {
        return this.mClient.GetSavedGameClient();
      }
    }

    public IEventsClient Events
    {
      get
      {
        return this.mClient.GetEventsClient();
      }
    }

    public IQuestsClient Quests
    {
      get
      {
        return this.mClient.GetQuestsClient();
      }
    }

    public ILocalUser localUser
    {
      get
      {
        return (ILocalUser) this.mLocalUser;
      }
    }

    internal PlayGamesPlatform(IPlayGamesClient client)
    {
      this.mClient = Misc.CheckNotNull<IPlayGamesClient>(client);
      this.mLocalUser = new PlayGamesLocalUser(this);
      this.mConfiguration = PlayGamesClientConfiguration.DefaultConfiguration;
    }

    private PlayGamesPlatform(PlayGamesClientConfiguration configuration)
    {
      this.mLocalUser = new PlayGamesLocalUser(this);
      this.mConfiguration = configuration;
    }

    public static void InitializeInstance(PlayGamesClientConfiguration configuration)
    {
      if (PlayGamesPlatform.sInstance != null)
        GooglePlayGames.OurUtils.Logger.w("PlayGamesPlatform already initialized. Ignoring this call.");
      else
        PlayGamesPlatform.sInstance = new PlayGamesPlatform(configuration);
    }

    public static void InitializeNearby(Action<INearbyConnectionClient> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlayGamesPlatform.\u003CInitializeNearby\u003Ec__AnonStorey0 nearbyCAnonStorey0 = new PlayGamesPlatform.\u003CInitializeNearby\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      nearbyCAnonStorey0.callback = callback;
      Debug.Log((object) "Calling InitializeNearby!");
      if (PlayGamesPlatform.sNearbyConnectionClient == null)
      {
        // ISSUE: reference to a compiler-generated method
        NearbyConnectionClientFactory.Create(new Action<INearbyConnectionClient>(nearbyCAnonStorey0.\u003C\u003Em__0));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (nearbyCAnonStorey0.callback != null)
        {
          Debug.Log((object) "Nearby Already initialized: calling callback directly");
          // ISSUE: reference to a compiler-generated field
          nearbyCAnonStorey0.callback(PlayGamesPlatform.sNearbyConnectionClient);
        }
        else
          Debug.Log((object) "Nearby Already initialized");
      }
    }

    public static PlayGamesPlatform Activate()
    {
      GooglePlayGames.OurUtils.Logger.d("Activating PlayGamesPlatform.");
      Social.Active = (ISocialPlatform) PlayGamesPlatform.Instance;
      GooglePlayGames.OurUtils.Logger.d("PlayGamesPlatform activated: " + (object) Social.Active);
      return PlayGamesPlatform.Instance;
    }

    public IntPtr GetApiClient()
    {
      return this.mClient.GetApiClient();
    }

    public void AddIdMapping(string fromId, string toId)
    {
      this.mIdMap[fromId] = toId;
    }

    public void Authenticate(Action<bool> callback)
    {
      this.Authenticate(callback, false);
    }

    public void Authenticate(Action<bool, string> callback)
    {
      this.Authenticate(callback, false);
    }

    public void Authenticate(Action<bool> callback, bool silent)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.Authenticate(new Action<bool, string>(new PlayGamesPlatform.\u003CAuthenticate\u003Ec__AnonStorey1()
      {
        callback = callback
      }.\u003C\u003Em__0), silent);
    }

    public void Authenticate(Action<bool, string> callback, bool silent)
    {
      if (this.mClient == null)
      {
        GooglePlayGames.OurUtils.Logger.d("Creating platform-specific Play Games client.");
        this.mClient = PlayGamesClientFactory.GetPlatformPlayGamesClient(this.mConfiguration);
      }
      this.mClient.Authenticate(callback, silent);
    }

    public void Authenticate(ILocalUser unused, Action<bool> callback)
    {
      this.Authenticate(callback, false);
    }

    public void Authenticate(ILocalUser unused, Action<bool, string> callback)
    {
      this.Authenticate(callback, false);
    }

    public bool IsAuthenticated()
    {
      if (this.mClient != null)
        return this.mClient.IsAuthenticated();
      return false;
    }

    public void SignOut()
    {
      if (this.mClient != null)
        this.mClient.SignOut();
      this.mLocalUser = new PlayGamesLocalUser(this);
    }

    public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("GetUserId() can only be called after authentication.");
        callback(new IUserProfile[0]);
      }
      else
        this.mClient.LoadUsers(userIds, callback);
    }

    public string GetUserId()
    {
      if (this.IsAuthenticated())
        return this.mClient.GetUserId();
      GooglePlayGames.OurUtils.Logger.e("GetUserId() can only be called after authentication.");
      return "0";
    }

    public void GetIdToken(Action<string> idTokenCallback)
    {
      if (this.mClient != null)
      {
        this.mClient.GetIdToken(idTokenCallback);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.e("No client available, calling back with null.");
        idTokenCallback((string) null);
      }
    }

    public string GetAccessToken()
    {
      if (this.mClient != null)
        return this.mClient.GetAccessToken();
      return (string) null;
    }

    public void GetServerAuthCode(Action<CommonStatusCodes, string> callback)
    {
      if (this.mClient != null && this.mClient.IsAuthenticated())
      {
        if (GameInfo.WebClientIdInitialized())
        {
          this.mClient.GetServerAuthCode(string.Empty, callback);
        }
        else
        {
          GooglePlayGames.OurUtils.Logger.e("GetServerAuthCode requires a webClientId.");
          callback(CommonStatusCodes.DeveloperError, string.Empty);
        }
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.e("GetServerAuthCode can only be called after authentication.");
        callback(CommonStatusCodes.SignInRequired, string.Empty);
      }
    }

    public string GetUserEmail()
    {
      if (this.mClient != null)
        return this.mClient.GetUserEmail();
      return (string) null;
    }

    public void GetUserEmail(Action<CommonStatusCodes, string> callback)
    {
      this.mClient.GetUserEmail(callback);
    }

    public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
    {
      if (this.mClient != null && this.mClient.IsAuthenticated())
      {
        this.mClient.GetPlayerStats(callback);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.e("GetPlayerStats can only be called after authentication.");
        callback(CommonStatusCodes.SignInRequired, new PlayerStats());
      }
    }

    public Achievement GetAchievement(string achievementId)
    {
      if (this.IsAuthenticated())
        return this.mClient.GetAchievement(achievementId);
      GooglePlayGames.OurUtils.Logger.e("GetAchievement can only be called after authentication.");
      return (Achievement) null;
    }

    public string GetUserDisplayName()
    {
      if (this.IsAuthenticated())
        return this.mClient.GetUserDisplayName();
      GooglePlayGames.OurUtils.Logger.e("GetUserDisplayName can only be called after authentication.");
      return string.Empty;
    }

    public string GetUserImageUrl()
    {
      if (this.IsAuthenticated())
        return this.mClient.GetUserImageUrl();
      GooglePlayGames.OurUtils.Logger.e("GetUserImageUrl can only be called after authentication.");
      return (string) null;
    }

    public void ReportProgress(string achievementID, double progress, Action<bool> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("ReportProgress can only be called after authentication.");
        if (callback == null)
          return;
        callback(false);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("ReportProgress, " + achievementID + ", " + (object) progress);
        achievementID = this.MapId(achievementID);
        if (progress < 1E-06)
        {
          GooglePlayGames.OurUtils.Logger.d("Progress 0.00 interpreted as request to reveal.");
          this.mClient.RevealAchievement(achievementID, callback);
        }
        else
        {
          int num1 = 0;
          int num2 = 0;
          Achievement achievement = this.mClient.GetAchievement(achievementID);
          bool flag;
          if (achievement == null)
          {
            GooglePlayGames.OurUtils.Logger.w("Unable to locate achievement " + achievementID);
            GooglePlayGames.OurUtils.Logger.w("As a quick fix, assuming it's standard.");
            flag = false;
          }
          else
          {
            flag = achievement.IsIncremental;
            num1 = achievement.CurrentSteps;
            num2 = achievement.TotalSteps;
            GooglePlayGames.OurUtils.Logger.d("Achievement is " + (!flag ? "STANDARD" : "INCREMENTAL"));
            if (flag)
              GooglePlayGames.OurUtils.Logger.d("Current steps: " + (object) num1 + "/" + (object) num2);
          }
          if (flag)
          {
            GooglePlayGames.OurUtils.Logger.d("Progress " + (object) progress + " interpreted as incremental target (approximate).");
            if (progress >= 0.0 && progress <= 1.0)
              GooglePlayGames.OurUtils.Logger.w("Progress " + (object) progress + " is less than or equal to 1. You might be trying to use values in the range of [0,1], while values are expected to be within the range [0,100]. If you are using the latter, you can safely ignore this message.");
            int num3 = (int) Math.Round(progress / 100.0 * (double) num2);
            int steps = num3 - num1;
            GooglePlayGames.OurUtils.Logger.d("Target steps: " + (object) num3 + ", cur steps:" + (object) num1);
            GooglePlayGames.OurUtils.Logger.d("Steps to increment: " + (object) steps);
            if (steps < 0)
              return;
            this.mClient.IncrementAchievement(achievementID, steps, callback);
          }
          else if (progress >= 100.0)
          {
            GooglePlayGames.OurUtils.Logger.d("Progress " + (object) progress + " interpreted as UNLOCK.");
            this.mClient.UnlockAchievement(achievementID, callback);
          }
          else
            GooglePlayGames.OurUtils.Logger.d("Progress " + (object) progress + " not enough to unlock non-incremental achievement.");
        }
      }
    }

    public void IncrementAchievement(string achievementID, int steps, Action<bool> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("IncrementAchievement can only be called after authentication.");
        if (callback == null)
          return;
        callback(false);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("IncrementAchievement: " + achievementID + ", steps " + (object) steps);
        achievementID = this.MapId(achievementID);
        this.mClient.IncrementAchievement(achievementID, steps, callback);
      }
    }

    public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("SetStepsAtLeast can only be called after authentication.");
        if (callback == null)
          return;
        callback(false);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("SetStepsAtLeast: " + achievementID + ", steps " + (object) steps);
        achievementID = this.MapId(achievementID);
        this.mClient.SetStepsAtLeast(achievementID, steps, callback);
      }
    }

    public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlayGamesPlatform.\u003CLoadAchievementDescriptions\u003Ec__AnonStorey2 descriptionsCAnonStorey2 = new PlayGamesPlatform.\u003CLoadAchievementDescriptions\u003Ec__AnonStorey2();
      // ISSUE: reference to a compiler-generated field
      descriptionsCAnonStorey2.callback = callback;
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("LoadAchievementDescriptions can only be called after authentication.");
        // ISSUE: reference to a compiler-generated field
        if (descriptionsCAnonStorey2.callback == null)
          return;
        // ISSUE: reference to a compiler-generated field
        descriptionsCAnonStorey2.callback((IAchievementDescription[]) null);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mClient.LoadAchievements(new Action<Achievement[]>(descriptionsCAnonStorey2.\u003C\u003Em__0));
      }
    }

    public void LoadAchievements(Action<IAchievement[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlayGamesPlatform.\u003CLoadAchievements\u003Ec__AnonStorey3 achievementsCAnonStorey3 = new PlayGamesPlatform.\u003CLoadAchievements\u003Ec__AnonStorey3();
      // ISSUE: reference to a compiler-generated field
      achievementsCAnonStorey3.callback = callback;
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("LoadAchievements can only be called after authentication.");
        // ISSUE: reference to a compiler-generated field
        achievementsCAnonStorey3.callback((IAchievement[]) null);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mClient.LoadAchievements(new Action<Achievement[]>(achievementsCAnonStorey3.\u003C\u003Em__0));
      }
    }

    public IAchievement CreateAchievement()
    {
      return (IAchievement) new PlayGamesAchievement();
    }

    public void ReportScore(long score, string board, Action<bool> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("ReportScore can only be called after authentication.");
        if (callback == null)
          return;
        callback(false);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("ReportScore: score=" + (object) score + ", board=" + board);
        this.mClient.SubmitScore(this.MapId(board), score, callback);
      }
    }

    public void ReportScore(long score, string board, string metadata, Action<bool> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("ReportScore can only be called after authentication.");
        if (callback == null)
          return;
        callback(false);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("ReportScore: score=" + (object) score + ", board=" + board + " metadata=" + metadata);
        this.mClient.SubmitScore(this.MapId(board), score, metadata, callback);
      }
    }

    public void LoadScores(string leaderboardId, Action<IScore[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.LoadScores(leaderboardId, LeaderboardStart.PlayerCentered, this.mClient.LeaderboardMaxResults(), LeaderboardCollection.Public, LeaderboardTimeSpan.AllTime, new Action<LeaderboardScoreData>(new PlayGamesPlatform.\u003CLoadScores\u003Ec__AnonStorey4()
      {
        callback = callback
      }.\u003C\u003Em__0));
    }

    public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("LoadScores can only be called after authentication.");
        callback(new LeaderboardScoreData(leaderboardId, ResponseStatus.NotAuthorized));
      }
      else
        this.mClient.LoadScores(leaderboardId, start, rowCount, collection, timeSpan, callback);
    }

    public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("LoadMoreScores can only be called after authentication.");
        callback(new LeaderboardScoreData(token.LeaderboardId, ResponseStatus.NotAuthorized));
      }
      else
        this.mClient.LoadMoreScores(token, rowCount, callback);
    }

    public ILeaderboard CreateLeaderboard()
    {
      return (ILeaderboard) new PlayGamesLeaderboard(this.mDefaultLbUi);
    }

    public void ShowAchievementsUI()
    {
      this.ShowAchievementsUI((Action<UIStatus>) null);
    }

    public void ShowAchievementsUI(Action<UIStatus> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("ShowAchievementsUI can only be called after authentication.");
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("ShowAchievementsUI callback is " + (object) callback);
        this.mClient.ShowAchievementsUI(callback);
      }
    }

    public void ShowLeaderboardUI()
    {
      GooglePlayGames.OurUtils.Logger.d("ShowLeaderboardUI with default ID");
      this.ShowLeaderboardUI(this.MapId(this.mDefaultLbUi), (Action<UIStatus>) null);
    }

    public void ShowLeaderboardUI(string leaderboardId)
    {
      if (leaderboardId != null)
        leaderboardId = this.MapId(leaderboardId);
      this.mClient.ShowLeaderboardUI(leaderboardId, LeaderboardTimeSpan.AllTime, (Action<UIStatus>) null);
    }

    public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback)
    {
      this.ShowLeaderboardUI(leaderboardId, LeaderboardTimeSpan.AllTime, callback);
    }

    public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("ShowLeaderboardUI can only be called after authentication.");
        if (callback == null)
          return;
        callback(UIStatus.NotAuthorized);
      }
      else
      {
        GooglePlayGames.OurUtils.Logger.d("ShowLeaderboardUI, lbId=" + leaderboardId + " callback is " + (object) callback);
        this.mClient.ShowLeaderboardUI(leaderboardId, span, callback);
      }
    }

    public void SetDefaultLeaderboardForUI(string lbid)
    {
      GooglePlayGames.OurUtils.Logger.d("SetDefaultLeaderboardForUI: " + lbid);
      if (lbid != null)
        lbid = this.MapId(lbid);
      this.mDefaultLbUi = lbid;
    }

    public void LoadFriends(ILocalUser user, Action<bool> callback)
    {
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("LoadScores can only be called after authentication.");
        if (callback == null)
          return;
        callback(false);
      }
      else
        this.mClient.LoadFriends(callback);
    }

    public void LoadScores(ILeaderboard board, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlayGamesPlatform.\u003CLoadScores\u003Ec__AnonStorey5 scoresCAnonStorey5 = new PlayGamesPlatform.\u003CLoadScores\u003Ec__AnonStorey5();
      // ISSUE: reference to a compiler-generated field
      scoresCAnonStorey5.board = board;
      // ISSUE: reference to a compiler-generated field
      scoresCAnonStorey5.callback = callback;
      // ISSUE: reference to a compiler-generated field
      scoresCAnonStorey5.\u0024this = this;
      if (!this.IsAuthenticated())
      {
        GooglePlayGames.OurUtils.Logger.e("LoadScores can only be called after authentication.");
        // ISSUE: reference to a compiler-generated field
        if (scoresCAnonStorey5.callback == null)
          return;
        // ISSUE: reference to a compiler-generated field
        scoresCAnonStorey5.callback(false);
      }
      else
      {
        LeaderboardTimeSpan timeSpan;
        // ISSUE: reference to a compiler-generated field
        switch (scoresCAnonStorey5.board.timeScope)
        {
          case TimeScope.Today:
            timeSpan = LeaderboardTimeSpan.Daily;
            break;
          case TimeScope.Week:
            timeSpan = LeaderboardTimeSpan.Weekly;
            break;
          case TimeScope.AllTime:
            timeSpan = LeaderboardTimeSpan.AllTime;
            break;
          default:
            timeSpan = LeaderboardTimeSpan.AllTime;
            break;
        }
        // ISSUE: reference to a compiler-generated field
        ((PlayGamesLeaderboard) scoresCAnonStorey5.board).loading = true;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.OurUtils.Logger.d("LoadScores, board=" + (object) scoresCAnonStorey5.board + " callback is " + (object) scoresCAnonStorey5.callback);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        this.mClient.LoadScores(scoresCAnonStorey5.board.id, LeaderboardStart.PlayerCentered, scoresCAnonStorey5.board.range.count <= 0 ? this.mClient.LeaderboardMaxResults() : scoresCAnonStorey5.board.range.count, scoresCAnonStorey5.board.userScope != UserScope.FriendsOnly ? LeaderboardCollection.Public : LeaderboardCollection.Social, timeSpan, new Action<LeaderboardScoreData>(scoresCAnonStorey5.\u003C\u003Em__0));
      }
    }

    public bool GetLoading(ILeaderboard board)
    {
      if (board != null)
        return board.loading;
      return false;
    }

    public void RegisterInvitationDelegate(InvitationReceivedDelegate deleg)
    {
      this.mClient.RegisterInvitationDelegate(deleg);
    }

    public string GetToken()
    {
      return this.mClient.GetToken();
    }

    internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlayGamesPlatform.\u003CHandleLoadingScores\u003Ec__AnonStorey6 scoresCAnonStorey6 = new PlayGamesPlatform.\u003CHandleLoadingScores\u003Ec__AnonStorey6();
      // ISSUE: reference to a compiler-generated field
      scoresCAnonStorey6.board = board;
      // ISSUE: reference to a compiler-generated field
      scoresCAnonStorey6.callback = callback;
      // ISSUE: reference to a compiler-generated field
      scoresCAnonStorey6.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      bool flag = scoresCAnonStorey6.board.SetFromData(scoreData);
      // ISSUE: reference to a compiler-generated field
      if (flag && !scoresCAnonStorey6.board.HasAllScores() && scoreData.NextPageToken != null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        int rowCount = scoresCAnonStorey6.board.range.count - scoresCAnonStorey6.board.ScoreCount;
        // ISSUE: reference to a compiler-generated method
        this.mClient.LoadMoreScores(scoreData.NextPageToken, rowCount, new Action<LeaderboardScoreData>(scoresCAnonStorey6.\u003C\u003Em__0));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        scoresCAnonStorey6.callback(flag);
      }
    }

    internal IUserProfile[] GetFriends()
    {
      if (this.IsAuthenticated())
        return this.mClient.GetFriends();
      GooglePlayGames.OurUtils.Logger.d("Cannot get friends when not authenticated!");
      return new IUserProfile[0];
    }

    private string MapId(string id)
    {
      if (id == null)
        return (string) null;
      if (!this.mIdMap.ContainsKey(id))
        return id;
      string mId = this.mIdMap[id];
      GooglePlayGames.OurUtils.Logger.d("Mapping alias " + id + " to ID " + mId);
      return mId;
    }
  }
}
