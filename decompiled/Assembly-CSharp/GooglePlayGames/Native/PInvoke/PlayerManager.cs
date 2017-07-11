// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.PlayerManager
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
  internal class PlayerManager
  {
    private readonly GameServices mGameServices;

    internal PlayerManager(GameServices services)
    {
      this.mGameServices = Misc.CheckNotNull<GameServices>(services);
    }

    internal void FetchSelf(Action<PlayerManager.FetchSelfResponse> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      int num = 1;
      // ISSUE: reference to a compiler-generated field
      if (PlayerManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        PlayerManager.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.PlayerManager.FetchSelfCallback(PlayerManager.InternalFetchSelfCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.PlayerManager.FetchSelfCallback fMgCache1 = PlayerManager.\u003C\u003Ef__mg\u0024cache1;
      Action<PlayerManager.FetchSelfResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (PlayerManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        PlayerManager.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, PlayerManager.FetchSelfResponse>(PlayerManager.FetchSelfResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, PlayerManager.FetchSelfResponse> fMgCache0 = PlayerManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr<PlayerManager.FetchSelfResponse>(callback1, fMgCache0);
      GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchSelf(self, (Types.DataSource) num, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.PlayerManager.FetchSelfCallback))]
    private static void InternalFetchSelfCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("PlayerManager#InternalFetchSelfCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void FetchList(string[] userIds, Action<NativePlayer[]> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlayerManager.\u003CFetchList\u003Ec__AnonStorey0 listCAnonStorey0 = new PlayerManager.\u003CFetchList\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      listCAnonStorey0.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      listCAnonStorey0.coll = new PlayerManager.FetchResponseCollector();
      // ISSUE: reference to a compiler-generated field
      listCAnonStorey0.coll.pendingCount = userIds.Length;
      // ISSUE: reference to a compiler-generated field
      listCAnonStorey0.coll.callback = callback;
      foreach (string userId in userIds)
      {
        HandleRef self = this.mGameServices.AsHandle();
        int num = 1;
        string player_id = userId;
        // ISSUE: reference to a compiler-generated field
        if (PlayerManager.\u003C\u003Ef__mg\u0024cache3 == null)
        {
          // ISSUE: reference to a compiler-generated field
          PlayerManager.\u003C\u003Ef__mg\u0024cache3 = new GooglePlayGames.Native.Cwrapper.PlayerManager.FetchCallback(PlayerManager.InternalFetchCallback);
        }
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.Native.Cwrapper.PlayerManager.FetchCallback fMgCache3 = PlayerManager.\u003C\u003Ef__mg\u0024cache3;
        // ISSUE: reference to a compiler-generated method
        Action<PlayerManager.FetchResponse> callback1 = new Action<PlayerManager.FetchResponse>(listCAnonStorey0.\u003C\u003Em__0);
        // ISSUE: reference to a compiler-generated field
        if (PlayerManager.\u003C\u003Ef__mg\u0024cache2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          PlayerManager.\u003C\u003Ef__mg\u0024cache2 = new Func<IntPtr, PlayerManager.FetchResponse>(PlayerManager.FetchResponse.FromPointer);
        }
        // ISSUE: reference to a compiler-generated field
        Func<IntPtr, PlayerManager.FetchResponse> fMgCache2 = PlayerManager.\u003C\u003Ef__mg\u0024cache2;
        IntPtr intPtr = Callbacks.ToIntPtr<PlayerManager.FetchResponse>(callback1, fMgCache2);
        GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_Fetch(self, (Types.DataSource) num, player_id, fMgCache3, intPtr);
      }
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.PlayerManager.FetchCallback))]
    private static void InternalFetchCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("PlayerManager#InternalFetchCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void HandleFetchResponse(PlayerManager.FetchResponseCollector collector, PlayerManager.FetchResponse resp)
    {
      if (resp.Status() == CommonErrorStatus.ResponseStatus.VALID || resp.Status() == CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
      {
        NativePlayer player = resp.GetPlayer();
        collector.results.Add(player);
      }
      --collector.pendingCount;
      if (collector.pendingCount != 0)
        return;
      collector.callback(collector.results.ToArray());
    }

    internal void FetchFriends(Action<GooglePlayGames.BasicApi.ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
    {
      HandleRef self = this.mGameServices.AsHandle();
      int num = 1;
      // ISSUE: reference to a compiler-generated field
      if (PlayerManager.\u003C\u003Ef__mg\u0024cache5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        PlayerManager.\u003C\u003Ef__mg\u0024cache5 = new GooglePlayGames.Native.Cwrapper.PlayerManager.FetchListCallback(PlayerManager.InternalFetchConnectedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.PlayerManager.FetchListCallback fMgCache5 = PlayerManager.\u003C\u003Ef__mg\u0024cache5;
      Action<PlayerManager.FetchListResponse> callback1 = (Action<PlayerManager.FetchListResponse>) (rsp => this.HandleFetchCollected(rsp, callback));
      // ISSUE: reference to a compiler-generated field
      if (PlayerManager.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        PlayerManager.\u003C\u003Ef__mg\u0024cache4 = new Func<IntPtr, PlayerManager.FetchListResponse>(PlayerManager.FetchListResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, PlayerManager.FetchListResponse> fMgCache4 = PlayerManager.\u003C\u003Ef__mg\u0024cache4;
      IntPtr intPtr = Callbacks.ToIntPtr<PlayerManager.FetchListResponse>(callback1, fMgCache4);
      GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchConnected(self, (Types.DataSource) num, fMgCache5, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.PlayerManager.FetchListCallback))]
    private static void InternalFetchConnectedCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("PlayerManager#InternalFetchConnectedCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void HandleFetchCollected(PlayerManager.FetchListResponse rsp, Action<GooglePlayGames.BasicApi.ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
    {
      List<GooglePlayGames.BasicApi.Multiplayer.Player> playerList = new List<GooglePlayGames.BasicApi.Multiplayer.Player>();
      if (rsp.Status() == CommonErrorStatus.ResponseStatus.VALID || rsp.Status() == CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
      {
        Logger.d("Got " + (object) rsp.Length().ToUInt64() + " players");
        foreach (NativePlayer nativePlayer in rsp)
          playerList.Add(nativePlayer.AsPlayer());
      }
      callback((GooglePlayGames.BasicApi.ResponseStatus) rsp.Status(), playerList);
    }

    internal class FetchListResponse : BaseReferenceHolder, IEnumerable<NativePlayer>, IEnumerable
    {
      internal FetchListResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_Dispose(this.SelfPtr());
      }

      internal CommonErrorStatus.ResponseStatus Status()
      {
        return GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetStatus(this.SelfPtr());
      }

      public IEnumerator<NativePlayer> GetEnumerator()
      {
        return PInvokeUtilities.ToEnumerator<NativePlayer>(this.Length(), (Func<UIntPtr, NativePlayer>) (index => this.GetElement(index)));
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return (IEnumerator) this.GetEnumerator();
      }

      internal UIntPtr Length()
      {
        return GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_Length(this.SelfPtr());
      }

      internal NativePlayer GetElement(UIntPtr index)
      {
        if (index.ToUInt64() >= this.Length().ToUInt64())
          throw new ArgumentOutOfRangeException();
        return new NativePlayer(GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_GetElement(this.SelfPtr(), index));
      }

      internal static PlayerManager.FetchListResponse FromPointer(IntPtr selfPointer)
      {
        if (PInvokeUtilities.IsNull(selfPointer))
          return (PlayerManager.FetchListResponse) null;
        return new PlayerManager.FetchListResponse(selfPointer);
      }
    }

    internal class FetchResponseCollector
    {
      internal List<NativePlayer> results = new List<NativePlayer>();
      internal int pendingCount;
      internal Action<NativePlayer[]> callback;
    }

    internal class FetchResponse : BaseReferenceHolder
    {
      internal FetchResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_Dispose(this.SelfPtr());
      }

      internal NativePlayer GetPlayer()
      {
        return new NativePlayer(GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_GetData(this.SelfPtr()));
      }

      internal CommonErrorStatus.ResponseStatus Status()
      {
        return GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_GetStatus(this.SelfPtr());
      }

      internal static PlayerManager.FetchResponse FromPointer(IntPtr selfPointer)
      {
        if (PInvokeUtilities.IsNull(selfPointer))
          return (PlayerManager.FetchResponse) null;
        return new PlayerManager.FetchResponse(selfPointer);
      }
    }

    internal class FetchSelfResponse : BaseReferenceHolder
    {
      internal FetchSelfResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus Status()
      {
        return GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchSelfResponse_GetStatus(this.SelfPtr());
      }

      internal NativePlayer Self()
      {
        return new NativePlayer(GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchSelfResponse_GetData(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchSelfResponse_Dispose(this.SelfPtr());
      }

      internal static PlayerManager.FetchSelfResponse FromPointer(IntPtr selfPointer)
      {
        if (PInvokeUtilities.IsNull(selfPointer))
          return (PlayerManager.FetchSelfResponse) null;
        return new PlayerManager.FetchSelfResponse(selfPointer);
      }
    }
  }
}
