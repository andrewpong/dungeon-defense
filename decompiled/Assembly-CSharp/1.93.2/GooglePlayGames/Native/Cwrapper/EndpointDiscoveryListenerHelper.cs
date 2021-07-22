using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000A9")]
	internal static class EndpointDiscoveryListenerHelper
	{
		// Token: 0x060006F6 RID: 1782
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x94F690", Offset = "0x94F690", VA = "0x694F690")]
		[PreserveSig]
		internal static extern IntPtr EndpointDiscoveryListenerHelper_Construct();

		// Token: 0x060006F7 RID: 1783
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x94F770", Offset = "0x94F770", VA = "0x694F770")]
		[PreserveSig]
		internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointLostCallback(HandleRef self, EndpointDiscoveryListenerHelper.OnEndpointLostCallback callback, IntPtr callback_arg);

		// Token: 0x060006F8 RID: 1784
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x94F888", Offset = "0x94F888", VA = "0x694F888")]
		[PreserveSig]
		internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointFoundCallback(HandleRef self, EndpointDiscoveryListenerHelper.OnEndpointFoundCallback callback, IntPtr callback_arg);

		// Token: 0x060006F9 RID: 1785
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x94F9A0", Offset = "0x94F9A0", VA = "0x694F9A0")]
		[PreserveSig]
		internal static extern void EndpointDiscoveryListenerHelper_Dispose(HandleRef self);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x060006FB RID: 1787
		[Token(Token = "0x20000AA")]
		internal delegate void OnEndpointFoundCallback(long arg0, IntPtr arg1, IntPtr arg2);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x060006FF RID: 1791
		[Token(Token = "0x20000AB")]
		internal delegate void OnEndpointLostCallback(long arg0, string arg1, IntPtr arg2);
	}
}
