using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x200004D")]
	public interface RealTimeMultiplayerListener
	{
		// Token: 0x060003ED RID: 1005
		[Token(Token = "0x60003C1")]
		void OnRoomSetupProgress(float percent);

		// Token: 0x060003EE RID: 1006
		[Token(Token = "0x60003C2")]
		void OnRoomConnected(bool success);

		// Token: 0x060003EF RID: 1007
		[Token(Token = "0x60003C3")]
		void OnLeftRoom();

		// Token: 0x060003F0 RID: 1008
		[Token(Token = "0x60003C4")]
		void OnParticipantLeft(Participant participant);

		// Token: 0x060003F1 RID: 1009
		[Token(Token = "0x60003C5")]
		void OnPeersConnected(string[] participantIds);

		// Token: 0x060003F2 RID: 1010
		[Token(Token = "0x60003C6")]
		void OnPeersDisconnected(string[] participantIds);

		// Token: 0x060003F3 RID: 1011
		[Token(Token = "0x60003C7")]
		void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data);
	}
}
