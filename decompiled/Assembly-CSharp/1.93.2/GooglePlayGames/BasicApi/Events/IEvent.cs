using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x200003E")]
	public interface IEvent
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000364 RID: 868
		[Token(Token = "0x17000039")]
		string Id { [Token(Token = "0x6000338")] get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000365 RID: 869
		[Token(Token = "0x1700003A")]
		string Name { [Token(Token = "0x6000339")] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000366 RID: 870
		[Token(Token = "0x1700003B")]
		string Description { [Token(Token = "0x600033A")] get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000367 RID: 871
		[Token(Token = "0x1700003C")]
		string ImageUrl { [Token(Token = "0x600033B")] get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000368 RID: 872
		[Token(Token = "0x1700003D")]
		ulong CurrentCount { [Token(Token = "0x600033C")] get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000369 RID: 873
		[Token(Token = "0x1700003E")]
		EventVisibility Visibility { [Token(Token = "0x600033D")] get; }
	}
}
