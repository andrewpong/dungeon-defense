// Decompiled with JetBrains decompiler
// Type: AchievementElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class AchievementElt : MonoBehaviour
{
  public Text textName;
  private bool bUnlock;
  private string strTooltip;

  public void Refresh(AchievementType eID)
  {
    AchievementData achievement = BData.GetAchievement(eID);
    this.bUnlock = Info.achievement.listAcv.Contains(eID);
    this.textName.text = BData.GetString(achievement.strName);
    this.textName.color = !this.bUnlock ? Color.red : Color.white;
    this.strTooltip = "<" + (this.bUnlock ? "<color='white'>" : "<color='red'>") + this.textName.text + "</color>>\n" + BData.GetString(achievement.strDesc) + "\n";
    this.strTooltip += Info.GetAcvRewardDesc(achievement.eReward, achievement.nReward);
    if (!Info.listCheck.Contains(eID))
      return;
    Text textName = this.textName;
    string str = textName.text + "(" + BData.GetString("UI0130") + ")";
    textName.text = str;
    this.textName.color = Color.green;
  }

  public void OnShow()
  {
    UIMgr.TooltipShow(this.strTooltip);
    TooltipWindow.obj.bInit = false;
  }
}
