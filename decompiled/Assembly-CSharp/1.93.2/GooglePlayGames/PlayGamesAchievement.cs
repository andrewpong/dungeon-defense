using System;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x200006F")]
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x48F634", Offset = "0x48F634", VA = "0x648F634")]
		internal PlayGamesAchievement()
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x48F8B8", Offset = "0x48F8B8", VA = "0x648F8B8")]
		internal PlayGamesAchievement(ReportProgress progressCallback)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x48F9F0", Offset = "0x48F9F0", VA = "0x648F9F0")]
		internal PlayGamesAchievement(Achievement ach)
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x48FCE0", Offset = "0x48FCE0", VA = "0x648FCE0", Slot = "4")]
		public void ReportProgress(Action<bool> callback)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x48FD38", Offset = "0x48FD38", VA = "0x648FD38")]
		private Texture2D LoadImage()
		{
			return null;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public string id
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x48FF10", Offset = "0x48FF10", VA = "0x648FF10", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x48FF18", Offset = "0x48FF18", VA = "0x648FF18", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x1700009F")]
		public bool isIncremental
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x48FF20", Offset = "0x48FF20", VA = "0x648FF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x170000A0")]
		public int currentSteps
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x48FF28", Offset = "0x48FF28", VA = "0x648FF28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x170000A1")]
		public int totalSteps
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x48FF30", Offset = "0x48FF30", VA = "0x648FF30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000047A0 File Offset: 0x000029A0
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		public double percentCompleted
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x48FF38", Offset = "0x48FF38", VA = "0x648FF38", Slot = "7")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x48FF44", Offset = "0x48FF44", VA = "0x648FF44", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x170000A3")]
		public bool completed
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x48FF08", Offset = "0x48FF08", VA = "0x648FF08", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x170000A4")]
		public bool hidden
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x48FF00", Offset = "0x48FF00", VA = "0x648FF00", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x170000A5")]
		public DateTime lastReportedDate
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x48FF54", Offset = "0x48FF54", VA = "0x648FF54", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A6")]
		public string title
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x48FF64", Offset = "0x48FF64", VA = "0x648FF64", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A7")]
		public Texture2D image
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x48FF6C", Offset = "0x48FF6C", VA = "0x648FF6C", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A8")]
		public string achievedDescription
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x48FF70", Offset = "0x48FF70", VA = "0x648FF70", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A9")]
		public string unachievedDescription
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x48FF78", Offset = "0x48FF78", VA = "0x648FF78", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x170000AA")]
		public int points
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x48FF80", Offset = "0x48FF80", VA = "0x648FF80", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x8")]
		private readonly ReportProgress mProgressCallback;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xC")]
		private string mId;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x10")]
		private bool mIsIncremental;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x14")]
		private int mCurrentSteps;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x18")]
		private int mTotalSteps;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x20")]
		private double mPercentComplete;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x28")]
		private bool mCompleted;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x29")]
		private bool mHidden;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x30")]
		private DateTime mLastModifiedTime;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x40")]
		private string mTitle;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x44")]
		private string mRevealedImageUrl;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x48")]
		private string mUnlockedImageUrl;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x4C")]
		private UnityWebRequest mImageFetcher;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x50")]
		private Texture2D mImage;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x54")]
		private string mDescription;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x58")]
		private ulong mPoints;
	}
}
