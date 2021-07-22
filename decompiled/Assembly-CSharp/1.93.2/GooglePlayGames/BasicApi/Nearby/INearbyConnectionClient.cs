using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x2000057")]
	public interface INearbyConnectionClient
	{
		// Token: 0x06000431 RID: 1073
		[Token(Token = "0x6000405")]
		int MaxUnreliableMessagePayloadLength();

		// Token: 0x06000432 RID: 1074
		[Token(Token = "0x6000406")]
		int MaxReliableMessagePayloadLength();

		// Token: 0x06000433 RID: 1075
		[Token(Token = "0x6000407")]
		void SendReliable(List<string> recipientEndpointIds, byte[] payload);

		// Token: 0x06000434 RID: 1076
		[Token(Token = "0x6000408")]
		void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);

		// Token: 0x06000435 RID: 1077
		[Token(Token = "0x6000409")]
		void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);

		// Token: 0x06000436 RID: 1078
		[Token(Token = "0x600040A")]
		void StopAdvertising();

		// Token: 0x06000437 RID: 1079
		[Token(Token = "0x600040B")]
		void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);

		// Token: 0x06000438 RID: 1080
		[Token(Token = "0x600040C")]
		void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);

		// Token: 0x06000439 RID: 1081
		[Token(Token = "0x600040D")]
		void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener);

		// Token: 0x0600043A RID: 1082
		[Token(Token = "0x600040E")]
		void StopDiscovery(string serviceId);

		// Token: 0x0600043B RID: 1083
		[Token(Token = "0x600040F")]
		void RejectConnectionRequest(string requestingEndpointId);

		// Token: 0x0600043C RID: 1084
		[Token(Token = "0x6000410")]
		void DisconnectFromEndpoint(string remoteEndpointId);

		// Token: 0x0600043D RID: 1085
		[Token(Token = "0x6000411")]
		void StopAllConnections();

		// Token: 0x0600043E RID: 1086
		[Token(Token = "0x6000412")]
		string GetAppBundleId();

		// Token: 0x0600043F RID: 1087
		[Token(Token = "0x6000413")]
		string GetServiceId();
	}
}
