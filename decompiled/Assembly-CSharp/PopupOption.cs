// Decompiled with JetBrains decompiler
// Type: PopupOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class PopupOption : UIPage
{
  public static PopupOption obj;
  public GameObject goBtnA;
  public GameObject goBtnB;
  public GameObject goBtnC;
  public Text textTitle;
  public Text textBtnA;
  public Text textBtnB;
  public Text textBtnC;
  public Text textMusic;
  public Text textSound;
  public Text textAuto;
  public Text textDouble;
  public Text textFast;
  public Text textHompage;
  public Text textAutoLogin;
  public Text textCloudSave;
  public Text textCloudLoad;
  public Text textOptimize;
  public Text textLeftSkill;
  public Text textWarning;
  public Text textCriOff;
  public Text textHideDamage;
  public Text textAutoBattleBegin;
  public Text textAutoSpecialSkill;
  public Text textAutoSkillSelect;
  public Text textAutoItemEnchant;
  public Text textAutoItemSell;
  public Text textAutoResearch;
  public Text textAutoDungeonRepair;
  public Text textAutoItemManage;
  public Text textAIBuild;
  public Text textAIQuickOver;
  public Text textAllFXOff;
  public Button btnHompage;
  public GameObject[] goOptionLock;
  public GameObject[] goOptionOff;
  public GameObject[] goOptionOn;
  public GameObject goCloud;
  public GameObject goOptionAutoLogin;
  public GameObject goOptionAutoItemManage;
  public GameObject goOptionPowerSaveOn;
  public GameObject goOptionLeftSkill;
  public GameObject goOptionCriOff;
  public GameObject goOptionHideDamage;
  public GameObject goEngGuide;
  public GameObject goAutoGoogle;
  public GameObject goMuteMusic;
  public GameObject goMuteSound;
  public GameObject goOptionAIBuild;
  public GameObject goLockAIBuild;
  public GameObject goOptionQuickOver;
  public GameObject goLockQuickOver;
  public GameObject goOptionAllFXOff;
  private PopupOption.Mode eType;
  private bool bChanged;

  protected override void Awake()
  {
    base.Awake();
    PopupOption.obj = this;
    this.eType = !((Object) PageLobby.obj != (Object) null) ? (!((Object) PageBattle.obj != (Object) null) ? PopupOption.Mode.eMain : PopupOption.Mode.eBattle) : PopupOption.Mode.eLobby;
    this.textTitle.text = BData.GetString("UI0099");
    this.RefreshMusic();
    this.RefreshSound();
    this.textDouble.text = BData.GetString("UI0187");
    this.textAuto.text = BData.GetString("UI0188");
    this.textFast.text = BData.GetString("UI0189");
    this.textHompage.text = BData.GetString("UI0190");
    this.textAutoLogin.text = BData.GetString("UI0203");
    this.textCloudSave.text = BData.GetString("UI0204");
    this.textCloudLoad.text = BData.GetString("UI0205");
    this.textOptimize.text = BData.GetString("UI0209");
    this.textLeftSkill.text = BData.GetString("UI0210");
    this.textWarning.text = BData.GetString("UI0172") + "\n" + BData.GetString("UI0211");
    this.textCriOff.text = BData.GetString("UI0212");
    this.textAllFXOff.text = BData.GetString("UI0389");
    this.textHideDamage.text = BData.GetString("UI0248");
    this.textAutoBattleBegin.text = BData.GetString("UI0255");
    this.textAutoSpecialSkill.text = BData.GetString("UI0256");
    this.textAutoSkillSelect.text = BData.GetString("UI0257");
    this.textAutoItemEnchant.text = BData.GetString("UI0258");
    this.textAutoItemSell.text = BData.GetString("UI0259");
    this.textAutoResearch.text = BData.GetString("UI0260");
    this.textAutoDungeonRepair.text = BData.GetString("UI0261");
    this.textAutoItemManage.text = BData.GetString("UI0290");
    this.textAIBuild.text = BData.GetString("UI0353");
    this.textAIQuickOver.text = BData.GetString("UI0354");
    this.goEngGuide.SetActive(Info.option.nLanguage == 1);
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
    this.goOptionOff[0].SetActive(Info.CheckRebirth(RebirthID.eDoubleSpeed));
    this.goOptionOn[0].SetActive(Info.option.bDoubleSpeed);
    this.goOptionLock[0].SetActive(!Info.CheckRebirth(RebirthID.eDoubleSpeed));
    this.goOptionOff[1].SetActive(Info.CheckRebirth(RebirthID.eAutoBattle));
    this.goOptionOn[1].SetActive(Info.option.bAutoBattle);
    this.goOptionLock[1].SetActive(!Info.CheckRebirth(RebirthID.eAutoBattle));
    this.goOptionOff[2].SetActive(Info.CheckRebirth(RebirthID.eWaveRush));
    this.goOptionOn[2].SetActive(Info.option.bFastSpawn);
    this.goOptionLock[2].SetActive(!Info.CheckRebirth(RebirthID.eWaveRush));
    this.goOptionOff[3].SetActive(Info.CheckRebirth(RebirthID.eStoneStatMax));
    this.goOptionOn[3].SetActive(Info.option.bAutoBattleStart);
    this.goOptionLock[3].SetActive(!Info.CheckRebirth(RebirthID.eStoneStatMax));
    this.goOptionOff[4].SetActive(Info.CheckRebirth(RebirthID.eAutoActiveSkill));
    this.goOptionOn[4].SetActive(Info.option.bAutoSkill);
    this.goOptionLock[4].SetActive(!Info.CheckRebirth(RebirthID.eAutoActiveSkill));
    this.goOptionOff[5].SetActive(Info.CheckRebirth(RebirthID.eAutoSkillSelect));
    this.goOptionOn[5].SetActive(Info.option.bAutoSkillSelect);
    this.goOptionLock[5].SetActive(!Info.CheckRebirth(RebirthID.eAutoSkillSelect));
    this.goOptionOff[6].SetActive(Info.CheckRebirth(RebirthID.eAutoEnchant));
    this.goOptionOn[6].SetActive(Info.option.bAutoItemEnchant);
    this.goOptionLock[6].SetActive(!Info.CheckRebirth(RebirthID.eAutoEnchant));
    this.goOptionOff[7].SetActive(Info.CheckRebirth(RebirthID.eAutoItemSell));
    this.goOptionOn[7].SetActive(Info.option.bAutoItemSell);
    this.goOptionLock[7].SetActive(!Info.CheckRebirth(RebirthID.eAutoItemSell));
    this.goOptionOff[8].SetActive(Info.CheckRebirth(RebirthID.eAutoResearch));
    this.goOptionOn[8].SetActive(Info.option.bAutoResearch);
    this.goOptionLock[8].SetActive(!Info.CheckRebirth(RebirthID.eAutoResearch));
    this.goOptionOff[9].SetActive(Info.CheckRebirth(RebirthID.eAutoRepair));
    this.goOptionOn[9].SetActive(Info.option.bAutoRepair);
    this.goOptionLock[9].SetActive(!Info.CheckRebirth(RebirthID.eAutoRepair));
    this.goOptionAutoItemManage.SetActive(Info.option.bAutoItemManage);
    this.goOptionAutoLogin.SetActive(Info.option.bAutoLogin);
    this.goOptionPowerSaveOn.SetActive(Info.option.bOptimize);
    this.goOptionLeftSkill.SetActive(Info.option.bLeftSpecial);
    this.goOptionCriOff.SetActive(Info.option.bCriFlashOff);
    this.goOptionHideDamage.SetActive(Info.option.bHideDamageOutput);
    this.goOptionAIBuild.SetActive(Info.option.bAIBuild);
    this.goOptionQuickOver.SetActive(Info.option.bQuickOver);
    this.goOptionAllFXOff.SetActive(Info.option.bAllFXOff);
    this.goLockAIBuild.SetActive(!Info.CheckRebirth(RebirthID.eAIBuilder));
    this.goLockQuickOver.SetActive(!Info.CheckRebirth(RebirthID.eQuickBattleOver));
    this.RefreshButton();
    UIMgr.StopMusic();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  private void RefreshButton()
  {
    this.goBtnA.SetActive(this.eType != PopupOption.Mode.eMain);
    this.goBtnB.SetActive(this.eType != PopupOption.Mode.eMain);
    this.goBtnC.SetActive(this.eType == PopupOption.Mode.eMain);
    this.goCloud.SetActive(this.eType != PopupOption.Mode.eBattle);
    this.btnHompage.interactable = this.eType != PopupOption.Mode.eBattle;
    switch (this.eType)
    {
      case PopupOption.Mode.eMain:
        this.textBtnC.text = BData.GetString("UI0107");
        break;
      case PopupOption.Mode.eBattle:
        Time.timeScale = 0.0f;
        this.textBtnA.text = BData.GetString("UI0104");
        this.textBtnB.text = BData.GetString("UI0105");
        break;
      case PopupOption.Mode.eLobby:
        this.textBtnA.text = BData.GetString("UI0104");
        this.textBtnB.text = BData.GetString("UI0106");
        break;
    }
  }

  public void SetMuteMusic()
  {
    Info.option.bMuteMusic = !Info.option.bMuteMusic;
    this.RefreshMusic();
    this.bChanged = true;
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
  }

  public void SetMusic(int n)
  {
    Info.option.fMusic = Mathf.Clamp(Info.option.fMusic + 0.05f * (float) n, 0.0f, 1f);
    if ((double) Info.option.fMusic > 0.0)
      Info.option.bMuteMusic = false;
    if ((double) Info.option.fMusic <= 0.0)
      Info.option.bMuteMusic = true;
    this.RefreshMusic();
    if (n == 0)
      return;
    this.bChanged = true;
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
  }

  private void RefreshMusic()
  {
    this.textMusic.text = (!Info.option.bMuteMusic ? Info.option.fMusic : 0.0f).ToString("P0");
    this.goMuteMusic.SetActive(Info.option.bMuteMusic);
  }

  public void SetMuteSound()
  {
    Info.option.bMuteSound = !Info.option.bMuteSound;
    this.RefreshSound();
    this.bChanged = true;
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
  }

  public void SetSound(int n)
  {
    Info.option.fSound = Mathf.Clamp(Info.option.fSound + 0.05f * (float) n, 0.0f, 1f);
    if ((double) Info.option.fMusic > 0.0)
      Info.option.bMuteSound = false;
    if ((double) Info.option.fMusic <= 0.0)
      Info.option.bMuteSound = true;
    this.RefreshSound();
    if (n == 0)
      return;
    this.bChanged = true;
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
  }

  private void RefreshSound()
  {
    this.textSound.text = (!Info.option.bMuteSound ? Info.option.fSound : 0.0f).ToString("P0");
    this.goMuteSound.SetActive(Info.option.bMuteSound);
  }

  public void OnButtonA()
  {
    UIMgr.PlaySound("MainButton", true);
    switch (this.eType)
    {
      case PopupOption.Mode.eBattle:
      case PopupOption.Mode.eLobby:
        this.OnClose();
        break;
    }
  }

  public void OnButtonB()
  {
    UIMgr.PlaySound("MainButton", true);
    if (this.bChanged)
      SaveManager.SaveOption();
    switch (this.eType)
    {
      case PopupOption.Mode.eBattle:
        UIMgr.popupMsg.SetYesNo("BattleQuit", BData.GetString("UI0108"), false);
        break;
      case PopupOption.Mode.eLobby:
        UIMgr.popupMsg.SetYesNo("LobbyQuit", BData.GetString("UI0109"), false);
        break;
    }
  }

  public void OnButtonC()
  {
    UIMgr.PlaySound("MainButton", true);
    switch (this.eType)
    {
      case PopupOption.Mode.eMain:
        if (this.bChanged)
          SaveManager.SaveOption();
        UIMgr.popupMsg.SetYesNo("Quit", BData.GetString("UI0110") + "\n" + BData.GetString("UI0243"), false);
        break;
    }
  }

  public void OnClose()
  {
    UIMgr.PlaySound("Negative", false);
    switch (this.eType)
    {
      case PopupOption.Mode.eBattle:
        PageBattle.obj.OnResume();
        break;
      case PopupOption.Mode.eLobby:
        if ((bool) ((Object) PageLobby.obj))
        {
          if ((int) Info.option.byAutoResearchType == 0)
          {
            PageLobby.obj.AutoResearch(false);
            break;
          }
          PageLobby.obj.ResearchPlan();
          break;
        }
        break;
    }
    if (this.bChanged)
      SaveManager.SaveOption();
    UIMgr.RemoveTop();
    UIMgr.PlayMusic();
  }

  public void ToggleDoubleSpeed()
  {
    if (!Info.CheckRebirth(RebirthID.eDoubleSpeed))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0191"), true, false, string.Empty);
      Info.option.bDoubleSpeed = false;
    }
    else
      Info.option.bDoubleSpeed = !Info.option.bDoubleSpeed;
    UIMgr.PlaySound(!Info.option.bDoubleSpeed ? "Negative" : "MainButton", true);
    this.goOptionOn[0].SetActive(Info.option.bDoubleSpeed);
    this.bChanged = true;
  }

  public void ToggleAutoBattle()
  {
    if (!Info.CheckRebirth(RebirthID.eAutoBattle))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0191"), true, false, string.Empty);
      Info.option.bAutoBattle = false;
    }
    else
      Info.option.bAutoBattle = !Info.option.bAutoBattle;
    UIMgr.PlaySound(!Info.option.bAutoBattle ? "Negative" : "MainButton", true);
    this.goOptionOn[1].SetActive(Info.option.bAutoBattle);
    this.bChanged = true;
  }

  public void ToggleFastSpawn()
  {
    if (!Info.CheckRebirth(RebirthID.eWaveRush))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0191"), true, false, string.Empty);
      Info.option.bFastSpawn = false;
    }
    else
      Info.option.bFastSpawn = !Info.option.bFastSpawn;
    UIMgr.PlaySound(!Info.option.bFastSpawn ? "Negative" : "MainButton", true);
    this.goOptionOn[2].SetActive(Info.option.bFastSpawn);
    this.bChanged = true;
  }

  public void ToggleAutoLogin()
  {
    Info.option.bAutoLogin = !Info.option.bAutoLogin;
    this.goOptionAutoLogin.SetActive(Info.option.bAutoLogin);
    UIMgr.PlaySound(!Info.option.bAutoLogin ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAllFXOff()
  {
    Info.option.bAllFXOff = !Info.option.bAllFXOff;
    this.goOptionAllFXOff.SetActive(Info.option.bAllFXOff);
    UIMgr.PlaySound(!Info.option.bAllFXOff ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleOptimize()
  {
    Info.option.bOptimize = !Info.option.bOptimize;
    this.goOptionPowerSaveOn.SetActive(Info.option.bOptimize);
    UIMgr.PlaySound(!Info.option.bOptimize ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleLeftSkill()
  {
    Info.option.bLeftSpecial = !Info.option.bLeftSpecial;
    this.goOptionLeftSkill.SetActive(Info.option.bLeftSpecial);
    UIMgr.PlaySound(!Info.option.bLeftSpecial ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleCriOff()
  {
    Info.option.bCriFlashOff = !Info.option.bCriFlashOff;
    this.goOptionCriOff.SetActive(Info.option.bCriFlashOff);
    UIMgr.PlaySound(!Info.option.bCriFlashOff ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleHideDamage()
  {
    Info.option.bHideDamageOutput = !Info.option.bHideDamageOutput;
    this.goOptionHideDamage.SetActive(Info.option.bHideDamageOutput);
    UIMgr.PlaySound(!Info.option.bHideDamageOutput ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAutoBattleStart()
  {
    if (!Info.CheckRebirth(RebirthID.eStoneStatMax))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
      Info.option.bAutoBattleStart = false;
    }
    else
      Info.option.bAutoBattleStart = !Info.option.bAutoBattleStart;
    this.goOptionOn[3].SetActive(Info.option.bAutoBattleStart);
    UIMgr.PlaySound(!Info.option.bAutoBattleStart ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAutoActiveSkill()
  {
    if (!Info.CheckRebirth(RebirthID.eAutoActiveSkill))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
      Info.option.bAutoSkill = false;
    }
    else
      Info.option.bAutoSkill = !Info.option.bAutoSkill;
    this.goOptionOn[4].SetActive(Info.option.bAutoSkill);
    UIMgr.PlaySound(!Info.option.bAutoSkill ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAutoSkillSelect()
  {
    if (!Info.CheckRebirth(RebirthID.eAutoSkillSelect))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
      Info.option.bAutoSkillSelect = false;
    }
    else
      Info.option.bAutoSkillSelect = !Info.option.bAutoSkillSelect;
    this.goOptionOn[5].SetActive(Info.option.bAutoSkillSelect);
    UIMgr.PlaySound(!Info.option.bAutoSkillSelect ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAutoItemEnchant()
  {
    if (!Info.CheckRebirth(RebirthID.eAutoEnchant))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
      Info.option.bAutoItemEnchant = false;
    }
    else
      Info.option.bAutoItemEnchant = !Info.option.bAutoItemEnchant;
    if (Info.option.bAutoItemEnchant)
    {
      UIMgr.AddPage("PopupTypeSelect");
      PopupTypeSelect.obj.EnchantType();
    }
    this.goOptionOn[6].SetActive(Info.option.bAutoItemEnchant);
    UIMgr.PlaySound(!Info.option.bAutoItemEnchant ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAutoItemSell()
  {
    if (!Info.CheckRebirth(RebirthID.eAutoItemSell))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
      Info.option.bAutoItemSell = false;
    }
    else
      Info.option.bAutoItemSell = !Info.option.bAutoItemSell;
    if (Info.option.bAutoItemSell)
    {
      UIMgr.AddPage("PopupTypeSelect");
      PopupTypeSelect.obj.ItemSellType();
    }
    this.goOptionOn[7].SetActive(Info.option.bAutoItemSell);
    UIMgr.PlaySound(!Info.option.bAutoItemSell ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAutoResearch()
  {
    if (!Info.CheckRebirth(RebirthID.eAutoResearch))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
      Info.option.bAutoResearch = false;
    }
    else
    {
      Info.option.bAutoResearch = !Info.option.bAutoResearch;
      if (Info.option.bAutoResearch)
      {
        UIMgr.AddPage("PopupTypeSelect");
        PopupTypeSelect.obj.ResearchType();
      }
    }
    this.goOptionOn[8].SetActive(Info.option.bAutoResearch);
    UIMgr.PlaySound(!Info.option.bAutoResearch ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAutoDungeonRepair()
  {
    if (!Info.CheckRebirth(RebirthID.eAutoRepair))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
      Info.option.bAutoRepair = false;
    }
    else
      Info.option.bAutoRepair = !Info.option.bAutoRepair;
    this.goOptionOn[9].SetActive(Info.option.bAutoRepair);
    UIMgr.PlaySound(!Info.option.bAutoRepair ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void TryAutoItemManagement()
  {
    if (Info.option.bAutoItemManage)
    {
      this.ToggleAutoItemManagement();
    }
    else
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetYesNo("ToggleItemManage", BData.GetString("UI0291"), true);
    }
  }

  public void ToggleAutoItemManagement()
  {
    Info.option.bAutoItemManage = !Info.option.bAutoItemManage;
    this.goOptionAutoItemManage.SetActive(Info.option.bAutoItemManage);
    UIMgr.PlaySound(!Info.option.bAutoItemManage ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleAIBuilder()
  {
    if (!Info.CheckRebirth(RebirthID.eAIBuilder))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0355"), true, false, string.Empty);
      Info.option.bAIBuild = false;
    }
    else
    {
      Info.option.bAIBuild = !Info.option.bAIBuild;
      if (Info.option.bAIBuild)
        UIMgr.AddPage("PopupBuildOrder");
    }
    this.goOptionAIBuild.SetActive(Info.option.bAIBuild);
    UIMgr.PlaySound(!Info.option.bAIBuild ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void ToggleQuickOver()
  {
    if (!Info.CheckRebirth(RebirthID.eQuickBattleOver))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0355"), true, false, string.Empty);
      Info.option.bQuickOver = false;
    }
    else
      Info.option.bQuickOver = !Info.option.bQuickOver;
    this.goOptionQuickOver.SetActive(Info.option.bQuickOver);
    UIMgr.PlaySound(!Info.option.bQuickOver ? "Negative" : "MainButton", true);
    this.bChanged = true;
  }

  public void OnHomapage()
  {
    if (Info.option.nLanguage == 0)
      Application.OpenURL("http://cafe.naver.com/gamecoaster");
    else
      Application.OpenURL("https://www.facebook.com/GameCoaster/");
  }

  public void OnCloudSave()
  {
    if (this.eType != PopupOption.Mode.eMain && this.eType != PopupOption.Mode.eLobby)
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0208"), true, false, string.Empty);
    }
    else if (!GPGSMgr.single.isLogin)
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetYesNo("LoginGoogle", BData.GetString("UI0198"), false);
    }
    else
      GPGSMgr.single.ShowCloudData(true);
  }

  public void OnCloudLoad()
  {
    if (this.eType != PopupOption.Mode.eMain && this.eType != PopupOption.Mode.eLobby)
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0208"), true, false, string.Empty);
    }
    else if (!GPGSMgr.single.isLogin)
    {
      UIMgr.PlaySound("Negative", true);
      UIMgr.popupMsg.SetYesNo("LoginGoogle", BData.GetString("UI0198"), false);
    }
    else
      UIMgr.popupMsg.SetYesNo("CloudLoad", BData.GetString("UI0390"), true);
  }

  public void OnOpenEngGuide()
  {
    Application.OpenURL("http://dungeondefense.gamepedia.com/Dungeon_Defense_Wiki");
  }

  public enum Mode
  {
    eMain,
    eLobby,
    eBattle,
  }
}
