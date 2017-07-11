// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.PlayGamesClientFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
