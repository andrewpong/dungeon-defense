// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.InternalHooks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
