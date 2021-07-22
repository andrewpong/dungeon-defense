using System;
using Com.Google.Android.Gms.Common.Api;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x2000089")]
	public interface Stats
	{
		// Token: 0x0600066F RID: 1647
		[Token(Token = "0x6000615")]
		PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2);
	}
}
