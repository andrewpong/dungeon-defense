using System;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x200026A")]
	[Serializable]
	public class CloudSavedData
	{
		// Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x292A0C", Offset = "0x292A0C", VA = "0x6292A0C")]
		public CloudSavedData()
		{
		}

		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x8")]
		public SavedData[] savedData;

		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0xC")]
		public SavedAchievement achievement;

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x10")]
		public SavedRebirth rebirth;
	}
}
