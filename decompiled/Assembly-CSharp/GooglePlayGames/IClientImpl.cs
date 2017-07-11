// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.IClientImpl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.PInvoke;
using System;

namespace GooglePlayGames
{
  internal interface IClientImpl
  {
    PlatformConfiguration CreatePlatformConfiguration();

    TokenClient CreateTokenClient(string playerId, bool reset);

    void GetPlayerStats(IntPtr apiClientPtr, Action<CommonStatusCodes, PlayerStats> callback);
  }
}
