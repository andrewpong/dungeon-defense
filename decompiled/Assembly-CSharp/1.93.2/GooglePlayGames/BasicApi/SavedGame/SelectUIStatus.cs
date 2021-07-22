using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000061")]
	public enum SelectUIStatus
	{
		// Token: 0x04000279 RID: 633
		[Token(Token = "0x400022D")]
		SavedGameSelected = 1,
		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400022E")]
		UserClosedUI,
		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400022F")]
		InternalError = -1,
		// Token: 0x0400027C RID: 636
		[Token(Token = "0x4000230")]
		TimeoutError = -2,
		// Token: 0x0400027D RID: 637
		[Token(Token = "0x4000231")]
		AuthenticationError = -3,
		// Token: 0x0400027E RID: 638
		[Token(Token = "0x4000232")]
		BadInputError = -4
	}
}
