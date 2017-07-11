// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Nearby.IDiscoveryListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
  public interface IDiscoveryListener
  {
    void OnEndpointFound(EndpointDetails discoveredEndpoint);

    void OnEndpointLost(string lostEndpointId);
  }
}
