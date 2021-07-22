using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022B RID: 555
[Token(Token = "0x20001A1")]
public class DataAccessory : ScriptableObject
{
	// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D47")]
	[Address(RVA = "0x3C2548", Offset = "0x3C2548", VA = "0x63C2548")]
	public DataAccessory()
	{
	}

	// Token: 0x04000611 RID: 1553
	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0xC")]
	public List<DataAccessory.Sheet> sheets;

	// Token: 0x0200022C RID: 556
	[Token(Token = "0x20001A2")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x3C25DC", Offset = "0x3C25DC", VA = "0x63C25DC")]
		public Sheet()
		{
		}

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0xC")]
		public List<DataAccessory.Param> list;
	}

	// Token: 0x0200022D RID: 557
	[Token(Token = "0x20001A3")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000E9B RID: 3739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x3C25D4", Offset = "0x3C25D4", VA = "0x63C25D4")]
		public Param()
		{
		}

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x10")]
		public string Sprite;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x14")]
		public string Type;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x18")]
		public int Only;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x1C")]
		public string DropType;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x20")]
		public string Achieve;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x24")]
		public bool Sell;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x28")]
		public int Price;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x2C")]
		public int Grade;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x30")]
		public string StatType1;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x34")]
		public float StatFac1;

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x38")]
		public float StatGrow1;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x3C")]
		public string StatType2;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x40")]
		public float StatFac2;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x44")]
		public float StatGrow2;

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x48")]
		public string StatType3;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x4C")]
		public float StatFac3;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x50")]
		public float StatGrow3;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x54")]
		public string SpecialSkill;
	}
}
