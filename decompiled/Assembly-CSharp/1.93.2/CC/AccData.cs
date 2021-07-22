using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002FA RID: 762
	[Token(Token = "0x2000266")]
	public class AccData
	{
		// Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x28BD7C", Offset = "0x28BD7C", VA = "0x628BD7C")]
		public AccData()
		{
		}

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x8")]
		public short sID;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x10")]
		public string strSprite;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0x14")]
		public ItemType eType;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000CD4")]
		[FieldOffset(Offset = "0x18")]
		public short sOnly;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000CD5")]
		[FieldOffset(Offset = "0x1C")]
		public AccDropType eDrop;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000CD6")]
		[FieldOffset(Offset = "0x20")]
		public AchievementType eAchieve;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000CD7")]
		[FieldOffset(Offset = "0x24")]
		public bool bSell;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000CD8")]
		[FieldOffset(Offset = "0x28")]
		public int nPrice;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000CD9")]
		[FieldOffset(Offset = "0x2C")]
		public int nGrade;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x30")]
		public ModType eStat1;

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x34")]
		public float fStat1;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000CDC")]
		[FieldOffset(Offset = "0x38")]
		public float fGrow1;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000CDD")]
		[FieldOffset(Offset = "0x3C")]
		public ModType eStat2;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x40")]
		public float fStat2;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x44")]
		public float fGrow2;

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x48")]
		public ModType eStat3;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x4C")]
		public float fStat3;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x50")]
		public float fGrow3;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x54")]
		public SkillKey eSpecial;
	}
}
