using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000237 RID: 567
[Token(Token = "0x20001AD")]
public class DataEnemy : ScriptableObject
{
	// Token: 0x06000EA5 RID: 3749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x3C2AE8", Offset = "0x3C2AE8", VA = "0x63C2AE8")]
	public DataEnemy()
	{
	}

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0xC")]
	public List<DataEnemy.Sheet> sheets;

	// Token: 0x02000238 RID: 568
	[Token(Token = "0x20001AE")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EA6 RID: 3750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x3C2B7C", Offset = "0x3C2B7C", VA = "0x63C2B7C")]
		public Sheet()
		{
		}

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0xC")]
		public List<DataEnemy.Param> list;
	}

	// Token: 0x02000239 RID: 569
	[Token(Token = "0x20001AF")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x3C2B74", Offset = "0x3C2B74", VA = "0x63C2B74")]
		public Param()
		{
		}

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0xC")]
		public string Controller;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x10")]
		public string Armor;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x14")]
		public string Move;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x18")]
		public int Exp;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x1C")]
		public int Factor;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x20")]
		public float Power;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x24")]
		public float AttackRate;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x28")]
		public float SpeedMin;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x2C")]
		public float SpeedMax;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x30")]
		public int HP;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x34")]
		public float Range;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x38")]
		public int SpawnMin;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x3C")]
		public int SpawnMax;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x40")]
		public bool Use;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x41")]
		public bool BeBoss;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x42")]
		public bool OnlyBoss;
	}
}
