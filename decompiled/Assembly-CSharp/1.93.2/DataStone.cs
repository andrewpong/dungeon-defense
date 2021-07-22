using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000258 RID: 600
[Token(Token = "0x20001CE")]
public class DataStone : ScriptableObject
{
	// Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x3C3A60", Offset = "0x3C3A60", VA = "0x63C3A60")]
	public DataStone()
	{
	}

	// Token: 0x040006F8 RID: 1784
	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0xC")]
	public List<DataStone.Sheet> sheets;

	// Token: 0x02000259 RID: 601
	[Token(Token = "0x20001CF")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x3C3AF4", Offset = "0x3C3AF4", VA = "0x63C3AF4")]
		public Sheet()
		{
		}

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0xC")]
		public List<DataStone.Param> list;
	}

	// Token: 0x0200025A RID: 602
	[Token(Token = "0x20001D0")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x3C3AEC", Offset = "0x3C3AEC", VA = "0x63C3AEC")]
		public Param()
		{
		}

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x10")]
		public double Normal;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x18")]
		public double Easy;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x20")]
		public double Hard;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x28")]
		public double Insane;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x30")]
		public double End;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x38")]
		public double God;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x40")]
		public double Hell1;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x48")]
		public double Hell2;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x50")]
		public double Hell3;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x58")]
		public double Hell4;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x60")]
		public double Hell5;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x68")]
		public double Hell6;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x70")]
		public double Hell7;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x78")]
		public double Hell8;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x80")]
		public double Hell9;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x88")]
		public double Hell10;

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x90")]
		public double Hell11;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x98")]
		public double Hell12;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0xA0")]
		public double Hell13;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0xA8")]
		public double Hell14;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0xB0")]
		public double Hell15;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0xB8")]
		public double Mul;
	}
}
