// Decompiled with JetBrains decompiler
// Type: PopupEndlessBrief
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class PopupEndlessBrief : UIPage
{
  public Text textTitle;
  public Text textDescTop;
  public Text textDesc;
  public Text textRubyTop;
  public Text textRubyNum;
  public Text textWaveTop;
  public Text textWaveNum;
  public Text textBestTop;
  public Text textBestNum;
  public Text textBtnRubyShop;
  public Text textStartFirst;
  public Text textStartContinue;
  public Button btnStartFirst;
  public Button btnStartContinue;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0268");
    this.textDescTop.text = BData.GetString("UI0058");
    this.textDesc.text = BData.GetString("UI0269") + (!Info.currentSave.bAfterEndless ? " " + BData.GetString("UI0275") : string.Empty);
    this.textRubyTop.text = BData.GetString("UI0270");
    this.textWaveTop.text = BData.GetString("UI0271");
    this.textBestTop.text = BData.GetString("UI0272");
    this.textBtnRubyShop.text = BData.GetString("UI0278");
    this.textRubyNum.text = Info.nTodayRuby.ToString();
    int continueWave = Info.GetContinueWave((int) Info.currentSave.nMaxEndless);
    this.textWaveNum.text = Mathf.Max(1, Info.GetContinueWave((int) Info.currentSave.nMaxEndless)).ToString();
    this.textBestNum.text = Info.currentSave.nMaxEndless.ToString();
    this.btnStartContinue.interactable = continueWave > 1;
    this.textStartFirst.text = BData.GetString("UI0140") + "\n<size='40'>( Wave 1 )</size>";
    this.textStartContinue.text = BData.GetString("UI0140") + "\n<size='40'>( Wave " + continueWave.ToString() + " )</size>";
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
  }

  public void OnStartFirst()
  {
    if (Info.currentSave.bChallengeEndless)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0224").Replace("[1]", BData.GetString("UI0268")), true, false, string.Empty);
    }
    else
    {
      Info.eBattle = BattleType.eEndless;
      if ((int) Info.currentSave.nDay < 1000)
        Info.currentSave.bChallengeEndless = true;
      Info.nStartEndless = (ObscuredInt) 1;
      UIMgr.PlaySound("BattleBegin", false);
      UIMgr.LoadLevel("Battle", 2f, 1f, Color.black);
    }
  }

  public void OnContinue()
  {
    if (Info.currentSave.bChallengeEndless)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0224").Replace("[1]", BData.GetString("UI0268")), true, false, string.Empty);
    }
    else
    {
      Info.eBattle = BattleType.eEndless;
      if ((int) Info.currentSave.nDay < 1000)
        Info.currentSave.bChallengeEndless = true;
      Info.nStartEndless = (ObscuredInt) Mathf.Max(1, Info.GetContinueWave((int) Info.currentSave.nMaxEndless));
      UIMgr.PlaySound("BattleBegin", false);
      UIMgr.LoadLevel("Battle", 2f, 1f, Color.black);
    }
  }

  public void OnCallRubyShop()
  {
    UIMgr.AddPage("PopupRubyShop");
  }
}
