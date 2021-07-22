using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x200008E")]
	internal static class Achievement
	{
		// Token: 0x0600068D RID: 1677
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x9498F8", Offset = "0x9498F8", VA = "0x69498F8")]
		[PreserveSig]
		internal static extern uint Achievement_TotalSteps(HandleRef self);

		// Token: 0x0600068E RID: 1678
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x949A08", Offset = "0x949A08", VA = "0x6949A08")]
		[PreserveSig]
		internal static extern UIntPtr Achievement_Description(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x0600068F RID: 1679
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x949B30", Offset = "0x949B30", VA = "0x6949B30")]
		[PreserveSig]
		internal static extern void Achievement_Dispose(HandleRef self);

		// Token: 0x06000690 RID: 1680
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x949C38", Offset = "0x949C38", VA = "0x6949C38")]
		[PreserveSig]
		internal static extern UIntPtr Achievement_UnlockedIconUrl(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000691 RID: 1681
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x949D30", Offset = "0x949D30", VA = "0x6949D30")]
		[PreserveSig]
		internal static extern ulong Achievement_LastModifiedTime(HandleRef self);

		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x949E10", Offset = "0x949E10", VA = "0x6949E10")]
		[PreserveSig]
		internal static extern UIntPtr Achievement_RevealedIconUrl(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000693 RID: 1683
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x949F08", Offset = "0x949F08", VA = "0x6949F08")]
		[PreserveSig]
		internal static extern uint Achievement_CurrentSteps(HandleRef self);

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x94A018", Offset = "0x94A018", VA = "0x694A018")]
		[PreserveSig]
		internal static extern Types.AchievementState Achievement_State(HandleRef self);

		// Token: 0x06000695 RID: 1685
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x94A118", Offset = "0x94A118", VA = "0x694A118")]
		[PreserveSig]
		internal static extern bool Achievement_Valid(HandleRef self);

		// Token: 0x06000696 RID: 1686
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x94A220", Offset = "0x94A220", VA = "0x694A220")]
		[PreserveSig]
		internal static extern ulong Achievement_LastModified(HandleRef self);

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x94A330", Offset = "0x94A330", VA = "0x694A330")]
		[PreserveSig]
		internal static extern ulong Achievement_XP(HandleRef self);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x94A430", Offset = "0x94A430", VA = "0x694A430")]
		[PreserveSig]
		internal static extern Types.AchievementType Achievement_Type(HandleRef self);

		// Token: 0x06000699 RID: 1689
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x94A530", Offset = "0x94A530", VA = "0x694A530")]
		[PreserveSig]
		internal static extern UIntPtr Achievement_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x0600069A RID: 1690
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x94A648", Offset = "0x94A648", VA = "0x694A648")]
		[PreserveSig]
		internal static extern UIntPtr Achievement_Name(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);
	}
}
