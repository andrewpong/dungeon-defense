// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.OurUtils.PlatformUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
