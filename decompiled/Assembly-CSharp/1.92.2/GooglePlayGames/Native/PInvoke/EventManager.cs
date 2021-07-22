// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.EventManager
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
  internal class EventManager
  {
    private readonly GameServices mServices;

    internal EventManager(GameServices services)
    {
      this.mServices = Misc.CheckNotNull<GameServices>(services);
    }

    internal void FetchAll(Types.DataSource source, Action<EventManager.FetchAllResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      int num = (int) source;
      // ISSUE: reference to a compiler-generated field
      if (EventManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        EventManager.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.EventManager.FetchAllCallback(EventManager.InternalFetchAllCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.EventManager.FetchAllCallback fMgCache1 = EventManager.\u003C\u003Ef__mg\u0024cache1;
      Action<EventManager.FetchAllResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (EventManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        EventManager.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, EventManager.FetchAllResponse>(EventManager.FetchAllResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, EventManager.FetchAllResponse> fMgCache0 = EventManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr<EventManager.FetchAllResponse>(callback1, fMgCache0);
      GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchAll(self, (Types.DataSource) num, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.EventManager.FetchAllCallback))]
    internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("EventManager#FetchAllCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Fetch(Types.DataSource source, string eventId, Action<EventManager.FetchResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      int num = (int) source;
      string event_id = eventId;
      // ISSUE: reference to a compiler-generated field
      if (EventManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        EventManager.\u003C\u003Ef__mg\u0024cache3 = new GooglePlayGames.Native.Cwrapper.EventManager.FetchCallback(EventManager.InternalFetchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.EventManager.FetchCallback fMgCache3 = EventManager.\u003C\u003Ef__mg\u0024cache3;
      Action<EventManager.FetchResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (EventManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        EventManager.\u003C\u003Ef__mg\u0024cache2 = new Func<IntPtr, EventManager.FetchResponse>(EventManager.FetchResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, EventManager.FetchResponse> fMgCache2 = EventManager.\u003C\u003Ef__mg\u0024cache2;
      IntPtr intPtr = Callbacks.ToIntPtr<EventManager.FetchResponse>(callback1, fMgCache2);
      GooglePlayGames.Native.Cwrapper.EventManager.EventManager_Fetch(self, (Types.DataSource) num, event_id, fMgCache3, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.EventManager.FetchCallback))]
    internal static void InternalFetchCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("EventManager#FetchCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Increment(string eventId, uint steps)
    {
      GooglePlayGames.Native.Cwrapper.EventManager.EventManager_Increment(this.mServices.AsHandle(), eventId, steps);
    }

    internal class FetchResponse : BaseReferenceHolder
    {
      internal FetchResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      internal NativeEvent Data()
      {
        if (!this.RequestSucceeded())
          return (NativeEvent) null;
        return new NativeEvent(GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchResponse_GetData(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchResponse_Dispose(selfPointer);
      }

      internal static EventManager.FetchResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (EventManager.FetchResponse) null;
        return new EventManager.FetchResponse(pointer);
      }
    }

    internal class FetchAllResponse : BaseReferenceHolder
    {
      internal FetchAllResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchAllResponse_GetStatus(this.SelfPtr());
      }

      internal List<NativeEvent> Data()
      {
        return ((IEnumerable<IntPtr>) PInvokeUtilities.OutParamsToArray<IntPtr>((PInvokeUtilities.OutMethod<IntPtr>) ((out_arg, out_size) => GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchAllResponse_GetData(this.SelfPtr(), out_arg, out_size)))).Select<IntPtr, NativeEvent>((Func<IntPtr, NativeEvent>) (ptr => new NativeEvent(ptr))).ToList<NativeEvent>();
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchAllResponse_Dispose(selfPointer);
      }

      internal static EventManager.FetchAllResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (EventManager.FetchAllResponse) null;
        return new EventManager.FetchAllResponse(pointer);
      }
    }
  }
}
