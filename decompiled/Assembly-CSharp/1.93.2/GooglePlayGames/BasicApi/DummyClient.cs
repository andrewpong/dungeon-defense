using System;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x200003C")]
	public class DummyClient : IPlayGamesClient
	{
		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x94082C", Offset = "0x94082C", VA = "0x694082C")]
		public DummyClient()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x940834", Offset = "0x940834", VA = "0x6940834", Slot = "4")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x940944", Offset = "0x940944", VA = "0x6940944", Slot = "5")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x940958", Offset = "0x940958", VA = "0x6940958", Slot = "6")]
		public void SignOut()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x94095C", Offset = "0x94095C", VA = "0x694095C", Slot = "10")]
		public string GetIdToken()
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x940970", Offset = "0x940970", VA = "0x6940970", Slot = "7")]
		public string GetUserId()
		{
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x9409CC", Offset = "0x9409CC", VA = "0x69409CC", Slot = "11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x9409E0", Offset = "0x9409E0", VA = "0x69409E0", Slot = "12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x940A5C", Offset = "0x940A5C", VA = "0x6940A5C", Slot = "13")]
		public string GetUserEmail()
		{
			return null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x940AE8", Offset = "0x940AE8", VA = "0x6940AE8", Slot = "15")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x940BB0", Offset = "0x940BB0", VA = "0x6940BB0", Slot = "9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x940C0C", Offset = "0x940C0C", VA = "0x6940C0C", Slot = "14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x940C20", Offset = "0x940C20", VA = "0x6940C20", Slot = "16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x940C94", Offset = "0x940C94", VA = "0x6940C94", Slot = "17")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x940D08", Offset = "0x940D08", VA = "0x6940D08", Slot = "18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x940D7C", Offset = "0x940D7C", VA = "0x6940D7C", Slot = "19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x940DF0", Offset = "0x940DF0", VA = "0x6940DF0", Slot = "20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x940E64", Offset = "0x940E64", VA = "0x6940E64", Slot = "21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x940ED8", Offset = "0x940ED8", VA = "0x6940ED8", Slot = "22")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x940F4C", Offset = "0x940F4C", VA = "0x6940F4C", Slot = "23")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x940FC0", Offset = "0x940FC0", VA = "0x6940FC0", Slot = "26")]
		public int LeaderboardMaxResults()
		{
			return 0;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x940FC8", Offset = "0x940FC8", VA = "0x6940FC8", Slot = "24")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x9410FC", Offset = "0x9410FC", VA = "0x69410FC", Slot = "25")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x9411B4", Offset = "0x9411B4", VA = "0x69411B4", Slot = "27")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x941228", Offset = "0x941228", VA = "0x6941228", Slot = "28")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x94129C", Offset = "0x94129C", VA = "0x694129C", Slot = "29")]
		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			return null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x9412B0", Offset = "0x9412B0", VA = "0x69412B0", Slot = "30")]
		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			return null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x9412C4", Offset = "0x9412C4", VA = "0x69412C4", Slot = "31")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x9412D8", Offset = "0x9412D8", VA = "0x69412D8", Slot = "32")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x9412EC", Offset = "0x9412EC", VA = "0x69412EC", Slot = "33")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x941300", Offset = "0x941300", VA = "0x6941300", Slot = "34")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x941304", Offset = "0x941304", VA = "0x6941304")]
		public Invitation GetInvitationFromNotification()
		{
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x941318", Offset = "0x941318", VA = "0x6941318")]
		public bool HasInvitationFromNotification()
		{
			return default(bool);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x94132C", Offset = "0x94132C", VA = "0x694132C", Slot = "8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x9413A8", Offset = "0x9413A8", VA = "0x69413A8", Slot = "35")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x94140C", Offset = "0x94140C", VA = "0x694140C", Slot = "36")]
		public IntPtr GetApiClient()
		{
			return 0;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x94145C", Offset = "0x94145C", VA = "0x694145C", Slot = "37")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x9408B8", Offset = "0x9408B8", VA = "0x69408B8")]
		private static void LogUsage()
		{
		}
	}
}
