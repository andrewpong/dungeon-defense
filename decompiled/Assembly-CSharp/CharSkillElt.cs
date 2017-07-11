// Decompiled with JetBrains decompiler
// Type: CharSkillElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharSkillElt : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
  public Image imgIcon;
  public Image imgFrame;
  public Text textName;
  private SkillKey eKey;
  private int nLevel;
  private string strTooltip;

  public void SetSkillElt(SkillKey _eKey, int _nLevel, bool bAwaken, bool bFocused = false)
  {
    this.eKey = _eKey;
    this.nLevel = _nLevel;
    SkillData skill = BData.GetSkill(this.eKey);
    bool flag = this.nLevel > 0;
    this.textName.text = !flag ? string.Empty : "Lv" + (object) this.nLevel;
    this.strTooltip = (!bAwaken ? string.Empty : "! " + BData.GetString("UI0304") + " !\n") + "<" + BData.GetString(skill.strName) + (!flag ? " (" + BData.GetString("UI0249") + ")" : " Lv." + this.nLevel.ToString("###0") + "/" + skill.nMax.ToString());
    switch (skill.eType)
    {
      case SkillType.eAwaken:
        CharSkillElt charSkillElt1 = this;
        string str1 = charSkillElt1.strTooltip + " ~" + BData.GetString("UI0303") + "~";
        charSkillElt1.strTooltip = str1;
        break;
      case SkillType.eActive:
        CharSkillElt charSkillElt2 = this;
        string str2 = charSkillElt2.strTooltip + " ~" + BData.GetString("UI0020") + "~";
        charSkillElt2.strTooltip = str2;
        break;
      case SkillType.eParty:
        CharSkillElt charSkillElt3 = this;
        string str3 = charSkillElt3.strTooltip + " ~" + BData.GetString("UI0019") + "~";
        charSkillElt3.strTooltip = str3;
        break;
    }
    this.strTooltip += ">\n";
    this.imgIcon.sprite = RSMgr.GetSprite(skill.strIcon);
    this.imgFrame.color = !bFocused ? (!flag ? new Color(0.2f, 0.2f, 0.2f) : Color.white) : Color.cyan;
    this.imgIcon.color = !flag ? new Color(0.2f, 0.2f, 0.2f) : Color.white;
    float num1 = skill.fFactor + skill.fGrow * (float) this.nLevel;
    float num2 = skill.fFactor2 + skill.fGrow2 * (float) this.nLevel;
    CharSkillElt charSkillElt4 = this;
    string str4 = charSkillElt4.strTooltip + BData.GetString(skill.strSummary).Replace("[1]", num1.ToString("###0.##")).Replace("[2]", num2.ToString("###0.##")) + "\n\n" + BData.GetString(skill.strDesc);
    charSkillElt4.strTooltip = str4;
  }

  public void OnPointerDown(PointerEventData eventData)
  {
    UIMgr.TooltipShow(this.strTooltip);
  }

  public void OnPointerUp(PointerEventData eventData)
  {
    UIMgr.TooltipHide();
  }
}
