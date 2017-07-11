// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Quests.QuestFetchFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
