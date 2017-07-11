// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Games.Stats.StatsObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using System;

namespace Com.Google.Android.Gms.Games.Stats
{
  public class StatsObject : JavaObjWrapper, Com.Google.Android.Gms.Games.Stats.Stats
  {
    private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats";

    public StatsObject(IntPtr ptr)
      : base(ptr)
    {
    }

    public PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2)
    {
      return new PendingResult<Stats_LoadPlayerStatsResultObject>(this.InvokeCall<IntPtr>(nameof (loadPlayerStats), "(Lcom/google/android/gms/common/api/GoogleApiClient;Z)Lcom/google/android/gms/common/api/PendingResult;", (object) arg_GoogleApiClient_1, (object) arg_bool_2));
    }
  }
}
