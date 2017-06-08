// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.QuestManager
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
  internal class QuestManager
  {
    private readonly GameServices mServices;

    internal QuestManager(GameServices services)
    {
      this.mServices = Misc.CheckNotNull<GameServices>(services);
    }

    internal void Fetch(Types.DataSource source, string questId, Action<QuestManager.FetchResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      int num = (int) source;
      string quest_id = questId;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.QuestManager.FetchCallback(QuestManager.InternalFetchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.QuestManager.FetchCallback fMgCache1 = QuestManager.\u003C\u003Ef__mg\u0024cache1;
      Action<QuestManager.FetchResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, QuestManager.FetchResponse>(QuestManager.FetchResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, QuestManager.FetchResponse> fMgCache0 = QuestManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr<QuestManager.FetchResponse>(callback1, fMgCache0);
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_Fetch(self, (Types.DataSource) num, quest_id, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.QuestManager.FetchCallback))]
    internal static void InternalFetchCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("QuestManager#FetchCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void FetchList(Types.DataSource source, int fetchFlags, Action<QuestManager.FetchListResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      int num = (int) source;
      int fetch_flags = fetchFlags;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache3 = new GooglePlayGames.Native.Cwrapper.QuestManager.FetchListCallback(QuestManager.InternalFetchListCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.QuestManager.FetchListCallback fMgCache3 = QuestManager.\u003C\u003Ef__mg\u0024cache3;
      Action<QuestManager.FetchListResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache2 = new Func<IntPtr, QuestManager.FetchListResponse>(QuestManager.FetchListResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, QuestManager.FetchListResponse> fMgCache2 = QuestManager.\u003C\u003Ef__mg\u0024cache2;
      IntPtr intPtr = Callbacks.ToIntPtr<QuestManager.FetchListResponse>(callback1, fMgCache2);
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchList(self, (Types.DataSource) num, fetch_flags, fMgCache3, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.QuestManager.FetchListCallback))]
    internal static void InternalFetchListCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("QuestManager#FetchListCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void ShowAllQuestUI(Action<QuestManager.QuestUIResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache5 = new GooglePlayGames.Native.Cwrapper.QuestManager.QuestUICallback(QuestManager.InternalQuestUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestUICallback fMgCache5 = QuestManager.\u003C\u003Ef__mg\u0024cache5;
      Action<QuestManager.QuestUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache4 = new Func<IntPtr, QuestManager.QuestUIResponse>(QuestManager.QuestUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, QuestManager.QuestUIResponse> fMgCache4 = QuestManager.\u003C\u003Ef__mg\u0024cache4;
      IntPtr intPtr = Callbacks.ToIntPtr<QuestManager.QuestUIResponse>(callback1, fMgCache4);
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_ShowAllUI(self, fMgCache5, intPtr);
    }

    internal void ShowQuestUI(NativeQuest quest, Action<QuestManager.QuestUIResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      IntPtr quest1 = quest.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache7 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache7 = new GooglePlayGames.Native.Cwrapper.QuestManager.QuestUICallback(QuestManager.InternalQuestUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestUICallback fMgCache7 = QuestManager.\u003C\u003Ef__mg\u0024cache7;
      Action<QuestManager.QuestUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache6 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache6 = new Func<IntPtr, QuestManager.QuestUIResponse>(QuestManager.QuestUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, QuestManager.QuestUIResponse> fMgCache6 = QuestManager.\u003C\u003Ef__mg\u0024cache6;
      IntPtr intPtr = Callbacks.ToIntPtr<QuestManager.QuestUIResponse>(callback1, fMgCache6);
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_ShowUI(self, quest1, fMgCache7, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.QuestManager.QuestUICallback))]
    internal static void InternalQuestUICallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("QuestManager#QuestUICallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Accept(NativeQuest quest, Action<QuestManager.AcceptResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      IntPtr quest1 = quest.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache9 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache9 = new GooglePlayGames.Native.Cwrapper.QuestManager.AcceptCallback(QuestManager.InternalAcceptCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.QuestManager.AcceptCallback fMgCache9 = QuestManager.\u003C\u003Ef__mg\u0024cache9;
      Action<QuestManager.AcceptResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cache8 == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cache8 = new Func<IntPtr, QuestManager.AcceptResponse>(QuestManager.AcceptResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, QuestManager.AcceptResponse> fMgCache8 = QuestManager.\u003C\u003Ef__mg\u0024cache8;
      IntPtr intPtr = Callbacks.ToIntPtr<QuestManager.AcceptResponse>(callback1, fMgCache8);
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_Accept(self, quest1, fMgCache9, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.QuestManager.AcceptCallback))]
    internal static void InternalAcceptCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("QuestManager#AcceptCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void ClaimMilestone(NativeQuestMilestone milestone, Action<QuestManager.ClaimMilestoneResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      IntPtr milestone1 = milestone.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cacheB == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cacheB = new GooglePlayGames.Native.Cwrapper.QuestManager.ClaimMilestoneCallback(QuestManager.InternalClaimMilestoneCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.QuestManager.ClaimMilestoneCallback fMgCacheB = QuestManager.\u003C\u003Ef__mg\u0024cacheB;
      Action<QuestManager.ClaimMilestoneResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (QuestManager.\u003C\u003Ef__mg\u0024cacheA == null)
      {
        // ISSUE: reference to a compiler-generated field
        QuestManager.\u003C\u003Ef__mg\u0024cacheA = new Func<IntPtr, QuestManager.ClaimMilestoneResponse>(QuestManager.ClaimMilestoneResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, QuestManager.ClaimMilestoneResponse> fMgCacheA = QuestManager.\u003C\u003Ef__mg\u0024cacheA;
      IntPtr intPtr = Callbacks.ToIntPtr<QuestManager.ClaimMilestoneResponse>(callback1, fMgCacheA);
      GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_ClaimMilestone(self, milestone1, fMgCacheB, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.QuestManager.ClaimMilestoneCallback))]
    internal static void InternalClaimMilestoneCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("QuestManager#ClaimMilestoneCallback", Callbacks.Type.Temporary, response, data);
    }

    internal class FetchResponse : BaseReferenceHolder
    {
      internal FetchResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchResponse_GetStatus(this.SelfPtr());
      }

      internal NativeQuest Data()
      {
        if (!this.RequestSucceeded())
          return (NativeQuest) null;
        return new NativeQuest(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchResponse_GetData(this.SelfPtr()));
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchResponse_Dispose(selfPointer);
      }

      internal static QuestManager.FetchResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (QuestManager.FetchResponse) null;
        return new QuestManager.FetchResponse(pointer);
      }
    }

    internal class FetchListResponse : BaseReferenceHolder
    {
      internal FetchListResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchListResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      internal IEnumerable<NativeQuest> Data()
      {
        return PInvokeUtilities.ToEnumerable<NativeQuest>(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchListResponse_GetData_Length(this.SelfPtr()), (Func<UIntPtr, NativeQuest>) (index => new NativeQuest(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchListResponse_GetData_GetElement(this.SelfPtr(), index))));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_FetchListResponse_Dispose(selfPointer);
      }

      internal static QuestManager.FetchListResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (QuestManager.FetchListResponse) null;
        return new QuestManager.FetchListResponse(pointer);
      }
    }

    internal class ClaimMilestoneResponse : BaseReferenceHolder
    {
      internal ClaimMilestoneResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.QuestClaimMilestoneStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_ClaimMilestoneResponse_GetStatus(this.SelfPtr());
      }

      internal NativeQuest Quest()
      {
        if (!this.RequestSucceeded())
          return (NativeQuest) null;
        NativeQuest nativeQuest = new NativeQuest(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_ClaimMilestoneResponse_GetQuest(this.SelfPtr()));
        if (nativeQuest.Valid())
          return nativeQuest;
        nativeQuest.Dispose();
        return (NativeQuest) null;
      }

      internal NativeQuestMilestone ClaimedMilestone()
      {
        if (!this.RequestSucceeded())
          return (NativeQuestMilestone) null;
        NativeQuestMilestone nativeQuestMilestone = new NativeQuestMilestone(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_ClaimMilestoneResponse_GetClaimedMilestone(this.SelfPtr()));
        if (nativeQuestMilestone.Valid())
          return nativeQuestMilestone;
        nativeQuestMilestone.Dispose();
        return (NativeQuestMilestone) null;
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~(CommonErrorStatus.QuestClaimMilestoneStatus.ERROR_INTERNAL | CommonErrorStatus.QuestClaimMilestoneStatus.VALID);
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_ClaimMilestoneResponse_Dispose(selfPointer);
      }

      internal static QuestManager.ClaimMilestoneResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (QuestManager.ClaimMilestoneResponse) null;
        return new QuestManager.ClaimMilestoneResponse(pointer);
      }
    }

    internal class AcceptResponse : BaseReferenceHolder
    {
      internal AcceptResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.QuestAcceptStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_AcceptResponse_GetStatus(this.SelfPtr());
      }

      internal NativeQuest AcceptedQuest()
      {
        if (!this.RequestSucceeded())
          return (NativeQuest) null;
        return new NativeQuest(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_AcceptResponse_GetAcceptedQuest(this.SelfPtr()));
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~(CommonErrorStatus.QuestAcceptStatus.ERROR_INTERNAL | CommonErrorStatus.QuestAcceptStatus.VALID);
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_AcceptResponse_Dispose(selfPointer);
      }

      internal static QuestManager.AcceptResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (QuestManager.AcceptResponse) null;
        return new QuestManager.AcceptResponse(pointer);
      }
    }

    internal class QuestUIResponse : BaseReferenceHolder
    {
      internal QuestUIResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.UIStatus RequestStatus()
      {
        return GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_QuestUIResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.RequestStatus() > ~(CommonErrorStatus.UIStatus.ERROR_INTERNAL | CommonErrorStatus.UIStatus.VALID);
      }

      internal NativeQuest AcceptedQuest()
      {
        if (!this.RequestSucceeded())
          return (NativeQuest) null;
        NativeQuest nativeQuest = new NativeQuest(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_QuestUIResponse_GetAcceptedQuest(this.SelfPtr()));
        if (nativeQuest.Valid())
          return nativeQuest;
        nativeQuest.Dispose();
        return (NativeQuest) null;
      }

      internal NativeQuestMilestone MilestoneToClaim()
      {
        if (!this.RequestSucceeded())
          return (NativeQuestMilestone) null;
        NativeQuestMilestone nativeQuestMilestone = new NativeQuestMilestone(GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_QuestUIResponse_GetMilestoneToClaim(this.SelfPtr()));
        if (nativeQuestMilestone.Valid())
          return nativeQuestMilestone;
        nativeQuestMilestone.Dispose();
        return (NativeQuestMilestone) null;
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.QuestManager.QuestManager_QuestUIResponse_Dispose(selfPointer);
      }

      internal static QuestManager.QuestUIResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (QuestManager.QuestUIResponse) null;
        return new QuestManager.QuestUIResponse(pointer);
      }
    }
  }
}
