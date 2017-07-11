// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Quests.IQuestsClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Quests
{
  public interface IQuestsClient
  {
    void Fetch(DataSource source, string questId, Action<ResponseStatus, IQuest> callback);

    void FetchMatchingState(DataSource source, QuestFetchFlags flags, Action<ResponseStatus, List<IQuest>> callback);

    void ShowAllQuestsUI(Action<QuestUiResult, IQuest, IQuestMilestone> callback);

    void ShowSpecificQuestUI(IQuest quest, Action<QuestUiResult, IQuest, IQuestMilestone> callback);

    void Accept(IQuest quest, Action<QuestAcceptStatus, IQuest> callback);

    void ClaimMilestone(IQuestMilestone milestone, Action<QuestClaimMilestoneStatus, IQuest, IQuestMilestone> callback);
  }
}
