using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x20000E4")]
	internal static class RealTimeRoomConfigBuilder
	{
		// Token: 0x06000862 RID: 2146
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x6CACF8", Offset = "0x6CACF8", VA = "0x66CACF8")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Builder_PopulateFromPlayerSelectUIResponse(HandleRef self, IntPtr response);

		// Token: 0x06000863 RID: 2147
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x6CAE00", Offset = "0x6CAE00", VA = "0x66CAE00")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Builder_SetVariant(HandleRef self, uint variant);

		// Token: 0x06000864 RID: 2148
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x6CAEF0", Offset = "0x6CAEF0", VA = "0x66CAEF0")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Builder_AddPlayerToInvite(HandleRef self, string player_id);

		// Token: 0x06000865 RID: 2149
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x6CB008", Offset = "0x6CB008", VA = "0x66CB008")]
		[PreserveSig]
		internal static extern IntPtr RealTimeRoomConfig_Builder_Construct();

		// Token: 0x06000866 RID: 2150
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x6CB0E0", Offset = "0x6CB0E0", VA = "0x66CB0E0")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Builder_SetExclusiveBitMask(HandleRef self, ulong exclusive_bit_mask);

		// Token: 0x06000867 RID: 2151
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x6CB1E0", Offset = "0x6CB1E0", VA = "0x66CB1E0")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Builder_SetMaximumAutomatchingPlayers(HandleRef self, uint maximum_automatching_players);

		// Token: 0x06000868 RID: 2152
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x6CB2E8", Offset = "0x6CB2E8", VA = "0x66CB2E8")]
		[PreserveSig]
		internal static extern IntPtr RealTimeRoomConfig_Builder_Create(HandleRef self);

		// Token: 0x06000869 RID: 2153
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x6CB3D0", Offset = "0x6CB3D0", VA = "0x66CB3D0")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Builder_SetMinimumAutomatchingPlayers(HandleRef self, uint minimum_automatching_players);

		// Token: 0x0600086A RID: 2154
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x6CB4D8", Offset = "0x6CB4D8", VA = "0x66CB4D8")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Builder_Dispose(HandleRef self);
	}
}
