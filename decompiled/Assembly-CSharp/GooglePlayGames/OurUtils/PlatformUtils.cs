// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.OurUtils.PlatformUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
  public static class PlatformUtils
  {
    public static bool Supported
    {
      get
      {
        AndroidJavaObject androidJavaObject1 = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity").Call<AndroidJavaObject>("getPackageManager");
        AndroidJavaObject androidJavaObject2;
        try
        {
          androidJavaObject2 = androidJavaObject1.Call<AndroidJavaObject>("getLaunchIntentForPackage", new object[1]
          {
            (object) "com.google.android.play.games"
          });
        }
        catch (Exception ex)
        {
          return false;
        }
        return androidJavaObject2 != null;
      }
    }
  }
}
