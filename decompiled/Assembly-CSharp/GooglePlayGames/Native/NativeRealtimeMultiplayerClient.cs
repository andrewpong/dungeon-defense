// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.NativeRealtimeMultiplayerClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GooglePlayGames.Native
{
  public class NativeRealtimeMultiplayerClient : IRealTimeMultiplayerClient
  {
    private readonly object mSessionLock = new object();
    private readonly NativeClient mNativeClient;
    private readonly RealtimeManager mRealtimeManager;
    private volatile NativeRealtimeMultiplayerClient.RoomSession mCurrentSession;

    internal NativeRealtimeMultiplayerClient(NativeClient nativeClient, RealtimeManager manager)
    {
      this.mNativeClient = Misc.CheckNotNull<NativeClient>(nativeClient);
      this.mRealtimeManager = Misc.CheckNotNull<RealtimeManager>(manager);
      this.mCurrentSession = this.GetTerminatedSession();
      PlayGamesHelperObject.AddPauseCallback(new Action<bool>(this.HandleAppPausing));
    }

    private NativeRealtimeMultiplayerClient.RoomSession GetTerminatedSession()
    {
      NativeRealtimeMultiplayerClient.RoomSession session = new NativeRealtimeMultiplayerClient.RoomSession(this.mRealtimeManager, (RealTimeMultiplayerListener) new NativeRealtimeMultiplayerClient.NoopListener());
      session.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ShutdownState(session), false);
      return session;
    }

    public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener)
    {
      this.CreateQuickGame(minOpponents, maxOpponents, variant, 0UL, listener);
    }

    public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener)
    {
      lock (this.mSessionLock)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NativeRealtimeMultiplayerClient.\u003CCreateQuickGame\u003Ec__AnonStorey2 gameCAnonStorey2 = new NativeRealtimeMultiplayerClient.\u003CCreateQuickGame\u003Ec__AnonStorey2();
        // ISSUE: reference to a compiler-generated field
        gameCAnonStorey2.\u0024this = this;
        // ISSUE: reference to a compiler-generated field
        gameCAnonStorey2.newSession = new NativeRealtimeMultiplayerClient.RoomSession(this.mRealtimeManager, listener);
        if (this.mCurrentSession.IsActive())
        {
          Logger.e("Received attempt to create a new room without cleaning up the old one.");
          // ISSUE: reference to a compiler-generated field
          gameCAnonStorey2.newSession.LeaveRoom();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.mCurrentSession = gameCAnonStorey2.newSession;
          Logger.d("QuickGame: Setting MinPlayersToStart = " + (object) minOpponents);
          this.mCurrentSession.MinPlayersToStart = minOpponents;
          using (RealtimeRoomConfigBuilder roomConfigBuilder = RealtimeRoomConfigBuilder.Create())
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            NativeRealtimeMultiplayerClient.\u003CCreateQuickGame\u003Ec__AnonStorey0 gameCAnonStorey0 = new NativeRealtimeMultiplayerClient.\u003CCreateQuickGame\u003Ec__AnonStorey0();
            // ISSUE: reference to a compiler-generated field
            gameCAnonStorey0.config = roomConfigBuilder.SetMinimumAutomatchingPlayers(minOpponents).SetMaximumAutomatchingPlayers(maxOpponents).SetVariant(variant).SetExclusiveBitMask(exclusiveBitMask).Build();
            // ISSUE: reference to a compiler-generated field
            using (gameCAnonStorey0.config)
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              NativeRealtimeMultiplayerClient.\u003CCreateQuickGame\u003Ec__AnonStorey1 gameCAnonStorey1 = new NativeRealtimeMultiplayerClient.\u003CCreateQuickGame\u003Ec__AnonStorey1();
              // ISSUE: reference to a compiler-generated field
              gameCAnonStorey1.\u003C\u003Ef__ref\u00242 = gameCAnonStorey2;
              // ISSUE: reference to a compiler-generated field
              gameCAnonStorey1.\u003C\u003Ef__ref\u00240 = gameCAnonStorey0;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              gameCAnonStorey1.helper = NativeRealtimeMultiplayerClient.HelperForSession(gameCAnonStorey2.newSession);
              try
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                gameCAnonStorey2.newSession.StartRoomCreation(this.mNativeClient.GetUserId(), new Action(gameCAnonStorey1.\u003C\u003Em__0));
              }
              finally
              {
                // ISSUE: reference to a compiler-generated field
                if (gameCAnonStorey1.helper != null)
                {
                  // ISSUE: reference to a compiler-generated field
                  gameCAnonStorey1.helper.Dispose();
                }
              }
            }
          }
        }
      }
    }

    private static GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper HelperForSession(NativeRealtimeMultiplayerClient.RoomSession session)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeRealtimeMultiplayerClient.\u003CHelperForSession\u003Ec__AnonStorey3 sessionCAnonStorey3 = new NativeRealtimeMultiplayerClient.\u003CHelperForSession\u003Ec__AnonStorey3();
      // ISSUE: reference to a compiler-generated field
      sessionCAnonStorey3.session = session;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.Create().SetOnDataReceivedCallback(new Action<NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, byte[], bool>(sessionCAnonStorey3.\u003C\u003Em__0)).SetOnParticipantStatusChangedCallback(new Action<NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant>(sessionCAnonStorey3.\u003C\u003Em__1)).SetOnRoomConnectedSetChangedCallback(new Action<NativeRealTimeRoom>(sessionCAnonStorey3.\u003C\u003Em__2)).SetOnRoomStatusChangedCallback(new Action<NativeRealTimeRoom>(sessionCAnonStorey3.\u003C\u003Em__3));
    }

    private void HandleAppPausing(bool paused)
    {
      if (!paused)
        return;
      Logger.d("Application is pausing, which disconnects the RTMP  client.  Leaving room.");
      this.LeaveRoom();
    }

    public void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, RealTimeMultiplayerListener listener)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeRealtimeMultiplayerClient.\u003CCreateWithInvitationScreen\u003Ec__AnonStorey5 screenCAnonStorey5 = new NativeRealtimeMultiplayerClient.\u003CCreateWithInvitationScreen\u003Ec__AnonStorey5();
      // ISSUE: reference to a compiler-generated field
      screenCAnonStorey5.variant = variant;
      // ISSUE: reference to a compiler-generated field
      screenCAnonStorey5.\u0024this = this;
      lock (this.mSessionLock)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NativeRealtimeMultiplayerClient.\u003CCreateWithInvitationScreen\u003Ec__AnonStorey4 screenCAnonStorey4 = new NativeRealtimeMultiplayerClient.\u003CCreateWithInvitationScreen\u003Ec__AnonStorey4();
        // ISSUE: reference to a compiler-generated field
        screenCAnonStorey4.\u003C\u003Ef__ref\u00245 = screenCAnonStorey5;
        // ISSUE: reference to a compiler-generated field
        screenCAnonStorey4.newRoom = new NativeRealtimeMultiplayerClient.RoomSession(this.mRealtimeManager, listener);
        if (this.mCurrentSession.IsActive())
        {
          Logger.e("Received attempt to create a new room without cleaning up the old one.");
          // ISSUE: reference to a compiler-generated field
          screenCAnonStorey4.newRoom.LeaveRoom();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.mCurrentSession = screenCAnonStorey4.newRoom;
          this.mCurrentSession.ShowingUI = true;
          // ISSUE: reference to a compiler-generated method
          this.mRealtimeManager.ShowPlayerSelectUI(minOpponents, maxOppponents, true, new Action<PlayerSelectUIResponse>(screenCAnonStorey4.\u003C\u003Em__0));
        }
      }
    }

    public void ShowWaitingRoomUI()
    {
      lock (this.mSessionLock)
        this.mCurrentSession.ShowWaitingRoomUI();
    }

    public void GetAllInvitations(Action<Invitation[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.mRealtimeManager.FetchInvitations(new Action<RealtimeManager.FetchInvitationsResponse>(new NativeRealtimeMultiplayerClient.\u003CGetAllInvitations\u003Ec__AnonStorey8()
      {
        callback = callback
      }.\u003C\u003Em__0));
    }

    public void AcceptFromInbox(RealTimeMultiplayerListener listener)
    {
      lock (this.mSessionLock)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NativeRealtimeMultiplayerClient.\u003CAcceptFromInbox\u003Ec__AnonStorey9 inboxCAnonStorey9 = new NativeRealtimeMultiplayerClient.\u003CAcceptFromInbox\u003Ec__AnonStorey9();
        // ISSUE: reference to a compiler-generated field
        inboxCAnonStorey9.\u0024this = this;
        // ISSUE: reference to a compiler-generated field
        inboxCAnonStorey9.newRoom = new NativeRealtimeMultiplayerClient.RoomSession(this.mRealtimeManager, listener);
        if (this.mCurrentSession.IsActive())
        {
          Logger.e("Received attempt to accept invitation without cleaning up active session.");
          // ISSUE: reference to a compiler-generated field
          inboxCAnonStorey9.newRoom.LeaveRoom();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.mCurrentSession = inboxCAnonStorey9.newRoom;
          this.mCurrentSession.ShowingUI = true;
          // ISSUE: reference to a compiler-generated method
          this.mRealtimeManager.ShowRoomInboxUI(new Action<RealtimeManager.RoomInboxUIResponse>(inboxCAnonStorey9.\u003C\u003Em__0));
        }
      }
    }

    public void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeRealtimeMultiplayerClient.\u003CAcceptInvitation\u003Ec__AnonStoreyD invitationCAnonStoreyD = new NativeRealtimeMultiplayerClient.\u003CAcceptInvitation\u003Ec__AnonStoreyD();
      // ISSUE: reference to a compiler-generated field
      invitationCAnonStoreyD.invitationId = invitationId;
      // ISSUE: reference to a compiler-generated field
      invitationCAnonStoreyD.\u0024this = this;
      lock (this.mSessionLock)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NativeRealtimeMultiplayerClient.\u003CAcceptInvitation\u003Ec__AnonStoreyC invitationCAnonStoreyC = new NativeRealtimeMultiplayerClient.\u003CAcceptInvitation\u003Ec__AnonStoreyC();
        // ISSUE: reference to a compiler-generated field
        invitationCAnonStoreyC.\u003C\u003Ef__ref\u002413 = invitationCAnonStoreyD;
        // ISSUE: reference to a compiler-generated field
        invitationCAnonStoreyC.newRoom = new NativeRealtimeMultiplayerClient.RoomSession(this.mRealtimeManager, listener);
        if (this.mCurrentSession.IsActive())
        {
          Logger.e("Received attempt to accept invitation without cleaning up active session.");
          // ISSUE: reference to a compiler-generated field
          invitationCAnonStoreyC.newRoom.LeaveRoom();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.mCurrentSession = invitationCAnonStoreyC.newRoom;
          // ISSUE: reference to a compiler-generated method
          this.mRealtimeManager.FetchInvitations(new Action<RealtimeManager.FetchInvitationsResponse>(invitationCAnonStoreyC.\u003C\u003Em__0));
        }
      }
    }

    public Invitation GetInvitation()
    {
      return this.mCurrentSession.GetInvitation();
    }

    public void LeaveRoom()
    {
      this.mCurrentSession.LeaveRoom();
    }

    public void SendMessageToAll(bool reliable, byte[] data)
    {
      this.mCurrentSession.SendMessageToAll(reliable, data);
    }

    public void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
    {
      this.mCurrentSession.SendMessageToAll(reliable, data, offset, length);
    }

    public void SendMessage(bool reliable, string participantId, byte[] data)
    {
      this.mCurrentSession.SendMessage(reliable, participantId, data);
    }

    public void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
    {
      this.mCurrentSession.SendMessage(reliable, participantId, data, offset, length);
    }

    public List<Participant> GetConnectedParticipants()
    {
      return this.mCurrentSession.GetConnectedParticipants();
    }

    public Participant GetSelf()
    {
      return this.mCurrentSession.GetSelf();
    }

    public Participant GetParticipant(string participantId)
    {
      return this.mCurrentSession.GetParticipant(participantId);
    }

    public bool IsRoomConnected()
    {
      return this.mCurrentSession.IsRoomConnected();
    }

    public void DeclineInvitation(string invitationId)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.mRealtimeManager.FetchInvitations(new Action<RealtimeManager.FetchInvitationsResponse>(new NativeRealtimeMultiplayerClient.\u003CDeclineInvitation\u003Ec__AnonStorey10()
      {
        invitationId = invitationId,
        \u0024this = this
      }.\u003C\u003Em__0));
    }

    private static T WithDefault<T>(T presented, T defaultValue) where T : class
    {
      if ((object) presented != null)
        return presented;
      return defaultValue;
    }

    private class NoopListener : RealTimeMultiplayerListener
    {
      public void OnRoomSetupProgress(float percent)
      {
      }

      public void OnRoomConnected(bool success)
      {
      }

      public void OnLeftRoom()
      {
      }

      public void OnParticipantLeft(Participant participant)
      {
      }

      public void OnPeersConnected(string[] participantIds)
      {
      }

      public void OnPeersDisconnected(string[] participantIds)
      {
      }

      public void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
      {
      }
    }

    private class RoomSession
    {
      private readonly object mLifecycleLock = new object();
      private readonly NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener mListener;
      private readonly RealtimeManager mManager;
      private volatile string mCurrentPlayerId;
      private volatile NativeRealtimeMultiplayerClient.State mState;
      private volatile bool mStillPreRoomCreation;
      private Invitation mInvitation;
      private volatile bool mShowingUI;
      private uint mMinPlayersToStart;

      internal bool ShowingUI
      {
        get
        {
          return this.mShowingUI;
        }
        set
        {
          this.mShowingUI = value;
        }
      }

      internal uint MinPlayersToStart
      {
        get
        {
          return this.mMinPlayersToStart;
        }
        set
        {
          this.mMinPlayersToStart = value;
        }
      }

      internal RoomSession(RealtimeManager manager, RealTimeMultiplayerListener listener)
      {
        this.mManager = Misc.CheckNotNull<RealtimeManager>(manager);
        this.mListener = new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener(listener);
        this.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.BeforeRoomCreateStartedState(this), false);
        this.mStillPreRoomCreation = true;
      }

      internal RealtimeManager Manager()
      {
        return this.mManager;
      }

      internal bool IsActive()
      {
        return this.mState.IsActive();
      }

      internal string SelfPlayerId()
      {
        return this.mCurrentPlayerId;
      }

      public void SetInvitation(Invitation invitation)
      {
        this.mInvitation = invitation;
      }

      public Invitation GetInvitation()
      {
        return this.mInvitation;
      }

      internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener OnGameThreadListener()
      {
        return this.mListener;
      }

      internal void EnterState(NativeRealtimeMultiplayerClient.State handler)
      {
        this.EnterState(handler, true);
      }

      internal void EnterState(NativeRealtimeMultiplayerClient.State handler, bool fireStateEnteredEvent)
      {
        lock (this.mLifecycleLock)
        {
          this.mState = Misc.CheckNotNull<NativeRealtimeMultiplayerClient.State>(handler);
          if (!fireStateEnteredEvent)
            return;
          Logger.d("Entering state: " + handler.GetType().Name);
          this.mState.OnStateEntered();
        }
      }

      internal void LeaveRoom()
      {
        if (!this.ShowingUI)
        {
          lock (this.mLifecycleLock)
            this.mState.LeaveRoom();
        }
        else
          Logger.d("Not leaving room since showing UI");
      }

      internal void ShowWaitingRoomUI()
      {
        this.mState.ShowWaitingRoomUI(this.MinPlayersToStart);
      }

      internal void StartRoomCreation(string currentPlayerId, Action createRoom)
      {
        lock (this.mLifecycleLock)
        {
          if (!this.mStillPreRoomCreation)
            Logger.e("Room creation started more than once, this shouldn't happen!");
          else if (!this.mState.IsActive())
          {
            Logger.w("Received an attempt to create a room after the session was already torn down!");
          }
          else
          {
            this.mCurrentPlayerId = Misc.CheckNotNull<string>(currentPlayerId);
            this.mStillPreRoomCreation = false;
            this.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.RoomCreationPendingState(this));
            createRoom();
          }
        }
      }

      internal void OnRoomStatusChanged(NativeRealTimeRoom room)
      {
        lock (this.mLifecycleLock)
          this.mState.OnRoomStatusChanged(room);
      }

      internal void OnConnectedSetChanged(NativeRealTimeRoom room)
      {
        lock (this.mLifecycleLock)
          this.mState.OnConnectedSetChanged(room);
      }

      internal void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
      {
        lock (this.mLifecycleLock)
          this.mState.OnParticipantStatusChanged(room, participant);
      }

      internal void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
      {
        lock (this.mLifecycleLock)
          this.mState.HandleRoomResponse(response);
      }

      internal void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
      {
        this.mState.OnDataReceived(room, sender, data, isReliable);
      }

      internal void SendMessageToAll(bool reliable, byte[] data)
      {
        this.SendMessageToAll(reliable, data, 0, data.Length);
      }

      internal void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
      {
        this.mState.SendToAll(data, offset, length, reliable);
      }

      internal void SendMessage(bool reliable, string participantId, byte[] data)
      {
        this.SendMessage(reliable, participantId, data, 0, data.Length);
      }

      internal void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
      {
        this.mState.SendToSpecificRecipient(participantId, data, offset, length, reliable);
      }

      internal List<Participant> GetConnectedParticipants()
      {
        return this.mState.GetConnectedParticipants();
      }

      internal virtual Participant GetSelf()
      {
        return this.mState.GetSelf();
      }

      internal virtual Participant GetParticipant(string participantId)
      {
        return this.mState.GetParticipant(participantId);
      }

      internal virtual bool IsRoomConnected()
      {
        return this.mState.IsRoomConnected();
      }
    }

    private class OnGameThreadForwardingListener
    {
      private readonly RealTimeMultiplayerListener mListener;

      internal OnGameThreadForwardingListener(RealTimeMultiplayerListener listener)
      {
        this.mListener = Misc.CheckNotNull<RealTimeMultiplayerListener>(listener);
      }

      public void RoomSetupProgress(float percent)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.\u003CRoomSetupProgress\u003Ec__AnonStorey0()
        {
          percent = percent,
          \u0024this = this
        }.\u003C\u003Em__0));
      }

      public void RoomConnected(bool success)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.\u003CRoomConnected\u003Ec__AnonStorey1()
        {
          success = success,
          \u0024this = this
        }.\u003C\u003Em__0));
      }

      public void LeftRoom()
      {
        PlayGamesHelperObject.RunOnGameThread((Action) (() => this.mListener.OnLeftRoom()));
      }

      public void PeersConnected(string[] participantIds)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.\u003CPeersConnected\u003Ec__AnonStorey2()
        {
          participantIds = participantIds,
          \u0024this = this
        }.\u003C\u003Em__0));
      }

      public void PeersDisconnected(string[] participantIds)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.\u003CPeersDisconnected\u003Ec__AnonStorey3()
        {
          participantIds = participantIds,
          \u0024this = this
        }.\u003C\u003Em__0));
      }

      public void RealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.\u003CRealTimeMessageReceived\u003Ec__AnonStorey4()
        {
          isReliable = isReliable,
          senderId = senderId,
          data = data,
          \u0024this = this
        }.\u003C\u003Em__0));
      }

      public void ParticipantLeft(Participant participant)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.\u003CParticipantLeft\u003Ec__AnonStorey5()
        {
          participant = participant,
          \u0024this = this
        }.\u003C\u003Em__0));
      }
    }

    internal abstract class State
    {
      internal virtual void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
      {
        Logger.d(this.GetType().Name + ".HandleRoomResponse: Defaulting to no-op.");
      }

      internal virtual bool IsActive()
      {
        Logger.d(this.GetType().Name + ".IsNonPreemptable: Is preemptable by default.");
        return true;
      }

      internal virtual void LeaveRoom()
      {
        Logger.d(this.GetType().Name + ".LeaveRoom: Defaulting to no-op.");
      }

      internal virtual void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
      {
        Logger.d(this.GetType().Name + ".ShowWaitingRoomUI: Defaulting to no-op.");
      }

      internal virtual void OnStateEntered()
      {
        Logger.d(this.GetType().Name + ".OnStateEntered: Defaulting to no-op.");
      }

      internal virtual void OnRoomStatusChanged(NativeRealTimeRoom room)
      {
        Logger.d(this.GetType().Name + ".OnRoomStatusChanged: Defaulting to no-op.");
      }

      internal virtual void OnConnectedSetChanged(NativeRealTimeRoom room)
      {
        Logger.d(this.GetType().Name + ".OnConnectedSetChanged: Defaulting to no-op.");
      }

      internal virtual void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
      {
        Logger.d(this.GetType().Name + ".OnParticipantStatusChanged: Defaulting to no-op.");
      }

      internal virtual void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
      {
        Logger.d(this.GetType().Name + ".OnDataReceived: Defaulting to no-op.");
      }

      internal virtual void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
      {
        Logger.d(this.GetType().Name + ".SendToSpecificRecipient: Defaulting to no-op.");
      }

      internal virtual void SendToAll(byte[] data, int offset, int length, bool isReliable)
      {
        Logger.d(this.GetType().Name + ".SendToApp: Defaulting to no-op.");
      }

      internal virtual List<Participant> GetConnectedParticipants()
      {
        Logger.d(this.GetType().Name + ".GetConnectedParticipants: Returning empty connected participants");
        return new List<Participant>();
      }

      internal virtual Participant GetSelf()
      {
        Logger.d(this.GetType().Name + ".GetSelf: Returning null self.");
        return (Participant) null;
      }

      internal virtual Participant GetParticipant(string participantId)
      {
        Logger.d(this.GetType().Name + ".GetSelf: Returning null participant.");
        return (Participant) null;
      }

      internal virtual bool IsRoomConnected()
      {
        Logger.d(this.GetType().Name + ".IsRoomConnected: Returning room not connected.");
        return false;
      }
    }

    private abstract class MessagingEnabledState : NativeRealtimeMultiplayerClient.State
    {
      protected readonly NativeRealtimeMultiplayerClient.RoomSession mSession;
      protected NativeRealTimeRoom mRoom;
      protected Dictionary<string, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> mNativeParticipants;
      protected Dictionary<string, Participant> mParticipants;

      internal MessagingEnabledState(NativeRealtimeMultiplayerClient.RoomSession session, NativeRealTimeRoom room)
      {
        this.mSession = Misc.CheckNotNull<NativeRealtimeMultiplayerClient.RoomSession>(session);
        this.UpdateCurrentRoom(room);
      }

      internal void UpdateCurrentRoom(NativeRealTimeRoom room)
      {
        if (this.mRoom != null)
          this.mRoom.Dispose();
        this.mRoom = Misc.CheckNotNull<NativeRealTimeRoom>(room);
        this.mNativeParticipants = this.mRoom.Participants().ToDictionary<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string>((Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string>) (p => p.Id()));
        this.mParticipants = this.mNativeParticipants.Values.Select<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant>((Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant>) (p => p.AsParticipant())).ToDictionary<Participant, string>((Func<Participant, string>) (p => p.ParticipantId));
      }

      internal override sealed void OnRoomStatusChanged(NativeRealTimeRoom room)
      {
        this.HandleRoomStatusChanged(room);
        this.UpdateCurrentRoom(room);
      }

      internal virtual void HandleRoomStatusChanged(NativeRealTimeRoom room)
      {
      }

      internal override sealed void OnConnectedSetChanged(NativeRealTimeRoom room)
      {
        this.HandleConnectedSetChanged(room);
        this.UpdateCurrentRoom(room);
      }

      internal virtual void HandleConnectedSetChanged(NativeRealTimeRoom room)
      {
      }

      internal override sealed void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
      {
        this.HandleParticipantStatusChanged(room, participant);
        this.UpdateCurrentRoom(room);
      }

      internal virtual void HandleParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
      {
      }

      internal override sealed List<Participant> GetConnectedParticipants()
      {
        List<Participant> list = this.mParticipants.Values.Where<Participant>((Func<Participant, bool>) (p => p.IsConnectedToRoom)).ToList<Participant>();
        list.Sort();
        return list;
      }

      internal override void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
      {
        if (!this.mNativeParticipants.ContainsKey(recipientId))
          Logger.e("Attempted to send message to unknown participant " + recipientId);
        else if (isReliable)
          this.mSession.Manager().SendReliableMessage(this.mRoom, this.mNativeParticipants[recipientId], Misc.GetSubsetBytes(data, offset, length), (Action<CommonErrorStatus.MultiplayerStatus>) null);
        else
          this.mSession.Manager().SendUnreliableMessageToSpecificParticipants(this.mRoom, new List<GooglePlayGames.Native.PInvoke.MultiplayerParticipant>()
          {
            this.mNativeParticipants[recipientId]
          }, Misc.GetSubsetBytes(data, offset, length));
      }

      internal override void SendToAll(byte[] data, int offset, int length, bool isReliable)
      {
        byte[] subsetBytes = Misc.GetSubsetBytes(data, offset, length);
        if (isReliable)
        {
          foreach (string key in this.mNativeParticipants.Keys)
            this.SendToSpecificRecipient(key, subsetBytes, 0, subsetBytes.Length, true);
        }
        else
          this.mSession.Manager().SendUnreliableMessageToAll(this.mRoom, subsetBytes);
      }

      internal override void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
      {
        this.mSession.OnGameThreadListener().RealTimeMessageReceived(isReliable, sender.Id(), data);
      }
    }

    private class BeforeRoomCreateStartedState : NativeRealtimeMultiplayerClient.State
    {
      private readonly NativeRealtimeMultiplayerClient.RoomSession mContainingSession;

      internal BeforeRoomCreateStartedState(NativeRealtimeMultiplayerClient.RoomSession session)
      {
        this.mContainingSession = Misc.CheckNotNull<NativeRealtimeMultiplayerClient.RoomSession>(session);
      }

      internal override void LeaveRoom()
      {
        Logger.d("Session was torn down before room was created.");
        this.mContainingSession.OnGameThreadListener().RoomConnected(false);
        this.mContainingSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ShutdownState(this.mContainingSession));
      }
    }

    private class RoomCreationPendingState : NativeRealtimeMultiplayerClient.State
    {
      private readonly NativeRealtimeMultiplayerClient.RoomSession mContainingSession;

      internal RoomCreationPendingState(NativeRealtimeMultiplayerClient.RoomSession session)
      {
        this.mContainingSession = Misc.CheckNotNull<NativeRealtimeMultiplayerClient.RoomSession>(session);
      }

      internal override void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
      {
        if (!response.RequestSucceeded())
        {
          this.mContainingSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ShutdownState(this.mContainingSession));
          this.mContainingSession.OnGameThreadListener().RoomConnected(false);
        }
        else
          this.mContainingSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ConnectingState(response.Room(), this.mContainingSession));
      }

      internal override bool IsActive()
      {
        return true;
      }

      internal override void LeaveRoom()
      {
        Logger.d("Received request to leave room during room creation, aborting creation.");
        this.mContainingSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.AbortingRoomCreationState(this.mContainingSession));
      }
    }

    private class ConnectingState : NativeRealtimeMultiplayerClient.MessagingEnabledState
    {
      private static readonly HashSet<Types.ParticipantStatus> FailedStatuses = new HashSet<Types.ParticipantStatus>() { Types.ParticipantStatus.DECLINED, Types.ParticipantStatus.LEFT };
      private HashSet<string> mConnectedParticipants = new HashSet<string>();
      private float mPercentComplete = 20f;
      private const float InitialPercentComplete = 20f;
      private float mPercentPerParticipant;

      internal ConnectingState(NativeRealTimeRoom room, NativeRealtimeMultiplayerClient.RoomSession session)
        : base(session, room)
      {
        this.mPercentPerParticipant = 80f / (float) session.MinPlayersToStart;
      }

      internal override void OnStateEntered()
      {
        this.mSession.OnGameThreadListener().RoomSetupProgress(this.mPercentComplete);
      }

      internal override void HandleConnectedSetChanged(NativeRealTimeRoom room)
      {
        HashSet<string> first = new HashSet<string>();
        if ((room.Status() == Types.RealTimeRoomStatus.AUTO_MATCHING || room.Status() == Types.RealTimeRoomStatus.CONNECTING) && this.mSession.MinPlayersToStart <= room.ParticipantCount())
        {
          this.mSession.MinPlayersToStart = this.mSession.MinPlayersToStart + room.ParticipantCount();
          this.mPercentPerParticipant = 80f / (float) this.mSession.MinPlayersToStart;
        }
        foreach (GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant in room.Participants())
        {
          using (participant)
          {
            if (participant.IsConnectedToRoom())
              first.Add(participant.Id());
          }
        }
        if (this.mConnectedParticipants.Equals((object) first))
        {
          Logger.w("Received connected set callback with unchanged connected set!");
        }
        else
        {
          IEnumerable<string> source1 = this.mConnectedParticipants.Except<string>((IEnumerable<string>) first);
          if (room.Status() == Types.RealTimeRoomStatus.DELETED)
          {
            Logger.e("Participants disconnected during room setup, failing. Participants were: " + string.Join(",", source1.ToArray<string>()));
            this.mSession.OnGameThreadListener().RoomConnected(false);
            this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ShutdownState(this.mSession));
          }
          else
          {
            IEnumerable<string> source2 = first.Except<string>((IEnumerable<string>) this.mConnectedParticipants);
            Logger.d("New participants connected: " + string.Join(",", source2.ToArray<string>()));
            if (room.Status() == Types.RealTimeRoomStatus.ACTIVE)
            {
              Logger.d("Fully connected! Transitioning to active state.");
              this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ActiveState(room, this.mSession));
              this.mSession.OnGameThreadListener().RoomConnected(true);
            }
            else
            {
              this.mPercentComplete += this.mPercentPerParticipant * (float) source2.Count<string>();
              this.mConnectedParticipants = first;
              this.mSession.OnGameThreadListener().RoomSetupProgress(this.mPercentComplete);
            }
          }
        }
      }

      internal override void HandleParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
      {
        if (!NativeRealtimeMultiplayerClient.ConnectingState.FailedStatuses.Contains(participant.Status()))
          return;
        this.mSession.OnGameThreadListener().ParticipantLeft(participant.AsParticipant());
        if (room.Status() == Types.RealTimeRoomStatus.CONNECTING || room.Status() == Types.RealTimeRoomStatus.AUTO_MATCHING)
          return;
        this.LeaveRoom();
      }

      internal override void LeaveRoom()
      {
        this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.LeavingRoom(this.mSession, this.mRoom, (Action) (() => this.mSession.OnGameThreadListener().RoomConnected(false))));
      }

      internal override void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
      {
        this.mSession.ShowingUI = true;
        this.mSession.Manager().ShowWaitingRoomUI(this.mRoom, minimumParticipantsBeforeStarting, (Action<RealtimeManager.WaitingRoomUIResponse>) (response =>
        {
          this.mSession.ShowingUI = false;
          Logger.d("ShowWaitingRoomUI Response: " + (object) response.ResponseStatus());
          if (response.ResponseStatus() == CommonErrorStatus.UIStatus.VALID)
          {
            Logger.d("Connecting state ShowWaitingRoomUI: room pcount:" + (object) response.Room().ParticipantCount() + " status: " + (object) response.Room().Status());
            if (response.Room().Status() != Types.RealTimeRoomStatus.ACTIVE)
              return;
            this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ActiveState(response.Room(), this.mSession));
          }
          else if (response.ResponseStatus() == CommonErrorStatus.UIStatus.ERROR_LEFT_ROOM)
            this.LeaveRoom();
          else
            this.mSession.OnGameThreadListener().RoomSetupProgress(this.mPercentComplete);
        }));
      }
    }

    private class ActiveState : NativeRealtimeMultiplayerClient.MessagingEnabledState
    {
      internal ActiveState(NativeRealTimeRoom room, NativeRealtimeMultiplayerClient.RoomSession session)
        : base(session, room)
      {
      }

      internal override void OnStateEntered()
      {
        if (this.GetSelf() != null)
          return;
        Logger.e("Room reached active state with unknown participant for the player");
        this.LeaveRoom();
      }

      internal override bool IsRoomConnected()
      {
        return true;
      }

      internal override Participant GetParticipant(string participantId)
      {
        if (this.mParticipants.ContainsKey(participantId))
          return this.mParticipants[participantId];
        Logger.e("Attempted to retrieve unknown participant " + participantId);
        return (Participant) null;
      }

      internal override Participant GetSelf()
      {
        foreach (Participant participant in this.mParticipants.Values)
        {
          if (participant.Player != null && participant.Player.id.Equals(this.mSession.SelfPlayerId()))
            return participant;
        }
        return (Participant) null;
      }

      internal override void HandleConnectedSetChanged(NativeRealTimeRoom room)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NativeRealtimeMultiplayerClient.ActiveState.\u003CHandleConnectedSetChanged\u003Ec__AnonStorey0 changedCAnonStorey0 = new NativeRealtimeMultiplayerClient.ActiveState.\u003CHandleConnectedSetChanged\u003Ec__AnonStorey0();
        List<string> source1 = new List<string>();
        List<string> source2 = new List<string>();
        Dictionary<string, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> dictionary = room.Participants().ToDictionary<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string>((Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string>) (p => p.Id()));
        foreach (string key in this.mNativeParticipants.Keys)
        {
          GooglePlayGames.Native.PInvoke.MultiplayerParticipant multiplayerParticipant = dictionary[key];
          GooglePlayGames.Native.PInvoke.MultiplayerParticipant nativeParticipant = this.mNativeParticipants[key];
          if (!multiplayerParticipant.IsConnectedToRoom())
            source2.Add(key);
          if (!nativeParticipant.IsConnectedToRoom() && multiplayerParticipant.IsConnectedToRoom())
            source1.Add(key);
        }
        foreach (BaseReferenceHolder baseReferenceHolder in this.mNativeParticipants.Values)
          baseReferenceHolder.Dispose();
        this.mNativeParticipants = dictionary;
        this.mParticipants = this.mNativeParticipants.Values.Select<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant>((Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant>) (p => p.AsParticipant())).ToDictionary<Participant, string>((Func<Participant, string>) (p => p.ParticipantId));
        Logger.d("Updated participant statuses: " + string.Join(",", this.mParticipants.Values.Select<Participant, string>((Func<Participant, string>) (p => p.ToString())).ToArray<string>()));
        if (source2.Contains(this.GetSelf().ParticipantId))
          Logger.w("Player was disconnected from the multiplayer session.");
        // ISSUE: reference to a compiler-generated field
        changedCAnonStorey0.selfId = this.GetSelf().ParticipantId;
        // ISSUE: reference to a compiler-generated method
        List<string> list1 = source1.Where<string>(new Func<string, bool>(changedCAnonStorey0.\u003C\u003Em__0)).ToList<string>();
        // ISSUE: reference to a compiler-generated method
        List<string> list2 = source2.Where<string>(new Func<string, bool>(changedCAnonStorey0.\u003C\u003Em__1)).ToList<string>();
        if (list1.Count > 0)
        {
          list1.Sort();
          // ISSUE: reference to a compiler-generated method
          this.mSession.OnGameThreadListener().PeersConnected(list1.Where<string>(new Func<string, bool>(changedCAnonStorey0.\u003C\u003Em__2)).ToArray<string>());
        }
        if (list2.Count <= 0)
          return;
        list2.Sort();
        // ISSUE: reference to a compiler-generated method
        this.mSession.OnGameThreadListener().PeersDisconnected(list2.Where<string>(new Func<string, bool>(changedCAnonStorey0.\u003C\u003Em__3)).ToArray<string>());
      }

      internal override void LeaveRoom()
      {
        this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.LeavingRoom(this.mSession, this.mRoom, (Action) (() => this.mSession.OnGameThreadListener().LeftRoom())));
      }
    }

    private class ShutdownState : NativeRealtimeMultiplayerClient.State
    {
      private readonly NativeRealtimeMultiplayerClient.RoomSession mSession;

      internal ShutdownState(NativeRealtimeMultiplayerClient.RoomSession session)
      {
        this.mSession = Misc.CheckNotNull<NativeRealtimeMultiplayerClient.RoomSession>(session);
      }

      internal override bool IsActive()
      {
        return false;
      }

      internal override void LeaveRoom()
      {
        this.mSession.OnGameThreadListener().LeftRoom();
      }
    }

    private class LeavingRoom : NativeRealtimeMultiplayerClient.State
    {
      private readonly NativeRealtimeMultiplayerClient.RoomSession mSession;
      private readonly NativeRealTimeRoom mRoomToLeave;
      private readonly Action mLeavingCompleteCallback;

      internal LeavingRoom(NativeRealtimeMultiplayerClient.RoomSession session, NativeRealTimeRoom room, Action leavingCompleteCallback)
      {
        this.mSession = Misc.CheckNotNull<NativeRealtimeMultiplayerClient.RoomSession>(session);
        this.mRoomToLeave = Misc.CheckNotNull<NativeRealTimeRoom>(room);
        this.mLeavingCompleteCallback = Misc.CheckNotNull<Action>(leavingCompleteCallback);
      }

      internal override bool IsActive()
      {
        return false;
      }

      internal override void OnStateEntered()
      {
        this.mSession.Manager().LeaveRoom(this.mRoomToLeave, (Action<CommonErrorStatus.ResponseStatus>) (status =>
        {
          this.mLeavingCompleteCallback();
          this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ShutdownState(this.mSession));
        }));
      }
    }

    private class AbortingRoomCreationState : NativeRealtimeMultiplayerClient.State
    {
      private readonly NativeRealtimeMultiplayerClient.RoomSession mSession;

      internal AbortingRoomCreationState(NativeRealtimeMultiplayerClient.RoomSession session)
      {
        this.mSession = Misc.CheckNotNull<NativeRealtimeMultiplayerClient.RoomSession>(session);
      }

      internal override bool IsActive()
      {
        return false;
      }

      internal override void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
      {
        if (!response.RequestSucceeded())
        {
          this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.ShutdownState(this.mSession));
          this.mSession.OnGameThreadListener().RoomConnected(false);
        }
        else
          this.mSession.EnterState((NativeRealtimeMultiplayerClient.State) new NativeRealtimeMultiplayerClient.LeavingRoom(this.mSession, response.Room(), (Action) (() => this.mSession.OnGameThreadListener().RoomConnected(false))));
      }
    }
  }
}
