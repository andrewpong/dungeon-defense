// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeEndpointDiscoveryListenerHelper : BaseReferenceHolder
  {
    internal NativeEndpointDiscoveryListenerHelper()
      : base(EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_Construct())
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_Dispose(selfPointer);
    }

    internal void SetOnEndpointFound(Action<long, NativeEndpointDetails> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache1 = new EndpointDiscoveryListenerHelper.OnEndpointFoundCallback(NativeEndpointDiscoveryListenerHelper.InternalOnEndpointFoundCallback);
      }
      // ISSUE: reference to a compiler-generated field
      EndpointDiscoveryListenerHelper.OnEndpointFoundCallback fMgCache1 = NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache1;
      Action<long, NativeEndpointDetails> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, NativeEndpointDetails>(NativeEndpointDetails.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, NativeEndpointDetails> fMgCache0 = NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr<long, NativeEndpointDetails>(callback1, fMgCache0);
      EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_SetOnEndpointFoundCallback(self, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (EndpointDiscoveryListenerHelper.OnEndpointFoundCallback))]
    private static void InternalOnEndpointFoundCallback(long id, IntPtr data, IntPtr userData)
    {
      Callbacks.PerformInternalCallback<long>("NativeEndpointDiscoveryListenerHelper#InternalOnEndpointFoundCallback", Callbacks.Type.Permanent, id, data, userData);
    }

    internal void SetOnEndpointLostCallback(Action<long, string> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache2 = new EndpointDiscoveryListenerHelper.OnEndpointLostCallback(NativeEndpointDiscoveryListenerHelper.InternalOnEndpointLostCallback);
      }
      // ISSUE: reference to a compiler-generated field
      EndpointDiscoveryListenerHelper.OnEndpointLostCallback fMgCache2 = NativeEndpointDiscoveryListenerHelper.\u003C\u003Ef__mg\u0024cache2;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_SetOnEndpointLostCallback(self, fMgCache2, intPtr);
    }

    [MonoPInvokeCallback(typeof (EndpointDiscoveryListenerHelper.OnEndpointLostCallback))]
    private static void InternalOnEndpointLostCallback(long id, string lostEndpointId, IntPtr userData)
    {
      Action<long, string> permanentCallback = Callbacks.IntPtrToPermanentCallback<Action<long, string>>(userData);
      if (permanentCallback == null)
        return;
      try
      {
        permanentCallback(id, lostEndpointId);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing NativeEndpointDiscoveryListenerHelper#InternalOnEndpointLostCallback. Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }
  }
}
