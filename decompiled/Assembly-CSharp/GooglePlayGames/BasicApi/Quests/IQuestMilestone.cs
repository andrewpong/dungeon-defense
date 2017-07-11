// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Quests.IQuestMilestone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
