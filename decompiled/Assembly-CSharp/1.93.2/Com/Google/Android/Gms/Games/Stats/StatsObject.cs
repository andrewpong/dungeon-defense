using System;
using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x200008B")]
	public class StatsObject : JavaObjWrapper, Stats
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x3C21C4", Offset = "0x3C21C4", VA = "0x63C21C4")]
		public StatsObject(IntPtr ptr)
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x3C21CC", Offset = "0x3C21CC", VA = "0x63C21CC", Slot = "5")]
		public PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2)
		{
			return null;
		}

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x40002A8")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats";
	}
}
