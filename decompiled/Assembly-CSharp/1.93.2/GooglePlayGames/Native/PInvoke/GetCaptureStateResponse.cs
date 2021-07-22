using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x2000192")]
	internal class GetCaptureStateResponse : BaseReferenceHolder
	{
		// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x457370", Offset = "0x457370", VA = "0x6457370")]
		internal GetCaptureStateResponse(IntPtr selfPointer)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x4573F8", Offset = "0x4573F8", VA = "0x64573F8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x45185C", Offset = "0x45185C", VA = "0x645185C")]
		internal NativeVideoCaptureState GetData()
		{
			return null;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x4517F4", Offset = "0x4517F4", VA = "0x64517F4")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return (CommonErrorStatus.ResponseStatus)0;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x451820", Offset = "0x451820", VA = "0x6451820")]
		internal bool RequestSucceeded()
		{
			return default(bool);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x457424", Offset = "0x457424", VA = "0x6457424")]
		internal static GetCaptureStateResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
