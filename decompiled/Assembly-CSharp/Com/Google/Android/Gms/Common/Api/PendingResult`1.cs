﻿// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Common.Api.PendingResult`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using Google.Developers;
using System;

namespace Com.Google.Android.Gms.Common.Api
{
  public class PendingResult<R> : JavaObjWrapper where R : Result
  {
    private const string CLASS_NAME = "com/google/android/gms/common/api/PendingResult";

    public PendingResult(IntPtr ptr)
      : base(ptr)
    {
    }

    public PendingResult()
      : base("com.google.android.gms.common.api.PendingResult")
    {
    }

    public R await(long arg_long_1, object arg_object_2)
    {
      return this.InvokeCall<R>("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/api/Result;", (object) arg_long_1, arg_object_2);
    }

    public R await()
    {
      return this.InvokeCall<R>("await", "()Lcom/google/android/gms/common/api/Result;");
    }

    public bool isCanceled()
    {
      return this.InvokeCall<bool>("isCanceled", "()Z");
    }

    public void cancel()
    {
      this.InvokeCallVoid("cancel", "()V");
    }

    public void setResultCallback(ResultCallback<R> arg_ResultCallback_1)
    {
      this.InvokeCallVoid("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;)V", (object) arg_ResultCallback_1);
    }

    public void setResultCallback(ResultCallback<R> arg_ResultCallback_1, long arg_long_2, object arg_object_3)
    {
      this.InvokeCallVoid("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", (object) arg_ResultCallback_1, (object) arg_long_2, arg_object_3);
    }
  }
}
