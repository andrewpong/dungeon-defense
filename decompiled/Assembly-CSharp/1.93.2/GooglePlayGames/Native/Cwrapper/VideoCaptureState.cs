using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200011D")]
	internal static class VideoCaptureState
	{
		// Token: 0x06000945 RID: 2373
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x6D8310", Offset = "0x6D8310", VA = "0x66D8310")]
		[PreserveSig]
		internal static extern bool VideoCaptureState_IsCapturing(HandleRef self);

		// Token: 0x06000946 RID: 2374
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x6D83F8", Offset = "0x6D83F8", VA = "0x66D83F8")]
		[PreserveSig]
		internal static extern Types.VideoCaptureMode VideoCaptureState_CaptureMode(HandleRef self);

		// Token: 0x06000947 RID: 2375
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x6D84D8", Offset = "0x6D84D8", VA = "0x66D84D8")]
		[PreserveSig]
		internal static extern Types.VideoQualityLevel VideoCaptureState_QualityLevel(HandleRef self);

		// Token: 0x06000948 RID: 2376
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x6D85B8", Offset = "0x6D85B8", VA = "0x66D85B8")]
		[PreserveSig]
		internal static extern bool VideoCaptureState_IsOverlayVisible(HandleRef self);

		// Token: 0x06000949 RID: 2377
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x6D86A8", Offset = "0x6D86A8", VA = "0x66D86A8")]
		[PreserveSig]
		internal static extern bool VideoCaptureState_IsPaused(HandleRef self);

		// Token: 0x0600094A RID: 2378
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x6D8790", Offset = "0x6D8790", VA = "0x66D8790")]
		[PreserveSig]
		internal static extern void VideoCaptureState_Dispose(HandleRef self);

		// Token: 0x0600094B RID: 2379
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x6D88A0", Offset = "0x6D88A0", VA = "0x66D88A0")]
		[PreserveSig]
		internal static extern bool VideoCaptureState_Valid(HandleRef self);
	}
}
