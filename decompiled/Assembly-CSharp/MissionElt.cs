// Decompiled with JetBrains decompiler
// Type: MissionElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionElt : MonoBehaviour
{
  public Text textName;
  public Text textGuage;
  public Text textReward;
  public Text textButton;
  public Image imgFill;
  public Button btnGet;
  public QuestID eID;

  private int nCurrent
  {
    get
    {
      int num = 0;
      switch (this.eID)
      {
        case QuestID.eEasy100:
        case QuestID.eEasy500:
        case QuestID.eEasy250:
          foreach (KeyValuePair<ObscuredInt, List<ObscuredInt>> keyValuePair in Info.rebirth.dictRebirthHistory)
          {
            for (int index = 0; index < keyValuePair.Value.Count; ++index)
            {
              if ((int) keyValuePair.Value[index] > num)
                num = (int) keyValuePair.Value[index];
            }
          }
          if ((int) Info.currentSave.nDay > num)
            num = (int) Info.currentSave.nDay;
          return num;
        case QuestID.eNormal100:
        case QuestID.eNormal500:
        case QuestID.eNormal250:
          foreach (KeyValuePair<ObscuredInt, List<ObscuredInt>> keyValuePair in Info.rebirth.dictRebirthHistory)
          {
            if ((int) keyValuePair.Key != 1)
            {
              for (int index = 0; index < keyValuePair.Value.Count; ++index)
              {
                if ((int) keyValuePair.Value[index] > num)
                  num = (int) keyValuePair.Value[index];
              }
            }
          }
          if ((int) Info.currentSave.nDiff != 1 && (int) Info.currentSave.nDay > num)
            num = (int) Info.currentSave.nDay;
          return num;
        case QuestID.eHard100:
        case QuestID.eHard500:
        case QuestID.eHard250:
          foreach (KeyValuePair<ObscuredInt, List<ObscuredInt>> keyValuePair in Info.rebirth.dictRebirthHistory)
          {
            if ((int) keyValuePair.Key >= 2)
            {
              for (int index = 0; index < keyValuePair.Value.Count; ++index)
              {
                if ((int) keyValuePair.Value[index] > num)
                  num = (int) keyValuePair.Value[index];
              }
            }
          }
          if ((int) Info.currentSave.nDiff >= 2 && (int) Info.currentSave.nDay > num)
            num = (int) Info.currentSave.nDay;
          return num;
        case QuestID.eEnchant:
          return (int) Info.achievement.nEnchant;
        case QuestID.eMod:
          return (int) Info.currentSave.nMod;
        case QuestID.eTrial:
          return Info.GetTrialClear(Info.currentSave.uRebirthID);
        case QuestID.eEndless:
          return (int) Info.currentSave.nMaxEndless;
        case QuestID.eRebirth:
          return (int) Info.rebirth.nRebirth;
        case QuestID.eAwakening:
          for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
          {
            if (Info.currentSave.arrPlayerMon[index] != null && Info.isAwaken(Info.currentSave.arrPlayerMon[index]))
              return 1;
          }
          return (int) Info.achievement.nAwaken;
        case QuestID.eInsane100:
        case QuestID.eInsane250:
        case QuestID.eInsane500:
          foreach (KeyValuePair<ObscuredInt, List<ObscuredInt>> keyValuePair in Info.rebirth.dictRebirthHistory)
          {
            if ((int) keyValuePair.Key >= 3)
            {
              for (int index = 0; index < keyValuePair.Value.Count; ++index)
              {
                if ((int) keyValuePair.Value[index] > num)
                  num = (int) keyValuePair.Value[index];
              }
            }
          }
          if ((int) Info.currentSave.nDiff >= 3 && (int) Info.currentSave.nDay > num)
            num = (int) Info.currentSave.nDay;
          return num;
        default:
          return 0;
      }
    }
  }

  public void Refresh()
  {
    QuestData quest = BData.GetQuest(this.eID);
    bool flag = Info.rebirth.listMission.Contains(this.eID);
    float num = !flag ? Mathf.Min((float) this.nCurrent / (float) quest.nMax, 1f) : 1f;
    int nReward = quest.nReward;
    this.imgFill.fillAmount = num;
    this.textGuage.text = !flag ? this.nCurrent.ToString() + " / " + quest.nMax.ToString() : "100%";
    this.textName.text = BData.GetString(quest.strDesc).Replace("[1]", quest.nMax.ToString());
    this.textReward.text = nReward.ToString();
    this.textButton.text = BData.GetString(!flag ? "UI0157" : "UI0302");
    this.btnGet.interactable = !flag && this.nCurrent >= quest.nMax;
  }

  public void OnGet()
  {
    if (Info.rebirth.listMission.Contains(this.eID))
      return;
    QuestData quest = BData.GetQuest(this.eID);
    if (this.nCurrent < quest.nMax)
      return;
    int nReward = quest.nReward;
    UIMgr.PlaySound("Hire", false);
    Info.rebirth.listMission.Add(this.eID);
    SavedRebirth rebirth = Info.rebirth;
    ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) nReward);
    rebirth.nNewStone = obscuredLong;
    SaveManager.SaveRebirth();
    this.Refresh();
  }
}
