using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000100")]
	internal static class TurnBasedMultiplayerManager
	{
		// Token: 0x06000903 RID: 2307
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x6D4748", Offset = "0x6D4748", VA = "0x66D4748")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_ShowPlayerSelectUI(HandleRef self, uint minimum_players, uint maximum_players, bool allow_automatch, TurnBasedMultiplayerManager.PlayerSelectUICallback callback, IntPtr callback_arg);

		// Token: 0x06000904 RID: 2308
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x6D4868", Offset = "0x6D4868", VA = "0x66D4868")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_CancelMatch(HandleRef self, IntPtr match, TurnBasedMultiplayerManager.MultiplayerStatusCallback callback, IntPtr callback_arg);

		// Token: 0x06000905 RID: 2309
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x6D4978", Offset = "0x6D4978", VA = "0x66D4978")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_DismissMatch(HandleRef self, IntPtr match);

		// Token: 0x06000906 RID: 2310
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x6D4A70", Offset = "0x6D4A70", VA = "0x66D4A70")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_ShowMatchInboxUI(HandleRef self, TurnBasedMultiplayerManager.MatchInboxUICallback callback, IntPtr callback_arg);

		// Token: 0x06000907 RID: 2311
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x6D4B80", Offset = "0x6D4B80", VA = "0x66D4B80")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_SynchronizeData(HandleRef self);

		// Token: 0x06000908 RID: 2312
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x6D4C70", Offset = "0x6D4C70", VA = "0x66D4C70")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_Rematch(HandleRef self, IntPtr match, TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg);

		// Token: 0x06000909 RID: 2313
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x6D4D78", Offset = "0x6D4D78", VA = "0x66D4D78")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_DismissInvitation(HandleRef self, IntPtr invitation);

		// Token: 0x0600090A RID: 2314
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x6D4E70", Offset = "0x6D4E70", VA = "0x66D4E70")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_FetchMatch(HandleRef self, string match_id, TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg);

		// Token: 0x0600090B RID: 2315
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x6D4F98", Offset = "0x6D4F98", VA = "0x66D4F98")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_DeclineInvitation(HandleRef self, IntPtr invitation);

		// Token: 0x0600090C RID: 2316
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x6D5090", Offset = "0x6D5090", VA = "0x66D5090")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_FinishMatchDuringMyTurn(HandleRef self, IntPtr match, byte[] match_data, UIntPtr match_data_size, IntPtr results, TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg);

		// Token: 0x0600090D RID: 2317
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x6D51C0", Offset = "0x6D51C0", VA = "0x66D51C0")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_FetchMatches(HandleRef self, TurnBasedMultiplayerManager.TurnBasedMatchesCallback callback, IntPtr callback_arg);

		// Token: 0x0600090E RID: 2318
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x6D52C8", Offset = "0x6D52C8", VA = "0x66D52C8")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_CreateTurnBasedMatch(HandleRef self, IntPtr config, TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg);

		// Token: 0x0600090F RID: 2319
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x6D53E0", Offset = "0x6D53E0", VA = "0x66D53E0")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_AcceptInvitation(HandleRef self, IntPtr invitation, TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg);

		// Token: 0x06000910 RID: 2320
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x6D54F8", Offset = "0x6D54F8", VA = "0x66D54F8")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_TakeMyTurn(HandleRef self, IntPtr match, byte[] match_data, UIntPtr match_data_size, IntPtr results, IntPtr next_participant, TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg);

		// Token: 0x06000911 RID: 2321
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x6D5628", Offset = "0x6D5628", VA = "0x66D5628")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_ConfirmPendingCompletion(HandleRef self, IntPtr match, TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg);

		// Token: 0x06000912 RID: 2322
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x6D5748", Offset = "0x6D5748", VA = "0x66D5748")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_LeaveMatchDuringMyTurn(HandleRef self, IntPtr match, IntPtr next_participant, TurnBasedMultiplayerManager.MultiplayerStatusCallback callback, IntPtr callback_arg);

		// Token: 0x06000913 RID: 2323
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x6D5868", Offset = "0x6D5868", VA = "0x66D5868")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_LeaveMatchDuringTheirTurn(HandleRef self, IntPtr match, TurnBasedMultiplayerManager.MultiplayerStatusCallback callback, IntPtr callback_arg);

		// Token: 0x06000914 RID: 2324
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x6D5988", Offset = "0x6D5988", VA = "0x66D5988")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_TurnBasedMatchResponse_Dispose(HandleRef self);

		// Token: 0x06000915 RID: 2325
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x6D5A88", Offset = "0x6D5A88", VA = "0x66D5A88")]
		[PreserveSig]
		internal static extern CommonErrorStatus.MultiplayerStatus TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetStatus(HandleRef self);

		// Token: 0x06000916 RID: 2326
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x6D5B88", Offset = "0x6D5B88", VA = "0x66D5B88")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetMatch(HandleRef self);

		// Token: 0x06000917 RID: 2327
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x6D5C88", Offset = "0x6D5C88", VA = "0x66D5C88")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_TurnBasedMatchesResponse_Dispose(HandleRef self);

		// Token: 0x06000918 RID: 2328
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x6D5D88", Offset = "0x6D5D88", VA = "0x66D5D88")]
		[PreserveSig]
		internal static extern CommonErrorStatus.MultiplayerStatus TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetStatus(HandleRef self);

		// Token: 0x06000919 RID: 2329
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x6D5E88", Offset = "0x6D5E88", VA = "0x66D5E88")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_Length(HandleRef self);

		// Token: 0x0600091A RID: 2330
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x6D5F50", Offset = "0x6D5F50", VA = "0x66D5F50")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x0600091B RID: 2331
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x6D6020", Offset = "0x6D6020", VA = "0x66D6020")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_Length(HandleRef self);

		// Token: 0x0600091C RID: 2332
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x6D60E8", Offset = "0x6D60E8", VA = "0x66D60E8")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x0600091D RID: 2333
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x6D61B8", Offset = "0x6D61B8", VA = "0x66D61B8")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_Length(HandleRef self);

		// Token: 0x0600091E RID: 2334
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x6D6280", Offset = "0x6D6280", VA = "0x66D6280")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x0600091F RID: 2335
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x6D6350", Offset = "0x6D6350", VA = "0x66D6350")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_Length(HandleRef self);

		// Token: 0x06000920 RID: 2336
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x6D6418", Offset = "0x6D6418", VA = "0x66D6418")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x06000921 RID: 2337
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x6D64E8", Offset = "0x6D64E8", VA = "0x66D64E8")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_MatchInboxUIResponse_Dispose(HandleRef self);

		// Token: 0x06000922 RID: 2338
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x6D65E8", Offset = "0x6D65E8", VA = "0x66D65E8")]
		[PreserveSig]
		internal static extern CommonErrorStatus.UIStatus TurnBasedMultiplayerManager_MatchInboxUIResponse_GetStatus(HandleRef self);

		// Token: 0x06000923 RID: 2339
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x6D66E8", Offset = "0x6D66E8", VA = "0x66D66E8")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMultiplayerManager_MatchInboxUIResponse_GetMatch(HandleRef self);

		// Token: 0x06000924 RID: 2340
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x6D67E8", Offset = "0x6D67E8", VA = "0x66D67E8")]
		[PreserveSig]
		internal static extern void TurnBasedMultiplayerManager_PlayerSelectUIResponse_Dispose(HandleRef self);

		// Token: 0x06000925 RID: 2341
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x6D68E8", Offset = "0x6D68E8", VA = "0x66D68E8")]
		[PreserveSig]
		internal static extern CommonErrorStatus.UIStatus TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetStatus(HandleRef self);

		// Token: 0x06000926 RID: 2342
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x6D69E8", Offset = "0x6D69E8", VA = "0x66D69E8")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_Length(HandleRef self);

		// Token: 0x06000927 RID: 2343
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x6D6AB0", Offset = "0x6D6AB0", VA = "0x66D6AB0")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_GetElement(HandleRef self, UIntPtr index, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000928 RID: 2344
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x6D6B98", Offset = "0x6D6B98", VA = "0x66D6B98")]
		[PreserveSig]
		internal static extern uint TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMinimumAutomatchingPlayers(HandleRef self);

		// Token: 0x06000929 RID: 2345
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x6D6C60", Offset = "0x6D6C60", VA = "0x66D6C60")]
		[PreserveSig]
		internal static extern uint TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMaximumAutomatchingPlayers(HandleRef self);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x0600092B RID: 2347
		[Token(Token = "0x2000101")]
		internal delegate void TurnBasedMatchCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x0600092F RID: 2351
		[Token(Token = "0x2000102")]
		internal delegate void MultiplayerStatusCallback(CommonErrorStatus.MultiplayerStatus arg0, IntPtr arg1);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000933 RID: 2355
		[Token(Token = "0x2000103")]
		internal delegate void TurnBasedMatchesCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000937 RID: 2359
		[Token(Token = "0x2000104")]
		internal delegate void MatchInboxUICallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x0600093B RID: 2363
		[Token(Token = "0x2000105")]
		internal delegate void PlayerSelectUICallback(IntPtr arg0, IntPtr arg1);
	}
}
