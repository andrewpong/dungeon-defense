using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x2000193")]
	internal class IsCaptureAvailableResponse : BaseReferenceHolder
	{
		// Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x4574D8", Offset = "0x4574D8", VA = "0x64574D8")]
		internal IsCaptureAvailableResponse(IntPtr selfPointer)
		{
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x457560", Offset = "0x457560", VA = "0x6457560", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x4519C4", Offset = "0x4519C4", VA = "0x64519C4")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return (CommonErrorStatus.ResponseStatus)0;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x4519F0", Offset = "0x4519F0", VA = "0x64519F0")]
		internal bool RequestSucceeded()
		{
			return default(bool);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x451A2C", Offset = "0x451A2C", VA = "0x6451A2C")]
		internal bool IsCaptureAvailable()
		{
			return default(bool);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x457570", Offset = "0x457570", VA = "0x6457570")]
		internal static IsCaptureAvailableResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
