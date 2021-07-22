using System;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000190")]
	internal class VideoManager
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x48C004", Offset = "0x48C004", VA = "0x648C004")]
		internal VideoManager(GameServices services)
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x17000118")]
		internal int NumCaptureModes
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x48C07C", Offset = "0x48C07C", VA = "0x648C07C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x17000119")]
		internal int NumQualityLevels
		{
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x48C084", Offset = "0x48C084", VA = "0x648C084")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x48C08C", Offset = "0x48C08C", VA = "0x648C08C")]
		internal void GetCaptureCapabilities(Action<GetCaptureCapabilitiesResponse> callback)
		{
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x48BE00", Offset = "0x48BE00", VA = "0x648BE00")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x187214", Offset = "0x187214")]
		internal static void InternalCaptureCapabilitiesCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x48C25C", Offset = "0x48C25C", VA = "0x648C25C")]
		internal void ShowCaptureOverlay()
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x48C2A0", Offset = "0x48C2A0", VA = "0x648C2A0")]
		internal void GetCaptureState(Action<GetCaptureStateResponse> callback)
		{
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x48BEAC", Offset = "0x48BEAC", VA = "0x648BEAC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18728C", Offset = "0x18728C")]
		internal static void InternalCaptureStateCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x48C470", Offset = "0x48C470", VA = "0x648C470")]
		internal void IsCaptureAvailable(Types.VideoCaptureMode captureMode, Action<IsCaptureAvailableResponse> callback)
		{
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x48BF58", Offset = "0x48BF58", VA = "0x648BF58")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x187304", Offset = "0x187304")]
		internal static void InternalIsCaptureAvailableCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x48C644", Offset = "0x48C644", VA = "0x648C644")]
		internal bool IsCaptureSupported()
		{
			return default(bool);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x48C688", Offset = "0x48C688", VA = "0x648C688")]
		internal void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListenerHelper helper)
		{
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x48C6F0", Offset = "0x48C6F0", VA = "0x648C6F0")]
		internal void UnregisterCaptureOverlayStateChangedListener()
		{
		}

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x8")]
		private readonly GameServices mServices;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814B0", Offset = "0x1814B0")]
		private static Func<IntPtr, GetCaptureCapabilitiesResponse> <>f__mg$cache0;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814C0", Offset = "0x1814C0")]
		private static VideoManager.CaptureCapabilitiesCallback <>f__mg$cache1;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814D0", Offset = "0x1814D0")]
		private static Func<IntPtr, GetCaptureStateResponse> <>f__mg$cache2;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814E0", Offset = "0x1814E0")]
		private static VideoManager.CaptureStateCallback <>f__mg$cache3;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814F0", Offset = "0x1814F0")]
		private static Func<IntPtr, IsCaptureAvailableResponse> <>f__mg$cache4;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181500", Offset = "0x181500")]
		private static VideoManager.IsCaptureAvailableCallback <>f__mg$cache5;
	}
}
