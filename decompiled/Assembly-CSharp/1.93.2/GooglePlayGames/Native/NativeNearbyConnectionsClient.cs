using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x2000127")]
	internal class NativeNearbyConnectionsClient : INearbyConnectionClient
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x6E195C", Offset = "0x6E195C", VA = "0x66E195C")]
		internal NativeNearbyConnectionsClient(NearbyConnectionsManager manager)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x6E1DAC", Offset = "0x6E1DAC", VA = "0x66E1DAC", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return 0;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x6E1DB4", Offset = "0x6E1DB4", VA = "0x66E1DB4", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return 0;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x6E1DBC", Offset = "0x6E1DBC", VA = "0x66E1DBC", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x6E2278", Offset = "0x6E2278", VA = "0x66E2278", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x6E1DD8", Offset = "0x6E1DD8", VA = "0x66E1DD8")]
		private void InternalSend(List<string> recipientEndpointIds, byte[] payload, bool isReliable)
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x6E2294", Offset = "0x6E2294", VA = "0x66E2294", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> requestCallback)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x6E26F4", Offset = "0x6E26F4", VA = "0x66E26F4")]
		private static long ToTimeoutMillis(TimeSpan? span)
		{
			return 0L;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x6E27D0", Offset = "0x6E27D0", VA = "0x66E27D0", Slot = "9")]
		public void StopAdvertising()
		{
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x6E27FC", Offset = "0x6E27FC", VA = "0x66E27FC", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x6E2B54", Offset = "0x6E2B54", VA = "0x66E2B54")]
		private static NativeMessageListenerHelper ToMessageListener(IMessageListener listener)
		{
			return null;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x6E2D84", Offset = "0x6E2D84", VA = "0x66E2D84", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x6E2EF4", Offset = "0x6E2EF4", VA = "0x66E2EF4", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x6E30DC", Offset = "0x6E30DC", VA = "0x66E30DC")]
		private static NativeEndpointDiscoveryListenerHelper ToDiscoveryListener(IDiscoveryListener listener)
		{
			return null;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x6E3318", Offset = "0x6E3318", VA = "0x66E3318", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x6E33B4", Offset = "0x6E33B4", VA = "0x66E33B4", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x6E3450", Offset = "0x6E3450", VA = "0x66E3450", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x6E3484", Offset = "0x6E3484", VA = "0x66E3484", Slot = "16")]
		public void StopAllConnections()
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x6E34B0", Offset = "0x6E34B0", VA = "0x66E34B0", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x6E34DC", Offset = "0x6E34DC", VA = "0x66E34DC", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x8")]
		private readonly NearbyConnectionsManager mManager;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E00", Offset = "0x180E00")]
		private static Func<string, NativeAppIdentifier> <>f__mg$cache0;

		// Token: 0x0200015B RID: 347
		[Token(Token = "0x2000128")]
		protected class OnGameThreadMessageListener : IMessageListener
		{
			// Token: 0x060009E0 RID: 2528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x6E2D0C", Offset = "0x6E2D0C", VA = "0x66E2D0C")]
			public OnGameThreadMessageListener(IMessageListener listener)
			{
			}

			// Token: 0x060009E1 RID: 2529 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x6E3FA0", Offset = "0x6E3FA0", VA = "0x66E3FA0", Slot = "4")]
			public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
			{
			}

			// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x6E40E4", Offset = "0x6E40E4", VA = "0x66E40E4", Slot = "5")]
			public void OnRemoteEndpointDisconnected(string remoteEndpointId)
			{
			}

			// Token: 0x0400043E RID: 1086
			[Token(Token = "0x40003A1")]
			[FieldOffset(Offset = "0x8")]
			private readonly IMessageListener mListener;

			// Token: 0x0200015C RID: 348
			[Token(Token = "0x20002EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F8E0", Offset = "0x17F8E0")]
			private sealed class <OnMessageReceived>c__AnonStorey0
			{
				// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014D8")]
				[Address(RVA = "0x6E40DC", Offset = "0x6E40DC", VA = "0x66E40DC")]
				public <OnMessageReceived>c__AnonStorey0()
				{
				}

				// Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014D9")]
				[Address(RVA = "0x6E41F8", Offset = "0x6E41F8", VA = "0x66E41F8")]
				internal void <>m__0()
				{
				}

				// Token: 0x0400043F RID: 1087
				[Token(Token = "0x4001364")]
				[FieldOffset(Offset = "0x8")]
				internal string remoteEndpointId;

				// Token: 0x04000440 RID: 1088
				[Token(Token = "0x4001365")]
				[FieldOffset(Offset = "0xC")]
				internal byte[] data;

				// Token: 0x04000441 RID: 1089
				[Token(Token = "0x4001366")]
				[FieldOffset(Offset = "0x10")]
				internal bool isReliableMessage;

				// Token: 0x04000442 RID: 1090
				[Token(Token = "0x4001367")]
				[FieldOffset(Offset = "0x14")]
				internal NativeNearbyConnectionsClient.OnGameThreadMessageListener $this;
			}

			// Token: 0x0200015D RID: 349
			[Token(Token = "0x20002ED")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F8F0", Offset = "0x17F8F0")]
			private sealed class <OnRemoteEndpointDisconnected>c__AnonStorey1
			{
				// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014DA")]
				[Address(RVA = "0x6E41F0", Offset = "0x6E41F0", VA = "0x66E41F0")]
				public <OnRemoteEndpointDisconnected>c__AnonStorey1()
				{
				}

				// Token: 0x060009E6 RID: 2534 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014DB")]
				[Address(RVA = "0x6E4310", Offset = "0x6E4310", VA = "0x66E4310")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000443 RID: 1091
				[Token(Token = "0x4001368")]
				[FieldOffset(Offset = "0x8")]
				internal string remoteEndpointId;

				// Token: 0x04000444 RID: 1092
				[Token(Token = "0x4001369")]
				[FieldOffset(Offset = "0xC")]
				internal NativeNearbyConnectionsClient.OnGameThreadMessageListener $this;
			}
		}

		// Token: 0x0200015E RID: 350
		[Token(Token = "0x2000129")]
		protected class OnGameThreadDiscoveryListener : IDiscoveryListener
		{
			// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x6E32A0", Offset = "0x6E32A0", VA = "0x66E32A0")]
			public OnGameThreadDiscoveryListener(IDiscoveryListener listener)
			{
			}

			// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x6E3B6C", Offset = "0x6E3B6C", VA = "0x66E3B6C", Slot = "4")]
			public void OnEndpointFound(EndpointDetails discoveredEndpoint)
			{
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x6E3C8C", Offset = "0x6E3C8C", VA = "0x66E3C8C", Slot = "5")]
			public void OnEndpointLost(string lostEndpointId)
			{
			}

			// Token: 0x04000445 RID: 1093
			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x8")]
			private readonly IDiscoveryListener mListener;

			// Token: 0x0200015F RID: 351
			[Token(Token = "0x20002EE")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F900", Offset = "0x17F900")]
			private sealed class <OnEndpointFound>c__AnonStorey0
			{
				// Token: 0x060009EA RID: 2538 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014DC")]
				[Address(RVA = "0x6E3C84", Offset = "0x6E3C84", VA = "0x66E3C84")]
				public <OnEndpointFound>c__AnonStorey0()
				{
				}

				// Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014DD")]
				[Address(RVA = "0x6E3DA0", Offset = "0x6E3DA0", VA = "0x66E3DA0")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000446 RID: 1094
				[Token(Token = "0x400136A")]
				[FieldOffset(Offset = "0x8")]
				internal EndpointDetails discoveredEndpoint;

				// Token: 0x04000447 RID: 1095
				[Token(Token = "0x400136B")]
				[FieldOffset(Offset = "0x14")]
				internal NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener $this;
			}

			// Token: 0x02000160 RID: 352
			[Token(Token = "0x20002EF")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F910", Offset = "0x17F910")]
			private sealed class <OnEndpointLost>c__AnonStorey1
			{
				// Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014DE")]
				[Address(RVA = "0x6E3D98", Offset = "0x6E3D98", VA = "0x66E3D98")]
				public <OnEndpointLost>c__AnonStorey1()
				{
				}

				// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014DF")]
				[Address(RVA = "0x6E3EAC", Offset = "0x6E3EAC", VA = "0x66E3EAC")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000448 RID: 1096
				[Token(Token = "0x400136C")]
				[FieldOffset(Offset = "0x8")]
				internal string lostEndpointId;

				// Token: 0x04000449 RID: 1097
				[Token(Token = "0x400136D")]
				[FieldOffset(Offset = "0xC")]
				internal NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener $this;
			}
		}

		// Token: 0x02000161 RID: 353
		[Token(Token = "0x20002E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F8A0", Offset = "0x17F8A0")]
		private sealed class <StartAdvertising>c__AnonStorey0
		{
			// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014CD")]
			[Address(RVA = "0x6E26EC", Offset = "0x6E26EC", VA = "0x66E26EC")]
			public <StartAdvertising>c__AnonStorey0()
			{
			}

			// Token: 0x060009EF RID: 2543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014CE")]
			[Address(RVA = "0x6E3638", Offset = "0x6E3638", VA = "0x66E3638")]
			internal void <>m__0(long localClientId, NativeStartAdvertisingResult result)
			{
			}

			// Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014CF")]
			[Address(RVA = "0x6E36E0", Offset = "0x6E36E0", VA = "0x66E36E0")]
			internal void <>m__1(long localClientId, NativeConnectionRequest request)
			{
			}

			// Token: 0x0400044A RID: 1098
			[Token(Token = "0x400135F")]
			[FieldOffset(Offset = "0x8")]
			internal Action<AdvertisingResult> resultCallback;

			// Token: 0x0400044B RID: 1099
			[Token(Token = "0x4001360")]
			[FieldOffset(Offset = "0xC")]
			internal Action<ConnectionRequest> requestCallback;
		}

		// Token: 0x02000162 RID: 354
		[Token(Token = "0x20002E9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F8B0", Offset = "0x17F8B0")]
		private sealed class <SendConnectionRequest>c__AnonStorey1
		{
			// Token: 0x060009F1 RID: 2545 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D0")]
			[Address(RVA = "0x6E2B4C", Offset = "0x6E2B4C", VA = "0x66E2B4C")]
			public <SendConnectionRequest>c__AnonStorey1()
			{
			}

			// Token: 0x060009F2 RID: 2546 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D1")]
			[Address(RVA = "0x6E3558", Offset = "0x6E3558", VA = "0x66E3558")]
			internal void <>m__0(long localClientId, NativeConnectionResponse response)
			{
			}

			// Token: 0x0400044C RID: 1100
			[Token(Token = "0x4001361")]
			[FieldOffset(Offset = "0x8")]
			internal Action<ConnectionResponse> responseCallback;
		}

		// Token: 0x02000163 RID: 355
		[Token(Token = "0x20002EA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F8C0", Offset = "0x17F8C0")]
		private sealed class <ToMessageListener>c__AnonStorey2
		{
			// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D2")]
			[Address(RVA = "0x6E2D04", Offset = "0x6E2D04", VA = "0x66E2D04")]
			public <ToMessageListener>c__AnonStorey2()
			{
			}

			// Token: 0x060009F4 RID: 2548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D3")]
			[Address(RVA = "0x6E3990", Offset = "0x6E3990", VA = "0x66E3990")]
			internal void <>m__0(long localClientId, string endpointId, byte[] data, bool isReliable)
			{
			}

			// Token: 0x060009F5 RID: 2549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D4")]
			[Address(RVA = "0x6E3A8C", Offset = "0x6E3A8C", VA = "0x66E3A8C")]
			internal void <>m__1(long localClientId, string endpointId)
			{
			}

			// Token: 0x0400044D RID: 1101
			[Token(Token = "0x4001362")]
			[FieldOffset(Offset = "0x8")]
			internal IMessageListener listener;
		}

		// Token: 0x02000164 RID: 356
		[Token(Token = "0x20002EB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F8D0", Offset = "0x17F8D0")]
		private sealed class <ToDiscoveryListener>c__AnonStorey3
		{
			// Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D5")]
			[Address(RVA = "0x6E3298", Offset = "0x6E3298", VA = "0x66E3298")]
			public <ToDiscoveryListener>c__AnonStorey3()
			{
			}

			// Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D6")]
			[Address(RVA = "0x6E3794", Offset = "0x6E3794", VA = "0x66E3794")]
			internal void <>m__0(long localClientId, NativeEndpointDetails endpoint)
			{
			}

			// Token: 0x060009F8 RID: 2552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014D7")]
			[Address(RVA = "0x6E38B0", Offset = "0x6E38B0", VA = "0x66E38B0")]
			internal void <>m__1(long localClientId, string lostEndpointId)
			{
			}

			// Token: 0x0400044E RID: 1102
			[Token(Token = "0x4001363")]
			[FieldOffset(Offset = "0x8")]
			internal IDiscoveryListener listener;
		}
	}
}
