// Decompiled with JetBrains decompiler
// Type: PageLobby
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageLobby : UIMgr
{
  public static PageLobby obj;
  public AudioSource _asMusic;
  public GameObject[] arrLeftPanel;
  public Text textGold;
  public Text[] textMenu;
  public Text textActionTitle;
  public Text textDailySummary;
  public Text textActionRepairName;
  public Text textActionRepairCost;
  public Text textActionSave;
  public Text textActionAchievement;
  public Text textActionMission;
  public Text textActionHellStone;
  public Button btnActionRepair;
  public RectTransform rtActionSummary;
  public GameObject goGPGS;
  public GameObject goCloudSave;
  public CharUnitTab[] arrCharUnitTab;
  public Text textCharNameClass;
  public Text textCharLevelWage;
  public Text textCharHire;
  public Text textCharDismiss;
  public Text textCharAwaken;
  public Text textCharBatch;
  public Text textCharFocusSkill;
  public Text textCharStat;
  public Text textCharPromote;
  public Text textCharTrait;
  public RectTransform rtCharSkillRect;
  public CharSkillElt[] arrCharSkillElt;
  public WeaponElt eltCharWeapon;
  public AccElt eltCharAmulet;
  public AccElt eltCharRing;
  public Button btnCharHire;
  public GameObject goCharDismiss;
  public GameObject goCharAwaken;
  public GameObject goCharBatch;
  public StringTooltip strCharStatTooltip;
  public Text[] textItemMenu;
  public Button[] btnItemMenu;
  public Text textBtnRebirth;
  public Text textBtnRebirthShop;
  public Text textBtnRubyShop;
  public Text textRebirthDesc;
  public Text textRebirthStone;
  public Text textRebirthRuby;
  public Text textStoneBonus;
  public Text textRubyBonus;
  public Button btnRebirth;
  public Image imgAcvFill;
  public Text textAcvFill;
  public GameObject goAcvAlarm;
  public List<AchievementElt> listAcvElt;
  public GameObject goRscAlarm;
  public ResearchElt[] arrResearchElt;
  public Text textResearchTitle;
  public Text textResearchDetailTitle;
  public Text textResearchDetailDesc;
  public Text textResearchDetailButton;
  public Text textResearchGuage;
  public Image imgResearchFillPre;
  public Image imgResearchFill;
  public Image imgResearchDetailIcon;
  public Button btnResearchDetail;
  public DungeonElt[] arrDungeonElt;
  public Text textTowerTrial;
  public Text textEndlessWave;
  public Text textBattleBegin;
  public Text textBattleDays;
  public bool bCompleteResearch;
  public bool bAllResearch;

  public long nGold
  {
    get
    {
      return (long) Info.currentSave.nNewGold;
    }
    set
    {
      Info.currentSave.nNewGold = (ObscuredLong) value;
      this.textGold.text = Info.currentSave.nNewGold.ToString("N0") + "G";
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PageLobby.obj = this;
    UIMgr.asMusic = this._asMusic;
    this.textMenu[0].text = BData.GetString("UI0139");
    this.textMenu[1].text = BData.GetString("UI0002");
    this.textMenu[2].text = BData.GetString("UI0003");
    this.textMenu[3].text = BData.GetString("UI0004");
    this.textMenu[4].text = BData.GetString("DUN011");
    this.textMenu[5].text = BData.GetString("UI0140");
    this.textResearchTitle.text = BData.GetString("UI0155");
    this.textItemMenu[0].text = BData.GetString("UI0003") + " " + BData.GetString("UI0071");
    this.textItemMenu[1].text = BData.GetString("UI0003") + " " + BData.GetString("UI0016");
    this.textItemMenu[2].text = BData.GetString("UI0003") + " " + BData.GetString("UI0093");
    this.textItemMenu[3].text = BData.GetString("UI0003") + " " + BData.GetString("UI0100");
    this.textItemMenu[4].text = BData.GetString("UI0239");
    this.textItemMenu[5].text = BData.GetString("UI0241");
    this.textItemMenu[6].text = BData.GetString("UI0287");
    this.textItemMenu[7].text = BData.GetString("UI0179");
    this.textCharDismiss.text = BData.GetString("UI0120");
    this.textCharAwaken.text = BData.GetString("UI0303");
    this.textCharBatch.text = BData.GetString("UI0152");
    this.textCharHire.text = BData.GetString("UI0044");
    this.textBtnRebirth.text = BData.GetString("UI0193");
    this.textBtnRebirthShop.text = BData.GetString("UI0170");
    this.textBtnRubyShop.text = BData.GetString("UI0278");
    this.textRebirthDesc.text = BData.GetString("UI0194") + "\n<size='20'>" + BData.GetString("UI0195") + "</size>";
    this.textTowerTrial.text = BData.GetString("UI0214");
    this.textEndlessWave.text = BData.GetString("UI0268");
    this.textCharFocusSkill.text = BData.GetString("UI0323");
    this.textCharStat.text = BData.GetString("UI0322");
    this.textBattleDays.text = BData.GetString("UI0061").Replace("[1]", Info.currentSave.nDay.ToString());
    this.textBattleBegin.text = BData.GetString("UI0140");
    this.textCharPromote.text = BData.GetString("UI0385");
    this.textCharTrait.text = BData.GetString("UI0367");
  }

  protected override void Start()
  {
    base.Start();
    Info.RefreshElementalFac();
    this.nGold = this.nGold;
    Info.RefreshAccMod();
    Info.nDiffTrial = (ObscuredInt) Info.currentSave.nLastTrialDiff;
    Info.RefreshResearchPower();
    Info.listDropItem.Clear();
    Info.CalcLevelUp();
    for (int index = 0; index < 11; ++index)
    {
      DungeonData dungeon = BData.GetDungeon((DungeonType) index);
      if (Info.currentSave.dictDun.ContainsKey(dungeon.eID) && (int) Info.currentSave.dictDun[dungeon.eID] > dungeon.nMax)
        Info.currentSave.dictDun[dungeon.eID] = (ObscuredInt) dungeon.nMax;
    }
    SaveManager.Save();
    Info.CheckLevelAchievement();
    this.ProgressResearch();
    this.bAllResearch = true;
    int num = 0;
    for (int index = 1; index < 59; ++index)
    {
      if (Info.CheckResearch((ResearchID) index))
        ++num;
      else if (!BData.GetResearch((ResearchID) index).bRepeat)
        this.bAllResearch = false;
    }
    Info.RefreshBattleItemData();
    if (this.bAllResearch)
      Info.CheckAchievement(AchievementType.eResearchAll);
    if (num >= 35 && (int) Info.currentSave.nDay <= 200)
      Info.CheckAchievement(AchievementType.eResearchAllIn200);
    if ((int) Info.option.byAutoResearchType == 0)
      this.AutoResearch(false);
    else
      this.ResearchPlan();
    Info.TrySaveAchievement();
    Info.TrySaveRebirth();
    if (Info.listGetAcc.Count > 0)
      UIMgr.AddPage("PopupNewAcc");
    if (!Info.option.bReview && (int) Info.currentSave.nDay >= 20)
    {
      UIMgr.popupMsg.SetYesNo("Review", BData.GetString("UI0131"), false);
      Info.option.bReview = true;
      SaveManager.SaveOption();
    }
    else if (!Info.currentSave.bClear && (int) Info.rebirth.nRebirth < 1 && ((int) Info.currentSave.nDiff < 2 && (int) Info.currentSave.nDay >= 100))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0154"), true, false, string.Empty);
      Info.currentSave.bClear = true;
    }
    if ((int) Info.currentSave.arrPlayerMon[0].nExp >= Info.GetNeedExp(0))
      UIMgr.AddPage("PopupSkillSelect");
    GPGSMgr.single.CheckAchievementDayPass();
    GPGSMgr.single.ReportLeaderBoard();
    if (Info.currentSave.strSummary == string.Empty)
      Info.currentSave.strSummary = "<size='60'>" + BData.GetString("UI0061").Replace("[1]", Info.currentSave.nDay.ToString()) + "...</size>\n";
    if (Info.option.bAutoRepair)
    {
      if (this.nGold < (long) Info.nRepairCost && this.nGold >= (long) Info.nRepairCostOnePoint)
        this.OnDungeonRepairPart();
      else if (this.nGold >= (long) Info.nRepairCost)
        this.OnDungeonRepair();
    }
    if (Info.option.bAutoItemEnchant)
    {
      if ((int) Info.option.byAutoEnchantType == 0)
      {
        for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
        {
          if (Info.currentSave.arrPlayerMon[index] != null && (long) Info.currentSave.arrPlayerMon[index].nEquip != -1L)
            Info.OnWeaponSimpleEnchant((long) Info.currentSave.arrPlayerMon[index].nEquip, true);
        }
      }
      else
        Info.OnWeaponEqualEnchant(true);
    }
    if (Info.option.bAutoItemManage)
    {
      bool flag = Info.OnAutoEquip();
      if (Info.option.bAutoItemSell)
      {
        switch (Info.option.byAutoItemSellType)
        {
          case 0:
          case 1:
            flag = Info.OnSellAll() || flag;
            break;
          case 3:
            flag = Info.OnSellAllWithoutLengend() || flag;
            break;
        }
      }
      else
        flag = Info.OnSellAll() || flag;
      if (flag)
      {
        SavedData currentSave = Info.currentSave;
        string str = currentSave.strSummary + "\n\n(" + BData.GetString("UI0290") + ") " + BData.GetString("UI0292");
        currentSave.strSummary = str;
      }
    }
    if (Info.option.bAIBuild)
    {
      List<DungeonType> dungeonTypeList = new List<DungeonType>();
      List<int> intList = new List<int>();
      if (Info.option.listAutoBuildOrder.Count == 0)
      {
        dungeonTypeList.Add(DungeonType.eExpand);
        intList.Add(1);
        dungeonTypeList.Add(DungeonType.eLab);
        intList.Add(1);
        dungeonTypeList.Add(DungeonType.eParty);
        intList.Add(1);
        dungeonTypeList.Add(DungeonType.eNest);
        intList.Add(1);
        dungeonTypeList.Add(DungeonType.eDunHP);
        intList.Add(1);
        dungeonTypeList.Add(DungeonType.eBank);
        intList.Add(1);
        dungeonTypeList.Add(DungeonType.eStatue);
        intList.Add(1);
      }
      else
      {
        dungeonTypeList = new List<DungeonType>((IEnumerable<DungeonType>) Info.option.listAutoBuildOrder);
        intList = new List<int>((IEnumerable<int>) Info.option.listAutoBuildCount);
      }
      if (Info.option.nBuildRepeat < 1)
        Info.option.nBuildRepeat = 1;
      for (int index1 = 0; index1 < Info.option.nBuildRepeat; ++index1)
      {
        for (int index2 = 0; index2 < dungeonTypeList.Count; ++index2)
        {
          for (int index3 = 0; index3 < intList[index2]; ++index3)
          {
            if (Info.CanUpgDungeon(dungeonTypeList[index2], 1))
              Info.UpgDungeon(dungeonTypeList[index2], 1);
          }
        }
      }
      Info.bBattleFail = false;
    }
    if ((int) Info.currentSave.nDay < 20 && (int) Info.rebirth.nRebirth == 0)
    {
      SavedData currentSave = Info.currentSave;
      string str = currentSave.strSummary + "\n\n!" + BData.GetString("UI0313") + "!\n > " + BData.GetString("UI0314") + "\n > " + BData.GetString("UI0315") + "\n > " + BData.GetString("UI0316");
      currentSave.strSummary = str;
    }
    if ((int) Info.currentSave.nDay >= 100 && !Info.CheckRebirth(RebirthID.eFireDungeon) && (!Info.CheckRebirth(RebirthID.eWaterDungeon) && !Info.CheckRebirth(RebirthID.eNatureDungeon)) && (!Info.CheckRebirth(RebirthID.eLightDungeon) && !Info.CheckRebirth(RebirthID.eDarkDungeon)))
      UIMgr.AddPage("PopupElementalSelect");
    this.OnMoveMenu(0);
    UIMgr.PlayMusic();
    this.AutoBattleStart();
  }

  public void OnCallFocusSKill()
  {
    UIMgr.AddPage("PopupFocusSkill");
  }

  public void OnCallRubyShop()
  {
    UIMgr.AddPage("PopupRubyShop");
  }

  public void OnCallHellStone()
  {
    UIMgr.AddPage("PopupHellStone");
  }

  public void OnCallElementalSelect()
  {
    bool flag = (int) Info.currentSave.nDay > 99;
    if (!flag)
    {
      foreach (KeyValuePair<ObscuredInt, List<ObscuredInt>> keyValuePair in Info.rebirth.dictRebirthHistory)
      {
        for (int index = 0; index < keyValuePair.Value.Count; ++index)
        {
          if ((int) keyValuePair.Value[index] >= 100)
          {
            flag = true;
            break;
          }
        }
      }
    }
    if (!flag && !Info.CheckRebirth(RebirthID.eFireDungeon) && (!Info.CheckRebirth(RebirthID.eWaterDungeon) && !Info.CheckRebirth(RebirthID.eNatureDungeon)) && (!Info.CheckRebirth(RebirthID.eLightDungeon) && !Info.CheckRebirth(RebirthID.eDarkDungeon)))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0276").Replace("[1]", "100"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("MainButton", false);
      UIMgr.AddPage("PopupElementalSelect");
    }
  }

  public void AutoBattleStart()
  {
    if (!Info.option.bAutoBattleStart || !((Object) UIMgr.focused == (Object) this) || Info.bTempQuitBattle)
      return;
    this.OnBattleBegin();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    UIMgr.popupMsg.SetYesNo("Quit", BData.GetString("UI0110") + "\n" + BData.GetString("UI0243"), false);
  }

  public void ProgressResearch()
  {
    if (Info.CheckResearch(Info.currentSave.eResearch))
    {
      Info.currentSave.fResearch += Info.currentSave.fResearchProgress;
      Info.currentSave.fResearchProgress = 0.0f;
    }
    else
    {
      if (!Info.currentSave.bProgressResearch)
        return;
      Info.TrySaveAchievement();
      if (Info.currentSave.eResearch == ResearchID.eNone)
        return;
      ResearchData research = BData.GetResearch(Info.currentSave.eResearch);
      this.bCompleteResearch = (double) Info.currentSave.fResearchProgress >= (double) Info.GetResearchCost(research.eID);
      if (this.bCompleteResearch)
      {
        Info.currentSave.fResearch = Info.currentSave.fResearchProgress - (float) Info.GetResearchCost(research.eID);
        Info.currentSave.fResearchProgress = 0.0f;
        if (!research.bRepeat)
        {
          Info.currentSave.listResearch.Add(Info.currentSave.eResearch);
        }
        else
        {
          Info.UpgRepeatResearch(research.eID);
          PageLobby.obj.AutoResearch(true);
        }
        if (!Info.option.bAutoResearch)
        {
          UIMgr.PlaySound("Fanfare", false);
          UIMgr.popupMsg.SetMsg(BData.GetString("UI0163") + " " + BData.GetString("UI0161") + "\n<" + BData.GetString(research.strName) + ">\n( " + BData.GetString(research.strDesc) + " )", true, true, "ResearchComplete");
        }
      }
      Info.currentSave.bProgressResearch = false;
    }
  }

  public void OnMoveMenu(int n)
  {
    this.nGold = this.nGold;
    for (int index = 0; index < this.arrLeftPanel.Length; ++index)
      this.arrLeftPanel[index].SetActive(index == n);
    switch (n)
    {
      case 0:
        this.RefreshAction();
        break;
      case 1:
        this.RefreshCharTab();
        this.RefreshCharUnitInfo(0);
        this.RefreshHighlightCharTab();
        break;
      case 2:
        this.textRebirthStone.text = Info.nTodayStone.ToString();
        float num = Info.GetStoneBonus();
        this.textStoneBonus.text = (double) num <= 0.0 ? string.Empty : BData.GetString("UI0405").Replace("[1]", num.ToString("N0")) + ((int) Info.rebirth.nRebirthBonus <= 0 ? string.Empty : "(" + Info.rebirth.nRebirthBonus.ToString() + "/5)");
        this.textRebirthRuby.text = Info.nTodayRuby.ToString();
        num = Info.GetRubyBonus();
        this.textRubyBonus.text = (double) num <= 0.0 ? string.Empty : BData.GetString("UI0405").Replace("[1]", num.ToString("N0")) + ((int) Info.rebirth.nRebirthBonus <= 0 ? string.Empty : "(" + Info.rebirth.nRebirthBonus.ToString() + "/5)");
        this.btnRebirth.interactable = true;
        break;
      case 3:
        this.RefreshDungeon();
        break;
      case 4:
        this.RefreshAchievement();
        Info.listCheck.Clear();
        break;
      case 6:
        this.RefreshResearch();
        Info.eSelectedResearch = Info.currentSave.eResearch;
        this.RefreshDetailResearch(Info.currentSave.eResearch);
        this.RefreshResearchProgress();
        this.RefreshResearchHighlight();
        break;
    }
    this.RefreshAlarm();
  }

  public void OnTowerTrial()
  {
    if ((int) Info.currentSave.nDay <= 10)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0276").Replace("[1]", "10"), true, false, string.Empty);
    }
    else
      UIMgr.AddPage("PopupTrialBrief");
  }

  public void OnCallEndlessWave()
  {
    if ((int) Info.currentSave.nDay <= 20 && (int) Info.rebirth.nRebirth == 0)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0276").Replace("[1]", "20"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("MainButton", false);
      UIMgr.AddPage("PopupEndlessBrief");
    }
  }

  public void OnBattleBegin()
  {
    if (Info.currentSave.dictItem.Count > Info.nMaxInven)
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0057"), true, false, string.Empty);
    else if ((Info.currentSave.eResearch == ResearchID.eNone || Info.CheckResearch(Info.currentSave.eResearch)) && !this.bAllResearch)
      UIMgr.popupMsg.SetYesNo("WhyNotResearch", BData.GetString("UI0164"), true);
    else
      this.MoveToBattle();
  }

  public void MoveToBattle()
  {
    Info.eBattle = BattleType.eSurvial;
    UIMgr.PlaySound("BattleBegin", false);
    UIMgr.LoadLevel("Battle", 1f, 1f, Color.black);
  }

  public void RefreshAction()
  {
    int nRepairCost = Info.nRepairCost;
    this.textActionTitle.text = "< " + BData.GetString("UI0059") + " >";
    this.textActionSave.text = BData.GetString("UI0098");
    this.textActionAchievement.text = BData.GetString("UI0005");
    this.textActionMission.text = BData.GetString("UI0301");
    this.textActionHellStone.text = BData.GetString("UI0338");
    this.textActionRepairName.text = BData.GetString("UI0060") + "\n<size='24'>(" + Info.currentSave.fDunCurHP.ToString("N0") + "/" + Info.fDunMaxHP.ToString("N0") + ")</size>";
    this.textActionRepairCost.text = nRepairCost.ToString("N0") + "G";
    this.textActionRepairCost.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.textActionRepairCost.preferredWidth);
    this.textDailySummary.text = Info.currentSave.strSummary;
    this.rtActionSummary.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.textDailySummary.preferredHeight + 60f);
    this.btnActionRepair.interactable = (double) (float) Info.currentSave.fDunCurHP < (double) (float) Info.fDunMaxHP;
  }

  public void RefreshCharTab()
  {
    for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
    {
      this.arrCharUnitTab[index].gameObject.SetActive(Info.GetPlayerMon(index) != null);
      if (Info.GetPlayerMon(index) != null)
        this.arrCharUnitTab[index].SetUnitTab(Info.GetPlayerMon(index), index);
    }
  }

  public void RefreshHighlightCharTab()
  {
    for (int index = 0; index < this.arrCharUnitTab.Length; ++index)
      this.arrCharUnitTab[index].SetHighlight(index == (int) Info.nSelectedMonster);
  }

  public void RefreshCharUnitInfo(int nPos)
  {
    Info.nSelectedMonster = (ObscuredInt) nPos;
    PlayerMonsterData playerMon = Info.GetPlayerMon((int) Info.nSelectedMonster);
    MonsterData monster = BData.GetMonster((short) playerMon.sID);
    this.textCharNameClass.text = BData.GetString("UI0007") + " : " + BData.GetString(monster.strName) + " Lv." + (object) playerMon.nLv + "\n" + BData.GetString("UI0010") + " : " + Info.GetWage(nPos).ToString("N0") + " G";
    this.textCharLevelWage.text = string.Empty;
    int promoteLevel = Info.GetPromoteLevel((short) playerMon.sID);
    List<SkillKey> skillKeyList1 = new List<SkillKey>((IEnumerable<SkillKey>) playerMon.dictSkill.Keys);
    List<SkillKey> skillKeyList2 = new List<SkillKey>((IEnumerable<SkillKey>) monster.listLearnSkill);
    skillKeyList2.AddRange((IEnumerable<SkillKey>) monster.listAwakenLearnSkill);
    skillKeyList1.Sort();
    skillKeyList1.Reverse();
    int index1 = 0;
    for (int index2 = 0; index2 < skillKeyList1.Count; ++index2)
    {
      this.arrCharSkillElt[index1].gameObject.SetActive(true);
      this.arrCharSkillElt[index1].SetSkillElt(skillKeyList1[index2], Info.GetSkill(playerMon, skillKeyList1[index2], false), monster.listAwakenLearnSkill.Contains(skillKeyList1[index2]) && !Info.isAwaken(playerMon), (bool) playerMon.bFocused && playerMon.eFocusedSkill == skillKeyList1[index2]);
      skillKeyList2.Remove(skillKeyList1[index2]);
      ++index1;
    }
    for (int index2 = 0; index2 < skillKeyList2.Count; ++index2)
    {
      this.arrCharSkillElt[index1].gameObject.SetActive(true);
      this.arrCharSkillElt[index1].SetSkillElt(skillKeyList2[index2], Info.GetSkill(playerMon, skillKeyList2[index2], false), monster.listAwakenLearnSkill.Contains(skillKeyList2[index2]) && !Info.isAwaken(playerMon), (bool) playerMon.bFocused && playerMon.eFocusedSkill == skillKeyList2[index2]);
      ++index1;
    }
    float num1 = 0.0f;
    float num2 = 0.0f;
    float num3 = 0.0f;
    float num4 = 0.0f;
    float num5 = 0.0f;
    float num6 = 0.0f;
    int num7 = 0;
    int num8 = 0;
    float num9 = (float) (0.600000023841858 * (1.0 + (double) Info.GetResearchFac(ResearchID.eMecenaryTraining) * 0.00999999977648258));
    if ((long) playerMon.nEquip != -1L)
    {
      BattleItemData battleItem = Info.GetBattleItem((long) playerMon.nEquip);
      float num10 = battleItem.fDmg * (float) (1.0 + (double) Info.GetSkillFac(playerMon, SkillKey.eSnipe) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetSkillFac(playerMon, SkillKey.eBasicTraining) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetSkillFac(playerMon, SkillKey.ePowerGaurdian) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetAccModFac(nPos, ModType.eDmg) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetSkillFac2(playerMon, SkillKey.eWindWeapon) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eRubyCharDmg) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRepeatResearch(ResearchID.eUnlimitedPower) * 0.00999999977648258);
      float num11 = promoteLevel < 200 ? (promoteLevel < 100 ? num10 * (float) (1.0 + (double) promoteLevel * 0.00999999977648258) : num10 * (float) (1.5 + (double) promoteLevel * 0.00999999977648258)) : num10 * (float) (3.0 + (double) promoteLevel * 0.00999999977648258);
      if (Info.isAwaken(playerMon))
        num11 *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eAwaken) * 0.00999999977648258);
      num2 = (nPos != 0 ? num11 * num9 * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eMercenaryDmg) * 0.00999999977648258) : num11 * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eAcientBlood) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eMainCharDmg) * 0.00999999977648258)) * (float) (1.0 + (double) Info.GetSkillFac(nPos, SkillKey.eTrainedKnight) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetSkillFac(nPos, SkillKey.ePowerGaurdian) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetDungeonFactor(DungeonType.eParty, -1) * 0.00999999977648258);
      if ((double) Info.GetSkillFac(nPos, SkillKey.eElementalForce) > 0.0)
      {
        float num12 = 0.0f;
        for (int nPos1 = 0; nPos1 < Info.currentSave.arrPlayerMon.Length; ++nPos1)
        {
          if (Info.GetPlayerMon(nPos1) != null)
          {
            short sId = (short) Info.GetPlayerMon(nPos1).sID;
            if ((int) sId >= 15 && (int) sId <= 19)
              ++num12;
          }
        }
        num2 *= (float) (1.0 + (double) Info.GetSkillFac(nPos, SkillKey.eElementalForce) * 0.00999999977648258 * (double) num12);
      }
      float num13 = (float) (1.0 + (double) Info.GetSkillFac(playerMon, SkillKey.eFirerate) * 0.00999999977648258 - (double) Info.GetSkillFac2(playerMon, SkillKey.eSnipe) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetAccModFac(nPos, ModType.eAsp) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetSkillFac2(nPos, SkillKey.eTrainedKnight) * 0.00999999977648258);
      num3 = 1f / battleItem.fRate * num13;
      num4 = battleItem.fReload / (float) ((1.0 + (double) Info.GetSkillFac(playerMon, SkillKey.eReloading) * 0.00999999977648258) * (1.0 + (double) Info.GetAccModFac(nPos, ModType.eReload) * 0.00999999977648258));
      num5 = battleItem.fCri + 5f + Info.GetSkillFac(playerMon, SkillKey.eEagleEye) + Info.GetAccModFac(nPos, ModType.eCri) + Info.GetElementalFac(ElementalID.eFireCrRate, 0);
      num6 = (float) ((double) battleItem.fCriDmg + (double) Info.GetAccModFac(nPos, ModType.eCriDmg) * 0.00999999977648258 + (double) Info.GetPartySkillFac(SkillKey.eCriDmgParty) * 0.00999999977648258 + (double) Info.GetElementalFac(ElementalID.eFireCrDmg, 0) * 0.00999999977648258);
      num7 = Mathf.RoundToInt((float) ((double) battleItem.nAmmo * (1.0 + (double) Info.GetAccModFac(nPos, ModType.eAmmo) * 0.00999999977648258) * (1.0 + (double) Info.GetSkillFac(playerMon, SkillKey.eAmmoSupply) * 0.00999999977648258)));
      if (BData.GetWeapon((short) battleItem.sID).eWeapon == WeaponType.eBow)
        num7 = 1;
      num8 = battleItem.nSpread;
      if (battleItem.eWeapon == WeaponType.eShriken)
        num8 += (int) Info.GetSkillFac(nPos, SkillKey.eShriken);
      else if (battleItem.eWeapon == WeaponType.eBow)
        num8 += Info.GetAccModFacToInt(nPos, ModType.eAddArrow);
      else if (battleItem.eWeapon == WeaponType.eSpear)
        num8 += Info.GetAccModFacToInt(nPos, ModType.eJavelinAddShot);
      float num14 = 1f / num3;
      float num15 = num7 != 1 ? (float) num7 * num14 + num4 : ((double) num14 <= (double) num4 ? num4 : num14);
      num1 = (float) ((double) num2 * (double) num7 / (double) num15 * (1.0 + (double) Mathf.Min(1f, num5 * 0.01f) * (double) num6)) * (float) num8;
    }
    Text textCharNameClass = this.textCharNameClass;
    string str = textCharNameClass.text + "\n" + BData.GetString("UI0091") + " : " + num1.ToString("N0");
    textCharNameClass.text = str;
    this.strCharStatTooltip.strTooltip = BData.GetString("UI0091") + " : " + num1.ToString("N1") + "\n" + BData.GetString("UI0013") + " : " + num2.ToString("N1") + (num8 != 1 ? " x" + num8.ToString() : string.Empty) + "\n" + BData.GetString("UI0014") + " : " + num3.ToString("N3") + "\n" + BData.GetString("UI0015") + " : " + num4.ToString("N3") + "\n" + BData.GetString("UI0326") + " : " + num5.ToString("N2") + "%\n" + BData.GetString("UI0327") + " : " + (num6 * 100f).ToString("N2") + "%\n" + BData.GetString("UI0012") + " : " + num7.ToString("N0") + (nPos == 0 ? string.Empty : "\n" + BData.GetString("UI0328") + " : " + (1f - num9).ToString("P0"));
    this.eltCharWeapon.SetItem((long) playerMon.nEquip, WeaponElt.Type.CharEquip, 0);
    this.eltCharAmulet.SetItem((long) playerMon.nAmulet, AccElt.Type.CharEquip, 0);
    this.eltCharRing.SetItem((long) playerMon.nRing, AccElt.Type.CharEquip, 0);
    this.goCharAwaken.SetActive(nPos == 0);
    this.goCharDismiss.SetActive(nPos != 0);
    for (; index1 < this.arrCharSkillElt.Length; ++index1)
      this.arrCharSkillElt[index1].gameObject.SetActive(false);
  }

  public void RefreshAchievement()
  {
    List<AchievementType> achievementTypeList = new List<AchievementType>();
    int count = BData.dictAcv.Count;
    for (int index = 0; index < this.listAcvElt.Count; ++index)
    {
      AchievementType achievementType = (AchievementType) index;
      switch (achievementType)
      {
        case AchievementType.eExpand1:
          achievementTypeList.Add(AchievementType.eNecromancer);
          achievementTypeList.Add(AchievementType.eMagicalGirl);
          achievementTypeList.Add(AchievementType.eDarkKnight);
          break;
        case AchievementType.eNecromancer:
        case AchievementType.eMagicalGirl:
        case AchievementType.eDarkKnight:
          continue;
      }
      achievementTypeList.Add(achievementType);
    }
    int num1 = 0;
    for (int index = 0; index < achievementTypeList.Count; ++index)
    {
      if (Info.IsAchievement(achievementTypeList[index]))
        ++num1;
      this.listAcvElt[index].Refresh(achievementTypeList[index]);
    }
    float num2 = Mathf.Clamp((float) num1 / (float) count, 0.0f, 1f);
    this.imgAcvFill.fillAmount = num2;
    this.textAcvFill.text = num1.ToString() + "/" + count.ToString() + " ( " + num2.ToString("P0") + " )";
  }

  public void RefreshDungeon()
  {
    List<DungeonType> dungeonTypeList1 = new List<DungeonType>();
    dungeonTypeList1.Add(DungeonType.eDunHP);
    dungeonTypeList1.Add(DungeonType.eAutoRepair);
    dungeonTypeList1.Add(DungeonType.eBank);
    dungeonTypeList1.Add(DungeonType.eExpand);
    dungeonTypeList1.Add(DungeonType.eLab);
    dungeonTypeList1.Add(DungeonType.eNest);
    dungeonTypeList1.Add(DungeonType.eParty);
    dungeonTypeList1.Add(DungeonType.eStatue);
    dungeonTypeList1.Add(DungeonType.eStorage);
    dungeonTypeList1.Add(DungeonType.eRegen);
    dungeonTypeList1.Add(DungeonType.eShop);
    dungeonTypeList1.Reverse();
    List<DungeonType> dungeonTypeList2 = new List<DungeonType>();
    for (int index = 0; index < dungeonTypeList1.Count; ++index)
    {
      if (Info.GetDungeon(dungeonTypeList1[index]) < BData.GetDungeon(dungeonTypeList1[index]).nMax)
        dungeonTypeList2.Insert(0, dungeonTypeList1[index]);
      else
        dungeonTypeList2.Add(dungeonTypeList1[index]);
    }
    for (int index = 0; index < this.arrDungeonElt.Length; ++index)
      this.arrDungeonElt[index].Refresh(dungeonTypeList2[index]);
  }

  public void RefreshResearch()
  {
    for (int index = 0; index < this.arrResearchElt.Length; ++index)
      this.arrResearchElt[index].Refresh();
  }

  public void RefreshResearchProgress()
  {
    for (int index = 0; index < this.arrResearchElt.Length; ++index)
      this.arrResearchElt[index].SetProgress(this.arrResearchElt[index].eID == Info.currentSave.eResearch && !this.bAllResearch);
  }

  public void RefreshResearchHighlight()
  {
    for (int index = 0; index < this.arrResearchElt.Length; ++index)
      this.arrResearchElt[index].SetHighlight(this.arrResearchElt[index].eID == Info.eSelectedResearch);
  }

  public void RefreshDetailResearch(ResearchID eID)
  {
    this.btnResearchDetail.interactable = false;
    this.imgResearchDetailIcon.enabled = eID != ResearchID.eNone;
    Image imgResearchFill = this.imgResearchFill;
    float num1 = 0.0f;
    this.imgResearchFillPre.fillAmount = num1;
    double num2 = (double) num1;
    imgResearchFill.fillAmount = (float) num2;
    if (eID == ResearchID.eNone)
    {
      Text researchDetailTitle = this.textResearchDetailTitle;
      string empty = string.Empty;
      this.textResearchDetailDesc.text = empty;
      string str = empty;
      researchDetailTitle.text = str;
      this.textResearchDetailButton.text = string.Empty;
      this.textResearchGuage.text = BData.GetString("UI0161");
    }
    else
    {
      ResearchData research = BData.GetResearch(eID);
      bool flag1 = Info.CheckResearch(eID);
      bool flag2 = Info.LearnableResearch(eID);
      bool flag3 = Info.currentSave.eResearch == eID;
      float num3 = !flag2 ? 0.0f : (Info.currentSave.fResearchProgress + Info.currentSave.fResearch + (float) Info.fResearchPower) / (float) Info.GetResearchCost(research.eID);
      float num4 = !flag3 ? 0.0f : Info.currentSave.fResearchProgress / (float) Info.GetResearchCost(research.eID);
      int num5 = Mathf.Max(Mathf.CeilToInt(((float) Info.GetResearchCost(research.eID) - Info.currentSave.fResearchProgress - Info.currentSave.fResearch) / (float) Info.fResearchPower), 1);
      this.btnResearchDetail.interactable = flag2 && !flag1 && !flag3;
      this.textResearchDetailTitle.text = BData.GetString(research.strName) + (!research.bRepeat ? string.Empty : "Lv." + (object) Info.GetRepeatResearch(eID));
      this.imgResearchDetailIcon.sprite = RSMgr.GetSprite(research.strIcon);
      this.textResearchDetailButton.text = BData.GetString(!flag1 ? (!flag3 ? "UI0155" : "UI0156") : "UI0157");
      this.imgResearchFillPre.fillAmount = num3;
      this.imgResearchFill.fillAmount = num4;
      this.textResearchDetailDesc.text = string.Empty;
      if (research.listPre.Count != 0)
      {
        this.textResearchDetailDesc.text = BData.GetString("UI0162") + " : ";
        for (int index = 0; index < research.listPre.Count; ++index)
        {
          bool flag4 = Info.CheckResearch(research.listPre[index]);
          Text researchDetailDesc = this.textResearchDetailDesc;
          string str = researchDetailDesc.text + (flag4 ? "<" : "<color='red'><") + BData.GetString(BData.GetResearch(research.listPre[index]).strName) + (flag4 ? ">" : "></color>");
          researchDetailDesc.text = str;
          if (index < research.listPre.Count - 1)
            this.textResearchDetailDesc.text += ", ";
        }
        this.textResearchDetailDesc.text += "\n";
      }
      this.textResearchDetailDesc.text += BData.GetString(research.strDesc);
      if (!flag2)
        this.textResearchGuage.text = BData.GetString("UI0165");
      else if (flag1)
        this.textResearchGuage.text = BData.GetString("UI0158");
      else if (flag3 && !flag1)
      {
        this.textResearchGuage.text = BData.GetString("UI0156") + " : " + Info.currentSave.fResearchProgress.ToString("N0") + "/" + (object) Info.GetResearchCost(research.eID) + ", " + BData.GetString("UI0159").Replace("[1]", num5.ToString());
      }
      else
      {
        if (flag3 || flag1)
          return;
        this.textResearchGuage.text = BData.GetString("UI0160").Replace("[1]", num5.ToString());
      }
    }
  }

  public void OnCharUnitTab(int nPos)
  {
    UIMgr.PlaySound("Character", false);
    this.RefreshCharUnitInfo(nPos);
    this.RefreshHighlightCharTab();
  }

  public void OnCallHire()
  {
    UIMgr.AddPage("PopupHire");
  }

  public void OnUnitHire(PlayerMonsterData pData)
  {
    if (pData == null)
      return;
    if (!Info.CanHireMonster())
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.GetMsg().SetMsg(BData.GetString(Info.nMaxHire != 5 ? "UI0055" : "UI0056"), true, false, string.Empty);
    }
    else
    {
      int costHire = Info.GetCostHire(pData);
      if (this.nGold < (long) costHire)
      {
        UIMgr.NotEnoughGold();
      }
      else
      {
        UIMgr.PlaySound("Hire", false);
        this.nGold -= (long) costHire;
        int nPos = Info.HireMonster(pData);
        SavedData currentSave = Info.currentSave;
        string str = currentSave.strSummary + "\n" + BData.GetString("UI0066").Replace("[1]", BData.GetString(BData.GetMonster((short) pData.sID).strName));
        currentSave.strSummary = str;
        this.RefreshCharTab();
        this.RefreshCharUnitInfo(nPos);
        this.RefreshHighlightCharTab();
        Info.RefreshPartySkill();
      }
    }
  }

  public void OnDungeonBuild(DungeonType eID, int nNum = 1)
  {
    if (!Info.CanUpgDungeon(eID, 1) || !Info.UpgDungeon(eID, nNum))
      return;
    UIMgr.PlaySound("Hire", false);
    this.RefreshDungeon();
    this.nGold = this.nGold;
  }

  public void OnDungeonRepair()
  {
    int nRepairCost = Info.nRepairCost;
    if ((double) (float) Info.currentSave.fDunCurHP >= (double) (float) Info.fDunMaxHP)
      return;
    if (this.nGold < (long) nRepairCost)
    {
      if (this.nGold < (long) Info.nRepairCostOnePoint)
        UIMgr.NotEnoughGold();
      else
        UIMgr.popupMsg.SetYesNo("RepairPart", BData.GetString("UI0126"), false);
    }
    else
    {
      UIMgr.PlaySound("Hire", false);
      this.nGold -= (long) nRepairCost;
      Info.currentSave.fDunCurHP = Info.fDunMaxHP;
      SavedData currentSave = Info.currentSave;
      string str = currentSave.strSummary + "\n\n" + BData.GetString("UI0125").Replace("[1]", nRepairCost.ToString());
      currentSave.strSummary = str;
      this.RefreshAction();
    }
  }

  public void OnDungeonRepairPart()
  {
    int num1 = 0;
    int num2 = (int) ((double) (float) Info.fDunMaxHP - (double) (float) Info.currentSave.fDunCurHP);
    for (int index = 0; index < num2; ++index)
    {
      num1 = index;
      if (this.nGold < (long) ((index + 1) * Info.nRepairCostOnePoint))
        break;
    }
    int num3 = num1 * Info.nRepairCostOnePoint;
    UIMgr.PlaySound("Hire", false);
    this.nGold -= (long) num3;
    Info.currentSave.fDunCurHP = (ObscuredFloat) Mathf.Clamp((float) Info.currentSave.fDunCurHP + (float) num1, (float) Info.currentSave.fDunCurHP, (float) Info.fDunMaxHP);
    if ((double) (float) Info.fDunMaxHP - (double) (float) Info.currentSave.fDunCurHP < 1.0)
      Info.currentSave.fDunCurHP = Info.fDunMaxHP;
    SavedData currentSave = Info.currentSave;
    string str = currentSave.strSummary + "\n\n" + BData.GetString("UI0063").Replace("[1]", num3.ToString()).Replace("[2]", num1.ToString());
    currentSave.strSummary = str;
    this.RefreshAction();
  }

  public void OpenShop(int nNum)
  {
    UIMgr.PlaySound("DoorOpen", false);
    switch (nNum)
    {
      case 0:
        UIMgr.AddPage("PopupWeaponSelect");
        PopupWeaponSelect.obj.ShopMode();
        break;
      case 1:
        UIMgr.AddPage("PopupWeaponSelect");
        PopupWeaponSelect.obj.SellMode(true);
        break;
      case 2:
        UIMgr.AddPage("PopupWeaponSelect");
        PopupWeaponSelect.obj.ModifyMode();
        break;
      case 3:
        UIMgr.AddPage("PopupWeaponSelect");
        PopupWeaponSelect.obj.EnchantMode(-1L);
        break;
      case 4:
        UIMgr.AddPage("PopupAccSelect");
        PopupAccSelect.obj.AccEnchantMode();
        break;
      case 5:
        UIMgr.AddPage("PopupAccSelect");
        PopupAccSelect.obj.AccSellMode();
        break;
      case 6:
        UIMgr.AddPage("PopupAccBook");
        break;
    }
  }

  public void OnResearchSelected(ResearchElt elt)
  {
    Info.eSelectedResearch = elt.eID;
    this.RefreshDetailResearch(elt.eID);
    this.RefreshResearchHighlight();
  }

  public void OnSave()
  {
    UIMgr.PlaySound("MainButton", false);
    UIMgr.popupMsg.SetYesNo("LobbySave", BData.GetString("UI0123"), false);
  }

  public void OnOption()
  {
    UIMgr.CallOption();
  }

  public void RefreshAlarm()
  {
    this.goAcvAlarm.SetActive(Info.listCheck.Count > 0);
    this.goRscAlarm.SetActive((Info.currentSave.eResearch == ResearchID.eNone || Info.CheckResearch(Info.currentSave.eResearch)) && !this.bAllResearch);
  }

  public void OnAwaken()
  {
    UIMgr.PlaySound("MainButton", false);
    UIMgr.AddPage("PopupAwakening");
  }

  public void OnDismiss()
  {
    UIMgr.popupMsg.SetYesNo("Dismiss", BData.GetString("UI0121"), false);
  }

  public void CallBatch()
  {
    UIMgr.AddPage("PopupBatch");
  }

  public void AutoResearch(bool bForce = false)
  {
    if (!Info.option.bAutoResearch || Info.currentSave.eResearch != ResearchID.eNone && !Info.CheckResearch(Info.currentSave.eResearch) && !bForce)
      return;
    List<ResearchID> researchIdList = new List<ResearchID>();
    for (int index = 1; index < 59; ++index)
    {
      ResearchID eID = (ResearchID) index;
      if (!Info.CheckResearch(eID) && Info.LearnableResearch(eID))
        researchIdList.Add(eID);
    }
    if (researchIdList.Count == 0)
      return;
    Info.currentSave.eResearch = Info.eSelectedResearch = researchIdList[Random.Range(0, researchIdList.Count)];
    this.RefreshAlarm();
  }

  public void ResearchPlan()
  {
    if (!Info.option.bAutoResearch || Info.currentSave.eResearch != ResearchID.eNone && !Info.CheckResearch(Info.currentSave.eResearch) && (Info.currentSave.eResearch != ResearchID.eUnlimitedPower && Info.currentSave.eResearch != ResearchID.eUnlimitedShield))
      return;
    for (int index = 0; index < Info.option.listResearchOrder.Count; ++index)
    {
      if (!Info.CheckResearch(Info.option.listResearchOrder[index]))
      {
        Info.currentSave.eResearch = Info.option.listResearchOrder[index];
        this.RefreshAlarm();
        return;
      }
    }
    this.AutoResearch(false);
  }

  public void OnResearchStart()
  {
    if (Info.eSelectedResearch == ResearchID.eNone || Info.CheckResearch(Info.eSelectedResearch) || Info.eSelectedResearch == Info.currentSave.eResearch)
      return;
    UIMgr.PlaySound("Hire", false);
    Info.currentSave.eResearch = Info.eSelectedResearch;
    this.RefreshDetailResearch(Info.currentSave.eResearch);
    this.RefreshResearchProgress();
    this.RefreshAlarm();
  }

  public void OnRebirth()
  {
    UIMgr.PlaySound("MainButton", false);
    if ((int) Info.currentSave.nDay < 100)
      UIMgr.popupMsg.SetYesNo("100DayAgo", BData.GetString("UI0330"), true);
    else
      UIMgr.AddPage("PopupRebirthDiff");
  }

  public void OnCallRebirthShop()
  {
    UIMgr.AddPage("PopupRebirth");
  }

  public void OnCallMission()
  {
    UIMgr.AddPage("PopupMission");
  }

  public void OnAchievement()
  {
    if (!GPGSMgr.single.isLogin)
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetYesNo("LoginGoogle", BData.GetString("UI0198"), false);
    }
    else
    {
      GPGSMgr.single.CheckAchievementDayPass();
      GPGSMgr.single.CheckAchievementRebirth();
      GPGSMgr.single.ShowAchievement();
    }
  }

  public void OnLeaderBoard()
  {
    if (!GPGSMgr.single.isLogin)
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetYesNo("LoginGoogle", BData.GetString("UI0198"), false);
    }
    else
    {
      if (!Info.currentSave.bAfterRebirth)
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0207"), true, false, string.Empty);
      GPGSMgr.single.ReportLeaderBoard();
      GPGSMgr.single.ShowLeaderboardUI();
    }
  }

  public void OnCallCloudSave()
  {
    if (!GPGSMgr.single.isLogin)
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetYesNo("LoginGoogle", BData.GetString("UI0198"), false);
    }
    else
      GPGSMgr.single.ShowCloudData(true);
  }

  public void OnCallPromote()
  {
    UIMgr.PlaySound("MainButton", false);
    UIMgr.AddPage("PopupPromote");
  }

  public void OnCallMonTrait()
  {
    UIMgr.PlaySound("MainButton", false);
    UIMgr.AddPage("PopupMonsterTrait");
  }
}
