// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Quests.IQuestMilestone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Quests
{
  public interface IQuestMilestone
  {
    string Id { get; }

    string EventId { get; }

    string QuestId { get; }

    ulong CurrentCount { get; }

    ulong TargetCount { get; }

    byte[] CompletionRewardData { get; }

    MilestoneState State { get; }
  }
}
