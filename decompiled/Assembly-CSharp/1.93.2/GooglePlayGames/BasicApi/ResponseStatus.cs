using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000032")]
	public enum ResponseStatus
	{
		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x4000167")]
		Success = 1,
		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x4000168")]
		SuccessWithStale,
		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x4000169")]
		LicenseCheckFailed = -1,
		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x400016A")]
		InternalError = -2,
		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x400016B")]
		NotAuthorized = -3,
		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x400016C")]
		VersionUpdateRequired = -4,
		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x400016D")]
		Timeout = -5
	}
}
