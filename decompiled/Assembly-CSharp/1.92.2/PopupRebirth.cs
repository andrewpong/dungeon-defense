// Decompiled with JetBrains decompiler
// Type: PopupRebirth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupRebirth : UIPage
{
  private static int[] nCashBonus = new int[11]
  {
    120,
    120,
    140,
    180,
    260,
    10,
    10,
    20,
    40,
    80,
    400
  };
  public static PopupRebirth obj;
  public Text textTitle;
  public Text textStone;
  public GameObject[] goShopPanel;
  public Text[] textBotBtn;
  public Text[] textCharacterDesc;
  public Text[] textCharacterPrice;
  public Text[] textCharacterSkill;
  public Text[] textFeatureDesc;
  public Text[] textFeaturePrice;
  public Text[] textStatDesc;
  public Text[] textStatCount;
  public Text[] textStatPrice;
  public Text[] textShopCashDesc;
  public Text[] textShopCashPrice;
  public Text[] textShopCashBonus;
  public Text[] textShopBtnCharUnlock;
  public Text[] textShopBtnFeatureUnlock;
  public Text[] textShopBtnLevelUp;
  public Text[] textShopBtnLevelUp10;
  public Text[] textShopBtnPurchase;
  public Text[] textOnlyOnce;
  public Button[] btnCharacterPurchase;
  public Button[] btnFeaturePurchase;
  public Button[] btnStatPurchase;
  public Button[] btnStat10Purchase;
  public Button[] btnCashPurchase;
  public Image[] imgBtnHighlight;
  public Text textRefundWarn;
  public GameObject goRemoveAd;
  public GameObject goForbidden;
  public GameObject goExpensive;
  private bool bChange;

  public ObscuredLong nStone
  {
    get
    {
      return Info.rebirth.nNewStone;
    }
    set
    {
      Info.rebirth.nNewStone = value;
      this.textStone.text = value.ToString();
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PopupRebirth.obj = this;
    this.nStone = this.nStone;
    this.textTitle.text = BData.GetString("UI0170");
    this.textBotBtn[0].text = BData.GetString("UI0002");
    this.textBotBtn[1].text = BData.GetString("UI0176");
    this.textBotBtn[2].text = BData.GetString("UI0177");
    this.textBotBtn[3].text = BData.GetString("UI0178");
    this.textCharacterDesc[0].text = BData.GetString(BData.GetMonster((short) 9).strName) + ". " + BData.GetString(BData.GetRebirth(RebirthID.eMagicalGirl).strDesc);
    this.textCharacterDesc[1].text = BData.GetString(BData.GetMonster((short) 10).strName) + ". " + BData.GetString(BData.GetRebirth(RebirthID.eDarkKnight).strDesc);
    this.textCharacterDesc[2].text = BData.GetString(BData.GetMonster((short) 11).strName) + ". " + BData.GetString(BData.GetRebirth(RebirthID.eMonsterEye).strDesc);
    this.textCharacterDesc[3].text = BData.GetString(BData.GetMonster((short) 12).strName) + ". " + BData.GetString(BData.GetRebirth(RebirthID.eSoul).strDesc);
    this.textCharacterDesc[4].text = BData.GetString(BData.GetMonster((short) 13).strName) + ". " + BData.GetString(BData.GetRebirth(RebirthID.eBlade).strDesc);
    this.textCharacterPrice[0].text = BData.GetRebirth(RebirthID.eMagicalGirl).nCost.ToString();
    this.textCharacterPrice[1].text = BData.GetRebirth(RebirthID.eDarkKnight).nCost.ToString();
    this.textCharacterPrice[2].text = BData.GetRebirth(RebirthID.eMonsterEye).nCost.ToString();
    this.textCharacterPrice[3].text = BData.GetRebirth(RebirthID.eSoul).nCost.ToString();
    this.textCharacterPrice[4].text = BData.GetRebirth(RebirthID.eBlade).nCost.ToString();
    this.textFeatureDesc[0].text = BData.GetString(BData.GetRebirth(RebirthID.eDoubleSpeed).strDesc);
    this.textFeatureDesc[1].text = BData.GetString(BData.GetRebirth(RebirthID.eAutoBattle).strDesc);
    this.textFeatureDesc[2].text = BData.GetString(BData.GetRebirth(RebirthID.eWaveRush).strDesc);
    this.textFeaturePrice[0].text = BData.GetRebirth(RebirthID.eDoubleSpeed).nCost.ToString();
    this.textFeaturePrice[1].text = BData.GetRebirth(RebirthID.eAutoBattle).nCost.ToString();
    this.textFeaturePrice[2].text = BData.GetRebirth(RebirthID.eWaveRush).nCost.ToString();
    for (int index = 0; index < this.textShopBtnLevelUp.Length; ++index)
      this.textShopBtnLevelUp[index].text = BData.GetString("UI0071");
    for (int index = 0; index < this.textOnlyOnce.Length; ++index)
      this.textOnlyOnce[index].text = !BData.GetShop((ShopID) index).bOnly ? string.Empty : BData.GetString("UI0181");
    for (int index = 0; index < this.textCharacterSkill.Length; ++index)
      this.textCharacterSkill[index].text = BData.GetString("UI0250");
    this.goRemoveAd.SetActive(false);
    this.OnMoveMenu(2);
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((UnityEngine.Object) UIMgr.focused == (UnityEngine.Object) this))
      return;
    this.OnClose();
  }

  public void RefreshCharacter()
  {
    this.textShopBtnCharUnlock[0].text = !BData.GetRebirth(RebirthID.eMagicalGirl).bLock ? (!Info.CheckRebirth(RebirthID.eMagicalGirl) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnCharUnlock[1].text = !BData.GetRebirth(RebirthID.eDarkKnight).bLock ? (!Info.CheckRebirth(RebirthID.eDarkKnight) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnCharUnlock[2].text = !BData.GetRebirth(RebirthID.eMonsterEye).bLock ? (!Info.CheckRebirth(RebirthID.eMonsterEye) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnCharUnlock[3].text = !BData.GetRebirth(RebirthID.eSoul).bLock ? (!Info.CheckRebirth(RebirthID.eSoul) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnCharUnlock[4].text = !BData.GetRebirth(RebirthID.eBlade).bLock ? (!Info.CheckRebirth(RebirthID.eBlade) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.btnCharacterPurchase[0].interactable = !BData.GetRebirth(RebirthID.eMagicalGirl).bLock && !Info.CheckRebirth(RebirthID.eMagicalGirl);
    this.btnCharacterPurchase[1].interactable = !BData.GetRebirth(RebirthID.eDarkKnight).bLock && !Info.CheckRebirth(RebirthID.eDarkKnight);
    this.btnCharacterPurchase[2].interactable = !BData.GetRebirth(RebirthID.eMonsterEye).bLock && !Info.CheckRebirth(RebirthID.eMonsterEye);
    this.btnCharacterPurchase[3].interactable = !BData.GetRebirth(RebirthID.eSoul).bLock && !Info.CheckRebirth(RebirthID.eSoul);
    this.btnCharacterPurchase[4].interactable = !BData.GetRebirth(RebirthID.eBlade).bLock && !Info.CheckRebirth(RebirthID.eBlade);
  }

  public void RefreshFeature()
  {
    this.textShopBtnFeatureUnlock[0].text = !BData.GetRebirth(RebirthID.eDoubleSpeed).bLock ? (!Info.CheckRebirth(RebirthID.eDoubleSpeed) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnFeatureUnlock[1].text = !BData.GetRebirth(RebirthID.eAutoBattle).bLock ? (!Info.CheckRebirth(RebirthID.eAutoBattle) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnFeatureUnlock[2].text = !BData.GetRebirth(RebirthID.eWaveRush).bLock ? (!Info.CheckRebirth(RebirthID.eWaveRush) ? BData.GetString("UI0071") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.btnFeaturePurchase[0].interactable = !BData.GetRebirth(RebirthID.eDoubleSpeed).bLock && !Info.CheckRebirth(RebirthID.eDoubleSpeed);
    this.btnFeaturePurchase[1].interactable = !BData.GetRebirth(RebirthID.eAutoBattle).bLock && !Info.CheckRebirth(RebirthID.eAutoBattle);
    this.btnFeaturePurchase[2].interactable = !BData.GetRebirth(RebirthID.eWaveRush).bLock && !Info.CheckRebirth(RebirthID.eWaveRush);
  }

  public void RefreshAbility()
  {
    List<RebirthID> rebirthIdList = new List<RebirthID>();
    rebirthIdList.Add(RebirthID.eStartLevel);
    rebirthIdList.Add(RebirthID.eWeaponDmg);
    rebirthIdList.Add(RebirthID.eBossDmg);
    rebirthIdList.Add(RebirthID.eCriRate);
    rebirthIdList.Add(RebirthID.eCriDmg);
    rebirthIdList.Add(RebirthID.eMastery);
    rebirthIdList.Add(RebirthID.eAttackSpd);
    rebirthIdList.Add(RebirthID.eReloadSpd);
    rebirthIdList.Add(RebirthID.eRegen);
    rebirthIdList.Add(RebirthID.eResearch);
    rebirthIdList.Add(RebirthID.eEnchant);
    rebirthIdList.Add(RebirthID.eItemBag);
    rebirthIdList.Add(RebirthID.eStartGold);
    rebirthIdList.Add(RebirthID.eSellPrice);
    rebirthIdList.Add(RebirthID.eDunHp);
    rebirthIdList.Add(RebirthID.eMutationInhibit);
    rebirthIdList.Add(RebirthID.eItemQuality);
    rebirthIdList.Add(RebirthID.eRebirthDef);
    for (int index = 0; index < rebirthIdList.Count; ++index)
    {
      int rebirth1 = Info.GetRebirth(rebirthIdList[index]);
      RebirthData rebirth2 = BData.GetRebirth(rebirthIdList[index]);
      bool flag = rebirth1 >= rebirth2.nMax;
      int num = Mathf.Clamp(rebirth2.nMax - rebirth1, 0, 10);
      this.textStatDesc[index].text = BData.GetString(rebirth2.strDesc).Replace("[1]", Info.GetRebirthFac(rebirth2.eID).ToString("######0.##")).Replace("[2]", (Info.GetRebirthFac(rebirth2.eID, rebirth1 + 1) - Info.GetRebirthFac(rebirth2.eID)).ToString("N0"));
      this.btnStatPurchase[index].interactable = !rebirth2.bLock && !flag;
      this.btnStat10Purchase[index].interactable = !rebirth2.bLock && !flag;
      this.textShopBtnLevelUp[index].text = !flag ? "+1" : "+0";
      this.textShopBtnLevelUp10[index].text = "+" + num.ToString();
      this.textStatPrice[index].text = Info.GetCostRebirth(rebirth2.eID).ToString("N0");
      this.textStatPrice[index].rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.textStatPrice[index].preferredWidth + 8f);
      this.textStatCount[index].text = "( " + (object) rebirth1 + " / " + (object) rebirth2.nMax + " )";
      this.btnStatPurchase[index].interactable = !flag;
    }
  }

  public void OnMoveMenu(int n)
  {
    UIMgr.PlaySound("MainButton", false);
    for (int index = 0; index < this.goShopPanel.Length; ++index)
      this.goShopPanel[index].SetActive(index == n);
    this.RefreshPanel(n);
    this.RefreshHighlight(n);
  }

  private void RefreshPanel(int n)
  {
    switch (n)
    {
      case 0:
        this.RefreshCharacter();
        break;
      case 1:
        this.RefreshFeature();
        break;
      case 2:
        this.RefreshAbility();
        break;
      case 3:
        if (!Info.rebirth.bAttention)
        {
          UIMgr.popupMsg.SetMsg(BData.GetString("UI0172") + "\n" + BData.GetString("UI0173"), true, false, string.Empty);
          Info.rebirth.bAttention = true;
        }
        this.RefreshForbidden();
        break;
    }
  }

  private void RefreshMenu()
  {
    int n = 0;
    for (int index = 0; index < this.goShopPanel.Length; ++index)
    {
      if (this.goShopPanel[index].activeInHierarchy)
        n = index;
    }
    this.RefreshPanel(n);
  }

  private void RefreshHighlight(int n)
  {
    for (int index = 0; index < this.imgBtnHighlight.Length; ++index)
      this.imgBtnHighlight[index].gameObject.SetActive(index == n);
  }

  public void RefreshForbidden()
  {
    List<ShopID> shopIdList = new List<ShopID>();
    shopIdList.Add(ShopID.eFeaturePackage);
    shopIdList.Add(ShopID.eMagicalPackage);
    shopIdList.Add(ShopID.eTotalPackage);
    shopIdList.Add(ShopID.eFirst660);
    shopIdList.Add(ShopID.eFirst1100);
    shopIdList.Add(ShopID.eFirst2400);
    shopIdList.Add(ShopID.eFirst8400);
    shopIdList.Add(ShopID.eFirst18000);
    shopIdList.Add(ShopID.eRepeat330);
    shopIdList.Add(ShopID.eRepeat550);
    shopIdList.Add(ShopID.eRepeat1200);
    shopIdList.Add(ShopID.eRepeat4200);
    shopIdList.Add(ShopID.eRepeat9000);
    shopIdList.Add(ShopID.eRemoveAds);
    shopIdList.Add(ShopID.eElementalPackage);
    shopIdList.Add(ShopID.eFirst50000);
    shopIdList.Add(ShopID.eElementalExp);
    shopIdList.Add(ShopID.eRebirthPackage);
    shopIdList.Add(ShopID.eRebirthExp);
    this.goExpensive.SetActive(Info.rebirth.listPurchase.Contains(ShopID.eFirst50000));
    for (int index = 0; index < shopIdList.Count; ++index)
    {
      ShopData shop = BData.GetShop(shopIdList[index]);
      this.textShopCashDesc[index].text = BData.GetString(shop.strDesc);
      this.textShopCashPrice[index].text = Purchaser.single.GetProductPrice(shop.eID);
      this.textShopBtnPurchase[index].text = !shop.bOnly || !Info.CheckShop(shop.eID) ? BData.GetString("UI0071") : BData.GetString("UI0175");
      this.btnCashPurchase[index].interactable = (!shop.bOnly ? 0 : (Info.CheckShop(shop.eID) ? 1 : 0)) == 0;
    }
    for (int index = 0; index < this.textShopCashBonus.Length; ++index)
      this.textShopCashBonus[index].text = BData.GetString("UI0180") + " + " + PopupRebirth.nCashBonus[index].ToString() + " %";
  }

  public void OnClose()
  {
    UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
    if (this.bChange)
      Info.RefreshBattleItemData();
    if (!(bool) ((UnityEngine.Object) PageLobby.obj))
      return;
    Info.RefreshDungeonHP();
  }

  public void OnPurchase(string strID)
  {
    this.OnPurchase((RebirthID) Enum.Parse(typeof (RebirthID), strID));
  }

  public void OnPurchaseMul(string strID)
  {
    this.OnPurchaseMul((RebirthID) Enum.Parse(typeof (RebirthID), strID));
  }

  public void OnPurchaseCash(string strID)
  {
    this.OnPurchase((ShopID) Enum.Parse(typeof (ShopID), strID));
  }

  public void OnPurchase(RebirthID eID)
  {
    RebirthData rebirth1 = BData.GetRebirth(eID);
    int rebirth2 = Info.GetRebirth(eID);
    int costRebirth = Info.GetCostRebirth(eID);
    if (rebirth2 >= rebirth1.nMax)
      return;
    if ((long) this.nStone < (long) costRebirth)
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0174"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("Hire", false);
      PopupRebirth popupRebirth = this;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) popupRebirth.nStone - (long) costRebirth);
      popupRebirth.nStone = obscuredLong;
      Info.UpgRebirth(eID, 1);
      this.RefreshMenu();
      SaveManager.SaveRebirth();
      this.bChange = true;
    }
  }

  public void OnPurchaseMul(RebirthID eID)
  {
    RebirthData rebirth1 = BData.GetRebirth(eID);
    int rebirth2 = Info.GetRebirth(eID);
    if (rebirth2 >= rebirth1.nMax)
      return;
    int num = 0;
    int nPlus = 0;
    for (int index = 0; index < 10 && rebirth2 + nPlus < rebirth1.nMax; ++index)
    {
      num += Info.GetCostRebirth(eID, rebirth2 + nPlus);
      ++nPlus;
    }
    if ((long) this.nStone < (long) num)
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0174"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("Hire", false);
      PopupRebirth popupRebirth = this;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) popupRebirth.nStone - (long) num);
      popupRebirth.nStone = obscuredLong;
      Info.UpgRebirth(eID, nPlus);
      this.RefreshMenu();
      SaveManager.SaveRebirth();
      this.bChange = true;
    }
  }

  public void OnPurchase(ShopID eID)
  {
    ShopData shop = BData.GetShop(eID);
    if (Info.CheckShop(eID) && shop.bOnly)
      return;
    Purchaser.single.BuyProductByShopID(eID);
  }

  public void RefreshFromPurchase()
  {
    this.RefreshMenu();
    this.nStone = this.nStone;
  }

  public void CheckSkill(string strID)
  {
    short sID = -1;
    if (strID != null)
    {
      if (!(strID == "eMagicalGirl"))
      {
        if (!(strID == "eDarkKnight"))
        {
          if (!(strID == "eMonsterEye"))
          {
            if (!(strID == "eSoul"))
            {
              if (strID == "eBlade")
                sID = (short) 13;
            }
            else
              sID = (short) 12;
          }
          else
            sID = (short) 11;
        }
        else
          sID = (short) 10;
      }
      else
        sID = (short) 9;
    }
    if ((int) sID == -1)
      return;
    UIMgr.AddPage("PopupMercenarySkill");
    PlayerMonsterData newPlayerMon = Info.GetNewPlayerMon(sID, false, false);
    PopupMercenarySkill.obj.ShowSkill(newPlayerMon);
  }

  public void OnRubyStore()
  {
    UIMgr.PlaySound("Character", false);
    UIMgr.RemoveTop();
    if (this.bChange)
      Info.RefreshBattleItemData();
    if ((bool) ((UnityEngine.Object) PageLobby.obj))
      Info.RefreshDungeonHP();
    UIMgr.AddPage("PopupRubyShop");
  }
}
