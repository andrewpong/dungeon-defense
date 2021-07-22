using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Native
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000123")]
	public class NativeClient : IPlayGamesClient
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x6DA740", Offset = "0x6DA740", VA = "0x66DA740")]
		internal NativeClient(PlayGamesClientConfiguration configuration, IClientImpl clientImpl)
		{
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x6DA894", Offset = "0x6DA894", VA = "0x66DA894")]
		private GooglePlayGames.Native.PInvoke.GameServices GameServices()
		{
			return null;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x6DA8C8", Offset = "0x6DA8C8", VA = "0x66DA8C8", Slot = "4")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000908")]
		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
		{
			return null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000909")]
		private static void InvokeCallbackOnGameThread<T, S>(Action<T, S> callback, T data, S msg)
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090A")]
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x6DB5FC", Offset = "0x6DB5FC", VA = "0x66DB5FC")]
		private void InitializeGameServices()
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x6DAB58", Offset = "0x6DAB58", VA = "0x66DAB58")]
		private void InitializeTokenClient()
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x6DC3D4", Offset = "0x6DC3D4", VA = "0x66DC3D4")]
		internal void HandleInvitation(Types.MultiplayerEvent eventType, string invitationId, GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x6DC888", Offset = "0x6DC888", VA = "0x66DC888", Slot = "13")]
		public string GetUserEmail()
		{
			return null;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x6DCA4C", Offset = "0x6DCA4C", VA = "0x66DCA4C", Slot = "10")]
		public string GetIdToken()
		{
			return null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x6DCB84", Offset = "0x6DCB84", VA = "0x66DCB84", Slot = "11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x6DCCBC", Offset = "0x6DCCBC", VA = "0x66DCCBC", Slot = "12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x6DC9C0", Offset = "0x6DC9C0", VA = "0x66DC9C0", Slot = "5")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x6DCDA8", Offset = "0x6DCDA8", VA = "0x66DCDA8", Slot = "8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x6DCFF4", Offset = "0x6DCFF4", VA = "0x66DCFF4", Slot = "35")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x6DD15C", Offset = "0x6DD15C", VA = "0x66DD15C")]
		private void MaybeFinishAuthentication()
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x6DD3EC", Offset = "0x6DD3EC", VA = "0x66DD3EC")]
		private void PopulateUser(uint authGeneration, GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse response)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x6DD890", Offset = "0x6DD890", VA = "0x66DD890")]
		private void HandleAuthTransition(Types.AuthOperation operation, CommonErrorStatus.AuthStatus status)
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x6DDE88", Offset = "0x6DDE88", VA = "0x66DDE88")]
		private void ToUnauthenticated()
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x6DD744", Offset = "0x6DD744", VA = "0x66DD744", Slot = "6")]
		public void SignOut()
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x6DE014", Offset = "0x6DE014", VA = "0x66DE014", Slot = "7")]
		public string GetUserId()
		{
			return null;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x6DE060", Offset = "0x6DE060", VA = "0x66DE060", Slot = "9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x6DE0AC", Offset = "0x6DE0AC", VA = "0x66DE0AC", Slot = "14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x6DE0F8", Offset = "0x6DE0F8", VA = "0x66DE0F8", Slot = "37")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x6DE20C", Offset = "0x6DE20C", VA = "0x66DE20C", Slot = "15")]
		public void GetPlayerStats(Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x6DE320", Offset = "0x6DE320", VA = "0x66DE320", Slot = "16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x6DE43C", Offset = "0x6DE43C", VA = "0x66DE43C", Slot = "17")]
		public void LoadAchievements(Action<GooglePlayGames.BasicApi.Achievement[]> callback)
		{
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x6DE600", Offset = "0x6DE600", VA = "0x66DE600", Slot = "18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x6DE71C", Offset = "0x6DE71C", VA = "0x66DE71C", Slot = "19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x6DE838", Offset = "0x6DE838", VA = "0x66DE838", Slot = "20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x6DEA14", Offset = "0x6DEA14", VA = "0x66DEA14", Slot = "21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x6DEBF0", Offset = "0x6DEBF0", VA = "0x66DEBF0", Slot = "22")]
		public void ShowAchievementsUI(Action<UIStatus> cb)
		{
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x6DEDA0", Offset = "0x6DEDA0", VA = "0x66DEDA0", Slot = "26")]
		public int LeaderboardMaxResults()
		{
			return 0;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x6DEE0C", Offset = "0x6DEE0C", VA = "0x66DEE0C", Slot = "23")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> cb)
		{
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x6DEFF8", Offset = "0x6DEFF8", VA = "0x66DEFF8", Slot = "24")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x6DF120", Offset = "0x6DF120", VA = "0x66DF120", Slot = "25")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x6DF20C", Offset = "0x6DF20C", VA = "0x66DF20C", Slot = "27")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x6DF3CC", Offset = "0x6DF3CC", VA = "0x66DF3CC", Slot = "28")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x6DF590", Offset = "0x6DF590", VA = "0x66DF590", Slot = "29")]
		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			return null;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x6DF624", Offset = "0x6DF624", VA = "0x66DF624", Slot = "30")]
		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			return null;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x6DF6A8", Offset = "0x6DF6A8", VA = "0x66DF6A8", Slot = "31")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x6DF72C", Offset = "0x6DF72C", VA = "0x66DF72C", Slot = "32")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x6DF7B0", Offset = "0x6DF7B0", VA = "0x66DF7B0", Slot = "33")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x6DC0CC", Offset = "0x6DC0CC", VA = "0x66DC0CC", Slot = "34")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x6DF83C", Offset = "0x6DF83C", VA = "0x66DF83C", Slot = "36")]
		public IntPtr GetApiClient()
		{
			return 0;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000933")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18562C", Offset = "0x18562C")]
		private static void <AsOnGameThreadCallback<T>(T A_0)
		{
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x6DF880", Offset = "0x6DF880", VA = "0x66DF880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18563C", Offset = "0x18563C")]
		private void <InitializeGameServices>m__1(Types.MultiplayerEvent eventType, string matchId, NativeTurnBasedMatch match)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x6DF8D4", Offset = "0x6DF8D4", VA = "0x66DF8D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18564C", Offset = "0x18564C")]
		private void <GetFriends>m__2(bool ok)
		{
		}

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x8")]
		private readonly IClientImpl clientImpl;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0xC")]
		private readonly object GameServicesLock;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x10")]
		private readonly object AuthStateLock;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x14")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x30")]
		private GooglePlayGames.Native.PInvoke.GameServices mServices;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x34")]
		private NativeTurnBasedMultiplayerClient mTurnBasedClient;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x38")]
		private NativeRealtimeMultiplayerClient mRealTimeClient;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x3C")]
		private ISavedGameClient mSavedGameClient;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x40")]
		private IEventsClient mEventsClient;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x44")]
		private IVideoClient mVideoClient;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x48")]
		private TokenClient mTokenClient;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x4C")]
		private Action<Invitation, bool> mInvitationDelegate;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x50")]
		private GooglePlayGames.BasicApi.Multiplayer.Player mUser;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x54")]
		private List<GooglePlayGames.BasicApi.Multiplayer.Player> mFriends;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x58")]
		private Action<bool, string> mPendingAuthCallbacks;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x5C")]
		private NativeClient.AuthState mAuthState;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x60")]
		private uint mAuthGeneration;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x64")]
		private bool friendsLoading;

		// Token: 0x02000146 RID: 326
		[Token(Token = "0x2000124")]
		private enum AuthState
		{
			// Token: 0x04000419 RID: 1049
			[Token(Token = "0x4000399")]
			Unauthenticated,
			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400039A")]
			Authenticated
		}

		// Token: 0x02000147 RID: 327
		[Token(Token = "0x20002D7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F7A0", Offset = "0x17F7A0")]
		private sealed class <Authenticate>c__AnonStorey0
		{
			// Token: 0x0600099C RID: 2460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A6")]
			[Address(RVA = "0x6DAB50", Offset = "0x6DAB50", VA = "0x66DAB50")]
			public <Authenticate>c__AnonStorey0()
			{
			}

			// Token: 0x0600099D RID: 2461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A7")]
			[Address(RVA = "0x6DFBC4", Offset = "0x6DFBC4", VA = "0x66DFBC4")]
			internal void <>m__0(int result)
			{
			}

			// Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A8")]
			[Address(RVA = "0x6DFE28", Offset = "0x6DFE28", VA = "0x66DFE28")]
			private static void <>m__1(GooglePlayGames.BasicApi.Achievement[] ignore)
			{
			}

			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x4001342")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool, string> callback;

			// Token: 0x0400041C RID: 1052
			[Token(Token = "0x4001343")]
			[FieldOffset(Offset = "0xC")]
			internal NativeClient $this;

			// Token: 0x0400041D RID: 1053
			[Token(Token = "0x4001344")]
			[FieldOffset(Offset = "0x0")]
			private static Action<GooglePlayGames.BasicApi.Achievement[]> <>f__am$cache0;
		}

		// Token: 0x02000148 RID: 328
		[Token(Token = "0x20002D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F7B0", Offset = "0x17F7B0")]
		private sealed class <AsOnGameThreadCallback>c__AnonStorey1<T>
		{
			// Token: 0x0600099F RID: 2463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A9")]
			public <AsOnGameThreadCallback>c__AnonStorey1()
			{
			}

			// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AA")]
			internal void <>m__0(T result)
			{
			}

			// Token: 0x0400041E RID: 1054
			[Token(Token = "0x4001345")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T> callback;
		}

		// Token: 0x02000149 RID: 329
		[Token(Token = "0x20002D9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F7C0", Offset = "0x17F7C0")]
		private sealed class <InvokeCallbackOnGameThread>c__AnonStorey2<T, S>
		{
			// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AB")]
			public <InvokeCallbackOnGameThread>c__AnonStorey2()
			{
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AC")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400041F RID: 1055
			[Token(Token = "0x4001346")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T, S> callback;

			// Token: 0x04000420 RID: 1056
			[Token(Token = "0x4001347")]
			[FieldOffset(Offset = "0x0")]
			internal T data;

			// Token: 0x04000421 RID: 1057
			[Token(Token = "0x4001348")]
			[FieldOffset(Offset = "0x0")]
			internal S msg;
		}

		// Token: 0x0200014A RID: 330
		[Token(Token = "0x20002DA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F7D0", Offset = "0x17F7D0")]
		private sealed class <InvokeCallbackOnGameThread>c__AnonStorey3<T>
		{
			// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AD")]
			public <InvokeCallbackOnGameThread>c__AnonStorey3()
			{
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AE")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000422 RID: 1058
			[Token(Token = "0x4001349")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T> callback;

			// Token: 0x04000423 RID: 1059
			[Token(Token = "0x400134A")]
			[FieldOffset(Offset = "0x0")]
			internal T data;
		}

		// Token: 0x0200014B RID: 331
		[Token(Token = "0x20002DB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F7E0", Offset = "0x17F7E0")]
		private sealed class <HandleInvitation>c__AnonStorey4
		{
			// Token: 0x060009A5 RID: 2469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AF")]
			[Address(RVA = "0x6DC880", Offset = "0x6DC880", VA = "0x66DC880")]
			public <HandleInvitation>c__AnonStorey4()
			{
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B0")]
			[Address(RVA = "0x6DFF88", Offset = "0x6DFF88", VA = "0x66DFF88")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000424 RID: 1060
			[Token(Token = "0x400134B")]
			[FieldOffset(Offset = "0x8")]
			internal Action<Invitation, bool> currentHandler;

			// Token: 0x04000425 RID: 1061
			[Token(Token = "0x400134C")]
			[FieldOffset(Offset = "0xC")]
			internal Invitation invite;

			// Token: 0x04000426 RID: 1062
			[Token(Token = "0x400134D")]
			[FieldOffset(Offset = "0x10")]
			internal bool shouldAutolaunch;
		}

		// Token: 0x0200014C RID: 332
		[Token(Token = "0x20002DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F7F0", Offset = "0x17F7F0")]
		private sealed class <LoadFriends>c__AnonStorey5
		{
			// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B1")]
			[Address(RVA = "0x6DCFEC", Offset = "0x6DCFEC", VA = "0x66DCFEC")]
			public <LoadFriends>c__AnonStorey5()
			{
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B2")]
			[Address(RVA = "0x6E05E4", Offset = "0x6E05E4", VA = "0x66E05E4")]
			internal void <>m__0()
			{
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B3")]
			[Address(RVA = "0x6E0660", Offset = "0x6E0660", VA = "0x66E0660")]
			internal void <>m__1()
			{
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B4")]
			[Address(RVA = "0x6E06DC", Offset = "0x6E06DC", VA = "0x66E06DC")]
			internal void <>m__2(ResponseStatus status, List<GooglePlayGames.BasicApi.Multiplayer.Player> players)
			{
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B5")]
			[Address(RVA = "0x6E0944", Offset = "0x6E0944", VA = "0x66E0944")]
			internal void <>m__3()
			{
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B6")]
			[Address(RVA = "0x6E09C0", Offset = "0x6E09C0", VA = "0x66E09C0")]
			internal void <>m__4()
			{
			}

			// Token: 0x04000427 RID: 1063
			[Token(Token = "0x400134E")]
			[FieldOffset(Offset = "0x8")]
			internal Action<bool> callback;

			// Token: 0x04000428 RID: 1064
			[Token(Token = "0x400134F")]
			[FieldOffset(Offset = "0xC")]
			internal NativeClient $this;
		}

		// Token: 0x0200014D RID: 333
		[Token(Token = "0x20002DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F800", Offset = "0x17F800")]
		private sealed class <HandleAuthTransition>c__AnonStorey6
		{
			// Token: 0x060009AD RID: 2477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B7")]
			[Address(RVA = "0x6DDE80", Offset = "0x6DDE80", VA = "0x66DDE80")]
			public <HandleAuthTransition>c__AnonStorey6()
			{
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B8")]
			[Address(RVA = "0x6DFF50", Offset = "0x6DFF50", VA = "0x66DFF50")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse results)
			{
			}

			// Token: 0x04000429 RID: 1065
			[Token(Token = "0x4001350")]
			[FieldOffset(Offset = "0x8")]
			internal uint currentAuthGeneration;

			// Token: 0x0400042A RID: 1066
			[Token(Token = "0x4001351")]
			[FieldOffset(Offset = "0xC")]
			internal NativeClient $this;
		}

		// Token: 0x0200014E RID: 334
		[Token(Token = "0x20002DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F810", Offset = "0x17F810")]
		private sealed class <SetGravityForPopups>c__AnonStorey7
		{
			// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B9")]
			[Address(RVA = "0x6DE204", Offset = "0x6DE204", VA = "0x66DE204")]
			public <SetGravityForPopups>c__AnonStorey7()
			{
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014BA")]
			[Address(RVA = "0x6E0D0C", Offset = "0x6E0D0C", VA = "0x66E0D0C")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400042B RID: 1067
			[Token(Token = "0x4001352")]
			[FieldOffset(Offset = "0x8")]
			internal Gravity gravity;

			// Token: 0x0400042C RID: 1068
			[Token(Token = "0x4001353")]
			[FieldOffset(Offset = "0xC")]
			internal NativeClient $this;
		}

		// Token: 0x0200014F RID: 335
		[Token(Token = "0x20002DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F820", Offset = "0x17F820")]
		private sealed class <GetPlayerStats>c__AnonStorey8
		{
			// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014BB")]
			[Address(RVA = "0x6DE318", Offset = "0x6DE318", VA = "0x66DE318")]
			public <GetPlayerStats>c__AnonStorey8()
			{
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014BC")]
			[Address(RVA = "0x6DFE2C", Offset = "0x6DFE2C", VA = "0x66DFE2C")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400042D RID: 1069
			[Token(Token = "0x4001354")]
			[FieldOffset(Offset = "0x8")]
			internal Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;

			// Token: 0x0400042E RID: 1070
			[Token(Token = "0x4001355")]
			[FieldOffset(Offset = "0xC")]
			internal NativeClient $this;
		}

		// Token: 0x02000150 RID: 336
		[Token(Token = "0x20002E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F830", Offset = "0x17F830")]
		private sealed class <LoadUsers>c__AnonStorey9
		{
			// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014BD")]
			[Address(RVA = "0x6DE434", Offset = "0x6DE434", VA = "0x66DE434")]
			public <LoadUsers>c__AnonStorey9()
			{
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014BE")]
			[Address(RVA = "0x6E0A3C", Offset = "0x6E0A3C", VA = "0x66E0A3C")]
			internal void <>m__0(NativePlayer[] nativeUsers)
			{
			}

			// Token: 0x0400042F RID: 1071
			[Token(Token = "0x4001356")]
			[FieldOffset(Offset = "0x8")]
			internal Action<IUserProfile[]> callback;

			// Token: 0x02000151 RID: 337
			[Token(Token = "0x20002E5")]
			private sealed class <LoadUsers>c__AnonStoreyA
			{
				// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014C7")]
				[Address(RVA = "0x6E0C34", Offset = "0x6E0C34", VA = "0x66E0C34")]
				public <LoadUsers>c__AnonStoreyA()
				{
				}

				// Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014C8")]
				[Address(RVA = "0x6E0C3C", Offset = "0x6E0C3C", VA = "0x66E0C3C")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000430 RID: 1072
				[Token(Token = "0x400135B")]
				[FieldOffset(Offset = "0x8")]
				internal IUserProfile[] users;

				// Token: 0x04000431 RID: 1073
				[Token(Token = "0x400135C")]
				[FieldOffset(Offset = "0xC")]
				internal NativeClient.<LoadUsers>c__AnonStorey9 <>f__ref$9;
			}
		}

		// Token: 0x02000152 RID: 338
		[Token(Token = "0x20002E1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F840", Offset = "0x17F840")]
		private sealed class <LoadAchievements>c__AnonStoreyB
		{
			// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014BF")]
			[Address(RVA = "0x6DE5F8", Offset = "0x6DE5F8", VA = "0x66DE5F8")]
			public <LoadAchievements>c__AnonStoreyB()
			{
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C0")]
			[Address(RVA = "0x6E0018", Offset = "0x6E0018", VA = "0x66E0018")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse response)
			{
			}

			// Token: 0x04000432 RID: 1074
			[Token(Token = "0x4001357")]
			[FieldOffset(Offset = "0x8")]
			internal Action<GooglePlayGames.BasicApi.Achievement[]> callback;
		}

		// Token: 0x02000153 RID: 339
		[Token(Token = "0x20002E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F850", Offset = "0x17F850")]
		private sealed class <ShowAchievementsUI>c__AnonStoreyC
		{
			// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C1")]
			[Address(RVA = "0x6DED98", Offset = "0x6DED98", VA = "0x66DED98")]
			public <ShowAchievementsUI>c__AnonStoreyC()
			{
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C2")]
			[Address(RVA = "0x6E0E30", Offset = "0x6E0E30", VA = "0x66E0E30")]
			internal void <>m__0(CommonErrorStatus.UIStatus result)
			{
			}

			// Token: 0x04000433 RID: 1075
			[Token(Token = "0x4001358")]
			[FieldOffset(Offset = "0x8")]
			internal Action<UIStatus> cb;
		}

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x20002E3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F860", Offset = "0x17F860")]
		private sealed class <ShowLeaderboardUI>c__AnonStoreyD
		{
			// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C3")]
			[Address(RVA = "0x6DEFF0", Offset = "0x6DEFF0", VA = "0x66DEFF0")]
			public <ShowLeaderboardUI>c__AnonStoreyD()
			{
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C4")]
			[Address(RVA = "0x6E0EB0", Offset = "0x6E0EB0", VA = "0x66E0EB0")]
			internal void <>m__0(CommonErrorStatus.UIStatus result)
			{
			}

			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4001359")]
			[FieldOffset(Offset = "0x8")]
			internal Action<UIStatus> cb;
		}

		// Token: 0x02000155 RID: 341
		[Token(Token = "0x20002E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F870", Offset = "0x17F870")]
		private sealed class <RegisterInvitationDelegate>c__AnonStoreyE
		{
			// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C5")]
			[Address(RVA = "0x6DF834", Offset = "0x6DF834", VA = "0x66DF834")]
			public <RegisterInvitationDelegate>c__AnonStoreyE()
			{
			}

			// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C6")]
			[Address(RVA = "0x6E0CD0", Offset = "0x6E0CD0", VA = "0x66E0CD0")]
			internal void <>m__0(Invitation invitation, bool autoAccept)
			{
			}

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x400135A")]
			[FieldOffset(Offset = "0x8")]
			internal InvitationReceivedDelegate invitationDelegate;
		}
	}
}
