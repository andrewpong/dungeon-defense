using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000CD")]
	internal static class Player
	{
		// Token: 0x060007C3 RID: 1987
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x95B618", Offset = "0x95B618", VA = "0x695B618")]
		[PreserveSig]
		internal static extern IntPtr Player_CurrentLevel(HandleRef self);

		// Token: 0x060007C4 RID: 1988
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x95B720", Offset = "0x95B720", VA = "0x695B720")]
		[PreserveSig]
		internal static extern UIntPtr Player_Name(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007C5 RID: 1989
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x95B830", Offset = "0x95B830", VA = "0x695B830")]
		[PreserveSig]
		internal static extern void Player_Dispose(HandleRef self);

		// Token: 0x060007C6 RID: 1990
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x95B930", Offset = "0x95B930", VA = "0x695B930")]
		[PreserveSig]
		internal static extern UIntPtr Player_AvatarUrl(HandleRef self, Types.ImageResolution resolution, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007C7 RID: 1991
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x95BA50", Offset = "0x95BA50", VA = "0x695BA50")]
		[PreserveSig]
		internal static extern ulong Player_LastLevelUpTime(HandleRef self);

		// Token: 0x060007C8 RID: 1992
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x95BB60", Offset = "0x95BB60", VA = "0x695BB60")]
		[PreserveSig]
		internal static extern UIntPtr Player_Title(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007C9 RID: 1993
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x95BC70", Offset = "0x95BC70", VA = "0x695BC70")]
		[PreserveSig]
		internal static extern ulong Player_CurrentXP(HandleRef self);

		// Token: 0x060007CA RID: 1994
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x95BD70", Offset = "0x95BD70", VA = "0x695BD70")]
		[PreserveSig]
		internal static extern bool Player_Valid(HandleRef self);

		// Token: 0x060007CB RID: 1995
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x95BE70", Offset = "0x95BE70", VA = "0x695BE70")]
		[PreserveSig]
		internal static extern bool Player_HasLevelInfo(HandleRef self);

		// Token: 0x060007CC RID: 1996
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x95BF80", Offset = "0x95BF80", VA = "0x695BF80")]
		[PreserveSig]
		internal static extern IntPtr Player_NextLevel(HandleRef self);

		// Token: 0x060007CD RID: 1997
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x95C080", Offset = "0x95C080", VA = "0x695C080")]
		[PreserveSig]
		internal static extern UIntPtr Player_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);
	}
}
