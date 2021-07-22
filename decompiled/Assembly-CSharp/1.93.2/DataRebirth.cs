using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000249 RID: 585
[Token(Token = "0x20001BF")]
public class DataRebirth : ScriptableObject
{
	// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x3C3358", Offset = "0x3C3358", VA = "0x63C3358")]
	public DataRebirth()
	{
	}

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0xC")]
	public List<DataRebirth.Sheet> sheets;

	// Token: 0x0200024A RID: 586
	[Token(Token = "0x20001C0")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x3C33EC", Offset = "0x3C33EC", VA = "0x63C33EC")]
		public Sheet()
		{
		}

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0xC")]
		public List<DataRebirth.Param> list;
	}

	// Token: 0x0200024B RID: 587
	[Token(Token = "0x20001C1")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x3C33E4", Offset = "0x3C33E4", VA = "0x63C33E4")]
		public Param()
		{
		}

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0xC")]
		public string Desc;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x10")]
		public bool Only;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x11")]
		public bool Lock;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x14")]
		public string Currency;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x18")]
		public float Base;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x1C")]
		public float Grow;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x20")]
		public float Factorial;

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x24")]
		public int Max;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x28")]
		public int CostBase;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x2C")]
		public int CostAdd;

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x30")]
		public int CostGrow;
	}
}
