// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Nearby.AdvertisingResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.OurUtils;

namespace GooglePlayGames.BasicApi.Nearby
{
  public struct AdvertisingResult
  {
    private readonly ResponseStatus mStatus;
    private readonly string mLocalEndpointName;

    public bool Succeeded
    {
      get
      {
        return this.mStatus == ResponseStatus.Success;
      }
    }

    public ResponseStatus Status
    {
      get
      {
        return this.mStatus;
      }
    }

    public string LocalEndpointName
    {
      get
      {
        return this.mLocalEndpointName;
      }
    }

    public AdvertisingResult(ResponseStatus status, string localEndpointName)
    {
      this.mStatus = status;
      this.mLocalEndpointName = Misc.CheckNotNull<string>(localEndpointName);
    }
  }
}
