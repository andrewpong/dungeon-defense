// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class RealTimeEventListenerHelper : BaseReferenceHolder
  {
    internal RealTimeEventListenerHelper(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_Dispose(selfPointer);
    }

    internal RealTimeEventListenerHelper SetOnRoomStatusChangedCallback(Action<NativeRealTimeRoom> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache0 = new GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomStatusChangedCallback(RealTimeEventListenerHelper.InternalOnRoomStatusChangedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomStatusChangedCallback fMgCache0 = RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache0;
      IntPtr callbackPointer = RealTimeEventListenerHelper.ToCallbackPointer(callback);
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnRoomStatusChangedCallback(self, fMgCache0, callbackPointer);
      return this;
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomStatusChangedCallback))]
    internal static void InternalOnRoomStatusChangedCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("RealTimeEventListenerHelper#InternalOnRoomStatusChangedCallback", Callbacks.Type.Permanent, response, data);
    }

    internal RealTimeEventListenerHelper SetOnRoomConnectedSetChangedCallback(Action<NativeRealTimeRoom> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback(RealTimeEventListenerHelper.InternalOnRoomConnectedSetChangedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback fMgCache1 = RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache1;
      IntPtr callbackPointer = RealTimeEventListenerHelper.ToCallbackPointer(callback);
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnRoomConnectedSetChangedCallback(self, fMgCache1, callbackPointer);
      return this;
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback))]
    internal static void InternalOnRoomConnectedSetChangedCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("RealTimeEventListenerHelper#InternalOnRoomConnectedSetChangedCallback", Callbacks.Type.Permanent, response, data);
    }

    internal RealTimeEventListenerHelper SetOnP2PConnectedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache2 = new GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PConnectedCallback(RealTimeEventListenerHelper.InternalOnP2PConnectedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PConnectedCallback fMgCache2 = RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache2;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnP2PConnectedCallback(self, fMgCache2, intPtr);
      return this;
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PConnectedCallback))]
    internal static void InternalOnP2PConnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
    {
      RealTimeEventListenerHelper.PerformRoomAndParticipantCallback("InternalOnP2PConnectedCallback", room, participant, data);
    }

    internal RealTimeEventListenerHelper SetOnP2PDisconnectedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache3 = new GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PDisconnectedCallback(RealTimeEventListenerHelper.InternalOnP2PDisconnectedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PDisconnectedCallback fMgCache3 = RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache3;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnP2PDisconnectedCallback(self, fMgCache3, intPtr);
      return this;
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PDisconnectedCallback))]
    internal static void InternalOnP2PDisconnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
    {
      RealTimeEventListenerHelper.PerformRoomAndParticipantCallback("InternalOnP2PDisconnectedCallback", room, participant, data);
    }

    internal RealTimeEventListenerHelper SetOnParticipantStatusChangedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache4 = new GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnParticipantStatusChangedCallback(RealTimeEventListenerHelper.InternalOnParticipantStatusChangedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnParticipantStatusChangedCallback fMgCache4 = RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache4;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnParticipantStatusChangedCallback(self, fMgCache4, intPtr);
      return this;
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnParticipantStatusChangedCallback))]
    internal static void InternalOnParticipantStatusChangedCallback(IntPtr room, IntPtr participant, IntPtr data)
    {
      RealTimeEventListenerHelper.PerformRoomAndParticipantCallback("InternalOnParticipantStatusChangedCallback", room, participant, data);
    }

    internal static void PerformRoomAndParticipantCallback(string callbackName, IntPtr room, IntPtr participant, IntPtr data)
    {
      Logger.d("Entering " + callbackName);
      try
      {
        NativeRealTimeRoom nativeRealTimeRoom = NativeRealTimeRoom.FromPointer(room);
        using (MultiplayerParticipant multiplayerParticipant = MultiplayerParticipant.FromPointer(participant))
        {
          Action<NativeRealTimeRoom, MultiplayerParticipant> permanentCallback = Callbacks.IntPtrToPermanentCallback<Action<NativeRealTimeRoom, MultiplayerParticipant>>(data);
          if (permanentCallback == null)
            return;
          permanentCallback(nativeRealTimeRoom, multiplayerParticipant);
        }
      }
      catch (Exception ex)
      {
        Logger.e("Error encountered executing " + callbackName + ". Smothering to avoid passing exception into Native: " + (object) ex);
      }
    }

    internal RealTimeEventListenerHelper SetOnDataReceivedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant, byte[], bool> callback)
    {
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      Logger.d("OnData Callback has addr: " + (object) intPtr.ToInt64());
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache5 = new GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnDataReceivedCallback(RealTimeEventListenerHelper.InternalOnDataReceived);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnDataReceivedCallback fMgCache5 = RealTimeEventListenerHelper.\u003C\u003Ef__mg\u0024cache5;
      IntPtr callback_arg = intPtr;
      GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnDataReceivedCallback(self, fMgCache5, callback_arg);
      return this;
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnDataReceivedCallback))]
    internal static void InternalOnDataReceived(IntPtr room, IntPtr participant, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
    {
      Logger.d("Entering InternalOnDataReceived: " + (object) userData.ToInt64());
      Action<NativeRealTimeRoom, MultiplayerParticipant, byte[], bool> permanentCallback = Callbacks.IntPtrToPermanentCallback<Action<NativeRealTimeRoom, MultiplayerParticipant, byte[], bool>>(userData);
      using (NativeRealTimeRoom nativeRealTimeRoom = NativeRealTimeRoom.FromPointer(room))
      {
        using (MultiplayerParticipant multiplayerParticipant = MultiplayerParticipant.FromPointer(participant))
        {
          if (permanentCallback == null)
            return;
          byte[] destination = (byte[]) null;
          if ((long) dataLength.ToUInt64() != 0L)
          {
            destination = new byte[(IntPtr) dataLength.ToUInt32()];
            Marshal.Copy(data, destination, 0, (int) dataLength.ToUInt32());
          }
          try
          {
            permanentCallback(nativeRealTimeRoom, multiplayerParticipant, destination, isReliable);
          }
          catch (Exception ex)
          {
            Logger.e("Error encountered executing InternalOnDataReceived. Smothering to avoid passing exception into Native: " + (object) ex);
          }
        }
      }
    }

    private static IntPtr ToCallbackPointer(Action<NativeRealTimeRoom> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return Callbacks.ToIntPtr((Delegate) new Action<IntPtr>(new RealTimeEventListenerHelper.\u003CToCallbackPointer\u003Ec__AnonStorey0() { callback = callback }.\u003C\u003Em__0));
    }

    internal static RealTimeEventListenerHelper Create()
    {
      return new RealTimeEventListenerHelper(GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_Construct());
    }
  }
}
