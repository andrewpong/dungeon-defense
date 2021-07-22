using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x2000259")]
	public class ItemData
	{
		// Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x28BC80", Offset = "0x28BC80", VA = "0x628BC80")]
		public ItemData()
		{
		}

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x8")]
		public short sID;

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x10")]
		public string strSprite;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x14")]
		public string strBullet;

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x18")]
		public ItemType eItem;

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x1C")]
		public TrailType eTrail;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x20")]
		public WeaponType eWeapon;

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x24")]
		public SkillKey eMastery;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x28")]
		public int nDropMin;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x2C")]
		public int nDropMax;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x30")]
		public float fDmg;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x34")]
		public float fRate;

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x38")]
		public float fReload;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0x3C")]
		public float fvsArmor;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000C6E")]
		[FieldOffset(Offset = "0x40")]
		public float fvsMagic;

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000C6F")]
		[FieldOffset(Offset = "0x44")]
		public float fAcc;

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000C70")]
		[FieldOffset(Offset = "0x48")]
		public float fSpd;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000C71")]
		[FieldOffset(Offset = "0x4C")]
		public float fRange;

		// Token: 0x04000E1B RID: 3611
		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0x50")]
		public int nSpread;

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0x54")]
		public int nAmmo;

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x58")]
		public int nPen;

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x5C")]
		public bool bSpin;
	}
}
