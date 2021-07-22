using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Video;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x200013B")]
	internal class NativeVideoClient : IVideoClient
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x450774", Offset = "0x450774", VA = "0x6450774")]
		internal NativeVideoClient(GooglePlayGames.Native.PInvoke.VideoManager manager)
		{
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x4507EC", Offset = "0x4507EC", VA = "0x64507EC", Slot = "4")]
		public void GetCaptureCapabilities(Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback)
		{
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x450988", Offset = "0x450988", VA = "0x6450988")]
		private GooglePlayGames.BasicApi.Video.VideoCapabilities FromNativeVideoCapabilities(NativeVideoCapabilities capabilities)
		{
			return null;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x450CBC", Offset = "0x450CBC", VA = "0x6450CBC", Slot = "5")]
		public void ShowCaptureOverlay()
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x450CE8", Offset = "0x450CE8", VA = "0x6450CE8", Slot = "6")]
		public void GetCaptureState(Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback)
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x450E84", Offset = "0x450E84", VA = "0x6450E84")]
		private GooglePlayGames.BasicApi.Video.VideoCaptureState FromNativeVideoCaptureState(NativeVideoCaptureState captureState)
		{
			return null;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x450FD8", Offset = "0x450FD8", VA = "0x6450FD8", Slot = "7")]
		public void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x451178", Offset = "0x451178", VA = "0x6451178", Slot = "8")]
		public bool IsCaptureSupported()
		{
			return default(bool);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x4511A4", Offset = "0x4511A4", VA = "0x64511A4", Slot = "9")]
		public void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener)
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x4514A0", Offset = "0x4514A0", VA = "0x64514A0", Slot = "10")]
		public void UnregisterCaptureOverlayStateChangedListener()
		{
		}

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x8")]
		private readonly GooglePlayGames.Native.PInvoke.VideoManager mManager;

		// Token: 0x020001B1 RID: 433
		[Token(Token = "0x200032A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC30", Offset = "0x17FC30")]
		private sealed class <GetCaptureCapabilities>c__AnonStorey0
		{
			// Token: 0x06000B4C RID: 2892 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001562")]
			[Address(RVA = "0x450980", Offset = "0x450980", VA = "0x6450980")]
			public <GetCaptureCapabilities>c__AnonStorey0()
			{
			}

			// Token: 0x06000B4D RID: 2893 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001563")]
			[Address(RVA = "0x4514CC", Offset = "0x4514CC", VA = "0x64514CC")]
			internal void <>m__0(GetCaptureCapabilitiesResponse response)
			{
			}

			// Token: 0x04000511 RID: 1297
			[Token(Token = "0x40013F5")]
			[FieldOffset(Offset = "0x8")]
			internal Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback;

			// Token: 0x04000512 RID: 1298
			[Token(Token = "0x40013F6")]
			[FieldOffset(Offset = "0xC")]
			internal NativeVideoClient $this;
		}

		// Token: 0x020001B2 RID: 434
		[Token(Token = "0x200032B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC40", Offset = "0x17FC40")]
		private sealed class <GetCaptureState>c__AnonStorey1
		{
			// Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001564")]
			[Address(RVA = "0x450E7C", Offset = "0x450E7C", VA = "0x6450E7C")]
			public <GetCaptureState>c__AnonStorey1()
			{
			}

			// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001565")]
			[Address(RVA = "0x4516B0", Offset = "0x4516B0", VA = "0x64516B0")]
			internal void <>m__0(GetCaptureStateResponse response)
			{
			}

			// Token: 0x04000513 RID: 1299
			[Token(Token = "0x40013F7")]
			[FieldOffset(Offset = "0x8")]
			internal Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback;

			// Token: 0x04000514 RID: 1300
			[Token(Token = "0x40013F8")]
			[FieldOffset(Offset = "0xC")]
			internal NativeVideoClient $this;
		}

		// Token: 0x020001B3 RID: 435
		[Token(Token = "0x200032C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC50", Offset = "0x17FC50")]
		private sealed class <IsCaptureAvailable>c__AnonStorey2
		{
			// Token: 0x06000B50 RID: 2896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001566")]
			[Address(RVA = "0x451170", Offset = "0x451170", VA = "0x6451170")]
			public <IsCaptureAvailable>c__AnonStorey2()
			{
			}

			// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x451890", Offset = "0x451890", VA = "0x6451890")]
			internal void <>m__0(IsCaptureAvailableResponse response)
			{
			}

			// Token: 0x04000515 RID: 1301
			[Token(Token = "0x40013F9")]
			[FieldOffset(Offset = "0x8")]
			internal Action<ResponseStatus, bool> callback;
		}

		// Token: 0x020001B4 RID: 436
		[Token(Token = "0x200032D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC60", Offset = "0x17FC60")]
		private sealed class <RegisterCaptureOverlayStateChangedListener>c__AnonStorey3
		{
			// Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001568")]
			[Address(RVA = "0x4512E4", Offset = "0x4512E4", VA = "0x64512E4")]
			public <RegisterCaptureOverlayStateChangedListener>c__AnonStorey3()
			{
			}

			// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001569")]
			[Address(RVA = "0x451A58", Offset = "0x451A58", VA = "0x6451A58")]
			internal void <>m__0(Types.VideoCaptureOverlayState response)
			{
			}

			// Token: 0x04000516 RID: 1302
			[Token(Token = "0x40013FA")]
			[FieldOffset(Offset = "0x8")]
			internal CaptureOverlayStateListener listener;
		}
	}
}
