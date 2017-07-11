// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Quests.IQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;

namespace GooglePlayGames.BasicApi.Quests
{
  public interface IQuest
  {
    string Id { get; }

    string Name { get; }

    string Description { get; }

    string BannerUrl { get; }

    string IconUrl { get; }

    DateTime StartTime { get; }

    DateTime ExpirationTime { get; }

    DateTime? AcceptedTime { get; }

    IQuestMilestone Milestone { get; }

    QuestState State { get; }
  }
}
