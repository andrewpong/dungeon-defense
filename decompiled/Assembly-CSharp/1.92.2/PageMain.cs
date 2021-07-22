// Decompiled with JetBrains decompiler
// Type: PageMain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PageMain : UIMgr
{
  private int nSelectedDiff = 1;
  private SavedData[] save = new SavedData[9];
  public static PageMain obj;
  public AudioSource _asMusic;
  public Transform trBG;
  public SpriteRenderer imgBG;
  public Text textGameTitle;
  public Text textGameSubTitle;
  public Text textNewGame;
  public Text textContinue;
  public Text textShop;
  public Text textOption;
  public Text textVersion;
  public Text textRestore;
  public GameObject goMainMenu;
  public GameObject goRestore;
  public int nAllStone;
  public int nAllRuby;
  public GameObject goCharSel;
  public Text textCharSelTitle;
  public Text textDetailDesc;
  public Text textCharDiffTitle;
  public Text textCharLock;
  public Text textCharSkill;
  public Text[] textCharDiff;
  public Image[] arrImgChar;
  public GameObject goCharLock;
  public GameObject btnCharArrowL;
  public GameObject btnCharArrowR;
  public GameObject[] arrCharCheckOff;
  public Button btnCharConfirm;
  public GameObject goSave;
  public Text textSaveTitle;
  public Text[] textSaveDesc;
  public Text[] textSaveNoData;
  public Text[] textSaveDiff;
  public Text[] textSaveNum;
  public Image[] imgSaveChar;
  public Image[] imgSaveHighlight;
  public GameObject goSaveArrowL;
  public GameObject goSaveArrowR;
  private int nCharSelPos;
  private List<short> listCharID;
  private int nSavePage;
  private bool bSave;

  protected override void Awake()
  {
    base.Awake();
    PageMain.obj = this;
    UIMgr.asMusic = this._asMusic;
    Info.bBattleFail = false;
    Purchaser.single.TryInitialize();
  }

  protected override void Start()
  {
    base.Start();
    this.textNewGame.text = BData.GetString("UI0136");
    this.textContinue.text = BData.GetString("UI0080");
    this.textOption.text = BData.GetString("UI0099");
    this.textShop.text = BData.GetString("UI0170");
    this.textGameTitle.text = BData.GetString("UI0134");
    this.textGameSubTitle.text = BData.GetString("UI0135");
    this.textCharDiffTitle.text = BData.GetString("UI0040");
    this.textCharSelTitle.text = BData.GetString("UI0137");
    this.textCharSkill.text = BData.GetString("UI0250");
    this.textRestore.text = BData.GetString("UI0335");
    this.goRestore.SetActive(false);
    for (int nDiff = 0; nDiff < this.textCharDiff.Length; ++nDiff)
      this.textCharDiff[nDiff].text = Info.GetDiffText(nDiff, true);
    this.textVersion.text = "Ver " + Application.version;
    Info.eBattle = BattleType.eSurvial;
    this.listCharID = new List<short>((IEnumerable<short>) BData.dictMonster.Keys);
    for (int index = 0; index < 9; ++index)
      this.save[index] = SaveManager.Load((byte) index);
    bool flag = false;
    for (int index = 0; index < 9; ++index)
    {
      if (this.save[index] != null)
      {
        if ((long) Info.rebirth.uRebirthID <= this.save[index].uRebirthID)
          Info.rebirth.uRebirthID = (ObscuredLong) (this.save[index].uRebirthID + 1L);
        Info.currentSave = this.save[index];
        if ((int) this.save[index].nClearTrial > 0)
        {
          this.save[index].nClearTrial = (ObscuredInt) 0;
          if (Info.rebirth.dictTrialClear.ContainsKey((ObscuredLong) this.save[index].uRebirthID))
            Info.rebirth.dictTrialClear[(ObscuredLong) this.save[index].uRebirthID] = (ObscuredInt) 0;
          SaveManager.Save((byte) index);
          flag = true;
        }
      }
    }
    if (!(bool) Info.rebirth.bPurchaseReward)
    {
      Info.rebirth.bPurchaseReward = (ObscuredBool) true;
      PlayerAccData newAcc = Info.GetNewAcc((short) 21);
      Info.rebirth.dictAcc.Add(newAcc.UID, newAcc);
      Info.listGetAcc.Add(newAcc);
      flag = true;
    }
    if (!(bool) Info.rebirth.bBefore1_5)
    {
      long nNewStone = (long) Info.rebirth.nNewStone;
      foreach (KeyValuePair<RebirthID, ObscuredInt> keyValuePair in Info.rebirth.dictRebirth)
      {
        for (int nLv = 0; nLv < (int) keyValuePair.Value; ++nLv)
          nNewStone += (long) Info.GetCostRebirth(keyValuePair.Key, nLv);
      }
      int num = Mathf.RoundToInt((float) nNewStone * 0.5f);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) num);
      rebirth.nNewStone = obscuredLong;
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0213").Replace("[1]", num.ToString()), true, false, string.Empty);
      Info.rebirth.bBefore1_5 = (ObscuredBool) true;
      flag = true;
    }
    if (!Info.rebirth.bAdjustHellStone)
    {
      Info.rebirth.bAdjustHellStone = true;
      foreach (KeyValuePair<ObscuredInt, Dictionary<ObscuredInt, ObscuredInt>> keyValuePair1 in Info.rebirth.dictHellQuest)
      {
        foreach (KeyValuePair<ObscuredInt, ObscuredInt> keyValuePair2 in keyValuePair1.Value)
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + (((int) keyValuePair1.Key - 5) * Info.nMulStone[(int) keyValuePair2.Key] - ((int) keyValuePair1.Key - 5)) * (int) keyValuePair2.Value);
          rebirth.nHell = obscuredInt;
        }
      }
      flag = true;
    }
    if ((long) Info.rebirth.nNewMedal < 0L)
      Info.rebirth.nNewMedal = (ObscuredLong) 0L;
    if (!Info.rebirth.bFixAppleHellStoneBug)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      Info.rebirth.bFixAppleHellStoneBug = true;
      flag = true;
      for (int index = 0; index < Info.rebirth.listPurchase.Count; ++index)
      {
        if (Info.rebirth.listPurchase[index] == ShopID.eHellF60)
          ++num1;
        else if (Info.rebirth.listPurchase[index] == ShopID.eHellF240)
          ++num2;
        else if (Info.rebirth.listPurchase[index] == ShopID.eHellF500)
          ++num3;
      }
      if (num1 > 1)
        num4 += (num1 - 1) * 60 - 6;
      if (num2 > 1)
        num4 += (num2 - 1) * 240 - 24;
      if (num3 > 1)
        num4 += (num3 - 1) * 500 - 50;
      if (num4 > 0)
      {
        if ((int) Info.rebirth.nHell >= num4)
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell - num4);
          rebirth.nHell = obscuredInt;
        }
        else
        {
          List<RebirthID> rebirthIdList = new List<RebirthID>();
          rebirthIdList.Add(RebirthID.eHugeWeapon);
          rebirthIdList.Add(RebirthID.eFireBall);
          rebirthIdList.Add(RebirthID.eFireLance);
          rebirthIdList.Add(RebirthID.eFrostBall);
          rebirthIdList.Add(RebirthID.eAssasinate);
          rebirthIdList.Add(RebirthID.eStrongKick);
          rebirthIdList.Add(RebirthID.ePenetratePower);
          rebirthIdList.Add(RebirthID.eMoonSlash);
          rebirthIdList.Add(RebirthID.eSoulBomb);
          rebirthIdList.Add(RebirthID.eSubLaser);
          rebirthIdList.Add(RebirthID.eChainLightning);
          rebirthIdList.Add(RebirthID.eMainCharDmg);
          rebirthIdList.Add(RebirthID.eMercenaryDmg);
          rebirthIdList.Add(RebirthID.eModLevel);
          rebirthIdList.Add(RebirthID.eDamageReduce);
          rebirthIdList.Add(RebirthID.ePreventModFail);
          rebirthIdList.Add(RebirthID.eItemEnchantPlus);
          rebirthIdList.Add(RebirthID.eEnchantManage);
          rebirthIdList.Add(RebirthID.eAIBuilder);
          rebirthIdList.Add(RebirthID.eQuickBattleOver);
          rebirthIdList.Add(RebirthID.eSuccubus);
          rebirthIdList.Add(RebirthID.eElementalBomb);
          for (int index1 = 0; index1 < rebirthIdList.Count; ++index1)
          {
            if (Info.rebirth.dictRebirth.ContainsKey(rebirthIdList[index1]))
            {
              int num5 = (int) Info.rebirth.dictRebirth[rebirthIdList[index1]];
              for (int index2 = 0; index2 < num5; ++index2)
              {
                SavedRebirth rebirth = Info.rebirth;
                ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + Info.GetCostRebirth(rebirthIdList[index1], num5 - 1 - index2));
                rebirth.nHell = obscuredInt;
              }
              Info.rebirth.dictRebirth.Remove(rebirthIdList[index1]);
            }
          }
          SavedRebirth rebirth1 = Info.rebirth;
          ObscuredInt obscuredInt1 = (ObscuredInt) ((int) rebirth1.nHell - num4);
          rebirth1.nHell = obscuredInt1;
        }
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0357"), true, false, string.Empty);
      }
    }
    if ((bool) Info.rebirth.bVIP)
    {
      Info.rebirth.bVIP = (ObscuredBool) false;
      flag = true;
    }
    if (flag)
      SaveManager.SaveRebirth();
    this.OnClick(-1);
    UIMgr.PlayMusic();
    if (Info.nNewStone > 0L || Info.nNewRuby > 0L)
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0196").Replace("[1]", Info.nNewStone.ToString()).Replace("[2]", Info.nNewRuby.ToString()), true, false, string.Empty);
      Info.nNewRuby = Info.nNewStone = 0L;
    }
    if (!Info.CheckRebirth(RebirthID.eDoubleSpeed))
      Info.option.bDoubleSpeed = false;
    if (!Info.CheckRebirth(RebirthID.eAutoBattle))
      Info.option.bAutoBattle = false;
    if (!Info.CheckRebirth(RebirthID.eWaveRush))
      Info.option.bFastSpawn = false;
    if (!Info.CheckRebirth(RebirthID.eAutoActiveSkill))
      Info.option.bAutoSkill = false;
    if (!Info.CheckRebirth(RebirthID.eAutoEnchant))
      Info.option.bAutoItemEnchant = false;
    if (!Info.CheckRebirth(RebirthID.eAutoItemSell))
      Info.option.bAutoItemSell = false;
    if (!Info.CheckRebirth(RebirthID.eAutoRepair))
      Info.option.bAutoRepair = false;
    if (!Info.CheckRebirth(RebirthID.eAutoResearch))
      Info.option.bAutoResearch = false;
    if (!Info.CheckRebirth(RebirthID.eAutoSkillSelect))
      Info.option.bAutoSkillSelect = false;
    if (!Info.CheckRebirth(RebirthID.eStoneStatMax))
      Info.option.bAutoBattleStart = false;
    if (!Info.CheckRebirth(RebirthID.eAIBuilder))
      Info.option.bAIBuild = false;
    if (!Info.CheckRebirth(RebirthID.eQuickBattleOver))
      Info.option.bQuickOver = false;
    if (Info.rebirth.listPurchase.Contains(ShopID.eAwakenPackage))
    {
      List<RebirthID> rebirthIdList = new List<RebirthID>();
      rebirthIdList.Add(RebirthID.eSoulAwk);
      rebirthIdList.Add(RebirthID.eBladeAwk);
      rebirthIdList.Add(RebirthID.eSuccubusAwk);
      rebirthIdList.Add(RebirthID.eFireAwk);
      rebirthIdList.Add(RebirthID.eWaterAwk);
      rebirthIdList.Add(RebirthID.eNatureAwk);
      rebirthIdList.Add(RebirthID.eLightAwk);
      rebirthIdList.Add(RebirthID.eDarkAwk);
      for (int index = 0; index < rebirthIdList.Count; ++index)
      {
        if (!Info.CheckRebirth(rebirthIdList[index]))
          Info.UpgRebirth(rebirthIdList[index], 1);
      }
    }
    Info.bTempQuitBattle = true;
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    if (this.goMainMenu.activeInHierarchy)
      UIMgr.popupMsg.SetYesNo("Quit", BData.GetString("UI0110") + "\n" + BData.GetString("UI0243"), false);
    else if (this.goCharSel.activeInHierarchy)
      this.OnBackFromCharSel();
    else
      this.OnBack();
  }

  public void OnClick(int n)
  {
    if (n != -1)
      UIMgr.PlaySound("MainButton", false);
    this.goSave.SetActive(n == 0 || n == 1);
    this.goCharSel.SetActive(n == 3);
    bool flag = false;
    switch (n)
    {
      case 0:
        this.trBG.position = new Vector3(0.0f, 3f);
        this.nSavePage = 0;
        this.RefreshSaveArrow();
        this.RefreshSaveData(true);
        break;
      case 1:
        this.nSavePage = 0;
        this.RefreshSaveArrow();
        this.RefreshSaveData(false);
        break;
      case 2:
        UIMgr.CallOption();
        flag = true;
        break;
      case 3:
        this.nSelectedDiff = 0;
        this.RefreshCharSel(0);
        this.RefreshDiffHighlight();
        break;
      default:
        this.trBG.position = new Vector3(0.0f, -0.4f);
        flag = true;
        break;
    }
    this.goMainMenu.SetActive(flag);
  }

  public void CallRebirthShop()
  {
    UIMgr.AddPage("PopupRebirth");
  }

  public void CallSkillShow()
  {
    UIMgr.AddPage("PopupMercenarySkill");
    PlayerMonsterData newPlayerMon = Info.GetNewPlayerMon(this.listCharID[this.nCharSelPos], false, false);
    PopupMercenarySkill.obj.ShowSkill(newPlayerMon);
  }

  private void RefreshCharSel(int nPos)
  {
    this.nCharSelPos = Mathf.Clamp(nPos, 0, this.listCharID.Count - 1);
    MonsterData monster1 = BData.GetMonster(this.listCharID[this.nCharSelPos]);
    bool flag = Info.achievement.listAcv.Count >= monster1.nNeedAcv && (monster1.eNeedRebirth == RebirthID.eNone || Info.CheckRebirth(monster1.eNeedRebirth));
    this.arrImgChar[2].sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster1.eAwaken) ? monster1.strSprite : monster1.strSpriteAwk);
    this.arrImgChar[2].color = !flag ? Color.grey : Color.white;
    this.textDetailDesc.text = BData.GetString("UI0007") + " : " + BData.GetString(monster1.strName) + "\n" + BData.GetString("UI0008") + " : " + BData.GetString(monster1.strClass) + "\n" + BData.GetString("UI0058") + " : " + BData.GetString(monster1.strDesc);
    this.goCharLock.SetActive(!flag);
    if (monster1.eNeedRebirth == RebirthID.eNone)
    {
      this.textCharLock.text = BData.GetString("UI0253").Replace("[1]", monster1.nNeedAcv.ToString());
    }
    else
    {
      switch (monster1.sID)
      {
        case 14:
          this.textCharLock.text = BData.GetString("UI0339");
          break;
        case 15:
        case 16:
        case 17:
        case 18:
        case 19:
          this.textCharLock.text = BData.GetString("UI0388");
          break;
        default:
          this.textCharLock.text = BData.GetString("UI0182");
          break;
      }
    }
    this.btnCharConfirm.interactable = flag;
    this.arrImgChar[0].gameObject.SetActive(this.nCharSelPos > 1);
    this.arrImgChar[1].gameObject.SetActive(this.nCharSelPos > 0);
    this.arrImgChar[3].gameObject.SetActive(this.nCharSelPos < this.listCharID.Count - 1);
    this.arrImgChar[4].gameObject.SetActive(this.nCharSelPos < this.listCharID.Count - 2);
    if (this.arrImgChar[0].gameObject.activeInHierarchy)
    {
      MonsterData monster2 = BData.GetMonster(this.listCharID[this.nCharSelPos - 2]);
      this.arrImgChar[0].sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster2.eAwaken) ? monster2.strSprite : monster2.strSpriteAwk);
    }
    if (this.arrImgChar[1].gameObject.activeInHierarchy)
    {
      MonsterData monster2 = BData.GetMonster(this.listCharID[this.nCharSelPos - 1]);
      this.arrImgChar[1].sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster2.eAwaken) ? monster2.strSprite : monster2.strSpriteAwk);
    }
    if (this.arrImgChar[3].gameObject.activeInHierarchy)
    {
      MonsterData monster2 = BData.GetMonster(this.listCharID[this.nCharSelPos + 1]);
      this.arrImgChar[3].sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster2.eAwaken) ? monster2.strSprite : monster2.strSpriteAwk);
    }
    if (this.arrImgChar[4].gameObject.activeInHierarchy)
    {
      MonsterData monster2 = BData.GetMonster(this.listCharID[this.nCharSelPos + 2]);
      this.arrImgChar[4].sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster2.eAwaken) ? monster2.strSprite : monster2.strSpriteAwk);
    }
    this.btnCharArrowL.SetActive(this.nCharSelPos > 0);
    this.btnCharArrowR.SetActive(this.nCharSelPos < this.listCharID.Count - 1);
  }

  public void RefreshSaveData(bool _bSave)
  {
    Info.byCurrentSaveSlot = (ObscuredByte) (byte) 10;
    this.bSave = _bSave;
    this.textSaveTitle.text = BData.GetString(!this.bSave ? "UI0080" : "UI0079");
    for (int index1 = 0; index1 < 3; ++index1)
    {
      int index2 = this.nSavePage * 3 + index1;
      this.imgSaveChar[index1].enabled = this.save[index2] != null;
      this.textSaveNum[index1].text = (index2 + 1).ToString();
      if (this.save[index2] == null)
      {
        this.textSaveNoData[index1].text = BData.GetString(!this.bSave ? "UI0077" : "UI0078");
        this.textSaveDesc[index1].text = string.Empty;
        this.textSaveDiff[index1].text = string.Empty;
      }
      else
      {
        this.textSaveNoData[index1].text = string.Empty;
        this.textSaveDiff[index1].text = Info.GetDiffText((int) this.save[index2].nDiff, false);
        this.textSaveDesc[index1].text = BData.GetString("UI0061").Replace("[1]", this.save[index2].nDay.ToString()) + "\n" + BData.GetString("UI0001") + " " + (object) this.save[index2].nNewGold + "G\n" + BData.GetString("UI0006") + " " + (object) this.save[index2].arrPlayerMon[0].nLv;
        MonsterData monster = BData.GetMonster((short) this.save[index2].arrPlayerMon[0].sID);
        this.imgSaveChar[index1].sprite = RSMgr.GetSprite((bool) this.save[index2].arrPlayerMon[0].bAwaken || Info.CheckRebirth(monster.eAwaken) ? monster.strSpriteAwk : monster.strSprite);
      }
    }
    this.RefreshSaveHighlight();
  }

  private void RefreshSaveHighlight()
  {
    for (int index = 0; index < 3; ++index)
      this.imgSaveHighlight[index].enabled = index == (int) (byte) Info.byCurrentSaveSlot - this.nSavePage * 3;
  }

  public void OnChooseSaveSlot(int nSlot)
  {
    Info.byCurrentSaveSlot = (ObscuredByte) ((byte) (nSlot + this.nSavePage * 3));
    if (this.bSave)
    {
      if (this.save[(int) (byte) Info.byCurrentSaveSlot] == null)
      {
        this.OnClick(3);
      }
      else
      {
        UIMgr.PlaySound("Negative", false);
        this.RefreshSaveHighlight();
        UIMgr.popupMsg.SetYesNo("overwrite", BData.GetString("UI0081"), true);
      }
    }
    else if (this.save[(int) (byte) Info.byCurrentSaveSlot] == null)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0082"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("CharSel", false);
      Info.currentSave = this.save[(int) (byte) Info.byCurrentSaveSlot];
      UIMgr.LoadLevel((int) Info.currentSave.nDay != 1 ? "Lobby" : "Battle", 1f, 1f, Color.black);
    }
  }

  public void OnCharSelMove(int n)
  {
    UIMgr.PlaySound("Character", false);
    this.RefreshCharSel(this.nCharSelPos + n);
  }

  public void OnBack()
  {
    UIMgr.PlaySound("Negative", false);
    this.OnClick(-1);
  }

  public void OnBackFromCharSel()
  {
    UIMgr.PlaySound("Negative", false);
    this.OnClick(0);
  }

  public void OnCharSelect()
  {
    Info.Rebirth(this.nSelectedDiff, this.nSelectedDiff, this.listCharID[this.nCharSelPos], (byte) Info.byCurrentSaveSlot, false, 1, -1L, new List<PlayerItemData>(), new List<short>(), 0, false);
  }

  public void OnDifficult(int nDiff)
  {
    UIMgr.PlaySound("Character", false);
    this.nSelectedDiff = nDiff;
    this.RefreshDiffHighlight();
  }

  public void RefreshDiffHighlight()
  {
    for (int index = 0; index < this.arrCharCheckOff.Length; ++index)
      this.arrCharCheckOff[index].SetActive(index == this.nSelectedDiff);
  }

  public void OnLanguage(int nLang)
  {
    Info.option.nLanguage = nLang;
    SaveManager.SaveOption();
    SceneManager.LoadScene("Main");
  }

  public void OnSavePage(int n)
  {
    this.nSavePage += n;
    this.RefreshSaveArrow();
    this.RefreshSaveData(this.bSave);
  }

  public void RefreshSaveArrow()
  {
    UIMgr.PlaySound("Character", false);
    this.goSaveArrowL.SetActive(this.nSavePage > 0);
    this.goSaveArrowR.SetActive(this.nSavePage < 2);
  }

  public void RestoreTransaction()
  {
  }
}
