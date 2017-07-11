// Decompiled with JetBrains decompiler
// Type: PopupFocusSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupFocusSkill : UIPage
{
  private List<SkillKey> listSkill = new List<SkillKey>();
  public Text textDesc;
  public Text[] textSkillName;
  public Image imgChar;
  public Button[] btnSkill;
  public GameObject[] goChecker;
  public RectTransform rtContent;

  protected override void Awake()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    PopupFocusSkill.\u003CAwake\u003Ec__AnonStorey0 awakeCAnonStorey0 = new PopupFocusSkill.\u003CAwake\u003Ec__AnonStorey0();
    base.Awake();
    // ISSUE: reference to a compiler-generated field
    awakeCAnonStorey0.pData = Info.GetPlayerMon((int) Info.nSelectedMonster);
    // ISSUE: reference to a compiler-generated field
    MonsterData monster = BData.GetMonster((short) awakeCAnonStorey0.pData.sID);
    // ISSUE: reference to a compiler-generated field
    bool flag1 = Info.isAwaken(awakeCAnonStorey0.pData);
    this.imgChar.sprite = RSMgr.GetSprite(!flag1 ? monster.strSprite : monster.strSpriteAwk);
    this.textDesc.text = BData.GetString("UI0324");
    this.listSkill.AddRange((IEnumerable<SkillKey>) monster.listLearnSkill);
    if (flag1)
      this.listSkill.AddRange((IEnumerable<SkillKey>) monster.listAwakenLearnSkill);
    List<SkillKey> skillKeyList = new List<SkillKey>();
    for (int index = 0; index < this.listSkill.Count; ++index)
    {
      if (BData.GetSkill(this.listSkill[index]).eType == SkillType.eMastery)
        skillKeyList.Add(this.listSkill[index]);
      else if ((int) Info.nSelectedMonster != 0 && BData.GetSkill(this.listSkill[index]).eType == SkillType.eAwaken)
        skillKeyList.Add(this.listSkill[index]);
    }
    for (int index = 0; index < skillKeyList.Count; ++index)
      this.listSkill.Remove(skillKeyList[index]);
    // ISSUE: reference to a compiler-generated method
    this.listSkill.Sort(new Comparison<SkillKey>(awakeCAnonStorey0.\u003C\u003Em__0));
    for (int index = 0; index < this.btnSkill.Length; ++index)
    {
      if (index >= this.listSkill.Count)
      {
        this.btnSkill[index].gameObject.SetActive(false);
      }
      else
      {
        SkillData skill1 = BData.GetSkill(this.listSkill[index]);
        // ISSUE: reference to a compiler-generated field
        int skill2 = Info.GetSkill(awakeCAnonStorey0.pData, skill1.eKey, false);
        // ISSUE: reference to a compiler-generated field
        int skill3 = Info.GetSkill(awakeCAnonStorey0.pData, skill1.eKey, true);
        bool flag2 = skill3 >= skill1.nMax;
        this.textSkillName[index].text = BData.GetString(skill1.strName) + " Lv." + (object) skill2 + "/" + (object) skill1.nMax + (skill2 <= skill3 ? string.Empty : "(+" + (object) (skill2 - skill3) + ")");
        this.textSkillName[index].color = skill3 < skill1.nMax ? Color.white : Color.gray;
        this.btnSkill[index].interactable = !flag2;
      }
    }
    this.rtContent.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float) (8 + 66 * this.listSkill.Count));
    this.RefreshChecker();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((UnityEngine.Object) UIMgr.focused == (UnityEngine.Object) this))
      return;
    this.OnClose();
  }

  private void RefreshChecker()
  {
    PlayerMonsterData playerMon = Info.GetPlayerMon((int) Info.nSelectedMonster);
    for (int index = 0; index < this.listSkill.Count; ++index)
      this.goChecker[index].SetActive(this.listSkill[index] == playerMon.eFocusedSkill && (bool) playerMon.bFocused);
  }

  public void OnCheckSkill(int nPos)
  {
    if (nPos >= this.listSkill.Count)
      return;
    PlayerMonsterData playerMon = Info.GetPlayerMon((int) Info.nSelectedMonster);
    SkillData skill = BData.GetSkill(this.listSkill[nPos]);
    string str = string.Empty;
    switch (skill.eType)
    {
      case SkillType.eAwaken:
        str = str + " ~" + BData.GetString("UI0303") + "~";
        break;
      case SkillType.eActive:
        str = str + " ~" + BData.GetString("UI0020") + "~";
        break;
      case SkillType.eParty:
        str = str + " ~" + BData.GetString("UI0019") + "~";
        break;
    }
    UIMgr.TooltipShow(BData.GetString(skill.strName) + str + "\n" + BData.GetString(skill.strDesc) + "\n" + BData.GetString(skill.strSummary).Replace("[1]", Info.GetSkillFac(playerMon, this.listSkill[nPos]).ToString("N0")).Replace("[2]", Info.GetSkillFac2(playerMon, this.listSkill[nPos]).ToString("N0")));
    if ((bool) playerMon.bFocused && playerMon.eFocusedSkill == this.listSkill[nPos])
    {
      playerMon.bFocused = (ObscuredBool) false;
      playerMon.eFocusedSkill = SkillKey.eNone;
      UIMgr.PlaySound("Negative", false);
    }
    else
    {
      playerMon.bFocused = (ObscuredBool) true;
      playerMon.eFocusedSkill = this.listSkill[nPos];
      UIMgr.PlaySound("MainButton", false);
    }
    this.RefreshChecker();
  }

  public void OnClose()
  {
    UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
    if (!(bool) ((UnityEngine.Object) PageLobby.obj))
      return;
    PageLobby.obj.RefreshCharUnitInfo((int) Info.nSelectedMonster);
  }
}
