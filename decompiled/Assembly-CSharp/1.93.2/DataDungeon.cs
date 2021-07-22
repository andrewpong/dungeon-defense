using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000231 RID: 561
[Token(Token = "0x20001A7")]
public class DataDungeon : ScriptableObject
{
	// Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x3C2818", Offset = "0x3C2818", VA = "0x63C2818")]
	public DataDungeon()
	{
	}

	// Token: 0x04000630 RID: 1584
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0xC")]
	public List<DataDungeon.Sheet> sheets;

	// Token: 0x02000232 RID: 562
	[Token(Token = "0x20001A8")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x3C28AC", Offset = "0x3C28AC", VA = "0x63C28AC")]
		public Sheet()
		{
		}

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0xC")]
		public List<DataDungeon.Param> list;
	}

	// Token: 0x02000233 RID: 563
	[Token(Token = "0x20001A9")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x3C28A4", Offset = "0x3C28A4", VA = "0x63C28A4")]
		public Param()
		{
		}

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x14")]
		public string Icon;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x18")]
		public float Base;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x1C")]
		public float Grow;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x20")]
		public int Max;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x24")]
		public float Cost;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x28")]
		public float CostGrow;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x2C")]
		public float CostMul;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x30")]
		public float CostAdd;
	}
}
