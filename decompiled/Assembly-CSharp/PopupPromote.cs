// Decompiled with JetBrains decompiler
// Type: PopupPromote
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class PopupPromote : UIPage
{
  public static PopupPromote obj;
  public Text textBtnPromote;
  public Text textMedalOwn;
  public Text textMedalNeed;
  public Text textCurrentPromote;
  public Text textWarning;
  public Text textLvBonus;
  public Text[] textEffect;
  public GameObject[] goLock;
  public Image imgChar;
  public Button btnPromote;
  public Text textInit;
  public Text textInitCost;
  public Button btnInit;
  private bool bChanged;

  protected override void Awake()
  {
    base.Awake();
    PopupPromote.obj = this;
    this.textWarning.text = BData.GetString("UI0386");
    this.textBtnPromote.text = BData.GetString("UI0385");
    this.textLvBonus.text = BData.GetString("UI0387");
    this.textInit.text = BData.GetString("UI0383");
    this.bChanged = false;
    this.Refresh();
  }

  private void Refresh()
  {
    PlayerMonsterData playerMon = Info.GetPlayerMon((int) Info.nSelectedMonster);
    if (playerMon == null)
    {
      this.OnClose();
    }
    else
    {
      MonsterData monster = BData.GetMonster((short) playerMon.sID);
      int promoteLevel = Info.GetPromoteLevel(monster.sID);
      int num = Info.GetNeedMedalPromote(promoteLevel) * monster.nPromoteMul;
      bool flag1 = (long) num > (long) Info.rebirth.nNewMedal;
      this.imgChar.sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster.eAwaken) ? monster.strSprite : monster.strSpriteAwk);
      this.textCurrentPromote.text = "+" + promoteLevel.ToString();
      this.textMedalNeed.text = num.ToString("N0");
      this.textMedalNeed.color = !flag1 ? Color.white : Color.red;
      this.textMedalNeed.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.textMedalNeed.preferredWidth);
      this.textMedalOwn.text = "(" + Info.rebirth.nNewMedal.ToString("N0") + ")";
      this.btnInit.interactable = promoteLevel > 0;
      this.textInitCost.text = (promoteLevel * 5000).ToString("N0");
      this.textInitCost.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.textInitCost.preferredWidth);
      for (int index = 0; index < 10; ++index)
      {
        bool flag2 = (index + 1) * 20 <= promoteLevel;
        this.textEffect[index].color = !flag2 ? Color.gray : Color.white;
        this.goLock[index].SetActive(!flag2);
      }
      this.textEffect[0].text = "+20 : " + BData.GetString("UI0358").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillMain).strName)).Replace("[2]", monster.fPromoteMainFac.ToString());
      this.textEffect[1].text = "+40 : " + BData.GetString("UI0358").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillSub).strName)).Replace("[2]", monster.fPromoteSubFac.ToString());
      this.textEffect[2].text = "+60 : " + BData.GetString("UI0359").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillMain).strName)).Replace("[2]", (monster.fPromoteMainDmg * 100f).ToString());
      this.textEffect[3].text = "+80 : " + BData.GetString("UI0359").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillSub).strName)).Replace("[2]", (monster.fPromoteSubDmg * 100f).ToString());
      this.textEffect[4].text = "+100 : " + BData.GetString("SKLSMR0102").Replace("[1]", "50");
      this.textEffect[5].text = "+120 : " + BData.GetString("UI0358").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillMain).strName)).Replace("[2]", (monster.fPromoteMainFac * 2f).ToString());
      this.textEffect[6].text = "+140 : " + BData.GetString("UI0358").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillSub).strName)).Replace("[2]", (monster.fPromoteSubFac * 2f).ToString());
      this.textEffect[7].text = "+160 : " + BData.GetString("UI0359").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillMain).strName)).Replace("[2]", (monster.fPromoteMainDmg * 300f).ToString());
      this.textEffect[8].text = "+180 : " + BData.GetString("UI0359").Replace("[1]", BData.GetString(BData.GetSkill(monster.ePromoteSkillSub).strName)).Replace("[2]", (monster.fPromoteSubDmg * 300f).ToString());
      this.textEffect[9].text = "+200 : " + BData.GetString("SKLSMR0102").Replace("[1]", "150");
    }
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
    UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
    if (!this.bChanged)
      return;
    SaveManager.SaveRebirth();
  }

  public void OnPromote()
  {
    PlayerMonsterData playerMon = Info.GetPlayerMon((int) Info.nSelectedMonster);
    if (playerMon == null)
    {
      this.OnClose();
    }
    else
    {
      MonsterData monster = BData.GetMonster((short) playerMon.sID);
      int num = Info.GetNeedMedalPromote(Info.GetPromoteLevel((short) playerMon.sID)) * monster.nPromoteMul;
      if ((long) num > (long) Info.rebirth.nNewMedal)
      {
        UIMgr.PlaySound("Negative", false);
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0240"), true, false, string.Empty);
      }
      else
      {
        SavedRebirth rebirth = Info.rebirth;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewMedal - (long) num);
        rebirth.nNewMedal = obscuredLong;
        Info.UpgPromoteLevel((short) playerMon.sID);
        UIMgr.PlaySound("Hire", false);
        this.bChanged = true;
        this.Refresh();
      }
    }
  }

  public void OnInit()
  {
    int num = Info.GetPromoteLevel(BData.GetMonster((short) Info.GetPlayerMon((int) Info.nSelectedMonster).sID).sID) * 5000;
    if ((long) Info.rebirth.nNewStone < (long) num)
    {
      UIMgr.NotEnoughStone();
      UIMgr.PlaySound("Negative", false);
    }
    else
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetYesNo("InitPromote", BData.GetString("UI0396"), true);
    }
  }

  public void OnRealInit()
  {
    PlayerMonsterData playerMon = Info.GetPlayerMon((int) Info.nSelectedMonster);
    MonsterData monster = BData.GetMonster((short) playerMon.sID);
    int promoteLevel = Info.GetPromoteLevel(monster.sID);
    int num = promoteLevel * 5000;
    for (int index = 0; index < promoteLevel; ++index)
    {
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewMedal + (long) (Info.GetNeedMedalPromote(promoteLevel - 1 - index) * monster.nPromoteMul));
      rebirth.nNewMedal = obscuredLong;
    }
    SavedRebirth rebirth1 = Info.rebirth;
    ObscuredLong obscuredLong1 = (ObscuredLong) ((long) rebirth1.nNewStone - (long) num);
    rebirth1.nNewStone = obscuredLong1;
    Info.InitPromoteLevel((short) playerMon.sID);
    UIMgr.PlaySound("Hire", false);
    this.Refresh();
    this.bChanged = true;
  }
}
