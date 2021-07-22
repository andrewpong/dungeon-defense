using System;
using Il2CppDummyDll;

namespace GooglePlayGames
{
	// Token: 0x02000224 RID: 548
	[Token(Token = "0x200019A")]
	internal interface TokenClient
	{
		// Token: 0x06000E7B RID: 3707
		[Token(Token = "0x6000D29")]
		string GetEmail();

		// Token: 0x06000E7C RID: 3708
		[Token(Token = "0x6000D2A")]
		string GetAuthCode();

		// Token: 0x06000E7D RID: 3709
		[Token(Token = "0x6000D2B")]
		string GetIdToken();

		// Token: 0x06000E7E RID: 3710
		[Token(Token = "0x6000D2C")]
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);

		// Token: 0x06000E7F RID: 3711
		[Token(Token = "0x6000D2D")]
		void Signout();

		// Token: 0x06000E80 RID: 3712
		[Token(Token = "0x6000D2E")]
		void SetRequestAuthCode(bool flag, bool forceRefresh);

		// Token: 0x06000E81 RID: 3713
		[Token(Token = "0x6000D2F")]
		void SetRequestEmail(bool flag);

		// Token: 0x06000E82 RID: 3714
		[Token(Token = "0x6000D30")]
		void SetRequestIdToken(bool flag);

		// Token: 0x06000E83 RID: 3715
		[Token(Token = "0x6000D31")]
		void SetWebClientId(string webClientId);

		// Token: 0x06000E84 RID: 3716
		[Token(Token = "0x6000D32")]
		void SetAccountName(string accountName);

		// Token: 0x06000E85 RID: 3717
		[Token(Token = "0x6000D33")]
		void AddOauthScopes(params string[] scopes);

		// Token: 0x06000E86 RID: 3718
		[Token(Token = "0x6000D34")]
		void SetHidePopups(bool flag);

		// Token: 0x06000E87 RID: 3719
		[Token(Token = "0x6000D35")]
		void FetchTokens(bool silent, Action<int> callback);
	}
}
