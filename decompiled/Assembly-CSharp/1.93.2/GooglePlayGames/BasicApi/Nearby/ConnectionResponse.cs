using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x2000053")]
	public struct ConnectionResponse
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1E1920", Offset = "0x1E1920", VA = "0x61E1920")]
		private ConnectionResponse(long localClientId, string remoteEndpointId, ConnectionResponse.Status code, byte[] payload)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x17000068")]
		public long LocalClientId
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1E1948", Offset = "0x1E1948", VA = "0x61E1948")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000069")]
		public string RemoteEndpointId
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1E1950", Offset = "0x1E1950", VA = "0x61E1950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x1700006A")]
		public ConnectionResponse.Status ResponseStatus
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1E1958", Offset = "0x1E1958", VA = "0x61E1958")]
			get
			{
				return ConnectionResponse.Status.Accepted;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006B")]
		public byte[] Payload
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1E1960", Offset = "0x1E1960", VA = "0x61E1960")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x944328", Offset = "0x944328", VA = "0x6944328")]
		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x944404", Offset = "0x944404", VA = "0x6944404")]
		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x9444E0", Offset = "0x9444E0", VA = "0x69444E0")]
		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x9445BC", Offset = "0x9445BC", VA = "0x69445BC")]
		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x944698", Offset = "0x944698", VA = "0x6944698")]
		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x9446D8", Offset = "0x9446D8", VA = "0x69446D8")]
		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] EmptyPayload;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x0")]
		private readonly long mLocalClientId;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mRemoteEndpointId;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0xC")]
		private readonly ConnectionResponse.Status mResponseStatus;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] mPayload;

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x2000054")]
		public enum Status
		{
			// Token: 0x04000237 RID: 567
			[Token(Token = "0x40001EB")]
			Accepted,
			// Token: 0x04000238 RID: 568
			[Token(Token = "0x40001EC")]
			Rejected,
			// Token: 0x04000239 RID: 569
			[Token(Token = "0x40001ED")]
			ErrorInternal,
			// Token: 0x0400023A RID: 570
			[Token(Token = "0x40001EE")]
			ErrorNetworkNotConnected,
			// Token: 0x0400023B RID: 571
			[Token(Token = "0x40001EF")]
			ErrorEndpointNotConnected,
			// Token: 0x0400023C RID: 572
			[Token(Token = "0x40001F0")]
			ErrorAlreadyConnected
		}
	}
}
