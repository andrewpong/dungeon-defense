using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000BF")]
	internal static class MultiplayerInvitation
	{
		// Token: 0x0600076F RID: 1903
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x9564D8", Offset = "0x9564D8", VA = "0x69564D8")]
		[PreserveSig]
		internal static extern uint MultiplayerInvitation_AutomatchingSlotsAvailable(HandleRef self);

		// Token: 0x06000770 RID: 1904
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x9565D0", Offset = "0x9565D0", VA = "0x69565D0")]
		[PreserveSig]
		internal static extern IntPtr MultiplayerInvitation_InvitingParticipant(HandleRef self);

		// Token: 0x06000771 RID: 1905
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x9566C0", Offset = "0x9566C0", VA = "0x69566C0")]
		[PreserveSig]
		internal static extern uint MultiplayerInvitation_Variant(HandleRef self);

		// Token: 0x06000772 RID: 1906
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x9567A0", Offset = "0x9567A0", VA = "0x69567A0")]
		[PreserveSig]
		internal static extern ulong MultiplayerInvitation_CreationTime(HandleRef self);

		// Token: 0x06000773 RID: 1907
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x956888", Offset = "0x956888", VA = "0x6956888")]
		[PreserveSig]
		internal static extern UIntPtr MultiplayerInvitation_Participants_Length(HandleRef self);

		// Token: 0x06000774 RID: 1908
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x956978", Offset = "0x956978", VA = "0x6956978")]
		[PreserveSig]
		internal static extern IntPtr MultiplayerInvitation_Participants_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x06000775 RID: 1909
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x956A70", Offset = "0x956A70", VA = "0x6956A70")]
		[PreserveSig]
		internal static extern bool MultiplayerInvitation_Valid(HandleRef self);

		// Token: 0x06000776 RID: 1910
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x956B58", Offset = "0x956B58", VA = "0x6956B58")]
		[PreserveSig]
		internal static extern Types.MultiplayerInvitationType MultiplayerInvitation_Type(HandleRef self);

		// Token: 0x06000777 RID: 1911
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x956C38", Offset = "0x956C38", VA = "0x6956C38")]
		[PreserveSig]
		internal static extern UIntPtr MultiplayerInvitation_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000778 RID: 1912
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x956D60", Offset = "0x956D60", VA = "0x6956D60")]
		[PreserveSig]
		internal static extern void MultiplayerInvitation_Dispose(HandleRef self);
	}
}
