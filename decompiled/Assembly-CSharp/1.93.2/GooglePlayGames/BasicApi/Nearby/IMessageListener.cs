using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x2000058")]
	public interface IMessageListener
	{
		// Token: 0x06000440 RID: 1088
		[Token(Token = "0x6000414")]
		void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

		// Token: 0x06000441 RID: 1089
		[Token(Token = "0x6000415")]
		void OnRemoteEndpointDisconnected(string remoteEndpointId);
	}
}
