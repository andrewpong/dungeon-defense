using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000196")]
	internal interface IClientImpl
	{
		// Token: 0x06000E6B RID: 3691
		[Token(Token = "0x6000D19")]
		PlatformConfiguration CreatePlatformConfiguration(PlayGamesClientConfiguration clientConfig);

		// Token: 0x06000E6C RID: 3692
		[Token(Token = "0x6000D1A")]
		TokenClient CreateTokenClient(bool reset);

		// Token: 0x06000E6D RID: 3693
		[Token(Token = "0x6000D1B")]
		void GetPlayerStats(IntPtr apiClientPtr, Action<CommonStatusCodes, PlayerStats> callback);

		// Token: 0x06000E6E RID: 3694
		[Token(Token = "0x6000D1C")]
		void SetGravityForPopups(IntPtr apiClient, Gravity gravity);
	}
}
