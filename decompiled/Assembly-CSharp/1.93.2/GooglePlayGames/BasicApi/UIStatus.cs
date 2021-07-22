using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x2000033")]
	public enum UIStatus
	{
		// Token: 0x040001BB RID: 443
		[Token(Token = "0x400016F")]
		Valid = 1,
		// Token: 0x040001BC RID: 444
		[Token(Token = "0x4000170")]
		InternalError = -2,
		// Token: 0x040001BD RID: 445
		[Token(Token = "0x4000171")]
		NotAuthorized = -3,
		// Token: 0x040001BE RID: 446
		[Token(Token = "0x4000172")]
		VersionUpdateRequired = -4,
		// Token: 0x040001BF RID: 447
		[Token(Token = "0x4000173")]
		Timeout = -5,
		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x4000174")]
		UserClosedUI = -6,
		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x4000175")]
		UiBusy = -12,
		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x4000176")]
		LeftRoom = -18
	}
}
