﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Android.TokenResultCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using Com.Google.Android.Gms.Common.Api;
using System;

namespace GooglePlayGames.Android
{
  internal class TokenResultCallback : ResultCallbackProxy<TokenResult>
  {
    private Action<int, string, string, string> callback;

    public TokenResultCallback(Action<int, string, string, string> callback)
    {
      this.callback = callback;
    }

    public override void OnResult(TokenResult arg_Result_1)
    {
      if (this.callback == null)
        return;
      this.callback(arg_Result_1.getStatusCode(), arg_Result_1.getAccessToken(), arg_Result_1.getIdToken(), arg_Result_1.getEmail());
    }

    public string toString()
    {
      return this.ToString();
    }
  }
}