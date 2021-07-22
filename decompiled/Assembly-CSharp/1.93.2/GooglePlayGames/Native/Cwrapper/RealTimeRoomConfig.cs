using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x20000E3")]
	internal static class RealTimeRoomConfig
	{
		// Token: 0x0600085A RID: 2138
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x6CA498", Offset = "0x6CA498", VA = "0x66CA498")]
		[PreserveSig]
		internal static extern UIntPtr RealTimeRoomConfig_PlayerIdsToInvite_Length(HandleRef self);

		// Token: 0x0600085B RID: 2139
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x6CA588", Offset = "0x6CA588", VA = "0x66CA588")]
		[PreserveSig]
		internal static extern UIntPtr RealTimeRoomConfig_PlayerIdsToInvite_GetElement(HandleRef self, UIntPtr index, [In] [Out] char[] out_arg, UIntPtr out_size);

		// Token: 0x0600085C RID: 2140
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x6CA758", Offset = "0x6CA758", VA = "0x66CA758")]
		[PreserveSig]
		internal static extern uint RealTimeRoomConfig_Variant(HandleRef self);

		// Token: 0x0600085D RID: 2141
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x6CA838", Offset = "0x6CA838", VA = "0x66CA838")]
		[PreserveSig]
		internal static extern long RealTimeRoomConfig_ExclusiveBitMask(HandleRef self);

		// Token: 0x0600085E RID: 2142
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x6CA920", Offset = "0x6CA920", VA = "0x66CA920")]
		[PreserveSig]
		internal static extern bool RealTimeRoomConfig_Valid(HandleRef self);

		// Token: 0x0600085F RID: 2143
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x6CAA38", Offset = "0x6CAA38", VA = "0x66CAA38")]
		[PreserveSig]
		internal static extern uint RealTimeRoomConfig_MaximumAutomatchingPlayers(HandleRef self);

		// Token: 0x06000860 RID: 2144
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x6CAB28", Offset = "0x6CAB28", VA = "0x66CAB28")]
		[PreserveSig]
		internal static extern uint RealTimeRoomConfig_MinimumAutomatchingPlayers(HandleRef self);

		// Token: 0x06000861 RID: 2145
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x6CAC18", Offset = "0x6CAC18", VA = "0x66CAC18")]
		[PreserveSig]
		internal static extern void RealTimeRoomConfig_Dispose(HandleRef self);
	}
}
