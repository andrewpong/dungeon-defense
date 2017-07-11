﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.NearbyConnections
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class NearbyConnections
  {
    [DllImport("gpg")]
    internal static extern void NearbyConnections_StartDiscovery(HandleRef self, string service_id, long duration, IntPtr helper);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_RejectConnectionRequest(HandleRef self, string remote_endpoint_id);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_Disconnect(HandleRef self, string remote_endpoint_id);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_SendUnreliableMessage(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size);

    [DllImport("gpg")]
    internal static extern UIntPtr NearbyConnections_GetLocalDeviceId(HandleRef self, StringBuilder out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_StopAdvertising(HandleRef self);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_Dispose(HandleRef self);

    [DllImport("gpg")]
    internal static extern UIntPtr NearbyConnections_GetLocalEndpointId(HandleRef self, StringBuilder out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_SendReliableMessage(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_StopDiscovery(HandleRef self, string service_id);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_SendConnectionRequest(HandleRef self, string name, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, NearbyConnectionTypes.ConnectionResponseCallback callback, IntPtr callback_arg, IntPtr helper);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_StartAdvertising(HandleRef self, string name, IntPtr[] app_identifiers, UIntPtr app_identifiers_size, long duration, NearbyConnectionTypes.StartAdvertisingCallback start_advertising_callback, IntPtr start_advertising_callback_arg, NearbyConnectionTypes.ConnectionRequestCallback request_callback, IntPtr request_callback_arg);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_Stop(HandleRef self);

    [DllImport("gpg")]
    internal static extern void NearbyConnections_AcceptConnectionRequest(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, IntPtr helper);
  }
}
