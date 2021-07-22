using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024F RID: 591
[Token(Token = "0x20001C5")]
public class DataRuby : ScriptableObject
{
	// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x3C3628", Offset = "0x3C3628", VA = "0x63C3628")]
	public DataRuby()
	{
	}

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0xC")]
	public List<DataRuby.Sheet> sheets;

	// Token: 0x02000250 RID: 592
	[Token(Token = "0x20001C6")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x3C36BC", Offset = "0x3C36BC", VA = "0x63C36BC")]
		public Sheet()
		{
		}

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0xC")]
		public List<DataRuby.Param> list;
	}

	// Token: 0x02000251 RID: 593
	[Token(Token = "0x20001C7")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x3C36B4", Offset = "0x3C36B4", VA = "0x63C36B4")]
		public Param()
		{
		}

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0xC")]
		public float Normal;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x10")]
		public float Easy;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x14")]
		public float Hard;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x18")]
		public float Insane;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x1C")]
		public float End;

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x20")]
		public float God;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x24")]
		public float Hell1;

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x28")]
		public float Hell2;

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x2C")]
		public float Hell3;

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x30")]
		public float Hell4;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x34")]
		public float Hell5;

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x38")]
		public float Hell6;

		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x3C")]
		public float Hell7;

		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x40")]
		public float Hell8;

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x44")]
		public float Hell9;

		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x48")]
		public float Hell10;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x4C")]
		public float Hell11;

		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x50")]
		public float Hell12;

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x54")]
		public float Hell13;

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x58")]
		public float Hell14;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x5C")]
		public float Hell15;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x60")]
		public float Mul;
	}
}
