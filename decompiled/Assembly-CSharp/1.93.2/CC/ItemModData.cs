using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x2000253")]
	[Serializable]
	public class ItemModData
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x293210", Offset = "0x293210", VA = "0x6293210")]
		public ItemModData()
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x17000146")]
		public float fFactor
		{
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x2933D0", Offset = "0x2933D0", VA = "0x62933D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000C16")]
		[FieldOffset(Offset = "0x8")]
		public ModType eMod;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0xC")]
		public ObscuredInt nModLevel;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x1C")]
		public ObscuredFloat fBonus;
	}
}
