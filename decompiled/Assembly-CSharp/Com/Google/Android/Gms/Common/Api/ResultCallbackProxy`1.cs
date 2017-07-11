// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Common.Api.ResultCallbackProxy`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using Google.Developers;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
  public abstract class ResultCallbackProxy<R> : JavaInterfaceProxy, ResultCallback<R> where R : Result
  {
    private const string CLASS_NAME = "com/google/android/gms/common/api/ResultCallback";

    public ResultCallbackProxy()
      : base("com/google/android/gms/common/api/ResultCallback")
    {
    }

    public abstract void OnResult(R arg_Result_1);

    public void onResult(R arg_Result_1)
    {
      this.OnResult(arg_Result_1);
    }

    public void onResult(AndroidJavaObject arg_Result_1)
    {
      IntPtr rawObject = arg_Result_1.GetRawObject();
      ConstructorInfo constructor = typeof (R).GetConstructor(new System.Type[1]
      {
        rawObject.GetType()
      });
      R arg_Result_1_1;
      if (constructor != null)
      {
        arg_Result_1_1 = (R) constructor.Invoke(new object[1]
        {
          (object) rawObject
        });
      }
      else
      {
        arg_Result_1_1 = (R) typeof (R).GetConstructor(new System.Type[0]).Invoke(new object[0]);
        Marshal.PtrToStructure(rawObject, (object) arg_Result_1_1);
      }
      this.OnResult(arg_Result_1_1);
    }
  }
}
