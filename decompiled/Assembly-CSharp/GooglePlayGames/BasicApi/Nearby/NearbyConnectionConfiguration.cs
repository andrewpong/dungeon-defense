// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Nearby.NearbyConnectionConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.OurUtils;
using System;

namespace GooglePlayGames.BasicApi.Nearby
{
  public struct NearbyConnectionConfiguration
  {
    public const int MaxUnreliableMessagePayloadLength = 1168;
    public const int MaxReliableMessagePayloadLength = 4096;
    private readonly Action<InitializationStatus> mInitializationCallback;
    private readonly long mLocalClientId;

    public long LocalClientId
    {
      get
      {
        return this.mLocalClientId;
      }
    }

    public Action<InitializationStatus> InitializationCallback
    {
      get
      {
        return this.mInitializationCallback;
      }
    }

    public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
    {
      this.mInitializationCallback = Misc.CheckNotNull<Action<InitializationStatus>>(callback);
      this.mLocalClientId = localClientId;
    }
  }
}
