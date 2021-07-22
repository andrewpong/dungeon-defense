using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x2000267")]
	public class QuestData
	{
		// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x28BD5C", Offset = "0x28BD5C", VA = "0x628BD5C")]
		public QuestData()
		{
		}

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x8")]
		public QuestID eID;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0xC")]
		public string strDesc;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x10")]
		public int nMax;

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x14")]
		public int nReward;
	}
}
