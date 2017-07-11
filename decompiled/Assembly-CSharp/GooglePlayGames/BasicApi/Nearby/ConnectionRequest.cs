// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Nearby.ConnectionRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
