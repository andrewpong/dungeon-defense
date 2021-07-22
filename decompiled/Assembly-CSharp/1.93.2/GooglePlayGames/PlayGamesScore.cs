using System;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000073")]
	public class PlayGamesScore : IScore
	{
		// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x32F7D0", Offset = "0x32F7D0", VA = "0x632F7D0")]
		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x32F918", Offset = "0x32F918", VA = "0x632F918", Slot = "4")]
		public void ReportScore(Action<bool> callback)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public string leaderboardID
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x32F910", Offset = "0x32F910", VA = "0x632F910", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x32F9E8", Offset = "0x32F9E8", VA = "0x632F9E8", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000049B0 File Offset: 0x00002BB0
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C8")]
		public long value
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x32F9F0", Offset = "0x32F9F0", VA = "0x632F9F0", Slot = "7")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x32F9F8", Offset = "0x32F9F8", VA = "0x632F9F8", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x170000C9")]
		public DateTime date
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x32FA08", Offset = "0x32FA08", VA = "0x632FA08", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CA")]
		public string formattedValue
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x32FA18", Offset = "0x32FA18", VA = "0x632FA18", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CB")]
		public string userID
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x32FA24", Offset = "0x32FA24", VA = "0x632FA24", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x170000CC")]
		public int rank
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x32FA2C", Offset = "0x32FA2C", VA = "0x632FA2C", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CD")]
		public string metaData
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x32FA34", Offset = "0x32FA34", VA = "0x632FA34")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x8")]
		private string mLbId;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x10")]
		private long mValue;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x18")]
		private ulong mRank;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x20")]
		private string mPlayerId;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x24")]
		private string mMetadata;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x28")]
		private DateTime mDate;
	}
}
