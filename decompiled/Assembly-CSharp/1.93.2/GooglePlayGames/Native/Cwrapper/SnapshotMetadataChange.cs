using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x20000F0")]
	internal static class SnapshotMetadataChange
	{
		// Token: 0x060008C4 RID: 2244
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x6D0A98", Offset = "0x6D0A98", VA = "0x66D0A98")]
		[PreserveSig]
		internal static extern UIntPtr SnapshotMetadataChange_Description(HandleRef self, [In] [Out] char[] out_arg, UIntPtr out_size);

		// Token: 0x060008C5 RID: 2245
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x6D0C50", Offset = "0x6D0C50", VA = "0x66D0C50")]
		[PreserveSig]
		internal static extern IntPtr SnapshotMetadataChange_Image(HandleRef self);

		// Token: 0x060008C6 RID: 2246
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x6D0D30", Offset = "0x6D0D30", VA = "0x66D0D30")]
		[PreserveSig]
		internal static extern bool SnapshotMetadataChange_PlayedTimeIsChanged(HandleRef self);

		// Token: 0x060008C7 RID: 2247
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x6D0E28", Offset = "0x6D0E28", VA = "0x66D0E28")]
		[PreserveSig]
		internal static extern bool SnapshotMetadataChange_Valid(HandleRef self);

		// Token: 0x060008C8 RID: 2248
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x6D0F10", Offset = "0x6D0F10", VA = "0x66D0F10")]
		[PreserveSig]
		internal static extern ulong SnapshotMetadataChange_PlayedTime(HandleRef self);

		// Token: 0x060008C9 RID: 2249
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x6D0FF8", Offset = "0x6D0FF8", VA = "0x66D0FF8")]
		[PreserveSig]
		internal static extern void SnapshotMetadataChange_Dispose(HandleRef self);

		// Token: 0x060008CA RID: 2250
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x6D10D8", Offset = "0x6D10D8", VA = "0x66D10D8")]
		[PreserveSig]
		internal static extern bool SnapshotMetadataChange_ImageIsChanged(HandleRef self);

		// Token: 0x060008CB RID: 2251
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x6D11C8", Offset = "0x6D11C8", VA = "0x66D11C8")]
		[PreserveSig]
		internal static extern bool SnapshotMetadataChange_DescriptionIsChanged(HandleRef self);
	}
}
