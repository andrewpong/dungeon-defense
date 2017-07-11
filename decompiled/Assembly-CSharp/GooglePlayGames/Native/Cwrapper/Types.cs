﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.Types
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class Types
  {
    internal enum DataSource
    {
      CACHE_OR_NETWORK = 1,
      NETWORK_ONLY = 2,
    }

    internal enum LogLevel
    {
      VERBOSE = 1,
      INFO = 2,
      WARNING = 3,
      ERROR = 4,
    }

    internal enum AuthOperation
    {
      SIGN_IN = 1,
      SIGN_OUT = 2,
    }

    internal enum ImageResolution
    {
      ICON = 1,
      HI_RES = 2,
    }

    internal enum AchievementType
    {
      STANDARD = 1,
      INCREMENTAL = 2,
    }

    internal enum AchievementState
    {
      HIDDEN = 1,
      REVEALED = 2,
      UNLOCKED = 3,
    }

    internal enum EventVisibility
    {
      HIDDEN = 1,
      REVEALED = 2,
    }

    internal enum LeaderboardOrder
    {
      LARGER_IS_BETTER = 1,
      SMALLER_IS_BETTER = 2,
    }

    internal enum LeaderboardStart
    {
      TOP_SCORES = 1,
      PLAYER_CENTERED = 2,
    }

    internal enum LeaderboardTimeSpan
    {
      DAILY = 1,
      WEEKLY = 2,
      ALL_TIME = 3,
    }

    internal enum LeaderboardCollection
    {
      PUBLIC = 1,
      SOCIAL = 2,
    }

    internal enum ParticipantStatus
    {
      INVITED = 1,
      JOINED = 2,
      DECLINED = 3,
      LEFT = 4,
      NOT_INVITED_YET = 5,
      FINISHED = 6,
      UNRESPONSIVE = 7,
    }

    internal enum MatchResult
    {
      DISAGREED = 1,
      DISCONNECTED = 2,
      LOSS = 3,
      NONE = 4,
      TIE = 5,
      WIN = 6,
    }

    internal enum MatchStatus
    {
      INVITED = 1,
      THEIR_TURN = 2,
      MY_TURN = 3,
      PENDING_COMPLETION = 4,
      COMPLETED = 5,
      CANCELED = 6,
      EXPIRED = 7,
    }

    internal enum QuestState
    {
      UPCOMING = 1,
      OPEN = 2,
      ACCEPTED = 3,
      COMPLETED = 4,
      EXPIRED = 5,
      FAILED = 6,
    }

    internal enum QuestMilestoneState
    {
      NOT_STARTED = 1,
      NOT_COMPLETED = 2,
      COMPLETED_NOT_CLAIMED = 3,
      CLAIMED = 4,
    }

    internal enum MultiplayerEvent
    {
      UPDATED = 1,
      UPDATED_FROM_APP_LAUNCH = 2,
      REMOVED = 3,
    }

    internal enum MultiplayerInvitationType
    {
      TURN_BASED = 1,
      REAL_TIME = 2,
    }

    internal enum RealTimeRoomStatus
    {
      INVITING = 1,
      CONNECTING = 2,
      AUTO_MATCHING = 3,
      ACTIVE = 4,
      DELETED = 5,
    }

    internal enum SnapshotConflictPolicy
    {
      MANUAL = 1,
      LONGEST_PLAYTIME = 2,
      LAST_KNOWN_GOOD = 3,
      MOST_RECENTLY_MODIFIED = 4,
    }
  }
}
