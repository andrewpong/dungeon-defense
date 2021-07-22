using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023D RID: 573
[Token(Token = "0x20001B3")]
public class DataMonster : ScriptableObject
{
	// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x3C2F20", Offset = "0x3C2F20", VA = "0x63C2F20")]
	public DataMonster()
	{
	}

	// Token: 0x0400066E RID: 1646
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0xC")]
	public List<DataMonster.Sheet> sheets;

	// Token: 0x0200023E RID: 574
	[Token(Token = "0x20001B4")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x3C2FB4", Offset = "0x3C2FB4", VA = "0x63C2FB4")]
		public Sheet()
		{
		}

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0xC")]
		public List<DataMonster.Param> list;
	}

	// Token: 0x0200023F RID: 575
	[Token(Token = "0x20001B5")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x3C2FAC", Offset = "0x3C2FAC", VA = "0x63C2FAC")]
		public Param()
		{
		}

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0xC")]
		public string Controller;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x10")]
		public string Controller2;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x14")]
		public string Sprite;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x18")]
		public string Sprite2;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x1C")]
		public string AwkRebirth;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x20")]
		public string Name;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x24")]
		public string JobName;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x28")]
		public string Desc;

		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x2C")]
		public int StartItem;

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x30")]
		public int NeedAcv;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x34")]
		public string NeedRbt;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x38")]
		public string AwkNeedSkill;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x3C")]
		public string StartSkill;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x40")]
		public string LearnSkill;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x44")]
		public string AwkLearnSkill;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x48")]
		public int PrmCost;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x4C")]
		public string PrmSkl1;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x50")]
		public float PrmFac1;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x54")]
		public float PrmDmg1;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x58")]
		public string PrmSkl2;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x5C")]
		public float PrmFac2;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x60")]
		public float PrmDmg2;
	}
}
