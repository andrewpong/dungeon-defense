using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000070")]
	public class PlayGamesLeaderboard : ILeaderboard
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x49010C", Offset = "0x49010C", VA = "0x649010C")]
		public PlayGamesLeaderboard(string id)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4901A0", Offset = "0x4901A0", VA = "0x64901A0", Slot = "9")]
		public void SetUserFilter(string[] userIDs)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x4901A8", Offset = "0x4901A8", VA = "0x64901A8", Slot = "10")]
		public void LoadScores(Action<bool> callback)
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00004818 File Offset: 0x00002A18
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public bool loading
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x490B8C", Offset = "0x490B8C", VA = "0x6490B8C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x490B94", Offset = "0x490B94", VA = "0x6490B94")]
			internal set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		public string id
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x490B9C", Offset = "0x490B9C", VA = "0x6490B9C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x490BA4", Offset = "0x490BA4", VA = "0x6490BA4", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00004830 File Offset: 0x00002A30
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		public UserScope userScope
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x490BAC", Offset = "0x490BAC", VA = "0x6490BAC", Slot = "6")]
			get
			{
				return UserScope.Global;
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x490BB4", Offset = "0x490BB4", VA = "0x6490BB4", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00004848 File Offset: 0x00002A48
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		public Range range
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x490BBC", Offset = "0x490BBC", VA = "0x6490BBC", Slot = "7")]
			get
			{
				return default(Range);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x490BD0", Offset = "0x490BD0", VA = "0x6490BD0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00004860 File Offset: 0x00002A60
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public TimeScope timeScope
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x490BDC", Offset = "0x490BDC", VA = "0x6490BDC", Slot = "8")]
			get
			{
				return TimeScope.Today;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x490BE4", Offset = "0x490BE4", VA = "0x6490BE4", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B0")]
		public IScore localUserScore
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x490BEC", Offset = "0x490BEC", VA = "0x6490BEC", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x170000B1")]
		public uint maxRange
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x490BF4", Offset = "0x490BF4", VA = "0x6490BF4", Slot = "16")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B2")]
		public IScore[] scores
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x490BFC", Offset = "0x490BFC", VA = "0x6490BFC", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B3")]
		public string title
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x490CC4", Offset = "0x490CC4", VA = "0x6490CC4", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x490CCC", Offset = "0x490CCC", VA = "0x6490CCC")]
		internal bool SetFromData(LeaderboardScoreData data)
		{
			return default(bool);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x490FE0", Offset = "0x490FE0", VA = "0x6490FE0")]
		internal void SetMaxRange(ulong val)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x490FE8", Offset = "0x490FE8", VA = "0x6490FE8")]
		internal void SetTitle(string value)
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x490FF0", Offset = "0x490FF0", VA = "0x6490FF0")]
		internal void SetLocalUserScore(PlayGamesScore score)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x490FF8", Offset = "0x490FF8", VA = "0x6490FF8")]
		internal int AddScore(PlayGamesScore score)
		{
			return 0;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x170000B4")]
		public int ScoreCount
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x49123C", Offset = "0x49123C", VA = "0x649123C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x49116C", Offset = "0x49116C", VA = "0x649116C")]
		internal bool HasAllScores()
		{
			return default(bool);
		}

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x8")]
		private string mId;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0xC")]
		private UserScope mUserScope;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x10")]
		private Range mRange;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x18")]
		private TimeScope mTimeScope;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x1C")]
		private string[] mFilteredUserIds;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x20")]
		private bool mLoading;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x24")]
		private IScore mLocalUserScore;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x28")]
		private uint mMaxRange;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x2C")]
		private List<PlayGamesScore> mScoreList;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x30")]
		private string mTitle;
	}
}
