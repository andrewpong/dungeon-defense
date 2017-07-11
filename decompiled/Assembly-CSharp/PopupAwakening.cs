// Decompiled with JetBrains decompiler
// Type: PopupAwakening
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class PopupAwakening : UIPage
{
  private static string red = "<color='red'>";
  private static string white = "<color='white'>";
  public Image imgMonPre;
  public Image imgMonAft;
  public Text textTitle;
  public Text textCondition;
  public Text textDesc;
  public Text textSkill;
  public Text textBtnAwk;
  public Button btnAwaken;
  public CharSkillElt[] arrSkillElt;
  public static PopupAwakening obj;
  private bool canAwake;

  protected override void Awake()
  {
    base.Awake();
    PopupAwakening.obj = this;
    this.textTitle.text = BData.GetString("UI0306");
    this.textCondition.text = BData.GetString("UI0307");
    this.textSkill.text = BData.GetString("UI0308");
  }

  protected override void Start()
  {
    base.Start();
    PlayerMonsterData pData = Info.currentSave.arrPlayerMon[0];
    MonsterData monster = BData.GetMonster((short) pData.sID);
    this.imgMonPre.sprite = RSMgr.GetSprite(monster.strSprite);
    this.imgMonAft.sprite = RSMgr.GetSprite(monster.strSpriteAwk);
    this.canAwake = true;
    this.textDesc.text = "- " + ((int) pData.nLv >= 400 ? PopupAwakening.white : PopupAwakening.red) + BData.GetString("UI0006") + " " + pData.nLv.ToString() + "/400</color>";
    if ((int) pData.nLv < 400)
      this.canAwake = false;
    int index1 = 0;
    for (int index2 = 0; index2 < monster.listNeedSkill.Count; ++index2)
    {
      SkillData skill1 = BData.GetSkill(monster.listNeedSkill[index2]);
      int num = Mathf.Min(skill1.nMax, 20);
      int skill2 = Info.GetSkill(pData, skill1.eKey, false);
      Text textDesc = this.textDesc;
      string str = textDesc.text + "\n- " + (skill2 >= num ? PopupAwakening.white : PopupAwakening.red) + BData.GetString(skill1.strName) + " Lv." + skill2.ToString() + "/" + num.ToString() + "</color>";
      textDesc.text = str;
      if (skill2 < num)
        this.canAwake = false;
    }
    for (; index1 < monster.listAwakenLearnSkill.Count; ++index1)
      this.arrSkillElt[index1].SetSkillElt(monster.listAwakenLearnSkill[index1], 1, true, false);
    for (; index1 < this.arrSkillElt.Length; ++index1)
      this.arrSkillElt[index1].gameObject.SetActive(false);
    Text textDesc1 = this.textDesc;
    string str1 = textDesc1.text + "\n- " + ((long) Info.currentSave.nNewGold >= (long) (int) Info.nAwakenCost ? PopupAwakening.white : PopupAwakening.red) + BData.GetString("UI0001") + " " + Info.nAwakenCost.ToString("N0") + "G</color>";
    textDesc1.text = str1;
    this.btnAwaken.interactable = this.canAwake && !Info.isAwaken(pData);
    this.textBtnAwk.text = !Info.isAwaken(pData) ? BData.GetString("UI0303") : BData.GetString("UI0302");
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void OnClose()
  {
    UIMgr.PlaySound("Negative", false);
    UIMgr.RemoveTop();
  }

  public void OnAwaken()
  {
    PlayerMonsterData pData = Info.currentSave.arrPlayerMon[0];
    MonsterData monster = BData.GetMonster((short) pData.sID);
    if (Info.isAwaken(pData) || (int) pData.nLv < 400)
      return;
    if ((long) Info.currentSave.nNewGold < (long) (int) Info.nAwakenCost)
    {
      UIMgr.NotEnoughGold();
    }
    else
    {
      for (int index = 0; index < monster.listNeedSkill.Count; ++index)
      {
        SkillData skill = BData.GetSkill(monster.listNeedSkill[index]);
        int num = Mathf.Min(skill.nMax, 20);
        if (Info.GetSkill(pData, skill.eKey, false) < num)
          return;
      }
      pData.bAwaken = (ObscuredBool) true;
      SavedData currentSave = Info.currentSave;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave.nNewGold - (long) (int) Info.nAwakenCost);
      currentSave.nNewGold = obscuredLong;
      PageLobby.obj.nGold = PageLobby.obj.nGold;
      UIMgr.RemoveTop();
      UIMgr.PlaySound("Hire", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0309"), true, false, string.Empty);
      ++Info.achievement.nAwaken;
      if (!(bool) ((Object) PageLobby.obj))
        return;
      PageLobby.obj.RefreshCharTab();
      PageLobby.obj.RefreshCharUnitInfo(0);
      PageLobby.obj.RefreshHighlightCharTab();
    }
  }
}
