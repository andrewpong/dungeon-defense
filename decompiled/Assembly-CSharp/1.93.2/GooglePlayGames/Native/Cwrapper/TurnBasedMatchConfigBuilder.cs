using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x20000FF")]
	internal static class TurnBasedMatchConfigBuilder
	{
		// Token: 0x060008FA RID: 2298
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x6D3E78", Offset = "0x6D3E78", VA = "0x66D3E78")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Builder_PopulateFromPlayerSelectUIResponse(HandleRef self, IntPtr response);

		// Token: 0x060008FB RID: 2299
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x6D3F80", Offset = "0x6D3F80", VA = "0x66D3F80")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Builder_SetVariant(HandleRef self, uint variant);

		// Token: 0x060008FC RID: 2300
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x6D4070", Offset = "0x6D4070", VA = "0x66D4070")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Builder_AddPlayerToInvite(HandleRef self, string player_id);

		// Token: 0x060008FD RID: 2301
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x6D4188", Offset = "0x6D4188", VA = "0x66D4188")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatchConfig_Builder_Construct();

		// Token: 0x060008FE RID: 2302
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x6D4260", Offset = "0x6D4260", VA = "0x66D4260")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Builder_SetExclusiveBitMask(HandleRef self, ulong exclusive_bit_mask);

		// Token: 0x060008FF RID: 2303
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x6D4368", Offset = "0x6D4368", VA = "0x66D4368")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Builder_SetMaximumAutomatchingPlayers(HandleRef self, uint maximum_automatching_players);

		// Token: 0x06000900 RID: 2304
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x6D4470", Offset = "0x6D4470", VA = "0x66D4470")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatchConfig_Builder_Create(HandleRef self);

		// Token: 0x06000901 RID: 2305
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x6D4558", Offset = "0x6D4558", VA = "0x66D4558")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Builder_SetMinimumAutomatchingPlayers(HandleRef self, uint minimum_automatching_players);

		// Token: 0x06000902 RID: 2306
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x6D4660", Offset = "0x6D4660", VA = "0x66D4660")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Builder_Dispose(HandleRef self);
	}
}
