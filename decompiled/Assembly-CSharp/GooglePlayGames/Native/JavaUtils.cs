// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.JavaUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Reflection;
using UnityEngine;

namespace GooglePlayGames.Native
{
  internal static class JavaUtils
  {
    private static ConstructorInfo IntPtrConstructor = typeof (AndroidJavaObject).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, (Binder) null, new System.Type[1]{ typeof (IntPtr) }, (ParameterModifier[]) null);

    internal static AndroidJavaObject JavaObjectFromPointer(IntPtr jobject)
    {
      if (jobject == IntPtr.Zero)
        return (AndroidJavaObject) null;
      return (AndroidJavaObject) JavaUtils.IntPtrConstructor.Invoke(new object[1]{ (object) jobject });
    }

    internal static AndroidJavaObject NullSafeCall(this AndroidJavaObject target, string methodName, params object[] args)
    {
      try
      {
        return target.Call<AndroidJavaObject>(methodName, args);
      }
      catch (Exception ex)
      {
        if (ex.Message.Contains("null"))
          return (AndroidJavaObject) null;
        GooglePlayGames.OurUtils.Logger.w("CallObjectMethod exception: " + (object) ex);
        return (AndroidJavaObject) null;
      }
    }
  }
}
