using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x2000055")]
	public class DummyNearbyConnectionClient : INearbyConnectionClient
	{
		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x94482C", Offset = "0x94482C", VA = "0x694482C")]
		public DummyNearbyConnectionClient()
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x944834", Offset = "0x944834", VA = "0x6944834", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return 0;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x94483C", Offset = "0x94483C", VA = "0x694483C", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return 0;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x944844", Offset = "0x944844", VA = "0x6944844", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x9448D0", Offset = "0x9448D0", VA = "0x69448D0", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x94495C", Offset = "0x94495C", VA = "0x694495C", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x944A40", Offset = "0x944A40", VA = "0x6944A40", Slot = "9")]
		public void StopAdvertising()
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x944ACC", Offset = "0x944ACC", VA = "0x6944ACC", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x944C30", Offset = "0x944C30", VA = "0x6944C30", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x944CBC", Offset = "0x944CBC", VA = "0x6944CBC", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x944D48", Offset = "0x944D48", VA = "0x6944D48", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x944DD4", Offset = "0x944DD4", VA = "0x6944DD4", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x944E60", Offset = "0x944E60", VA = "0x6944E60", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x944EEC", Offset = "0x944EEC", VA = "0x6944EEC", Slot = "16")]
		public void StopAllConnections()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x944F78", Offset = "0x944F78", VA = "0x6944F78")]
		public string LocalEndpointId()
		{
			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x945004", Offset = "0x945004", VA = "0x6945004")]
		public string LocalDeviceId()
		{
			return null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x945060", Offset = "0x945060", VA = "0x6945060", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x9450BC", Offset = "0x9450BC", VA = "0x69450BC", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}
	}
}
