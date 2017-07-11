// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NearbyConnectionsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.Native.Cwrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NearbyConnectionsManager : BaseReferenceHolder
  {
    private static readonly string sServiceId = NearbyConnectionsManager.ReadServiceId();

    public string AppBundleId
    {
      get
      {
        using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
          return androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity").Call<string>("getPackageName");
      }
    }

    public static string ServiceId
    {
      get
      {
        return NearbyConnectionsManager.sServiceId;
      }
    }

    internal NearbyConnectionsManager(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      NearbyConnections.NearbyConnections_Dispose(selfPointer);
    }

    internal void SendUnreliable(string remoteEndpointId, byte[] payload)
    {
      NearbyConnections.NearbyConnections_SendUnreliableMessage(this.SelfPtr(), remoteEndpointId, payload, new UIntPtr((ulong) payload.Length));
    }

    internal void SendReliable(string remoteEndpointId, byte[] payload)
    {
      NearbyConnections.NearbyConnections_SendReliableMessage(this.SelfPtr(), remoteEndpointId, payload, new UIntPtr((ulong) payload.Length));
    }

    internal void StartAdvertising(string name, List<NativeAppIdentifier> appIds, long advertisingDuration, Action<long, NativeStartAdvertisingResult> advertisingCallback, Action<long, NativeConnectionRequest> connectionRequestCallback)
    {
      HandleRef self = this.SelfPtr();
      string name1 = name;
      IntPtr[] array = appIds.Select<NativeAppIdentifier, IntPtr>((Func<NativeAppIdentifier, IntPtr>) (id => id.AsPointer())).ToArray<IntPtr>();
      IntPtr num = (IntPtr) new UIntPtr((ulong) appIds.Count);
      long duration = advertisingDuration;
      // ISSUE: reference to a compiler-generated field
      if (NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache2 = new NearbyConnectionTypes.StartAdvertisingCallback(NearbyConnectionsManager.InternalStartAdvertisingCallback);
      }
      // ISSUE: reference to a compiler-generated field
      NearbyConnectionTypes.StartAdvertisingCallback fMgCache2 = NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache2;
      Action<long, NativeStartAdvertisingResult> callback1 = advertisingCallback;
      // ISSUE: reference to a compiler-generated field
      if (NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, NativeStartAdvertisingResult>(NativeStartAdvertisingResult.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, NativeStartAdvertisingResult> fMgCache0 = NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr1 = Callbacks.ToIntPtr<long, NativeStartAdvertisingResult>(callback1, fMgCache0);
      // ISSUE: reference to a compiler-generated field
      if (NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache3 = new NearbyConnectionTypes.ConnectionRequestCallback(NearbyConnectionsManager.InternalConnectionRequestCallback);
      }
      // ISSUE: reference to a compiler-generated field
      NearbyConnectionTypes.ConnectionRequestCallback fMgCache3 = NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache3;
      Action<long, NativeConnectionRequest> callback2 = connectionRequestCallback;
      // ISSUE: reference to a compiler-generated field
      if (NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache1 = new Func<IntPtr, NativeConnectionRequest>(NativeConnectionRequest.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, NativeConnectionRequest> fMgCache1 = NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache1;
      IntPtr intPtr2 = Callbacks.ToIntPtr<long, NativeConnectionRequest>(callback2, fMgCache1);
      NearbyConnections.NearbyConnections_StartAdvertising(self, name1, array, (UIntPtr) num, duration, fMgCache2, intPtr1, fMgCache3, intPtr2);
    }

    [MonoPInvokeCallback(typeof (NearbyConnectionTypes.StartAdvertisingCallback))]
    private static void InternalStartAdvertisingCallback(long id, IntPtr result, IntPtr userData)
    {
      Callbacks.PerformInternalCallback<long>("NearbyConnectionsManager#InternalStartAdvertisingCallback", Callbacks.Type.Permanent, id, result, userData);
    }

    [MonoPInvokeCallback(typeof (NearbyConnectionTypes.ConnectionRequestCallback))]
    private static void InternalConnectionRequestCallback(long id, IntPtr result, IntPtr userData)
    {
      Callbacks.PerformInternalCallback<long>("NearbyConnectionsManager#InternalConnectionRequestCallback", Callbacks.Type.Permanent, id, result, userData);
    }

    internal void StopAdvertising()
    {
      NearbyConnections.NearbyConnections_StopAdvertising(this.SelfPtr());
    }

    internal void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<long, NativeConnectionResponse> callback, NativeMessageListenerHelper listener)
    {
      HandleRef self = this.SelfPtr();
      string name1 = name;
      string remote_endpoint_id = remoteEndpointId;
      byte[] payload1 = payload;
      IntPtr num = (IntPtr) new UIntPtr((ulong) payload.Length);
      // ISSUE: reference to a compiler-generated field
      if (NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache5 = new NearbyConnectionTypes.ConnectionResponseCallback(NearbyConnectionsManager.InternalConnectResponseCallback);
      }
      // ISSUE: reference to a compiler-generated field
      NearbyConnectionTypes.ConnectionResponseCallback fMgCache5 = NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache5;
      Action<long, NativeConnectionResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache4 = new Func<IntPtr, NativeConnectionResponse>(NativeConnectionResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, NativeConnectionResponse> fMgCache4 = NearbyConnectionsManager.\u003C\u003Ef__mg\u0024cache4;
      IntPtr intPtr = Callbacks.ToIntPtr<long, NativeConnectionResponse>(callback1, fMgCache4);
      IntPtr helper = listener.AsPointer();
      NearbyConnections.NearbyConnections_SendConnectionRequest(self, name1, remote_endpoint_id, payload1, (UIntPtr) num, fMgCache5, intPtr, helper);
    }

    [MonoPInvokeCallback(typeof (NearbyConnectionTypes.ConnectionResponseCallback))]
    private static void InternalConnectResponseCallback(long localClientId, IntPtr response, IntPtr userData)
    {
      Callbacks.PerformInternalCallback<long>("NearbyConnectionManager#InternalConnectResponseCallback", Callbacks.Type.Temporary, localClientId, response, userData);
    }

    internal void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, NativeMessageListenerHelper listener)
    {
      NearbyConnections.NearbyConnections_AcceptConnectionRequest(this.SelfPtr(), remoteEndpointId, payload, new UIntPtr((ulong) payload.Length), listener.AsPointer());
    }

    internal void DisconnectFromEndpoint(string remoteEndpointId)
    {
      NearbyConnections.NearbyConnections_Disconnect(this.SelfPtr(), remoteEndpointId);
    }

    internal void StopAllConnections()
    {
      NearbyConnections.NearbyConnections_Stop(this.SelfPtr());
    }

    internal void StartDiscovery(string serviceId, long duration, NativeEndpointDiscoveryListenerHelper listener)
    {
      NearbyConnections.NearbyConnections_StartDiscovery(this.SelfPtr(), serviceId, duration, listener.AsPointer());
    }

    internal void StopDiscovery(string serviceId)
    {
      NearbyConnections.NearbyConnections_StopDiscovery(this.SelfPtr(), serviceId);
    }

    internal void RejectConnectionRequest(string remoteEndpointId)
    {
      NearbyConnections.NearbyConnections_RejectConnectionRequest(this.SelfPtr(), remoteEndpointId);
    }

    internal void Shutdown()
    {
      NearbyConnections.NearbyConnections_Stop(this.SelfPtr());
    }

    internal string LocalEndpointId()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnections.NearbyConnections_GetLocalEndpointId(this.SelfPtr(), out_arg, out_size)));
    }

    internal string LocalDeviceId()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnections.NearbyConnections_GetLocalDeviceId(this.SelfPtr(), out_arg, out_size)));
    }

    internal static string ReadServiceId()
    {
      Debug.Log((object) "Initializing ServiceId property!!!!");
      using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
      {
        using (AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity"))
        {
          string str1 = androidJavaObject.Call<string>("getPackageName");
          string str2 = androidJavaObject.Call<AndroidJavaObject>("getPackageManager").Call<AndroidJavaObject>("getApplicationInfo", (object) str1, (object) 128).Get<AndroidJavaObject>("metaData").Call<string>("getString", new object[1]{ (object) "com.google.android.gms.nearby.connection.SERVICE_ID" });
          Debug.Log((object) ("SystemId from Manifest: " + str2));
          return str2;
        }
      }
    }
  }
}
