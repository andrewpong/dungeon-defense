// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Nearby.ConnectionRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.OurUtils;

namespace GooglePlayGames.BasicApi.Nearby
{
  public struct ConnectionRequest
  {
    private readonly EndpointDetails mRemoteEndpoint;
    private readonly byte[] mPayload;

    public EndpointDetails RemoteEndpoint
    {
      get
      {
        return this.mRemoteEndpoint;
      }
    }

    public byte[] Payload
    {
      get
      {
        return this.mPayload;
      }
    }

    public ConnectionRequest(string remoteEndpointId, string remoteDeviceId, string remoteEndpointName, string serviceId, byte[] payload)
    {
      Logger.d("Constructing ConnectionRequest");
      this.mRemoteEndpoint = new EndpointDetails(remoteEndpointId, remoteDeviceId, remoteEndpointName, serviceId);
      this.mPayload = Misc.CheckNotNull<byte[]>(payload);
    }
  }
}
