using System;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000A0")]
	internal static class CommonErrorStatus
	{
		// Token: 0x020000C3 RID: 195
		[Token(Token = "0x20000A1")]
		internal enum ResponseStatus
		{
			// Token: 0x0400032A RID: 810
			[Token(Token = "0x40002AA")]
			VALID = 1,
			// Token: 0x0400032B RID: 811
			[Token(Token = "0x40002AB")]
			VALID_BUT_STALE,
			// Token: 0x0400032C RID: 812
			[Token(Token = "0x40002AC")]
			ERROR_LICENSE_CHECK_FAILED = -1,
			// Token: 0x0400032D RID: 813
			[Token(Token = "0x40002AD")]
			ERROR_INTERNAL = -2,
			// Token: 0x0400032E RID: 814
			[Token(Token = "0x40002AE")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x0400032F RID: 815
			[Token(Token = "0x40002AF")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x04000330 RID: 816
			[Token(Token = "0x40002B0")]
			ERROR_TIMEOUT = -5
		}

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000A2")]
		internal enum FlushStatus
		{
			// Token: 0x04000332 RID: 818
			[Token(Token = "0x40002B2")]
			FLUSHED = 4,
			// Token: 0x04000333 RID: 819
			[Token(Token = "0x40002B3")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000334 RID: 820
			[Token(Token = "0x40002B4")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x04000335 RID: 821
			[Token(Token = "0x40002B5")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x04000336 RID: 822
			[Token(Token = "0x40002B6")]
			ERROR_TIMEOUT = -5
		}

		// Token: 0x020000C5 RID: 197
		[Token(Token = "0x20000A3")]
		internal enum AuthStatus
		{
			// Token: 0x04000338 RID: 824
			[Token(Token = "0x40002B8")]
			VALID = 1,
			// Token: 0x04000339 RID: 825
			[Token(Token = "0x40002B9")]
			ERROR_INTERNAL = -2,
			// Token: 0x0400033A RID: 826
			[Token(Token = "0x40002BA")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x0400033B RID: 827
			[Token(Token = "0x40002BB")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x0400033C RID: 828
			[Token(Token = "0x40002BC")]
			ERROR_TIMEOUT = -5
		}

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000A4")]
		internal enum UIStatus
		{
			// Token: 0x0400033E RID: 830
			[Token(Token = "0x40002BE")]
			VALID = 1,
			// Token: 0x0400033F RID: 831
			[Token(Token = "0x40002BF")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000340 RID: 832
			[Token(Token = "0x40002C0")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x04000341 RID: 833
			[Token(Token = "0x40002C1")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x04000342 RID: 834
			[Token(Token = "0x40002C2")]
			ERROR_TIMEOUT = -5,
			// Token: 0x04000343 RID: 835
			[Token(Token = "0x40002C3")]
			ERROR_CANCELED = -6,
			// Token: 0x04000344 RID: 836
			[Token(Token = "0x40002C4")]
			ERROR_UI_BUSY = -12,
			// Token: 0x04000345 RID: 837
			[Token(Token = "0x40002C5")]
			ERROR_LEFT_ROOM = -18
		}

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000A5")]
		internal enum MultiplayerStatus
		{
			// Token: 0x04000347 RID: 839
			[Token(Token = "0x40002C7")]
			VALID = 1,
			// Token: 0x04000348 RID: 840
			[Token(Token = "0x40002C8")]
			VALID_BUT_STALE,
			// Token: 0x04000349 RID: 841
			[Token(Token = "0x40002C9")]
			ERROR_INTERNAL = -2,
			// Token: 0x0400034A RID: 842
			[Token(Token = "0x40002CA")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x0400034B RID: 843
			[Token(Token = "0x40002CB")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x0400034C RID: 844
			[Token(Token = "0x40002CC")]
			ERROR_TIMEOUT = -5,
			// Token: 0x0400034D RID: 845
			[Token(Token = "0x40002CD")]
			ERROR_MATCH_ALREADY_REMATCHED = -7,
			// Token: 0x0400034E RID: 846
			[Token(Token = "0x40002CE")]
			ERROR_INACTIVE_MATCH = -8,
			// Token: 0x0400034F RID: 847
			[Token(Token = "0x40002CF")]
			ERROR_INVALID_RESULTS = -9,
			// Token: 0x04000350 RID: 848
			[Token(Token = "0x40002D0")]
			ERROR_INVALID_MATCH = -10,
			// Token: 0x04000351 RID: 849
			[Token(Token = "0x40002D1")]
			ERROR_MATCH_OUT_OF_DATE = -11,
			// Token: 0x04000352 RID: 850
			[Token(Token = "0x40002D2")]
			ERROR_REAL_TIME_ROOM_NOT_JOINED = -17
		}

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000A6")]
		internal enum QuestAcceptStatus
		{
			// Token: 0x04000354 RID: 852
			[Token(Token = "0x40002D4")]
			VALID = 1,
			// Token: 0x04000355 RID: 853
			[Token(Token = "0x40002D5")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000356 RID: 854
			[Token(Token = "0x40002D6")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x04000357 RID: 855
			[Token(Token = "0x40002D7")]
			ERROR_TIMEOUT = -5,
			// Token: 0x04000358 RID: 856
			[Token(Token = "0x40002D8")]
			ERROR_QUEST_NO_LONGER_AVAILABLE = -13,
			// Token: 0x04000359 RID: 857
			[Token(Token = "0x40002D9")]
			ERROR_QUEST_NOT_STARTED = -14
		}

		// Token: 0x020000C9 RID: 201
		[Token(Token = "0x20000A7")]
		internal enum QuestClaimMilestoneStatus
		{
			// Token: 0x0400035B RID: 859
			[Token(Token = "0x40002DB")]
			VALID = 1,
			// Token: 0x0400035C RID: 860
			[Token(Token = "0x40002DC")]
			ERROR_INTERNAL = -2,
			// Token: 0x0400035D RID: 861
			[Token(Token = "0x40002DD")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x0400035E RID: 862
			[Token(Token = "0x40002DE")]
			ERROR_TIMEOUT = -5,
			// Token: 0x0400035F RID: 863
			[Token(Token = "0x40002DF")]
			ERROR_MILESTONE_ALREADY_CLAIMED = -15,
			// Token: 0x04000360 RID: 864
			[Token(Token = "0x40002E0")]
			ERROR_MILESTONE_CLAIM_FAILED = -16
		}

		// Token: 0x020000CA RID: 202
		[Token(Token = "0x20000A8")]
		internal enum SnapshotOpenStatus
		{
			// Token: 0x04000362 RID: 866
			[Token(Token = "0x40002E2")]
			VALID = 1,
			// Token: 0x04000363 RID: 867
			[Token(Token = "0x40002E3")]
			VALID_WITH_CONFLICT = 3,
			// Token: 0x04000364 RID: 868
			[Token(Token = "0x40002E4")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000365 RID: 869
			[Token(Token = "0x40002E5")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x04000366 RID: 870
			[Token(Token = "0x40002E6")]
			ERROR_TIMEOUT = -5
		}
	}
}
