using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x200008D")]
	internal static class ConversionUtils
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x948F0C", Offset = "0x948F0C", VA = "0x6948F0C")]
		internal static ResponseStatus ConvertResponseStatus(CommonErrorStatus.ResponseStatus status)
		{
			return (ResponseStatus)0;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x949058", Offset = "0x949058", VA = "0x6949058")]
		internal static CommonStatusCodes ConvertResponseStatusToCommonStatus(CommonErrorStatus.ResponseStatus status)
		{
			return CommonStatusCodes.Success;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x9491B4", Offset = "0x9491B4", VA = "0x69491B4")]
		internal static UIStatus ConvertUIStatus(CommonErrorStatus.UIStatus status)
		{
			return (UIStatus)0;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x949318", Offset = "0x949318", VA = "0x6949318")]
		internal static Types.DataSource AsDataSource(DataSource source)
		{
			return (Types.DataSource)0;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x949438", Offset = "0x949438", VA = "0x6949438")]
		internal static Types.VideoCaptureMode ConvertVideoCaptureMode(VideoCaptureMode captureMode)
		{
			return Types.VideoCaptureMode.FILE;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x94955C", Offset = "0x94955C", VA = "0x694955C")]
		internal static VideoCaptureMode ConvertNativeVideoCaptureMode(Types.VideoCaptureMode nativeCaptureMode)
		{
			return VideoCaptureMode.File;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x949680", Offset = "0x949680", VA = "0x6949680")]
		internal static VideoQualityLevel ConvertNativeVideoQualityLevel(Types.VideoQualityLevel nativeQualityLevel)
		{
			return VideoQualityLevel.SD;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x9497A4", Offset = "0x9497A4", VA = "0x69497A4")]
		internal static VideoCaptureOverlayState ConvertNativeVideoCaptureOverlayState(Types.VideoCaptureOverlayState nativeOverlayState)
		{
			return (VideoCaptureOverlayState)0;
		}
	}
}
