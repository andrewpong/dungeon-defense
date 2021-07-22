using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x2000265")]
	public class TrialData
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x28BD6C", Offset = "0x28BD6C", VA = "0x628BD6C")]
		public TrialData()
		{
		}

		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x8")]
		public int nFloor;

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0xC")]
		public MutateType eID;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x10")]
		public bool bDropRing;

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x14")]
		public int nDay;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x18")]
		public float fDropRate;

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0x1C")]
		public int nDropMin;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0x20")]
		public int nDropMax;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x24")]
		public Dictionary<int, int> dictMedal;
	}
}
