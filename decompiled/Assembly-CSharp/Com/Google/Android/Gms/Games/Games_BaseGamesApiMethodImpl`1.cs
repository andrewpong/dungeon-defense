// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Games.Games_BaseGamesApiMethodImpl`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using System;

namespace Com.Google.Android.Gms.Games
{
  public class Games_BaseGamesApiMethodImpl<R> : JavaObjWrapper where R : Result
  {
    private const string CLASS_NAME = "com/google/android/gms/games/Games$BaseGamesApiMethodImpl";

    public Games_BaseGamesApiMethodImpl(IntPtr ptr)
      : base(ptr)
    {
    }

    public Games_BaseGamesApiMethodImpl(GoogleApiClient arg_GoogleApiClient_1)
    {
      this.CreateInstance("com/google/android/gms/games/Games$BaseGamesApiMethodImpl", (object) arg_GoogleApiClient_1);
    }
  }
}
