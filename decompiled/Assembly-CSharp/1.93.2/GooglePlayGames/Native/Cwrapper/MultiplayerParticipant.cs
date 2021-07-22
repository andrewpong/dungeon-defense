using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000C0")]
	internal static class MultiplayerParticipant
	{
		// Token: 0x06000779 RID: 1913
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x956E40", Offset = "0x956E40", VA = "0x6956E40")]
		[PreserveSig]
		internal static extern Types.ParticipantStatus MultiplayerParticipant_Status(HandleRef self);

		// Token: 0x0600077A RID: 1914
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x956F20", Offset = "0x956F20", VA = "0x6956F20")]
		[PreserveSig]
		internal static extern uint MultiplayerParticipant_MatchRank(HandleRef self);

		// Token: 0x0600077B RID: 1915
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x957008", Offset = "0x957008", VA = "0x6957008")]
		[PreserveSig]
		internal static extern bool MultiplayerParticipant_IsConnectedToRoom(HandleRef self);

		// Token: 0x0600077C RID: 1916
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x957100", Offset = "0x957100", VA = "0x6957100")]
		[PreserveSig]
		internal static extern UIntPtr MultiplayerParticipant_DisplayName(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x0600077D RID: 1917
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x957200", Offset = "0x957200", VA = "0x6957200")]
		[PreserveSig]
		internal static extern bool MultiplayerParticipant_HasPlayer(HandleRef self);

		// Token: 0x0600077E RID: 1918
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x9572F0", Offset = "0x9572F0", VA = "0x69572F0")]
		[PreserveSig]
		internal static extern UIntPtr MultiplayerParticipant_AvatarUrl(HandleRef self, Types.ImageResolution resolution, [In] [Out] char[] out_arg, UIntPtr out_size);

		// Token: 0x0600077F RID: 1919
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x9574B8", Offset = "0x9574B8", VA = "0x69574B8")]
		[PreserveSig]
		internal static extern Types.MatchResult MultiplayerParticipant_MatchResult(HandleRef self);

		// Token: 0x06000780 RID: 1920
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x9575A0", Offset = "0x9575A0", VA = "0x69575A0")]
		[PreserveSig]
		internal static extern IntPtr MultiplayerParticipant_Player(HandleRef self);

		// Token: 0x06000781 RID: 1921
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x957680", Offset = "0x957680", VA = "0x6957680")]
		[PreserveSig]
		internal static extern void MultiplayerParticipant_Dispose(HandleRef self);

		// Token: 0x06000782 RID: 1922
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x957760", Offset = "0x957760", VA = "0x6957760")]
		[PreserveSig]
		internal static extern bool MultiplayerParticipant_Valid(HandleRef self);

		// Token: 0x06000783 RID: 1923
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x957848", Offset = "0x957848", VA = "0x6957848")]
		[PreserveSig]
		internal static extern bool MultiplayerParticipant_HasMatchResult(HandleRef self);

		// Token: 0x06000784 RID: 1924
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x957938", Offset = "0x957938", VA = "0x6957938")]
		[PreserveSig]
		internal static extern UIntPtr MultiplayerParticipant_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);
	}
}
