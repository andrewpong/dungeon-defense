// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.MessageListenerHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class MessageListenerHelper
  {
    [DllImport("gpg")]
    internal static extern void MessageListenerHelper_SetOnMessageReceivedCallback(HandleRef self, MessageListenerHelper.OnMessageReceivedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void MessageListenerHelper_SetOnDisconnectedCallback(HandleRef self, MessageListenerHelper.OnDisconnectedCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern IntPtr MessageListenerHelper_Construct();

    [DllImport("gpg")]
    internal static extern void MessageListenerHelper_Dispose(HandleRef self);

    internal delegate void OnMessageReceivedCallback(long arg0, string arg1, IntPtr arg2, UIntPtr arg3, [MarshalAs(UnmanagedType.I1)] bool arg4, IntPtr arg5);

    internal delegate void OnDisconnectedCallback(long arg0, string arg1, IntPtr arg2);
  }
}
