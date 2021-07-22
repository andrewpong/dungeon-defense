using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x2000262")]
	public class ShopData
	{
		// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x28BD44", Offset = "0x28BD44", VA = "0x628BD44")]
		public ShopData()
		{
		}

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x8")]
		public ShopID eID;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x14")]
		public bool bOnly;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x18")]
		public int nBonus;

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x1C")]
		public float fStoneBonus;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x20")]
		public float fRubyBonus;
	}
}
