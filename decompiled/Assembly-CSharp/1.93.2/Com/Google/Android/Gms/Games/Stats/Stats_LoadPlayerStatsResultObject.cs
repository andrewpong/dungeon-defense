using System;
using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x2000086")]
	public class Stats_LoadPlayerStatsResultObject : JavaObjWrapper, Stats_LoadPlayerStatsResult, Result
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x3C2390", Offset = "0x3C2390", VA = "0x63C2390")]
		public Stats_LoadPlayerStatsResultObject(IntPtr ptr)
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x3C2398", Offset = "0x3C2398", VA = "0x63C2398", Slot = "5")]
		public PlayerStats getPlayerStats()
		{
			return null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x3C2470", Offset = "0x3C2470", VA = "0x63C2470", Slot = "6")]
		public Status getStatus()
		{
			return null;
		}

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x40002A6")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats$LoadPlayerStatsResult";
	}
}
