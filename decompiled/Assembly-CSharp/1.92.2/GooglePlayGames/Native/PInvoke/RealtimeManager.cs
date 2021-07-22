// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.RealtimeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class RealtimeManager
  {
    private readonly GameServices mGameServices;

    internal RealtimeManager(GameServices gameServices)
    {
      this.mGameServices = Misc.CheckNotNull<GameServices>(gameServices);
    }

    internal void CreateRoom(RealtimeRoomConfig config, RealTimeEventListenerHelper helper, Action<RealtimeManager.RealTimeRoomResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr config1 = config.AsPointer();
      IntPtr helper1 = helper.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache0 = new RealTimeMultiplayerManager.RealTimeRoomCallback(RealtimeManager.InternalRealTimeRoomCallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.RealTimeRoomCallback fMgCache0 = RealtimeManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr callbackPointer = RealtimeManager.ToCallbackPointer(callback);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_CreateRealTimeRoom(self, config1, helper1, fMgCache0, callbackPointer);
    }

    internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, Action<PlayerSelectUIResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      int num1 = (int) minimumPlayers;
      int num2 = (int) maxiumPlayers;
      int num3 = allowAutomatching ? 1 : 0;
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache2 = new RealTimeMultiplayerManager.PlayerSelectUICallback(RealtimeManager.InternalPlayerSelectUIcallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.PlayerSelectUICallback fMgCache2 = RealtimeManager.\u003C\u003Ef__mg\u0024cache2;
      Action<PlayerSelectUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache1 = new Func<IntPtr, PlayerSelectUIResponse>(PlayerSelectUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, PlayerSelectUIResponse> fMgCache1 = RealtimeManager.\u003C\u003Ef__mg\u0024cache1;
      IntPtr intPtr = Callbacks.ToIntPtr<PlayerSelectUIResponse>(callback1, fMgCache1);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_ShowPlayerSelectUI(self, (uint) num1, (uint) num2, num3 != 0, fMgCache2, intPtr);
    }

    [MonoPInvokeCallback(typeof (RealTimeMultiplayerManager.PlayerSelectUICallback))]
    internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("RealtimeManager#PlayerSelectUICallback", Callbacks.Type.Temporary, response, data);
    }

    [MonoPInvokeCallback(typeof (RealTimeMultiplayerManager.RealTimeRoomCallback))]
    internal static void InternalRealTimeRoomCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("RealtimeManager#InternalRealTimeRoomCallback", Callbacks.Type.Temporary, response, data);
    }

    [MonoPInvokeCallback(typeof (RealTimeMultiplayerManager.RoomInboxUICallback))]
    internal static void InternalRoomInboxUICallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("RealtimeManager#InternalRoomInboxUICallback", Callbacks.Type.Temporary, response, data);
    }

    internal void ShowRoomInboxUI(Action<RealtimeManager.RoomInboxUIResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache4 = new RealTimeMultiplayerManager.RoomInboxUICallback(RealtimeManager.InternalRoomInboxUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.RoomInboxUICallback fMgCache4 = RealtimeManager.\u003C\u003Ef__mg\u0024cache4;
      Action<RealtimeManager.RoomInboxUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache3 = new Func<IntPtr, RealtimeManager.RoomInboxUIResponse>(RealtimeManager.RoomInboxUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, RealtimeManager.RoomInboxUIResponse> fMgCache3 = RealtimeManager.\u003C\u003Ef__mg\u0024cache3;
      IntPtr intPtr = Callbacks.ToIntPtr<RealtimeManager.RoomInboxUIResponse>(callback1, fMgCache3);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_ShowRoomInboxUI(self, fMgCache4, intPtr);
    }

    internal void ShowWaitingRoomUI(NativeRealTimeRoom room, uint minimumParticipantsBeforeStarting, Action<RealtimeManager.WaitingRoomUIResponse> callback)
    {
      Misc.CheckNotNull<NativeRealTimeRoom>(room);
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr room1 = room.AsPointer();
      int num = (int) minimumParticipantsBeforeStarting;
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache6 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache6 = new RealTimeMultiplayerManager.WaitingRoomUICallback(RealtimeManager.InternalWaitingRoomUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.WaitingRoomUICallback fMgCache6 = RealtimeManager.\u003C\u003Ef__mg\u0024cache6;
      Action<RealtimeManager.WaitingRoomUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache5 = new Func<IntPtr, RealtimeManager.WaitingRoomUIResponse>(RealtimeManager.WaitingRoomUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, RealtimeManager.WaitingRoomUIResponse> fMgCache5 = RealtimeManager.\u003C\u003Ef__mg\u0024cache5;
      IntPtr intPtr = Callbacks.ToIntPtr<RealtimeManager.WaitingRoomUIResponse>(callback1, fMgCache5);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_ShowWaitingRoomUI(self, room1, (uint) num, fMgCache6, intPtr);
    }

    [MonoPInvokeCallback(typeof (RealTimeMultiplayerManager.WaitingRoomUICallback))]
    internal static void InternalWaitingRoomUICallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("RealtimeManager#InternalWaitingRoomUICallback", Callbacks.Type.Temporary, response, data);
    }

    [MonoPInvokeCallback(typeof (RealTimeMultiplayerManager.FetchInvitationsCallback))]
    internal static void InternalFetchInvitationsCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("RealtimeManager#InternalFetchInvitationsCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void FetchInvitations(Action<RealtimeManager.FetchInvitationsResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache8 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache8 = new RealTimeMultiplayerManager.FetchInvitationsCallback(RealtimeManager.InternalFetchInvitationsCallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.FetchInvitationsCallback fMgCache8 = RealtimeManager.\u003C\u003Ef__mg\u0024cache8;
      Action<RealtimeManager.FetchInvitationsResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache7 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache7 = new Func<IntPtr, RealtimeManager.FetchInvitationsResponse>(RealtimeManager.FetchInvitationsResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, RealtimeManager.FetchInvitationsResponse> fMgCache7 = RealtimeManager.\u003C\u003Ef__mg\u0024cache7;
      IntPtr intPtr = Callbacks.ToIntPtr<RealtimeManager.FetchInvitationsResponse>(callback1, fMgCache7);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitations(self, fMgCache8, intPtr);
    }

    [MonoPInvokeCallback(typeof (RealTimeMultiplayerManager.LeaveRoomCallback))]
    internal static void InternalLeaveRoomCallback(CommonErrorStatus.ResponseStatus response, IntPtr data)
    {
      Logger.d("Entering internal callback for InternalLeaveRoomCallback");
      Action<CommonErrorStatus.ResponseStatus> tempCallback = Callbacks.IntPtrToTempCallback<Action<CommonErrorStatus.ResponseStatus>>(data);
      if (tempCallback == null)
        return;
      try
      {
        tempCallback(response);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing InternalLeaveRoomCallback. Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal void LeaveRoom(NativeRealTimeRoom room, Action<CommonErrorStatus.ResponseStatus> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr room1 = room.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cache9 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cache9 = new RealTimeMultiplayerManager.LeaveRoomCallback(RealtimeManager.InternalLeaveRoomCallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.LeaveRoomCallback fMgCache9 = RealtimeManager.\u003C\u003Ef__mg\u0024cache9;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_LeaveRoom(self, room1, fMgCache9, intPtr);
    }

    internal void AcceptInvitation(MultiplayerInvitation invitation, RealTimeEventListenerHelper listener, Action<RealtimeManager.RealTimeRoomResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr invitation1 = invitation.AsPointer();
      IntPtr helper = listener.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cacheA == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cacheA = new RealTimeMultiplayerManager.RealTimeRoomCallback(RealtimeManager.InternalRealTimeRoomCallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.RealTimeRoomCallback fMgCacheA = RealtimeManager.\u003C\u003Ef__mg\u0024cacheA;
      IntPtr callbackPointer = RealtimeManager.ToCallbackPointer(callback);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_AcceptInvitation(self, invitation1, helper, fMgCacheA, callbackPointer);
    }

    internal void DeclineInvitation(MultiplayerInvitation invitation)
    {
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_DeclineInvitation(this.mGameServices.AsHandle(), invitation.AsPointer());
    }

    internal void SendReliableMessage(NativeRealTimeRoom room, MultiplayerParticipant participant, byte[] data, Action<CommonErrorStatus.MultiplayerStatus> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      IntPtr room1 = room.AsPointer();
      IntPtr participant1 = participant.AsPointer();
      byte[] data1 = data;
      IntPtr sizeT = (IntPtr) PInvokeUtilities.ArrayToSizeT<byte>(data);
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cacheB == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cacheB = new RealTimeMultiplayerManager.SendReliableMessageCallback(RealtimeManager.InternalSendReliableMessageCallback);
      }
      // ISSUE: reference to a compiler-generated field
      RealTimeMultiplayerManager.SendReliableMessageCallback fMgCacheB = RealtimeManager.\u003C\u003Ef__mg\u0024cacheB;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_SendReliableMessage(self, room1, participant1, data1, (UIntPtr) sizeT, fMgCacheB, intPtr);
    }

    [MonoPInvokeCallback(typeof (RealTimeMultiplayerManager.SendReliableMessageCallback))]
    internal static void InternalSendReliableMessageCallback(CommonErrorStatus.MultiplayerStatus response, IntPtr data)
    {
      Logger.d("Entering internal callback for InternalSendReliableMessageCallback " + (object) response);
      Action<CommonErrorStatus.MultiplayerStatus> tempCallback = Callbacks.IntPtrToTempCallback<Action<CommonErrorStatus.MultiplayerStatus>>(data);
      if (tempCallback == null)
        return;
      try
      {
        tempCallback(response);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing InternalSendReliableMessageCallback. Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal void SendUnreliableMessageToAll(NativeRealTimeRoom room, byte[] data)
    {
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_SendUnreliableMessageToOthers(this.mGameServices.AsHandle(), room.AsPointer(), data, PInvokeUtilities.ArrayToSizeT<byte>(data));
    }

    internal void SendUnreliableMessageToSpecificParticipants(NativeRealTimeRoom room, List<MultiplayerParticipant> recipients, byte[] data)
    {
      RealTimeMultiplayerManager.RealTimeMultiplayerManager_SendUnreliableMessage(this.mGameServices.AsHandle(), room.AsPointer(), recipients.Select<MultiplayerParticipant, IntPtr>((Func<MultiplayerParticipant, IntPtr>) (r => r.AsPointer())).ToArray<IntPtr>(), new UIntPtr((ulong) recipients.LongCount<MultiplayerParticipant>()), data, PInvokeUtilities.ArrayToSizeT<byte>(data));
    }

    private static IntPtr ToCallbackPointer(Action<RealtimeManager.RealTimeRoomResponse> callback)
    {
      Action<RealtimeManager.RealTimeRoomResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (RealtimeManager.\u003C\u003Ef__mg\u0024cacheC == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealtimeManager.\u003C\u003Ef__mg\u0024cacheC = new Func<IntPtr, RealtimeManager.RealTimeRoomResponse>(RealtimeManager.RealTimeRoomResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, RealtimeManager.RealTimeRoomResponse> fMgCacheC = RealtimeManager.\u003C\u003Ef__mg\u0024cacheC;
      return Callbacks.ToIntPtr<RealtimeManager.RealTimeRoomResponse>(callback1, fMgCacheC);
    }

    internal class RealTimeRoomResponse : BaseReferenceHolder
    {
      internal RealTimeRoomResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.MultiplayerStatus ResponseStatus()
      {
        return RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~(CommonErrorStatus.MultiplayerStatus.ERROR_INTERNAL | CommonErrorStatus.MultiplayerStatus.VALID);
      }

      internal NativeRealTimeRoom Room()
      {
        if (!this.RequestSucceeded())
          return (NativeRealTimeRoom) null;
        return new NativeRealTimeRoom(RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_GetRoom(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_Dispose(selfPointer);
      }

      internal static RealtimeManager.RealTimeRoomResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (RealtimeManager.RealTimeRoomResponse) null;
        return new RealtimeManager.RealTimeRoomResponse(pointer);
      }
    }

    internal class RoomInboxUIResponse : BaseReferenceHolder
    {
      internal RoomInboxUIResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.UIStatus ResponseStatus()
      {
        return RealTimeMultiplayerManager.RealTimeMultiplayerManager_RoomInboxUIResponse_GetStatus(this.SelfPtr());
      }

      internal MultiplayerInvitation Invitation()
      {
        if (this.ResponseStatus() != CommonErrorStatus.UIStatus.VALID)
          return (MultiplayerInvitation) null;
        return new MultiplayerInvitation(RealTimeMultiplayerManager.RealTimeMultiplayerManager_RoomInboxUIResponse_GetInvitation(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        RealTimeMultiplayerManager.RealTimeMultiplayerManager_RoomInboxUIResponse_Dispose(selfPointer);
      }

      internal static RealtimeManager.RoomInboxUIResponse FromPointer(IntPtr pointer)
      {
        if (PInvokeUtilities.IsNull(pointer))
          return (RealtimeManager.RoomInboxUIResponse) null;
        return new RealtimeManager.RoomInboxUIResponse(pointer);
      }
    }

    internal class WaitingRoomUIResponse : BaseReferenceHolder
    {
      internal WaitingRoomUIResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.UIStatus ResponseStatus()
      {
        return RealTimeMultiplayerManager.RealTimeMultiplayerManager_WaitingRoomUIResponse_GetStatus(this.SelfPtr());
      }

      internal NativeRealTimeRoom Room()
      {
        if (this.ResponseStatus() != CommonErrorStatus.UIStatus.VALID)
          return (NativeRealTimeRoom) null;
        return new NativeRealTimeRoom(RealTimeMultiplayerManager.RealTimeMultiplayerManager_WaitingRoomUIResponse_GetRoom(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        RealTimeMultiplayerManager.RealTimeMultiplayerManager_WaitingRoomUIResponse_Dispose(selfPointer);
      }

      internal static RealtimeManager.WaitingRoomUIResponse FromPointer(IntPtr pointer)
      {
        if (PInvokeUtilities.IsNull(pointer))
          return (RealtimeManager.WaitingRoomUIResponse) null;
        return new RealtimeManager.WaitingRoomUIResponse(pointer);
      }
    }

    internal class FetchInvitationsResponse : BaseReferenceHolder
    {
      internal FetchInvitationsResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_GetStatus(this.SelfPtr());
      }

      internal IEnumerable<MultiplayerInvitation> Invitations()
      {
        return PInvokeUtilities.ToEnumerable<MultiplayerInvitation>(RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_Length(this.SelfPtr()), (Func<UIntPtr, MultiplayerInvitation>) (index => new MultiplayerInvitation(RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_GetElement(this.SelfPtr(), index))));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_Dispose(selfPointer);
      }

      internal static RealtimeManager.FetchInvitationsResponse FromPointer(IntPtr pointer)
      {
        if (PInvokeUtilities.IsNull(pointer))
          return (RealtimeManager.FetchInvitationsResponse) null;
        return new RealtimeManager.FetchInvitationsResponse(pointer);
      }
    }
  }
}
