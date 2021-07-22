using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x2000145")]
	internal class CaptureOverlayStateListenerHelper : BaseReferenceHolder
	{
		// Token: 0x06000BA1 RID: 2977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x4544A4", Offset = "0x4544A4", VA = "0x64544A4")]
		internal CaptureOverlayStateListenerHelper(IntPtr selfPointer)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x45452C", Offset = "0x45452C", VA = "0x645452C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x451364", Offset = "0x451364", VA = "0x6451364")]
		internal CaptureOverlayStateListenerHelper SetOnCaptureOverlayStateChangedCallback(Action<Types.VideoCaptureOverlayState> callback)
		{
			return null;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x4542D4", Offset = "0x4542D4", VA = "0x64542D4")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18599C", Offset = "0x18599C")]
		internal static void InternalOnCaptureOverlayStateChangedCallback(Types.VideoCaptureOverlayState response, IntPtr data)
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x4512EC", Offset = "0x4512EC", VA = "0x64512EC")]
		internal static CaptureOverlayStateListenerHelper Create()
		{
			return null;
		}

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F10", Offset = "0x180F10")]
		private static CaptureOverlayStateListenerHelper.OnCaptureOverlayStateChangedCallback <>f__mg$cache0;
	}
}
