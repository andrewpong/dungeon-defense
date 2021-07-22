using System;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x2000219")]
	public class SingleLineClampAttribute : SingleLineAttribute
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x2ED320", Offset = "0x2ED320", VA = "0x62ED320")]
		public SingleLineClampAttribute(string tooltip, double minValue, double maxValue)
		{
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00006AC8 File Offset: 0x00004CC8
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000134")]
		public double MinValue
		{
			[Token(Token = "0x6000EC7")]
			[Address(RVA = "0x2ED374", Offset = "0x2ED374", VA = "0x62ED374")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1875DC", Offset = "0x1875DC")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x2ED354", Offset = "0x2ED354", VA = "0x62ED354")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1875EC", Offset = "0x1875EC")]
			private set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00006AE0 File Offset: 0x00004CE0
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000135")]
		public double MaxValue
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x2ED380", Offset = "0x2ED380", VA = "0x62ED380")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1875FC", Offset = "0x1875FC")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x2ED364", Offset = "0x2ED364", VA = "0x62ED364")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18760C", Offset = "0x18760C")]
			private set
			{
			}
		}

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x183304", Offset = "0x183304")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x183304", Offset = "0x183304")]
		private double <MinValue>k__BackingField;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x183338", Offset = "0x183338")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x183338", Offset = "0x183338")]
		private double <MaxValue>k__BackingField;
	}
}
