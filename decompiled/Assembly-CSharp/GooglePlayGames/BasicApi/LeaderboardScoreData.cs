// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.LeaderboardScoreData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
  public class LeaderboardScoreData
  {
    private List<PlayGamesScore> mScores = new List<PlayGamesScore>();
    private string mId;
    private ResponseStatus mStatus;
    private ulong mApproxCount;
    private string mTitle;
    private IScore mPlayerScore;
    private ScorePageToken mPrevPage;
    private ScorePageToken mNextPage;

    public bool Valid
    {
      get
      {
        if (this.mStatus != ResponseStatus.Success)
          return this.mStatus == ResponseStatus.SuccessWithStale;
        return true;
      }
    }

    public ResponseStatus Status
    {
      get
      {
        return this.mStatus;
      }
      internal set
      {
        this.mStatus = value;
      }
    }

    public ulong ApproximateCount
    {
      get
      {
        return this.mApproxCount;
      }
      internal set
      {
        this.mApproxCount = value;
      }
    }

    public string Title
    {
      get
      {
        return this.mTitle;
      }
      internal set
      {
        this.mTitle = value;
      }
    }

    public string Id
    {
      get
      {
        return this.mId;
      }
      internal set
      {
        this.mId = value;
      }
    }

    public IScore PlayerScore
    {
      get
      {
        return this.mPlayerScore;
      }
      internal set
      {
        this.mPlayerScore = value;
      }
    }

    public IScore[] Scores
    {
      get
      {
        return (IScore[]) this.mScores.ToArray();
      }
    }

    public ScorePageToken PrevPageToken
    {
      get
      {
        return this.mPrevPage;
      }
      internal set
      {
        this.mPrevPage = value;
      }
    }

    public ScorePageToken NextPageToken
    {
      get
      {
        return this.mNextPage;
      }
      internal set
      {
        this.mNextPage = value;
      }
    }

    internal LeaderboardScoreData(string leaderboardId)
    {
      this.mId = leaderboardId;
    }

    internal LeaderboardScoreData(string leaderboardId, ResponseStatus status)
    {
      this.mId = leaderboardId;
      this.mStatus = status;
    }

    internal int AddScore(PlayGamesScore score)
    {
      this.mScores.Add(score);
      return this.mScores.Count;
    }

    public override string ToString()
    {
      return string.Format("[LeaderboardScoreData: mId={0},  mStatus={1}, mApproxCount={2}, mTitle={3}]", (object) this.mId, (object) this.mStatus, (object) this.mApproxCount, (object) this.mTitle);
    }
  }
}
