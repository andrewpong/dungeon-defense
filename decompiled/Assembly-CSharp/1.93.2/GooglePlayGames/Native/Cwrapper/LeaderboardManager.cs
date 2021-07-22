using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000B4")]
	internal static class LeaderboardManager
	{
		// Token: 0x0600072D RID: 1837
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x952A28", Offset = "0x952A28", VA = "0x6952A28")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchAll(HandleRef self, Types.DataSource data_source, LeaderboardManager.FetchAllCallback callback, IntPtr callback_arg);

		// Token: 0x0600072E RID: 1838
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x952B28", Offset = "0x952B28", VA = "0x6952B28")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchScoreSummary(HandleRef self, Types.DataSource data_source, string leaderboard_id, Types.LeaderboardTimeSpan time_span, Types.LeaderboardCollection collection, LeaderboardManager.FetchScoreSummaryCallback callback, IntPtr callback_arg);

		// Token: 0x0600072F RID: 1839
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x952C60", Offset = "0x952C60", VA = "0x6952C60")]
		[PreserveSig]
		internal static extern IntPtr LeaderboardManager_ScorePageToken(HandleRef self, string leaderboard_id, Types.LeaderboardStart start, Types.LeaderboardTimeSpan time_span, Types.LeaderboardCollection collection);

		// Token: 0x06000730 RID: 1840
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x952D88", Offset = "0x952D88", VA = "0x6952D88")]
		[PreserveSig]
		internal static extern void LeaderboardManager_ShowAllUI(HandleRef self, LeaderboardManager.ShowAllUICallback callback, IntPtr callback_arg);

		// Token: 0x06000731 RID: 1841
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x952E88", Offset = "0x952E88", VA = "0x6952E88")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchScorePage(HandleRef self, Types.DataSource data_source, IntPtr token, uint max_results, LeaderboardManager.FetchScorePageCallback callback, IntPtr callback_arg);

		// Token: 0x06000732 RID: 1842
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x952F98", Offset = "0x952F98", VA = "0x6952F98")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchAllScoreSummaries(HandleRef self, Types.DataSource data_source, string leaderboard_id, LeaderboardManager.FetchAllScoreSummariesCallback callback, IntPtr callback_arg);

		// Token: 0x06000733 RID: 1843
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x9530C8", Offset = "0x9530C8", VA = "0x69530C8")]
		[PreserveSig]
		internal static extern void LeaderboardManager_ShowUI(HandleRef self, string leaderboard_id, Types.LeaderboardTimeSpan time_span, LeaderboardManager.ShowUICallback callback, IntPtr callback_arg);

		// Token: 0x06000734 RID: 1844
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x953220", Offset = "0x953220", VA = "0x6953220")]
		[PreserveSig]
		internal static extern void LeaderboardManager_Fetch(HandleRef self, Types.DataSource data_source, string leaderboard_id, LeaderboardManager.FetchCallback callback, IntPtr callback_arg);

		// Token: 0x06000735 RID: 1845
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x953378", Offset = "0x953378", VA = "0x6953378")]
		[PreserveSig]
		internal static extern void LeaderboardManager_SubmitScore(HandleRef self, string leaderboard_id, ulong score, string metadata);

		// Token: 0x06000736 RID: 1846
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x9534A8", Offset = "0x9534A8", VA = "0x69534A8")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchResponse_Dispose(HandleRef self);

		// Token: 0x06000737 RID: 1847
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x953598", Offset = "0x953598", VA = "0x6953598")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchResponse_GetStatus(HandleRef self);

		// Token: 0x06000738 RID: 1848
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x953688", Offset = "0x953688", VA = "0x6953688")]
		[PreserveSig]
		internal static extern IntPtr LeaderboardManager_FetchResponse_GetData(HandleRef self);

		// Token: 0x06000739 RID: 1849
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x953778", Offset = "0x953778", VA = "0x6953778")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchAllResponse_Dispose(HandleRef self);

		// Token: 0x0600073A RID: 1850
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x953868", Offset = "0x953868", VA = "0x6953868")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchAllResponse_GetStatus(HandleRef self);

		// Token: 0x0600073B RID: 1851
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x953958", Offset = "0x953958", VA = "0x6953958")]
		[PreserveSig]
		internal static extern UIntPtr LeaderboardManager_FetchAllResponse_GetData_Length(HandleRef self);

		// Token: 0x0600073C RID: 1852
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x953A50", Offset = "0x953A50", VA = "0x6953A50")]
		[PreserveSig]
		internal static extern IntPtr LeaderboardManager_FetchAllResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x0600073D RID: 1853
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x953B50", Offset = "0x953B50", VA = "0x6953B50")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchScorePageResponse_Dispose(HandleRef self);

		// Token: 0x0600073E RID: 1854
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x953C48", Offset = "0x953C48", VA = "0x6953C48")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchScorePageResponse_GetStatus(HandleRef self);

		// Token: 0x0600073F RID: 1855
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x953D40", Offset = "0x953D40", VA = "0x6953D40")]
		[PreserveSig]
		internal static extern IntPtr LeaderboardManager_FetchScorePageResponse_GetData(HandleRef self);

		// Token: 0x06000740 RID: 1856
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x953E38", Offset = "0x953E38", VA = "0x6953E38")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchScoreSummaryResponse_Dispose(HandleRef self);

		// Token: 0x06000741 RID: 1857
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x953F30", Offset = "0x953F30", VA = "0x6953F30")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchScoreSummaryResponse_GetStatus(HandleRef self);

		// Token: 0x06000742 RID: 1858
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x954028", Offset = "0x954028", VA = "0x6954028")]
		[PreserveSig]
		internal static extern IntPtr LeaderboardManager_FetchScoreSummaryResponse_GetData(HandleRef self);

		// Token: 0x06000743 RID: 1859
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x954120", Offset = "0x954120", VA = "0x6954120")]
		[PreserveSig]
		internal static extern void LeaderboardManager_FetchAllScoreSummariesResponse_Dispose(HandleRef self);

		// Token: 0x06000744 RID: 1860
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x954220", Offset = "0x954220", VA = "0x6954220")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchAllScoreSummariesResponse_GetStatus(HandleRef self);

		// Token: 0x06000745 RID: 1861
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x954320", Offset = "0x954320", VA = "0x6954320")]
		[PreserveSig]
		internal static extern UIntPtr LeaderboardManager_FetchAllScoreSummariesResponse_GetData_Length(HandleRef self);

		// Token: 0x06000746 RID: 1862
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x9543E8", Offset = "0x9543E8", VA = "0x69543E8")]
		[PreserveSig]
		internal static extern IntPtr LeaderboardManager_FetchAllScoreSummariesResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x06000748 RID: 1864
		[Token(Token = "0x20000B5")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x0600074C RID: 1868
		[Token(Token = "0x20000B6")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x06000750 RID: 1872
		[Token(Token = "0x20000B7")]
		internal delegate void FetchScorePageCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x06000754 RID: 1876
		[Token(Token = "0x20000B8")]
		internal delegate void FetchScoreSummaryCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000758 RID: 1880
		[Token(Token = "0x20000B9")]
		internal delegate void FetchAllScoreSummariesCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x0600075C RID: 1884
		[Token(Token = "0x20000BA")]
		internal delegate void ShowAllUICallback(CommonErrorStatus.UIStatus arg0, IntPtr arg1);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000760 RID: 1888
		[Token(Token = "0x20000BB")]
		internal delegate void ShowUICallback(CommonErrorStatus.UIStatus arg0, IntPtr arg1);
	}
}
