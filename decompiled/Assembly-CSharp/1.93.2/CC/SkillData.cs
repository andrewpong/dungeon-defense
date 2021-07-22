using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002EE RID: 750
	[Token(Token = "0x200025A")]
	public class SkillData
	{
		// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x28BC88", Offset = "0x28BC88", VA = "0x628BC88")]
		public SkillData()
		{
		}

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000C76")]
		[FieldOffset(Offset = "0x8")]
		public short sID;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x14")]
		public string strSummary;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x18")]
		public string strIcon;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x1C")]
		public SkillKey eKey;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x20")]
		public SkillType eType;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x24")]
		public float fFactor;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x28")]
		public float fGrow;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x2C")]
		public float fFactor2;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0x30")]
		public float fGrow2;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0x34")]
		public float fGuage;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x38")]
		public int nMax;
	}
}
