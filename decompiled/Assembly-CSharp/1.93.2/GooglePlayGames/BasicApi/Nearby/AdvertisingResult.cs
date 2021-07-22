using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000051")]
	public struct AdvertisingResult
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1E1484", Offset = "0x1E1484", VA = "0x61E1484")]
		public AdvertisingResult(ResponseStatus status, string localEndpointName)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x17000063")]
		public bool Succeeded
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1E148C", Offset = "0x1E148C", VA = "0x61E148C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x17000064")]
		public ResponseStatus Status
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1E149C", Offset = "0x1E149C", VA = "0x61E149C")]
			get
			{
				return (ResponseStatus)0;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000065")]
		public string LocalEndpointName
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1E14A4", Offset = "0x1E14A4", VA = "0x61E14A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x0")]
		private readonly ResponseStatus mStatus;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x4")]
		private readonly string mLocalEndpointName;
	}
}
