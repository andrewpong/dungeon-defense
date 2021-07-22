using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000DA")]
	internal static class RealTimeMultiplayerManager
	{
		// Token: 0x06000819 RID: 2073
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x6C6968", Offset = "0x6C6968", VA = "0x66C6968")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_CreateRealTimeRoom(HandleRef self, IntPtr config, IntPtr helper, RealTimeMultiplayerManager.RealTimeRoomCallback callback, IntPtr callback_arg);

		// Token: 0x0600081A RID: 2074
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x6C6A88", Offset = "0x6C6A88", VA = "0x66C6A88")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_LeaveRoom(HandleRef self, IntPtr room, RealTimeMultiplayerManager.LeaveRoomCallback callback, IntPtr callback_arg);

		// Token: 0x0600081B RID: 2075
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x6C6B98", Offset = "0x6C6B98", VA = "0x66C6B98")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_SendUnreliableMessage(HandleRef self, IntPtr room, IntPtr[] participants, UIntPtr participants_size, byte[] data, UIntPtr data_size);

		// Token: 0x0600081C RID: 2076
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x6C6CC0", Offset = "0x6C6CC0", VA = "0x66C6CC0")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_ShowWaitingRoomUI(HandleRef self, IntPtr room, uint min_participants_to_start, RealTimeMultiplayerManager.WaitingRoomUICallback callback, IntPtr callback_arg);

		// Token: 0x0600081D RID: 2077
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x6C6DE0", Offset = "0x6C6DE0", VA = "0x66C6DE0")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_ShowPlayerSelectUI(HandleRef self, uint minimum_players, uint maximum_players, bool allow_automatch, RealTimeMultiplayerManager.PlayerSelectUICallback callback, IntPtr callback_arg);

		// Token: 0x0600081E RID: 2078
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x6C6F00", Offset = "0x6C6F00", VA = "0x66C6F00")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_DismissInvitation(HandleRef self, IntPtr invitation);

		// Token: 0x0600081F RID: 2079
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x6C6FF8", Offset = "0x6C6FF8", VA = "0x66C6FF8")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_DeclineInvitation(HandleRef self, IntPtr invitation);

		// Token: 0x06000820 RID: 2080
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x6C70F0", Offset = "0x6C70F0", VA = "0x66C70F0")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_SendReliableMessage(HandleRef self, IntPtr room, IntPtr participant, byte[] data, UIntPtr data_size, RealTimeMultiplayerManager.SendReliableMessageCallback callback, IntPtr callback_arg);

		// Token: 0x06000821 RID: 2081
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x6C7220", Offset = "0x6C7220", VA = "0x66C7220")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_AcceptInvitation(HandleRef self, IntPtr invitation, IntPtr helper, RealTimeMultiplayerManager.RealTimeRoomCallback callback, IntPtr callback_arg);

		// Token: 0x06000822 RID: 2082
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x6C7338", Offset = "0x6C7338", VA = "0x66C7338")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_FetchInvitations(HandleRef self, RealTimeMultiplayerManager.FetchInvitationsCallback callback, IntPtr callback_arg);

		// Token: 0x06000823 RID: 2083
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x6C7440", Offset = "0x6C7440", VA = "0x66C7440")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_SendUnreliableMessageToOthers(HandleRef self, IntPtr room, byte[] data, UIntPtr data_size);

		// Token: 0x06000824 RID: 2084
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x6C7558", Offset = "0x6C7558", VA = "0x66C7558")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_ShowRoomInboxUI(HandleRef self, RealTimeMultiplayerManager.RoomInboxUICallback callback, IntPtr callback_arg);

		// Token: 0x06000825 RID: 2085
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x6C7660", Offset = "0x6C7660", VA = "0x66C7660")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_RealTimeRoomResponse_Dispose(HandleRef self);

		// Token: 0x06000826 RID: 2086
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x6C7758", Offset = "0x6C7758", VA = "0x66C7758")]
		[PreserveSig]
		internal static extern CommonErrorStatus.MultiplayerStatus RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(HandleRef self);

		// Token: 0x06000827 RID: 2087
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x6C7858", Offset = "0x6C7858", VA = "0x66C7858")]
		[PreserveSig]
		internal static extern IntPtr RealTimeMultiplayerManager_RealTimeRoomResponse_GetRoom(HandleRef self);

		// Token: 0x06000828 RID: 2088
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x6C7950", Offset = "0x6C7950", VA = "0x66C7950")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_RoomInboxUIResponse_Dispose(HandleRef self);

		// Token: 0x06000829 RID: 2089
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x6C7A48", Offset = "0x6C7A48", VA = "0x66C7A48")]
		[PreserveSig]
		internal static extern CommonErrorStatus.UIStatus RealTimeMultiplayerManager_RoomInboxUIResponse_GetStatus(HandleRef self);

		// Token: 0x0600082A RID: 2090
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x6C7B48", Offset = "0x6C7B48", VA = "0x66C7B48")]
		[PreserveSig]
		internal static extern IntPtr RealTimeMultiplayerManager_RoomInboxUIResponse_GetInvitation(HandleRef self);

		// Token: 0x0600082B RID: 2091
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x6C7C48", Offset = "0x6C7C48", VA = "0x66C7C48")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_WaitingRoomUIResponse_Dispose(HandleRef self);

		// Token: 0x0600082C RID: 2092
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x6C7D48", Offset = "0x6C7D48", VA = "0x66C7D48")]
		[PreserveSig]
		internal static extern CommonErrorStatus.UIStatus RealTimeMultiplayerManager_WaitingRoomUIResponse_GetStatus(HandleRef self);

		// Token: 0x0600082D RID: 2093
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x6C7E48", Offset = "0x6C7E48", VA = "0x66C7E48")]
		[PreserveSig]
		internal static extern IntPtr RealTimeMultiplayerManager_WaitingRoomUIResponse_GetRoom(HandleRef self);

		// Token: 0x0600082E RID: 2094
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x6C7F48", Offset = "0x6C7F48", VA = "0x66C7F48")]
		[PreserveSig]
		internal static extern void RealTimeMultiplayerManager_FetchInvitationsResponse_Dispose(HandleRef self);

		// Token: 0x0600082F RID: 2095
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x6C8048", Offset = "0x6C8048", VA = "0x66C8048")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus RealTimeMultiplayerManager_FetchInvitationsResponse_GetStatus(HandleRef self);

		// Token: 0x06000830 RID: 2096
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x6C8148", Offset = "0x6C8148", VA = "0x66C8148")]
		[PreserveSig]
		internal static extern UIntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_Length(HandleRef self);

		// Token: 0x06000831 RID: 2097
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x6C8210", Offset = "0x6C8210", VA = "0x66C8210")]
		[PreserveSig]
		internal static extern IntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x06000833 RID: 2099
		[Token(Token = "0x20000DB")]
		internal delegate void RealTimeRoomCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x06000837 RID: 2103
		[Token(Token = "0x20000DC")]
		internal delegate void LeaveRoomCallback(CommonErrorStatus.ResponseStatus arg0, IntPtr arg1);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x0600083B RID: 2107
		[Token(Token = "0x20000DD")]
		internal delegate void SendReliableMessageCallback(CommonErrorStatus.MultiplayerStatus arg0, IntPtr arg1);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x0600083F RID: 2111
		[Token(Token = "0x20000DE")]
		internal delegate void RoomInboxUICallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x06000843 RID: 2115
		[Token(Token = "0x20000DF")]
		internal delegate void PlayerSelectUICallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x06000847 RID: 2119
		[Token(Token = "0x20000E0")]
		internal delegate void WaitingRoomUICallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x0600084B RID: 2123
		[Token(Token = "0x20000E1")]
		internal delegate void FetchInvitationsCallback(IntPtr arg0, IntPtr arg1);
	}
}
