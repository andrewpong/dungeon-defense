using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x200016B")]
	internal class NativeVideoCaptureState : BaseReferenceHolder
	{
		// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x47D16C", Offset = "0x47D16C", VA = "0x647D16C")]
		internal NativeVideoCaptureState(IntPtr selfPtr)
		{
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x47D1F8", Offset = "0x47D1F8", VA = "0x647D1F8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x47D208", Offset = "0x47D208", VA = "0x647D208")]
		internal bool IsCapturing()
		{
			return default(bool);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x47D238", Offset = "0x47D238", VA = "0x647D238")]
		internal Types.VideoCaptureMode CaptureMode()
		{
			return Types.VideoCaptureMode.FILE;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x47D268", Offset = "0x47D268", VA = "0x647D268")]
		internal Types.VideoQualityLevel QualityLevel()
		{
			return Types.VideoQualityLevel.SD;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x47D298", Offset = "0x47D298", VA = "0x647D298")]
		internal bool IsOverlayVisible()
		{
			return default(bool);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x47D2C8", Offset = "0x47D2C8", VA = "0x647D2C8")]
		internal bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x47D2F8", Offset = "0x47D2F8", VA = "0x647D2F8")]
		internal static NativeVideoCaptureState FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
