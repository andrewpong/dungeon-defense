// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Games.Stats.PlayerStatsObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
        return JavaObjWrapper.GetStaticFloatField("com/google/android/gms/games/stats/PlayerStats", nameof (UNSET_VALUE));
      }
    }

    public static int CONTENTS_FILE_DESCRIPTOR
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/games/stats/PlayerStats", nameof (CONTENTS_FILE_DESCRIPTOR));
      }
    }

    public static int PARCELABLE_WRITE_RETURN_VALUE
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/games/stats/PlayerStats", nameof (PARCELABLE_WRITE_RETURN_VALUE));
      }
    }

    public PlayerStatsObject(IntPtr ptr)
      : base(ptr)
    {
    }

    public float getAverageSessionLength()
    {
      return this.InvokeCall<float>(nameof (getAverageSessionLength), "()F");
    }

    public float getChurnProbability()
    {
      return this.InvokeCall<float>(nameof (getChurnProbability), "()F");
    }

    public int getDaysSinceLastPlayed()
    {
      return this.InvokeCall<int>(nameof (getDaysSinceLastPlayed), "()I");
    }

    public int getNumberOfPurchases()
    {
      return this.InvokeCall<int>(nameof (getNumberOfPurchases), "()I");
    }

    public int getNumberOfSessions()
    {
      return this.InvokeCall<int>(nameof (getNumberOfSessions), "()I");
    }

    public float getSessionPercentile()
    {
      return this.InvokeCall<float>(nameof (getSessionPercentile), "()F");
    }

    public float getSpendPercentile()
    {
      return this.InvokeCall<float>(nameof (getSpendPercentile), "()F");
    }

    public float getSpendProbability()
    {
      return this.InvokeCall<float>(nameof (getSpendProbability), "()F");
    }

    public float getHighSpenderProbability()
    {
      return this.InvokeCall<float>(nameof (getHighSpenderProbability), "()F");
    }

    public float getTotalSpendNext28Days()
    {
      return this.InvokeCall<float>(nameof (getTotalSpendNext28Days), "()F");
    }
  }
}
