// Decompiled with JetBrains decompiler
// Type: PopupHellStone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupHellStone : UIPage
{
  private int nDiff = 6;
  private int nMinDiff = 6;
  private int nMaxDiff = 15;
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
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int num5 = 0;
    int num6 = 0;
    int num7 = 0;
    for (int index = 0; index < Info.rebirth.listPurchase.Count; ++index)
    {
      if (Info.rebirth.listPurchase[index] == ShopID.eHellF60)
        ++num1;
      else if (Info.rebirth.listPurchase[index] == ShopID.eHellF240)
        ++num2;
      else if (Info.rebirth.listPurchase[index] == ShopID.eHellF500)
        ++num3;
      else if (Info.rebirth.listPurchase[index] == ShopID.eHellR30)
        ++num4;
      else if (Info.rebirth.listPurchase[index] == ShopID.eHellR120)
        ++num5;
      else if (Info.rebirth.listPurchase[index] == ShopID.eHellR250)
        ++num6;
      else if (Info.rebirth.listPurchase[index] == ShopID.eHellPackage)
        num7 -= 400;
      else if (Info.rebirth.listPurchase[index] == ShopID.eSuccubusPackage)
        num7 -= 800;
    }
    int num8 = num7 - (num1 * 60 - (num1 <= 1 ? 0 : 6)) - (num2 * 240 - (num2 <= 1 ? 0 : 24)) - (num3 * 500 - (num3 <= 1 ? 0 : 50)) - num4 * 30 - num5 * 120 - num6 * 250;
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
        int num9 = (int) Info.rebirth.dictRebirth[rebirthIdList[index1]];
        for (int index2 = 0; index2 < num9; ++index2)
          num8 += Info.GetCostRebirth(rebirthIdList[index1], num9 - 1 - index2);
      }
    }
    foreach (KeyValuePair<ObscuredInt, Dictionary<ObscuredInt, ObscuredInt>> keyValuePair1 in Info.rebirth.dictHellQuest)
    {
      foreach (KeyValuePair<ObscuredInt, ObscuredInt> keyValuePair2 in keyValuePair1.Value)
        num8 -= ((int) keyValuePair1.Key - 5) * Info.nMulStone[(int) keyValuePair2.Key] * (int) keyValuePair2.Value;
    }
    if ((int) Info.rebirth.nHell + num8 <= this.nSpendHellStone)
      return;
    Debug.LogError((object) ("VIP - " + (object) Info.rebirth.nHell + " / " + num8.ToString()));
    Info.rebirth.bVIP = (ObscuredBool) true;
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
