// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Multiplayer
{
  public interface IRealTimeMultiplayerClient
  {
    void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener);

    void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener);

    void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, RealTimeMultiplayerListener listener);

    void ShowWaitingRoomUI();

    void GetAllInvitations(Action<Invitation[]> callback);

    void AcceptFromInbox(RealTimeMultiplayerListener listener);

    void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener);

    void SendMessageToAll(bool reliable, byte[] data);

    void SendMessageToAll(bool reliable, byte[] data, int offset, int length);

    void SendMessage(bool reliable, string participantId, byte[] data);

    void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length);

    List<Participant> GetConnectedParticipants();

    Participant GetSelf();

    Participant GetParticipant(string participantId);

    Invitation GetInvitation();

    void LeaveRoom();

    bool IsRoomConnected();

    void DeclineInvitation(string invitationId);
  }
}
