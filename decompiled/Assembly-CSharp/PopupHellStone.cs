// Decompiled with JetBrains decompiler
// Type: PopupHellStone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class PopupHellStone : UIPage
{
  private int nDiff = 6;
  private int nMinDiff = 6;
  private int nMaxDiff = 20;
  public Text textHellShop;
  public Text textTitle;
  public Text textWarning;
  public Text[] textQuestTitle;
  public Text[] textQuestProgress;
  public Text[] textQuestReward;
  public Text[] textQuestComplete;
  public Image[] imgQuestFill;
  public Button[] btnQuestComplete;
  public int nSpendHellStone;
  private bool bChanged;

  protected override void Awake()
  {
    base.Awake();
    this.textHellShop.text = BData.GetString("UI0339");
    this.textWarning.text = BData.GetString("UI0340");
    this.nDiff = Mathf.Clamp((int) Info.currentSave.nDiff, this.nMinDiff, this.nMaxDiff);
    for (int index = 0; index < this.textQuestComplete.Length; ++index)
      this.textQuestComplete[index].text = BData.GetString("UI0157");
    this.RefreshQuest();
  }

  private void RefreshQuest()
  {
    this.textTitle.text = Info.GetDiffText(this.nDiff, false);
    for (int nNum = 0; nNum < this.textQuestTitle.Length; ++nNum)
    {
      int nDay = (nNum + 1) * 100;
      int clearHellStone = Info.GetClearHellStone(this.nDiff, nNum);
      int num = Mathf.Min(5, clearHellStone / 2 + 1);
      int rebirthTime = Info.GetRebirthTime(this.nDiff, nDay);
      this.textQuestTitle[nNum].text = BData.GetString("UI0352").Replace("[1]", this.textTitle.text).Replace("[2]", nDay.ToString()).Replace("[3]", num.ToString());
      for (int index = 0; index < clearHellStone; ++index)
        rebirthTime -= Mathf.Min(5, index / 2 + 1);
      bool flag = rebirthTime >= num;
      this.textQuestReward[nNum].text = ((this.nDiff - 5) * Info.nMulStone[nNum]).ToString();
      this.imgQuestFill[nNum].fillAmount = (float) rebirthTime / (float) num;
      this.textQuestProgress[nNum].text = rebirthTime.ToString() + " / " + num.ToString();
      this.btnQuestComplete[nNum].interactable = flag;
    }
  }

  public void OnComplete(int nNum)
  {
    int clearHellStone = Info.GetClearHellStone(this.nDiff, nNum);
    int num = Mathf.Min(5, clearHellStone / 2 + 1);
    int rebirthTime = Info.GetRebirthTime(this.nDiff, (nNum + 1) * 100);
    for (int index = 0; index < clearHellStone; ++index)
      rebirthTime -= Mathf.Min(5, index / 2 + 1);
    if (rebirthTime < num)
      return;
    Info.AddClearHellStone(this.nDiff, nNum);
    SavedRebirth rebirth = Info.rebirth;
    ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + (this.nDiff - 5) * Info.nMulStone[nNum]);
    rebirth.nHell = obscuredInt;
    UIMgr.PlaySound("Hire", false);
    this.bChanged = true;
    this.RefreshQuest();
  }

  public void OnMoveDiff(int nMove)
  {
    this.nDiff += nMove;
    if (this.nDiff < this.nMinDiff)
      this.nDiff = this.nMaxDiff;
    if (this.nDiff > this.nMaxDiff)
      this.nDiff = this.nMinDiff;
    this.RefreshQuest();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void OnHellStore()
  {
    this.OnClose();
    UIMgr.AddPage("PopupHellShop");
  }

  public void OnClose()
  {
    UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
    if (!this.bChanged)
      return;
    SaveManager.SaveRebirth();
  }
}
