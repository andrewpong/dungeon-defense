using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x2000252")]
	[Serializable]
	public class PlayerMonsterData
	{
		// Token: 0x06001134 RID: 4404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x2938B4", Offset = "0x2938B4", VA = "0x62938B4")]
		public PlayerMonsterData()
		{
		}

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x8")]
		public ObscuredShort sID;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x10")]
		public ObscuredInt nLv;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x20")]
		public ObscuredInt nExp;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<SkillKey, ObscuredInt> dictSkill;

		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x38")]
		public ObscuredLong nEquip;

		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x58")]
		public ObscuredLong nAmulet;

		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x78")]
		public ObscuredFloat fActive;

		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x8C")]
		public byte byBatch;

		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x90")]
		public ObscuredLong nRing;

		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0xB0")]
		public ObscuredBool bAwaken;

		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0xBC")]
		public ObscuredBool bFocused;

		// Token: 0x04000DBE RID: 3518
		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0xC8")]
		public SkillKey eFocusedSkill;
	}
}
