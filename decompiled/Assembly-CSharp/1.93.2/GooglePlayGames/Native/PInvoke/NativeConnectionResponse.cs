using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x2000156")]
	internal class NativeConnectionResponse : BaseReferenceHolder
	{
		// Token: 0x06000C3B RID: 3131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x45B248", Offset = "0x45B248", VA = "0x645B248")]
		internal NativeConnectionResponse(IntPtr pointer)
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x45B2D0", Offset = "0x45B2D0", VA = "0x645B2D0")]
		internal string RemoteEndpointId()
		{
			return null;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x45B38C", Offset = "0x45B38C", VA = "0x645B38C")]
		internal NearbyConnectionTypes.ConnectionResponse_ResponseCode ResponseCode()
		{
			return (NearbyConnectionTypes.ConnectionResponse_ResponseCode)0;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x45B3B8", Offset = "0x45B3B8", VA = "0x645B3B8")]
		internal byte[] Payload()
		{
			return null;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x45B48C", Offset = "0x45B48C", VA = "0x645B48C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x45B49C", Offset = "0x45B49C", VA = "0x645B49C")]
		internal ConnectionResponse AsResponse(long localClientId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x45B854", Offset = "0x45B854", VA = "0x645B854")]
		internal static NativeConnectionResponse FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x45B8E0", Offset = "0x45B8E0", VA = "0x645B8E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185F2C", Offset = "0x185F2C")]
		private UIntPtr <RemoteEndpointId>m__0(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x45B924", Offset = "0x45B924", VA = "0x645B924")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185F3C", Offset = "0x185F3C")]
		private UIntPtr <Payload>m__1(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}
	}
}
