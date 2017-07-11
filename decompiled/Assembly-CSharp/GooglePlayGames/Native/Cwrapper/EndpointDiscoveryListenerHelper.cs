// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class EndpointDiscoveryListenerHelper
  {
    [DllImport("gpg")]
    internal static extern IntPtr EndpointDiscoveryListenerHelper_Construct();

    [DllImport("gpg")]
    internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointLostCallback(HandleRef self, EndpointDiscoveryListenerHelper.OnEndpointLostCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointFoundCallback(HandleRef self, EndpointDiscoveryListenerHelper.OnEndpointFoundCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void EndpointDiscoveryListenerHelper_Dispose(HandleRef self);

    internal delegate void OnEndpointFoundCallback(long arg0, IntPtr arg1, IntPtr arg2);

    internal delegate void OnEndpointLostCallback(long arg0, string arg1, IntPtr arg2);
  }
}
