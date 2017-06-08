// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GooglePlayGames.BasicApi.Multiplayer
{
  public class TurnBasedMatch
  {
    private string mMatchId;
    private byte[] mData;
    private bool mCanRematch;
    private uint mAvailableAutomatchSlots;
    private string mSelfParticipantId;
    private List<Participant> mParticipants;
    private string mPendingParticipantId;
    private TurnBasedMatch.MatchTurnStatus mTurnStatus;
    private TurnBasedMatch.MatchStatus mMatchStatus;
    private uint mVariant;
    private uint mVersion;

    public string MatchId
    {
      get
      {
        return this.mMatchId;
      }
    }

    public byte[] Data
    {
      get
      {
        return this.mData;
      }
    }

    public bool CanRematch
    {
      get
      {
        return this.mCanRematch;
      }
    }

    public string SelfParticipantId
    {
      get
      {
        return this.mSelfParticipantId;
      }
    }

    public Participant Self
    {
      get
      {
        return this.GetParticipant(this.mSelfParticipantId);
      }
    }

    public List<Participant> Participants
    {
      get
      {
        return this.mParticipants;
      }
    }

    public string PendingParticipantId
    {
      get
      {
        return this.mPendingParticipantId;
      }
    }

    public Participant PendingParticipant
    {
      get
      {
        if (this.mPendingParticipantId == null)
          return (Participant) null;
        return this.GetParticipant(this.mPendingParticipantId);
      }
    }

    public TurnBasedMatch.MatchTurnStatus TurnStatus
    {
      get
      {
        return this.mTurnStatus;
      }
    }

    public TurnBasedMatch.MatchStatus Status
    {
      get
      {
        return this.mMatchStatus;
      }
    }

    public uint Variant
    {
      get
      {
        return this.mVariant;
      }
    }

    public uint Version
    {
      get
      {
        return this.mVersion;
      }
    }

    public uint AvailableAutomatchSlots
    {
      get
      {
        return this.mAvailableAutomatchSlots;
      }
    }

    internal TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, List<Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, TurnBasedMatch.MatchTurnStatus turnStatus, TurnBasedMatch.MatchStatus matchStatus, uint variant, uint version)
    {
      this.mMatchId = matchId;
      this.mData = data;
      this.mCanRematch = canRematch;
      this.mSelfParticipantId = selfParticipantId;
      this.mParticipants = participants;
      this.mParticipants.Sort();
      this.mAvailableAutomatchSlots = availableAutomatchSlots;
      this.mPendingParticipantId = pendingParticipantId;
      this.mTurnStatus = turnStatus;
      this.mMatchStatus = matchStatus;
      this.mVariant = variant;
      this.mVersion = version;
    }

    public Participant GetParticipant(string participantId)
    {
      foreach (Participant mParticipant in this.mParticipants)
      {
        if (mParticipant.ParticipantId.Equals(participantId))
          return mParticipant;
      }
      Logger.w("Participant not found in turn-based match: " + participantId);
      return (Participant) null;
    }

    public override string ToString()
    {
      return string.Format("[TurnBasedMatch: mMatchId={0}, mData={1}, mCanRematch={2}, mSelfParticipantId={3}, mParticipants={4}, mPendingParticipantId={5}, mTurnStatus={6}, mMatchStatus={7}, mVariant={8}, mVersion={9}]", (object) this.mMatchId, (object) this.mData, (object) this.mCanRematch, (object) this.mSelfParticipantId, (object) string.Join(",", this.mParticipants.Select<Participant, string>((Func<Participant, string>) (p => p.ToString())).ToArray<string>()), (object) this.mPendingParticipantId, (object) this.mTurnStatus, (object) this.mMatchStatus, (object) this.mVariant, (object) this.mVersion);
    }

    public enum MatchStatus
    {
      Active,
      AutoMatching,
      Cancelled,
      Complete,
      Expired,
      Unknown,
      Deleted,
    }

    public enum MatchTurnStatus
    {
      Complete,
      Invited,
      MyTurn,
      TheirTurn,
      Unknown,
    }
  }
}
