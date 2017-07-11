﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.PlayGamesScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
  public class PlayGamesScore : IScore
  {
    private string mPlayerId = string.Empty;
    private string mMetadata = string.Empty;
    private DateTime mDate = new DateTime(1970, 1, 1, 0, 0, 0);
    private string mLbId;
    private long mValue;
    private ulong mRank;

    public string leaderboardID
    {
      get
      {
        return this.mLbId;
      }
      set
      {
        this.mLbId = value;
      }
    }

    public long value
    {
      get
      {
        return this.mValue;
      }
      set
      {
        this.mValue = value;
      }
    }

    public DateTime date
    {
      get
      {
        return this.mDate;
      }
    }

    public string formattedValue
    {
      get
      {
        return this.mValue.ToString();
      }
    }

    public string userID
    {
      get
      {
        return this.mPlayerId;
      }
    }

    public int rank
    {
      get
      {
        return (int) this.mRank;
      }
    }

    internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
    {
      this.mDate = date;
      this.mLbId = this.leaderboardID;
      this.mRank = rank;
      this.mPlayerId = playerId;
      this.mValue = (long) value;
      this.mMetadata = metadata;
    }

    public void ReportScore(Action<bool> callback)
    {
      PlayGamesPlatform.Instance.ReportScore(this.mValue, this.mLbId, this.mMetadata, callback);
    }
  }
}
