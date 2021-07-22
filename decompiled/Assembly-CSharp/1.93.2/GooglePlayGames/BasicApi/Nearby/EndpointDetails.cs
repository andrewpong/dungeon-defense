using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x2000056")]
	public struct EndpointDetails
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1E1968", Offset = "0x1E1968", VA = "0x61E1968")]
		public EndpointDetails(string endpointId, string name, string serviceId)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006C")]
		public string EndpointId
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1E1984", Offset = "0x1E1984", VA = "0x61E1984")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006D")]
		public string Name
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1E198C", Offset = "0x1E198C", VA = "0x61E198C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006E")]
		public string ServiceId
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1E1994", Offset = "0x1E1994", VA = "0x61E1994")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x0")]
		private readonly string mEndpointId;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x4")]
		private readonly string mName;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mServiceId;
	}
}
