// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.NativeTurnBasedMultiplayerClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using System;
using System.Collections;
using System.Diagnostics;

namespace GooglePlayGames.Native
{
  public class NativeTurnBasedMultiplayerClient : ITurnBasedMultiplayerClient
  {
    private readonly TurnBasedManager mTurnBasedManager;
    private readonly NativeClient mNativeClient;
    private volatile Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;

    internal NativeTurnBasedMultiplayerClient(NativeClient nativeClient, TurnBasedManager manager)
    {
      this.mTurnBasedManager = manager;
      this.mNativeClient = nativeClient;
    }

    public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
    {
      this.CreateQuickMatch(minOpponents, maxOpponents, variant, 0UL, callback);
    }

    public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CCreateQuickMatch\u003Ec__AnonStorey1 matchCAnonStorey1 = new NativeTurnBasedMultiplayerClient.\u003CCreateQuickMatch\u003Ec__AnonStorey1();
      // ISSUE: reference to a compiler-generated field
      matchCAnonStorey1.callback = callback;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      matchCAnonStorey1.callback = Callbacks.AsOnGameThreadCallback<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(matchCAnonStorey1.callback);
      using (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder matchConfigBuilder = GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder.Create())
      {
        matchConfigBuilder.SetVariant(variant).SetMinimumAutomatchingPlayers(minOpponents).SetMaximumAutomatchingPlayers(maxOpponents).SetExclusiveBitMask(exclusiveBitmask);
        using (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig config = matchConfigBuilder.Build())
        {
          // ISSUE: reference to a compiler-generated method
          this.mTurnBasedManager.CreateMatch(config, this.BridgeMatchToUserCallback(new Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(matchCAnonStorey1.\u003C\u003Em__0)));
        }
      }
    }

    public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.CreateWithInvitationScreen(minOpponents, maxOpponents, variant, new Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(new NativeTurnBasedMultiplayerClient.\u003CCreateWithInvitationScreen\u003Ec__AnonStorey2()
      {
        callback = callback
      }.\u003C\u003Em__0));
    }

    public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CCreateWithInvitationScreen\u003Ec__AnonStorey3 screenCAnonStorey3 = new NativeTurnBasedMultiplayerClient.\u003CCreateWithInvitationScreen\u003Ec__AnonStorey3();
      // ISSUE: reference to a compiler-generated field
      screenCAnonStorey3.callback = callback;
      // ISSUE: reference to a compiler-generated field
      screenCAnonStorey3.variant = variant;
      // ISSUE: reference to a compiler-generated field
      screenCAnonStorey3.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      screenCAnonStorey3.callback = Callbacks.AsOnGameThreadCallback<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(screenCAnonStorey3.callback);
      // ISSUE: reference to a compiler-generated method
      this.mTurnBasedManager.ShowPlayerSelectUI(minOpponents, maxOpponents, true, new Action<PlayerSelectUIResponse>(screenCAnonStorey3.\u003C\u003Em__0));
    }

    public void GetAllInvitations(Action<Invitation[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.mTurnBasedManager.GetAllTurnbasedMatches(new Action<TurnBasedManager.TurnBasedMatchesResponse>(new NativeTurnBasedMultiplayerClient.\u003CGetAllInvitations\u003Ec__AnonStorey4()
      {
        callback = callback
      }.\u003C\u003Em__0));
    }

    public void GetAllMatches(Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.mTurnBasedManager.GetAllTurnbasedMatches(new Action<TurnBasedManager.TurnBasedMatchesResponse>(new NativeTurnBasedMultiplayerClient.\u003CGetAllMatches\u003Ec__AnonStorey5()
      {
        callback = callback,
        \u0024this = this
      }.\u003C\u003Em__0));
    }

    private Action<TurnBasedManager.TurnBasedMatchResponse> BridgeMatchToUserCallback(Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> userCallback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return new Action<TurnBasedManager.TurnBasedMatchResponse>(new NativeTurnBasedMultiplayerClient.\u003CBridgeMatchToUserCallback\u003Ec__AnonStorey6() { userCallback = userCallback, \u0024this = this }.\u003C\u003Em__0);
    }

    public void AcceptFromInbox(Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CAcceptFromInbox\u003Ec__AnonStorey7 inboxCAnonStorey7 = new NativeTurnBasedMultiplayerClient.\u003CAcceptFromInbox\u003Ec__AnonStorey7();
      // ISSUE: reference to a compiler-generated field
      inboxCAnonStorey7.callback = callback;
      // ISSUE: reference to a compiler-generated field
      inboxCAnonStorey7.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      inboxCAnonStorey7.callback = Callbacks.AsOnGameThreadCallback<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(inboxCAnonStorey7.callback);
      // ISSUE: reference to a compiler-generated method
      this.mTurnBasedManager.ShowInboxUI(new Action<TurnBasedManager.MatchInboxUIResponse>(inboxCAnonStorey7.\u003C\u003Em__0));
    }

    public void AcceptInvitation(string invitationId, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CAcceptInvitation\u003Ec__AnonStorey8 invitationCAnonStorey8 = new NativeTurnBasedMultiplayerClient.\u003CAcceptInvitation\u003Ec__AnonStorey8();
      // ISSUE: reference to a compiler-generated field
      invitationCAnonStorey8.invitationId = invitationId;
      // ISSUE: reference to a compiler-generated field
      invitationCAnonStorey8.callback = callback;
      // ISSUE: reference to a compiler-generated field
      invitationCAnonStorey8.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      invitationCAnonStorey8.callback = Callbacks.AsOnGameThreadCallback<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(invitationCAnonStorey8.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindInvitationWithId(invitationCAnonStorey8.invitationId, new Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation>(invitationCAnonStorey8.\u003C\u003Em__0));
    }

    private void FindInvitationWithId(string invitationId, Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.mTurnBasedManager.GetAllTurnbasedMatches(new Action<TurnBasedManager.TurnBasedMatchesResponse>(new NativeTurnBasedMultiplayerClient.\u003CFindInvitationWithId\u003Ec__AnonStorey9()
      {
        callback = callback,
        invitationId = invitationId
      }.\u003C\u003Em__0));
    }

    public void RegisterMatchDelegate(MatchDelegate del)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CRegisterMatchDelegate\u003Ec__AnonStoreyA delegateCAnonStoreyA = new NativeTurnBasedMultiplayerClient.\u003CRegisterMatchDelegate\u003Ec__AnonStoreyA();
      // ISSUE: reference to a compiler-generated field
      delegateCAnonStoreyA.del = del;
      // ISSUE: reference to a compiler-generated field
      if (delegateCAnonStoreyA.del == null)
      {
        this.mMatchDelegate = (Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool>) null;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mMatchDelegate = Callbacks.AsOnGameThreadCallback<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool>(new Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool>(delegateCAnonStoreyA.\u003C\u003Em__0));
      }
    }

    internal void HandleMatchEvent(Types.MultiplayerEvent eventType, string matchId, NativeTurnBasedMatch match)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CHandleMatchEvent\u003Ec__AnonStoreyB eventCAnonStoreyB = new NativeTurnBasedMultiplayerClient.\u003CHandleMatchEvent\u003Ec__AnonStoreyB();
      // ISSUE: reference to a compiler-generated field
      eventCAnonStoreyB.match = match;
      // ISSUE: reference to a compiler-generated field
      eventCAnonStoreyB.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      eventCAnonStoreyB.currentDelegate = this.mMatchDelegate;
      // ISSUE: reference to a compiler-generated field
      if (eventCAnonStoreyB.currentDelegate == null)
        return;
      if (eventType == Types.MultiplayerEvent.REMOVED)
      {
        Logger.d("Ignoring REMOVE event for match " + matchId);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        eventCAnonStoreyB.shouldAutolaunch = eventType == Types.MultiplayerEvent.UPDATED_FROM_APP_LAUNCH;
        // ISSUE: reference to a compiler-generated field
        eventCAnonStoreyB.match.ReferToMe();
        // ISSUE: reference to a compiler-generated method
        Callbacks.AsCoroutine(this.WaitForLogin(new Action(eventCAnonStoreyB.\u003C\u003Em__0)));
      }
    }

    [DebuggerHidden]
    private IEnumerator WaitForLogin(Action method)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new NativeTurnBasedMultiplayerClient.\u003CWaitForLogin\u003Ec__Iterator0() { method = method, \u0024this = this };
    }

    public void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CTakeTurn\u003Ec__AnonStoreyC turnCAnonStoreyC = new NativeTurnBasedMultiplayerClient.\u003CTakeTurn\u003Ec__AnonStoreyC();
      // ISSUE: reference to a compiler-generated field
      turnCAnonStoreyC.data = data;
      // ISSUE: reference to a compiler-generated field
      turnCAnonStoreyC.callback = callback;
      // ISSUE: reference to a compiler-generated field
      turnCAnonStoreyC.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      Logger.describe(turnCAnonStoreyC.data);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      turnCAnonStoreyC.callback = Callbacks.AsOnGameThreadCallback<bool>(turnCAnonStoreyC.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatchWithParticipant(match, pendingParticipantId, turnCAnonStoreyC.callback, new Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, NativeTurnBasedMatch>(turnCAnonStoreyC.\u003C\u003Em__0));
    }

    private void FindEqualVersionMatch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> onFailure, Action<NativeTurnBasedMatch> onVersionMatch)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CFindEqualVersionMatch\u003Ec__AnonStoreyD matchCAnonStoreyD = new NativeTurnBasedMultiplayerClient.\u003CFindEqualVersionMatch\u003Ec__AnonStoreyD();
      // ISSUE: reference to a compiler-generated field
      matchCAnonStoreyD.match = match;
      // ISSUE: reference to a compiler-generated field
      matchCAnonStoreyD.onFailure = onFailure;
      // ISSUE: reference to a compiler-generated field
      matchCAnonStoreyD.onVersionMatch = onVersionMatch;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.mTurnBasedManager.GetMatch(matchCAnonStoreyD.match.MatchId, new Action<TurnBasedManager.TurnBasedMatchResponse>(matchCAnonStoreyD.\u003C\u003Em__0));
    }

    private void FindEqualVersionMatchWithParticipant(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string participantId, Action<bool> onFailure, Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, NativeTurnBasedMatch> onFoundParticipantAndMatch)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CFindEqualVersionMatchWithParticipant\u003Ec__AnonStoreyE participantCAnonStoreyE = new NativeTurnBasedMultiplayerClient.\u003CFindEqualVersionMatchWithParticipant\u003Ec__AnonStoreyE();
      // ISSUE: reference to a compiler-generated field
      participantCAnonStoreyE.participantId = participantId;
      // ISSUE: reference to a compiler-generated field
      participantCAnonStoreyE.onFoundParticipantAndMatch = onFoundParticipantAndMatch;
      // ISSUE: reference to a compiler-generated field
      participantCAnonStoreyE.match = match;
      // ISSUE: reference to a compiler-generated field
      participantCAnonStoreyE.onFailure = onFailure;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatch(participantCAnonStoreyE.match, participantCAnonStoreyE.onFailure, new Action<NativeTurnBasedMatch>(participantCAnonStoreyE.\u003C\u003Em__0));
    }

    public int GetMaxMatchDataSize()
    {
      throw new NotImplementedException();
    }

    public void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CFinish\u003Ec__AnonStoreyF finishCAnonStoreyF = new NativeTurnBasedMultiplayerClient.\u003CFinish\u003Ec__AnonStoreyF();
      // ISSUE: reference to a compiler-generated field
      finishCAnonStoreyF.outcome = outcome;
      // ISSUE: reference to a compiler-generated field
      finishCAnonStoreyF.callback = callback;
      // ISSUE: reference to a compiler-generated field
      finishCAnonStoreyF.data = data;
      // ISSUE: reference to a compiler-generated field
      finishCAnonStoreyF.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      finishCAnonStoreyF.callback = Callbacks.AsOnGameThreadCallback<bool>(finishCAnonStoreyF.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatch(match, finishCAnonStoreyF.callback, new Action<NativeTurnBasedMatch>(finishCAnonStoreyF.\u003C\u003Em__0));
    }

    private static Types.MatchResult ResultToMatchResult(MatchOutcome.ParticipantResult result)
    {
      switch (result)
      {
        case MatchOutcome.ParticipantResult.None:
          return Types.MatchResult.NONE;
        case MatchOutcome.ParticipantResult.Win:
          return Types.MatchResult.WIN;
        case MatchOutcome.ParticipantResult.Loss:
          return Types.MatchResult.LOSS;
        case MatchOutcome.ParticipantResult.Tie:
          return Types.MatchResult.TIE;
        default:
          Logger.e("Received unknown ParticipantResult " + (object) result);
          return Types.MatchResult.NONE;
      }
    }

    public void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CAcknowledgeFinished\u003Ec__AnonStorey10 finishedCAnonStorey10 = new NativeTurnBasedMultiplayerClient.\u003CAcknowledgeFinished\u003Ec__AnonStorey10();
      // ISSUE: reference to a compiler-generated field
      finishedCAnonStorey10.callback = callback;
      // ISSUE: reference to a compiler-generated field
      finishedCAnonStorey10.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      finishedCAnonStorey10.callback = Callbacks.AsOnGameThreadCallback<bool>(finishedCAnonStorey10.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatch(match, finishedCAnonStorey10.callback, new Action<NativeTurnBasedMatch>(finishedCAnonStorey10.\u003C\u003Em__0));
    }

    public void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CLeave\u003Ec__AnonStorey11 leaveCAnonStorey11 = new NativeTurnBasedMultiplayerClient.\u003CLeave\u003Ec__AnonStorey11();
      // ISSUE: reference to a compiler-generated field
      leaveCAnonStorey11.callback = callback;
      // ISSUE: reference to a compiler-generated field
      leaveCAnonStorey11.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      leaveCAnonStorey11.callback = Callbacks.AsOnGameThreadCallback<bool>(leaveCAnonStorey11.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatch(match, leaveCAnonStorey11.callback, new Action<NativeTurnBasedMatch>(leaveCAnonStorey11.\u003C\u003Em__0));
    }

    public void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CLeaveDuringTurn\u003Ec__AnonStorey12 turnCAnonStorey12 = new NativeTurnBasedMultiplayerClient.\u003CLeaveDuringTurn\u003Ec__AnonStorey12();
      // ISSUE: reference to a compiler-generated field
      turnCAnonStorey12.callback = callback;
      // ISSUE: reference to a compiler-generated field
      turnCAnonStorey12.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      turnCAnonStorey12.callback = Callbacks.AsOnGameThreadCallback<bool>(turnCAnonStorey12.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatchWithParticipant(match, pendingParticipantId, turnCAnonStorey12.callback, new Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, NativeTurnBasedMatch>(turnCAnonStorey12.\u003C\u003Em__0));
    }

    public void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CCancel\u003Ec__AnonStorey13 cancelCAnonStorey13 = new NativeTurnBasedMultiplayerClient.\u003CCancel\u003Ec__AnonStorey13();
      // ISSUE: reference to a compiler-generated field
      cancelCAnonStorey13.callback = callback;
      // ISSUE: reference to a compiler-generated field
      cancelCAnonStorey13.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cancelCAnonStorey13.callback = Callbacks.AsOnGameThreadCallback<bool>(cancelCAnonStorey13.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatch(match, cancelCAnonStorey13.callback, new Action<NativeTurnBasedMatch>(cancelCAnonStorey13.\u003C\u003Em__0));
    }

    public void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeTurnBasedMultiplayerClient.\u003CRematch\u003Ec__AnonStorey14 rematchCAnonStorey14 = new NativeTurnBasedMultiplayerClient.\u003CRematch\u003Ec__AnonStorey14();
      // ISSUE: reference to a compiler-generated field
      rematchCAnonStorey14.callback = callback;
      // ISSUE: reference to a compiler-generated field
      rematchCAnonStorey14.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      rematchCAnonStorey14.callback = Callbacks.AsOnGameThreadCallback<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(rematchCAnonStorey14.callback);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.FindEqualVersionMatch(match, new Action<bool>(rematchCAnonStorey14.\u003C\u003Em__0), new Action<NativeTurnBasedMatch>(rematchCAnonStorey14.\u003C\u003Em__1));
    }

    public void DeclineInvitation(string invitationId)
    {
      this.FindInvitationWithId(invitationId, (Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation>) (invitation =>
      {
        if (invitation == null)
          return;
        this.mTurnBasedManager.DeclineInvitation(invitation);
      }));
    }
  }
}
