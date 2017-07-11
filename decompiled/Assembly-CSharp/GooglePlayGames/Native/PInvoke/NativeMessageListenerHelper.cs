// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeMessageListenerHelper : BaseReferenceHolder
  {
    internal NativeMessageListenerHelper()
      : base(MessageListenerHelper.MessageListenerHelper_Construct())
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      MessageListenerHelper.MessageListenerHelper_Dispose(selfPointer);
    }

    internal void SetOnMessageReceivedCallback(NativeMessageListenerHelper.OnMessageReceived callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (NativeMessageListenerHelper.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NativeMessageListenerHelper.\u003C\u003Ef__mg\u0024cache0 = new MessageListenerHelper.OnMessageReceivedCallback(NativeMessageListenerHelper.InternalOnMessageReceivedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      MessageListenerHelper.OnMessageReceivedCallback fMgCache0 = NativeMessageListenerHelper.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      MessageListenerHelper.MessageListenerHelper_SetOnMessageReceivedCallback(self, fMgCache0, intPtr);
    }

    [MonoPInvokeCallback(typeof (MessageListenerHelper.OnMessageReceivedCallback))]
    private static void InternalOnMessageReceivedCallback(long id, string name, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
    {
      NativeMessageListenerHelper.OnMessageReceived permanentCallback = Callbacks.IntPtrToPermanentCallback<NativeMessageListenerHelper.OnMessageReceived>(userData);
      if (permanentCallback == null)
        return;
      try
      {
        permanentCallback(id, name, Callbacks.IntPtrAndSizeToByteArray(data, dataLength), isReliable);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing NativeMessageListenerHelper#InternalOnMessageReceivedCallback. Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal void SetOnDisconnectedCallback(Action<long, string> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (NativeMessageListenerHelper.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NativeMessageListenerHelper.\u003C\u003Ef__mg\u0024cache1 = new MessageListenerHelper.OnDisconnectedCallback(NativeMessageListenerHelper.InternalOnDisconnectedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      MessageListenerHelper.OnDisconnectedCallback fMgCache1 = NativeMessageListenerHelper.\u003C\u003Ef__mg\u0024cache1;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      MessageListenerHelper.MessageListenerHelper_SetOnDisconnectedCallback(self, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (MessageListenerHelper.OnDisconnectedCallback))]
    private static void InternalOnDisconnectedCallback(long id, string lostEndpointId, IntPtr userData)
    {
      Action<long, string> permanentCallback = Callbacks.IntPtrToPermanentCallback<Action<long, string>>(userData);
      if (permanentCallback == null)
        return;
      try
      {
        permanentCallback(id, lostEndpointId);
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing NativeMessageListenerHelper#InternalOnDisconnectedCallback. Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal delegate void OnMessageReceived(long localClientId, string remoteEndpointId, byte[] data, bool isReliable);
  }
}
