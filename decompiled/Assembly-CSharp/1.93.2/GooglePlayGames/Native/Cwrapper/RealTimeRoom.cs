using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x20000E2")]
	internal static class RealTimeRoom
	{
		// Token: 0x0600084E RID: 2126
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x6C97D8", Offset = "0x6C97D8", VA = "0x66C97D8")]
		[PreserveSig]
		internal static extern Types.RealTimeRoomStatus RealTimeRoom_Status(HandleRef self);

		// Token: 0x0600084F RID: 2127
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x6C98E0", Offset = "0x6C98E0", VA = "0x66C98E0")]
		[PreserveSig]
		internal static extern UIntPtr RealTimeRoom_Description(HandleRef self, [In] [Out] char[] out_arg, UIntPtr out_size);

		// Token: 0x06000850 RID: 2128
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x6C9AC0", Offset = "0x6C9AC0", VA = "0x66C9AC0")]
		[PreserveSig]
		internal static extern uint RealTimeRoom_Variant(HandleRef self);

		// Token: 0x06000851 RID: 2129
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x6C9BC8", Offset = "0x6C9BC8", VA = "0x66C9BC8")]
		[PreserveSig]
		internal static extern ulong RealTimeRoom_CreationTime(HandleRef self);

		// Token: 0x06000852 RID: 2130
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x6C9CD8", Offset = "0x6C9CD8", VA = "0x66C9CD8")]
		[PreserveSig]
		internal static extern UIntPtr RealTimeRoom_Participants_Length(HandleRef self);

		// Token: 0x06000853 RID: 2131
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x6C9DC0", Offset = "0x6C9DC0", VA = "0x66C9DC0")]
		[PreserveSig]
		internal static extern IntPtr RealTimeRoom_Participants_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x06000854 RID: 2132
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x6C9EB0", Offset = "0x6C9EB0", VA = "0x66C9EB0")]
		[PreserveSig]
		internal static extern bool RealTimeRoom_Valid(HandleRef self);

		// Token: 0x06000855 RID: 2133
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x6C9FC0", Offset = "0x6C9FC0", VA = "0x66C9FC0")]
		[PreserveSig]
		internal static extern uint RealTimeRoom_RemainingAutomatchingSlots(HandleRef self);

		// Token: 0x06000856 RID: 2134
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x6CA0A8", Offset = "0x6CA0A8", VA = "0x66CA0A8")]
		[PreserveSig]
		internal static extern ulong RealTimeRoom_AutomatchWaitEstimate(HandleRef self);

		// Token: 0x06000857 RID: 2135
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x6CA190", Offset = "0x6CA190", VA = "0x66CA190")]
		[PreserveSig]
		internal static extern IntPtr RealTimeRoom_CreatingParticipant(HandleRef self);

		// Token: 0x06000858 RID: 2136
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x6CA278", Offset = "0x6CA278", VA = "0x66CA278")]
		[PreserveSig]
		internal static extern UIntPtr RealTimeRoom_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000859 RID: 2137
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x6CA390", Offset = "0x6CA390", VA = "0x66CA390")]
		[PreserveSig]
		internal static extern void RealTimeRoom_Dispose(HandleRef self);
	}
}
