﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class AndroidPlatformConfiguration
  {
    [DllImport("gpg")]
    internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithSnapshot(HandleRef self, AndroidPlatformConfiguration.OnLaunchedWithSnapshotCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern IntPtr AndroidPlatformConfiguration_Construct();

    [DllImport("gpg")]
    internal static extern void AndroidPlatformConfiguration_SetOptionalIntentHandlerForUI(HandleRef self, AndroidPlatformConfiguration.IntentHandler intent_handler, IntPtr intent_handler_arg);

    [DllImport("gpg")]
    internal static extern void AndroidPlatformConfiguration_Dispose(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool AndroidPlatformConfiguration_Valid(HandleRef self);

    [DllImport("gpg")]
    internal static extern void AndroidPlatformConfiguration_SetActivity(HandleRef self, IntPtr android_app_activity);

    [DllImport("gpg")]
    internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithQuest(HandleRef self, AndroidPlatformConfiguration.OnLaunchedWithQuestCallback callback, IntPtr callback_arg);

    internal delegate void IntentHandler(IntPtr arg0, IntPtr arg1);

    internal delegate void OnLaunchedWithSnapshotCallback(IntPtr arg0, IntPtr arg1);

    internal delegate void OnLaunchedWithQuestCallback(IntPtr arg0, IntPtr arg1);
  }
}
