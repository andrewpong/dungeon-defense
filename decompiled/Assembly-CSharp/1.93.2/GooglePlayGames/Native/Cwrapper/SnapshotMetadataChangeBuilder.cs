using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x20000F1")]
	internal static class SnapshotMetadataChangeBuilder
	{
		// Token: 0x060008CC RID: 2252
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x6D12C0", Offset = "0x6D12C0", VA = "0x66D12C0")]
		[PreserveSig]
		internal static extern void SnapshotMetadataChange_Builder_SetDescription(HandleRef self, string description);

		// Token: 0x060008CD RID: 2253
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x6D13D8", Offset = "0x6D13D8", VA = "0x66D13D8")]
		[PreserveSig]
		internal static extern IntPtr SnapshotMetadataChange_Builder_Construct();

		// Token: 0x060008CE RID: 2254
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x6D14B8", Offset = "0x6D14B8", VA = "0x66D14B8")]
		[PreserveSig]
		internal static extern void SnapshotMetadataChange_Builder_SetPlayedTime(HandleRef self, ulong played_time);

		// Token: 0x060008CF RID: 2255
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x6D15B8", Offset = "0x6D15B8", VA = "0x66D15B8")]
		[PreserveSig]
		internal static extern void SnapshotMetadataChange_Builder_SetCoverImageFromPngData(HandleRef self, byte[] png_data, UIntPtr png_data_size);

		// Token: 0x060008D0 RID: 2256
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x6D16C8", Offset = "0x6D16C8", VA = "0x66D16C8")]
		[PreserveSig]
		internal static extern IntPtr SnapshotMetadataChange_Builder_Create(HandleRef self);

		// Token: 0x060008D1 RID: 2257
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x6D17B0", Offset = "0x6D17B0", VA = "0x66D17B0")]
		[PreserveSig]
		internal static extern void SnapshotMetadataChange_Builder_Dispose(HandleRef self);
	}
}
