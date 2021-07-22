using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x2000256")]
	public class MonsterData
	{
		// Token: 0x06001139 RID: 4409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x28BC70", Offset = "0x28BC70", VA = "0x628BC70")]
		public MonsterData()
		{
		}

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x8")]
		public short sID;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x14")]
		public string strClass;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x18")]
		public string strController;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x1C")]
		public string strControllerAwk;

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x20")]
		public string strSprite;

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x24")]
		public string strSpriteAwk;

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x28")]
		public RebirthID eAwaken;

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x2C")]
		public short sStartItem;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x30")]
		public int nNeedAcv;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x34")]
		public RebirthID eNeedRebirth;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x38")]
		public List<SkillKey> listSkill;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x3C")]
		public List<SkillKey> listLearnSkill;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x40")]
		public List<SkillKey> listNeedSkill;

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x44")]
		public List<SkillKey> listAwakenLearnSkill;

		// Token: 0x04000DDF RID: 3551
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x48")]
		public int nPromoteMul;

		// Token: 0x04000DE0 RID: 3552
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x4C")]
		public SkillKey ePromoteSkillMain;

		// Token: 0x04000DE1 RID: 3553
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x50")]
		public SkillKey ePromoteSkillSub;

		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x54")]
		public float fPromoteMainFac;

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x58")]
		public float fPromoteMainDmg;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x5C")]
		public float fPromoteSubFac;

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x60")]
		public float fPromoteSubDmg;
	}
}
