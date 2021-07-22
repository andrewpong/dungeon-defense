using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000191")]
	internal class GetCaptureCapabilitiesResponse : BaseReferenceHolder
	{
		// Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x457208", Offset = "0x457208", VA = "0x6457208")]
		internal GetCaptureCapabilitiesResponse(IntPtr selfPointer)
		{
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x457290", Offset = "0x457290", VA = "0x6457290", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x451614", Offset = "0x451614", VA = "0x6451614")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return (CommonErrorStatus.ResponseStatus)0;
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x451640", Offset = "0x451640", VA = "0x6451640")]
		internal bool RequestSucceeded()
		{
			return default(bool);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x45167C", Offset = "0x45167C", VA = "0x645167C")]
		internal NativeVideoCapabilities GetData()
		{
			return null;
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x4572BC", Offset = "0x4572BC", VA = "0x64572BC")]
		internal static GetCaptureCapabilitiesResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
