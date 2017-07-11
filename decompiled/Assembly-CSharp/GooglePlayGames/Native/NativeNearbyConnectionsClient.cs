// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.NativeNearbyConnectionsClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GooglePlayGames.Native
{
  internal class NativeNearbyConnectionsClient : INearbyConnectionClient
  {
    private readonly NearbyConnectionsManager mManager;

    internal NativeNearbyConnectionsClient(NearbyConnectionsManager manager)
    {
      this.mManager = Misc.CheckNotNull<NearbyConnectionsManager>(manager);
    }

    public int MaxUnreliableMessagePayloadLength()
    {
      return 1168;
    }

    public int MaxReliableMessagePayloadLength()
    {
      return 4096;
    }

    public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
    {
      this.InternalSend(recipientEndpointIds, payload, true);
    }

    public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
    {
      this.InternalSend(recipientEndpointIds, payload, false);
    }

    private void InternalSend(List<string> recipientEndpointIds, byte[] payload, bool isReliable)
    {
      if (recipientEndpointIds == null)
        throw new ArgumentNullException("recipientEndpointIds");
      if (payload == null)
        throw new ArgumentNullException("payload");
      if (recipientEndpointIds.Contains((string) null))
        throw new InvalidOperationException("Cannot send a message to a null recipient");
      if (recipientEndpointIds.Count == 0)
      {
        Logger.w("Attempted to send a reliable message with no recipients");
      }
      else
      {
        if (isReliable)
        {
          if (payload.Length > this.MaxReliableMessagePayloadLength())
            throw new InvalidOperationException("cannot send more than " + (object) this.MaxReliableMessagePayloadLength() + " bytes");
        }
        else if (payload.Length > this.MaxUnreliableMessagePayloadLength())
          throw new InvalidOperationException("cannot send more than " + (object) this.MaxUnreliableMessagePayloadLength() + " bytes");
        foreach (string recipientEndpointId in recipientEndpointIds)
        {
          if (isReliable)
            this.mManager.SendReliable(recipientEndpointId, payload);
          else
            this.mManager.SendUnreliable(recipientEndpointId, payload);
        }
      }
    }

    public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> requestCallback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeNearbyConnectionsClient.\u003CStartAdvertising\u003Ec__AnonStorey0 advertisingCAnonStorey0 = new NativeNearbyConnectionsClient.\u003CStartAdvertising\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      advertisingCAnonStorey0.resultCallback = resultCallback;
      // ISSUE: reference to a compiler-generated field
      advertisingCAnonStorey0.requestCallback = requestCallback;
      Misc.CheckNotNull<List<string>>(appIdentifiers, "appIdentifiers");
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<AdvertisingResult>>(advertisingCAnonStorey0.resultCallback, "resultCallback");
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<ConnectionRequest>>(advertisingCAnonStorey0.requestCallback, "connectionRequestCallback");
      if (advertisingDuration.HasValue && advertisingDuration.Value.Ticks < 0L)
        throw new InvalidOperationException("advertisingDuration must be positive");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      advertisingCAnonStorey0.resultCallback = Callbacks.AsOnGameThreadCallback<AdvertisingResult>(advertisingCAnonStorey0.resultCallback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      advertisingCAnonStorey0.requestCallback = Callbacks.AsOnGameThreadCallback<ConnectionRequest>(advertisingCAnonStorey0.requestCallback);
      NearbyConnectionsManager mManager = this.mManager;
      string name1 = name;
      List<string> source = appIdentifiers;
      // ISSUE: reference to a compiler-generated field
      if (NativeNearbyConnectionsClient.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NativeNearbyConnectionsClient.\u003C\u003Ef__mg\u0024cache0 = new Func<string, NativeAppIdentifier>(NativeAppIdentifier.FromString);
      }
      // ISSUE: reference to a compiler-generated field
      Func<string, NativeAppIdentifier> fMgCache0 = NativeNearbyConnectionsClient.\u003C\u003Ef__mg\u0024cache0;
      List<NativeAppIdentifier> list = source.Select<string, NativeAppIdentifier>(fMgCache0).ToList<NativeAppIdentifier>();
      long timeoutMillis = NativeNearbyConnectionsClient.ToTimeoutMillis(advertisingDuration);
      // ISSUE: reference to a compiler-generated method
      Action<long, NativeStartAdvertisingResult> advertisingCallback = new Action<long, NativeStartAdvertisingResult>(advertisingCAnonStorey0.\u003C\u003Em__0);
      // ISSUE: reference to a compiler-generated method
      Action<long, NativeConnectionRequest> connectionRequestCallback = new Action<long, NativeConnectionRequest>(advertisingCAnonStorey0.\u003C\u003Em__1);
      mManager.StartAdvertising(name1, list, timeoutMillis, advertisingCallback, connectionRequestCallback);
    }

    private static long ToTimeoutMillis(TimeSpan? span)
    {
      if (span.HasValue)
        return PInvokeUtilities.ToMilliseconds(span.Value);
      return 0;
    }

    public void StopAdvertising()
    {
      this.mManager.StopAdvertising();
    }

    public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeNearbyConnectionsClient.\u003CSendConnectionRequest\u003Ec__AnonStorey1 requestCAnonStorey1 = new NativeNearbyConnectionsClient.\u003CSendConnectionRequest\u003Ec__AnonStorey1();
      // ISSUE: reference to a compiler-generated field
      requestCAnonStorey1.responseCallback = responseCallback;
      Misc.CheckNotNull<string>(remoteEndpointId, "remoteEndpointId");
      Misc.CheckNotNull<byte[]>(payload, "payload");
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<ConnectionResponse>>(requestCAnonStorey1.responseCallback, "responseCallback");
      Misc.CheckNotNull<IMessageListener>(listener, "listener");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      requestCAnonStorey1.responseCallback = Callbacks.AsOnGameThreadCallback<ConnectionResponse>(requestCAnonStorey1.responseCallback);
      using (NativeMessageListenerHelper messageListener = NativeNearbyConnectionsClient.ToMessageListener(listener))
      {
        // ISSUE: reference to a compiler-generated method
        this.mManager.SendConnectionRequest(name, remoteEndpointId, payload, new Action<long, NativeConnectionResponse>(requestCAnonStorey1.\u003C\u003Em__0), messageListener);
      }
    }

    private static NativeMessageListenerHelper ToMessageListener(IMessageListener listener)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeNearbyConnectionsClient.\u003CToMessageListener\u003Ec__AnonStorey2 listenerCAnonStorey2 = new NativeNearbyConnectionsClient.\u003CToMessageListener\u003Ec__AnonStorey2();
      // ISSUE: reference to a compiler-generated field
      listenerCAnonStorey2.listener = listener;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      listenerCAnonStorey2.listener = (IMessageListener) new NativeNearbyConnectionsClient.OnGameThreadMessageListener(listenerCAnonStorey2.listener);
      NativeMessageListenerHelper messageListenerHelper = new NativeMessageListenerHelper();
      // ISSUE: reference to a compiler-generated method
      messageListenerHelper.SetOnMessageReceivedCallback(new NativeMessageListenerHelper.OnMessageReceived(listenerCAnonStorey2.\u003C\u003Em__0));
      // ISSUE: reference to a compiler-generated method
      messageListenerHelper.SetOnDisconnectedCallback(new Action<long, string>(listenerCAnonStorey2.\u003C\u003Em__1));
      return messageListenerHelper;
    }

    public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
    {
      Misc.CheckNotNull<string>(remoteEndpointId, "remoteEndpointId");
      Misc.CheckNotNull<byte[]>(payload, "payload");
      Misc.CheckNotNull<IMessageListener>(listener, "listener");
      Logger.d("Calling AcceptConncectionRequest");
      this.mManager.AcceptConnectionRequest(remoteEndpointId, payload, NativeNearbyConnectionsClient.ToMessageListener(listener));
      Logger.d("Called!");
    }

    public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
    {
      Misc.CheckNotNull<string>(serviceId, "serviceId");
      Misc.CheckNotNull<IDiscoveryListener>(listener, "listener");
      using (NativeEndpointDiscoveryListenerHelper discoveryListener = NativeNearbyConnectionsClient.ToDiscoveryListener(listener))
        this.mManager.StartDiscovery(serviceId, NativeNearbyConnectionsClient.ToTimeoutMillis(advertisingTimeout), discoveryListener);
    }

    private static NativeEndpointDiscoveryListenerHelper ToDiscoveryListener(IDiscoveryListener listener)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeNearbyConnectionsClient.\u003CToDiscoveryListener\u003Ec__AnonStorey3 listenerCAnonStorey3 = new NativeNearbyConnectionsClient.\u003CToDiscoveryListener\u003Ec__AnonStorey3();
      // ISSUE: reference to a compiler-generated field
      listenerCAnonStorey3.listener = listener;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      listenerCAnonStorey3.listener = (IDiscoveryListener) new NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener(listenerCAnonStorey3.listener);
      NativeEndpointDiscoveryListenerHelper discoveryListenerHelper = new NativeEndpointDiscoveryListenerHelper();
      // ISSUE: reference to a compiler-generated method
      discoveryListenerHelper.SetOnEndpointFound(new Action<long, NativeEndpointDetails>(listenerCAnonStorey3.\u003C\u003Em__0));
      // ISSUE: reference to a compiler-generated method
      discoveryListenerHelper.SetOnEndpointLostCallback(new Action<long, string>(listenerCAnonStorey3.\u003C\u003Em__1));
      return discoveryListenerHelper;
    }

    public void StopDiscovery(string serviceId)
    {
      Misc.CheckNotNull<string>(serviceId, "serviceId");
      this.mManager.StopDiscovery(serviceId);
    }

    public void RejectConnectionRequest(string requestingEndpointId)
    {
      Misc.CheckNotNull<string>(requestingEndpointId, "requestingEndpointId");
      this.mManager.RejectConnectionRequest(requestingEndpointId);
    }

    public void DisconnectFromEndpoint(string remoteEndpointId)
    {
      this.mManager.DisconnectFromEndpoint(remoteEndpointId);
    }

    public void StopAllConnections()
    {
      this.mManager.StopAllConnections();
    }

    public string LocalEndpointId()
    {
      return this.mManager.LocalEndpointId();
    }

    public string LocalDeviceId()
    {
      return this.mManager.LocalDeviceId();
    }

    public string GetAppBundleId()
    {
      return this.mManager.AppBundleId;
    }

    public string GetServiceId()
    {
      return NearbyConnectionsManager.ServiceId;
    }

    protected class OnGameThreadMessageListener : IMessageListener
    {
      private readonly IMessageListener mListener;

      public OnGameThreadMessageListener(IMessageListener listener)
      {
        this.mListener = Misc.CheckNotNull<IMessageListener>(listener);
      }

      public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeNearbyConnectionsClient.OnGameThreadMessageListener.\u003COnMessageReceived\u003Ec__AnonStorey0()
        {
          remoteEndpointId = remoteEndpointId,
          data = data,
          isReliableMessage = isReliableMessage,
          \u0024this = this
        }.\u003C\u003Em__0));
      }

      public void OnRemoteEndpointDisconnected(string remoteEndpointId)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeNearbyConnectionsClient.OnGameThreadMessageListener.\u003COnRemoteEndpointDisconnected\u003Ec__AnonStorey1()
        {
          remoteEndpointId = remoteEndpointId,
          \u0024this = this
        }.\u003C\u003Em__0));
      }
    }

    protected class OnGameThreadDiscoveryListener : IDiscoveryListener
    {
      private readonly IDiscoveryListener mListener;

      public OnGameThreadDiscoveryListener(IDiscoveryListener listener)
      {
        this.mListener = Misc.CheckNotNull<IDiscoveryListener>(listener);
      }

      public void OnEndpointFound(EndpointDetails discoveredEndpoint)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.\u003COnEndpointFound\u003Ec__AnonStorey0()
        {
          discoveredEndpoint = discoveredEndpoint,
          \u0024this = this
        }.\u003C\u003Em__0));
      }

      public void OnEndpointLost(string lostEndpointId)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(new NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.\u003COnEndpointLost\u003Ec__AnonStorey1()
        {
          lostEndpointId = lostEndpointId,
          \u0024this = this
        }.\u003C\u003Em__0));
      }
    }
  }
}
