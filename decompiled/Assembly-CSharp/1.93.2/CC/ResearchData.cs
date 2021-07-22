using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x200025D")]
	public class ResearchData
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x28BD34", Offset = "0x28BD34", VA = "0x628BD34")]
		public ResearchData()
		{
		}

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x8")]
		public ResearchID eID;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000C94")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x14")]
		public string strIcon;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x18")]
		public float fFactor;

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x1C")]
		public int nCost;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x20")]
		public bool bRepeat;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x24")]
		public List<ResearchID> listPre;
	}
}
