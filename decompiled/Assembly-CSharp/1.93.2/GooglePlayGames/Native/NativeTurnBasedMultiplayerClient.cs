using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x200013A")]
	public class NativeTurnBasedMultiplayerClient : ITurnBasedMultiplayerClient
	{
		// Token: 0x06000AEA RID: 2794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x449B9C", Offset = "0x449B9C", VA = "0x6449B9C")]
		internal NativeTurnBasedMultiplayerClient(NativeClient nativeClient, TurnBasedManager manager)
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x449BC4", Offset = "0x449BC4", VA = "0x6449BC4", Slot = "4")]
		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x449BF0", Offset = "0x449BF0", VA = "0x6449BF0", Slot = "5")]
		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x44A188", Offset = "0x44A188", VA = "0x644A188", Slot = "6")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x44A284", Offset = "0x44A284", VA = "0x644A284", Slot = "7")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x44A438", Offset = "0x44A438", VA = "0x644A438", Slot = "8")]
		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x44A52C", Offset = "0x44A52C", VA = "0x644A52C", Slot = "9")]
		public void GetAllMatches(Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback)
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x44A638", Offset = "0x44A638", VA = "0x644A638", Slot = "10")]
		public void GetMatch(string matchId, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x44A0A4", Offset = "0x44A0A4", VA = "0x644A0A4")]
		private Action<TurnBasedManager.TurnBasedMatchResponse> BridgeMatchToUserCallback(Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> userCallback)
		{
			return null;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x44A780", Offset = "0x44A780", VA = "0x644A780", Slot = "11")]
		public void AcceptFromInbox(Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x44A900", Offset = "0x44A900", VA = "0x644A900", Slot = "12")]
		public void AcceptInvitation(string invitationId, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x44AA9C", Offset = "0x44AA9C", VA = "0x644AA9C")]
		private void FindInvitationWithId(string invitationId, Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x44ABAC", Offset = "0x44ABAC", VA = "0x644ABAC", Slot = "13")]
		public void RegisterMatchDelegate(MatchDelegate del)
		{
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x44ACF8", Offset = "0x44ACF8", VA = "0x644ACF8")]
		internal void HandleMatchEvent(Types.MultiplayerEvent eventType, string matchId, NativeTurnBasedMatch match)
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x44B03C", Offset = "0x44B03C", VA = "0x644B03C")]
		[DebuggerHidden]
		private IEnumerator WaitForLogin(Action method)
		{
			return null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x44B168", Offset = "0x44B168", VA = "0x644B168", Slot = "14")]
		public void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x44B4B8", Offset = "0x44B4B8", VA = "0x644B4B8")]
		private void FindEqualVersionMatch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> onFailure, Action<NativeTurnBasedMatch> onVersionMatch)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x44B368", Offset = "0x44B368", VA = "0x644B368")]
		private void FindEqualVersionMatchWithParticipant(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string participantId, Action<bool> onFailure, Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, NativeTurnBasedMatch> onFoundParticipantAndMatch)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x44B620", Offset = "0x44B620", VA = "0x644B620", Slot = "15")]
		public int GetMaxMatchDataSize()
		{
			return 0;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x44B6A8", Offset = "0x44B6A8", VA = "0x644B6A8", Slot = "16")]
		public void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x44B868", Offset = "0x44B868", VA = "0x644B868")]
		private static Types.MatchResult ResultToMatchResult(MatchOutcome.ParticipantResult result)
		{
			return (Types.MatchResult)0;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x44B98C", Offset = "0x44B98C", VA = "0x644B98C", Slot = "17")]
		public void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
		{
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x44BB1C", Offset = "0x44BB1C", VA = "0x644BB1C", Slot = "18")]
		public void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
		{
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x44BCAC", Offset = "0x44BCAC", VA = "0x644BCAC", Slot = "19")]
		public void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, Action<bool> callback)
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x44BE44", Offset = "0x44BE44", VA = "0x644BE44", Slot = "20")]
		public void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
		{
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x44BFD4", Offset = "0x44BFD4", VA = "0x644BFD4", Slot = "21")]
		public void Dismiss(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x44C120", Offset = "0x44C120", VA = "0x644C120", Slot = "22")]
		public void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x44C2E0", Offset = "0x44C2E0", VA = "0x644C2E0", Slot = "23")]
		public void DeclineInvitation(string invitationId)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x44C384", Offset = "0x44C384", VA = "0x644C384")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18578C", Offset = "0x18578C")]
		private void <DeclineInvitation>m__0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
		{
		}

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x8")]
		private readonly TurnBasedManager mTurnBasedManager;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0xC")]
		private readonly NativeClient mNativeClient;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x10")]
		private Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;

		// Token: 0x02000199 RID: 409
		[Token(Token = "0x2000313")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FAC0", Offset = "0x17FAC0")]
		private sealed class <CreateQuickMatch>c__AnonStorey1
		{
			// Token: 0x06000B07 RID: 2823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x44A09C", Offset = "0x44A09C", VA = "0x644A09C")]
			public <CreateQuickMatch>c__AnonStorey1()
			{
			}

			// Token: 0x06000B08 RID: 2824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001528")]
			[Address(RVA = "0x44CE88", Offset = "0x44CE88", VA = "0x644CE88")]
			internal void <>m__0(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
			{
			}

			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40013BE")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
		}

		// Token: 0x0200019A RID: 410
		[Token(Token = "0x2000314")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FAD0", Offset = "0x17FAD0")]
		private sealed class <CreateWithInvitationScreen>c__AnonStorey2
		{
			// Token: 0x06000B09 RID: 2825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001529")]
			[Address(RVA = "0x44A27C", Offset = "0x44A27C", VA = "0x644A27C")]
			public <CreateWithInvitationScreen>c__AnonStorey2()
			{
			}

			// Token: 0x06000B0A RID: 2826 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152A")]
			[Address(RVA = "0x44CF18", Offset = "0x44CF18", VA = "0x644CF18")]
			internal void <>m__0(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
			{
			}

			// Token: 0x040004DA RID: 1242
			[Token(Token = "0x40013BF")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
		}

		// Token: 0x0200019B RID: 411
		[Token(Token = "0x2000315")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FAE0", Offset = "0x17FAE0")]
		private sealed class <CreateWithInvitationScreen>c__AnonStorey3
		{
			// Token: 0x06000B0B RID: 2827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152B")]
			[Address(RVA = "0x44A430", Offset = "0x44A430", VA = "0x644A430")]
			public <CreateWithInvitationScreen>c__AnonStorey3()
			{
			}

			// Token: 0x06000B0C RID: 2828 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152C")]
			[Address(RVA = "0x44CFA8", Offset = "0x44CFA8", VA = "0x644CFA8")]
			internal void <>m__0(PlayerSelectUIResponse result)
			{
			}

			// Token: 0x040004DB RID: 1243
			[Token(Token = "0x40013C0")]
			[FieldOffset(Offset = "0x8")]
			internal Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			// Token: 0x040004DC RID: 1244
			[Token(Token = "0x40013C1")]
			[FieldOffset(Offset = "0xC")]
			internal uint variant;

			// Token: 0x040004DD RID: 1245
			[Token(Token = "0x40013C2")]
			[FieldOffset(Offset = "0x10")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x0200019C RID: 412
		[Token(Token = "0x2000316")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FAF0", Offset = "0x17FAF0")]
		private sealed class <GetAllInvitations>c__AnonStorey4
		{
			// Token: 0x06000B0D RID: 2829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152D")]
			[Address(RVA = "0x44A524", Offset = "0x44A524", VA = "0x644A524")]
			public <GetAllInvitations>c__AnonStorey4()
			{
			}

			// Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152E")]
			[Address(RVA = "0x44E84C", Offset = "0x44E84C", VA = "0x644E84C")]
			internal void <>m__0(TurnBasedManager.TurnBasedMatchesResponse allMatches)
			{
			}

			// Token: 0x040004DE RID: 1246
			[Token(Token = "0x40013C3")]
			[FieldOffset(Offset = "0x8")]
			internal Action<Invitation[]> callback;
		}

		// Token: 0x0200019D RID: 413
		[Token(Token = "0x2000317")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB00", Offset = "0x17FB00")]
		private sealed class <GetAllMatches>c__AnonStorey5
		{
			// Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152F")]
			[Address(RVA = "0x44A630", Offset = "0x44A630", VA = "0x644A630")]
			public <GetAllMatches>c__AnonStorey5()
			{
			}

			// Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001530")]
			[Address(RVA = "0x44EC4C", Offset = "0x44EC4C", VA = "0x644EC4C")]
			internal void <>m__0(TurnBasedManager.TurnBasedMatchesResponse allMatches)
			{
			}

			// Token: 0x040004DF RID: 1247
			[Token(Token = "0x40013C4")]
			[FieldOffset(Offset = "0x8")]
			internal Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback;

			// Token: 0x040004E0 RID: 1248
			[Token(Token = "0x40013C5")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x0200019E RID: 414
		[Token(Token = "0x2000318")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB10", Offset = "0x17FB10")]
		private sealed class <GetMatch>c__AnonStorey6
		{
			// Token: 0x06000B11 RID: 2833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001531")]
			[Address(RVA = "0x44A770", Offset = "0x44A770", VA = "0x644A770")]
			public <GetMatch>c__AnonStorey6()
			{
			}

			// Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001532")]
			[Address(RVA = "0x44F8E0", Offset = "0x44F8E0", VA = "0x644F8E0")]
			internal void <>m__0(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}

			// Token: 0x040004E1 RID: 1249
			[Token(Token = "0x40013C6")]
			[FieldOffset(Offset = "0x8")]
			internal string matchId;

			// Token: 0x040004E2 RID: 1250
			[Token(Token = "0x40013C7")]
			[FieldOffset(Offset = "0xC")]
			internal Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			// Token: 0x040004E3 RID: 1251
			[Token(Token = "0x40013C8")]
			[FieldOffset(Offset = "0x10")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x0200019F RID: 415
		[Token(Token = "0x2000319")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB20", Offset = "0x17FB20")]
		private sealed class <BridgeMatchToUserCallback>c__AnonStorey7
		{
			// Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001533")]
			[Address(RVA = "0x44A778", Offset = "0x44A778", VA = "0x644A778")]
			public <BridgeMatchToUserCallback>c__AnonStorey7()
			{
			}

			// Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001534")]
			[Address(RVA = "0x44CA18", Offset = "0x44CA18", VA = "0x644CA18")]
			internal void <>m__0(TurnBasedManager.TurnBasedMatchResponse callbackResult)
			{
			}

			// Token: 0x040004E4 RID: 1252
			[Token(Token = "0x40013C9")]
			[FieldOffset(Offset = "0x8")]
			internal Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> userCallback;

			// Token: 0x040004E5 RID: 1253
			[Token(Token = "0x40013CA")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001A0 RID: 416
		[Token(Token = "0x200031A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB30", Offset = "0x17FB30")]
		private sealed class <AcceptFromInbox>c__AnonStorey8
		{
			// Token: 0x06000B15 RID: 2837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001535")]
			[Address(RVA = "0x44A8F8", Offset = "0x44A8F8", VA = "0x644A8F8")]
			public <AcceptFromInbox>c__AnonStorey8()
			{
			}

			// Token: 0x06000B16 RID: 2838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001536")]
			[Address(RVA = "0x44C3C0", Offset = "0x44C3C0", VA = "0x644C3C0")]
			internal void <>m__0(TurnBasedManager.MatchInboxUIResponse callbackResult)
			{
			}

			// Token: 0x040004E6 RID: 1254
			[Token(Token = "0x40013CB")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			// Token: 0x040004E7 RID: 1255
			[Token(Token = "0x40013CC")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001A1 RID: 417
		[Token(Token = "0x200031B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB40", Offset = "0x17FB40")]
		private sealed class <AcceptInvitation>c__AnonStorey9
		{
			// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001537")]
			[Address(RVA = "0x44AA94", Offset = "0x44AA94", VA = "0x644AA94")]
			public <AcceptInvitation>c__AnonStorey9()
			{
			}

			// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001538")]
			[Address(RVA = "0x44C658", Offset = "0x44C658", VA = "0x644C658")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
			{
			}

			// Token: 0x06000B19 RID: 2841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001539")]
			[Address(RVA = "0x44C818", Offset = "0x44C818", VA = "0x644C818")]
			internal void <>m__1(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
			{
			}

			// Token: 0x040004E8 RID: 1256
			[Token(Token = "0x40013CD")]
			[FieldOffset(Offset = "0x8")]
			internal string invitationId;

			// Token: 0x040004E9 RID: 1257
			[Token(Token = "0x40013CE")]
			[FieldOffset(Offset = "0xC")]
			internal Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			// Token: 0x040004EA RID: 1258
			[Token(Token = "0x40013CF")]
			[FieldOffset(Offset = "0x10")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001A2 RID: 418
		[Token(Token = "0x200031C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB50", Offset = "0x17FB50")]
		private sealed class <FindInvitationWithId>c__AnonStoreyA
		{
			// Token: 0x06000B1A RID: 2842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153A")]
			[Address(RVA = "0x44ABA4", Offset = "0x44ABA4", VA = "0x644ABA4")]
			public <FindInvitationWithId>c__AnonStoreyA()
			{
			}

			// Token: 0x06000B1B RID: 2843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153B")]
			[Address(RVA = "0x44DD40", Offset = "0x44DD40", VA = "0x644DD40")]
			internal void <>m__0(TurnBasedManager.TurnBasedMatchesResponse allMatches)
			{
			}

			// Token: 0x040004EB RID: 1259
			[Token(Token = "0x40013D0")]
			[FieldOffset(Offset = "0x8")]
			internal Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback;

			// Token: 0x040004EC RID: 1260
			[Token(Token = "0x40013D1")]
			[FieldOffset(Offset = "0xC")]
			internal string invitationId;
		}

		// Token: 0x020001A3 RID: 419
		[Token(Token = "0x200031D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB60", Offset = "0x17FB60")]
		private sealed class <RegisterMatchDelegate>c__AnonStoreyB
		{
			// Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153C")]
			[Address(RVA = "0x44ACF0", Offset = "0x44ACF0", VA = "0x644ACF0")]
			public <RegisterMatchDelegate>c__AnonStoreyB()
			{
			}

			// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153D")]
			[Address(RVA = "0x4500A8", Offset = "0x4500A8", VA = "0x64500A8")]
			internal void <>m__0(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool autoLaunch)
			{
			}

			// Token: 0x040004ED RID: 1261
			[Token(Token = "0x40013D2")]
			[FieldOffset(Offset = "0x8")]
			internal MatchDelegate del;
		}

		// Token: 0x020001A4 RID: 420
		[Token(Token = "0x200031E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB70", Offset = "0x17FB70")]
		private sealed class <HandleMatchEvent>c__AnonStoreyC
		{
			// Token: 0x06000B1E RID: 2846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153E")]
			[Address(RVA = "0x44AF58", Offset = "0x44AF58", VA = "0x644AF58")]
			public <HandleMatchEvent>c__AnonStoreyC()
			{
			}

			// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x44FB7C", Offset = "0x44FB7C", VA = "0x644FB7C")]
			internal void <>m__0()
			{
			}

			// Token: 0x040004EE RID: 1262
			[Token(Token = "0x40013D3")]
			[FieldOffset(Offset = "0x8")]
			internal Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> currentDelegate;

			// Token: 0x040004EF RID: 1263
			[Token(Token = "0x40013D4")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMatch match;

			// Token: 0x040004F0 RID: 1264
			[Token(Token = "0x40013D5")]
			[FieldOffset(Offset = "0x10")]
			internal bool shouldAutolaunch;

			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40013D6")]
			[FieldOffset(Offset = "0x14")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001A5 RID: 421
		[Token(Token = "0x200031F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB80", Offset = "0x17FB80")]
		private sealed class <WaitForLogin>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001540")]
			[Address(RVA = "0x44B160", Offset = "0x44B160", VA = "0x644B160")]
			[DebuggerHidden]
			public <WaitForLogin>c__Iterator0()
			{
			}

			// Token: 0x06000B21 RID: 2849 RVA: 0x00005490 File Offset: 0x00003690
			[Token(Token = "0x6001541")]
			[Address(RVA = "0x450580", Offset = "0x450580", VA = "0x6450580", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B1")]
			private object Current
			{
				[Token(Token = "0x6001542")]
				[Address(RVA = "0x4506C8", Offset = "0x4506C8", VA = "0x64506C8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B2")]
			private object Current
			{
				[Token(Token = "0x6001543")]
				[Address(RVA = "0x4506D0", Offset = "0x4506D0", VA = "0x64506D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000B24 RID: 2852 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001544")]
			[Address(RVA = "0x4506D8", Offset = "0x4506D8", VA = "0x64506D8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000B25 RID: 2853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001545")]
			[Address(RVA = "0x4506EC", Offset = "0x4506EC", VA = "0x64506EC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040004F2 RID: 1266
			[Token(Token = "0x40013D7")]
			[FieldOffset(Offset = "0x8")]
			internal Action method;

			// Token: 0x040004F3 RID: 1267
			[Token(Token = "0x40013D8")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;

			// Token: 0x040004F4 RID: 1268
			[Token(Token = "0x40013D9")]
			[FieldOffset(Offset = "0x10")]
			internal object $current;

			// Token: 0x040004F5 RID: 1269
			[Token(Token = "0x40013DA")]
			[FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			// Token: 0x040004F6 RID: 1270
			[Token(Token = "0x40013DB")]
			[FieldOffset(Offset = "0x18")]
			internal int $PC;
		}

		// Token: 0x020001A6 RID: 422
		[Token(Token = "0x2000320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FB90", Offset = "0x17FB90")]
		private sealed class <TakeTurn>c__AnonStoreyD
		{
			// Token: 0x06000B26 RID: 2854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001546")]
			[Address(RVA = "0x44B360", Offset = "0x44B360", VA = "0x644B360")]
			public <TakeTurn>c__AnonStoreyD()
			{
			}

			// Token: 0x06000B27 RID: 2855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001547")]
			[Address(RVA = "0x4502EC", Offset = "0x4502EC", VA = "0x64502EC")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001548")]
			[Address(RVA = "0x4503D8", Offset = "0x4503D8", VA = "0x64503D8")]
			internal void <>m__1(TurnBasedManager.TurnBasedMatchResponse result)
			{
			}

			// Token: 0x040004F7 RID: 1271
			[Token(Token = "0x40013DC")]
			[FieldOffset(Offset = "0x8")]
			internal byte[] data;

			// Token: 0x040004F8 RID: 1272
			[Token(Token = "0x40013DD")]
			[FieldOffset(Offset = "0xC")]
			internal Action<bool> callback;

			// Token: 0x040004F9 RID: 1273
			[Token(Token = "0x40013DE")]
			[FieldOffset(Offset = "0x10")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001A7 RID: 423
		[Token(Token = "0x2000321")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FBA0", Offset = "0x17FBA0")]
		private sealed class <FindEqualVersionMatch>c__AnonStoreyE
		{
			// Token: 0x06000B29 RID: 2857 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001549")]
			[Address(RVA = "0x44B610", Offset = "0x44B610", VA = "0x644B610")]
			public <FindEqualVersionMatch>c__AnonStoreyE()
			{
			}

			// Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154A")]
			[Address(RVA = "0x44D488", Offset = "0x44D488", VA = "0x644D488")]
			internal void <>m__0(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}

			// Token: 0x040004FA RID: 1274
			[Token(Token = "0x40013DF")]
			[FieldOffset(Offset = "0x8")]
			internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

			// Token: 0x040004FB RID: 1275
			[Token(Token = "0x40013E0")]
			[FieldOffset(Offset = "0xC")]
			internal Action<bool> onFailure;

			// Token: 0x040004FC RID: 1276
			[Token(Token = "0x40013E1")]
			[FieldOffset(Offset = "0x10")]
			internal Action<NativeTurnBasedMatch> onVersionMatch;
		}

		// Token: 0x020001A8 RID: 424
		[Token(Token = "0x2000322")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FBB0", Offset = "0x17FBB0")]
		private sealed class <FindEqualVersionMatchWithParticipant>c__AnonStoreyF
		{
			// Token: 0x06000B2B RID: 2859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x44B618", Offset = "0x44B618", VA = "0x644B618")]
			public <FindEqualVersionMatchWithParticipant>c__AnonStoreyF()
			{
			}

			// Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154C")]
			[Address(RVA = "0x44D8B0", Offset = "0x44D8B0", VA = "0x644D8B0")]
			internal void <>m__0(NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x040004FD RID: 1277
			[Token(Token = "0x40013E2")]
			[FieldOffset(Offset = "0x8")]
			internal string participantId;

			// Token: 0x040004FE RID: 1278
			[Token(Token = "0x40013E3")]
			[FieldOffset(Offset = "0xC")]
			internal Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, NativeTurnBasedMatch> onFoundParticipantAndMatch;

			// Token: 0x040004FF RID: 1279
			[Token(Token = "0x40013E4")]
			[FieldOffset(Offset = "0x10")]
			internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

			// Token: 0x04000500 RID: 1280
			[Token(Token = "0x40013E5")]
			[FieldOffset(Offset = "0x14")]
			internal Action<bool> onFailure;
		}

		// Token: 0x020001A9 RID: 425
		[Token(Token = "0x2000323")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FBC0", Offset = "0x17FBC0")]
		private sealed class <Finish>c__AnonStorey10
		{
			// Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x44B860", Offset = "0x44B860", VA = "0x644B860")]
			public <Finish>c__AnonStorey10()
			{
			}

			// Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154E")]
			[Address(RVA = "0x44E2C0", Offset = "0x44E2C0", VA = "0x644E2C0")]
			internal void <>m__0(NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154F")]
			[Address(RVA = "0x44E7AC", Offset = "0x44E7AC", VA = "0x644E7AC")]
			internal void <>m__1(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}

			// Token: 0x04000501 RID: 1281
			[Token(Token = "0x40013E6")]
			[FieldOffset(Offset = "0x8")]
			internal MatchOutcome outcome;

			// Token: 0x04000502 RID: 1282
			[Token(Token = "0x40013E7")]
			[FieldOffset(Offset = "0xC")]
			internal Action<bool> callback;

			// Token: 0x04000503 RID: 1283
			[Token(Token = "0x40013E8")]
			[FieldOffset(Offset = "0x10")]
			internal byte[] data;

			// Token: 0x04000504 RID: 1284
			[Token(Token = "0x40013E9")]
			[FieldOffset(Offset = "0x14")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001AA RID: 426
		[Token(Token = "0x2000324")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FBD0", Offset = "0x17FBD0")]
		private sealed class <AcknowledgeFinished>c__AnonStorey11
		{
			// Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001550")]
			[Address(RVA = "0x44BB14", Offset = "0x44BB14", VA = "0x644BB14")]
			public <AcknowledgeFinished>c__AnonStorey11()
			{
			}

			// Token: 0x06000B31 RID: 2865 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001551")]
			[Address(RVA = "0x44C8A8", Offset = "0x44C8A8", VA = "0x644C8A8")]
			internal void <>m__0(NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001552")]
			[Address(RVA = "0x44C978", Offset = "0x44C978", VA = "0x644C978")]
			internal void <>m__1(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}

			// Token: 0x04000505 RID: 1285
			[Token(Token = "0x40013EA")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool> callback;

			// Token: 0x04000506 RID: 1286
			[Token(Token = "0x40013EB")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001AB RID: 427
		[Token(Token = "0x2000325")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FBE0", Offset = "0x17FBE0")]
		private sealed class <Leave>c__AnonStorey12
		{
			// Token: 0x06000B33 RID: 2867 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001553")]
			[Address(RVA = "0x44BCA4", Offset = "0x44BCA4", VA = "0x644BCA4")]
			public <Leave>c__AnonStorey12()
			{
			}

			// Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001554")]
			[Address(RVA = "0x44FDE4", Offset = "0x44FDE4", VA = "0x644FDE4")]
			internal void <>m__0(NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001555")]
			[Address(RVA = "0x44FEB4", Offset = "0x44FEB4", VA = "0x644FEB4")]
			internal void <>m__1(CommonErrorStatus.MultiplayerStatus status)
			{
			}

			// Token: 0x04000507 RID: 1287
			[Token(Token = "0x40013EC")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool> callback;

			// Token: 0x04000508 RID: 1288
			[Token(Token = "0x40013ED")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001AC RID: 428
		[Token(Token = "0x2000326")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FBF0", Offset = "0x17FBF0")]
		private sealed class <LeaveDuringTurn>c__AnonStorey13
		{
			// Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001556")]
			[Address(RVA = "0x44BE3C", Offset = "0x44BE3C", VA = "0x644BE3C")]
			public <LeaveDuringTurn>c__AnonStorey13()
			{
			}

			// Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001557")]
			[Address(RVA = "0x44FF3C", Offset = "0x44FF3C", VA = "0x644FF3C")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001558")]
			[Address(RVA = "0x450020", Offset = "0x450020", VA = "0x6450020")]
			internal void <>m__1(CommonErrorStatus.MultiplayerStatus status)
			{
			}

			// Token: 0x04000509 RID: 1289
			[Token(Token = "0x40013EE")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool> callback;

			// Token: 0x0400050A RID: 1290
			[Token(Token = "0x40013EF")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001AD RID: 429
		[Token(Token = "0x2000327")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC00", Offset = "0x17FC00")]
		private sealed class <Cancel>c__AnonStorey14
		{
			// Token: 0x06000B39 RID: 2873 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001559")]
			[Address(RVA = "0x44BFCC", Offset = "0x44BFCC", VA = "0x644BFCC")]
			public <Cancel>c__AnonStorey14()
			{
			}

			// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x44CD30", Offset = "0x44CD30", VA = "0x644CD30")]
			internal void <>m__0(NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155B")]
			[Address(RVA = "0x44CE00", Offset = "0x44CE00", VA = "0x644CE00")]
			internal void <>m__1(CommonErrorStatus.MultiplayerStatus status)
			{
			}

			// Token: 0x0400050B RID: 1291
			[Token(Token = "0x40013F0")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool> callback;

			// Token: 0x0400050C RID: 1292
			[Token(Token = "0x40013F1")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}

		// Token: 0x020001AE RID: 430
		[Token(Token = "0x2000328")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC10", Offset = "0x17FC10")]
		private sealed class <Dismiss>c__AnonStorey15
		{
			// Token: 0x06000B3C RID: 2876 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155C")]
			[Address(RVA = "0x44C118", Offset = "0x44C118", VA = "0x644C118")]
			public <Dismiss>c__AnonStorey15()
			{
			}

			// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155D")]
			[Address(RVA = "0x44D394", Offset = "0x44D394", VA = "0x644D394")]
			internal void <>m__0(bool success)
			{
			}

			// Token: 0x0400050D RID: 1293
			[Token(Token = "0x40013F2")]
			[FieldOffset(Offset = "0x8")]
			internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
		}

		// Token: 0x020001AF RID: 431
		[Token(Token = "0x2000329")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC20", Offset = "0x17FC20")]
		private sealed class <Rematch>c__AnonStorey16
		{
			// Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155E")]
			[Address(RVA = "0x44C2D8", Offset = "0x44C2D8", VA = "0x644C2D8")]
			public <Rematch>c__AnonStorey16()
			{
			}

			// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155F")]
			[Address(RVA = "0x4500E4", Offset = "0x4500E4", VA = "0x64500E4")]
			internal void <>m__0(bool failed)
			{
			}

			// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001560")]
			[Address(RVA = "0x450164", Offset = "0x450164", VA = "0x6450164")]
			internal void <>m__1(NativeTurnBasedMatch foundMatch)
			{
			}

			// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001561")]
			[Address(RVA = "0x45025C", Offset = "0x45025C", VA = "0x645025C")]
			internal void <>m__2(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch m)
			{
			}

			// Token: 0x0400050E RID: 1294
			[Token(Token = "0x40013F3")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			// Token: 0x0400050F RID: 1295
			[Token(Token = "0x40013F4")]
			[FieldOffset(Offset = "0xC")]
			internal NativeTurnBasedMultiplayerClient $this;
		}
	}
}
