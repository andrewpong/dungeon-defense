using System;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000106")]
	internal static class Types
	{
		// Token: 0x02000129 RID: 297
		[Token(Token = "0x2000107")]
		internal enum DataSource
		{
			// Token: 0x040003A8 RID: 936
			[Token(Token = "0x4000328")]
			CACHE_OR_NETWORK = 1,
			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x4000329")]
			NETWORK_ONLY
		}

		// Token: 0x0200012A RID: 298
		[Token(Token = "0x2000108")]
		internal enum LogLevel
		{
			// Token: 0x040003AB RID: 939
			[Token(Token = "0x400032B")]
			VERBOSE = 1,
			// Token: 0x040003AC RID: 940
			[Token(Token = "0x400032C")]
			INFO,
			// Token: 0x040003AD RID: 941
			[Token(Token = "0x400032D")]
			WARNING,
			// Token: 0x040003AE RID: 942
			[Token(Token = "0x400032E")]
			ERROR
		}

		// Token: 0x0200012B RID: 299
		[Token(Token = "0x2000109")]
		internal enum AuthOperation
		{
			// Token: 0x040003B0 RID: 944
			[Token(Token = "0x4000330")]
			SIGN_IN = 1,
			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x4000331")]
			SIGN_OUT
		}

		// Token: 0x0200012C RID: 300
		[Token(Token = "0x200010A")]
		internal enum ImageResolution
		{
			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x4000333")]
			ICON = 1,
			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x4000334")]
			HI_RES
		}

		// Token: 0x0200012D RID: 301
		[Token(Token = "0x200010B")]
		internal enum AchievementType
		{
			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x4000336")]
			STANDARD = 1,
			// Token: 0x040003B7 RID: 951
			[Token(Token = "0x4000337")]
			INCREMENTAL
		}

		// Token: 0x0200012E RID: 302
		[Token(Token = "0x200010C")]
		internal enum AchievementState
		{
			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x4000339")]
			HIDDEN = 1,
			// Token: 0x040003BA RID: 954
			[Token(Token = "0x400033A")]
			REVEALED,
			// Token: 0x040003BB RID: 955
			[Token(Token = "0x400033B")]
			UNLOCKED
		}

		// Token: 0x0200012F RID: 303
		[Token(Token = "0x200010D")]
		internal enum EventVisibility
		{
			// Token: 0x040003BD RID: 957
			[Token(Token = "0x400033D")]
			HIDDEN = 1,
			// Token: 0x040003BE RID: 958
			[Token(Token = "0x400033E")]
			REVEALED
		}

		// Token: 0x02000130 RID: 304
		[Token(Token = "0x200010E")]
		internal enum LeaderboardOrder
		{
			// Token: 0x040003C0 RID: 960
			[Token(Token = "0x4000340")]
			LARGER_IS_BETTER = 1,
			// Token: 0x040003C1 RID: 961
			[Token(Token = "0x4000341")]
			SMALLER_IS_BETTER
		}

		// Token: 0x02000131 RID: 305
		[Token(Token = "0x200010F")]
		internal enum LeaderboardStart
		{
			// Token: 0x040003C3 RID: 963
			[Token(Token = "0x4000343")]
			TOP_SCORES = 1,
			// Token: 0x040003C4 RID: 964
			[Token(Token = "0x4000344")]
			PLAYER_CENTERED
		}

		// Token: 0x02000132 RID: 306
		[Token(Token = "0x2000110")]
		internal enum LeaderboardTimeSpan
		{
			// Token: 0x040003C6 RID: 966
			[Token(Token = "0x4000346")]
			DAILY = 1,
			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x4000347")]
			WEEKLY,
			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x4000348")]
			ALL_TIME
		}

		// Token: 0x02000133 RID: 307
		[Token(Token = "0x2000111")]
		internal enum LeaderboardCollection
		{
			// Token: 0x040003CA RID: 970
			[Token(Token = "0x400034A")]
			PUBLIC = 1,
			// Token: 0x040003CB RID: 971
			[Token(Token = "0x400034B")]
			SOCIAL
		}

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000112")]
		internal enum ParticipantStatus
		{
			// Token: 0x040003CD RID: 973
			[Token(Token = "0x400034D")]
			INVITED = 1,
			// Token: 0x040003CE RID: 974
			[Token(Token = "0x400034E")]
			JOINED,
			// Token: 0x040003CF RID: 975
			[Token(Token = "0x400034F")]
			DECLINED,
			// Token: 0x040003D0 RID: 976
			[Token(Token = "0x4000350")]
			LEFT,
			// Token: 0x040003D1 RID: 977
			[Token(Token = "0x4000351")]
			NOT_INVITED_YET,
			// Token: 0x040003D2 RID: 978
			[Token(Token = "0x4000352")]
			FINISHED,
			// Token: 0x040003D3 RID: 979
			[Token(Token = "0x4000353")]
			UNRESPONSIVE
		}

		// Token: 0x02000135 RID: 309
		[Token(Token = "0x2000113")]
		internal enum MatchResult
		{
			// Token: 0x040003D5 RID: 981
			[Token(Token = "0x4000355")]
			DISAGREED = 1,
			// Token: 0x040003D6 RID: 982
			[Token(Token = "0x4000356")]
			DISCONNECTED,
			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x4000357")]
			LOSS,
			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x4000358")]
			NONE,
			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x4000359")]
			TIE,
			// Token: 0x040003DA RID: 986
			[Token(Token = "0x400035A")]
			WIN
		}

		// Token: 0x02000136 RID: 310
		[Token(Token = "0x2000114")]
		internal enum MatchStatus
		{
			// Token: 0x040003DC RID: 988
			[Token(Token = "0x400035C")]
			INVITED = 1,
			// Token: 0x040003DD RID: 989
			[Token(Token = "0x400035D")]
			THEIR_TURN,
			// Token: 0x040003DE RID: 990
			[Token(Token = "0x400035E")]
			MY_TURN,
			// Token: 0x040003DF RID: 991
			[Token(Token = "0x400035F")]
			PENDING_COMPLETION,
			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x4000360")]
			COMPLETED,
			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x4000361")]
			CANCELED,
			// Token: 0x040003E2 RID: 994
			[Token(Token = "0x4000362")]
			EXPIRED
		}

		// Token: 0x02000137 RID: 311
		[Token(Token = "0x2000115")]
		internal enum MultiplayerEvent
		{
			// Token: 0x040003E4 RID: 996
			[Token(Token = "0x4000364")]
			UPDATED = 1,
			// Token: 0x040003E5 RID: 997
			[Token(Token = "0x4000365")]
			UPDATED_FROM_APP_LAUNCH,
			// Token: 0x040003E6 RID: 998
			[Token(Token = "0x4000366")]
			REMOVED
		}

		// Token: 0x02000138 RID: 312
		[Token(Token = "0x2000116")]
		internal enum MultiplayerInvitationType
		{
			// Token: 0x040003E8 RID: 1000
			[Token(Token = "0x4000368")]
			TURN_BASED = 1,
			// Token: 0x040003E9 RID: 1001
			[Token(Token = "0x4000369")]
			REAL_TIME
		}

		// Token: 0x02000139 RID: 313
		[Token(Token = "0x2000117")]
		internal enum RealTimeRoomStatus
		{
			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x400036B")]
			INVITING = 1,
			// Token: 0x040003EC RID: 1004
			[Token(Token = "0x400036C")]
			CONNECTING,
			// Token: 0x040003ED RID: 1005
			[Token(Token = "0x400036D")]
			AUTO_MATCHING,
			// Token: 0x040003EE RID: 1006
			[Token(Token = "0x400036E")]
			ACTIVE,
			// Token: 0x040003EF RID: 1007
			[Token(Token = "0x400036F")]
			DELETED
		}

		// Token: 0x0200013A RID: 314
		[Token(Token = "0x2000118")]
		internal enum SnapshotConflictPolicy
		{
			// Token: 0x040003F1 RID: 1009
			[Token(Token = "0x4000371")]
			MANUAL = 1,
			// Token: 0x040003F2 RID: 1010
			[Token(Token = "0x4000372")]
			LONGEST_PLAYTIME,
			// Token: 0x040003F3 RID: 1011
			[Token(Token = "0x4000373")]
			LAST_KNOWN_GOOD,
			// Token: 0x040003F4 RID: 1012
			[Token(Token = "0x4000374")]
			MOST_RECENTLY_MODIFIED
		}

		// Token: 0x0200013B RID: 315
		[Token(Token = "0x2000119")]
		internal enum VideoCaptureMode
		{
			// Token: 0x040003F6 RID: 1014
			[Token(Token = "0x4000376")]
			UNKNOWN = -1,
			// Token: 0x040003F7 RID: 1015
			[Token(Token = "0x4000377")]
			FILE,
			// Token: 0x040003F8 RID: 1016
			[Token(Token = "0x4000378")]
			STREAM
		}

		// Token: 0x0200013C RID: 316
		[Token(Token = "0x200011A")]
		internal enum VideoQualityLevel
		{
			// Token: 0x040003FA RID: 1018
			[Token(Token = "0x400037A")]
			UNKNOWN = -1,
			// Token: 0x040003FB RID: 1019
			[Token(Token = "0x400037B")]
			SD,
			// Token: 0x040003FC RID: 1020
			[Token(Token = "0x400037C")]
			HD,
			// Token: 0x040003FD RID: 1021
			[Token(Token = "0x400037D")]
			XHD,
			// Token: 0x040003FE RID: 1022
			[Token(Token = "0x400037E")]
			FULLHD
		}

		// Token: 0x0200013D RID: 317
		[Token(Token = "0x200011B")]
		internal enum VideoCaptureOverlayState
		{
			// Token: 0x04000400 RID: 1024
			[Token(Token = "0x4000380")]
			UNKNOWN = -1,
			// Token: 0x04000401 RID: 1025
			[Token(Token = "0x4000381")]
			SHOWN = 1,
			// Token: 0x04000402 RID: 1026
			[Token(Token = "0x4000382")]
			STARTED,
			// Token: 0x04000403 RID: 1027
			[Token(Token = "0x4000383")]
			STOPPED,
			// Token: 0x04000404 RID: 1028
			[Token(Token = "0x4000384")]
			DISMISSED
		}
	}
}
