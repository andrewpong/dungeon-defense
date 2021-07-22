using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x2000166")]
	internal class NativeSnapshotMetadataChange : BaseReferenceHolder
	{
		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x47AA20", Offset = "0x47AA20", VA = "0x647AA20")]
		internal NativeSnapshotMetadataChange(IntPtr selfPointer)
		{
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x47AAAC", Offset = "0x47AAAC", VA = "0x647AAAC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x47AABC", Offset = "0x47AABC", VA = "0x647AABC")]
		internal static NativeSnapshotMetadataChange FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x020001E9 RID: 489
		[Token(Token = "0x2000167")]
		internal class Builder : BaseReferenceHolder
		{
			// Token: 0x06000CCB RID: 3275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0x47AB70", Offset = "0x47AB70", VA = "0x647AB70")]
			internal Builder()
			{
			}

			// Token: 0x06000CCC RID: 3276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B90")]
			[Address(RVA = "0x47AC04", Offset = "0x47AC04", VA = "0x647AC04", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000CCD RID: 3277 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x47AC14", Offset = "0x47AC14", VA = "0x647AC14")]
			internal NativeSnapshotMetadataChange.Builder SetDescription(string description)
			{
				return null;
			}

			// Token: 0x06000CCE RID: 3278 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x47AC54", Offset = "0x47AC54", VA = "0x647AC54")]
			internal NativeSnapshotMetadataChange.Builder SetPlayedTime(ulong playedTime)
			{
				return null;
			}

			// Token: 0x06000CCF RID: 3279 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x47ACA4", Offset = "0x47ACA4", VA = "0x647ACA4")]
			internal NativeSnapshotMetadataChange.Builder SetCoverImageFromPngData(byte[] pngData)
			{
				return null;
			}

			// Token: 0x06000CD0 RID: 3280 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x47AD78", Offset = "0x47AD78", VA = "0x647AD78")]
			internal NativeSnapshotMetadataChange.Builder From(SavedGameMetadataUpdate update)
			{
				return null;
			}

			// Token: 0x06000CD1 RID: 3281 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x47AF68", Offset = "0x47AF68", VA = "0x647AF68")]
			internal NativeSnapshotMetadataChange Build()
			{
				return null;
			}
		}
	}
}
