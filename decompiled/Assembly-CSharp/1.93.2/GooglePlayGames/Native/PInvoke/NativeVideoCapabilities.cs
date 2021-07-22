using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x200016A")]
	internal class NativeVideoCapabilities : BaseReferenceHolder
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x47CF1C", Offset = "0x47CF1C", VA = "0x647CF1C")]
		internal NativeVideoCapabilities(IntPtr selfPtr)
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x47CFA8", Offset = "0x47CFA8", VA = "0x647CFA8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x47CFB8", Offset = "0x47CFB8", VA = "0x647CFB8")]
		internal bool IsCameraSupported()
		{
			return default(bool);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x47CFE8", Offset = "0x47CFE8", VA = "0x647CFE8")]
		internal bool IsMicSupported()
		{
			return default(bool);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x47D018", Offset = "0x47D018", VA = "0x647D018")]
		internal bool IsWriteStorageSupported()
		{
			return default(bool);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x47D048", Offset = "0x47D048", VA = "0x647D048")]
		internal bool SupportsCaptureMode(Types.VideoCaptureMode captureMode)
		{
			return default(bool);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x47D080", Offset = "0x47D080", VA = "0x647D080")]
		internal bool SupportsQualityLevel(Types.VideoQualityLevel qualityLevel)
		{
			return default(bool);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x47D0B8", Offset = "0x47D0B8", VA = "0x647D0B8")]
		internal static NativeVideoCapabilities FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
