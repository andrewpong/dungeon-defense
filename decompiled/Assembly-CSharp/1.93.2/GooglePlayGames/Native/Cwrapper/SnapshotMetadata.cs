using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x20000EF")]
	internal static class SnapshotMetadata
	{
		// Token: 0x060008BC RID: 2236
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x6D0278", Offset = "0x6D0278", VA = "0x66D0278")]
		[PreserveSig]
		internal static extern void SnapshotMetadata_Dispose(HandleRef self);

		// Token: 0x060008BD RID: 2237
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x6D0388", Offset = "0x6D0388", VA = "0x66D0388")]
		[PreserveSig]
		internal static extern UIntPtr SnapshotMetadata_CoverImageURL(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008BE RID: 2238
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x6D0480", Offset = "0x6D0480", VA = "0x66D0480")]
		[PreserveSig]
		internal static extern UIntPtr SnapshotMetadata_Description(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008BF RID: 2239
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x6D0578", Offset = "0x6D0578", VA = "0x66D0578")]
		[PreserveSig]
		internal static extern bool SnapshotMetadata_IsOpen(HandleRef self);

		// Token: 0x060008C0 RID: 2240
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x6D0690", Offset = "0x6D0690", VA = "0x66D0690")]
		[PreserveSig]
		internal static extern UIntPtr SnapshotMetadata_FileName(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008C1 RID: 2241
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x6D07B8", Offset = "0x6D07B8", VA = "0x66D07B8")]
		[PreserveSig]
		internal static extern bool SnapshotMetadata_Valid(HandleRef self);

		// Token: 0x060008C2 RID: 2242
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x6D08D0", Offset = "0x6D08D0", VA = "0x66D08D0")]
		[PreserveSig]
		internal static extern long SnapshotMetadata_PlayedTime(HandleRef self);

		// Token: 0x060008C3 RID: 2243
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x6D09B0", Offset = "0x6D09B0", VA = "0x66D09B0")]
		[PreserveSig]
		internal static extern long SnapshotMetadata_LastModifiedTime(HandleRef self);
	}
}
