using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000C7")]
	internal static class NearbyConnectionTypes
	{
		// Token: 0x060007A0 RID: 1952
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x957A60", Offset = "0x957A60", VA = "0x6957A60")]
		[PreserveSig]
		internal static extern void AppIdentifier_Dispose(HandleRef self);

		// Token: 0x060007A1 RID: 1953
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x957B68", Offset = "0x957B68", VA = "0x6957B68")]
		[PreserveSig]
		internal static extern UIntPtr AppIdentifier_GetIdentifier(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007A2 RID: 1954
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x957C60", Offset = "0x957C60", VA = "0x6957C60")]
		[PreserveSig]
		internal static extern void StartAdvertisingResult_Dispose(HandleRef self);

		// Token: 0x060007A3 RID: 1955
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x957D40", Offset = "0x957D40", VA = "0x6957D40")]
		[PreserveSig]
		internal static extern int StartAdvertisingResult_GetStatus(HandleRef self);

		// Token: 0x060007A4 RID: 1956
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x957E28", Offset = "0x957E28", VA = "0x6957E28")]
		[PreserveSig]
		internal static extern UIntPtr StartAdvertisingResult_GetLocalEndpointName(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007A5 RID: 1957
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x957F30", Offset = "0x957F30", VA = "0x6957F30")]
		[PreserveSig]
		internal static extern void EndpointDetails_Dispose(HandleRef self);

		// Token: 0x060007A6 RID: 1958
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x958040", Offset = "0x958040", VA = "0x6958040")]
		[PreserveSig]
		internal static extern UIntPtr EndpointDetails_GetEndpointId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007A7 RID: 1959
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x958138", Offset = "0x958138", VA = "0x6958138")]
		[PreserveSig]
		internal static extern UIntPtr EndpointDetails_GetName(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007A8 RID: 1960
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x958260", Offset = "0x958260", VA = "0x6958260")]
		[PreserveSig]
		internal static extern UIntPtr EndpointDetails_GetServiceId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007A9 RID: 1961
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x958358", Offset = "0x958358", VA = "0x6958358")]
		[PreserveSig]
		internal static extern void ConnectionRequest_Dispose(HandleRef self);

		// Token: 0x060007AA RID: 1962
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x958468", Offset = "0x958468", VA = "0x6958468")]
		[PreserveSig]
		internal static extern UIntPtr ConnectionRequest_GetRemoteEndpointId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007AB RID: 1963
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x958568", Offset = "0x958568", VA = "0x6958568")]
		[PreserveSig]
		internal static extern UIntPtr ConnectionRequest_GetRemoteEndpointName(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007AC RID: 1964
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x958668", Offset = "0x958668", VA = "0x6958668")]
		[PreserveSig]
		internal static extern UIntPtr ConnectionRequest_GetPayload(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007AD RID: 1965
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x958760", Offset = "0x958760", VA = "0x6958760")]
		[PreserveSig]
		internal static extern void ConnectionResponse_Dispose(HandleRef self);

		// Token: 0x060007AE RID: 1966
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x958840", Offset = "0x958840", VA = "0x6958840")]
		[PreserveSig]
		internal static extern UIntPtr ConnectionResponse_GetRemoteEndpointId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060007AF RID: 1967
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x958940", Offset = "0x958940", VA = "0x6958940")]
		[PreserveSig]
		internal static extern NearbyConnectionTypes.ConnectionResponse_ResponseCode ConnectionResponse_GetStatus(HandleRef self);

		// Token: 0x060007B0 RID: 1968
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x958A20", Offset = "0x958A20", VA = "0x6958A20")]
		[PreserveSig]
		internal static extern UIntPtr ConnectionResponse_GetPayload(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x020000EA RID: 234
		[Token(Token = "0x20000C8")]
		internal enum ConnectionResponse_ResponseCode
		{
			// Token: 0x0400036C RID: 876
			[Token(Token = "0x40002EC")]
			ACCEPTED = 1,
			// Token: 0x0400036D RID: 877
			[Token(Token = "0x40002ED")]
			REJECTED,
			// Token: 0x0400036E RID: 878
			[Token(Token = "0x40002EE")]
			ERROR_INTERNAL = -1,
			// Token: 0x0400036F RID: 879
			[Token(Token = "0x40002EF")]
			ERROR_NETWORK_NOT_CONNECTED = -2,
			// Token: 0x04000370 RID: 880
			[Token(Token = "0x40002F0")]
			ERROR_ENDPOINT_ALREADY_CONNECTED = -3,
			// Token: 0x04000371 RID: 881
			[Token(Token = "0x40002F1")]
			ERROR_ENDPOINT_NOT_CONNECTED = -4
		}

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060007B2 RID: 1970
		[Token(Token = "0x20000C9")]
		internal delegate void ConnectionRequestCallback(long arg0, IntPtr arg1, IntPtr arg2);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060007B6 RID: 1974
		[Token(Token = "0x20000CA")]
		internal delegate void StartAdvertisingCallback(long arg0, IntPtr arg1, IntPtr arg2);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060007BA RID: 1978
		[Token(Token = "0x20000CB")]
		internal delegate void ConnectionResponseCallback(long arg0, IntPtr arg1, IntPtr arg2);
	}
}
