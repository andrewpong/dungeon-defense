using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x200012A")]
	public class NativeRealtimeMultiplayerClient : IRealTimeMultiplayerClient
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x6DC288", Offset = "0x6DC288", VA = "0x66DC288")]
		internal NativeRealtimeMultiplayerClient(NativeClient nativeClient, RealtimeManager manager)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x6E4404", Offset = "0x6E4404", VA = "0x66E4404")]
		private NativeRealtimeMultiplayerClient.RoomSession GetTerminatedSession()
		{
			return null;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x6E44E8", Offset = "0x6E44E8", VA = "0x66E44E8", Slot = "4")]
		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x6E4514", Offset = "0x6E4514", VA = "0x66E4514", Slot = "5")]
		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener)
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x6E4E14", Offset = "0x6E4E14", VA = "0x66E4E14")]
		private static GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper HelperForSession(NativeRealtimeMultiplayerClient.RoomSession session)
		{
			return null;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x6E503C", Offset = "0x6E503C", VA = "0x66E503C")]
		private void HandleAppPausing(bool paused)
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x6E5110", Offset = "0x6E5110", VA = "0x66E5110", Slot = "6")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x6E53FC", Offset = "0x6E53FC", VA = "0x66E53FC", Slot = "7")]
		public void ShowWaitingRoomUI()
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x6E5490", Offset = "0x6E5490", VA = "0x66E5490", Slot = "8")]
		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x6E557C", Offset = "0x6E557C", VA = "0x66E557C", Slot = "9")]
		public void AcceptFromInbox(RealTimeMultiplayerListener listener)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x6E57F8", Offset = "0x6E57F8", VA = "0x66E57F8", Slot = "10")]
		public void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener)
		{
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x6E5A94", Offset = "0x6E5A94", VA = "0x66E5A94", Slot = "18")]
		public Invitation GetInvitation()
		{
			return null;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x6E50E0", Offset = "0x6E50E0", VA = "0x66E50E0", Slot = "19")]
		public void LeaveRoom()
		{
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x6E5AC4", Offset = "0x6E5AC4", VA = "0x66E5AC4", Slot = "11")]
		public void SendMessageToAll(bool reliable, byte[] data)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x6E5B04", Offset = "0x6E5B04", VA = "0x66E5B04", Slot = "12")]
		public void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x6E5B60", Offset = "0x6E5B60", VA = "0x66E5B60", Slot = "13")]
		public void SendMessage(bool reliable, string participantId, byte[] data)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x6E5BB4", Offset = "0x6E5BB4", VA = "0x66E5BB4", Slot = "14")]
		public void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x6E5C18", Offset = "0x6E5C18", VA = "0x66E5C18", Slot = "15")]
		public List<Participant> GetConnectedParticipants()
		{
			return null;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x6E5C48", Offset = "0x6E5C48", VA = "0x66E5C48", Slot = "16")]
		public Participant GetSelf()
		{
			return null;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x6E5C80", Offset = "0x6E5C80", VA = "0x66E5C80", Slot = "17")]
		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x6E5CC0", Offset = "0x6E5CC0", VA = "0x66E5CC0", Slot = "20")]
		public bool IsRoomConnected()
		{
			return default(bool);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x6E5CF8", Offset = "0x6E5CF8", VA = "0x66E5CF8", Slot = "21")]
		public void DeclineInvitation(string invitationId)
		{
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096F")]
		private static T WithDefault<T>(T presented, T defaultValue) where T : class
		{
			return null;
		}

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x8")]
		private readonly object mSessionLock;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0xC")]
		private readonly NativeClient mNativeClient;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x10")]
		private readonly RealtimeManager mRealtimeManager;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x14")]
		private NativeRealtimeMultiplayerClient.RoomSession mCurrentSession;

		// Token: 0x02000166 RID: 358
		[Token(Token = "0x200012B")]
		private class NoopListener : RealTimeMultiplayerListener
		{
			// Token: 0x06000A10 RID: 2576 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x4438A0", Offset = "0x4438A0", VA = "0x64438A0")]
			public NoopListener()
			{
			}

			// Token: 0x06000A11 RID: 2577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x4438A8", Offset = "0x4438A8", VA = "0x64438A8", Slot = "4")]
			public void OnRoomSetupProgress(float percent)
			{
			}

			// Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x4438AC", Offset = "0x4438AC", VA = "0x64438AC", Slot = "5")]
			public void OnRoomConnected(bool success)
			{
			}

			// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x4438B0", Offset = "0x4438B0", VA = "0x64438B0", Slot = "6")]
			public void OnLeftRoom()
			{
			}

			// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x4438B4", Offset = "0x4438B4", VA = "0x64438B4", Slot = "7")]
			public void OnParticipantLeft(Participant participant)
			{
			}

			// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x4438B8", Offset = "0x4438B8", VA = "0x64438B8", Slot = "8")]
			public void OnPeersConnected(string[] participantIds)
			{
			}

			// Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x4438BC", Offset = "0x4438BC", VA = "0x64438BC", Slot = "9")]
			public void OnPeersDisconnected(string[] participantIds)
			{
			}

			// Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x4438C0", Offset = "0x4438C0", VA = "0x64438C0", Slot = "10")]
			public void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}
		}

		// Token: 0x02000167 RID: 359
		[Token(Token = "0x200012C")]
		private class RoomSession
		{
			// Token: 0x06000A18 RID: 2584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x4442DC", Offset = "0x4442DC", VA = "0x64442DC")]
			internal RoomSession(RealtimeManager manager, RealTimeMultiplayerListener listener)
			{
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00005250 File Offset: 0x00003450
			// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000107")]
			internal bool ShowingUI
			{
				[Token(Token = "0x6000979")]
				[Address(RVA = "0x4445D0", Offset = "0x4445D0", VA = "0x64445D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600097A")]
				[Address(RVA = "0x43E130", Offset = "0x43E130", VA = "0x643E130")]
				set
				{
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00005268 File Offset: 0x00003468
			// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000108")]
			internal uint MinPlayersToStart
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0x43D548", Offset = "0x43D548", VA = "0x643D548")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600097C")]
				[Address(RVA = "0x43D540", Offset = "0x43D540", VA = "0x643D540")]
				set
				{
				}
			}

			// Token: 0x06000A1D RID: 2589 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x442464", Offset = "0x442464", VA = "0x6442464")]
			internal RealtimeManager Manager()
			{
				return null;
			}

			// Token: 0x06000A1E RID: 2590 RVA: 0x00005280 File Offset: 0x00003480
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x4445E8", Offset = "0x4445E8", VA = "0x64445E8")]
			internal bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06000A1F RID: 2591 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x43FCE4", Offset = "0x43FCE4", VA = "0x643FCE4")]
			internal string SelfPlayerId()
			{
				return null;
			}

			// Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x444620", Offset = "0x444620", VA = "0x6444620")]
			public void SetInvitation(Invitation invitation)
			{
			}

			// Token: 0x06000A21 RID: 2593 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x444628", Offset = "0x444628", VA = "0x6444628")]
			public Invitation GetInvitation()
			{
				return null;
			}

			// Token: 0x06000A22 RID: 2594 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x43F5DC", Offset = "0x43F5DC", VA = "0x643F5DC")]
			internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener OnGameThreadListener()
			{
				return null;
			}

			// Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x43F5D4", Offset = "0x43F5D4", VA = "0x643F5D4")]
			internal void EnterState(NativeRealtimeMultiplayerClient.State handler)
			{
			}

			// Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x4443DC", Offset = "0x4443DC", VA = "0x64443DC")]
			internal void EnterState(NativeRealtimeMultiplayerClient.State handler, bool fireStateEnteredEvent)
			{
			}

			// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x43D2E4", Offset = "0x43D2E4", VA = "0x643D2E4")]
			internal void LeaveRoom()
			{
			}

			// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x444630", Offset = "0x444630", VA = "0x6444630")]
			internal void ShowWaitingRoomUI()
			{
			}

			// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x43D558", Offset = "0x43D558", VA = "0x643D558")]
			internal void StartRoomCreation(string currentPlayerId, Action createRoom)
			{
			}

			// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x43F290", Offset = "0x43F290", VA = "0x643F290")]
			internal void OnRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x43F1B8", Offset = "0x43F1B8", VA = "0x643F1B8")]
			internal void OnConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x43F0D4", Offset = "0x43F0D4", VA = "0x643F0D4")]
			internal void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x444674", Offset = "0x444674", VA = "0x6444674")]
			internal void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			// Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x43F038", Offset = "0x43F038", VA = "0x643F038")]
			internal void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
			{
			}

			// Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x44471C", Offset = "0x44471C", VA = "0x644471C")]
			internal void SendMessageToAll(bool reliable, byte[] data)
			{
			}

			// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x444768", Offset = "0x444768", VA = "0x6444768")]
			internal void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
			{
			}

			// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x4447CC", Offset = "0x4447CC", VA = "0x64447CC")]
			internal void SendMessage(bool reliable, string participantId, byte[] data)
			{
			}

			// Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x444824", Offset = "0x444824", VA = "0x6444824")]
			internal void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
			{
			}

			// Token: 0x06000A31 RID: 2609 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x444890", Offset = "0x444890", VA = "0x6444890")]
			internal List<Participant> GetConnectedParticipants()
			{
				return null;
			}

			// Token: 0x06000A32 RID: 2610 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x4448C8", Offset = "0x4448C8", VA = "0x64448C8", Slot = "4")]
			internal virtual Participant GetSelf()
			{
				return null;
			}

			// Token: 0x06000A33 RID: 2611 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x444900", Offset = "0x444900", VA = "0x6444900", Slot = "5")]
			internal virtual Participant GetParticipant(string participantId)
			{
				return null;
			}

			// Token: 0x06000A34 RID: 2612 RVA: 0x00005298 File Offset: 0x00003498
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x444940", Offset = "0x444940", VA = "0x6444940", Slot = "6")]
			internal virtual bool IsRoomConnected()
			{
				return default(bool);
			}

			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x8")]
			private readonly object mLifecycleLock;

			// Token: 0x04000454 RID: 1108
			[Token(Token = "0x40003A8")]
			[FieldOffset(Offset = "0xC")]
			private readonly NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener mListener;

			// Token: 0x04000455 RID: 1109
			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x10")]
			private readonly RealtimeManager mManager;

			// Token: 0x04000456 RID: 1110
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x14")]
			private string mCurrentPlayerId;

			// Token: 0x04000457 RID: 1111
			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x18")]
			private NativeRealtimeMultiplayerClient.State mState;

			// Token: 0x04000458 RID: 1112
			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x1C")]
			private bool mStillPreRoomCreation;

			// Token: 0x04000459 RID: 1113
			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x20")]
			private Invitation mInvitation;

			// Token: 0x0400045A RID: 1114
			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x24")]
			private bool mShowingUI;

			// Token: 0x0400045B RID: 1115
			[Token(Token = "0x40003AF")]
			[FieldOffset(Offset = "0x28")]
			private uint mMinPlayersToStart;
		}

		// Token: 0x02000168 RID: 360
		[Token(Token = "0x200012D")]
		private class OnGameThreadForwardingListener
		{
			// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x4438C4", Offset = "0x4438C4", VA = "0x64438C4")]
			internal OnGameThreadForwardingListener(RealTimeMultiplayerListener listener)
			{
			}

			// Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x44142C", Offset = "0x44142C", VA = "0x644142C")]
			public void RoomSetupProgress(float percent)
			{
			}

			// Token: 0x06000A37 RID: 2615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x43F5E4", Offset = "0x43F5E4", VA = "0x643F5E4")]
			public void RoomConnected(bool success)
			{
			}

			// Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x440FF0", Offset = "0x440FF0", VA = "0x6440FF0")]
			public void LeftRoom()
			{
			}

			// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x4409E0", Offset = "0x4409E0", VA = "0x64409E0")]
			public void PeersConnected(string[] participantIds)
			{
			}

			// Token: 0x06000A3A RID: 2618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x440AEC", Offset = "0x440AEC", VA = "0x6440AEC")]
			public void PeersDisconnected(string[] participantIds)
			{
			}

			// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x4436BC", Offset = "0x4436BC", VA = "0x64436BC")]
			public void RealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}

			// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x442178", Offset = "0x442178", VA = "0x6442178")]
			public void ParticipantLeft(Participant participant)
			{
			}

			// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x44396C", Offset = "0x44396C", VA = "0x644396C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18565C", Offset = "0x18565C")]
			private void <LeftRoom>m__0()
			{
			}

			// Token: 0x0400045C RID: 1116
			[Token(Token = "0x40003B0")]
			[FieldOffset(Offset = "0x8")]
			private readonly RealTimeMultiplayerListener mListener;

			// Token: 0x02000169 RID: 361
			[Token(Token = "0x20002FB")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F9D0", Offset = "0x17F9D0")]
			private sealed class <RoomSetupProgress>c__AnonStorey0
			{
				// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014F5")]
				[Address(RVA = "0x44393C", Offset = "0x44393C", VA = "0x644393C")]
				public <RoomSetupProgress>c__AnonStorey0()
				{
				}

				// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014F6")]
				[Address(RVA = "0x443F34", Offset = "0x443F34", VA = "0x6443F34")]
				internal void <>m__0()
				{
				}

				// Token: 0x0400045D RID: 1117
				[Token(Token = "0x4001382")]
				[FieldOffset(Offset = "0x8")]
				internal float percent;

				// Token: 0x0400045E RID: 1118
				[Token(Token = "0x4001383")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener $this;
			}

			// Token: 0x0200016A RID: 362
			[Token(Token = "0x20002FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F9E0", Offset = "0x17F9E0")]
			private sealed class <RoomConnected>c__AnonStorey1
			{
				// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014F7")]
				[Address(RVA = "0x443944", Offset = "0x443944", VA = "0x6443944")]
				public <RoomConnected>c__AnonStorey1()
				{
				}

				// Token: 0x06000A41 RID: 2625 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014F8")]
				[Address(RVA = "0x443E38", Offset = "0x443E38", VA = "0x6443E38")]
				internal void <>m__0()
				{
				}

				// Token: 0x0400045F RID: 1119
				[Token(Token = "0x4001384")]
				[FieldOffset(Offset = "0x8")]
				internal bool success;

				// Token: 0x04000460 RID: 1120
				[Token(Token = "0x4001385")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener $this;
			}

			// Token: 0x0200016B RID: 363
			[Token(Token = "0x20002FD")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F9F0", Offset = "0x17F9F0")]
			private sealed class <PeersConnected>c__AnonStorey2
			{
				// Token: 0x06000A42 RID: 2626 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014F9")]
				[Address(RVA = "0x44394C", Offset = "0x44394C", VA = "0x644394C")]
				public <PeersConnected>c__AnonStorey2()
				{
				}

				// Token: 0x06000A43 RID: 2627 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014FA")]
				[Address(RVA = "0x443B38", Offset = "0x443B38", VA = "0x6443B38")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000461 RID: 1121
				[Token(Token = "0x4001386")]
				[FieldOffset(Offset = "0x8")]
				internal string[] participantIds;

				// Token: 0x04000462 RID: 1122
				[Token(Token = "0x4001387")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener $this;
			}

			// Token: 0x0200016C RID: 364
			[Token(Token = "0x20002FE")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA00", Offset = "0x17FA00")]
			private sealed class <PeersDisconnected>c__AnonStorey3
			{
				// Token: 0x06000A44 RID: 2628 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014FB")]
				[Address(RVA = "0x443954", Offset = "0x443954", VA = "0x6443954")]
				public <PeersDisconnected>c__AnonStorey3()
				{
				}

				// Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014FC")]
				[Address(RVA = "0x443C2C", Offset = "0x443C2C", VA = "0x6443C2C")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000463 RID: 1123
				[Token(Token = "0x4001388")]
				[FieldOffset(Offset = "0x8")]
				internal string[] participantIds;

				// Token: 0x04000464 RID: 1124
				[Token(Token = "0x4001389")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener $this;
			}

			// Token: 0x0200016D RID: 365
			[Token(Token = "0x20002FF")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA10", Offset = "0x17FA10")]
			private sealed class <RealTimeMessageReceived>c__AnonStorey4
			{
				// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014FD")]
				[Address(RVA = "0x44395C", Offset = "0x44395C", VA = "0x644395C")]
				public <RealTimeMessageReceived>c__AnonStorey4()
				{
				}

				// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014FE")]
				[Address(RVA = "0x443D20", Offset = "0x443D20", VA = "0x6443D20")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000465 RID: 1125
				[Token(Token = "0x400138A")]
				[FieldOffset(Offset = "0x8")]
				internal bool isReliable;

				// Token: 0x04000466 RID: 1126
				[Token(Token = "0x400138B")]
				[FieldOffset(Offset = "0xC")]
				internal string senderId;

				// Token: 0x04000467 RID: 1127
				[Token(Token = "0x400138C")]
				[FieldOffset(Offset = "0x10")]
				internal byte[] data;

				// Token: 0x04000468 RID: 1128
				[Token(Token = "0x400138D")]
				[FieldOffset(Offset = "0x14")]
				internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener $this;
			}

			// Token: 0x0200016E RID: 366
			[Token(Token = "0x2000300")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA20", Offset = "0x17FA20")]
			private sealed class <ParticipantLeft>c__AnonStorey5
			{
				// Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014FF")]
				[Address(RVA = "0x443964", Offset = "0x443964", VA = "0x6443964")]
				public <ParticipantLeft>c__AnonStorey5()
				{
				}

				// Token: 0x06000A49 RID: 2633 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001500")]
				[Address(RVA = "0x443A44", Offset = "0x443A44", VA = "0x6443A44")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000469 RID: 1129
				[Token(Token = "0x400138E")]
				[FieldOffset(Offset = "0x8")]
				internal Participant participant;

				// Token: 0x0400046A RID: 1130
				[Token(Token = "0x400138F")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener $this;
			}
		}

		// Token: 0x0200016F RID: 367
		[Token(Token = "0x200012E")]
		internal abstract class State
		{
			// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x43F3B0", Offset = "0x43F3B0", VA = "0x643F3B0")]
			protected State()
			{
			}

			// Token: 0x06000A4B RID: 2635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x4449BC", Offset = "0x4449BC", VA = "0x64449BC", Slot = "4")]
			internal virtual void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			// Token: 0x06000A4C RID: 2636 RVA: 0x000052B0 File Offset: 0x000034B0
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x444AC4", Offset = "0x444AC4", VA = "0x6444AC4", Slot = "5")]
			internal virtual bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x444BD0", Offset = "0x444BD0", VA = "0x6444BD0", Slot = "6")]
			internal virtual void LeaveRoom()
			{
			}

			// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x444CD8", Offset = "0x444CD8", VA = "0x6444CD8", Slot = "7")]
			internal virtual void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
			{
			}

			// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x444DE0", Offset = "0x444DE0", VA = "0x6444DE0", Slot = "8")]
			internal virtual void OnStateEntered()
			{
			}

			// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x444EE8", Offset = "0x444EE8", VA = "0x6444EE8", Slot = "9")]
			internal virtual void OnRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x444FF0", Offset = "0x444FF0", VA = "0x6444FF0", Slot = "10")]
			internal virtual void OnConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x4450F8", Offset = "0x4450F8", VA = "0x64450F8", Slot = "11")]
			internal virtual void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x445200", Offset = "0x445200", VA = "0x6445200", Slot = "12")]
			internal virtual void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
			{
			}

			// Token: 0x06000A54 RID: 2644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x445308", Offset = "0x445308", VA = "0x6445308", Slot = "13")]
			internal virtual void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
			{
			}

			// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x445410", Offset = "0x445410", VA = "0x6445410", Slot = "14")]
			internal virtual void SendToAll(byte[] data, int offset, int length, bool isReliable)
			{
			}

			// Token: 0x06000A56 RID: 2646 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x445518", Offset = "0x445518", VA = "0x6445518", Slot = "15")]
			internal virtual List<Participant> GetConnectedParticipants()
			{
				return null;
			}

			// Token: 0x06000A57 RID: 2647 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x445654", Offset = "0x445654", VA = "0x6445654", Slot = "16")]
			internal virtual Participant GetSelf()
			{
				return null;
			}

			// Token: 0x06000A58 RID: 2648 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x445760", Offset = "0x445760", VA = "0x6445760", Slot = "17")]
			internal virtual Participant GetParticipant(string participantId)
			{
				return null;
			}

			// Token: 0x06000A59 RID: 2649 RVA: 0x000052C8 File Offset: 0x000034C8
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x44586C", Offset = "0x44586C", VA = "0x644586C", Slot = "18")]
			internal virtual bool IsRoomConnected()
			{
				return default(bool);
			}
		}

		// Token: 0x02000170 RID: 368
		[Token(Token = "0x200012F")]
		private abstract class MessagingEnabledState : NativeRealtimeMultiplayerClient.State
		{
			// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x43F7F8", Offset = "0x43F7F8", VA = "0x643F7F8")]
			internal MessagingEnabledState(NativeRealtimeMultiplayerClient.RoomSession session, NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x442C9C", Offset = "0x442C9C", VA = "0x6442C9C")]
			internal void UpdateCurrentRoom(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x442F64", Offset = "0x442F64", VA = "0x6442F64", Slot = "9")]
			internal sealed override void OnRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x442F98", Offset = "0x442F98", VA = "0x6442F98", Slot = "19")]
			internal virtual void HandleRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A5E RID: 2654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x442F9C", Offset = "0x442F9C", VA = "0x6442F9C", Slot = "10")]
			internal sealed override void OnConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x442FD0", Offset = "0x442FD0", VA = "0x6442FD0", Slot = "20")]
			internal virtual void HandleConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A60 RID: 2656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x442FD4", Offset = "0x442FD4", VA = "0x6442FD4", Slot = "11")]
			internal sealed override void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			// Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x443008", Offset = "0x443008", VA = "0x6443008", Slot = "21")]
			internal virtual void HandleParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			// Token: 0x06000A62 RID: 2658 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x44300C", Offset = "0x44300C", VA = "0x644300C", Slot = "15")]
			internal sealed override List<Participant> GetConnectedParticipants()
			{
				return null;
			}

			// Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x443168", Offset = "0x443168", VA = "0x6443168", Slot = "13")]
			internal override void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
			{
			}

			// Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x443418", Offset = "0x443418", VA = "0x6443418", Slot = "14")]
			internal override void SendToAll(byte[] data, int offset, int length, bool isReliable)
			{
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x443644", Offset = "0x443644", VA = "0x6443644", Slot = "12")]
			internal override void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
			{
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x4437F8", Offset = "0x4437F8", VA = "0x64437F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18566C", Offset = "0x18566C")]
			private static string <UpdateCurrentRoom>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
			{
				return null;
			}

			// Token: 0x06000A67 RID: 2663 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x443820", Offset = "0x443820", VA = "0x6443820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18567C", Offset = "0x18567C")]
			private static Participant <UpdateCurrentRoom>m__1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
			{
				return null;
			}

			// Token: 0x06000A68 RID: 2664 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x443848", Offset = "0x443848", VA = "0x6443848")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18568C", Offset = "0x18568C")]
			private static string <UpdateCurrentRoom>m__2(Participant p)
			{
				return null;
			}

			// Token: 0x06000A69 RID: 2665 RVA: 0x000052E0 File Offset: 0x000034E0
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x443874", Offset = "0x443874", VA = "0x6443874")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18569C", Offset = "0x18569C")]
			private static bool <GetConnectedParticipants>m__3(Participant p)
			{
				return default(bool);
			}

			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x8")]
			protected readonly NativeRealtimeMultiplayerClient.RoomSession mSession;

			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0xC")]
			protected NativeRealTimeRoom mRoom;

			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x10")]
			protected Dictionary<string, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> mNativeParticipants;

			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x14")]
			protected Dictionary<string, Participant> mParticipants;

			// Token: 0x0400046F RID: 1135
			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E10", Offset = "0x180E10")]
			private static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string> <>f__am$cache0;

			// Token: 0x04000470 RID: 1136
			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0x4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E20", Offset = "0x180E20")]
			private static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant> <>f__am$cache1;

			// Token: 0x04000471 RID: 1137
			[Token(Token = "0x40003B7")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E30", Offset = "0x180E30")]
			private static Func<Participant, string> <>f__am$cache2;

			// Token: 0x04000472 RID: 1138
			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E40", Offset = "0x180E40")]
			private static Func<Participant, bool> <>f__am$cache3;
		}

		// Token: 0x02000171 RID: 369
		[Token(Token = "0x2000130")]
		private class BeforeRoomCreateStartedState : NativeRealtimeMultiplayerClient.State
		{
			// Token: 0x06000A6A RID: 2666 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x44118C", Offset = "0x44118C", VA = "0x644118C")]
			internal BeforeRoomCreateStartedState(NativeRealtimeMultiplayerClient.RoomSession session)
			{
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x441204", Offset = "0x441204", VA = "0x6441204", Slot = "6")]
			internal override void LeaveRoom()
			{
			}

			// Token: 0x04000473 RID: 1139
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x8")]
			private readonly NativeRealtimeMultiplayerClient.RoomSession mContainingSession;
		}

		// Token: 0x02000172 RID: 370
		[Token(Token = "0x2000131")]
		private class RoomCreationPendingState : NativeRealtimeMultiplayerClient.State
		{
			// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x444030", Offset = "0x444030", VA = "0x6444030")]
			internal RoomCreationPendingState(NativeRealtimeMultiplayerClient.RoomSession session)
			{
			}

			// Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x4440A8", Offset = "0x4440A8", VA = "0x64440A8", Slot = "4")]
			internal override void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			// Token: 0x06000A6E RID: 2670 RVA: 0x000052F8 File Offset: 0x000034F8
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x444200", Offset = "0x444200", VA = "0x6444200", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x444208", Offset = "0x444208", VA = "0x6444208", Slot = "6")]
			internal override void LeaveRoom()
			{
			}

			// Token: 0x04000474 RID: 1140
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x8")]
			private readonly NativeRealtimeMultiplayerClient.RoomSession mContainingSession;
		}

		// Token: 0x02000173 RID: 371
		[Token(Token = "0x2000132")]
		private class ConnectingState : NativeRealtimeMultiplayerClient.MessagingEnabledState
		{
			// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x44130C", Offset = "0x44130C", VA = "0x644130C")]
			internal ConnectingState(NativeRealTimeRoom room, NativeRealtimeMultiplayerClient.RoomSession session)
			{
			}

			// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x4413DC", Offset = "0x4413DC", VA = "0x64413DC", Slot = "8")]
			internal override void OnStateEntered()
			{
			}

			// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x441544", Offset = "0x441544", VA = "0x6441544", Slot = "20")]
			internal override void HandleConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x441F98", Offset = "0x441F98", VA = "0x6441F98", Slot = "21")]
			internal override void HandleParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x442284", Offset = "0x442284", VA = "0x6442284", Slot = "6")]
			internal override void LeaveRoom()
			{
			}

			// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x442360", Offset = "0x442360", VA = "0x6442360", Slot = "7")]
			internal override void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
			{
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x44256C", Offset = "0x44256C", VA = "0x644256C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1856AC", Offset = "0x1856AC")]
			private void <LeaveRoom>m__0()
			{
			}

			// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x4425AC", Offset = "0x4425AC", VA = "0x64425AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1856BC", Offset = "0x1856BC")]
			private void <ShowWaitingRoomUI>m__1(RealtimeManager.WaitingRoomUIResponse response)
			{
			}

			// Token: 0x04000475 RID: 1141
			[Token(Token = "0x40003BB")]
			private const float InitialPercentComplete = 20f;

			// Token: 0x04000476 RID: 1142
			[Token(Token = "0x40003BC")]
			[FieldOffset(Offset = "0x0")]
			private static readonly HashSet<Types.ParticipantStatus> FailedStatuses;

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x18")]
			private HashSet<string> mConnectedParticipants;

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x1C")]
			private float mPercentComplete;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x40003BF")]
			[FieldOffset(Offset = "0x20")]
			private float mPercentPerParticipant;
		}

		// Token: 0x02000174 RID: 372
		[Token(Token = "0x2000133")]
		private class ActiveState : NativeRealtimeMultiplayerClient.MessagingEnabledState
		{
			// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x43F7E8", Offset = "0x43F7E8", VA = "0x643F7E8")]
			internal ActiveState(NativeRealTimeRoom room, NativeRealtimeMultiplayerClient.RoomSession session)
			{
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x43F880", Offset = "0x43F880", VA = "0x643F880", Slot = "8")]
			internal override void OnStateEntered()
			{
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x00005310 File Offset: 0x00003510
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x43F940", Offset = "0x43F940", VA = "0x643F940", Slot = "18")]
			internal override bool IsRoomConnected()
			{
				return default(bool);
			}

			// Token: 0x06000A7C RID: 2684 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x43F948", Offset = "0x43F948", VA = "0x643F948", Slot = "17")]
			internal override Participant GetParticipant(string participantId)
			{
				return null;
			}

			// Token: 0x06000A7D RID: 2685 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x43FA94", Offset = "0x43FA94", VA = "0x643FA94", Slot = "16")]
			internal override Participant GetSelf()
			{
				return null;
			}

			// Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x43FCFC", Offset = "0x43FCFC", VA = "0x643FCFC", Slot = "20")]
			internal override void HandleConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x440BF8", Offset = "0x440BF8", VA = "0x6440BF8", Slot = "6")]
			internal override void LeaveRoom()
			{
			}

			// Token: 0x06000A80 RID: 2688 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x440CD4", Offset = "0x440CD4", VA = "0x6440CD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1856CC", Offset = "0x1856CC")]
			private static string <HandleConnectedSetChanged>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
			{
				return null;
			}

			// Token: 0x06000A81 RID: 2689 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x440DB8", Offset = "0x440DB8", VA = "0x6440DB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1856DC", Offset = "0x1856DC")]
			private static Participant <HandleConnectedSetChanged>m__1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
			{
				return null;
			}

			// Token: 0x06000A82 RID: 2690 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x440F54", Offset = "0x440F54", VA = "0x6440F54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1856EC", Offset = "0x1856EC")]
			private static string <HandleConnectedSetChanged>m__2(Participant p)
			{
				return null;
			}

			// Token: 0x06000A83 RID: 2691 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x440F80", Offset = "0x440F80", VA = "0x6440F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1856FC", Offset = "0x1856FC")]
			private static string <HandleConnectedSetChanged>m__3(Participant p)
			{
				return null;
			}

			// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x440FB4", Offset = "0x440FB4", VA = "0x6440FB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18570C", Offset = "0x18570C")]
			private void <LeaveRoom>m__4()
			{
			}

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x40003C0")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E50", Offset = "0x180E50")]
			private static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string> <>f__am$cache0;

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x40003C1")]
			[FieldOffset(Offset = "0x4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E60", Offset = "0x180E60")]
			private static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant> <>f__am$cache1;

			// Token: 0x0400047C RID: 1148
			[Token(Token = "0x40003C2")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E70", Offset = "0x180E70")]
			private static Func<Participant, string> <>f__am$cache2;

			// Token: 0x0400047D RID: 1149
			[Token(Token = "0x40003C3")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E80", Offset = "0x180E80")]
			private static Func<Participant, string> <>f__am$cache3;

			// Token: 0x02000175 RID: 373
			[Token(Token = "0x2000301")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA30", Offset = "0x17FA30")]
			private sealed class <HandleConnectedSetChanged>c__AnonStorey0
			{
				// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001501")]
				[Address(RVA = "0x44094C", Offset = "0x44094C", VA = "0x644094C")]
				public <HandleConnectedSetChanged>c__AnonStorey0()
				{
				}

				// Token: 0x06000A86 RID: 2694 RVA: 0x00005328 File Offset: 0x00003528
				[Token(Token = "0x6001502")]
				[Address(RVA = "0x4410AC", Offset = "0x4410AC", VA = "0x64410AC")]
				internal bool <>m__0(string peerId)
				{
					return default(bool);
				}

				// Token: 0x06000A87 RID: 2695 RVA: 0x00005340 File Offset: 0x00003540
				[Token(Token = "0x6001503")]
				[Address(RVA = "0x4410E4", Offset = "0x4410E4", VA = "0x64410E4")]
				internal bool <>m__1(string peerId)
				{
					return default(bool);
				}

				// Token: 0x06000A88 RID: 2696 RVA: 0x00005358 File Offset: 0x00003558
				[Token(Token = "0x6001504")]
				[Address(RVA = "0x44111C", Offset = "0x44111C", VA = "0x644111C")]
				internal bool <>m__2(string peer)
				{
					return default(bool);
				}

				// Token: 0x06000A89 RID: 2697 RVA: 0x00005370 File Offset: 0x00003570
				[Token(Token = "0x6001505")]
				[Address(RVA = "0x441154", Offset = "0x441154", VA = "0x6441154")]
				internal bool <>m__3(string peer)
				{
					return default(bool);
				}

				// Token: 0x0400047E RID: 1150
				[Token(Token = "0x4001390")]
				[FieldOffset(Offset = "0x8")]
				internal string selfId;
			}
		}

		// Token: 0x02000176 RID: 374
		[Token(Token = "0x2000134")]
		private class ShutdownState : NativeRealtimeMultiplayerClient.State
		{
			// Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x43F55C", Offset = "0x43F55C", VA = "0x643F55C")]
			internal ShutdownState(NativeRealtimeMultiplayerClient.RoomSession session)
			{
			}

			// Token: 0x06000A8B RID: 2699 RVA: 0x00005388 File Offset: 0x00003588
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x444978", Offset = "0x444978", VA = "0x6444978", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x444980", Offset = "0x444980", VA = "0x6444980", Slot = "6")]
			internal override void LeaveRoom()
			{
			}

			// Token: 0x0400047F RID: 1151
			[Token(Token = "0x40003C4")]
			[FieldOffset(Offset = "0x8")]
			private readonly NativeRealtimeMultiplayerClient.RoomSession mSession;
		}

		// Token: 0x02000177 RID: 375
		[Token(Token = "0x2000135")]
		private class LeavingRoom : NativeRealtimeMultiplayerClient.State
		{
			// Token: 0x06000A8D RID: 2701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x43F6F0", Offset = "0x43F6F0", VA = "0x643F6F0")]
			internal LeavingRoom(NativeRealtimeMultiplayerClient.RoomSession session, NativeRealTimeRoom room, Action leavingCompleteCallback)
			{
			}

			// Token: 0x06000A8E RID: 2702 RVA: 0x000053A0 File Offset: 0x000035A0
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x442B14", Offset = "0x442B14", VA = "0x6442B14", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06000A8F RID: 2703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x442B1C", Offset = "0x442B1C", VA = "0x6442B1C", Slot = "8")]
			internal override void OnStateEntered()
			{
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x442BEC", Offset = "0x442BEC", VA = "0x6442BEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18571C", Offset = "0x18571C")]
			private void <OnStateEntered>m__0(CommonErrorStatus.ResponseStatus status)
			{
			}

			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x40003C5")]
			[FieldOffset(Offset = "0x8")]
			private readonly NativeRealtimeMultiplayerClient.RoomSession mSession;

			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x40003C6")]
			[FieldOffset(Offset = "0xC")]
			private readonly NativeRealTimeRoom mRoomToLeave;

			// Token: 0x04000482 RID: 1154
			[Token(Token = "0x40003C7")]
			[FieldOffset(Offset = "0x10")]
			private readonly Action mLeavingCompleteCallback;
		}

		// Token: 0x02000178 RID: 376
		[Token(Token = "0x2000136")]
		private class AbortingRoomCreationState : NativeRealtimeMultiplayerClient.State
		{
			// Token: 0x06000A91 RID: 2705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x43F338", Offset = "0x43F338", VA = "0x643F338")]
			internal AbortingRoomCreationState(NativeRealtimeMultiplayerClient.RoomSession session)
			{
			}

			// Token: 0x06000A92 RID: 2706 RVA: 0x000053B8 File Offset: 0x000035B8
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x43F3B8", Offset = "0x43F3B8", VA = "0x643F3B8", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06000A93 RID: 2707 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x43F3C0", Offset = "0x43F3C0", VA = "0x643F3C0", Slot = "4")]
			internal override void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			// Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x43F7A8", Offset = "0x43F7A8", VA = "0x643F7A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18572C", Offset = "0x18572C")]
			private void <HandleRoomResponse>m__0()
			{
			}

			// Token: 0x04000483 RID: 1155
			[Token(Token = "0x40003C8")]
			[FieldOffset(Offset = "0x8")]
			private readonly NativeRealtimeMultiplayerClient.RoomSession mSession;
		}

		// Token: 0x02000179 RID: 377
		[Token(Token = "0x20002F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F920", Offset = "0x17F920")]
		private sealed class <CreateQuickGame>c__AnonStorey2
		{
			// Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E0")]
			[Address(RVA = "0x43D9DC", Offset = "0x43D9DC", VA = "0x643D9DC")]
			public <CreateQuickGame>c__AnonStorey2()
			{
			}

			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x400136E")]
			[FieldOffset(Offset = "0x8")]
			internal NativeRealtimeMultiplayerClient.RoomSession newSession;

			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x400136F")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient $this;
		}

		// Token: 0x0200017A RID: 378
		[Token(Token = "0x20002F1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F930", Offset = "0x17F930")]
		private sealed class <CreateQuickGame>c__AnonStorey0
		{
			// Token: 0x06000A96 RID: 2710 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E1")]
			[Address(RVA = "0x43D8A8", Offset = "0x43D8A8", VA = "0x643D8A8")]
			public <CreateQuickGame>c__AnonStorey0()
			{
			}

			// Token: 0x04000486 RID: 1158
			[Token(Token = "0x4001370")]
			[FieldOffset(Offset = "0x8")]
			internal RealtimeRoomConfig config;
		}

		// Token: 0x0200017B RID: 379
		[Token(Token = "0x20002F2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F940", Offset = "0x17F940")]
		private sealed class <CreateQuickGame>c__AnonStorey1
		{
			// Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E2")]
			[Address(RVA = "0x43D8B0", Offset = "0x43D8B0", VA = "0x643D8B0")]
			public <CreateQuickGame>c__AnonStorey1()
			{
			}

			// Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E3")]
			[Address(RVA = "0x43D8B8", Offset = "0x43D8B8", VA = "0x643D8B8")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000487 RID: 1159
			[Token(Token = "0x4001371")]
			[FieldOffset(Offset = "0x8")]
			internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4001372")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey2 <>f__ref$2;

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4001373")]
			[FieldOffset(Offset = "0x10")]
			internal NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey0 <>f__ref$0;
		}

		// Token: 0x0200017C RID: 380
		[Token(Token = "0x20002F3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F950", Offset = "0x17F950")]
		private sealed class <HelperForSession>c__AnonStorey3
		{
			// Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E4")]
			[Address(RVA = "0x43EFE0", Offset = "0x43EFE0", VA = "0x643EFE0")]
			public <HelperForSession>c__AnonStorey3()
			{
			}

			// Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E5")]
			[Address(RVA = "0x43EFE8", Offset = "0x43EFE8", VA = "0x643EFE8")]
			internal void <>m__0(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant, byte[] data, bool isReliable)
			{
			}

			// Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E6")]
			[Address(RVA = "0x43F09C", Offset = "0x43F09C", VA = "0x643F09C")]
			internal void <>m__1(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			// Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E7")]
			[Address(RVA = "0x43F188", Offset = "0x43F188", VA = "0x643F188")]
			internal void <>m__2(NativeRealTimeRoom room)
			{
			}

			// Token: 0x06000A9D RID: 2717 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E8")]
			[Address(RVA = "0x43F260", Offset = "0x43F260", VA = "0x643F260")]
			internal void <>m__3(NativeRealTimeRoom room)
			{
			}

			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x4001374")]
			[FieldOffset(Offset = "0x8")]
			internal NativeRealtimeMultiplayerClient.RoomSession session;
		}

		// Token: 0x0200017D RID: 381
		[Token(Token = "0x20002F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F960", Offset = "0x17F960")]
		private sealed class <CreateWithInvitationScreen>c__AnonStorey5
		{
			// Token: 0x06000A9E RID: 2718 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014E9")]
			[Address(RVA = "0x43E280", Offset = "0x43E280", VA = "0x643E280")]
			public <CreateWithInvitationScreen>c__AnonStorey5()
			{
			}

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x4001375")]
			[FieldOffset(Offset = "0x8")]
			internal uint variant;

			// Token: 0x0400048C RID: 1164
			[Token(Token = "0x4001376")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient $this;
		}

		// Token: 0x0200017E RID: 382
		[Token(Token = "0x20002F5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F970", Offset = "0x17F970")]
		private sealed class <CreateWithInvitationScreen>c__AnonStorey4
		{
			// Token: 0x06000A9F RID: 2719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014EA")]
			[Address(RVA = "0x43D9E4", Offset = "0x43D9E4", VA = "0x643D9E4")]
			public <CreateWithInvitationScreen>c__AnonStorey4()
			{
			}

			// Token: 0x06000AA0 RID: 2720 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014EB")]
			[Address(RVA = "0x43D9EC", Offset = "0x43D9EC", VA = "0x643D9EC")]
			internal void <>m__0(PlayerSelectUIResponse response)
			{
			}

			// Token: 0x0400048D RID: 1165
			[Token(Token = "0x4001377")]
			[FieldOffset(Offset = "0x8")]
			internal NativeRealtimeMultiplayerClient.RoomSession newRoom;

			// Token: 0x0400048E RID: 1166
			[Token(Token = "0x4001378")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey5 <>f__ref$5;

			// Token: 0x0200017F RID: 383
			[Token(Token = "0x2000302")]
			private sealed class <CreateWithInvitationScreen>c__AnonStorey6
			{
				// Token: 0x06000AA1 RID: 2721 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001506")]
				[Address(RVA = "0x43E14C", Offset = "0x43E14C", VA = "0x643E14C")]
				public <CreateWithInvitationScreen>c__AnonStorey6()
				{
				}

				// Token: 0x0400048F RID: 1167
				[Token(Token = "0x4001391")]
				[FieldOffset(Offset = "0x8")]
				internal RealtimeRoomConfig config;
			}

			// Token: 0x02000180 RID: 384
			[Token(Token = "0x2000303")]
			private sealed class <CreateWithInvitationScreen>c__AnonStorey7
			{
				// Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001507")]
				[Address(RVA = "0x43E154", Offset = "0x43E154", VA = "0x643E154")]
				public <CreateWithInvitationScreen>c__AnonStorey7()
				{
				}

				// Token: 0x06000AA3 RID: 2723 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001508")]
				[Address(RVA = "0x43E15C", Offset = "0x43E15C", VA = "0x643E15C")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000490 RID: 1168
				[Token(Token = "0x4001392")]
				[FieldOffset(Offset = "0x8")]
				internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

				// Token: 0x04000491 RID: 1169
				[Token(Token = "0x4001393")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey5 <>f__ref$5;

				// Token: 0x04000492 RID: 1170
				[Token(Token = "0x4001394")]
				[FieldOffset(Offset = "0x10")]
				internal NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4 <>f__ref$4;

				// Token: 0x04000493 RID: 1171
				[Token(Token = "0x4001395")]
				[FieldOffset(Offset = "0x14")]
				internal NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey6 <>f__ref$6;
			}
		}

		// Token: 0x02000181 RID: 385
		[Token(Token = "0x20002F6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F980", Offset = "0x17F980")]
		private sealed class <GetAllInvitations>c__AnonStorey8
		{
			// Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014EC")]
			[Address(RVA = "0x43E7D4", Offset = "0x43E7D4", VA = "0x643E7D4")]
			public <GetAllInvitations>c__AnonStorey8()
			{
			}

			// Token: 0x06000AA5 RID: 2725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x43E7DC", Offset = "0x43E7DC", VA = "0x643E7DC")]
			internal void <>m__0(RealtimeManager.FetchInvitationsResponse response)
			{
			}

			// Token: 0x04000494 RID: 1172
			[Token(Token = "0x4001379")]
			[FieldOffset(Offset = "0x8")]
			internal Action<Invitation[]> callback;
		}

		// Token: 0x02000182 RID: 386
		[Token(Token = "0x20002F7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F990", Offset = "0x17F990")]
		private sealed class <AcceptFromInbox>c__AnonStorey9
		{
			// Token: 0x06000AA6 RID: 2726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x6E57F0", Offset = "0x6E57F0", VA = "0x66E57F0")]
			public <AcceptFromInbox>c__AnonStorey9()
			{
			}

			// Token: 0x06000AA7 RID: 2727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014EF")]
			[Address(RVA = "0x6E5DFC", Offset = "0x6E5DFC", VA = "0x66E5DFC")]
			internal void <>m__0(RealtimeManager.RoomInboxUIResponse response)
			{
			}

			// Token: 0x04000495 RID: 1173
			[Token(Token = "0x400137A")]
			[FieldOffset(Offset = "0x8")]
			internal NativeRealtimeMultiplayerClient.RoomSession newRoom;

			// Token: 0x04000496 RID: 1174
			[Token(Token = "0x400137B")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient $this;

			// Token: 0x02000183 RID: 387
			[Token(Token = "0x2000304")]
			private sealed class <AcceptFromInbox>c__AnonStoreyA
			{
				// Token: 0x06000AA8 RID: 2728 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001509")]
				[Address(RVA = "0x6E61FC", Offset = "0x6E61FC", VA = "0x66E61FC")]
				public <AcceptFromInbox>c__AnonStoreyA()
				{
				}

				// Token: 0x04000497 RID: 1175
				[Token(Token = "0x4001396")]
				[FieldOffset(Offset = "0x8")]
				internal GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation;

				// Token: 0x04000498 RID: 1176
				[Token(Token = "0x4001397")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9 <>f__ref$9;
			}

			// Token: 0x02000184 RID: 388
			[Token(Token = "0x2000305")]
			private sealed class <AcceptFromInbox>c__AnonStoreyB
			{
				// Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600150A")]
				[Address(RVA = "0x6E6204", Offset = "0x6E6204", VA = "0x66E6204")]
				public <AcceptFromInbox>c__AnonStoreyB()
				{
				}

				// Token: 0x06000AAA RID: 2730 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600150B")]
				[Address(RVA = "0x6E620C", Offset = "0x6E620C", VA = "0x66E620C")]
				internal void <>m__0()
				{
				}

				// Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600150C")]
				[Address(RVA = "0x6E6318", Offset = "0x6E6318", VA = "0x66E6318")]
				internal void <>m__1(RealtimeManager.RealTimeRoomResponse acceptResponse)
				{
				}

				// Token: 0x04000499 RID: 1177
				[Token(Token = "0x4001398")]
				[FieldOffset(Offset = "0x8")]
				internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

				// Token: 0x0400049A RID: 1178
				[Token(Token = "0x4001399")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9 <>f__ref$9;

				// Token: 0x0400049B RID: 1179
				[Token(Token = "0x400139A")]
				[FieldOffset(Offset = "0x10")]
				internal NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyA <>f__ref$10;
			}
		}

		// Token: 0x02000185 RID: 389
		[Token(Token = "0x20002F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F9A0", Offset = "0x17F9A0")]
		private sealed class <AcceptInvitation>c__AnonStoreyD
		{
			// Token: 0x06000AAC RID: 2732 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014F0")]
			[Address(RVA = "0x43D8A0", Offset = "0x43D8A0", VA = "0x643D8A0")]
			public <AcceptInvitation>c__AnonStoreyD()
			{
			}

			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400137C")]
			[FieldOffset(Offset = "0x8")]
			internal string invitationId;

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400137D")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient $this;
		}

		// Token: 0x02000186 RID: 390
		[Token(Token = "0x20002F9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F9B0", Offset = "0x17F9B0")]
		private sealed class <AcceptInvitation>c__AnonStoreyC
		{
			// Token: 0x06000AAD RID: 2733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014F1")]
			[Address(RVA = "0x43C730", Offset = "0x43C730", VA = "0x643C730")]
			public <AcceptInvitation>c__AnonStoreyC()
			{
			}

			// Token: 0x06000AAE RID: 2734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014F2")]
			[Address(RVA = "0x43C738", Offset = "0x43C738", VA = "0x643C738")]
			internal void <>m__0(RealtimeManager.FetchInvitationsResponse response)
			{
			}

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400137E")]
			[FieldOffset(Offset = "0x8")]
			internal NativeRealtimeMultiplayerClient.RoomSession newRoom;

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400137F")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD <>f__ref$13;

			// Token: 0x02000187 RID: 391
			[Token(Token = "0x2000306")]
			private sealed class <AcceptInvitation>c__AnonStoreyE
			{
				// Token: 0x06000AAF RID: 2735 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600150D")]
				[Address(RVA = "0x43D414", Offset = "0x43D414", VA = "0x643D414")]
				public <AcceptInvitation>c__AnonStoreyE()
				{
				}

				// Token: 0x040004A0 RID: 1184
				[Token(Token = "0x400139B")]
				[FieldOffset(Offset = "0x8")]
				internal GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation;

				// Token: 0x040004A1 RID: 1185
				[Token(Token = "0x400139C")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD <>f__ref$13;

				// Token: 0x040004A2 RID: 1186
				[Token(Token = "0x400139D")]
				[FieldOffset(Offset = "0x10")]
				internal NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC <>f__ref$12;
			}

			// Token: 0x02000188 RID: 392
			[Token(Token = "0x2000307")]
			private sealed class <AcceptInvitation>c__AnonStoreyF
			{
				// Token: 0x06000AB0 RID: 2736 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600150E")]
				[Address(RVA = "0x43D550", Offset = "0x43D550", VA = "0x643D550")]
				public <AcceptInvitation>c__AnonStoreyF()
				{
				}

				// Token: 0x06000AB1 RID: 2737 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600150F")]
				[Address(RVA = "0x43D77C", Offset = "0x43D77C", VA = "0x643D77C")]
				internal void <>m__0()
				{
				}

				// Token: 0x040004A3 RID: 1187
				[Token(Token = "0x400139E")]
				[FieldOffset(Offset = "0x8")]
				internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

				// Token: 0x040004A4 RID: 1188
				[Token(Token = "0x400139F")]
				[FieldOffset(Offset = "0xC")]
				internal NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD <>f__ref$13;

				// Token: 0x040004A5 RID: 1189
				[Token(Token = "0x40013A0")]
				[FieldOffset(Offset = "0x10")]
				internal NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC <>f__ref$12;

				// Token: 0x040004A6 RID: 1190
				[Token(Token = "0x40013A1")]
				[FieldOffset(Offset = "0x14")]
				internal NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyE <>f__ref$14;
			}
		}

		// Token: 0x02000189 RID: 393
		[Token(Token = "0x20002FA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F9C0", Offset = "0x17F9C0")]
		private sealed class <DeclineInvitation>c__AnonStorey10
		{
			// Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014F3")]
			[Address(RVA = "0x43E288", Offset = "0x43E288", VA = "0x643E288")]
			public <DeclineInvitation>c__AnonStorey10()
			{
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014F4")]
			[Address(RVA = "0x43E290", Offset = "0x43E290", VA = "0x643E290")]
			internal void <>m__0(RealtimeManager.FetchInvitationsResponse response)
			{
			}

			// Token: 0x040004A7 RID: 1191
			[Token(Token = "0x4001380")]
			[FieldOffset(Offset = "0x8")]
			internal string invitationId;

			// Token: 0x040004A8 RID: 1192
			[Token(Token = "0x4001381")]
			[FieldOffset(Offset = "0xC")]
			internal NativeRealtimeMultiplayerClient $this;
		}
	}
}
