// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.CommonErrorStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class CommonErrorStatus
  {
    internal enum ResponseStatus
    {
      ERROR_TIMEOUT = -5,
      ERROR_VERSION_UPDATE_REQUIRED = -4,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      ERROR_LICENSE_CHECK_FAILED = -1,
      VALID = 1,
      VALID_BUT_STALE = 2,
    }

    internal enum FlushStatus
    {
      ERROR_TIMEOUT = -5,
      ERROR_VERSION_UPDATE_REQUIRED = -4,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      FLUSHED = 4,
    }

    internal enum AuthStatus
    {
      ERROR_TIMEOUT = -5,
      ERROR_VERSION_UPDATE_REQUIRED = -4,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      VALID = 1,
    }

    internal enum UIStatus
    {
      ERROR_LEFT_ROOM = -18,
      ERROR_UI_BUSY = -12,
      ERROR_CANCELED = -6,
      ERROR_TIMEOUT = -5,
      ERROR_VERSION_UPDATE_REQUIRED = -4,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      VALID = 1,
    }

    internal enum MultiplayerStatus
    {
      ERROR_REAL_TIME_ROOM_NOT_JOINED = -17,
      ERROR_MATCH_OUT_OF_DATE = -11,
      ERROR_INVALID_MATCH = -10,
      ERROR_INVALID_RESULTS = -9,
      ERROR_INACTIVE_MATCH = -8,
      ERROR_MATCH_ALREADY_REMATCHED = -7,
      ERROR_TIMEOUT = -5,
      ERROR_VERSION_UPDATE_REQUIRED = -4,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      VALID = 1,
      VALID_BUT_STALE = 2,
    }

    internal enum QuestAcceptStatus
    {
      ERROR_QUEST_NOT_STARTED = -14,
      ERROR_QUEST_NO_LONGER_AVAILABLE = -13,
      ERROR_TIMEOUT = -5,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      VALID = 1,
    }

    internal enum QuestClaimMilestoneStatus
    {
      ERROR_MILESTONE_CLAIM_FAILED = -16,
      ERROR_MILESTONE_ALREADY_CLAIMED = -15,
      ERROR_TIMEOUT = -5,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      VALID = 1,
    }

    internal enum SnapshotOpenStatus
    {
      ERROR_TIMEOUT = -5,
      ERROR_NOT_AUTHORIZED = -3,
      ERROR_INTERNAL = -2,
      VALID = 1,
      VALID_WITH_CONFLICT = 3,
    }
  }
}
