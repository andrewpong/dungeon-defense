// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Quests.QuestFetchFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;

namespace GooglePlayGames.BasicApi.Quests
{
  [Flags]
  public enum QuestFetchFlags
  {
    Upcoming = 1,
    Open = 2,
    Accepted = 4,
    Completed = 8,
    CompletedNotClaimed = 16,
    Expired = 32,
    EndingSoon = 64,
    Failed = 128,
    All = -1,
  }
}
