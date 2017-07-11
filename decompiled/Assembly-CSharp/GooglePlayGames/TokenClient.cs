// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.TokenClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
