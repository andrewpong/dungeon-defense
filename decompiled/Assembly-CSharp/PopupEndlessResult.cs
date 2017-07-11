// Decompiled with JetBrains decompiler
// Type: PopupEndlessResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;
using UnityEngine.UI;

public class PopupEndlessResult : UIPage
{
  public Text textTitle;
  public Text textRubyTop;
  public Text textRubyNum;
  public Text textWaveTop;
  public Text textWaveNum;
  public Text textBestTop;
  public Text textBestNum;
  public Text textBtnConfirm;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0277");
    this.textRubyTop.text = BData.GetString("UI0270");
    this.textWaveTop.text = BData.GetString("UI0274");
    this.textBestTop.text = BData.GetString("UI0272");
    if ((int) Info.wave.nCurrentWave > (int) Info.currentSave.nMaxEndless)
      Info.currentSave.nMaxEndless = Info.wave.nCurrentWave;
    this.textRubyNum.text = Info.nTodayRuby.ToString();
    this.textWaveNum.text = Info.wave.nCurrentWave.ToString();
    this.textBestNum.text = Info.currentSave.nMaxEndless.ToString();
    this.textBtnConfirm.text = BData.GetString("UI0095");
    UIMgr.PlaySound("Win", false);
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnConfirm();
  }

  public void OnConfirm()
  {
    UIMgr.PlaySound("MainButton", false);
    UIMgr.RemoveTop();
    UIMgr.LoadLevel("Lobby", 1.5f, 1f, Color.black);
  }
}
