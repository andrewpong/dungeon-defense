using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025B RID: 603
[Token(Token = "0x20001D1")]
public class DataTrial : ScriptableObject
{
	// Token: 0x06000EC9 RID: 3785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x3C3BC8", Offset = "0x3C3BC8", VA = "0x63C3BC8")]
	public DataTrial()
	{
	}

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0xC")]
	public List<DataTrial.Sheet> sheets;

	// Token: 0x0200025C RID: 604
	[Token(Token = "0x20001D2")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x3C3C5C", Offset = "0x3C3C5C", VA = "0x63C3C5C")]
		public Sheet()
		{
		}

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0xC")]
		public List<DataTrial.Param> list;
	}

	// Token: 0x0200025D RID: 605
	[Token(Token = "0x20001D3")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000ECB RID: 3787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x3C3C54", Offset = "0x3C3C54", VA = "0x63C3C54")]
		public Param()
		{
		}

		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x8")]
		public int Floor;

		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0xC")]
		public string Mutate;

		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x10")]
		public int Day;

		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x14")]
		public bool Ring;

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x18")]
		public int DropMin;

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x1C")]
		public int DropMax;

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x20")]
		public float DropRate;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x24")]
		public int Easy;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x28")]
		public int Normal;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x2C")]
		public int Hard;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x30")]
		public int Insane;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x34")]
		public int End;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x38")]
		public int God;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x3C")]
		public int Hell1;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x40")]
		public int Hell2;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x44")]
		public int Hell3;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x48")]
		public int Hell4;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x4C")]
		public int Hell5;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x50")]
		public int Hell6;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x54")]
		public int Hell7;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x58")]
		public int Hell8;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x5C")]
		public int Hell9;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x60")]
		public int Hell10;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x64")]
		public int Hell11;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x68")]
		public int Hell12;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x6C")]
		public int Hell13;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x70")]
		public int Hell14;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x74")]
		public int Hell15;
	}
}
