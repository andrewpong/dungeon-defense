// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.Callbacks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal static class Callbacks
  {
    internal static readonly Action<CommonErrorStatus.UIStatus> NoopUICallback = (Action<CommonErrorStatus.UIStatus>) (status => Logger.d("Received UI callback: " + (object) status));

    internal static IntPtr ToIntPtr<T>(Action<T> callback, Func<IntPtr, T> conversionFunction) where T : BaseReferenceHolder
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return Callbacks.ToIntPtr((Delegate) new Action<IntPtr>(new Callbacks.\u003CToIntPtr\u003Ec__AnonStorey0<T>() { conversionFunction = conversionFunction, callback = callback }.\u003C\u003Em__0));
    }

    internal static IntPtr ToIntPtr<T, P>(Action<T, P> callback, Func<IntPtr, P> conversionFunction) where P : BaseReferenceHolder
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return Callbacks.ToIntPtr((Delegate) new Action<T, IntPtr>(new Callbacks.\u003CToIntPtr\u003Ec__AnonStorey1<T, P>() { conversionFunction = conversionFunction, callback = callback }.\u003C\u003Em__0));
    }

    internal static IntPtr ToIntPtr(Delegate callback)
    {
      if ((object) callback == null)
        return IntPtr.Zero;
      return GCHandle.ToIntPtr(GCHandle.Alloc((object) callback));
    }

    internal static T IntPtrToTempCallback<T>(IntPtr handle) where T : class
    {
      return Callbacks.IntPtrToCallback<T>(handle, true);
    }

    private static T IntPtrToCallback<T>(IntPtr handle, bool unpinHandle) where T : class
    {
      if (PInvokeUtilities.IsNull(handle))
        return (T) null;
      GCHandle gcHandle = GCHandle.FromIntPtr(handle);
      try
      {
        return (T) gcHandle.Target;
      }
      catch (InvalidCastException ex)
      {
        Logger.e("GC Handle pointed to unexpected type: " + gcHandle.Target.ToString() + ". Expected " + (object) typeof (T));
        throw ex;
      }
      finally
      {
        if (unpinHandle)
          gcHandle.Free();
      }
    }

    internal static T IntPtrToPermanentCallback<T>(IntPtr handle) where T : class
    {
      return Callbacks.IntPtrToCallback<T>(handle, false);
    }

    [MonoPInvokeCallback(typeof (Callbacks.ShowUICallbackInternal))]
    internal static void InternalShowUICallback(CommonErrorStatus.UIStatus status, IntPtr data)
    {
      Logger.d("Showing UI Internal callback: " + (object) status);
      Action<CommonErrorStatus.UIStatus> tempCallback = Callbacks.IntPtrToTempCallback<Action<CommonErrorStatus.UIStatus>>(data);
      try
      {
        tempCallback(status);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing InternalShowAllUICallback. Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal static void PerformInternalCallback(string callbackName, Callbacks.Type callbackType, IntPtr response, IntPtr userData)
    {
      Logger.d("Entering internal callback for " + callbackName);
      Action<IntPtr> action = callbackType != Callbacks.Type.Permanent ? Callbacks.IntPtrToTempCallback<Action<IntPtr>>(userData) : Callbacks.IntPtrToPermanentCallback<Action<IntPtr>>(userData);
      if (action == null)
        return;
      try
      {
        action(response);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing " + callbackName + ". Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal static void PerformInternalCallback<T>(string callbackName, Callbacks.Type callbackType, T param1, IntPtr param2, IntPtr userData)
    {
      Logger.d("Entering internal callback for " + callbackName);
      Action<T, IntPtr> action;
      try
      {
        action = callbackType != Callbacks.Type.Permanent ? Callbacks.IntPtrToTempCallback<Action<T, IntPtr>>(userData) : Callbacks.IntPtrToPermanentCallback<Action<T, IntPtr>>(userData);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered converting " + callbackName + ". Smothering to avoid passing exception into Native: " + (object) ex);
        return;
      }
      Logger.d("Internal Callback converted to action");
      if (action == null)
        return;
      try
      {
        action(param1, param2);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing " + callbackName + ". Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal static Action<T> AsOnGameThreadCallback<T>(Action<T> toInvokeOnGameThread)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return new Action<T>(new Callbacks.\u003CAsOnGameThreadCallback\u003Ec__AnonStorey2<T>() { toInvokeOnGameThread = toInvokeOnGameThread }.\u003C\u003Em__0);
    }

    internal static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return new Action<T1, T2>(new Callbacks.\u003CAsOnGameThreadCallback\u003Ec__AnonStorey4<T1, T2>() { toInvokeOnGameThread = toInvokeOnGameThread }.\u003C\u003Em__0);
    }

    internal static void AsCoroutine(IEnumerator routine)
    {
      PlayGamesHelperObject.RunCoroutine(routine);
    }

    internal static byte[] IntPtrAndSizeToByteArray(IntPtr data, UIntPtr dataLength)
    {
      if ((long) dataLength.ToUInt64() == 0L)
        return (byte[]) null;
      byte[] destination = new byte[(IntPtr) dataLength.ToUInt32()];
      Marshal.Copy(data, destination, 0, (int) dataLength.ToUInt32());
      return destination;
    }

    internal delegate void ShowUICallbackInternal(CommonErrorStatus.UIStatus status, IntPtr data);

    internal enum Type
    {
      Permanent,
      Temporary,
    }
  }
}
