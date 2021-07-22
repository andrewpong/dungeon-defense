// Decompiled with JetBrains decompiler
// Type: PopupGameOver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PopupGameOver : UIPage
{
  public static PopupGameOver obj;
  public Image imgBack;
  public Text textTitle;
  public Text textLoad;
  public Text textMain;
  public Text textLower;
  public GameObject goLoad;
  public GameObject goLower;
  public GameObject goMain;

  protected override void Awake()
  {
    base.Awake();
    PopupGameOver.obj = this;
    this.textLoad.text = BData.GetString("UI0084");
    this.textMain.text = BData.GetString("UI0085");
    this.textLower.text = BData.GetString("UI0320");
    this.goLoad.SetActive(false);
    this.goMain.SetActive(false);
    this.goLower.SetActive(false);
  }

  protected override void Start()
  {
    base.Start();
    this.StartCoroutine(this.ShowButton());
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    UIMgr.LoadLevel("Main", 1f, 1f, Color.black);
  }

  [DebuggerHidden]
  private IEnumerator ShowButton()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PopupGameOver.\u003CShowButton\u003Ec__Iterator0()
    {
      \u0024this = this
    };
  }

  public void OnLoad()
  {
    if (Info.eBattle == BattleType.eSurvial)
    {
      float fAwakenCharge = (float) Info.currentSave.fAwakenCharge;
      float[] numArray = new float[Info.currentSave.arrPlayerMon.Length];
      for (int index = 0; index < 5; ++index)
      {
        numArray[index] = 0.0f;
        if (Info.currentSave.arrPlayerMon[index] != null)
          numArray[index] = (float) Info.currentSave.arrPlayerMon[index].fActive;
      }
      Info.currentSave = SaveManager.Load((byte) Info.byCurrentSaveSlot);
      for (int index = 0; index < 5; ++index)
      {
        if (Info.currentSave.arrPlayerMon[index] != null)
          Info.currentSave.arrPlayerMon[index].fActive = (ObscuredFloat) numArray[index];
      }
      Info.currentSave.fAwakenCharge = (ObscuredFloat) fAwakenCharge;
      SavedData currentSave = Info.currentSave;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave.nNewGold + (long) (int) Info.nBattleGold);
      currentSave.nNewGold = obscuredLong;
      Info.CalcExp(false);
      Info.currentSave.strSummary = "\n" + BData.GetString("UI0169").Replace("[1]", Info.nBattleGold.ToString()).Replace("[2]", Mathf.RoundToInt((float) (int) Info.nBattleExp * 0.2f).ToString());
      Info.nBattleGold = (ObscuredInt) 0;
      Info.nBattleExp = (ObscuredInt) 0;
    }
    UIMgr.LoadLevel("Lobby", 1f, 1f, Color.black);
  }

  public void OnLower()
  {
    UIMgr.popupMsg.SetYesNo("LowDifficult", BData.GetString("UI0321").Replace("[1]", Info.GetDiffText((int) Info.currentSave.nDiff, false)).Replace("[2]", Info.GetDiffText((int) Info.currentSave.nDiff - 1, false)), true);
  }

  public void OnLowRestart()
  {
    int nDiff = (int) Info.currentSave.nDiff;
    if (nDiff <= 2)
      return;
    Info.currentSave = SaveManager.Load((byte) Info.byCurrentSaveSlot);
    Info.currentSave.nDiff = (ObscuredInt) (nDiff - 1);
    UIMgr.LoadLevel("Battle", 1f, 1f, Color.black);
  }

  public void OnMain()
  {
    UIMgr.LoadLevel("Main", 1f, 1f, Color.black);
  }
}
