using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002EC RID: 748
	[Token(Token = "0x2000258")]
	public class BattleItemData : PlayerItemData
	{
		// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x2927AC", Offset = "0x2927AC", VA = "0x62927AC")]
		public BattleItemData()
		{
		}

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x78")]
		public float fDPS;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x7C")]
		public float fDmg;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x80")]
		public float fRate;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x84")]
		public float fReload;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x88")]
		public float fvsArmor;

		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x8C")]
		public float fvsMagic;

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x90")]
		public float fAcc;

		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x94")]
		public float fSpd;

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x98")]
		public float fRange;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x9C")]
		public float fCool;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0xA0")]
		public float fCri;

		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0xA4")]
		public float fCriDmg;

		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0xA8")]
		public int nSpread;

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0xAC")]
		public int nAmmo;

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0xB0")]
		public int nPen;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0xB4")]
		public int nMastery;

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0xB8")]
		public WeaponType eWeapon;

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0xBC")]
		public SkillKey eMastery;
	}
}
