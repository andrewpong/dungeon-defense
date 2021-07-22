using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x2000045")]
	public interface IRealTimeMultiplayerClient
	{
		// Token: 0x060003AF RID: 943
		[Token(Token = "0x6000383")]
		void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener);

		// Token: 0x060003B0 RID: 944
		[Token(Token = "0x6000384")]
		void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener);

		// Token: 0x060003B1 RID: 945
		[Token(Token = "0x6000385")]
		void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, RealTimeMultiplayerListener listener);

		// Token: 0x060003B2 RID: 946
		[Token(Token = "0x6000386")]
		void ShowWaitingRoomUI();

		// Token: 0x060003B3 RID: 947
		[Token(Token = "0x6000387")]
		void GetAllInvitations(Action<Invitation[]> callback);

		// Token: 0x060003B4 RID: 948
		[Token(Token = "0x6000388")]
		void AcceptFromInbox(RealTimeMultiplayerListener listener);

		// Token: 0x060003B5 RID: 949
		[Token(Token = "0x6000389")]
		void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener);

		// Token: 0x060003B6 RID: 950
		[Token(Token = "0x600038A")]
		void SendMessageToAll(bool reliable, byte[] data);

		// Token: 0x060003B7 RID: 951
		[Token(Token = "0x600038B")]
		void SendMessageToAll(bool reliable, byte[] data, int offset, int length);

		// Token: 0x060003B8 RID: 952
		[Token(Token = "0x600038C")]
		void SendMessage(bool reliable, string participantId, byte[] data);

		// Token: 0x060003B9 RID: 953
		[Token(Token = "0x600038D")]
		void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length);

		// Token: 0x060003BA RID: 954
		[Token(Token = "0x600038E")]
		List<Participant> GetConnectedParticipants();

		// Token: 0x060003BB RID: 955
		[Token(Token = "0x600038F")]
		Participant GetSelf();

		// Token: 0x060003BC RID: 956
		[Token(Token = "0x6000390")]
		Participant GetParticipant(string participantId);

		// Token: 0x060003BD RID: 957
		[Token(Token = "0x6000391")]
		Invitation GetInvitation();

		// Token: 0x060003BE RID: 958
		[Token(Token = "0x6000392")]
		void LeaveRoom();

		// Token: 0x060003BF RID: 959
		[Token(Token = "0x6000393")]
		bool IsRoomConnected();

		// Token: 0x060003C0 RID: 960
		[Token(Token = "0x6000394")]
		void DeclineInvitation(string invitationId);
	}
}
