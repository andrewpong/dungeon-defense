using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000D3")]
	internal static class RealTimeEventListenerHelper
	{
		// Token: 0x060007F9 RID: 2041
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x6C4DF0", Offset = "0x6C4DF0", VA = "0x66C4DF0")]
		[PreserveSig]
		internal static extern void RealTimeEventListenerHelper_SetOnParticipantStatusChangedCallback(HandleRef self, RealTimeEventListenerHelper.OnParticipantStatusChangedCallback callback, IntPtr callback_arg);

		// Token: 0x060007FA RID: 2042
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x6C4ED8", Offset = "0x6C4ED8", VA = "0x66C4ED8")]
		[PreserveSig]
		internal static extern IntPtr RealTimeEventListenerHelper_Construct();

		// Token: 0x060007FB RID: 2043
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x6C4FB0", Offset = "0x6C4FB0", VA = "0x66C4FB0")]
		[PreserveSig]
		internal static extern void RealTimeEventListenerHelper_SetOnP2PDisconnectedCallback(HandleRef self, RealTimeEventListenerHelper.OnP2PDisconnectedCallback callback, IntPtr callback_arg);

		// Token: 0x060007FC RID: 2044
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x6C50C8", Offset = "0x6C50C8", VA = "0x66C50C8")]
		[PreserveSig]
		internal static extern void RealTimeEventListenerHelper_SetOnDataReceivedCallback(HandleRef self, RealTimeEventListenerHelper.OnDataReceivedCallback callback, IntPtr callback_arg);

		// Token: 0x060007FD RID: 2045
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x6C51E0", Offset = "0x6C51E0", VA = "0x66C51E0")]
		[PreserveSig]
		internal static extern void RealTimeEventListenerHelper_SetOnRoomStatusChangedCallback(HandleRef self, RealTimeEventListenerHelper.OnRoomStatusChangedCallback callback, IntPtr callback_arg);

		// Token: 0x060007FE RID: 2046
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x6C52F8", Offset = "0x6C52F8", VA = "0x66C52F8")]
		[PreserveSig]
		internal static extern void RealTimeEventListenerHelper_SetOnP2PConnectedCallback(HandleRef self, RealTimeEventListenerHelper.OnP2PConnectedCallback callback, IntPtr callback_arg);

		// Token: 0x060007FF RID: 2047
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x6C5410", Offset = "0x6C5410", VA = "0x66C5410")]
		[PreserveSig]
		internal static extern void RealTimeEventListenerHelper_SetOnRoomConnectedSetChangedCallback(HandleRef self, RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback callback, IntPtr callback_arg);

		// Token: 0x06000800 RID: 2048
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x6C54F8", Offset = "0x6C54F8", VA = "0x66C54F8")]
		[PreserveSig]
		internal static extern void RealTimeEventListenerHelper_Dispose(HandleRef self);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x06000802 RID: 2050
		[Token(Token = "0x20000D4")]
		internal delegate void OnRoomStatusChangedCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x06000806 RID: 2054
		[Token(Token = "0x20000D5")]
		internal delegate void OnRoomConnectedSetChangedCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x0600080A RID: 2058
		[Token(Token = "0x20000D6")]
		internal delegate void OnP2PConnectedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x0600080E RID: 2062
		[Token(Token = "0x20000D7")]
		internal delegate void OnP2PDisconnectedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x06000812 RID: 2066
		[Token(Token = "0x20000D8")]
		internal delegate void OnParticipantStatusChangedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x06000816 RID: 2070
		[Token(Token = "0x20000D9")]
		internal delegate void OnDataReceivedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2, UIntPtr arg3, bool arg4, IntPtr arg5);
	}
}
