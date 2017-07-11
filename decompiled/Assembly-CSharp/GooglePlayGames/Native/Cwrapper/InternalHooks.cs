// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.InternalHooks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
