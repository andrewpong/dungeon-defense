using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x200006A")]
	public interface IVideoClient
	{
		// Token: 0x060004AF RID: 1199
		[Token(Token = "0x6000483")]
		void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback);

		// Token: 0x060004B0 RID: 1200
		[Token(Token = "0x6000484")]
		void ShowCaptureOverlay();

		// Token: 0x060004B1 RID: 1201
		[Token(Token = "0x6000485")]
		void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback);

		// Token: 0x060004B2 RID: 1202
		[Token(Token = "0x6000486")]
		void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback);

		// Token: 0x060004B3 RID: 1203
		[Token(Token = "0x6000487")]
		bool IsCaptureSupported();

		// Token: 0x060004B4 RID: 1204
		[Token(Token = "0x6000488")]
		void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener);

		// Token: 0x060004B5 RID: 1205
		[Token(Token = "0x6000489")]
		void UnregisterCaptureOverlayStateChangedListener();
	}
}
