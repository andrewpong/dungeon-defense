using System;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x20000F4")]
	internal static class Status
	{
		// Token: 0x02000117 RID: 279
		[Token(Token = "0x20000F5")]
		internal enum ResponseStatus
		{
			// Token: 0x04000373 RID: 883
			[Token(Token = "0x40002F3")]
			VALID = 1,
			// Token: 0x04000374 RID: 884
			[Token(Token = "0x40002F4")]
			VALID_BUT_STALE,
			// Token: 0x04000375 RID: 885
			[Token(Token = "0x40002F5")]
			ERROR_LICENSE_CHECK_FAILED = -1,
			// Token: 0x04000376 RID: 886
			[Token(Token = "0x40002F6")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000377 RID: 887
			[Token(Token = "0x40002F7")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x04000378 RID: 888
			[Token(Token = "0x40002F8")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x04000379 RID: 889
			[Token(Token = "0x40002F9")]
			ERROR_TIMEOUT = -5
		}

		// Token: 0x02000118 RID: 280
		[Token(Token = "0x20000F6")]
		internal enum FlushStatus
		{
			// Token: 0x0400037B RID: 891
			[Token(Token = "0x40002FB")]
			FLUSHED = 4,
			// Token: 0x0400037C RID: 892
			[Token(Token = "0x40002FC")]
			ERROR_INTERNAL = -2,
			// Token: 0x0400037D RID: 893
			[Token(Token = "0x40002FD")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x40002FE")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x40002FF")]
			ERROR_TIMEOUT = -5
		}

		// Token: 0x02000119 RID: 281
		[Token(Token = "0x20000F7")]
		internal enum AuthStatus
		{
			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000301")]
			VALID = 1,
			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000302")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000303")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000304")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000305")]
			ERROR_TIMEOUT = -5
		}

		// Token: 0x0200011A RID: 282
		[Token(Token = "0x20000F8")]
		internal enum UIStatus
		{
			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000307")]
			VALID = 1,
			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000308")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000309")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400030A")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400030B")]
			ERROR_TIMEOUT = -5,
			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400030C")]
			ERROR_CANCELED = -6,
			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400030D")]
			ERROR_UI_BUSY = -12,
			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400030E")]
			ERROR_LEFT_ROOM = -18
		}

		// Token: 0x0200011B RID: 283
		[Token(Token = "0x20000F9")]
		internal enum MultiplayerStatus
		{
			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000310")]
			VALID = 1,
			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000311")]
			VALID_BUT_STALE,
			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000312")]
			ERROR_INTERNAL = -2,
			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000313")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000314")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000315")]
			ERROR_TIMEOUT = -5,
			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000316")]
			ERROR_MATCH_ALREADY_REMATCHED = -7,
			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000317")]
			ERROR_INACTIVE_MATCH = -8,
			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000318")]
			ERROR_INVALID_RESULTS = -9,
			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000319")]
			ERROR_INVALID_MATCH = -10,
			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400031A")]
			ERROR_MATCH_OUT_OF_DATE = -11,
			// Token: 0x0400039B RID: 923
			[Token(Token = "0x400031B")]
			ERROR_REAL_TIME_ROOM_NOT_JOINED = -17
		}

		// Token: 0x0200011C RID: 284
		[Token(Token = "0x20000FA")]
		internal enum CommonErrorStatus
		{
			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400031D")]
			ERROR_INTERNAL = -2,
			// Token: 0x0400039E RID: 926
			[Token(Token = "0x400031E")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400031F")]
			ERROR_TIMEOUT = -5
		}

		// Token: 0x0200011D RID: 285
		[Token(Token = "0x20000FB")]
		internal enum SnapshotOpenStatus
		{
			// Token: 0x040003A1 RID: 929
			[Token(Token = "0x4000321")]
			VALID = 1,
			// Token: 0x040003A2 RID: 930
			[Token(Token = "0x4000322")]
			VALID_WITH_CONFLICT = 3,
			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x4000323")]
			ERROR_INTERNAL = -2,
			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x4000324")]
			ERROR_NOT_AUTHORIZED = -3,
			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x4000325")]
			ERROR_TIMEOUT = -5
		}
	}
}
