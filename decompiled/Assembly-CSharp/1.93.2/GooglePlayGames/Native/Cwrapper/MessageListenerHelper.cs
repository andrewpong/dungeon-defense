using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000BC")]
	internal static class MessageListenerHelper
	{
		// Token: 0x06000763 RID: 1891
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x9559B0", Offset = "0x9559B0", VA = "0x69559B0")]
		[PreserveSig]
		internal static extern void MessageListenerHelper_SetOnMessageReceivedCallback(HandleRef self, MessageListenerHelper.OnMessageReceivedCallback callback, IntPtr callback_arg);

		// Token: 0x06000764 RID: 1892
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x955AC0", Offset = "0x955AC0", VA = "0x6955AC0")]
		[PreserveSig]
		internal static extern void MessageListenerHelper_SetOnDisconnectedCallback(HandleRef self, MessageListenerHelper.OnDisconnectedCallback callback, IntPtr callback_arg);

		// Token: 0x06000765 RID: 1893
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x955BD0", Offset = "0x955BD0", VA = "0x6955BD0")]
		[PreserveSig]
		internal static extern IntPtr MessageListenerHelper_Construct();

		// Token: 0x06000766 RID: 1894
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x955CA0", Offset = "0x955CA0", VA = "0x6955CA0")]
		[PreserveSig]
		internal static extern void MessageListenerHelper_Dispose(HandleRef self);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x06000768 RID: 1896
		[Token(Token = "0x20000BD")]
		internal delegate void OnMessageReceivedCallback(long arg0, string arg1, IntPtr arg2, UIntPtr arg3, bool arg4, IntPtr arg5);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x0600076C RID: 1900
		[Token(Token = "0x20000BE")]
		internal delegate void OnDisconnectedCallback(long arg0, string arg1, IntPtr arg2);
	}
}
