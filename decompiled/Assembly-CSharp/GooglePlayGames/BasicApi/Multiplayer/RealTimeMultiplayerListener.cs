// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace GooglePlayGames.BasicApi.Multiplayer
{
  public interface RealTimeMultiplayerListener
  {
    void OnRoomSetupProgress(float percent);

    void OnRoomConnected(bool success);

    void OnLeftRoom();

    void OnParticipantLeft(Participant participant);

    void OnPeersConnected(string[] participantIds);

    void OnPeersDisconnected(string[] participantIds);

    void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data);
  }
}
