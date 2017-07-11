// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Multiplayer.Participant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;

namespace GooglePlayGames.BasicApi.Multiplayer
{
  public class Participant : IComparable<Participant>
  {
    private string mDisplayName = string.Empty;
    private string mParticipantId = string.Empty;
    private Participant.ParticipantStatus mStatus = Participant.ParticipantStatus.Unknown;
    private Player mPlayer;
    private bool mIsConnectedToRoom;

    public string DisplayName
    {
      get
      {
        return this.mDisplayName;
      }
    }

    public string ParticipantId
    {
      get
      {
        return this.mParticipantId;
      }
    }

    public Participant.ParticipantStatus Status
    {
      get
      {
        return this.mStatus;
      }
    }

    public Player Player
    {
      get
      {
        return this.mPlayer;
      }
    }

    public bool IsConnectedToRoom
    {
      get
      {
        return this.mIsConnectedToRoom;
      }
    }

    public bool IsAutomatch
    {
      get
      {
        return this.mPlayer == null;
      }
    }

    internal Participant(string displayName, string participantId, Participant.ParticipantStatus status, Player player, bool connectedToRoom)
    {
      this.mDisplayName = displayName;
      this.mParticipantId = participantId;
      this.mStatus = status;
      this.mPlayer = player;
      this.mIsConnectedToRoom = connectedToRoom;
    }

    public override string ToString()
    {
      return string.Format("[Participant: '{0}' (id {1}), status={2}, player={3}, connected={4}]", (object) this.mDisplayName, (object) this.mParticipantId, (object) this.mStatus.ToString(), (object) (this.mPlayer != null ? this.mPlayer.ToString() : "NULL"), (object) this.mIsConnectedToRoom);
    }

    public int CompareTo(Participant other)
    {
      return this.mParticipantId.CompareTo(other.mParticipantId);
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (object.ReferenceEquals((object) this, obj))
        return true;
      if (obj.GetType() != typeof (Participant))
        return false;
      return this.mParticipantId.Equals(((Participant) obj).mParticipantId);
    }

    public override int GetHashCode()
    {
      if (this.mParticipantId != null)
        return this.mParticipantId.GetHashCode();
      return 0;
    }

    public enum ParticipantStatus
    {
      NotInvitedYet,
      Invited,
      Joined,
      Declined,
      Left,
      Finished,
      Unresponsive,
      Unknown,
    }
  }
}
