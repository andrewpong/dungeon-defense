// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Android.TokenResultCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
