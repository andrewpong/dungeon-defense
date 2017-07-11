// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class RealTimeRoomConfigBuilder
  {
    [DllImport("gpg")]
    internal static extern void RealTimeRoomConfig_Builder_PopulateFromPlayerSelectUIResponse(HandleRef self, IntPtr response);

    [DllImport("gpg")]
    internal static extern void RealTimeRoomConfig_Builder_SetVariant(HandleRef self, uint variant);

    [DllImport("gpg")]
    internal static extern void RealTimeRoomConfig_Builder_AddPlayerToInvite(HandleRef self, string player_id);

    [DllImport("gpg")]
    internal static extern IntPtr RealTimeRoomConfig_Builder_Construct();

    [DllImport("gpg")]
    internal static extern void RealTimeRoomConfig_Builder_SetExclusiveBitMask(HandleRef self, ulong exclusive_bit_mask);

    [DllImport("gpg")]
    internal static extern void RealTimeRoomConfig_Builder_SetMaximumAutomatchingPlayers(HandleRef self, uint maximum_automatching_players);

    [DllImport("gpg")]
    internal static extern IntPtr RealTimeRoomConfig_Builder_Create(HandleRef self);

    [DllImport("gpg")]
    internal static extern void RealTimeRoomConfig_Builder_SetMinimumAutomatchingPlayers(HandleRef self, uint minimum_automatching_players);

    [DllImport("gpg")]
    internal static extern void RealTimeRoomConfig_Builder_Dispose(HandleRef self);
  }
}
