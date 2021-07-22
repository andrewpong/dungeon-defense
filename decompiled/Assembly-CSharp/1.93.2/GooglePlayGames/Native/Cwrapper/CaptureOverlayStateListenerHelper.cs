using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x200009E")]
	internal static class CaptureOverlayStateListenerHelper
	{
		// Token: 0x060006EF RID: 1775
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x94F0D0", Offset = "0x94F0D0", VA = "0x694F0D0")]
		[PreserveSig]
		internal static extern void CaptureOverlayStateListenerHelper_SetOnCaptureOverlayStateChangedCallback(HandleRef self, CaptureOverlayStateListenerHelper.OnCaptureOverlayStateChangedCallback callback, IntPtr callback_arg);

		// Token: 0x060006F0 RID: 1776
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x94F1B8", Offset = "0x94F1B8", VA = "0x694F1B8")]
		[PreserveSig]
		internal static extern IntPtr CaptureOverlayStateListenerHelper_Construct();

		// Token: 0x060006F1 RID: 1777
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x94F298", Offset = "0x94F298", VA = "0x694F298")]
		[PreserveSig]
		internal static extern void CaptureOverlayStateListenerHelper_Dispose(HandleRef self);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x060006F3 RID: 1779
		[Token(Token = "0x200009F")]
		internal delegate void OnCaptureOverlayStateChangedCallback(Types.VideoCaptureOverlayState arg0, IntPtr arg1);
	}
}
