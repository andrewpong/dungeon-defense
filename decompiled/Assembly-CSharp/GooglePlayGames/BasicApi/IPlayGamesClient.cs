// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.IPlayGamesClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.Quests;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
  public interface IPlayGamesClient
  {
    void Authenticate(Action<bool, string> callback, bool silent);

    bool IsAuthenticated();

    void SignOut();

    string GetToken();

    string GetUserId();

    void LoadFriends(Action<bool> callback);

    string GetUserDisplayName();

    void GetIdToken(Action<string> idTokenCallback);

    string GetAccessToken();

    void GetServerAuthCode(string serverClientId, Action<CommonStatusCodes, string> callback);

    string GetUserEmail();

    void GetUserEmail(Action<CommonStatusCodes, string> callback);

    string GetUserImageUrl();

    void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);

    void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);

    Achievement GetAchievement(string achievementId);

    void LoadAchievements(Action<Achievement[]> callback);

    void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

    void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

    void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

    void SetStepsAtLeast(string achId, int steps, Action<bool> callback);

    void ShowAchievementsUI(Action<UIStatus> callback);

    void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);

    void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);

    void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);

    int LeaderboardMaxResults();

    void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

    void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);

    IRealTimeMultiplayerClient GetRtmpClient();

    ITurnBasedMultiplayerClient GetTbmpClient();

    ISavedGameClient GetSavedGameClient();

    IEventsClient GetEventsClient();

    IQuestsClient GetQuestsClient();

    void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate);

    IUserProfile[] GetFriends();

    IntPtr GetApiClient();
  }
}
