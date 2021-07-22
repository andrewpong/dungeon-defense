using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x2000255")]
	[Serializable]
	public class PlayerAccData
	{
		// Token: 0x06001138 RID: 4408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x293580", Offset = "0x293580", VA = "0x6293580")]
		public PlayerAccData()
		{
		}

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x8")]
		public ObscuredLong UID;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x28")]
		public ObscuredShort sID;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x30")]
		public ObscuredInt nLv;

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x40")]
		public ObscuredBool bProtected;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x4C")]
		public ObscuredInt nSpecial;
	}
}
