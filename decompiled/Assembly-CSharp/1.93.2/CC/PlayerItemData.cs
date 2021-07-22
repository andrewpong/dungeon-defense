using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x2000254")]
	[Serializable]
	public class PlayerItemData
	{
		// Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x2927B0", Offset = "0x2927B0", VA = "0x62927B0")]
		public PlayerItemData()
		{
		}

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x8")]
		public ObscuredLong UID;

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x28")]
		public ObscuredShort sID;

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x30")]
		public ObscuredInt nLv;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x40")]
		public ObscuredFloat fPower;

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x54")]
		public ObscuredByte byGrade;

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x58")]
		public ObscuredInt nMod;

		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x68")]
		public ItemModData[] arrMod;

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x6C")]
		public ObscuredBool bProtected;
	}
}
