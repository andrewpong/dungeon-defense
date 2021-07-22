using System;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames
{
	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000198")]
	public static class NearbyConnectionClientFactory
	{
		// Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x48CBB8", Offset = "0x48CBB8", VA = "0x648CBB8")]
		public static void Create(Action<INearbyConnectionClient> callback)
		{
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x48CCEC", Offset = "0x48CCEC", VA = "0x648CCEC")]
		private static InitializationStatus ToStatus(NearbyConnectionsStatus.InitializationStatus status)
		{
			return InitializationStatus.Success;
		}
	}
}
