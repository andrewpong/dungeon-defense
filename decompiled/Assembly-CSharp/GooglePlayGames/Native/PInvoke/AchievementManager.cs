// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.AchievementManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class AchievementManager
  {
    private readonly GameServices mServices;

    internal AchievementManager(GameServices services)
    {
      this.mServices = Misc.CheckNotNull<GameServices>(services);
    }

    internal void ShowAllUI(Action<CommonErrorStatus.UIStatus> callback)
    {
      Misc.CheckNotNull<Action<CommonErrorStatus.UIStatus>>(callback);
      HandleRef self = this.mServices.AsHandle();
      // ISSUE: reference to a compiler-generated field
      if (AchievementManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        AchievementManager.\u003C\u003Ef__mg\u0024cache0 = new GooglePlayGames.Native.Cwrapper.AchievementManager.ShowAllUICallback(Callbacks.InternalShowUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.AchievementManager.ShowAllUICallback fMgCache0 = AchievementManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_ShowAllUI(self, fMgCache0, intPtr);
    }

    internal void FetchAll(Action<AchievementManager.FetchAllResponse> callback)
    {
      Misc.CheckNotNull<Action<AchievementManager.FetchAllResponse>>(callback);
      HandleRef self = this.mServices.AsHandle();
      int num = 1;
      // ISSUE: reference to a compiler-generated field
      if (AchievementManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        AchievementManager.\u003C\u003Ef__mg\u0024cache2 = new GooglePlayGames.Native.Cwrapper.AchievementManager.FetchAllCallback(AchievementManager.InternalFetchAllCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.AchievementManager.FetchAllCallback fMgCache2 = AchievementManager.\u003C\u003Ef__mg\u0024cache2;
      Action<AchievementManager.FetchAllResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (AchievementManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        AchievementManager.\u003C\u003Ef__mg\u0024cache1 = new Func<IntPtr, AchievementManager.FetchAllResponse>(AchievementManager.FetchAllResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, AchievementManager.FetchAllResponse> fMgCache1 = AchievementManager.\u003C\u003Ef__mg\u0024cache1;
      IntPtr intPtr = Callbacks.ToIntPtr<AchievementManager.FetchAllResponse>(callback1, fMgCache1);
      GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchAll(self, (Types.DataSource) num, fMgCache2, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.AchievementManager.FetchAllCallback))]
    private static void InternalFetchAllCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("AchievementManager#InternalFetchAllCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Fetch(string achId, Action<AchievementManager.FetchResponse> callback)
    {
      Misc.CheckNotNull<string>(achId);
      Misc.CheckNotNull<Action<AchievementManager.FetchResponse>>(callback);
      HandleRef self = this.mServices.AsHandle();
      int num = 1;
      string achievement_id = achId;
      // ISSUE: reference to a compiler-generated field
      if (AchievementManager.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        AchievementManager.\u003C\u003Ef__mg\u0024cache4 = new GooglePlayGames.Native.Cwrapper.AchievementManager.FetchCallback(AchievementManager.InternalFetchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.AchievementManager.FetchCallback fMgCache4 = AchievementManager.\u003C\u003Ef__mg\u0024cache4;
      Action<AchievementManager.FetchResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (AchievementManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        AchievementManager.\u003C\u003Ef__mg\u0024cache3 = new Func<IntPtr, AchievementManager.FetchResponse>(AchievementManager.FetchResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, AchievementManager.FetchResponse> fMgCache3 = AchievementManager.\u003C\u003Ef__mg\u0024cache3;
      IntPtr intPtr = Callbacks.ToIntPtr<AchievementManager.FetchResponse>(callback1, fMgCache3);
      GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Fetch(self, (Types.DataSource) num, achievement_id, fMgCache4, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.AchievementManager.FetchCallback))]
    private static void InternalFetchCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("AchievementManager#InternalFetchCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Increment(string achievementId, uint numSteps)
    {
      Misc.CheckNotNull<string>(achievementId);
      GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Increment(this.mServices.AsHandle(), achievementId, numSteps);
    }

    internal void SetStepsAtLeast(string achivementId, uint numSteps)
    {
      Misc.CheckNotNull<string>(achivementId);
      GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_SetStepsAtLeast(this.mServices.AsHandle(), achivementId, numSteps);
    }

    internal void Reveal(string achievementId)
    {
      Misc.CheckNotNull<string>(achievementId);
      GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Reveal(this.mServices.AsHandle(), achievementId);
    }

    internal void Unlock(string achievementId)
    {
      Misc.CheckNotNull<string>(achievementId);
      GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Unlock(this.mServices.AsHandle(), achievementId);
    }

    internal class FetchResponse : BaseReferenceHolder
    {
      internal FetchResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus Status()
      {
        return GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchResponse_GetStatus(this.SelfPtr());
      }

      internal NativeAchievement Achievement()
      {
        return new NativeAchievement(GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchResponse_GetData(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchResponse_Dispose(selfPointer);
      }

      internal static AchievementManager.FetchResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (AchievementManager.FetchResponse) null;
        return new AchievementManager.FetchResponse(pointer);
      }
    }

    internal class FetchAllResponse : BaseReferenceHolder, IEnumerable<NativeAchievement>, IEnumerable
    {
      internal FetchAllResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus Status()
      {
        return GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchAllResponse_GetStatus(this.SelfPtr());
      }

      private UIntPtr Length()
      {
        return GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchAllResponse_GetData_Length(this.SelfPtr());
      }

      private NativeAchievement GetElement(UIntPtr index)
      {
        if (index.ToUInt64() >= this.Length().ToUInt64())
          throw new ArgumentOutOfRangeException();
        return new NativeAchievement(GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchAllResponse_GetData_GetElement(this.SelfPtr(), index));
      }

      public IEnumerator<NativeAchievement> GetEnumerator()
      {
        return PInvokeUtilities.ToEnumerator<NativeAchievement>(GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchAllResponse_GetData_Length(this.SelfPtr()), (Func<UIntPtr, NativeAchievement>) (index => this.GetElement(index)));
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return (IEnumerator) this.GetEnumerator();
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchAllResponse_Dispose(selfPointer);
      }

      internal static AchievementManager.FetchAllResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (AchievementManager.FetchAllResponse) null;
        return new AchievementManager.FetchAllResponse(pointer);
      }
    }
  }
}
