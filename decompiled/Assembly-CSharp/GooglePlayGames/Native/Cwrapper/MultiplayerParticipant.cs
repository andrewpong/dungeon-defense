﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.MultiplayerParticipant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class MultiplayerParticipant
  {
    [DllImport("gpg")]
    internal static extern Types.ParticipantStatus MultiplayerParticipant_Status(HandleRef self);

    [DllImport("gpg")]
    internal static extern uint MultiplayerParticipant_MatchRank(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool MultiplayerParticipant_IsConnectedToRoom(HandleRef self);

    [DllImport("gpg")]
    internal static extern UIntPtr MultiplayerParticipant_DisplayName(HandleRef self, StringBuilder out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool MultiplayerParticipant_HasPlayer(HandleRef self);

    [DllImport("gpg")]
    internal static extern UIntPtr MultiplayerParticipant_AvatarUrl(HandleRef self, Types.ImageResolution resolution, StringBuilder out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    internal static extern Types.MatchResult MultiplayerParticipant_MatchResult(HandleRef self);

    [DllImport("gpg")]
    internal static extern IntPtr MultiplayerParticipant_Player(HandleRef self);

    [DllImport("gpg")]
    internal static extern void MultiplayerParticipant_Dispose(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool MultiplayerParticipant_Valid(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool MultiplayerParticipant_HasMatchResult(HandleRef self);

    [DllImport("gpg")]
    internal static extern UIntPtr MultiplayerParticipant_Id(HandleRef self, StringBuilder out_arg, UIntPtr out_size);
  }
}
