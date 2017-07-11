// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.IosPlatformConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class IosPlatformConfiguration
  {
    [DllImport("gpg")]
    internal static extern IntPtr IosPlatformConfiguration_Construct();

    [DllImport("gpg")]
    internal static extern void IosPlatformConfiguration_Dispose(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool IosPlatformConfiguration_Valid(HandleRef self);

    [DllImport("gpg")]
    internal static extern void IosPlatformConfiguration_SetClientID(HandleRef self, string client_id);
  }
}
