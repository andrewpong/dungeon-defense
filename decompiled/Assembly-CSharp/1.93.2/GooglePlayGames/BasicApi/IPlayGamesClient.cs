using System;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000040")]
	public interface IPlayGamesClient
	{
		// Token: 0x0600036D RID: 877
		[Token(Token = "0x6000341")]
		void Authenticate(Action<bool, string> callback, bool silent);

		// Token: 0x0600036E RID: 878
		[Token(Token = "0x6000342")]
		bool IsAuthenticated();

		// Token: 0x0600036F RID: 879
		[Token(Token = "0x6000343")]
		void SignOut();

		// Token: 0x06000370 RID: 880
		[Token(Token = "0x6000344")]
		string GetUserId();

		// Token: 0x06000371 RID: 881
		[Token(Token = "0x6000345")]
		void LoadFriends(Action<bool> callback);

		// Token: 0x06000372 RID: 882
		[Token(Token = "0x6000346")]
		string GetUserDisplayName();

		// Token: 0x06000373 RID: 883
		[Token(Token = "0x6000347")]
		string GetIdToken();

		// Token: 0x06000374 RID: 884
		[Token(Token = "0x6000348")]
		string GetServerAuthCode();

		// Token: 0x06000375 RID: 885
		[Token(Token = "0x6000349")]
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);

		// Token: 0x06000376 RID: 886
		[Token(Token = "0x600034A")]
		string GetUserEmail();

		// Token: 0x06000377 RID: 887
		[Token(Token = "0x600034B")]
		string GetUserImageUrl();

		// Token: 0x06000378 RID: 888
		[Token(Token = "0x600034C")]
		void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);

		// Token: 0x06000379 RID: 889
		[Token(Token = "0x600034D")]
		void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);

		// Token: 0x0600037A RID: 890
		[Token(Token = "0x600034E")]
		void LoadAchievements(Action<Achievement[]> callback);

		// Token: 0x0600037B RID: 891
		[Token(Token = "0x600034F")]
		void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		// Token: 0x0600037C RID: 892
		[Token(Token = "0x6000350")]
		void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		// Token: 0x0600037D RID: 893
		[Token(Token = "0x6000351")]
		void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

		// Token: 0x0600037E RID: 894
		[Token(Token = "0x6000352")]
		void SetStepsAtLeast(string achId, int steps, Action<bool> callback);

		// Token: 0x0600037F RID: 895
		[Token(Token = "0x6000353")]
		void ShowAchievementsUI(Action<UIStatus> callback);

		// Token: 0x06000380 RID: 896
		[Token(Token = "0x6000354")]
		void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);

		// Token: 0x06000381 RID: 897
		[Token(Token = "0x6000355")]
		void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);

		// Token: 0x06000382 RID: 898
		[Token(Token = "0x6000356")]
		void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);

		// Token: 0x06000383 RID: 899
		[Token(Token = "0x6000357")]
		int LeaderboardMaxResults();

		// Token: 0x06000384 RID: 900
		[Token(Token = "0x6000358")]
		void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

		// Token: 0x06000385 RID: 901
		[Token(Token = "0x6000359")]
		void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);

		// Token: 0x06000386 RID: 902
		[Token(Token = "0x600035A")]
		IRealTimeMultiplayerClient GetRtmpClient();

		// Token: 0x06000387 RID: 903
		[Token(Token = "0x600035B")]
		ITurnBasedMultiplayerClient GetTbmpClient();

		// Token: 0x06000388 RID: 904
		[Token(Token = "0x600035C")]
		ISavedGameClient GetSavedGameClient();

		// Token: 0x06000389 RID: 905
		[Token(Token = "0x600035D")]
		IEventsClient GetEventsClient();

		// Token: 0x0600038A RID: 906
		[Token(Token = "0x600035E")]
		IVideoClient GetVideoClient();

		// Token: 0x0600038B RID: 907
		[Token(Token = "0x600035F")]
		void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate);

		// Token: 0x0600038C RID: 908
		[Token(Token = "0x6000360")]
		IUserProfile[] GetFriends();

		// Token: 0x0600038D RID: 909
		[Token(Token = "0x6000361")]
		IntPtr GetApiClient();

		// Token: 0x0600038E RID: 910
		[Token(Token = "0x6000362")]
		void SetGravityForPopups(Gravity gravity);
	}
}
