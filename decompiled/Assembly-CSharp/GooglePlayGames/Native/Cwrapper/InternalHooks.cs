﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.InternalHooks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class InternalHooks
  {
    [DllImport("gpg")]
    internal static extern void InternalHooks_ConfigureForUnityPlugin(HandleRef builder);

    [DllImport("gpg")]
    internal static extern IntPtr InternalHooks_GetApiClient(HandleRef services);
  }
}
