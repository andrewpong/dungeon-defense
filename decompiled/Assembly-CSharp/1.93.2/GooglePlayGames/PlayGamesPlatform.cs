using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x2000072")]
	public class PlayGamesPlatform : ISocialPlatform
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x492A38", Offset = "0x492A38", VA = "0x6492A38")]
		internal PlayGamesPlatform(IPlayGamesClient client)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x492B70", Offset = "0x492B70", VA = "0x6492B70")]
		private PlayGamesPlatform(PlayGamesClientConfiguration configuration)
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00004950 File Offset: 0x00002B50
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BE")]
		public static bool DebugLogEnabled
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x492C9C", Offset = "0x492C9C", VA = "0x6492C9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x492D14", Offset = "0x492D14", VA = "0x6492D14")]
			set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BF")]
		public static PlayGamesPlatform Instance
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x48F6F8", Offset = "0x48F6F8", VA = "0x648F6F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C0")]
		public static INearbyConnectionClient Nearby
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x492F14", Offset = "0x492F14", VA = "0x6492F14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C1")]
		public IRealTimeMultiplayerClient RealTime
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x493300", Offset = "0x493300", VA = "0x6493300")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C2")]
		public ITurnBasedMultiplayerClient TurnBased
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x4933D8", Offset = "0x4933D8", VA = "0x64933D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C3")]
		public ISavedGameClient SavedGame
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x4934B0", Offset = "0x4934B0", VA = "0x64934B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C4")]
		public IEventsClient Events
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x493588", Offset = "0x493588", VA = "0x6493588")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C5")]
		public IVideoClient Video
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x493660", Offset = "0x493660", VA = "0x6493660")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C6")]
		public ILocalUser localUser
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x493738", Offset = "0x493738", VA = "0x6493738", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x492D94", Offset = "0x492D94", VA = "0x6492D94")]
		public static void InitializeInstance(PlayGamesClientConfiguration configuration)
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x49309C", Offset = "0x49309C", VA = "0x649309C")]
		public static void InitializeNearby(Action<INearbyConnectionClient> callback)
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x493740", Offset = "0x493740", VA = "0x6493740")]
		public static PlayGamesPlatform Activate()
		{
			return null;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x49385C", Offset = "0x49385C", VA = "0x649385C")]
		public IntPtr GetApiClient()
		{
			return 0;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x493934", Offset = "0x493934", VA = "0x6493934")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x493A14", Offset = "0x493A14", VA = "0x6493A14")]
		public void AddIdMapping(string fromId, string toId)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4913B4", Offset = "0x4913B4", VA = "0x64913B4")]
		public void Authenticate(Action<bool> callback)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4913F0", Offset = "0x4913F0", VA = "0x64913F0")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x491430", Offset = "0x491430", VA = "0x6491430")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x491544", Offset = "0x491544", VA = "0x6491544")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x493A9C", Offset = "0x493A9C", VA = "0x6493A9C", Slot = "9")]
		public void Authenticate(ILocalUser unused, Action<bool> callback)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x493AA8", Offset = "0x493AA8", VA = "0x6493AA8", Slot = "11")]
		public void Authenticate(ILocalUser unused, Action<bool, string> callback)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x491B10", Offset = "0x491B10", VA = "0x6491B10")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x493AB4", Offset = "0x493AB4", VA = "0x6493AB4")]
		public void SignOut()
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x493BA8", Offset = "0x493BA8", VA = "0x6493BA8", Slot = "12")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x491EBC", Offset = "0x491EBC", VA = "0x6491EBC")]
		public string GetUserId()
		{
			return null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x4919D0", Offset = "0x4919D0", VA = "0x64919D0")]
		public string GetIdToken()
		{
			return null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x493D2C", Offset = "0x493D2C", VA = "0x6493D2C")]
		public string GetServerAuthCode()
		{
			return null;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x493E98", Offset = "0x493E98", VA = "0x6493E98")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x49255C", Offset = "0x49255C", VA = "0x649255C")]
		public string GetUserEmail()
		{
			return null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x492798", Offset = "0x492798", VA = "0x6492798")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x491D4C", Offset = "0x491D4C", VA = "0x6491D4C")]
		public string GetUserDisplayName()
		{
			return null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x491FF8", Offset = "0x491FF8", VA = "0x6491FF8")]
		public string GetUserImageUrl()
		{
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4941D8", Offset = "0x4941D8", VA = "0x64941D8", Slot = "5")]
		public void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x494A00", Offset = "0x494A00", VA = "0x6494A00")]
		public void RevealAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x494BF4", Offset = "0x494BF4", VA = "0x6494BF4")]
		public void UnlockAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x494DE8", Offset = "0x494DE8", VA = "0x6494DE8")]
		public void IncrementAchievement(string achievementID, int steps, Action<bool> callback)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4951A4", Offset = "0x4951A4", VA = "0x64951A4")]
		public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback)
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x495560", Offset = "0x495560", VA = "0x6495560", Slot = "13")]
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x495734", Offset = "0x495734", VA = "0x6495734", Slot = "14")]
		public void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x495910", Offset = "0x495910", VA = "0x6495910", Slot = "15")]
		public IAchievement CreateAchievement()
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x495978", Offset = "0x495978", VA = "0x6495978", Slot = "6")]
		public void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x495D4C", Offset = "0x495D4C", VA = "0x6495D4C")]
		public void ReportScore(long score, string board, string metadata, Action<bool> callback)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4961F4", Offset = "0x4961F4", VA = "0x64961F4", Slot = "16")]
		public void LoadScores(string leaderboardId, Action<IScore[]> callback)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x49637C", Offset = "0x49637C", VA = "0x649637C")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x496544", Offset = "0x496544", VA = "0x6496544")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x49670C", Offset = "0x49670C", VA = "0x649670C", Slot = "17")]
		public ILeaderboard CreateLeaderboard()
		{
			return null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x496780", Offset = "0x496780", VA = "0x6496780", Slot = "7")]
		public void ShowAchievementsUI()
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x496788", Offset = "0x496788", VA = "0x6496788")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x49693C", Offset = "0x49693C", VA = "0x649693C", Slot = "8")]
		public void ShowLeaderboardUI()
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x496A10", Offset = "0x496A10", VA = "0x6496A10")]
		public void ShowLeaderboardUI(string leaderboardId)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x4969F0", Offset = "0x4969F0", VA = "0x64969F0")]
		public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback)
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x496B24", Offset = "0x496B24", VA = "0x6496B24")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x496EB0", Offset = "0x496EB0", VA = "0x6496EB0")]
		public void SetDefaultLeaderboardForUI(string lbid)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4916E0", Offset = "0x4916E0", VA = "0x64916E0", Slot = "18")]
		public void LoadFriends(ILocalUser user, Action<bool> callback)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x49024C", Offset = "0x49024C", VA = "0x649024C", Slot = "19")]
		public void LoadScores(ILeaderboard board, Action<bool> callback)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x496FA0", Offset = "0x496FA0", VA = "0x6496FA0", Slot = "10")]
		public bool GetLoading(ILeaderboard board)
		{
			return default(bool);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x497074", Offset = "0x497074", VA = "0x6497074")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate deleg)
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x497154", Offset = "0x497154", VA = "0x6497154")]
		internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x491864", Offset = "0x491864", VA = "0x6491864")]
		internal IUserProfile[] GetFriends()
		{
			return null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x494888", Offset = "0x494888", VA = "0x6494888")]
		private string MapId(string id)
		{
			return null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600051F")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000521")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1855AC", Offset = "0x1855AC")]
		private static void <ToOnGameThread<T>(T A_0)
		{
		}

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayGamesPlatform sInstance;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool sNearbyInitializePending;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static INearbyConnectionClient sNearbyConnectionClient;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private PlayGamesLocalUser mLocalUser;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IPlayGamesClient mClient;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private string mDefaultLbUi;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> mIdMap;

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x20002BD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F640", Offset = "0x17F640")]
		private sealed class <InitializeNearby>c__AnonStorey0
		{
			// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x32E9A0", Offset = "0x32E9A0", VA = "0x632E9A0")]
			public <InitializeNearby>c__AnonStorey0()
			{
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x32E9A8", Offset = "0x32E9A8", VA = "0x632E9A8")]
			internal void <>m__0(INearbyConnectionClient client)
			{
			}

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x4001310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<INearbyConnectionClient> callback;
		}

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x20002BE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F650", Offset = "0x17F650")]
		private sealed class <Authenticate>c__AnonStorey1
		{
			// Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x32E6D0", Offset = "0x32E6D0", VA = "0x632E6D0")]
			public <Authenticate>c__AnonStorey1()
			{
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001471")]
			[Address(RVA = "0x32E6D8", Offset = "0x32E6D8", VA = "0x632E6D8")]
			internal void <>m__0(bool success, string msg)
			{
			}

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x4001311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<bool> callback;
		}

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x20002BF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F660", Offset = "0x17F660")]
		private sealed class <GetAnotherServerAuthCode>c__AnonStorey2
		{
			// Token: 0x06000554 RID: 1364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001472")]
			[Address(RVA = "0x32E758", Offset = "0x32E758", VA = "0x632E758")]
			public <GetAnotherServerAuthCode>c__AnonStorey2()
			{
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x32E760", Offset = "0x32E760", VA = "0x632E760")]
			internal void <>m__0(bool success, string msg)
			{
			}

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x4001312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<string> callback;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x4001313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal PlayGamesPlatform $this;
		}

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x20002C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F670", Offset = "0x17F670")]
		private sealed class <ReportProgress>c__AnonStorey3
		{
			// Token: 0x06000556 RID: 1366 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001474")]
			[Address(RVA = "0x32EFAC", Offset = "0x32EFAC", VA = "0x632EFAC")]
			public <ReportProgress>c__AnonStorey3()
			{
			}

			// Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001475")]
			[Address(RVA = "0x32EFB8", Offset = "0x32EFB8", VA = "0x632EFB8")]
			internal void <>m__0(Achievement[] ach)
			{
			}

			// Token: 0x040002CC RID: 716
			[Token(Token = "0x4001314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<bool> callback;

			// Token: 0x040002CD RID: 717
			[Token(Token = "0x4001315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal string achievementID;

			// Token: 0x040002CE RID: 718
			[Token(Token = "0x4001316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal double progress;

			// Token: 0x040002CF RID: 719
			[Token(Token = "0x4001317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal PlayGamesPlatform $this;
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x20002C1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F680", Offset = "0x17F680")]
		private sealed class <LoadAchievementDescriptions>c__AnonStorey4
		{
			// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001476")]
			[Address(RVA = "0x32EAF0", Offset = "0x32EAF0", VA = "0x632EAF0")]
			public <LoadAchievementDescriptions>c__AnonStorey4()
			{
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001477")]
			[Address(RVA = "0x32EAF8", Offset = "0x32EAF8", VA = "0x632EAF8")]
			internal void <>m__0(Achievement[] ach)
			{
			}

			// Token: 0x040002D0 RID: 720
			[Token(Token = "0x4001318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<IAchievementDescription[]> callback;
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x20002C2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F690", Offset = "0x17F690")]
		private sealed class <LoadAchievements>c__AnonStorey5
		{
			// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001478")]
			[Address(RVA = "0x32EC84", Offset = "0x32EC84", VA = "0x632EC84")]
			public <LoadAchievements>c__AnonStorey5()
			{
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001479")]
			[Address(RVA = "0x32EC8C", Offset = "0x32EC8C", VA = "0x632EC8C")]
			internal void <>m__0(Achievement[] ach)
			{
			}

			// Token: 0x040002D1 RID: 721
			[Token(Token = "0x4001319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<IAchievement[]> callback;
		}

		// Token: 0x02000081 RID: 129
		[Token(Token = "0x20002C3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F6A0", Offset = "0x17F6A0")]
		private sealed class <LoadScores>c__AnonStorey6
		{
			// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600147A")]
			[Address(RVA = "0x32EE18", Offset = "0x32EE18", VA = "0x632EE18")]
			public <LoadScores>c__AnonStorey6()
			{
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600147B")]
			[Address(RVA = "0x32EE20", Offset = "0x32EE20", VA = "0x632EE20")]
			internal void <>m__0(LeaderboardScoreData scoreData)
			{
			}

			// Token: 0x040002D2 RID: 722
			[Token(Token = "0x400131A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<IScore[]> callback;
		}

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x20002C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F6B0", Offset = "0x17F6B0")]
		private sealed class <LoadScores>c__AnonStorey7
		{
			// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600147C")]
			[Address(RVA = "0x32EEC0", Offset = "0x32EEC0", VA = "0x632EEC0")]
			public <LoadScores>c__AnonStorey7()
			{
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600147D")]
			[Address(RVA = "0x32EEC8", Offset = "0x32EEC8", VA = "0x632EEC8")]
			internal void <>m__0(LeaderboardScoreData scoreData)
			{
			}

			// Token: 0x040002D3 RID: 723
			[Token(Token = "0x400131B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ILeaderboard board;

			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x400131C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Action<bool> callback;

			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x400131D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal PlayGamesPlatform $this;
		}

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x20002C5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F6C0", Offset = "0x17F6C0")]
		private sealed class <HandleLoadingScores>c__AnonStorey8
		{
			// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600147E")]
			[Address(RVA = "0x32E948", Offset = "0x32E948", VA = "0x632E948")]
			public <HandleLoadingScores>c__AnonStorey8()
			{
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600147F")]
			[Address(RVA = "0x32E950", Offset = "0x32E950", VA = "0x632E950")]
			internal void <>m__0(LeaderboardScoreData nextScoreData)
			{
			}

			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x400131E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal PlayGamesLeaderboard board;

			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x400131F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Action<bool> callback;

			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x4001320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal PlayGamesPlatform $this;
		}

		// Token: 0x02000084 RID: 132
		[Token(Token = "0x20002C6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F6D0", Offset = "0x17F6D0")]
		private sealed class <ToOnGameThread>c__AnonStorey9<T>
		{
			// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001480")]
			public <ToOnGameThread>c__AnonStorey9()
			{
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001481")]
			internal void <>m__0(T val)
			{
			}

			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x4001321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Action<T> toConvert;

			// Token: 0x02000085 RID: 133
			[Token(Token = "0x20002C7")]
			private sealed class <ToOnGameThread>c__AnonStoreyA
			{
				// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001482")]
				public <ToOnGameThread>c__AnonStoreyA()
				{
				}

				// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001483")]
				internal void <>m__0()
				{
				}

				// Token: 0x040002DA RID: 730
				[Token(Token = "0x4001322")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal T val;

				// Token: 0x040002DB RID: 731
				[Token(Token = "0x4001323")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal PlayGamesPlatform.<ToOnGameThread>c__AnonStorey9<T> <>f__ref$9;
			}
		}
	}
}
