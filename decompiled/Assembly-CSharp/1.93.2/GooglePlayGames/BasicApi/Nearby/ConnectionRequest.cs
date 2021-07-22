using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000052")]
	public struct ConnectionRequest
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1E1720", Offset = "0x1E1720", VA = "0x61E1720")]
		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x17000066")]
		public EndpointDetails RemoteEndpoint
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1E1744", Offset = "0x1E1744", VA = "0x61E1744")]
			get
			{
				return default(EndpointDetails);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000067")]
		public byte[] Payload
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1E1758", Offset = "0x1E1758", VA = "0x61E1758")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x0")]
		private readonly EndpointDetails mRemoteEndpoint;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0xC")]
		private readonly byte[] mPayload;
	}
}
