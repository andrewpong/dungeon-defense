using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000234 RID: 564
[Token(Token = "0x20001AA")]
public class DataElemental : ScriptableObject
{
	// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x3C2980", Offset = "0x3C2980", VA = "0x63C2980")]
	public DataElemental()
	{
	}

	// Token: 0x0400063E RID: 1598
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0xC")]
	public List<DataElemental.Sheet> sheets;

	// Token: 0x02000235 RID: 565
	[Token(Token = "0x20001AB")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x3C2A14", Offset = "0x3C2A14", VA = "0x63C2A14")]
		public Sheet()
		{
		}

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0xC")]
		public List<DataElemental.Param> list;
	}

	// Token: 0x02000236 RID: 566
	[Token(Token = "0x20001AC")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x3C2A0C", Offset = "0x3C2A0C", VA = "0x63C2A0C")]
		public Param()
		{
		}

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x14")]
		public string Icon;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x18")]
		public string Elemental;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x1C")]
		public string PreNeed;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x20")]
		public int DunLv;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x24")]
		public int Need;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x28")]
		public int MaxLv;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x2C")]
		public float Base;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x30")]
		public float Grow;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x34")]
		public float Base2;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x38")]
		public float Grow2;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x3C")]
		public float Base3;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x40")]
		public float Grow3;
	}
}
