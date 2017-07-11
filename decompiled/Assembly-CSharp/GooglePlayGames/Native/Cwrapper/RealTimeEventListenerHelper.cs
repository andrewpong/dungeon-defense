﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class RealTimeEventListenerHelper
  {
    [DllImport("gpg")]
    internal static extern void RealTimeEventListenerHelper_SetOnParticipantStatusChangedCallback(HandleRef self, RealTimeEventListenerHelper.OnParticipantStatusChangedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern IntPtr RealTimeEventListenerHelper_Construct();

    [DllImport("gpg")]
    internal static extern void RealTimeEventListenerHelper_SetOnP2PDisconnectedCallback(HandleRef self, RealTimeEventListenerHelper.OnP2PDisconnectedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void RealTimeEventListenerHelper_SetOnDataReceivedCallback(HandleRef self, RealTimeEventListenerHelper.OnDataReceivedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void RealTimeEventListenerHelper_SetOnRoomStatusChangedCallback(HandleRef self, RealTimeEventListenerHelper.OnRoomStatusChangedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void RealTimeEventListenerHelper_SetOnP2PConnectedCallback(HandleRef self, RealTimeEventListenerHelper.OnP2PConnectedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void RealTimeEventListenerHelper_SetOnRoomConnectedSetChangedCallback(HandleRef self, RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void RealTimeEventListenerHelper_Dispose(HandleRef self);

    internal delegate void OnRoomStatusChangedCallback(IntPtr arg0, IntPtr arg1);

    internal delegate void OnRoomConnectedSetChangedCallback(IntPtr arg0, IntPtr arg1);

    internal delegate void OnP2PConnectedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

    internal delegate void OnP2PDisconnectedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

    internal delegate void OnParticipantStatusChangedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

    internal delegate void OnDataReceivedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2, UIntPtr arg3, [MarshalAs(UnmanagedType.I1)] bool arg4, IntPtr arg5);
  }
}
