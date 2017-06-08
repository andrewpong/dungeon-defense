// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.TurnBasedManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class TurnBasedManager
  {
    private readonly GameServices mGameServices;

    internal TurnBasedManager(GameServices services)
    {
      this.mGameServices = services;
    }

    internal void GetMatch(string matchId, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      string match_id = matchId;
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache0 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(TurnBasedManager.InternalTurnBasedMatchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchCallback fMgCache0 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr callbackPointer = TurnBasedManager.ToCallbackPointer(callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_FetchMatch(self, match_id, fMgCache0, callbackPointer);
    }

    [MonoPInvokeCallback(typeof (TurnBasedMultiplayerManager.TurnBasedMatchCallback))]
    internal static void InternalTurnBasedMatchCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("TurnBasedManager#InternalTurnBasedMatchCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void CreateMatch(TurnBasedMatchConfig config, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr config1 = config.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache1 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(TurnBasedManager.InternalTurnBasedMatchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchCallback fMgCache1 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache1;
      IntPtr callbackPointer = TurnBasedManager.ToCallbackPointer(callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_CreateTurnBasedMatch(self, config1, fMgCache1, callbackPointer);
    }

    internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, Action<PlayerSelectUIResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      int num1 = (int) minimumPlayers;
      int num2 = (int) maxiumPlayers;
      int num3 = allowAutomatching ? 1 : 0;
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache3 = new TurnBasedMultiplayerManager.PlayerSelectUICallback(TurnBasedManager.InternalPlayerSelectUIcallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.PlayerSelectUICallback fMgCache3 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache3;
      Action<PlayerSelectUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache2 = new Func<IntPtr, PlayerSelectUIResponse>(PlayerSelectUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, PlayerSelectUIResponse> fMgCache2 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache2;
      IntPtr intPtr = Callbacks.ToIntPtr<PlayerSelectUIResponse>(callback1, fMgCache2);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_ShowPlayerSelectUI(self, (uint) num1, (uint) num2, num3 != 0, fMgCache3, intPtr);
    }

    [MonoPInvokeCallback(typeof (TurnBasedMultiplayerManager.PlayerSelectUICallback))]
    internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("TurnBasedManager#PlayerSelectUICallback", Callbacks.Type.Temporary, response, data);
    }

    internal void GetAllTurnbasedMatches(Action<TurnBasedManager.TurnBasedMatchesResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache5 = new TurnBasedMultiplayerManager.TurnBasedMatchesCallback(TurnBasedManager.InternalTurnBasedMatchesCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchesCallback fMgCache5 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache5;
      Action<TurnBasedManager.TurnBasedMatchesResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache4 = new Func<IntPtr, TurnBasedManager.TurnBasedMatchesResponse>(TurnBasedManager.TurnBasedMatchesResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, TurnBasedManager.TurnBasedMatchesResponse> fMgCache4 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache4;
      IntPtr intPtr = Callbacks.ToIntPtr<TurnBasedManager.TurnBasedMatchesResponse>(callback1, fMgCache4);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_FetchMatches(self, fMgCache5, intPtr);
    }

    [MonoPInvokeCallback(typeof (TurnBasedMultiplayerManager.TurnBasedMatchesCallback))]
    internal static void InternalTurnBasedMatchesCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("TurnBasedManager#TurnBasedMatchesCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void AcceptInvitation(MultiplayerInvitation invitation, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      Logger.d("Accepting invitation: " + (object) invitation.AsPointer().ToInt64());
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr invitation1 = invitation.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache6 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache6 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(TurnBasedManager.InternalTurnBasedMatchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchCallback fMgCache6 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache6;
      IntPtr callbackPointer = TurnBasedManager.ToCallbackPointer(callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_AcceptInvitation(self, invitation1, fMgCache6, callbackPointer);
    }

    internal void DeclineInvitation(MultiplayerInvitation invitation)
    {
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_DeclineInvitation(this.mGameServices.AsHandle(), invitation.AsPointer());
    }

    internal void TakeTurn(NativeTurnBasedMatch match, byte[] data, MultiplayerParticipant nextParticipant, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr match1 = match.AsPointer();
      byte[] match_data = data;
      IntPtr num = (IntPtr) new UIntPtr((uint) data.Length);
      IntPtr results = match.Results().AsPointer();
      IntPtr next_participant = nextParticipant.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache7 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache7 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(TurnBasedManager.InternalTurnBasedMatchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchCallback fMgCache7 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache7;
      IntPtr callbackPointer = TurnBasedManager.ToCallbackPointer(callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TakeMyTurn(self, match1, match_data, (UIntPtr) num, results, next_participant, fMgCache7, callbackPointer);
    }

    [MonoPInvokeCallback(typeof (TurnBasedMultiplayerManager.MatchInboxUICallback))]
    internal static void InternalMatchInboxUICallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("TurnBasedManager#MatchInboxUICallback", Callbacks.Type.Temporary, response, data);
    }

    internal void ShowInboxUI(Action<TurnBasedManager.MatchInboxUIResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache9 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache9 = new TurnBasedMultiplayerManager.MatchInboxUICallback(TurnBasedManager.InternalMatchInboxUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.MatchInboxUICallback fMgCache9 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache9;
      Action<TurnBasedManager.MatchInboxUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache8 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache8 = new Func<IntPtr, TurnBasedManager.MatchInboxUIResponse>(TurnBasedManager.MatchInboxUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, TurnBasedManager.MatchInboxUIResponse> fMgCache8 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache8;
      IntPtr intPtr = Callbacks.ToIntPtr<TurnBasedManager.MatchInboxUIResponse>(callback1, fMgCache8);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_ShowMatchInboxUI(self, fMgCache9, intPtr);
    }

    [MonoPInvokeCallback(typeof (TurnBasedMultiplayerManager.MultiplayerStatusCallback))]
    internal static void InternalMultiplayerStatusCallback(CommonErrorStatus.MultiplayerStatus status, IntPtr data)
    {
      Logger.d("InternalMultiplayerStatusCallback: " + (object) status);
      Action<CommonErrorStatus.MultiplayerStatus> tempCallback = Callbacks.IntPtrToTempCallback<Action<CommonErrorStatus.MultiplayerStatus>>(data);
      try
      {
        tempCallback(status);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing InternalMultiplayerStatusCallback. Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal void LeaveDuringMyTurn(NativeTurnBasedMatch match, MultiplayerParticipant nextParticipant, Action<CommonErrorStatus.MultiplayerStatus> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr match1 = match.AsPointer();
      IntPtr next_participant = nextParticipant.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cacheA == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cacheA = new TurnBasedMultiplayerManager.MultiplayerStatusCallback(TurnBasedManager.InternalMultiplayerStatusCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.MultiplayerStatusCallback fMgCacheA = TurnBasedManager.\u003C\u003Ef__mg\u0024cacheA;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_LeaveMatchDuringMyTurn(self, match1, next_participant, fMgCacheA, intPtr);
    }

    internal void FinishMatchDuringMyTurn(NativeTurnBasedMatch match, byte[] data, ParticipantResults results, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr match1 = match.AsPointer();
      byte[] match_data = data;
      IntPtr num = (IntPtr) new UIntPtr((uint) data.Length);
      IntPtr results1 = results.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cacheB == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cacheB = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(TurnBasedManager.InternalTurnBasedMatchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchCallback fMgCacheB = TurnBasedManager.\u003C\u003Ef__mg\u0024cacheB;
      IntPtr callbackPointer = TurnBasedManager.ToCallbackPointer(callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_FinishMatchDuringMyTurn(self, match1, match_data, (UIntPtr) num, results1, fMgCacheB, callbackPointer);
    }

    internal void ConfirmPendingCompletion(NativeTurnBasedMatch match, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr match1 = match.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cacheC == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cacheC = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(TurnBasedManager.InternalTurnBasedMatchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchCallback fMgCacheC = TurnBasedManager.\u003C\u003Ef__mg\u0024cacheC;
      IntPtr callbackPointer = TurnBasedManager.ToCallbackPointer(callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_ConfirmPendingCompletion(self, match1, fMgCacheC, callbackPointer);
    }

    internal void LeaveMatchDuringTheirTurn(NativeTurnBasedMatch match, Action<CommonErrorStatus.MultiplayerStatus> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr match1 = match.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cacheD == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cacheD = new TurnBasedMultiplayerManager.MultiplayerStatusCallback(TurnBasedManager.InternalMultiplayerStatusCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.MultiplayerStatusCallback fMgCacheD = TurnBasedManager.\u003C\u003Ef__mg\u0024cacheD;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_LeaveMatchDuringTheirTurn(self, match1, fMgCacheD, intPtr);
    }

    internal void CancelMatch(NativeTurnBasedMatch match, Action<CommonErrorStatus.MultiplayerStatus> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr match1 = match.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cacheE == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cacheE = new TurnBasedMultiplayerManager.MultiplayerStatusCallback(TurnBasedManager.InternalMultiplayerStatusCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.MultiplayerStatusCallback fMgCacheE = TurnBasedManager.\u003C\u003Ef__mg\u0024cacheE;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_CancelMatch(self, match1, fMgCacheE, intPtr);
    }

    internal void Rematch(NativeTurnBasedMatch match, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr match1 = match.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cacheF == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cacheF = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(TurnBasedManager.InternalTurnBasedMatchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      TurnBasedMultiplayerManager.TurnBasedMatchCallback fMgCacheF = TurnBasedManager.\u003C\u003Ef__mg\u0024cacheF;
      IntPtr callbackPointer = TurnBasedManager.ToCallbackPointer(callback);
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_Rematch(self, match1, fMgCacheF, callbackPointer);
    }

    private static IntPtr ToCallbackPointer(Action<TurnBasedManager.TurnBasedMatchResponse> callback)
    {
      Action<TurnBasedManager.TurnBasedMatchResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (TurnBasedManager.\u003C\u003Ef__mg\u0024cache10 == null)
      {
        // ISSUE: reference to a compiler-generated field
        TurnBasedManager.\u003C\u003Ef__mg\u0024cache10 = new Func<IntPtr, TurnBasedManager.TurnBasedMatchResponse>(TurnBasedManager.TurnBasedMatchResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, TurnBasedManager.TurnBasedMatchResponse> fMgCache10 = TurnBasedManager.\u003C\u003Ef__mg\u0024cache10;
      return Callbacks.ToIntPtr<TurnBasedManager.TurnBasedMatchResponse>(callback1, fMgCache10);
    }

    internal delegate void TurnBasedMatchCallback(TurnBasedManager.TurnBasedMatchResponse response);

    internal class MatchInboxUIResponse : BaseReferenceHolder
    {
      internal MatchInboxUIResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.UIStatus UiStatus()
      {
        return TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_MatchInboxUIResponse_GetStatus(this.SelfPtr());
      }

      internal NativeTurnBasedMatch Match()
      {
        if (this.UiStatus() != CommonErrorStatus.UIStatus.VALID)
          return (NativeTurnBasedMatch) null;
        return new NativeTurnBasedMatch(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_MatchInboxUIResponse_GetMatch(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_MatchInboxUIResponse_Dispose(selfPointer);
      }

      internal static TurnBasedManager.MatchInboxUIResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (TurnBasedManager.MatchInboxUIResponse) null;
        return new TurnBasedManager.MatchInboxUIResponse(pointer);
      }
    }

    internal class TurnBasedMatchResponse : BaseReferenceHolder
    {
      internal TurnBasedMatchResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.MultiplayerStatus ResponseStatus()
      {
        return TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~(CommonErrorStatus.MultiplayerStatus.ERROR_INTERNAL | CommonErrorStatus.MultiplayerStatus.VALID);
      }

      internal NativeTurnBasedMatch Match()
      {
        if (!this.RequestSucceeded())
          return (NativeTurnBasedMatch) null;
        return new NativeTurnBasedMatch(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetMatch(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_Dispose(selfPointer);
      }

      internal static TurnBasedManager.TurnBasedMatchResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (TurnBasedManager.TurnBasedMatchResponse) null;
        return new TurnBasedManager.TurnBasedMatchResponse(pointer);
      }
    }

    internal class TurnBasedMatchesResponse : BaseReferenceHolder
    {
      internal TurnBasedMatchesResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_Dispose(this.SelfPtr());
      }

      internal CommonErrorStatus.MultiplayerStatus Status()
      {
        return TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetStatus(this.SelfPtr());
      }

      internal IEnumerable<MultiplayerInvitation> Invitations()
      {
        return PInvokeUtilities.ToEnumerable<MultiplayerInvitation>(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_Length(this.SelfPtr()), (Func<UIntPtr, MultiplayerInvitation>) (index => new MultiplayerInvitation(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_GetElement(this.SelfPtr(), index))));
      }

      internal int InvitationCount()
      {
        return (int) TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_Length(this.SelfPtr()).ToUInt32();
      }

      internal IEnumerable<NativeTurnBasedMatch> MyTurnMatches()
      {
        return PInvokeUtilities.ToEnumerable<NativeTurnBasedMatch>(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_Length(this.SelfPtr()), (Func<UIntPtr, NativeTurnBasedMatch>) (index => new NativeTurnBasedMatch(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_GetElement(this.SelfPtr(), index))));
      }

      internal int MyTurnMatchesCount()
      {
        return (int) TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_Length(this.SelfPtr()).ToUInt32();
      }

      internal IEnumerable<NativeTurnBasedMatch> TheirTurnMatches()
      {
        return PInvokeUtilities.ToEnumerable<NativeTurnBasedMatch>(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_Length(this.SelfPtr()), (Func<UIntPtr, NativeTurnBasedMatch>) (index => new NativeTurnBasedMatch(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_GetElement(this.SelfPtr(), index))));
      }

      internal int TheirTurnMatchesCount()
      {
        return (int) TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_Length(this.SelfPtr()).ToUInt32();
      }

      internal IEnumerable<NativeTurnBasedMatch> CompletedMatches()
      {
        return PInvokeUtilities.ToEnumerable<NativeTurnBasedMatch>(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_Length(this.SelfPtr()), (Func<UIntPtr, NativeTurnBasedMatch>) (index => new NativeTurnBasedMatch(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_GetElement(this.SelfPtr(), index))));
      }

      internal int CompletedMatchesCount()
      {
        return (int) TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_Length(this.SelfPtr()).ToUInt32();
      }

      internal static TurnBasedManager.TurnBasedMatchesResponse FromPointer(IntPtr pointer)
      {
        if (PInvokeUtilities.IsNull(pointer))
          return (TurnBasedManager.TurnBasedMatchesResponse) null;
        return new TurnBasedManager.TurnBasedMatchesResponse(pointer);
      }
    }
  }
}
