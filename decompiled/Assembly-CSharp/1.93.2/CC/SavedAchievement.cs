using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x200026D")]
	[Serializable]
	public class SavedAchievement
	{
		// Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x292AC0", Offset = "0x292AC0", VA = "0x6292AC0")]
		public SavedAchievement()
		{
		}

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x8")]
		public ObscuredInt nEnchant;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000D5A")]
		[FieldOffset(Offset = "0x18")]
		public List<AchievementType> listAcv;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000D5B")]
		[FieldOffset(Offset = "0x1C")]
		public ObscuredInt nAwaken;
	}
}
