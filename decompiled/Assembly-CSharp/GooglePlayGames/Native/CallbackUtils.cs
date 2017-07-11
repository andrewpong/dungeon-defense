// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.CallbackUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.OurUtils;
using System;

namespace GooglePlayGames.Native
{
  internal static class CallbackUtils
  {
    internal static Action<T> ToOnGameThread<T>(Action<T> toConvert)
    {
      if (toConvert == null)
        return (Action<T>) (param0 => {});
      return (Action<T>) (val => PlayGamesHelperObject.RunOnGameThread((Action) (() => toConvert(val))));
    }

    internal static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
    {
      if (toConvert == null)
        return (Action<T1, T2>) ((param0, param1) => {});
      return (Action<T1, T2>) ((val1, val2) => PlayGamesHelperObject.RunOnGameThread((Action) (() => toConvert(val1, val2))));
    }

    internal static Action<T1, T2, T3> ToOnGameThread<T1, T2, T3>(Action<T1, T2, T3> toConvert)
    {
      if (toConvert == null)
        return (Action<T1, T2, T3>) ((param0, param1, param2) => {});
      return (Action<T1, T2, T3>) ((val1, val2, val3) => PlayGamesHelperObject.RunOnGameThread((Action) (() => toConvert(val1, val2, val3))));
    }
  }
}
