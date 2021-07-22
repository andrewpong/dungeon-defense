using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x2000268")]
	public class ElementalData
	{
		// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x28BD64", Offset = "0x28BD64", VA = "0x628BD64")]
		public ElementalData()
		{
		}

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x8")]
		public ElementalID eID;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x14")]
		public string strIcon;

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x18")]
		public ElementalID eNeed;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x1C")]
		public Element eElm;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x20")]
		public int nDunLv;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x24")]
		public int nNeed;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x28")]
		public int nMaxLv;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x2C")]
		public float fBase1;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x30")]
		public float fGrow1;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x34")]
		public float fBase2;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x38")]
		public float fGrow2;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x3C")]
		public float fBase3;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x40")]
		public float fGrow3;
	}
}
