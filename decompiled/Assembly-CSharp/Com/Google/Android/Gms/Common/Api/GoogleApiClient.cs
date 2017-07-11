// Decompiled with JetBrains decompiler
// Type: Com.Google.Android.Gms.Common.Api.GoogleApiClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using Google.Developers;
using System;

namespace Com.Google.Android.Gms.Common.Api
{
  public class GoogleApiClient : JavaObjWrapper
  {
    private const string CLASS_NAME = "com/google/android/gms/common/api/GoogleApiClient";

    public GoogleApiClient(IntPtr ptr)
      : base(ptr)
    {
    }

    public GoogleApiClient()
      : base("com.google.android.gms.common.api.GoogleApiClient")
    {
    }

    public object getContext()
    {
      return this.InvokeCall<object>("getContext", "()Landroid/content/Context;");
    }

    public void connect()
    {
      this.InvokeCallVoid("connect", "()V");
    }

    public void disconnect()
    {
      this.InvokeCallVoid("disconnect", "()V");
    }

    public void dump(string arg_string_1, object arg_object_2, object arg_object_3, string[] arg_string_4)
    {
      this.InvokeCallVoid("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", (object) arg_string_1, arg_object_2, arg_object_3, (object) arg_string_4);
    }

    public ConnectionResult blockingConnect(long arg_long_1, object arg_object_2)
    {
      return this.InvokeCall<ConnectionResult>("blockingConnect", "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/ConnectionResult;", (object) arg_long_1, arg_object_2);
    }

    public ConnectionResult blockingConnect()
    {
      return this.InvokeCall<ConnectionResult>("blockingConnect", "()Lcom/google/android/gms/common/ConnectionResult;");
    }

    public PendingResult<Status> clearDefaultAccountAndReconnect()
    {
      return this.InvokeCall<PendingResult<Status>>("clearDefaultAccountAndReconnect", "()Lcom/google/android/gms/common/api/PendingResult;");
    }

    public ConnectionResult getConnectionResult(object arg_object_1)
    {
      return this.InvokeCall<ConnectionResult>("getConnectionResult", "(Lcom/google/android/gms/common/api/Api;)Lcom/google/android/gms/common/ConnectionResult;", arg_object_1);
    }

    public int getSessionId()
    {
      return this.InvokeCall<int>("getSessionId", "()I");
    }

    public bool isConnecting()
    {
      return this.InvokeCall<bool>("isConnecting", "()Z");
    }

    public bool isConnectionCallbacksRegistered(object arg_object_1)
    {
      return this.InvokeCall<bool>("isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)Z", arg_object_1);
    }

    public bool isConnectionFailedListenerRegistered(object arg_object_1)
    {
      return this.InvokeCall<bool>("isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)Z", arg_object_1);
    }

    public void reconnect()
    {
      this.InvokeCallVoid("reconnect", "()V");
    }

    public void registerConnectionCallbacks(object arg_object_1)
    {
      this.InvokeCallVoid("registerConnectionCallbacks", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", arg_object_1);
    }

    public void registerConnectionFailedListener(object arg_object_1)
    {
      this.InvokeCallVoid("registerConnectionFailedListener", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", arg_object_1);
    }

    public void stopAutoManage(object arg_object_1)
    {
      this.InvokeCallVoid("stopAutoManage", "(Landroid/support/v4/app/FragmentActivity;)V", arg_object_1);
    }

    public void unregisterConnectionCallbacks(object arg_object_1)
    {
      this.InvokeCallVoid("unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", arg_object_1);
    }

    public void unregisterConnectionFailedListener(object arg_object_1)
    {
      this.InvokeCallVoid("unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", arg_object_1);
    }

    public bool hasConnectedApi(object arg_object_1)
    {
      return this.InvokeCall<bool>("hasConnectedApi", "(Lcom/google/android/gms/common/api/Api;)Z", arg_object_1);
    }

    public object getLooper()
    {
      return this.InvokeCall<object>("getLooper", "()Landroid/os/Looper;");
    }

    public bool isConnected()
    {
      return this.InvokeCall<bool>("isConnected", "()Z");
    }
  }
}
