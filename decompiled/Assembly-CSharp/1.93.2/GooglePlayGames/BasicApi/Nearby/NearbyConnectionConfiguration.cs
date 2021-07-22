using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x200005B")]
	public struct NearbyConnectionConfiguration
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1E1A3C", Offset = "0x1E1A3C", VA = "0x61E1A3C")]
		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x1700006F")]
		public long LocalClientId
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1E1A58", Offset = "0x1E1A58", VA = "0x61E1A58")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000070")]
		public Action<InitializationStatus> InitializationCallback
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1E1A60", Offset = "0x1E1A60", VA = "0x61E1A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x40001F8")]
		public const int MaxUnreliableMessagePayloadLength = 1168;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x40001F9")]
		public const int MaxReliableMessagePayloadLength = 4096;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<InitializationStatus> mInitializationCallback;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x8")]
		private readonly long mLocalClientId;
	}
}
