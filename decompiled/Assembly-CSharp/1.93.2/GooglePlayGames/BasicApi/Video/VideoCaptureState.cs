using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x200006C")]
	public class VideoCaptureState
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x946ECC", Offset = "0x946ECC", VA = "0x6946ECC")]
		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x17000099")]
		public bool IsCapturing
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x946F0C", Offset = "0x946F0C", VA = "0x6946F0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x1700009A")]
		public VideoCaptureMode CaptureMode
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x946F14", Offset = "0x946F14", VA = "0x6946F14")]
			get
			{
				return VideoCaptureMode.File;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x1700009B")]
		public VideoQualityLevel QualityLevel
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x946F1C", Offset = "0x946F1C", VA = "0x6946F1C")]
			get
			{
				return VideoQualityLevel.SD;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x1700009C")]
		public bool IsOverlayVisible
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x946F24", Offset = "0x946F24", VA = "0x6946F24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x1700009D")]
		public bool IsPaused
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x946F2C", Offset = "0x946F2C", VA = "0x6946F2C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x946F34", Offset = "0x946F34", VA = "0x6946F34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x8")]
		private bool mIsCapturing;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0xC")]
		private VideoCaptureMode mCaptureMode;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x10")]
		private VideoQualityLevel mQualityLevel;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x14")]
		private bool mIsOverlayVisible;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x15")]
		private bool mIsPaused;
	}
}
