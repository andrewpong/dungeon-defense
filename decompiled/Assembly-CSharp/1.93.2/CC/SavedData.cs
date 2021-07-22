using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x200026B")]
	[Serializable]
	public class SavedData
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x293B78", Offset = "0x293B78", VA = "0x6293B78")]
		public SavedData()
		{
		}

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x8")]
		public byte bySlot;

		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x10")]
		public long uRebirthID;

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x18")]
		public long uItem;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x20")]
		public ObscuredInt nDay;

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x30")]
		public ObscuredInt nGold;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x40")]
		public ObscuredInt nPerfect;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x50")]
		public ObscuredInt nMod;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x60")]
		public ObscuredLong[] nEquipWeapon;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x64")]
		public ObscuredFloat fDunCurHP;

		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x78")]
		public PlayerMonsterData[] arrPlayerMon;

		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x7C")]
		public PlayerMonsterData pHireMonster;

		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x80")]
		public List<PlayerItemData> listShopItem;

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x84")]
		public Dictionary<ObscuredLong, PlayerItemData> dictItem;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<DungeonType, ObscuredInt> dictDun;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x8C")]
		public string strSummary;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x90")]
		public ObscuredInt nDiff;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0xA0")]
		public ObscuredInt nEnchant;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0xB0")]
		public bool bBatched;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0xB1")]
		public bool bClear;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0xB4")]
		public List<ResearchID> listResearch;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0xB8")]
		public ResearchID eResearch;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0xBC")]
		public float fResearch;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0xC0")]
		public float fResearchProgress;

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0xC4")]
		public bool bPreResearch;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0xC5")]
		public bool bHireMonster;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0xC6")]
		public bool bAfterRebirth;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0xC7")]
		public bool bDeleted;

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0xC8")]
		public bool bChallengeTrial;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0xC9")]
		public bool bAfterAmulet;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0xCC")]
		public ObscuredInt nClearTrial;

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0xDC")]
		public int nLastTrialDiff;

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0xE0")]
		public bool bNewBalance;

		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0xE4")]
		public ObscuredInt nMaxEndless;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000D26")]
		[FieldOffset(Offset = "0xF4")]
		public bool bChallengeEndless;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0xF5")]
		public bool bAfterEndless;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0xF8")]
		public ObscuredLong nNewGold;

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x118")]
		public ObscuredFloat fAwakenCharge;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x12C")]
		public bool bAfterRelicChange;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000D2B")]
		[FieldOffset(Offset = "0x12D")]
		public bool bAfterDiffHpChange;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000D2C")]
		[FieldOffset(Offset = "0x130")]
		public ObscuredLong uSpecialEnchant;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x150")]
		public Dictionary<ResearchID, ObscuredInt> dictRepeatResearch;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x154")]
		public bool bAfterMonHpIncrease;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x155")]
		public bool bProgressResearch;

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x156")]
		public bool bNamelessCriFix;
	}
}
