// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Common.ConnectionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using Google.Developers;
using System;

namespace Com.Google.Android.Gms.Common
{
  public class ConnectionResult : JavaObjWrapper
  {
    private const string CLASS_NAME = "com/google/android/gms/common/ConnectionResult";

    public static int SUCCESS
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SUCCESS");
      }
    }

    public static int SERVICE_MISSING
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SERVICE_MISSING");
      }
    }

    public static int SERVICE_VERSION_UPDATE_REQUIRED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SERVICE_VERSION_UPDATE_REQUIRED");
      }
    }

    public static int SERVICE_DISABLED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SERVICE_DISABLED");
      }
    }

    public static int SIGN_IN_REQUIRED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SIGN_IN_REQUIRED");
      }
    }

    public static int INVALID_ACCOUNT
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "INVALID_ACCOUNT");
      }
    }

    public static int RESOLUTION_REQUIRED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "RESOLUTION_REQUIRED");
      }
    }

    public static int NETWORK_ERROR
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "NETWORK_ERROR");
      }
    }

    public static int INTERNAL_ERROR
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "INTERNAL_ERROR");
      }
    }

    public static int SERVICE_INVALID
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SERVICE_INVALID");
      }
    }

    public static int DEVELOPER_ERROR
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "DEVELOPER_ERROR");
      }
    }

    public static int LICENSE_CHECK_FAILED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "LICENSE_CHECK_FAILED");
      }
    }

    public static int CANCELED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "CANCELED");
      }
    }

    public static int TIMEOUT
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "TIMEOUT");
      }
    }

    public static int INTERRUPTED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "INTERRUPTED");
      }
    }

    public static int API_UNAVAILABLE
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "API_UNAVAILABLE");
      }
    }

    public static int SIGN_IN_FAILED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SIGN_IN_FAILED");
      }
    }

    public static int SERVICE_UPDATING
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SERVICE_UPDATING");
      }
    }

    public static int SERVICE_MISSING_PERMISSION
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "SERVICE_MISSING_PERMISSION");
      }
    }

    public static int DRIVE_EXTERNAL_STORAGE_REQUIRED
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "DRIVE_EXTERNAL_STORAGE_REQUIRED");
      }
    }

    public static object CREATOR
    {
      get
      {
        return JavaObjWrapper.GetStaticObjectField<object>("com/google/android/gms/common/ConnectionResult", "CREATOR", "Landroid/os/Parcelable$Creator;");
      }
    }

    public static string NULL
    {
      get
      {
        return JavaObjWrapper.GetStaticStringField("com/google/android/gms/common/ConnectionResult", "NULL");
      }
    }

    public static int CONTENTS_FILE_DESCRIPTOR
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "CONTENTS_FILE_DESCRIPTOR");
      }
    }

    public static int PARCELABLE_WRITE_RETURN_VALUE
    {
      get
      {
        return JavaObjWrapper.GetStaticIntField("com/google/android/gms/common/ConnectionResult", "PARCELABLE_WRITE_RETURN_VALUE");
      }
    }

    public ConnectionResult(IntPtr ptr)
      : base(ptr)
    {
    }

    public ConnectionResult(int arg_int_1, object arg_object_2, string arg_string_3)
    {
      this.CreateInstance("com/google/android/gms/common/ConnectionResult", (object) arg_int_1, arg_object_2, (object) arg_string_3);
    }

    public ConnectionResult(int arg_int_1, object arg_object_2)
    {
      this.CreateInstance("com/google/android/gms/common/ConnectionResult", (object) arg_int_1, arg_object_2);
    }

    public ConnectionResult(int arg_int_1)
    {
      this.CreateInstance("com/google/android/gms/common/ConnectionResult", (object) arg_int_1);
    }

    public bool equals(object arg_object_1)
    {
      return this.InvokeCall<bool>("equals", "(Ljava/lang/Object;)Z", arg_object_1);
    }

    public string toString()
    {
      return this.InvokeCall<string>("toString", "()Ljava/lang/String;");
    }

    public int hashCode()
    {
      return this.InvokeCall<int>("hashCode", "()I");
    }

    public int describeContents()
    {
      return this.InvokeCall<int>("describeContents", "()I");
    }

    public object getResolution()
    {
      return this.InvokeCall<object>("getResolution", "()Landroid/app/PendingIntent;");
    }

    public bool hasResolution()
    {
      return this.InvokeCall<bool>("hasResolution", "()Z");
    }

    public void startResolutionForResult(object arg_object_1, int arg_int_2)
    {
      this.InvokeCallVoid("startResolutionForResult", "(Landroid/app/Activity;I)V", arg_object_1, (object) arg_int_2);
    }

    public void writeToParcel(object arg_object_1, int arg_int_2)
    {
      this.InvokeCallVoid("writeToParcel", "(Landroid/os/Parcel;I)V", arg_object_1, (object) arg_int_2);
    }

    public int getErrorCode()
    {
      return this.InvokeCall<int>("getErrorCode", "()I");
    }

    public string getErrorMessage()
    {
      return this.InvokeCall<string>("getErrorMessage", "()Ljava/lang/String;");
    }

    public bool isSuccess()
    {
      return this.InvokeCall<bool>("isSuccess", "()Z");
    }
  }
}
