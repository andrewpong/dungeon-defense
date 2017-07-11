// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.TokenClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi;
using System;

namespace GooglePlayGames
{
  internal interface TokenClient
  {
    string GetEmail();

    void GetEmail(Action<CommonStatusCodes, string> callback);

    string GetAccessToken();

    void GetIdToken(string serverClientId, Action<string> idTokenCallback);

    void SetRationale(string rationale);
  }
}
