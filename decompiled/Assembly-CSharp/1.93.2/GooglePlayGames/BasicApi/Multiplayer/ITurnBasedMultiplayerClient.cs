using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x2000046")]
	public interface ITurnBasedMultiplayerClient
	{
		// Token: 0x060003C1 RID: 961
		[Token(Token = "0x6000395")]
		void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback);

		// Token: 0x060003C2 RID: 962
		[Token(Token = "0x6000396")]
		void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, TurnBasedMatch> callback);

		// Token: 0x060003C3 RID: 963
		[Token(Token = "0x6000397")]
		void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback);

		// Token: 0x060003C4 RID: 964
		[Token(Token = "0x6000398")]
		void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<UIStatus, TurnBasedMatch> callback);

		// Token: 0x060003C5 RID: 965
		[Token(Token = "0x6000399")]
		void GetAllInvitations(Action<Invitation[]> callback);

		// Token: 0x060003C6 RID: 966
		[Token(Token = "0x600039A")]
		void GetAllMatches(Action<TurnBasedMatch[]> callback);

		// Token: 0x060003C7 RID: 967
		[Token(Token = "0x600039B")]
		void GetMatch(string matchId, Action<bool, TurnBasedMatch> callback);

		// Token: 0x060003C8 RID: 968
		[Token(Token = "0x600039C")]
		void AcceptFromInbox(Action<bool, TurnBasedMatch> callback);

		// Token: 0x060003C9 RID: 969
		[Token(Token = "0x600039D")]
		void AcceptInvitation(string invitationId, Action<bool, TurnBasedMatch> callback);

		// Token: 0x060003CA RID: 970
		[Token(Token = "0x600039E")]
		void RegisterMatchDelegate(MatchDelegate del);

		// Token: 0x060003CB RID: 971
		[Token(Token = "0x600039F")]
		void TakeTurn(TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback);

		// Token: 0x060003CC RID: 972
		[Token(Token = "0x60003A0")]
		int GetMaxMatchDataSize();

		// Token: 0x060003CD RID: 973
		[Token(Token = "0x60003A1")]
		void Finish(TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback);

		// Token: 0x060003CE RID: 974
		[Token(Token = "0x60003A2")]
		void AcknowledgeFinished(TurnBasedMatch match, Action<bool> callback);

		// Token: 0x060003CF RID: 975
		[Token(Token = "0x60003A3")]
		void Leave(TurnBasedMatch match, Action<bool> callback);

		// Token: 0x060003D0 RID: 976
		[Token(Token = "0x60003A4")]
		void LeaveDuringTurn(TurnBasedMatch match, string pendingParticipantId, Action<bool> callback);

		// Token: 0x060003D1 RID: 977
		[Token(Token = "0x60003A5")]
		void Cancel(TurnBasedMatch match, Action<bool> callback);

		// Token: 0x060003D2 RID: 978
		[Token(Token = "0x60003A6")]
		void Dismiss(TurnBasedMatch match);

		// Token: 0x060003D3 RID: 979
		[Token(Token = "0x60003A7")]
		void Rematch(TurnBasedMatch match, Action<bool, TurnBasedMatch> callback);

		// Token: 0x060003D4 RID: 980
		[Token(Token = "0x60003A8")]
		void DeclineInvitation(string invitationId);
	}
}
