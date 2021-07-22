using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x20000FE")]
	internal static class TurnBasedMatchConfig
	{
		// Token: 0x060008F2 RID: 2290
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x6D3708", Offset = "0x6D3708", VA = "0x66D3708")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatchConfig_PlayerIdsToInvite_Length(HandleRef self);

		// Token: 0x060008F3 RID: 2291
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x6D37F8", Offset = "0x6D37F8", VA = "0x66D37F8")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatchConfig_PlayerIdsToInvite_GetElement(HandleRef self, UIntPtr index, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008F4 RID: 2292
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x6D3908", Offset = "0x6D3908", VA = "0x66D3908")]
		[PreserveSig]
		internal static extern uint TurnBasedMatchConfig_Variant(HandleRef self);

		// Token: 0x060008F5 RID: 2293
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x6D39E8", Offset = "0x6D39E8", VA = "0x66D39E8")]
		[PreserveSig]
		internal static extern long TurnBasedMatchConfig_ExclusiveBitMask(HandleRef self);

		// Token: 0x060008F6 RID: 2294
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x6D3AD0", Offset = "0x6D3AD0", VA = "0x66D3AD0")]
		[PreserveSig]
		internal static extern bool TurnBasedMatchConfig_Valid(HandleRef self);

		// Token: 0x060008F7 RID: 2295
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x6D3BB8", Offset = "0x6D3BB8", VA = "0x66D3BB8")]
		[PreserveSig]
		internal static extern uint TurnBasedMatchConfig_MaximumAutomatchingPlayers(HandleRef self);

		// Token: 0x060008F8 RID: 2296
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x6D3CA8", Offset = "0x6D3CA8", VA = "0x66D3CA8")]
		[PreserveSig]
		internal static extern uint TurnBasedMatchConfig_MinimumAutomatchingPlayers(HandleRef self);

		// Token: 0x060008F9 RID: 2297
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x6D3D98", Offset = "0x6D3D98", VA = "0x66D3D98")]
		[PreserveSig]
		internal static extern void TurnBasedMatchConfig_Dispose(HandleRef self);
	}
}
