using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023A RID: 570
[Token(Token = "0x20001B0")]
public class DataMod : ScriptableObject
{
	// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x3C2C50", Offset = "0x3C2C50", VA = "0x63C2C50")]
	public DataMod()
	{
	}

	// Token: 0x04000664 RID: 1636
	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0xC")]
	public List<DataMod.Sheet> sheets;

	// Token: 0x0200023B RID: 571
	[Token(Token = "0x20001B1")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x3C2CE4", Offset = "0x3C2CE4", VA = "0x63C2CE4")]
		public Sheet()
		{
		}

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0xC")]
		public List<DataMod.Param> list;
	}

	// Token: 0x0200023C RID: 572
	[Token(Token = "0x20001B2")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x3C2CDC", Offset = "0x3C2CDC", VA = "0x63C2CDC")]
		public Param()
		{
		}

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x14")]
		public string Target;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x18")]
		public bool Use;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x1C")]
		public float Base;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x20")]
		public float PerLv;
	}
}
