using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x2000065")]
	public interface ISavedGameMetadata
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000498 RID: 1176
		[Token(Token = "0x17000086")]
		bool IsOpen { [Token(Token = "0x600046C")] get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000499 RID: 1177
		[Token(Token = "0x17000087")]
		string Filename { [Token(Token = "0x600046D")] get; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600049A RID: 1178
		[Token(Token = "0x17000088")]
		string Description { [Token(Token = "0x600046E")] get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600049B RID: 1179
		[Token(Token = "0x17000089")]
		string CoverImageURL { [Token(Token = "0x600046F")] get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600049C RID: 1180
		[Token(Token = "0x1700008A")]
		TimeSpan TotalTimePlayed { [Token(Token = "0x6000470")] get; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600049D RID: 1181
		[Token(Token = "0x1700008B")]
		DateTime LastModifiedTimestamp { [Token(Token = "0x6000471")] get; }
	}
}
