// Decompiled with JetBrains decompiler
// Type: PopupSkillSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupSkillSelect : UIPage
{
  private SkillKey[] arrSkill = new SkillKey[7];
  private int nSelectedSkill = -1;
  private SkillKey ePreLearn = SkillKey.eNone;
  public Text textTitle;
  public Text textTitleSub;
  public Text textSelectTitle;
  public Text textDetailTitle;
  public Text textDetailType;
  public Text textDetailDesc;
  public Text textDetailCur;
  public Text textDetailNext;
  public Text textBtnLearn;
  public Image imgUnit;
  public Button[] arrBtnSkill;
  public Image[] arrImgSkill;
  public Text[] arrSkillLv;
  public Image[] arrHighlight;
  public Button btnLearn;
  private int nPreLv;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0047");
    this.textTitleSub.text = BData.GetString("UI0048");
    this.textSelectTitle.text = BData.GetString("UI0049");
    this.textBtnLearn.text = BData.GetString("UI0053");
    PlayerMonsterData playerMon = Info.GetPlayerMon(0);
    MonsterData monster = BData.GetMonster((short) playerMon.sID);
    this.imgUnit.sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster.eAwaken) && !(bool) playerMon.bAwaken ? monster.strSprite : monster.strSpriteAwk);
    UIMgr.PlaySound("Fanfare", false);
  }

  protected override void Start()
  {
    base.Start();
    this.RefreshSelect();
  }

  public void RefreshSelect()
  {
    PlayerMonsterData playerMon = Info.GetPlayerMon(0);
    int num1 = 2;
    if (playerMon.dictSkill.ContainsKey(SkillKey.ePotential))
    {
      int num2 = num1 + (int) playerMon.dictSkill[SkillKey.ePotential];
    }
    List<SkillKey> learnableSkill = Info.GetLearnableSkill(0);
    for (int index = 0; index < this.arrSkill.Length; ++index)
      this.arrSkill[index] = SkillKey.eNone;
    for (int index = 0; index < learnableSkill.Count; ++index)
    {
      if (index < this.arrSkill.Length)
        this.arrSkill[index] = learnableSkill[index];
    }
    for (int index = 0; index < this.arrSkill.Length; ++index)
    {
      this.arrBtnSkill[index].gameObject.SetActive(this.arrSkill[index] != SkillKey.eNone);
      if (this.arrSkill[index] != SkillKey.eNone)
      {
        this.arrImgSkill[index].sprite = RSMgr.GetSprite(BData.GetSkill(this.arrSkill[index]).strIcon);
        this.arrSkillLv[index].text = "Lv" + (object) (Info.GetSkill(playerMon, this.arrSkill[index], true) + 1);
      }
    }
    for (int index = 0; index < this.arrHighlight.Length; ++index)
      this.arrHighlight[index].gameObject.SetActive(false);
    this.btnLearn.interactable = false;
    Text textDetailTitle = this.textDetailTitle;
    string empty = string.Empty;
    this.textDetailType.text = empty;
    string str1 = empty;
    this.textDetailNext.text = str1;
    string str2 = str1;
    this.textDetailCur.text = str2;
    string str3 = str2;
    this.textDetailDesc.text = str3;
    string str4 = str3;
    textDetailTitle.text = str4;
    this.ePreLearn = Info.GetRandomMastery(0);
    this.nPreLv = Info.LearnSkill(0, this.ePreLearn);
    this.nSelectedSkill = -1;
    if (!Info.option.bAutoSkillSelect || !((Object) UIMgr.focused == (Object) this))
      return;
    int n = 0;
    if ((bool) playerMon.bFocused)
    {
      for (int index = 0; index < this.arrSkill.Length; ++index)
      {
        if (this.arrSkill[index] != SkillKey.eNone && this.arrSkill[index] == playerMon.eFocusedSkill)
        {
          n = index;
          break;
        }
      }
    }
    this.OnClick(n);
    this.OnLearn();
  }

  public void RefreshDetail(int n)
  {
    if (this.arrSkill[n] == SkillKey.eNone)
      return;
    this.nSelectedSkill = n;
    SkillData skill = BData.GetSkill(this.arrSkill[n]);
    int num1 = (int) (!Info.GetPlayerMon(0).dictSkill.ContainsKey(this.arrSkill[n]) ? (ObscuredInt) 0 : Info.GetPlayerMon(0).dictSkill[this.arrSkill[n]]);
    this.textDetailTitle.text = BData.GetString(skill.strName);
    this.textDetailDesc.text = BData.GetString(skill.strDesc);
    Text textDetailTitle = this.textDetailTitle;
    string str = textDetailTitle.text + " Lv." + (num1 + 1).ToString("##00");
    textDetailTitle.text = str;
    switch (skill.eType)
    {
      case SkillType.eParty:
        this.textDetailType.text = " <" + BData.GetString("UI0019") + ">";
        break;
      case SkillType.eActive:
        this.textDetailType.text = " <" + BData.GetString("UI0020") + ">";
        break;
      case SkillType.eAwaken:
        this.textDetailType.text = " <" + BData.GetString("UI0303") + ">";
        break;
      default:
        this.textDetailType.text = string.Empty;
        break;
    }
    float num2 = skill.fFactor + skill.fGrow * (float) num1;
    float num3 = skill.fFactor2 + skill.fGrow2 * (float) num1;
    this.textDetailCur.text = BData.GetString("UI0051") + (num1 != 0 ? BData.GetString(skill.strSummary).Replace("[1]", num2.ToString("###0.##")).Replace("[2]", num3.ToString("###0.##")) : "-");
    this.textDetailNext.text = BData.GetString("UI0031") + " : " + BData.GetString(skill.strSummary).Replace("[1]", (num2 + skill.fGrow).ToString("###0.##")).Replace("[2]", (num3 + skill.fGrow2).ToString("###0.##"));
  }

  public void RefreshHighlight()
  {
    for (int index = 0; index < this.arrHighlight.Length; ++index)
      this.arrHighlight[index].gameObject.SetActive(index == this.nSelectedSkill);
    this.btnLearn.interactable = this.arrSkill[this.nSelectedSkill] != SkillKey.eNone;
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    if (this.nSelectedSkill == -1)
      this.nSelectedSkill = 0;
    this.OnLearn();
  }

  public void OnClick(int n)
  {
    if (this.arrSkill[n] == SkillKey.eNone)
      return;
    UIMgr.PlaySound("Character", true);
    this.RefreshDetail(n);
    this.RefreshHighlight();
  }

  public void OnLearn()
  {
    if (this.arrSkill[this.nSelectedSkill] == SkillKey.eNone)
      return;
    UIMgr.PlaySound("LevelUp", false);
    PlayerMonsterData playerMon = Info.GetPlayerMon(0);
    ObscuredInt obscuredInt = (ObscuredInt) ((int) playerMon.nExp - Info.GetNeedExp(0));
    playerMon.nExp = obscuredInt;
    ++Info.GetPlayerMon(0).nLv;
    Info.AddSummaryMessageLv(0, (int) Info.GetPlayerMon(0).nLv);
    Info.AddSummaryMessageSkill(this.ePreLearn, this.nPreLv);
    Info.AddSummaryMessageSkill(this.arrSkill[this.nSelectedSkill], Info.LearnSkill(0, this.arrSkill[this.nSelectedSkill]));
    Info.CheckLevelAchievement();
    if ((int) Info.GetPlayerMon(0).nExp >= Info.GetNeedExp(0))
      this.RefreshSelect();
    else if ((Object) PageBattle.obj != (Object) null)
    {
      UIMgr.RemoveTop();
      PageBattle.obj.MoveToDropItem();
    }
    else
    {
      if (!((Object) PageLobby.obj != (Object) null))
        return;
      SaveManager.Save();
      Info.RefreshPartySkill();
      PageLobby.obj.OnMoveMenu(0);
      UIMgr.RemoveTop();
      PageLobby.obj.AutoBattleStart();
    }
  }
}
