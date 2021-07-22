using System;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000071")]
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x4912B4", Offset = "0x4912B4", VA = "0x64912B4")]
		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x491380", Offset = "0x491380", VA = "0x6491380", Slot = "9")]
		public void Authenticate(Action<bool> callback)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x4913BC", Offset = "0x4913BC", VA = "0x64913BC", Slot = "11")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x4913F8", Offset = "0x4913F8", VA = "0x64913F8")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x49150C", Offset = "0x49150C", VA = "0x649150C")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x4916B0", Offset = "0x4916B0", VA = "0x64916B0", Slot = "12")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B5")]
		public IUserProfile[] friends
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x49183C", Offset = "0x49183C", VA = "0x649183C", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x4919A8", Offset = "0x4919A8", VA = "0x64919A8")]
		public string GetIdToken()
		{
			return null;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x170000B6")]
		public bool authenticated
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x491AE8", Offset = "0x491AE8", VA = "0x6491AE8", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x170000B7")]
		public bool underage
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x491BE8", Offset = "0x491BE8", VA = "0x6491BE8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B8")]
		public new string userName
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x491BF0", Offset = "0x491BF0", VA = "0x6491BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B9")]
		public new string id
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x492128", Offset = "0x492128", VA = "0x6492128", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x170000BA")]
		public new bool isFriend
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x492284", Offset = "0x492284", VA = "0x6492284", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x170000BB")]
		public new UserState state
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x49228C", Offset = "0x49228C", VA = "0x649228C", Slot = "16")]
			get
			{
				return UserState.Online;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BC")]
		public new string AvatarURL
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x492294", Offset = "0x492294", VA = "0x6492294")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BD")]
		public string Email
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x4923F0", Offset = "0x4923F0", VA = "0x64923F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x492634", Offset = "0x492634", VA = "0x6492634")]
		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x1C")]
		internal PlayGamesPlatform mPlatform;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x20")]
		private string emailAddress;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x24")]
		private PlayerStats mStats;

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x20002BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F630", Offset = "0x17F630")]
		private sealed class <GetStats>c__AnonStorey0
		{
			// Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600146C")]
			[Address(RVA = "0x492790", Offset = "0x492790", VA = "0x6492790")]
			public <GetStats>c__AnonStorey0()
			{
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x492998", Offset = "0x492998", VA = "0x6492998")]
			internal void <>m__0(CommonStatusCodes rc, PlayerStats stats)
			{
			}

			// Token: 0x040002BE RID: 702
			[Token(Token = "0x400130E")]
			[FieldOffset(Offset = "0x8")]
			internal Action<CommonStatusCodes, PlayerStats> callback;

			// Token: 0x040002BF RID: 703
			[Token(Token = "0x400130F")]
			[FieldOffset(Offset = "0xC")]
			internal PlayGamesLocalUser $this;
		}
	}
}
