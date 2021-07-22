using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x200025C")]
	public class DungeonData
	{
		// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x28BC90", Offset = "0x28BC90", VA = "0x628BC90")]
		public DungeonData()
		{
		}

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000C87")]
		[FieldOffset(Offset = "0x8")]
		public DungeonType eID;

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000C88")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x14")]
		public string strIcon;

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x18")]
		public float fBase;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0x1C")]
		public float fGrow;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0x20")]
		public float fCost;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x24")]
		public float fCostGrow;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x28")]
		public float fCostAdd;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x2C")]
		public float fCostMul;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0x30")]
		public int nMax;
	}
}
