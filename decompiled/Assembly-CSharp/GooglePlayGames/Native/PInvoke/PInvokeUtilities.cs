﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.PInvokeUtilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace GooglePlayGames.Native.PInvoke
{
  internal static class PInvokeUtilities
  {
    private static readonly DateTime UnixEpoch = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);

    internal static HandleRef CheckNonNull(HandleRef reference)
    {
      if (PInvokeUtilities.IsNull(reference))
        throw new InvalidOperationException();
      return reference;
    }

    internal static bool IsNull(HandleRef reference)
    {
      return PInvokeUtilities.IsNull(HandleRef.ToIntPtr(reference));
    }

    internal static bool IsNull(IntPtr pointer)
    {
      return pointer.Equals((object) IntPtr.Zero);
    }

    internal static DateTime FromMillisSinceUnixEpoch(long millisSinceEpoch)
    {
      return PInvokeUtilities.UnixEpoch.Add(TimeSpan.FromMilliseconds((double) millisSinceEpoch));
    }

    internal static string OutParamsToString(PInvokeUtilities.OutStringMethod outStringMethod)
    {
      UIntPtr out_size = outStringMethod((StringBuilder) null, UIntPtr.Zero);
      if (out_size.Equals((object) UIntPtr.Zero))
        return (string) null;
      StringBuilder out_string = new StringBuilder((int) out_size.ToUInt32());
      IntPtr num = (IntPtr) outStringMethod(out_string, out_size);
      return out_string.ToString();
    }

    internal static T[] OutParamsToArray<T>(PInvokeUtilities.OutMethod<T> outMethod)
    {
      UIntPtr out_size = outMethod((T[]) null, UIntPtr.Zero);
      if (out_size.Equals((object) UIntPtr.Zero))
        return new T[0];
      T[] out_bytes = new T[out_size.ToUInt64()];
      IntPtr num = (IntPtr) outMethod(out_bytes, out_size);
      return out_bytes;
    }

    [DebuggerHidden]
    internal static IEnumerable<T> ToEnumerable<T>(UIntPtr size, Func<UIntPtr, T> getElement)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PInvokeUtilities.\u003CToEnumerable\u003Ec__Iterator0<T> enumerableCIterator0 = new PInvokeUtilities.\u003CToEnumerable\u003Ec__Iterator0<T>() { size = size, getElement = getElement };
      // ISSUE: reference to a compiler-generated field
      enumerableCIterator0.\u0024PC = -2;
      return (IEnumerable<T>) enumerableCIterator0;
    }

    internal static IEnumerator<T> ToEnumerator<T>(UIntPtr size, Func<UIntPtr, T> getElement)
    {
      return PInvokeUtilities.ToEnumerable<T>(size, getElement).GetEnumerator();
    }

    internal static UIntPtr ArrayToSizeT<T>(T[] array)
    {
      if (array == null)
        return UIntPtr.Zero;
      return new UIntPtr((ulong) array.Length);
    }

    internal static long ToMilliseconds(TimeSpan span)
    {
      double totalMilliseconds = span.TotalMilliseconds;
      if (totalMilliseconds > (double) long.MaxValue)
        return long.MaxValue;
      if (totalMilliseconds < (double) long.MinValue)
        return long.MinValue;
      return Convert.ToInt64(totalMilliseconds);
    }

    internal delegate UIntPtr OutStringMethod(StringBuilder out_string, UIntPtr out_size);

    internal delegate UIntPtr OutMethod<T>([In, Out] T[] out_bytes, UIntPtr out_size);
  }
}
