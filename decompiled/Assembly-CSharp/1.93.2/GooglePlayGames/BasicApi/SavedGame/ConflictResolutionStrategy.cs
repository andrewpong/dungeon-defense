using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x200005F")]
	public enum ConflictResolutionStrategy
	{
		// Token: 0x0400026C RID: 620
		[Token(Token = "0x4000220")]
		UseLongestPlaytime,
		// Token: 0x0400026D RID: 621
		[Token(Token = "0x4000221")]
		UseOriginal,
		// Token: 0x0400026E RID: 622
		[Token(Token = "0x4000222")]
		UseUnmerged,
		// Token: 0x0400026F RID: 623
		[Token(Token = "0x4000223")]
		UseManual,
		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000224")]
		UseLastKnownGood,
		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000225")]
		UseMostRecentlySaved
	}
}
