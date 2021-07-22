using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024C RID: 588
[Token(Token = "0x20001C2")]
public class DataResearch : ScriptableObject
{
	// Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x3C34C0", Offset = "0x3C34C0", VA = "0x63C34C0")]
	public DataResearch()
	{
	}

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0xC")]
	public List<DataResearch.Sheet> sheets;

	// Token: 0x0200024D RID: 589
	[Token(Token = "0x20001C3")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x3C3554", Offset = "0x3C3554", VA = "0x63C3554")]
		public Sheet()
		{
		}

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0xC")]
		public List<DataResearch.Param> list;
	}

	// Token: 0x0200024E RID: 590
	[Token(Token = "0x20001C4")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EBC RID: 3772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x3C354C", Offset = "0x3C354C", VA = "0x63C354C")]
		public Param()
		{
		}

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x14")]
		public string Icon;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x18")]
		public string PreLearn;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x1C")]
		public int Cost;

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x20")]
		public float Factor;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x24")]
		public bool Repeat;
	}
}
