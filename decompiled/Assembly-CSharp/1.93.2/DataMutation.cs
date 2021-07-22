using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000243 RID: 579
[Token(Token = "0x20001B9")]
public class DataMutation : ScriptableObject
{
	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x3C3088", Offset = "0x3C3088", VA = "0x63C3088")]
	public DataMutation()
	{
	}

	// Token: 0x04000696 RID: 1686
	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0xC")]
	public List<DataMutation.Sheet> sheets;

	// Token: 0x02000244 RID: 580
	[Token(Token = "0x20001BA")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x3C311C", Offset = "0x3C311C", VA = "0x63C311C")]
		public Sheet()
		{
		}

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0xC")]
		public List<DataMutation.Param> list;
	}

	// Token: 0x02000245 RID: 581
	[Token(Token = "0x20001BB")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x3C3114", Offset = "0x3C3114", VA = "0x63C3114")]
		public Param()
		{
		}

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x14")]
		public bool Boss;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x15")]
		public bool Use;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x18")]
		public float Fac1;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x1C")]
		public float Grow1;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x20")]
		public float Max1;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x24")]
		public float Fac2;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x28")]
		public float Grow2;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x2C")]
		public float Max2;
	}
}
