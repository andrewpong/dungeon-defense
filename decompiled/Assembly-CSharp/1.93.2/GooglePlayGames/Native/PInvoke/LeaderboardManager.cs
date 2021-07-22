using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x200014D")]
	internal class LeaderboardManager
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x455880", Offset = "0x455880", VA = "0x6455880")]
		internal LeaderboardManager(GameServices services)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x17000109")]
		internal int LeaderboardMaxResults
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x457810", Offset = "0x457810", VA = "0x6457810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x457818", Offset = "0x457818", VA = "0x6457818")]
		internal void SubmitScore(string leaderboardId, long score, string metadata)
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x457C34", Offset = "0x457C34", VA = "0x6457C34")]
		internal void ShowAllUI(Action<CommonErrorStatus.UIStatus> callback)
		{
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x457D98", Offset = "0x457D98", VA = "0x6457D98")]
		internal void ShowUI(string leaderboardId, LeaderboardTimeSpan span, Action<CommonErrorStatus.UIStatus> callback)
		{
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x457F04", Offset = "0x457F04", VA = "0x6457F04")]
		public void LoadLeaderboardData(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, string playerId, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x457624", Offset = "0x457624", VA = "0x6457624")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185D04", Offset = "0x185D04")]
		private static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x45825C", Offset = "0x45825C", VA = "0x645825C")]
		internal void HandleFetch(ScorePageToken token, FetchResponse response, string selfPlayerId, int maxResults, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x4576C8", Offset = "0x4576C8", VA = "0x64576C8")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185D7C", Offset = "0x185D7C")]
		private static void InternalFetchSummaryCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x45886C", Offset = "0x45886C", VA = "0x645886C")]
		internal void HandleFetchScoreSummary(LeaderboardScoreData data, FetchScoreSummaryResponse response, string selfPlayerId, int maxResults, ScorePageToken token, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x458B94", Offset = "0x458B94", VA = "0x6458B94")]
		public void LoadScorePage(LeaderboardScoreData data, int maxResults, ScorePageToken token, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x45776C", Offset = "0x45776C", VA = "0x645776C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185DF4", Offset = "0x185DF4")]
		private static void InternalFetchScorePage(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x458F9C", Offset = "0x458F9C", VA = "0x6458F9C")]
		internal void HandleFetchScorePage(LeaderboardScoreData data, ScorePageToken token, FetchScorePageResponse rsp, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x8")]
		private readonly GameServices mServices;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FB0", Offset = "0x180FB0")]
		private static LeaderboardManager.ShowAllUICallback <>f__mg$cache0;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FC0", Offset = "0x180FC0")]
		private static LeaderboardManager.ShowUICallback <>f__mg$cache1;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FD0", Offset = "0x180FD0")]
		private static Func<IntPtr, FetchResponse> <>f__mg$cache2;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FE0", Offset = "0x180FE0")]
		private static LeaderboardManager.FetchCallback <>f__mg$cache3;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FF0", Offset = "0x180FF0")]
		private static Func<IntPtr, FetchScoreSummaryResponse> <>f__mg$cache4;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181000", Offset = "0x181000")]
		private static LeaderboardManager.FetchScoreSummaryCallback <>f__mg$cache5;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181010", Offset = "0x181010")]
		private static Func<IntPtr, FetchScorePageResponse> <>f__mg$cache6;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181020", Offset = "0x181020")]
		private static LeaderboardManager.FetchScorePageCallback <>f__mg$cache7;

		// Token: 0x020001CD RID: 461
		[Token(Token = "0x2000334")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FCB0", Offset = "0x17FCB0")]
		private sealed class <LoadLeaderboardData>c__AnonStorey0
		{
			// Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001576")]
			[Address(RVA = "0x458254", Offset = "0x458254", VA = "0x6458254")]
			public <LoadLeaderboardData>c__AnonStorey0()
			{
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001577")]
			[Address(RVA = "0x45967C", Offset = "0x45967C", VA = "0x645967C")]
			internal void <>m__0(FetchResponse rsp)
			{
			}

			// Token: 0x04000543 RID: 1347
			[Token(Token = "0x4001406")]
			[FieldOffset(Offset = "0x8")]
			internal ScorePageToken token;

			// Token: 0x04000544 RID: 1348
			[Token(Token = "0x4001407")]
			[FieldOffset(Offset = "0xC")]
			internal string playerId;

			// Token: 0x04000545 RID: 1349
			[Token(Token = "0x4001408")]
			[FieldOffset(Offset = "0x10")]
			internal int rowCount;

			// Token: 0x04000546 RID: 1350
			[Token(Token = "0x4001409")]
			[FieldOffset(Offset = "0x14")]
			internal Action<LeaderboardScoreData> callback;

			// Token: 0x04000547 RID: 1351
			[Token(Token = "0x400140A")]
			[FieldOffset(Offset = "0x18")]
			internal LeaderboardManager $this;
		}

		// Token: 0x020001CE RID: 462
		[Token(Token = "0x2000335")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FCC0", Offset = "0x17FCC0")]
		private sealed class <HandleFetch>c__AnonStorey1
		{
			// Token: 0x06000BEA RID: 3050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001578")]
			[Address(RVA = "0x458864", Offset = "0x458864", VA = "0x6458864")]
			public <HandleFetch>c__AnonStorey1()
			{
			}

			// Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001579")]
			[Address(RVA = "0x45962C", Offset = "0x45962C", VA = "0x645962C")]
			internal void <>m__0(FetchScoreSummaryResponse rsp)
			{
			}

			// Token: 0x04000548 RID: 1352
			[Token(Token = "0x400140B")]
			[FieldOffset(Offset = "0x8")]
			internal LeaderboardScoreData data;

			// Token: 0x04000549 RID: 1353
			[Token(Token = "0x400140C")]
			[FieldOffset(Offset = "0xC")]
			internal string selfPlayerId;

			// Token: 0x0400054A RID: 1354
			[Token(Token = "0x400140D")]
			[FieldOffset(Offset = "0x10")]
			internal int maxResults;

			// Token: 0x0400054B RID: 1355
			[Token(Token = "0x400140E")]
			[FieldOffset(Offset = "0x14")]
			internal ScorePageToken token;

			// Token: 0x0400054C RID: 1356
			[Token(Token = "0x400140F")]
			[FieldOffset(Offset = "0x18")]
			internal Action<LeaderboardScoreData> callback;

			// Token: 0x0400054D RID: 1357
			[Token(Token = "0x4001410")]
			[FieldOffset(Offset = "0x1C")]
			internal LeaderboardManager $this;
		}

		// Token: 0x020001CF RID: 463
		[Token(Token = "0x2000336")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FCD0", Offset = "0x17FCD0")]
		private sealed class <LoadScorePage>c__AnonStorey2
		{
			// Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600157A")]
			[Address(RVA = "0x458F94", Offset = "0x458F94", VA = "0x6458F94")]
			public <LoadScorePage>c__AnonStorey2()
			{
			}

			// Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600157B")]
			[Address(RVA = "0x4596CC", Offset = "0x4596CC", VA = "0x64596CC")]
			internal void <>m__0(FetchScorePageResponse rsp)
			{
			}

			// Token: 0x0400054E RID: 1358
			[Token(Token = "0x4001411")]
			[FieldOffset(Offset = "0x8")]
			internal LeaderboardScoreData data;

			// Token: 0x0400054F RID: 1359
			[Token(Token = "0x4001412")]
			[FieldOffset(Offset = "0xC")]
			internal ScorePageToken token;

			// Token: 0x04000550 RID: 1360
			[Token(Token = "0x4001413")]
			[FieldOffset(Offset = "0x10")]
			internal Action<LeaderboardScoreData> callback;

			// Token: 0x04000551 RID: 1361
			[Token(Token = "0x4001414")]
			[FieldOffset(Offset = "0x14")]
			internal LeaderboardManager $this;
		}
	}
}
