using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x200006B")]
	public class VideoCapabilities
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x9467AC", Offset = "0x9467AC", VA = "0x69467AC")]
		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x17000096")]
		public bool IsCameraSupported
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x9467EC", Offset = "0x9467EC", VA = "0x69467EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x17000097")]
		public bool IsMicSupported
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x9467F4", Offset = "0x9467F4", VA = "0x69467F4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x17000098")]
		public bool IsWriteStorageSupported
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x9467FC", Offset = "0x9467FC", VA = "0x69467FC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x946804", Offset = "0x946804", VA = "0x6946804")]
		public bool SupportsCaptureMode(VideoCaptureMode captureMode)
		{
			return default(bool);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x9468EC", Offset = "0x9468EC", VA = "0x69468EC")]
		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel)
		{
			return default(bool);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x9469D4", Offset = "0x9469D4", VA = "0x69469D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x946E84", Offset = "0x946E84", VA = "0x6946E84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18558C", Offset = "0x18558C")]
		private static string <ToString>m__0(bool p)
		{
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x946EA8", Offset = "0x946EA8", VA = "0x6946EA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18559C", Offset = "0x18559C")]
		private static string <ToString>m__1(bool p)
		{
			return null;
		}

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x8")]
		private bool mIsCameraSupported;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x9")]
		private bool mIsMicSupported;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0xA")]
		private bool mIsWriteStorageSupported;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0xC")]
		private bool[] mCaptureModesSupported;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x10")]
		private bool[] mQualityLevelsSupported;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180DB0", Offset = "0x180DB0")]
		private static Func<bool, string> <>f__am$cache0;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180DC0", Offset = "0x180DC0")]
		private static Func<bool, string> <>f__am$cache1;
	}
}
