using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002F5 RID: 757
	[Token(Token = "0x2000261")]
	public class RebirthData
	{
		// Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x28BD3C", Offset = "0x28BD3C", VA = "0x628BD3C")]
		public RebirthData()
		{
		}

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x8")]
		public RebirthID eID;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0xC")]
		public string strDesc;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x10")]
		public bool bOnly;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x11")]
		public bool bLock;

		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x14")]
		public CurrencyType eCurrency;

		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x18")]
		public float fBase;

		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x1C")]
		public float fGrow;

		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x20")]
		public float fFactorial;

		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x24")]
		public int nMax;

		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x28")]
		public int nCost;

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x2C")]
		public int nCostAdd;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x30")]
		public int nCostGrow;
	}
}
