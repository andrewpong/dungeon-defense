using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x02000302 RID: 770
	[Token(Token = "0x200026E")]
	[Serializable]
	public class SavedRebirth
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x292BBC", Offset = "0x292BBC", VA = "0x6292BBC")]
		public SavedRebirth()
		{
		}

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000D5C")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<RebirthID, ObscuredInt> dictRebirth;

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000D5D")]
		[FieldOffset(Offset = "0xC")]
		public List<ShopID> listPurchase;

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000D5E")]
		[FieldOffset(Offset = "0x10")]
		public ObscuredInt nStone;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000D5F")]
		[FieldOffset(Offset = "0x20")]
		public bool bAttention;

		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000D60")]
		[FieldOffset(Offset = "0x24")]
		public ObscuredInt nRebirth;

		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000D61")]
		[FieldOffset(Offset = "0x38")]
		public ObscuredLong uRebirthID;

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x58")]
		public ObscuredBool bRebirthInit;

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x64")]
		public ObscuredBool bBefore1_5;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x70")]
		public List<ObscuredLong> listRebirthID;

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x78")]
		public ObscuredLong uAccUID;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x98")]
		public ObscuredInt nMedal;

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0xA8")]
		public ObscuredBool bPurchaseReward;

		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0xB4")]
		public Dictionary<ObscuredLong, PlayerAccData> dictAcc;

		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<ObscuredLong, ObscuredInt> dictTrialClear;

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0xBC")]
		public List<ObscuredShort> listAchievementAccReward;

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000D6B")]
		[FieldOffset(Offset = "0xC0")]
		public ObscuredBool bBadWarning;

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0xCC")]
		public ObscuredInt nRuby;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0xDC")]
		public bool bAttentionRuby;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0xE0")]
		public List<QuestID> listMission;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0xE4")]
		public ObscuredInt nHell;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0xF4")]
		public bool bAttentionHell;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0xF8")]
		public Dictionary<ObscuredInt, List<ObscuredInt>> dictRebirthHistory;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0xFC")]
		public Dictionary<ObscuredInt, Dictionary<ObscuredInt, ObscuredInt>> dictHellQuest;

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x100")]
		public bool bAdjustHellStone;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x101")]
		public bool bFixAppleHellStoneBug;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x104")]
		public Dictionary<ObscuredInt, ObscuredLong> dictElementalExp;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x108")]
		public Dictionary<ElementalID, ObscuredInt> dictElementalTrait;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x10C")]
		public ObscuredInt nEquippedElemental;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x11C")]
		public ObscuredBool bVIP;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x128")]
		public ObscuredInt nInitHellStone;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x138")]
		public Dictionary<ObscuredShort, ObscuredInt> dictUnitPromote;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x13C")]
		public ObscuredInt nInitElementalTrait;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x150")]
		public ObscuredLong nNewMedal;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x170")]
		public ObscuredLong nNewStone;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x190")]
		public Dictionary<ObscuredShort, Dictionary<MonTraitID, ObscuredInt>> dictMonTrait;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0x194")]
		public Dictionary<ObscuredShort, ObscuredLong> dictMonRebirthExp;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x198")]
		public ObscuredInt nRebirthBonus;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0x1A8")]
		public ObscuredBool bSaveErrorReward;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x1B4")]
		public ObscuredInt nInitMonsterTrait;
	}
}
