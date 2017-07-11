// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.TokenClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
