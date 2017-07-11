// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.LeaderboardManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Native.PInvoke
{
  internal class LeaderboardManager
  {
    private readonly GameServices mServices;

    internal int LeaderboardMaxResults
    {
      get
      {
        return 25;
      }
    }

    internal LeaderboardManager(GameServices services)
    {
      this.mServices = Misc.CheckNotNull<GameServices>(services);
    }

    internal void SubmitScore(string leaderboardId, long score, string metadata)
    {
      Misc.CheckNotNull<string>(leaderboardId, nameof (leaderboardId));
      Logger.d("Native Submitting score: " + (object) score + " for lb " + leaderboardId + " with metadata: " + metadata);
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_SubmitScore(this.mServices.AsHandle(), leaderboardId, (ulong) score, metadata ?? string.Empty);
    }

    internal void ShowAllUI(Action<CommonErrorStatus.UIStatus> callback)
    {
      Misc.CheckNotNull<Action<CommonErrorStatus.UIStatus>>(callback);
      HandleRef self = this.mServices.AsHandle();
      // ISSUE: reference to a compiler-generated field
      if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LeaderboardManager.\u003C\u003Ef__mg\u0024cache0 = new GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowAllUICallback(Callbacks.InternalShowUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowAllUICallback fMgCache0 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_ShowAllUI(self, fMgCache0, intPtr);
    }

    internal void ShowUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, Action<CommonErrorStatus.UIStatus> callback)
    {
      Misc.CheckNotNull<Action<CommonErrorStatus.UIStatus>>(callback);
      HandleRef self = this.mServices.AsHandle();
      string leaderboard_id = leaderboardId;
      int num = (int) span;
      // ISSUE: reference to a compiler-generated field
      if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LeaderboardManager.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowUICallback(Callbacks.InternalShowUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowUICallback fMgCache1 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache1;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_ShowUI(self, leaderboard_id, (Types.LeaderboardTimeSpan) num, fMgCache1, intPtr);
    }

    public void LoadLeaderboardData(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, string playerId, Action<LeaderboardScoreData> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      LeaderboardManager.\u003CLoadLeaderboardData\u003Ec__AnonStorey0 dataCAnonStorey0 = new LeaderboardManager.\u003CLoadLeaderboardData\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      dataCAnonStorey0.playerId = playerId;
      // ISSUE: reference to a compiler-generated field
      dataCAnonStorey0.rowCount = rowCount;
      // ISSUE: reference to a compiler-generated field
      dataCAnonStorey0.callback = callback;
      // ISSUE: reference to a compiler-generated field
      dataCAnonStorey0.\u0024this = this;
      NativeScorePageToken nativeScorePageToken = new NativeScorePageToken(GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_ScorePageToken(this.mServices.AsHandle(), leaderboardId, (Types.LeaderboardStart) start, (Types.LeaderboardTimeSpan) timeSpan, (Types.LeaderboardCollection) collection));
      // ISSUE: reference to a compiler-generated field
      dataCAnonStorey0.token = new ScorePageToken((object) nativeScorePageToken, leaderboardId, collection, timeSpan);
      HandleRef self = this.mServices.AsHandle();
      int num = 1;
      string leaderboard_id = leaderboardId;
      // ISSUE: reference to a compiler-generated field
      if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LeaderboardManager.\u003C\u003Ef__mg\u0024cache3 = new GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchCallback(LeaderboardManager.InternalFetchCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchCallback fMgCache3 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache3;
      // ISSUE: reference to a compiler-generated method
      Action<FetchResponse> callback1 = new Action<FetchResponse>(dataCAnonStorey0.\u003C\u003Em__0);
      // ISSUE: reference to a compiler-generated field
      if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LeaderboardManager.\u003C\u003Ef__mg\u0024cache2 = new Func<IntPtr, FetchResponse>(FetchResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, FetchResponse> fMgCache2 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache2;
      IntPtr intPtr = Callbacks.ToIntPtr<FetchResponse>(callback1, fMgCache2);
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_Fetch(self, (Types.DataSource) num, leaderboard_id, fMgCache3, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchCallback))]
    private static void InternalFetchCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("LeaderboardManager#InternalFetchCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void HandleFetch(ScorePageToken token, FetchResponse response, string selfPlayerId, int maxResults, Action<LeaderboardScoreData> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      LeaderboardManager.\u003CHandleFetch\u003Ec__AnonStorey1 fetchCAnonStorey1 = new LeaderboardManager.\u003CHandleFetch\u003Ec__AnonStorey1();
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey1.selfPlayerId = selfPlayerId;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey1.maxResults = maxResults;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey1.token = token;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey1.callback = callback;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey1.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey1.data = new LeaderboardScoreData(fetchCAnonStorey1.token.LeaderboardId, (GooglePlayGames.BasicApi.ResponseStatus) response.GetStatus());
      if (response.GetStatus() != CommonErrorStatus.ResponseStatus.VALID && response.GetStatus() != CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
      {
        Logger.w("Error returned from fetch: " + (object) response.GetStatus());
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        fetchCAnonStorey1.callback(fetchCAnonStorey1.data);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        fetchCAnonStorey1.data.Title = response.Leaderboard().Title();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        fetchCAnonStorey1.data.Id = fetchCAnonStorey1.token.LeaderboardId;
        HandleRef self = this.mServices.AsHandle();
        int num = 1;
        // ISSUE: reference to a compiler-generated field
        string leaderboardId = fetchCAnonStorey1.token.LeaderboardId;
        // ISSUE: reference to a compiler-generated field
        int timeSpan = (int) fetchCAnonStorey1.token.TimeSpan;
        // ISSUE: reference to a compiler-generated field
        int collection = (int) fetchCAnonStorey1.token.Collection;
        // ISSUE: reference to a compiler-generated field
        if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache5 == null)
        {
          // ISSUE: reference to a compiler-generated field
          LeaderboardManager.\u003C\u003Ef__mg\u0024cache5 = new GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScoreSummaryCallback(LeaderboardManager.InternalFetchSummaryCallback);
        }
        // ISSUE: reference to a compiler-generated field
        GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScoreSummaryCallback fMgCache5 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache5;
        // ISSUE: reference to a compiler-generated method
        Action<FetchScoreSummaryResponse> callback1 = new Action<FetchScoreSummaryResponse>(fetchCAnonStorey1.\u003C\u003Em__0);
        // ISSUE: reference to a compiler-generated field
        if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache4 == null)
        {
          // ISSUE: reference to a compiler-generated field
          LeaderboardManager.\u003C\u003Ef__mg\u0024cache4 = new Func<IntPtr, FetchScoreSummaryResponse>(FetchScoreSummaryResponse.FromPointer);
        }
        // ISSUE: reference to a compiler-generated field
        Func<IntPtr, FetchScoreSummaryResponse> fMgCache4 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache4;
        IntPtr intPtr = Callbacks.ToIntPtr<FetchScoreSummaryResponse>(callback1, fMgCache4);
        GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummary(self, (Types.DataSource) num, leaderboardId, (Types.LeaderboardTimeSpan) timeSpan, (Types.LeaderboardCollection) collection, fMgCache5, intPtr);
      }
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScoreSummaryCallback))]
    private static void InternalFetchSummaryCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("LeaderboardManager#InternalFetchSummaryCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void HandleFetchScoreSummary(LeaderboardScoreData data, FetchScoreSummaryResponse response, string selfPlayerId, int maxResults, ScorePageToken token, Action<LeaderboardScoreData> callback)
    {
      if (response.GetStatus() != CommonErrorStatus.ResponseStatus.VALID && response.GetStatus() != CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
      {
        Logger.w("Error returned from fetchScoreSummary: " + (object) response);
        data.Status = (GooglePlayGames.BasicApi.ResponseStatus) response.GetStatus();
        callback(data);
      }
      else
      {
        NativeScoreSummary scoreSummary = response.GetScoreSummary();
        data.ApproximateCount = scoreSummary.ApproximateResults();
        data.PlayerScore = (IScore) scoreSummary.LocalUserScore().AsScore(data.Id, selfPlayerId);
        if (maxResults <= 0)
          callback(data);
        else
          this.LoadScorePage(data, maxResults, token, callback);
      }
    }

    public void LoadScorePage(LeaderboardScoreData data, int maxResults, ScorePageToken token, Action<LeaderboardScoreData> callback)
    {
      if (data == null)
        data = new LeaderboardScoreData(token.LeaderboardId);
      NativeScorePageToken internalObject = (NativeScorePageToken) token.InternalObject;
      HandleRef self = this.mServices.AsHandle();
      int num1 = 1;
      IntPtr token1 = internalObject.AsPointer();
      int num2 = maxResults;
      // ISSUE: reference to a compiler-generated field
      if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache7 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LeaderboardManager.\u003C\u003Ef__mg\u0024cache7 = new GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScorePageCallback(LeaderboardManager.InternalFetchScorePage);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScorePageCallback fMgCache7 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache7;
      Action<FetchScorePageResponse> callback1 = (Action<FetchScorePageResponse>) (rsp => this.HandleFetchScorePage(data, token, rsp, callback));
      // ISSUE: reference to a compiler-generated field
      if (LeaderboardManager.\u003C\u003Ef__mg\u0024cache6 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LeaderboardManager.\u003C\u003Ef__mg\u0024cache6 = new Func<IntPtr, FetchScorePageResponse>(FetchScorePageResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, FetchScorePageResponse> fMgCache6 = LeaderboardManager.\u003C\u003Ef__mg\u0024cache6;
      IntPtr intPtr = Callbacks.ToIntPtr<FetchScorePageResponse>(callback1, fMgCache6);
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePage(self, (Types.DataSource) num1, token1, (uint) num2, fMgCache7, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScorePageCallback))]
    private static void InternalFetchScorePage(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("LeaderboardManager#InternalFetchScorePage", Callbacks.Type.Temporary, response, data);
    }

    internal void HandleFetchScorePage(LeaderboardScoreData data, ScorePageToken token, FetchScorePageResponse rsp, Action<LeaderboardScoreData> callback)
    {
      data.Status = (GooglePlayGames.BasicApi.ResponseStatus) rsp.GetStatus();
      if (rsp.GetStatus() != CommonErrorStatus.ResponseStatus.VALID && rsp.GetStatus() != CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
        callback(data);
      NativeScorePage scorePage = rsp.GetScorePage();
      if (!scorePage.Valid())
        callback(data);
      if (scorePage.HasNextScorePage())
        data.NextPageToken = new ScorePageToken((object) scorePage.GetNextScorePageToken(), token.LeaderboardId, token.Collection, token.TimeSpan);
      if (scorePage.HasPrevScorePage())
        data.PrevPageToken = new ScorePageToken((object) scorePage.GetPreviousScorePageToken(), token.LeaderboardId, token.Collection, token.TimeSpan);
      foreach (NativeScoreEntry nativeScoreEntry in scorePage)
        data.AddScore(nativeScoreEntry.AsScore(data.Id));
      callback(data);
    }
  }
}
