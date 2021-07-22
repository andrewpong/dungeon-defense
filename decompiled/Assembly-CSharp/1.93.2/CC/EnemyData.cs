using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x2000257")]
	public class EnemyData
	{
		// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x28BC78", Offset = "0x28BC78", VA = "0x628BC78")]
		public EnemyData()
		{
		}

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x8")]
		public short sID;

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0xC")]
		public string strController;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x10")]
		public ArmorType eArmor;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x14")]
		public MoveType eMove;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x18")]
		public bool bRange;

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x1C")]
		public float fPow;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x20")]
		public float fAsp;

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x24")]
		public float fMinSpd;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x28")]
		public float fMaxSpd;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x2C")]
		public float fMaxHP;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x30")]
		public int nFactor;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x34")]
		public float fRange;

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x38")]
		public int nMinSpawn;

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x3C")]
		public int nMaxSpawn;

		// Token: 0x04000DF4 RID: 3572
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x40")]
		public bool bCanBoss;

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x41")]
		public bool bOnlyBoss;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x42")]
		public bool bUse;
	}
}
