// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.CallbackUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;

namespace GooglePlayGames.Native
{
  internal static class CallbackUtils
  {
    internal static Action<T> ToOnGameThread<T>(Action<T> toConvert)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CallbackUtils.\u003CToOnGameThread\u003Ec__AnonStorey0<T> threadCAnonStorey0 = new CallbackUtils.\u003CToOnGameThread\u003Ec__AnonStorey0<T>();
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey0.toConvert = toConvert;
      // ISSUE: reference to a compiler-generated field
      if (threadCAnonStorey0.toConvert == null)
        return (Action<T>) (param0 => {});
      // ISSUE: reference to a compiler-generated method
      return new Action<T>(threadCAnonStorey0.\u003C\u003Em__0);
    }

    internal static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CallbackUtils.\u003CToOnGameThread\u003Ec__AnonStorey2<T1, T2> threadCAnonStorey2 = new CallbackUtils.\u003CToOnGameThread\u003Ec__AnonStorey2<T1, T2>();
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey2.toConvert = toConvert;
      // ISSUE: reference to a compiler-generated field
      if (threadCAnonStorey2.toConvert == null)
        return (Action<T1, T2>) ((param0, param1) => {});
      // ISSUE: reference to a compiler-generated method
      return new Action<T1, T2>(threadCAnonStorey2.\u003C\u003Em__0);
    }

    internal static Action<T1, T2, T3> ToOnGameThread<T1, T2, T3>(Action<T1, T2, T3> toConvert)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CallbackUtils.\u003CToOnGameThread\u003Ec__AnonStorey4<T1, T2, T3> threadCAnonStorey4 = new CallbackUtils.\u003CToOnGameThread\u003Ec__AnonStorey4<T1, T2, T3>();
      // ISSUE: reference to a compiler-generated field
      threadCAnonStorey4.toConvert = toConvert;
      // ISSUE: reference to a compiler-generated field
      if (threadCAnonStorey4.toConvert == null)
        return (Action<T1, T2, T3>) ((param0, param1, param2) => {});
      // ISSUE: reference to a compiler-generated method
      return new Action<T1, T2, T3>(threadCAnonStorey4.\u003C\u003Em__0);
    }
  }
}
