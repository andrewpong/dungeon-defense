using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x200017A")]
	internal class RealtimeManager
	{
		// Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x483B4C", Offset = "0x483B4C", VA = "0x6483B4C")]
		internal RealtimeManager(GameServices gameServices)
		{
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x483BC4", Offset = "0x483BC4", VA = "0x6483BC4")]
		internal void CreateRoom(RealtimeRoomConfig config, RealTimeEventListenerHelper helper, Action<RealtimeManager.RealTimeRoomResponse> callback)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x483E4C", Offset = "0x483E4C", VA = "0x6483E4C")]
		internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, Action<PlayerSelectUIResponse> callback)
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x483390", Offset = "0x483390", VA = "0x6483390")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186914", Offset = "0x186914")]
		internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x48343C", Offset = "0x48343C", VA = "0x648343C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18698C", Offset = "0x18698C")]
		internal static void InternalRealTimeRoomCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x4834E8", Offset = "0x4834E8", VA = "0x64834E8")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186A04", Offset = "0x186A04")]
		internal static void InternalRoomInboxUICallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x484034", Offset = "0x484034", VA = "0x6484034")]
		internal void ShowRoomInboxUI(Action<RealtimeManager.RoomInboxUIResponse> callback)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x484204", Offset = "0x484204", VA = "0x6484204")]
		internal void ShowWaitingRoomUI(NativeRealTimeRoom room, uint minimumParticipantsBeforeStarting, Action<RealtimeManager.WaitingRoomUIResponse> callback)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x483594", Offset = "0x483594", VA = "0x6483594")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186A7C", Offset = "0x186A7C")]
		internal static void InternalWaitingRoomUICallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x483640", Offset = "0x483640", VA = "0x6483640")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186AF4", Offset = "0x186AF4")]
		internal static void InternalFetchInvitationsCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x484418", Offset = "0x484418", VA = "0x6484418")]
		internal void FetchInvitations(Action<RealtimeManager.FetchInvitationsResponse> callback)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x4836EC", Offset = "0x4836EC", VA = "0x64836EC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186B6C", Offset = "0x186B6C")]
		internal static void InternalLeaveRoomCallback(CommonErrorStatus.ResponseStatus response, IntPtr data)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x4845E8", Offset = "0x4845E8", VA = "0x64845E8")]
		internal void LeaveRoom(NativeRealTimeRoom room, Action<CommonErrorStatus.ResponseStatus> callback)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x48475C", Offset = "0x48475C", VA = "0x648475C")]
		internal void AcceptInvitation(MultiplayerInvitation invitation, RealTimeEventListenerHelper listener, Action<RealtimeManager.RealTimeRoomResponse> callback)
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x4848C8", Offset = "0x4848C8", VA = "0x64848C8")]
		internal void DeclineInvitation(MultiplayerInvitation invitation)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x484930", Offset = "0x484930", VA = "0x6484930")]
		internal void SendReliableMessage(NativeRealTimeRoom room, MultiplayerParticipant participant, byte[] data, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x4838E8", Offset = "0x4838E8", VA = "0x64838E8")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186BE4", Offset = "0x186BE4")]
		internal static void InternalSendReliableMessageCallback(CommonErrorStatus.MultiplayerStatus response, IntPtr data)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x484B20", Offset = "0x484B20", VA = "0x6484B20")]
		internal void SendUnreliableMessageToAll(NativeRealTimeRoom room, byte[] data)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x484C24", Offset = "0x484C24", VA = "0x6484C24")]
		internal void SendUnreliableMessageToSpecificParticipants(NativeRealTimeRoom room, List<MultiplayerParticipant> recipients, byte[] data)
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x483D34", Offset = "0x483D34", VA = "0x6483D34")]
		private static IntPtr ToCallbackPointer(Action<RealtimeManager.RealTimeRoomResponse> callback)
		{
			return 0;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x484E24", Offset = "0x484E24", VA = "0x6484E24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x186C5C", Offset = "0x186C5C")]
		private static IntPtr <SendUnreliableMessageToSpecificParticipants>m__0(MultiplayerParticipant r)
		{
			return 0;
		}

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly GameServices mGameServices;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811C0", Offset = "0x1811C0")]
		private static RealTimeMultiplayerManager.RealTimeRoomCallback <>f__mg$cache0;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811D0", Offset = "0x1811D0")]
		private static Func<IntPtr, PlayerSelectUIResponse> <>f__mg$cache1;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811E0", Offset = "0x1811E0")]
		private static RealTimeMultiplayerManager.PlayerSelectUICallback <>f__mg$cache2;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811F0", Offset = "0x1811F0")]
		private static Func<IntPtr, RealtimeManager.RoomInboxUIResponse> <>f__mg$cache3;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181200", Offset = "0x181200")]
		private static RealTimeMultiplayerManager.RoomInboxUICallback <>f__mg$cache4;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181210", Offset = "0x181210")]
		private static Func<IntPtr, RealtimeManager.WaitingRoomUIResponse> <>f__mg$cache5;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181220", Offset = "0x181220")]
		private static RealTimeMultiplayerManager.WaitingRoomUICallback <>f__mg$cache6;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181230", Offset = "0x181230")]
		private static Func<IntPtr, RealtimeManager.FetchInvitationsResponse> <>f__mg$cache7;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181240", Offset = "0x181240")]
		private static RealTimeMultiplayerManager.FetchInvitationsCallback <>f__mg$cache8;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181250", Offset = "0x181250")]
		private static RealTimeMultiplayerManager.LeaveRoomCallback <>f__mg$cache9;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181260", Offset = "0x181260")]
		private static RealTimeMultiplayerManager.RealTimeRoomCallback <>f__mg$cacheA;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181270", Offset = "0x181270")]
		private static RealTimeMultiplayerManager.SendReliableMessageCallback <>f__mg$cacheB;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181280", Offset = "0x181280")]
		private static Func<MultiplayerParticipant, IntPtr> <>f__am$cache0;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181290", Offset = "0x181290")]
		private static Func<IntPtr, RealtimeManager.RealTimeRoomResponse> <>f__mg$cacheC;

		// Token: 0x02000202 RID: 514
		[Token(Token = "0x200017B")]
		internal class RealTimeRoomResponse : BaseReferenceHolder
		{
			// Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x4851B0", Offset = "0x4851B0", VA = "0x64851B0")]
			internal RealTimeRoomResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000D98 RID: 3480 RVA: 0x00006330 File Offset: 0x00004530
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x48523C", Offset = "0x48523C", VA = "0x648523C")]
			internal CommonErrorStatus.MultiplayerStatus ResponseStatus()
			{
				return (CommonErrorStatus.MultiplayerStatus)0;
			}

			// Token: 0x06000D99 RID: 3481 RVA: 0x00006348 File Offset: 0x00004548
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x48526C", Offset = "0x48526C", VA = "0x648526C")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000D9A RID: 3482 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0x4852AC", Offset = "0x4852AC", VA = "0x64852AC")]
			internal NativeRealTimeRoom Room()
			{
				return null;
			}

			// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x485358", Offset = "0x485358", VA = "0x6485358", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000D9C RID: 3484 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x485368", Offset = "0x485368", VA = "0x6485368")]
			internal static RealtimeManager.RealTimeRoomResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x02000203 RID: 515
		[Token(Token = "0x200017C")]
		internal class RoomInboxUIResponse : BaseReferenceHolder
		{
			// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x48541C", Offset = "0x48541C", VA = "0x648541C")]
			internal RoomInboxUIResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000D9E RID: 3486 RVA: 0x00006360 File Offset: 0x00004560
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x4854A8", Offset = "0x4854A8", VA = "0x64854A8")]
			internal CommonErrorStatus.UIStatus ResponseStatus()
			{
				return (CommonErrorStatus.UIStatus)0;
			}

			// Token: 0x06000D9F RID: 3487 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x4854D8", Offset = "0x4854D8", VA = "0x64854D8")]
			internal MultiplayerInvitation Invitation()
			{
				return null;
			}

			// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x48559C", Offset = "0x48559C", VA = "0x648559C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DA1 RID: 3489 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x4855AC", Offset = "0x4855AC", VA = "0x64855AC")]
			internal static RealtimeManager.RoomInboxUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x02000204 RID: 516
		[Token(Token = "0x200017D")]
		internal class WaitingRoomUIResponse : BaseReferenceHolder
		{
			// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x48565C", Offset = "0x48565C", VA = "0x648565C")]
			internal WaitingRoomUIResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DA3 RID: 3491 RVA: 0x00006378 File Offset: 0x00004578
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x4856E8", Offset = "0x4856E8", VA = "0x64856E8")]
			internal CommonErrorStatus.UIStatus ResponseStatus()
			{
				return (CommonErrorStatus.UIStatus)0;
			}

			// Token: 0x06000DA4 RID: 3492 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x485718", Offset = "0x485718", VA = "0x6485718")]
			internal NativeRealTimeRoom Room()
			{
				return null;
			}

			// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x4857D8", Offset = "0x4857D8", VA = "0x64857D8", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DA6 RID: 3494 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x4857E8", Offset = "0x4857E8", VA = "0x64857E8")]
			internal static RealtimeManager.WaitingRoomUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x02000205 RID: 517
		[Token(Token = "0x200017E")]
		internal class FetchInvitationsResponse : BaseReferenceHolder
		{
			// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x484E50", Offset = "0x484E50", VA = "0x6484E50")]
			internal FetchInvitationsResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DA8 RID: 3496 RVA: 0x00006390 File Offset: 0x00004590
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x484EDC", Offset = "0x484EDC", VA = "0x6484EDC")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000DA9 RID: 3497 RVA: 0x000063A8 File Offset: 0x000045A8
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x484F1C", Offset = "0x484F1C", VA = "0x6484F1C")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000DAA RID: 3498 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x484F4C", Offset = "0x484F4C", VA = "0x6484F4C")]
			internal IEnumerable<MultiplayerInvitation> Invitations()
			{
				return null;
			}

			// Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x48504C", Offset = "0x48504C", VA = "0x648504C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DAC RID: 3500 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x48505C", Offset = "0x48505C", VA = "0x648505C")]
			internal static RealtimeManager.FetchInvitationsResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			// Token: 0x06000DAD RID: 3501 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x48510C", Offset = "0x48510C", VA = "0x648510C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x186C6C", Offset = "0x186C6C")]
			private MultiplayerInvitation <Invitations>m__0(UIntPtr index)
			{
				return null;
			}
		}
	}
}
