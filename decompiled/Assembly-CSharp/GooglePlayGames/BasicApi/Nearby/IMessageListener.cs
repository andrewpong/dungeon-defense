// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Nearby.IMessageListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
  public interface IMessageListener
  {
    void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

    void OnRemoteEndpointDisconnected(string remoteEndpointId);
  }
}
