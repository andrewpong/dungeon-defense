using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000B3")]
	internal static class Leaderboard
	{
		// Token: 0x06000727 RID: 1831
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x9523C8", Offset = "0x9523C8", VA = "0x69523C8")]
		[PreserveSig]
		internal static extern UIntPtr Leaderboard_Name(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000728 RID: 1832
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x9524E0", Offset = "0x9524E0", VA = "0x69524E0")]
		[PreserveSig]
		internal static extern UIntPtr Leaderboard_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000729 RID: 1833
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x9525F8", Offset = "0x9525F8", VA = "0x69525F8")]
		[PreserveSig]
		internal static extern UIntPtr Leaderboard_IconUrl(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x0600072A RID: 1834
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x952718", Offset = "0x952718", VA = "0x6952718")]
		[PreserveSig]
		internal static extern void Leaderboard_Dispose(HandleRef self);

		// Token: 0x0600072B RID: 1835
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x952820", Offset = "0x952820", VA = "0x6952820")]
		[PreserveSig]
		internal static extern bool Leaderboard_Valid(HandleRef self);

		// Token: 0x0600072C RID: 1836
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x952928", Offset = "0x952928", VA = "0x6952928")]
		[PreserveSig]
		internal static extern Types.LeaderboardOrder Leaderboard_Order(HandleRef self);
	}
}
