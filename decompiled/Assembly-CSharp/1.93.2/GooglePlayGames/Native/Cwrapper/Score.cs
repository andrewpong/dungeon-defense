using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x20000E5")]
	internal static class Score
	{
		// Token: 0x0600086B RID: 2155
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x6CB5C0", Offset = "0x6CB5C0", VA = "0x66CB5C0")]
		[PreserveSig]
		internal static extern ulong Score_Value(HandleRef self);

		// Token: 0x0600086C RID: 2156
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x6CB6B8", Offset = "0x6CB6B8", VA = "0x66CB6B8")]
		[PreserveSig]
		internal static extern bool Score_Valid(HandleRef self);

		// Token: 0x0600086D RID: 2157
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x6CB7B8", Offset = "0x6CB7B8", VA = "0x66CB7B8")]
		[PreserveSig]
		internal static extern ulong Score_Rank(HandleRef self);

		// Token: 0x0600086E RID: 2158
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x6CB8B0", Offset = "0x6CB8B0", VA = "0x66CB8B0")]
		[PreserveSig]
		internal static extern void Score_Dispose(HandleRef self);

		// Token: 0x0600086F RID: 2159
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x6CB9A8", Offset = "0x6CB9A8", VA = "0x66CB9A8")]
		[PreserveSig]
		internal static extern UIntPtr Score_Metadata(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);
	}
}
