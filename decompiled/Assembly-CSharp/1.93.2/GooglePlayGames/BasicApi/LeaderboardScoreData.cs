using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000042")]
	public class LeaderboardScoreData
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x9418CC", Offset = "0x9418CC", VA = "0x69418CC")]
		internal LeaderboardScoreData(string leaderboardId)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x941064", Offset = "0x941064", VA = "0x6941064")]
		internal LeaderboardScoreData(string leaderboardId, ResponseStatus status)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x1700003F")]
		public bool Valid
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x941960", Offset = "0x941960", VA = "0x6941960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public ResponseStatus Status
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x941978", Offset = "0x941978", VA = "0x6941978")]
			get
			{
				return (ResponseStatus)0;
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x941980", Offset = "0x941980", VA = "0x6941980")]
			internal set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00003EB8 File Offset: 0x000020B8
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public ulong ApproximateCount
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x941988", Offset = "0x941988", VA = "0x6941988")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x941990", Offset = "0x941990", VA = "0x6941990")]
			internal set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public string Title
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x9419A0", Offset = "0x9419A0", VA = "0x69419A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x9419A8", Offset = "0x9419A8", VA = "0x69419A8")]
			internal set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public string Id
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x9419B0", Offset = "0x9419B0", VA = "0x69419B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x9419B8", Offset = "0x9419B8", VA = "0x69419B8")]
			internal set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public IScore PlayerScore
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x9419C0", Offset = "0x9419C0", VA = "0x69419C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x9419C8", Offset = "0x9419C8", VA = "0x69419C8")]
			internal set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000045")]
		public IScore[] Scores
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x9419D0", Offset = "0x9419D0", VA = "0x69419D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x941A48", Offset = "0x941A48", VA = "0x6941A48")]
		internal int AddScore(PlayGamesScore score)
		{
			return 0;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public ScorePageToken PrevPageToken
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x941AF4", Offset = "0x941AF4", VA = "0x6941AF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x941AFC", Offset = "0x941AFC", VA = "0x6941AFC")]
			internal set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public ScorePageToken NextPageToken
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x941B04", Offset = "0x941B04", VA = "0x6941B04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x941B0C", Offset = "0x941B0C", VA = "0x6941B0C")]
			internal set
			{
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x941B14", Offset = "0x941B14", VA = "0x6941B14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x8")]
		private string mId;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xC")]
		private ResponseStatus mStatus;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x10")]
		private ulong mApproxCount;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x18")]
		private string mTitle;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x1C")]
		private IScore mPlayerScore;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x20")]
		private ScorePageToken mPrevPage;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x24")]
		private ScorePageToken mNextPage;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x28")]
		private List<PlayGamesScore> mScores;
	}
}
