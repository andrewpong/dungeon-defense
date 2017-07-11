// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Android.TokenResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using System;

namespace GooglePlayGames.Android
{
  internal class TokenResult : JavaObjWrapper, Result
  {
    public TokenResult(IntPtr ptr)
      : base(ptr)
    {
    }

    public Status getStatus()
    {
      return new Status(this.InvokeCall<IntPtr>("getStatus", "()Lcom/google/android/gms/common/api/Status;"));
    }

    public int getStatusCode()
    {
      return this.InvokeCall<int>("getStatusCode", "()I");
    }

    public string getAccessToken()
    {
      return this.InvokeCall<string>("getAccessToken", "()Ljava/lang/String;");
    }

    public string getEmail()
    {
      return this.InvokeCall<string>("getEmail", "()Ljava/lang/String;");
    }

    public string getIdToken()
    {
      return this.InvokeCall<string>("getIdToken", "()Ljava/lang/String;");
    }
  }
}
