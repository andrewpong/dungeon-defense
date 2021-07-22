using System;
using Com.Google.Android.Gms.Common.Api;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x200008A")]
	public interface Stats_LoadPlayerStatsResult : Result
	{
		// Token: 0x06000670 RID: 1648
		[Token(Token = "0x6000616")]
		PlayerStats getPlayerStats();
	}
}
