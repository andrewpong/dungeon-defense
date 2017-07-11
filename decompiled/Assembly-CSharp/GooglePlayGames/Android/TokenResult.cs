// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Android.TokenResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
      return new Status(this.InvokeCall<IntPtr>(nameof (getStatus), "()Lcom/google/android/gms/common/api/Status;"));
    }

    public int getStatusCode()
    {
      return this.InvokeCall<int>(nameof (getStatusCode), "()I");
    }

    public string getAccessToken()
    {
      return this.InvokeCall<string>(nameof (getAccessToken), "()Ljava/lang/String;");
    }

    public string getEmail()
    {
      return this.InvokeCall<string>(nameof (getEmail), "()Ljava/lang/String;");
    }

    public string getIdToken()
    {
      return this.InvokeCall<string>(nameof (getIdToken), "()Ljava/lang/String;");
    }
  }
}
