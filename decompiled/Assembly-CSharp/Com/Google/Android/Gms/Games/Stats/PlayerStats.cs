// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Games.Stats.PlayerStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
