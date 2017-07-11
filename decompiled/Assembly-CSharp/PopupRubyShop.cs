// Decompiled with JetBrains decompiler
// Type: PopupRubyShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupRubyShop : UIPage
{
  private static int[] nCashBonus = new int[10]
  {
    100,
    100,
    120,
    140,
    180,
    0,
    0,
    10,
    20,
    40
  };
  public static PopupRubyShop obj;
  public Text textTitle;
  public Text textRuby;
  public GameObject[] goShopPanel;
  public Text[] textBotBtn;
  public Text[] textFeatureDesc;
  public Text[] textFeaturePrice;
  public Text[] textStatDesc;
  public Text[] textStatCount;
  public Text[] textStatPrice;
  public Text[] textShopCashDesc;
  public Text[] textShopCashPrice;
  public Text[] textShopCashBonus;
  public Text[] textShopBtnUnlock;
  public Text[] textShopBtnLevelUp;
  public Text[] textShopBtnPurchase;
  public Text[] textOnlyOnce;
  public Text[] textAwakenPrice;
  public Text[] textAwakenDesc;
  public Text[] textAwakenButton;
  public Button[] btnFeaturePurchase;
  public Button[] btnStatPurchase;
  public Button[] btnCashPurchase;
  public Button[] btnAwakenPurchase;
  public Image[] imgBtnHighlight;
  public GameObject goForbidden;
  private bool bChange;

  public ObscuredInt nRuby
  {
    get
    {
      return Info.rebirth.nRuby;
    }
    set
    {
      Info.rebirth.nRuby = value;
      this.textRuby.text = value.ToString();
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PopupRubyShop.obj = this;
    this.nRuby = this.nRuby;
    this.textTitle.text = BData.GetString("UI0278");
    this.textBotBtn[0].text = BData.GetString("UI0281");
    this.textBotBtn[1].text = BData.GetString("UI0176");
    this.textBotBtn[2].text = "?";
    this.textBotBtn[3].text = BData.GetString("UI0178");
    this.textFeatureDesc[0].text = BData.GetString(BData.GetRebirth(RebirthID.eStoneStatMax).strDesc);
    this.textFeatureDesc[1].text = BData.GetString(BData.GetRebirth(RebirthID.eAutoItemSell).strDesc);
    this.textFeatureDesc[2].text = BData.GetString(BData.GetRebirth(RebirthID.eAutoEnchant).strDesc);
    this.textFeatureDesc[3].text = BData.GetString(BData.GetRebirth(RebirthID.eAutoActiveSkill).strDesc);
    this.textFeatureDesc[4].text = BData.GetString(BData.GetRebirth(RebirthID.eAutoSkillSelect).strDesc);
    this.textFeatureDesc[5].text = BData.GetString(BData.GetRebirth(RebirthID.eAutoResearch).strDesc);
    this.textFeatureDesc[6].text = BData.GetString(BData.GetRebirth(RebirthID.eAutoRepair).strDesc);
    this.textFeatureDesc[7].text = BData.GetString(BData.GetRebirth(RebirthID.eRingUnlock).strDesc);
    this.textFeaturePrice[0].text = BData.GetRebirth(RebirthID.eStoneStatMax).nCost.ToString();
    this.textFeaturePrice[1].text = BData.GetRebirth(RebirthID.eAutoItemSell).nCost.ToString();
    this.textFeaturePrice[2].text = BData.GetRebirth(RebirthID.eAutoEnchant).nCost.ToString();
    this.textFeaturePrice[3].text = BData.GetRebirth(RebirthID.eAutoActiveSkill).nCost.ToString();
    this.textFeaturePrice[4].text = BData.GetRebirth(RebirthID.eAutoSkillSelect).nCost.ToString();
    this.textFeaturePrice[5].text = BData.GetRebirth(RebirthID.eAutoResearch).nCost.ToString();
    this.textFeaturePrice[6].text = BData.GetRebirth(RebirthID.eAutoRepair).nCost.ToString();
    this.textFeaturePrice[7].text = BData.GetRebirth(RebirthID.eRingUnlock).nCost.ToString();
    for (int index = 0; index < this.textShopBtnLevelUp.Length; ++index)
      this.textShopBtnLevelUp[index].text = BData.GetString("UI0071");
    for (int index = 0; index < this.textOnlyOnce.Length; ++index)
      this.textOnlyOnce[index].text = BData.GetString("UI0181");
    this.OnMoveMenu(0);
  }

  public void RefreshFeature()
  {
    this.textShopBtnUnlock[0].text = !BData.GetRebirth(RebirthID.eStoneStatMax).bLock ? (!Info.CheckRebirth(RebirthID.eStoneStatMax) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnUnlock[1].text = !BData.GetRebirth(RebirthID.eAutoItemSell).bLock ? (!Info.CheckRebirth(RebirthID.eAutoItemSell) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnUnlock[2].text = !BData.GetRebirth(RebirthID.eAutoEnchant).bLock ? (!Info.CheckRebirth(RebirthID.eAutoEnchant) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnUnlock[3].text = !BData.GetRebirth(RebirthID.eAutoActiveSkill).bLock ? (!Info.CheckRebirth(RebirthID.eAutoActiveSkill) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnUnlock[4].text = !BData.GetRebirth(RebirthID.eAutoSkillSelect).bLock ? (!Info.CheckRebirth(RebirthID.eAutoSkillSelect) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnUnlock[5].text = !BData.GetRebirth(RebirthID.eAutoResearch).bLock ? (!Info.CheckRebirth(RebirthID.eAutoResearch) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnUnlock[6].text = !BData.GetRebirth(RebirthID.eAutoRepair).bLock ? (!Info.CheckRebirth(RebirthID.eAutoRepair) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.textShopBtnUnlock[7].text = !BData.GetRebirth(RebirthID.eRingUnlock).bLock ? (!Info.CheckRebirth(RebirthID.eRingUnlock) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
    this.btnFeaturePurchase[0].interactable = !BData.GetRebirth(RebirthID.eStoneStatMax).bLock && !Info.CheckRebirth(RebirthID.eStoneStatMax);
    this.btnFeaturePurchase[1].interactable = !BData.GetRebirth(RebirthID.eAutoItemSell).bLock && !Info.CheckRebirth(RebirthID.eAutoItemSell);
    this.btnFeaturePurchase[2].interactable = !BData.GetRebirth(RebirthID.eAutoEnchant).bLock && !Info.CheckRebirth(RebirthID.eAutoEnchant);
    this.btnFeaturePurchase[3].interactable = !BData.GetRebirth(RebirthID.eAutoActiveSkill).bLock && !Info.CheckRebirth(RebirthID.eAutoActiveSkill);
    this.btnFeaturePurchase[4].interactable = !BData.GetRebirth(RebirthID.eAutoSkillSelect).bLock && !Info.CheckRebirth(RebirthID.eAutoSkillSelect);
    this.btnFeaturePurchase[5].interactable = !BData.GetRebirth(RebirthID.eAutoResearch).bLock && !Info.CheckRebirth(RebirthID.eAutoResearch);
    this.btnFeaturePurchase[6].interactable = !BData.GetRebirth(RebirthID.eAutoRepair).bLock && !Info.CheckRebirth(RebirthID.eAutoRepair);
    this.btnFeaturePurchase[7].interactable = !BData.GetRebirth(RebirthID.eRingUnlock).bLock && !Info.CheckRebirth(RebirthID.eRingUnlock);
  }

  public void RefreshSupporter()
  {
    List<RebirthID> rebirthIdList = new List<RebirthID>();
    rebirthIdList.Add(RebirthID.eInheritor);
    rebirthIdList.Add(RebirthID.eGuardian);
    rebirthIdList.Add(RebirthID.eManager);
    rebirthIdList.Add(RebirthID.eInheritLevel);
    rebirthIdList.Add(RebirthID.eRubyCharDmg);
    rebirthIdList.Add(RebirthID.eRubyBossDmg);
    for (int index = 0; index < rebirthIdList.Count; ++index)
    {
      int rebirth1 = Info.GetRebirth(rebirthIdList[index]);
      RebirthData rebirth2 = BData.GetRebirth(rebirthIdList[index]);
      bool flag = rebirth1 >= rebirth2.nMax;
      this.textStatDesc[index].text = BData.GetString(rebirth2.strDesc).Replace("[1]", Info.GetRebirthFac(rebirth2.eID).ToString("######0.##")).Replace("[2]", (Info.GetRebirthFac(rebirth2.eID, rebirth1 + 1) - Info.GetRebirthFac(rebirth2.eID)).ToString("N0"));
      this.btnStatPurchase[index].interactable = !rebirth2.bLock && !flag;
      this.textStatPrice[index].text = Info.GetCostRebirth(rebirth2.eID).ToString("N0");
      this.textStatPrice[index].rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.textStatPrice[index].preferredWidth + 8f);
      this.textStatCount[index].text = "( " + (object) rebirth1 + " / " + (object) rebirth2.nMax + " )";
      this.btnStatPurchase[index].interactable = !flag;
    }
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((UnityEngine.Object) UIMgr.focused == (UnityEngine.Object) this))
      return;
    this.OnClose();
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
        this.RefreshSupporter();
        break;
      case 1:
        this.RefreshFeature();
        break;
      case 2:
        this.RefreshAwaken();
        break;
      case 3:
        if (!Info.rebirth.bAttentionRuby)
        {
          UIMgr.popupMsg.SetMsg(BData.GetString("UI0172") + "\n" + BData.GetString("UI0279").Replace("[1]", BData.GetString("UI0268")), true, false, string.Empty);
          Info.rebirth.bAttentionRuby = true;
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
    shopIdList.Add(ShopID.eAutoPackage);
    shopIdList.Add(ShopID.eRingPackage);
    shopIdList.Add(ShopID.eRubyF180);
    shopIdList.Add(ShopID.eRubyF300);
    shopIdList.Add(ShopID.eRubyF660);
    shopIdList.Add(ShopID.eRubyF2160);
    shopIdList.Add(ShopID.eRubyF4200);
    shopIdList.Add(ShopID.eRubyR90);
    shopIdList.Add(ShopID.eRubyR150);
    shopIdList.Add(ShopID.eRubyR330);
    shopIdList.Add(ShopID.eRubyR1080);
    shopIdList.Add(ShopID.eRubyR2100);
    shopIdList.Add(ShopID.eAwakenPackage);
    for (int index = 0; index < this.btnCashPurchase.Length; ++index)
    {
      ShopData shop = BData.GetShop(shopIdList[index]);
      this.textShopCashDesc[index].text = BData.GetString(shop.strDesc);
      this.textShopCashPrice[index].text = Purchaser.single.GetProductPrice(shop.eID);
      this.textShopBtnPurchase[index].text = !shop.bOnly || !Info.CheckShop(shop.eID) ? BData.GetString("UI0071") : BData.GetString("UI0175");
      this.btnCashPurchase[index].interactable = (!shop.bOnly ? 0 : (Info.CheckShop(shop.eID) ? 1 : 0)) == 0;
    }
    for (int index = 0; index < this.textShopCashBonus.Length; ++index)
      this.textShopCashBonus[index].text = PopupRubyShop.nCashBonus[index] <= 0 ? string.Empty : BData.GetString("UI0180") + " + " + PopupRubyShop.nCashBonus[index].ToString() + " %";
  }

  public void RefreshAwaken()
  {
    List<RebirthID> rebirthIdList = new List<RebirthID>();
    rebirthIdList.Add(RebirthID.eSkeletonAwk);
    rebirthIdList.Add(RebirthID.eGoblinAwk);
    rebirthIdList.Add(RebirthID.eOgreAwk);
    rebirthIdList.Add(RebirthID.eOrcAwk);
    rebirthIdList.Add(RebirthID.eSlimeAwk);
    rebirthIdList.Add(RebirthID.eWraithAwk);
    rebirthIdList.Add(RebirthID.eSnakeAwk);
    rebirthIdList.Add(RebirthID.eSwordAwk);
    rebirthIdList.Add(RebirthID.eSummonerAwk);
    rebirthIdList.Add(RebirthID.eMagicalGirlAwk);
    rebirthIdList.Add(RebirthID.eDarkKnightAwk);
    rebirthIdList.Add(RebirthID.eEyeAwk);
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
      RebirthData rebirth = BData.GetRebirth(rebirthIdList[index]);
      this.textAwakenDesc[index].text = BData.GetString(rebirth.strDesc).Replace("[1]", BData.GetString(BData.GetMonster((short) index).strName));
      this.textAwakenButton[index].text = !Info.CheckRebirth(rebirth.eID) ? BData.GetString("UI0171") : BData.GetString("UI0175");
      this.textAwakenPrice[index].text = Info.GetCostRebirth(rebirth.eID).ToString("N0");
      this.btnAwakenPurchase[index].interactable = !Info.CheckRebirth(rebirth.eID);
    }
  }

  public void OnClose()
  {
    UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
    if (!this.bChange)
      return;
    Info.RefreshBattleItemData();
  }

  public void OnPurchase(string strID)
  {
    this.OnPurchase((RebirthID) Enum.Parse(typeof (RebirthID), strID));
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
    if ((int) this.nRuby < costRebirth)
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0280"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("Hire", false);
      PopupRubyShop popupRubyShop = this;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) popupRubyShop.nRuby - costRebirth);
      popupRubyShop.nRuby = obscuredInt;
      Info.UpgRebirth(eID, 1);
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
    this.nRuby = this.nRuby;
  }

  public void OnHellStore()
  {
    UIMgr.PlaySound("Character", false);
    UIMgr.RemoveTop();
    UIMgr.AddPage("PopupHellShop");
  }
}
