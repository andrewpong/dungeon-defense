// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.ScorePageToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace GooglePlayGames.BasicApi
{
  public class ScorePageToken
  {
    private string mId;
    private object mInternalObject;
    private LeaderboardCollection mCollection;
    private LeaderboardTimeSpan mTimespan;

    public LeaderboardCollection Collection
    {
      get
      {
        return this.mCollection;
      }
    }

    public LeaderboardTimeSpan TimeSpan
    {
      get
      {
        return this.mTimespan;
      }
    }

    public string LeaderboardId
    {
      get
      {
        return this.mId;
      }
    }

    internal object InternalObject
    {
      get
      {
        return this.mInternalObject;
      }
    }

    internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan)
    {
      this.mInternalObject = internalObject;
      this.mId = id;
      this.mCollection = collection;
      this.mTimespan = timespan;
    }
  }
}
