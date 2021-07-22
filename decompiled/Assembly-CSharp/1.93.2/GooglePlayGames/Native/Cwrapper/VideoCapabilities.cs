using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200011C")]
	internal static class VideoCapabilities
	{
		// Token: 0x0600093E RID: 2366
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x6D7C20", Offset = "0x6D7C20", VA = "0x66D7C20")]
		[PreserveSig]
		internal static extern bool VideoCapabilities_IsCameraSupported(HandleRef self);

		// Token: 0x0600093F RID: 2367
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x6D7D10", Offset = "0x6D7D10", VA = "0x66D7D10")]
		[PreserveSig]
		internal static extern bool VideoCapabilities_IsMicSupported(HandleRef self);

		// Token: 0x06000940 RID: 2368
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x6D7E00", Offset = "0x6D7E00", VA = "0x66D7E00")]
		[PreserveSig]
		internal static extern bool VideoCapabilities_IsWriteStorageSupported(HandleRef self);

		// Token: 0x06000941 RID: 2369
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x6D7EF8", Offset = "0x6D7EF8", VA = "0x66D7EF8")]
		[PreserveSig]
		internal static extern bool VideoCapabilities_SupportsCaptureMode(HandleRef self, Types.VideoCaptureMode capture_mode);

		// Token: 0x06000942 RID: 2370
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x6D7FF0", Offset = "0x6D7FF0", VA = "0x66D7FF0")]
		[PreserveSig]
		internal static extern bool VideoCapabilities_SupportsQualityLevel(HandleRef self, Types.VideoQualityLevel quality_level);

		// Token: 0x06000943 RID: 2371
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x6D80E8", Offset = "0x6D80E8", VA = "0x66D80E8")]
		[PreserveSig]
		internal static extern void VideoCapabilities_Dispose(HandleRef self);

		// Token: 0x06000944 RID: 2372
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x6D81F8", Offset = "0x6D81F8", VA = "0x66D81F8")]
		[PreserveSig]
		internal static extern bool VideoCapabilities_Valid(HandleRef self);
	}
}
