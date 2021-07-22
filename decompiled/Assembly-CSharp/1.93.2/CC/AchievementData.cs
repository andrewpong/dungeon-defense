using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x2000260")]
	public class AchievementData
	{
		// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x28BD2C", Offset = "0x28BD2C", VA = "0x628BD2C")]
		public AchievementData()
		{
		}

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x8")]
		public AchievementType eID;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0x14")]
		public AcvRewardType eReward;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x18")]
		public int nReward;
	}
}
