// Decompiled with JetBrains decompiler
// Type: PopupHellShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupHellShop : UIPage
{
  private static int[] nCashBonus = new int[6]
  {
    100,
    166,
    232,
    0,
    33,
    66
  };
  public static PopupHellShop obj;
  public Text textTitle;
  public Text textHell;
  public Text textRuby;
  public GameObject[] goShopPanel;
  public Text[] textBotBtn;
  public Text[] textStatDesc;
  public Text[] textStatCount;
  public Text[] textStatPrice;
  public Text[] textStatButton;
  public Text[] textFeatureDesc;
  public Text[] textFeaturePrice;
  public Text[] textFeatureButton;
  public Text[] textCharacterDesc;
  public Text[] textCharacterPrice;
  public Text[] textCharacterButton;
  public Text[] textCharacterSkill;
  public Text[] textShopCashDesc;
  public Text[] textShopCashPrice;
  public Text[] textShopCashBonus;
  public Text[] textShopBtnPurchase;
  public Text[] textOnlyOnce;
  public Button[] btnStatPurchase;
  public Button[] btnFeaturePurchase;
  public Button[] btnCharacterPurchase;
  public Button[] btnCashPurchase;
  public Image[] imgBtnHighlight;
  public GameObject goForbidden;
  public Text textInitCount;
  public GameObject goInitRuby;
  public Text textInitButton;
  public Button btnInit;
  public int nMaxInitCount;
  private bool bChange;

  public ObscuredInt nHell
  {
    get
    {
      return Info.rebirth.nHell;
    }
    set
    {
      Info.rebirth.nHell = value;
      this.textHell.text = value.ToString();
    }
  }

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

  private int nInitRubyCost
  {
    get
    {
      if ((int) Info.rebirth.nInitHellStone < this.nMaxInitCount)
        return 0;
      return Mathf.Min(1000 + ((int) Info.rebirth.nInitHellStone - this.nMaxInitCount) * 100, 10000);
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PopupHellShop.obj = this;
    this.nHell = this.nHell;
    this.nRuby = this.nRuby;
    this.textTitle.text = BData.GetString("UI0339");
    this.textBotBtn[0].text = BData.GetString("UI0177");
    this.textBotBtn[1].text = BData.GetString("UI0176");
    this.textBotBtn[2].text = BData.GetString("UI0002");
    this.textBotBtn[3].text = BData.GetString("UI0178");
    for (int index = 0; index < this.textOnlyOnce.Length; ++index)
      this.textOnlyOnce[index].text = BData.GetString("UI0181");
    for (int index = 0; index < this.textCharacterSkill.Length; ++index)
      this.textCharacterSkill[index].text = BData.GetString("UI0250");
    this.OnMoveMenu(0);
  }

  public void RefreshFeature()
  {
    List<RebirthID> rebirthIdList = new List<RebirthID>();
    rebirthIdList.Add(RebirthID.ePreventModFail);
    rebirthIdList.Add(RebirthID.eItemEnchantPlus);
    rebirthIdList.Add(RebirthID.eEnchantManage);
    rebirthIdList.Add(RebirthID.eAIBuilder);
    rebirthIdList.Add(RebirthID.eQuickBattleOver);
    for (int index = 0; index < rebirthIdList.Count; ++index)
    {
      RebirthData rebirth = BData.GetRebirth(rebirthIdList[index]);
      this.textFeatureDesc[index].text = BData.GetString(rebirth.strDesc);
      this.textFeaturePrice[index].text = rebirth.nCost.ToString();
      this.textFeatureButton[index].text = !rebirth.bLock ? (!Info.CheckRebirth(rebirthIdList[index]) ? BData.GetString("UI0171") : BData.GetString("UI0175")) : BData.GetString("UI0179");
      this.btnFeaturePurchase[index].interactable = !rebirth.bLock && !Info.CheckRebirth(rebirthIdList[index]);
    }
  }

  public void RefreshStat()
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
    rebirthIdList.Add(RebirthID.eElementalBomb);
    for (int index = 0; index < rebirthIdList.Count; ++index)
    {
      int rebirth1 = Info.GetRebirth(rebirthIdList[index]);
      RebirthData rebirth2 = BData.GetRebirth(rebirthIdList[index]);
      bool flag = rebirth1 >= rebirth2.nMax;
      this.textStatDesc[index].text = BData.GetString(rebirth2.strDesc).Replace("[1]", Info.GetRebirthFac(rebirth2.eID).ToString("######0.##"));
      if (!flag)
      {
        Text text = this.textStatDesc[index];
        string str = text.text + "\n(+" + (Info.GetRebirthFac(rebirth2.eID, rebirth1 + 1) - Info.GetRebirthFac(rebirth2.eID)).ToString("N0") + ")";
        text.text = str;
      }
      this.btnStatPurchase[index].interactable = !rebirth2.bLock && !flag;
      this.textStatPrice[index].text = Info.GetCostRebirth(rebirth2.eID).ToString("N0");
      this.textStatCount[index].text = "( " + (object) rebirth1 + " / " + (object) rebirth2.nMax + " )";
      this.btnStatPurchase[index].interactable = !flag;
      this.textStatButton[index].text = !flag ? BData.GetString("UI0071") : BData.GetString("UI0032");
    }
    this.textInitButton.text = BData.GetString("UI0383");
    if ((int) Info.rebirth.nInitHellStone < this.nMaxInitCount)
    {
      this.textInitCount.text = (this.nMaxInitCount - (int) Info.rebirth.nInitHellStone).ToString() + " / " + (object) this.nMaxInitCount;
    }
    else
    {
      this.textInitCount.text = this.nInitRubyCost.ToString();
      this.textInitCount.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.textInitCount.preferredWidth);
    }
    this.goInitRuby.SetActive((int) Info.rebirth.nInitHellStone >= this.nMaxInitCount);
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
        this.RefreshStat();
        break;
      case 1:
        this.RefreshFeature();
        break;
      case 2:
        this.RefreshChar();
        break;
      case 3:
        if (!Info.rebirth.bAttentionHell)
        {
          UIMgr.popupMsg.SetMsg(BData.GetString("UI0172") + "\n" + BData.GetString("UI0340"), true, false, string.Empty);
          Info.rebirth.bAttentionHell = true;
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
    shopIdList.Add(ShopID.eHellPackage);
    shopIdList.Add(ShopID.eSuccubusPackage);
    shopIdList.Add(ShopID.eHellF60);
    shopIdList.Add(ShopID.eHellF240);
    shopIdList.Add(ShopID.eHellF500);
    shopIdList.Add(ShopID.eHellR30);
    shopIdList.Add(ShopID.eHellR120);
    shopIdList.Add(ShopID.eHellR250);
    for (int index = 0; index < this.btnCashPurchase.Length; ++index)
    {
      ShopData shop = BData.GetShop(shopIdList[index]);
      this.textShopCashDesc[index].text = BData.GetString(shop.strDesc);
      this.textShopCashPrice[index].text = Purchaser.single.GetProductPrice(shop.eID);
      this.textShopBtnPurchase[index].text = !shop.bOnly || !Info.CheckShop(shop.eID) ? BData.GetString("UI0071") : BData.GetString("UI0175");
      this.btnCashPurchase[index].interactable = (!shop.bOnly ? 0 : (Info.CheckShop(shop.eID) ? 1 : 0)) == 0;
    }
    for (int index = 0; index < this.textShopCashBonus.Length; ++index)
      this.textShopCashBonus[index].text = PopupHellShop.nCashBonus[index] <= 0 ? string.Empty : BData.GetString("UI0180") + " + " + PopupHellShop.nCashBonus[index].ToString() + " %";
  }

  public void RefreshChar()
  {
    List<RebirthID> rebirthIdList = new List<RebirthID>();
    rebirthIdList.Add(RebirthID.eSuccubus);
    for (int index = 0; index < rebirthIdList.Count; ++index)
    {
      RebirthData rebirth = BData.GetRebirth(rebirthIdList[index]);
      this.textCharacterDesc[index].text = BData.GetString(rebirth.strDesc).Replace("[1]", BData.GetString(BData.GetMonster((short) index).strName));
      this.textCharacterButton[index].text = !Info.CheckRebirth(rebirth.eID) ? BData.GetString("UI0171") : BData.GetString("UI0175");
      this.textCharacterPrice[index].text = Info.GetCostRebirth(rebirth.eID).ToString("N0");
      this.btnCharacterPurchase[index].interactable = !Info.CheckRebirth(rebirth.eID);
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

  public void OnPayment(string strID)
  {
    this.OnPayment((ShopID) Enum.Parse(typeof (ShopID), strID));
  }

  public void OnPurchase(RebirthID eID)
  {
    RebirthData rebirth1 = BData.GetRebirth(eID);
    int rebirth2 = Info.GetRebirth(eID);
    int costRebirth = Info.GetCostRebirth(eID);
    if (rebirth2 >= rebirth1.nMax)
      return;
    if ((int) this.nHell < costRebirth)
    {
      UIMgr.NotEnoughHellStone();
    }
    else
    {
      UIMgr.PlaySound("Hire", false);
      PopupHellShop popupHellShop = this;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) popupHellShop.nHell - costRebirth);
      popupHellShop.nHell = obscuredInt;
      Info.UpgRebirth(eID, 1);
      this.RefreshMenu();
      SaveManager.SaveRebirth();
      this.bChange = true;
    }
  }

  public void OnPayment(ShopID eID)
  {
    ShopData shop = BData.GetShop(eID);
    if (Info.CheckShop(eID) && shop.bOnly)
      return;
    Purchaser.single.BuyProductByShopID(eID);
  }

  public void RefreshFromPurchase()
  {
    this.RefreshMenu();
    this.nHell = this.nHell;
  }

  public void CheckSkill(string strID)
  {
    short sID = -1;
    if (strID != null && strID == "eSuccubus")
      sID = (short) 14;
    if ((int) sID == -1)
      return;
    UIMgr.AddPage("PopupMercenarySkill");
    PlayerMonsterData newPlayerMon = Info.GetNewPlayerMon(sID, false, false);
    PopupMercenarySkill.obj.ShowSkill(newPlayerMon);
  }

  public void OnRebirthStore()
  {
    UIMgr.PlaySound("Character", false);
    UIMgr.RemoveTop();
    UIMgr.AddPage("PopupRebirth");
  }

  public void OnInit()
  {
    if ((int) Info.rebirth.nInitHellStone >= this.nMaxInitCount && (int) this.nRuby < this.nInitRubyCost)
      UIMgr.NotEnoughRuby();
    else
      UIMgr.popupMsg.SetYesNo("InitHellStone", BData.GetString("UI0382"), true);
  }

  public void OnRealInit()
  {
    if ((int) Info.rebirth.nInitHellStone >= this.nMaxInitCount && (int) this.nRuby < this.nInitRubyCost)
    {
      UIMgr.NotEnoughRuby();
    }
    else
    {
      List<RebirthID> rebirthIdList1 = new List<RebirthID>();
      rebirthIdList1.Add(RebirthID.eHugeWeapon);
      rebirthIdList1.Add(RebirthID.eFireBall);
      rebirthIdList1.Add(RebirthID.eFireLance);
      rebirthIdList1.Add(RebirthID.eFrostBall);
      rebirthIdList1.Add(RebirthID.eAssasinate);
      rebirthIdList1.Add(RebirthID.eStrongKick);
      rebirthIdList1.Add(RebirthID.ePenetratePower);
      rebirthIdList1.Add(RebirthID.eMoonSlash);
      rebirthIdList1.Add(RebirthID.eSoulBomb);
      rebirthIdList1.Add(RebirthID.eSubLaser);
      rebirthIdList1.Add(RebirthID.eChainLightning);
      rebirthIdList1.Add(RebirthID.eMainCharDmg);
      rebirthIdList1.Add(RebirthID.eMercenaryDmg);
      rebirthIdList1.Add(RebirthID.eModLevel);
      rebirthIdList1.Add(RebirthID.eDamageReduce);
      rebirthIdList1.Add(RebirthID.ePreventModFail);
      rebirthIdList1.Add(RebirthID.eItemEnchantPlus);
      rebirthIdList1.Add(RebirthID.eEnchantManage);
      rebirthIdList1.Add(RebirthID.eAIBuilder);
      rebirthIdList1.Add(RebirthID.eQuickBattleOver);
      rebirthIdList1.Add(RebirthID.eSuccubus);
      rebirthIdList1.Add(RebirthID.eElementalBomb);
      List<RebirthID> rebirthIdList2 = new List<RebirthID>();
      rebirthIdList2.Add(RebirthID.ePreventModFail);
      rebirthIdList2.Add(RebirthID.eItemEnchantPlus);
      rebirthIdList2.Add(RebirthID.eEnchantManage);
      rebirthIdList2.Add(RebirthID.eAIBuilder);
      rebirthIdList2.Add(RebirthID.eQuickBattleOver);
      rebirthIdList2.Add(RebirthID.eSuccubus);
      for (int index1 = 0; index1 < rebirthIdList1.Count; ++index1)
      {
        if (Info.rebirth.dictRebirth.ContainsKey(rebirthIdList1[index1]) && (!Info.rebirth.listPurchase.Contains(ShopID.eHellPackage) || !rebirthIdList2.Contains(rebirthIdList1[index1]) || rebirthIdList1[index1] == RebirthID.eSuccubus) && (!Info.rebirth.listPurchase.Contains(ShopID.eSuccubusPackage) || !rebirthIdList2.Contains(rebirthIdList1[index1])))
        {
          int num = (int) Info.rebirth.dictRebirth[rebirthIdList1[index1]];
          for (int index2 = 0; index2 < num; ++index2)
          {
            SavedRebirth rebirth = Info.rebirth;
            ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + Info.GetCostRebirth(rebirthIdList1[index1], num - 1 - index2));
            rebirth.nHell = obscuredInt;
          }
          Info.rebirth.dictRebirth.Remove(rebirthIdList1[index1]);
        }
      }
      this.nHell = this.nHell;
      if (this.nInitRubyCost > 0)
      {
        PopupHellShop popupHellShop = this;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) popupHellShop.nRuby - this.nInitRubyCost);
        popupHellShop.nRuby = obscuredInt;
      }
      ++Info.rebirth.nInitHellStone;
      this.RefreshStat();
      UIMgr.PlaySound("Hire", false);
      SaveManager.SaveRebirth();
    }
  }
}
