// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.PlayGamesClientFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.Android;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native;
using UnityEngine;

namespace GooglePlayGames
{
  internal class PlayGamesClientFactory
  {
    internal static IPlayGamesClient GetPlatformPlayGamesClient(PlayGamesClientConfiguration config)
    {
      if (Application.isEditor)
      {
        GooglePlayGames.OurUtils.Logger.d("Creating IPlayGamesClient in editor, using DummyClient.");
        return (IPlayGamesClient) new DummyClient();
      }
      GooglePlayGames.OurUtils.Logger.d("Creating Android IPlayGamesClient Client");
      return (IPlayGamesClient) new NativeClient(config, (IClientImpl) new AndroidClient());
    }
  }
}
