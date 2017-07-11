// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.PlayGamesAchievement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi;
using System;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
  internal class PlayGamesAchievement : IAchievement, IAchievementDescription
  {
    private string mId = string.Empty;
    private DateTime mLastModifiedTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
    private string mTitle = string.Empty;
    private string mRevealedImageUrl = string.Empty;
    private string mUnlockedImageUrl = string.Empty;
    private string mDescription = string.Empty;
    private readonly ReportProgress mProgressCallback;
    private bool mIsIncremental;
    private int mCurrentSteps;
    private int mTotalSteps;
    private double mPercentComplete;
    private bool mCompleted;
    private bool mHidden;
    private WWW mImageFetcher;
    private Texture2D mImage;
    private ulong mPoints;

    public string id
    {
      get
      {
        return this.mId;
      }
      set
      {
        this.mId = value;
      }
    }

    public bool isIncremental
    {
      get
      {
        return this.mIsIncremental;
      }
    }

    public int currentSteps
    {
      get
      {
        return this.mCurrentSteps;
      }
    }

    public int totalSteps
    {
      get
      {
        return this.mTotalSteps;
      }
    }

    public double percentCompleted
    {
      get
      {
        return this.mPercentComplete;
      }
      set
      {
        this.mPercentComplete = value;
      }
    }

    public bool completed
    {
      get
      {
        return this.mCompleted;
      }
    }

    public bool hidden
    {
      get
      {
        return this.mHidden;
      }
    }

    public DateTime lastReportedDate
    {
      get
      {
        return this.mLastModifiedTime;
      }
    }

    public string title
    {
      get
      {
        return this.mTitle;
      }
    }

    public Texture2D image
    {
      get
      {
        return this.LoadImage();
      }
    }

    public string achievedDescription
    {
      get
      {
        return this.mDescription;
      }
    }

    public string unachievedDescription
    {
      get
      {
        return this.mDescription;
      }
    }

    public int points
    {
      get
      {
        return (int) this.mPoints;
      }
    }

    internal PlayGamesAchievement()
      : this(new ReportProgress(PlayGamesPlatform.Instance.ReportProgress))
    {
    }

    internal PlayGamesAchievement(ReportProgress progressCallback)
    {
      this.mProgressCallback = progressCallback;
    }

    internal PlayGamesAchievement(Achievement ach)
      : this()
    {
      this.mId = ach.Id;
      this.mIsIncremental = ach.IsIncremental;
      this.mCurrentSteps = ach.CurrentSteps;
      this.mTotalSteps = ach.TotalSteps;
      this.mPercentComplete = !ach.IsIncremental ? (!ach.IsUnlocked ? 0.0 : 100.0) : (ach.TotalSteps <= 0 ? 0.0 : (double) ach.CurrentSteps / (double) ach.TotalSteps * 100.0);
      this.mCompleted = ach.IsUnlocked;
      this.mHidden = !ach.IsRevealed;
      this.mLastModifiedTime = ach.LastModifiedTime;
      this.mTitle = ach.Name;
      this.mDescription = ach.Description;
      this.mPoints = ach.Points;
      this.mRevealedImageUrl = ach.RevealedImageUrl;
      this.mUnlockedImageUrl = ach.UnlockedImageUrl;
    }

    public void ReportProgress(Action<bool> callback)
    {
      this.mProgressCallback(this.mId, this.mPercentComplete, callback);
    }

    private Texture2D LoadImage()
    {
      if (this.hidden)
        return (Texture2D) null;
      string url = !this.completed ? this.mRevealedImageUrl : this.mUnlockedImageUrl;
      if (!string.IsNullOrEmpty(url))
      {
        if (this.mImageFetcher == null || this.mImageFetcher.url != url)
        {
          this.mImageFetcher = new WWW(url);
          this.mImage = (Texture2D) null;
        }
        if ((UnityEngine.Object) this.mImage != (UnityEngine.Object) null)
          return this.mImage;
        if (this.mImageFetcher.isDone)
        {
          this.mImage = this.mImageFetcher.texture;
          return this.mImage;
        }
      }
      return (Texture2D) null;
    }
  }
}
