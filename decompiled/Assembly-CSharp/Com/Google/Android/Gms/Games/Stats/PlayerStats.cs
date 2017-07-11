// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Games.Stats.PlayerStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Com.Google.Android.Gms.Games.Stats
{
  public interface PlayerStats
  {
    float getAverageSessionLength();

    float getChurnProbability();

    int getDaysSinceLastPlayed();

    int getNumberOfPurchases();

    int getNumberOfSessions();

    float getSessionPercentile();

    float getSpendPercentile();

    float getSpendProbability();

    float getHighSpenderProbability();

    float getTotalSpendNext28Days();
  }
}
