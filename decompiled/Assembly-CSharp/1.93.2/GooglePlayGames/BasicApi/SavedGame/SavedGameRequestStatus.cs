using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000060")]
	public enum SavedGameRequestStatus
	{
		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000227")]
		Success = 1,
		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000228")]
		TimeoutError = -1,
		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000229")]
		InternalError = -2,
		// Token: 0x04000276 RID: 630
		[Token(Token = "0x400022A")]
		AuthenticationError = -3,
		// Token: 0x04000277 RID: 631
		[Token(Token = "0x400022B")]
		BadInputError = -4
	}
}
