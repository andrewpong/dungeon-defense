using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000252 RID: 594
[Token(Token = "0x20001C8")]
public class DataShop : ScriptableObject
{
	// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x3C3790", Offset = "0x3C3790", VA = "0x63C3790")]
	public DataShop()
	{
	}

	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0xC")]
	public List<DataShop.Sheet> sheets;

	// Token: 0x02000253 RID: 595
	[Token(Token = "0x20001C9")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x3C3824", Offset = "0x3C3824", VA = "0x63C3824")]
		public Sheet()
		{
		}

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0xC")]
		public List<DataShop.Param> list;
	}

	// Token: 0x02000254 RID: 596
	[Token(Token = "0x20001CA")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x3C381C", Offset = "0x3C381C", VA = "0x63C381C")]
		public Param()
		{
		}

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x14")]
		public bool Only;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x18")]
		public int Bonus;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x1C")]
		public float StoneBonus;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x20")]
		public float RubyBonus;
	}
}
