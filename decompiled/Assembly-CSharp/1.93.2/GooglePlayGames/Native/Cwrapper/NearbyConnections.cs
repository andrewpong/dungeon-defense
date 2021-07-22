using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000C1")]
	internal static class NearbyConnections
	{
		// Token: 0x06000785 RID: 1925
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x959530", Offset = "0x959530", VA = "0x6959530")]
		[PreserveSig]
		internal static extern void NearbyConnections_StartDiscovery(HandleRef self, string service_id, long duration, IntPtr helper);

		// Token: 0x06000786 RID: 1926
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x959650", Offset = "0x959650", VA = "0x6959650")]
		[PreserveSig]
		internal static extern void NearbyConnections_RejectConnectionRequest(HandleRef self, string remote_endpoint_id);

		// Token: 0x06000787 RID: 1927
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x959760", Offset = "0x959760", VA = "0x6959760")]
		[PreserveSig]
		internal static extern void NearbyConnections_Disconnect(HandleRef self, string remote_endpoint_id);

		// Token: 0x06000788 RID: 1928
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x959868", Offset = "0x959868", VA = "0x6959868")]
		[PreserveSig]
		internal static extern void NearbyConnections_SendUnreliableMessage(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size);

		// Token: 0x06000789 RID: 1929
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x959990", Offset = "0x959990", VA = "0x6959990")]
		[PreserveSig]
		internal static extern void NearbyConnections_StopAdvertising(HandleRef self);

		// Token: 0x0600078A RID: 1930
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x959A78", Offset = "0x959A78", VA = "0x6959A78")]
		[PreserveSig]
		internal static extern void NearbyConnections_Dispose(HandleRef self);

		// Token: 0x0600078B RID: 1931
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x959B88", Offset = "0x959B88", VA = "0x6959B88")]
		[PreserveSig]
		internal static extern void NearbyConnections_SendReliableMessage(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size);

		// Token: 0x0600078C RID: 1932
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x959CB0", Offset = "0x959CB0", VA = "0x6959CB0")]
		[PreserveSig]
		internal static extern void NearbyConnections_StopDiscovery(HandleRef self, string service_id);

		// Token: 0x0600078D RID: 1933
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x959DB8", Offset = "0x959DB8", VA = "0x6959DB8")]
		[PreserveSig]
		internal static extern void NearbyConnections_SendConnectionRequest(HandleRef self, string name, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, NearbyConnectionTypes.ConnectionResponseCallback callback, IntPtr callback_arg, IntPtr helper);

		// Token: 0x0600078E RID: 1934
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x959F18", Offset = "0x959F18", VA = "0x6959F18")]
		[PreserveSig]
		internal static extern void NearbyConnections_StartAdvertising(HandleRef self, string name, IntPtr[] app_identifiers, UIntPtr app_identifiers_size, long duration, NearbyConnectionTypes.StartAdvertisingCallback start_advertising_callback, IntPtr start_advertising_callback_arg, NearbyConnectionTypes.ConnectionRequestCallback request_callback, IntPtr request_callback_arg);

		// Token: 0x0600078F RID: 1935
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x95A070", Offset = "0x95A070", VA = "0x695A070")]
		[PreserveSig]
		internal static extern void NearbyConnections_Stop(HandleRef self);

		// Token: 0x06000790 RID: 1936
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x95A180", Offset = "0x95A180", VA = "0x695A180")]
		[PreserveSig]
		internal static extern void NearbyConnections_AcceptConnectionRequest(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, IntPtr helper);
	}
}
