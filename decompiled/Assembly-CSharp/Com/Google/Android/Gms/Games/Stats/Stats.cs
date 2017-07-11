// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Games.Stats.Stats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using Com.Google.Android.Gms.Common.Api;

namespace Com.Google.Android.Gms.Games.Stats
{
  public interface Stats
  {
    PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2);
  }
}
