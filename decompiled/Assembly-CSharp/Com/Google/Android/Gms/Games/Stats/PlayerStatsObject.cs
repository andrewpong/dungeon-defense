// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Games.Stats.PlayerStatsObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using Google.Developers;
using System;

namespace Com.Google.Android.Gms.Games.Stats
{
  public class PlayerStatsObject : JavaObjWrapper, PlayerStats
  {
    private const string CLASS_NAME = "com/google/android/gms/games/stats/PlayerStats";

    public static float UNSET_VALUE
    {
      get
      {
        return JavaObjWrapper.GetStaticFloatField("com/google/android/gms/games/stats/PlayerStats", "UNSET_VALUE");
      }
    }

    public static int CONTENTS_FILE_DESCRIPTOR
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/games/stats/PlayerStats", "CONTENTS_FILE_DESCRIPTOR");
      }
    }

    public static int PARCELABLE_WRITE_RETURN_VALUE
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/games/stats/PlayerStats", "PARCELABLE_WRITE_RETURN_VALUE");
      }
    }

    public PlayerStatsObject(IntPtr ptr)
      : base(ptr)
    {
    }

    public float getAverageSessionLength()
    {
      return this.InvokeCall<float>("getAverageSessionLength", "()F");
    }

    public float getChurnProbability()
    {
      return this.InvokeCall<float>("getChurnProbability", "()F");
    }

    public int getDaysSinceLastPlayed()
    {
      return this.InvokeCall<int>("getDaysSinceLastPlayed", "()I");
    }

    public int getNumberOfPurchases()
    {
      return this.InvokeCall<int>("getNumberOfPurchases", "()I");
    }

    public int getNumberOfSessions()
    {
      return this.InvokeCall<int>("getNumberOfSessions", "()I");
    }

    public float getSessionPercentile()
    {
      return this.InvokeCall<float>("getSessionPercentile", "()F");
    }

    public float getSpendPercentile()
    {
      return this.InvokeCall<float>("getSpendPercentile", "()F");
    }

    public float getSpendProbability()
    {
      return this.InvokeCall<float>("getSpendProbability", "()F");
    }

    public float getHighSpenderProbability()
    {
      return this.InvokeCall<float>("getHighSpenderProbability", "()F");
    }

    public float getTotalSpendNext28Days()
    {
      return this.InvokeCall<float>("getTotalSpendNext28Days", "()F");
    }
  }
}
