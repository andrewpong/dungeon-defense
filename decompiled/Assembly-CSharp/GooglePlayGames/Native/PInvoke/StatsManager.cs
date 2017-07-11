// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.StatsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class StatsManager
  {
    private readonly GameServices mServices;

    internal StatsManager(GameServices services)
    {
      this.mServices = Misc.CheckNotNull<GameServices>(services);
    }

    internal void FetchForPlayer(Action<StatsManager.FetchForPlayerResponse> callback)
    {
      Misc.CheckNotNull<Action<StatsManager.FetchForPlayerResponse>>(callback);
      HandleRef self = this.mServices.AsHandle();
      int num = 1;
      // ISSUE: reference to a compiler-generated field
      if (StatsManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        StatsManager.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.StatsManager.FetchForPlayerCallback(StatsManager.InternalFetchForPlayerCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.StatsManager.FetchForPlayerCallback fMgCache1 = StatsManager.\u003C\u003Ef__mg\u0024cache1;
      Action<StatsManager.FetchForPlayerResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (StatsManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        StatsManager.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, StatsManager.FetchForPlayerResponse>(StatsManager.FetchForPlayerResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, StatsManager.FetchForPlayerResponse> fMgCache0 = StatsManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr<StatsManager.FetchForPlayerResponse>(callback1, fMgCache0);
      GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayer(self, (Types.DataSource) num, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.StatsManager.FetchForPlayerCallback))]
    private static void InternalFetchForPlayerCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("StatsManager#InternalFetchForPlayerCallback", Callbacks.Type.Temporary, response, data);
    }

    internal class FetchForPlayerResponse : BaseReferenceHolder
    {
      internal FetchForPlayerResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus Status()
      {
        return GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayerResponse_GetStatus(this.SelfPtr());
      }

      internal NativePlayerStats PlayerStats()
      {
        return new NativePlayerStats(GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayerResponse_GetData(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayerResponse_Dispose(selfPointer);
      }

      internal static StatsManager.FetchForPlayerResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (StatsManager.FetchForPlayerResponse) null;
        return new StatsManager.FetchForPlayerResponse(pointer);
      }
    }
  }
}
