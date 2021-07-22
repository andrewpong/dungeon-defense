using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x200011E")]
	internal static class VideoManager
	{
		// Token: 0x0600094C RID: 2380
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x6D89B8", Offset = "0x6D89B8", VA = "0x66D89B8")]
		[PreserveSig]
		internal static extern void VideoManager_GetCaptureCapabilities(HandleRef self, VideoManager.CaptureCapabilitiesCallback callback, IntPtr callback_arg);

		// Token: 0x0600094D RID: 2381
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x6D8AB8", Offset = "0x6D8AB8", VA = "0x66D8AB8")]
		[PreserveSig]
		internal static extern void VideoManager_ShowCaptureOverlay(HandleRef self);

		// Token: 0x0600094E RID: 2382
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x6D8B98", Offset = "0x6D8B98", VA = "0x66D8B98")]
		[PreserveSig]
		internal static extern void VideoManager_GetCaptureState(HandleRef self, VideoManager.CaptureStateCallback callback, IntPtr callback_arg);

		// Token: 0x0600094F RID: 2383
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x6D8C98", Offset = "0x6D8C98", VA = "0x66D8C98")]
		[PreserveSig]
		internal static extern void VideoManager_IsCaptureAvailable(HandleRef self, Types.VideoCaptureMode capture_mode, VideoManager.IsCaptureAvailableCallback callback, IntPtr callback_arg);

		// Token: 0x06000950 RID: 2384
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x6D8DA0", Offset = "0x6D8DA0", VA = "0x66D8DA0")]
		[PreserveSig]
		internal static extern bool VideoManager_IsCaptureSupported(HandleRef self);

		// Token: 0x06000951 RID: 2385
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x6D8E88", Offset = "0x6D8E88", VA = "0x66D8E88")]
		[PreserveSig]
		internal static extern void VideoManager_RegisterCaptureOverlayStateChangedListener(HandleRef self, IntPtr helper);

		// Token: 0x06000952 RID: 2386
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x6D8F88", Offset = "0x6D8F88", VA = "0x66D8F88")]
		[PreserveSig]
		internal static extern void VideoManager_UnregisterCaptureOverlayStateChangedListener(HandleRef self);

		// Token: 0x06000953 RID: 2387
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x6D9088", Offset = "0x6D9088", VA = "0x66D9088")]
		[PreserveSig]
		internal static extern void VideoManager_GetCaptureCapabilitiesResponse_Dispose(HandleRef self);

		// Token: 0x06000954 RID: 2388
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x6D9180", Offset = "0x6D9180", VA = "0x66D9180")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus VideoManager_GetCaptureCapabilitiesResponse_GetStatus(HandleRef self);

		// Token: 0x06000955 RID: 2389
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x6D9278", Offset = "0x6D9278", VA = "0x66D9278")]
		[PreserveSig]
		internal static extern IntPtr VideoManager_GetCaptureCapabilitiesResponse_GetVideoCapabilities(HandleRef self);

		// Token: 0x06000956 RID: 2390
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x6D9340", Offset = "0x6D9340", VA = "0x66D9340")]
		[PreserveSig]
		internal static extern void VideoManager_GetCaptureStateResponse_Dispose(HandleRef self);

		// Token: 0x06000957 RID: 2391
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x6D9430", Offset = "0x6D9430", VA = "0x66D9430")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus VideoManager_GetCaptureStateResponse_GetStatus(HandleRef self);

		// Token: 0x06000958 RID: 2392
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x6D9520", Offset = "0x6D9520", VA = "0x66D9520")]
		[PreserveSig]
		internal static extern IntPtr VideoManager_GetCaptureStateResponse_GetVideoCaptureState(HandleRef self);

		// Token: 0x06000959 RID: 2393
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x6D9620", Offset = "0x6D9620", VA = "0x66D9620")]
		[PreserveSig]
		internal static extern void VideoManager_IsCaptureAvailableResponse_Dispose(HandleRef self);

		// Token: 0x0600095A RID: 2394
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x6D9710", Offset = "0x6D9710", VA = "0x66D9710")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus VideoManager_IsCaptureAvailableResponse_GetStatus(HandleRef self);

		// Token: 0x0600095B RID: 2395
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x6D9808", Offset = "0x6D9808", VA = "0x66D9808")]
		[PreserveSig]
		internal static extern bool VideoManager_IsCaptureAvailableResponse_GetIsCaptureAvailable(HandleRef self);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x0600095D RID: 2397
		[Token(Token = "0x200011F")]
		internal delegate void CaptureCapabilitiesCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x06000961 RID: 2401
		[Token(Token = "0x2000120")]
		internal delegate void CaptureStateCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x06000965 RID: 2405
		[Token(Token = "0x2000121")]
		internal delegate void IsCaptureAvailableCallback(IntPtr arg0, IntPtr arg1);
	}
}
