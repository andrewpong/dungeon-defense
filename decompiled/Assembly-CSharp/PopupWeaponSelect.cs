// Decompiled with JetBrains decompiler
// Type: PopupWeaponSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupWeaponSelect : UIPage
{
  private static string red = "<color='red'>";
  private static string white = "<color='white'>";
  private static string strGood = "<color='#77ff00'>";
  private static string strBad = "<color='#ff1100'>";
  private static string strGoodArw = PopupWeaponSelect.strGood + "(▲";
  private static string strBadArw = PopupWeaponSelect.strBad + "(▼";
  private static string strEnd = ")</color>";
  private List<WeaponElt> listWeapon = new List<WeaponElt>();
  [HideInInspector]
  public long nSelectedWeapon = -1;
  private int nSelectModSlot = -1;
  private int nSelectMonSlot = -1;
  private bool bAutoSell = true;
  private List<PlayerItemData> listInherit = new List<PlayerItemData>();
  private string[] arrStrItemDescL = new string[6];
  private string[] arrStrItemDescR = new string[6];
  public static PopupWeaponSelect obj;
  public StringTooltip strTooltip;
  public GameObject goLeftItem;
  public GameObject goRightItem;
  public GameObject goModPanel;
  public GameObject goEnchantPanel;
  public WeaponElt eltWeaponDetailL;
  public WeaponElt eltWeaponDetailR;
  public Text textItemNameL;
  public Text textItemNameR;
  public Text textItemGradeL;
  public Text textItemGradeR;
  public Text textItemLevelL;
  public Text textItemLevelR;
  public Text textItemTypeL;
  public Text textItemTypeR;
  public Text textItemDescL;
  public Text textItemDescR;
  public Text textItemStatL;
  public Text textItemStatR;
  public Text textBtnA;
  public Text textBtnB;
  public Text textBtnC;
  public Text textBtnD;
  public Text textBtnE;
  public Text textGold;
  public Text textInven;
  public Text textTitle;
  public GameObject objElt;
  public GameObject goGold;
  public GameObject goInven;
  public GameObject goBtnA;
  public GameObject goBtnB;
  public GameObject goBtnC;
  public GameObject goBtnD;
  public GameObject goBtnE;
  public Button btnA;
  public Button btnB;
  public Image[] imgModCheckOn;
  public Image[] imgModCheckOff;
  public Image[] imgModPanel;
  public Button[] btnModPanel;
  public Text[] textModName;
  public Text textModBtnA;
  public Text textModBtnB;
  public Text textModTitle;
  public Text textModCost;
  public Button btnModA;
  public Button btnModB;
  public Button btnBackPanel;
  public RectTransform rtWeaponList;
  private PopupWeaponSelect.Mode eMode;
  public WeaponElt eltEnchantL;
  public WeaponElt eltEnchantR;
  public Text textEnchantTitle;
  public Text textEnchantCost;
  public Text textEnchantBtn;
  public Text textEnchantOver;
  public Text textEnchantSimple;
  public GameObject goSpec;
  public GameObject[] goSpecChar;
  public Image[] imgSpecChar;
  public GameObject[] goSpecUp;
  public GameObject[] goSpecDown;
  public GameObject[] goSpecEqual;
  public GameObject[] goSpecCant;
  public Button[] btnSpecDiff;
  public Text[] textSpecDiff;
  public Button[] btnSpecEquip;
  public Text[] textSpecEquip;
  public Text[] textSpecMasLv;
  public GameObject goSpecDiffClose;

  private long nGold
  {
    get
    {
      return (long) Info.currentSave.nNewGold;
    }
    set
    {
      Info.currentSave.nNewGold = (ObscuredLong) value;
      this.textGold.text = Info.currentSave.nNewGold.ToString("N0") + "G";
      if (!((UnityEngine.Object) PageLobby.obj != (UnityEngine.Object) null))
        return;
      PageLobby.obj.nGold = PageLobby.obj.nGold;
    }
  }

  private int nInven
  {
    get
    {
      return Info.currentSave.dictItem.Count;
    }
    set
    {
      this.textInven.text = this.nInven.ToString() + " / " + Info.nMaxInven.ToString("###0");
      this.textInven.color = this.nInven <= Info.nMaxInven ? Color.white : Color.red;
    }
  }

  private int nMaxInherit
  {
    get
    {
      return Info.GetRebirth(RebirthID.eInheritor);
    }
  }

  private int nInheritInven
  {
    get
    {
      return this.listInherit.Count;
    }
    set
    {
      this.textInven.text = this.nInheritInven.ToString() + " / " + Info.GetRebirth(RebirthID.eInheritor).ToString("###0");
      this.textInven.color = this.nInheritInven < Info.GetRebirth(RebirthID.eInheritor) ? Color.white : Color.red;
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PopupWeaponSelect.obj = this;
    Info.RefreshPartySkill();
    this.textEnchantBtn.text = BData.GetString("UI0100");
    this.textEnchantOver.text = BData.GetString("UI0127");
    this.textModBtnA.text = BData.GetString("UI0093");
    this.textModBtnB.text = BData.GetString("UI0166");
    this.textEnchantSimple.text = BData.GetString("UI0238");
    for (int index = 0; index < this.textSpecDiff.Length; ++index)
      this.textSpecDiff[index].text = BData.GetString("UI0186");
    for (int nPos = 0; nPos < 5; ++nPos)
    {
      PlayerMonsterData playerMon = Info.GetPlayerMon(nPos);
      this.goSpecChar[nPos].SetActive(playerMon != null);
      this.btnSpecDiff[nPos].gameObject.SetActive(playerMon != null);
      this.btnSpecEquip[nPos].gameObject.SetActive(playerMon != null);
      if (this.goSpecChar[nPos].activeInHierarchy)
      {
        MonsterData monster = BData.GetMonster((short) playerMon.sID);
        bool flag = (bool) playerMon.bAwaken || Info.CheckRebirth(monster.eAwaken);
        this.imgSpecChar[nPos].sprite = RSMgr.GetSprite(!flag ? monster.strSprite : monster.strSpriteAwk);
      }
    }
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((UnityEngine.Object) UIMgr.focused == (UnityEngine.Object) this))
      return;
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eWeaponSelect:
      case PopupWeaponSelect.Mode.eShop:
      case PopupWeaponSelect.Mode.eSellItem:
      case PopupWeaponSelect.Mode.eModify:
      case PopupWeaponSelect.Mode.eEnchant:
      case PopupWeaponSelect.Mode.eInherit:
        this.OnClose();
        break;
      case PopupWeaponSelect.Mode.eLootItem:
        this.OnNext();
        break;
    }
  }

  public void WeaponSelectMode()
  {
    this.eMode = PopupWeaponSelect.Mode.eWeaponSelect;
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    playerItemDataList.Sort((Comparison<PlayerItemData>) ((x, y) =>
    {
      if (!Info.CheckWeaponMastery((int) Info.nSelectedMonster, (long) x.UID) && Info.CheckWeaponMastery((int) Info.nSelectedMonster, (long) y.UID))
        return 1;
      if (Info.CheckWeaponMastery((int) Info.nSelectedMonster, (long) x.UID) && !Info.CheckWeaponMastery((int) Info.nSelectedMonster, (long) y.UID))
        return -1;
      if (!Info.currentMon.dictSkill.ContainsKey(BData.GetWeapon((short) x.sID).eMastery) && Info.currentMon.dictSkill.ContainsKey(BData.GetWeapon((short) y.sID).eMastery))
        return 1;
      if (Info.currentMon.dictSkill.ContainsKey(BData.GetWeapon((short) x.sID).eMastery) && !Info.currentMon.dictSkill.ContainsKey(BData.GetWeapon((short) y.sID).eMastery))
        return -1;
      switch (Info.option.byItemFilter)
      {
        case 0:
          if ((double) Info.GetBattleItem((long) x.UID).fDPS < (double) Info.GetBattleItem((long) y.UID).fDPS)
            return 1;
          if ((double) Info.GetBattleItem((long) x.UID).fDPS > (double) Info.GetBattleItem((long) y.UID).fDPS)
            return -1;
          break;
        case 1:
          if ((int) x.nLv < (int) y.nLv)
            return 1;
          if ((int) x.nLv > (int) y.nLv)
            return -1;
          break;
        case 2:
          if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
            return 1;
          if ((int) (byte) x.byGrade > (int) (byte) y.byGrade)
            return -1;
          break;
        case 3:
          if ((double) (float) x.fPower < (double) (float) y.fPower)
            return 1;
          if ((double) (float) x.fPower > (double) (float) y.fPower)
            return -1;
          break;
      }
      return 0;
    }));
    this.ReallocElt(playerItemDataList.Count);
    for (int index = 0; index < playerItemDataList.Count; ++index)
    {
      this.listWeapon[index].SetItem((long) playerItemDataList[index].UID, WeaponElt.Type.WeaponSelect, 0);
      SkillKey eMastery = BData.GetWeapon((short) Info.GetPlayerWeapon((long) playerItemDataList[index].UID).sID).eMastery;
      if (!Info.currentMon.dictSkill.ContainsKey(eMastery))
        this.listWeapon[index].imgIcon.color = Color.red;
      else if ((int) Info.currentMon.dictSkill[eMastery] < Info.GetBattleItem((long) playerItemDataList[index].UID).nMastery)
        this.listWeapon[index].imgIcon.color = Color.gray;
      else
        this.listWeapon[index].imgIcon.color = Color.white;
    }
    this.RefreshDetailRight((long) Info.GetPlayerMon((int) Info.nSelectedMonster).nEquip);
    this.RefreshHighlight();
    this.RefreshButton();
  }

  public void LootItemMode(bool bSort = false)
  {
    this.textBtnC.text = BData.GetString("UI0132");
    this.textBtnE.text = BData.GetString("UI0039");
    this.eMode = PopupWeaponSelect.Mode.eLootItem;
    this.RefreshLootItem(bSort);
    if (!Info.option.bAutoItemSell || !this.bAutoSell)
      return;
    switch (Info.option.byAutoItemSellType)
    {
      case 0:
        this.OnSellAuto();
        break;
      case 1:
        this.OnSellAll();
        break;
      case 3:
        this.OnSellOnlyLegend();
        break;
    }
    this.OnNext();
  }

  private void RefreshLootItem(bool bSort = false)
  {
    this.nGold = this.nGold;
    this.nInven = this.nInven;
    Info.nSelectedMonster = (ObscuredInt) 0;
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    if (bSort)
    {
      playerItemDataList.Sort((Comparison<PlayerItemData>) ((x, y) =>
      {
        if (!Info.listDropItem.Contains(x) && Info.listDropItem.Contains(y))
          return 1;
        if (Info.listDropItem.Contains(x) && !Info.listDropItem.Contains(y))
          return -1;
        if (!Info.IsEquipped((long) x.UID) && Info.IsEquipped((long) y.UID))
          return 1;
        if (Info.IsEquipped((long) x.UID) && !Info.IsEquipped((long) y.UID))
          return -1;
        switch (Info.option.byItemFilter)
        {
          case 0:
            if ((double) Info.GetBattleItem((long) x.UID).fDPS < (double) Info.GetBattleItem((long) y.UID).fDPS)
              return 1;
            if ((double) Info.GetBattleItem((long) x.UID).fDPS > (double) Info.GetBattleItem((long) y.UID).fDPS)
              return -1;
            break;
          case 1:
            if ((int) x.nLv < (int) y.nLv)
              return 1;
            if ((int) x.nLv > (int) y.nLv)
              return -1;
            break;
          case 2:
            if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
              return 1;
            if ((int) (byte) x.byGrade > (int) (byte) y.byGrade)
              return -1;
            break;
          case 3:
            if ((double) (float) x.fPower < (double) (float) y.fPower)
              return 1;
            if ((double) (float) x.fPower > (double) (float) y.fPower)
              return -1;
            break;
        }
        return 0;
      }));
      Info.currentSave.dictItem.Clear();
    }
    this.ReallocElt(playerItemDataList.Count);
    for (int index = 0; index < playerItemDataList.Count; ++index)
    {
      if (bSort)
        Info.currentSave.dictItem.Add(playerItemDataList[index].UID, playerItemDataList[index]);
      this.listWeapon[index].SetItem((long) playerItemDataList[index].UID, WeaponElt.Type.LootItem, 0);
      this.listWeapon[index].SetNew(Info.listDropItem.Contains(playerItemDataList[index]));
    }
    this.RefreshDetailRight(-1L);
    this.RefreshHighlight();
    this.RefreshButton();
  }

  public void ShopMode()
  {
    this.eMode = PopupWeaponSelect.Mode.eShop;
    this.nGold = this.nGold;
    this.nInven = this.nInven;
    Info.nSelectedMonster = (ObscuredInt) 0;
    this.ReallocElt(Info.currentSave.listShopItem.Count);
    Info.currentSave.listShopItem.Sort((Comparison<PlayerItemData>) ((x, y) =>
    {
      switch (Info.option.byItemFilter)
      {
        case 0:
          if ((double) Info.GetBattleItem((long) x.UID).fDPS < (double) Info.GetBattleItem((long) y.UID).fDPS)
            return 1;
          if ((double) Info.GetBattleItem((long) x.UID).fDPS > (double) Info.GetBattleItem((long) y.UID).fDPS)
            return -1;
          break;
        case 1:
          if ((int) x.nLv < (int) y.nLv)
            return 1;
          if ((int) x.nLv > (int) y.nLv)
            return -1;
          break;
        case 2:
          if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
            return 1;
          if ((int) (byte) x.byGrade > (int) (byte) y.byGrade)
            return -1;
          break;
        case 3:
          if ((double) (float) x.fPower < (double) (float) y.fPower)
            return 1;
          if ((double) (float) x.fPower > (double) (float) y.fPower)
            return -1;
          break;
      }
      return 0;
    }));
    for (int index = 0; index < Info.currentSave.listShopItem.Count; ++index)
      this.listWeapon[index].SetItem(Info.currentSave.listShopItem[index], WeaponElt.Type.Shop, 0);
    this.RefreshDetailRight(-1L);
    this.RefreshHighlight();
    this.RefreshButton();
    if (Info.option.bShowWeaponPurchase)
      return;
    Info.option.bShowWeaponPurchase = true;
    UIMgr.TooltipShow(BData.GetString(this.strTooltip.strTooltip));
    SaveManager.SaveOption();
  }

  public void SellMode(bool bSort = false)
  {
    this.textBtnC.text = BData.GetString("UI0039");
    this.textBtnE.text = BData.GetString("UI0132");
    this.eMode = PopupWeaponSelect.Mode.eSellItem;
    this.nGold = this.nGold;
    this.nInven = this.nInven;
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    if (bSort)
    {
      playerItemDataList.Sort((Comparison<PlayerItemData>) ((x, y) =>
      {
        if (!Info.IsEquipped((long) x.UID) && Info.IsEquipped((long) y.UID))
          return 1;
        if (Info.IsEquipped((long) x.UID) && !Info.IsEquipped((long) y.UID))
          return -1;
        switch (Info.option.byItemFilter)
        {
          case 0:
            if ((double) Info.GetBattleItem((long) x.UID).fDPS < (double) Info.GetBattleItem((long) y.UID).fDPS)
              return 1;
            if ((double) Info.GetBattleItem((long) x.UID).fDPS > (double) Info.GetBattleItem((long) y.UID).fDPS)
              return -1;
            break;
          case 1:
            if ((int) x.nLv < (int) y.nLv)
              return 1;
            if ((int) x.nLv > (int) y.nLv)
              return -1;
            break;
          case 2:
            if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
              return 1;
            if ((int) (byte) x.byGrade > (int) (byte) y.byGrade)
              return -1;
            break;
          case 3:
            if ((double) (float) x.fPower < (double) (float) y.fPower)
              return 1;
            if ((double) (float) x.fPower > (double) (float) y.fPower)
              return -1;
            break;
        }
        return 0;
      }));
      Info.currentSave.dictItem.Clear();
    }
    this.ReallocElt(playerItemDataList.Count);
    for (int index = 0; index < playerItemDataList.Count; ++index)
    {
      if (bSort)
        Info.currentSave.dictItem.Add(playerItemDataList[index].UID, playerItemDataList[index]);
      this.listWeapon[index].SetItem((long) playerItemDataList[index].UID, WeaponElt.Type.WeaponSelect, 0);
    }
    this.RefreshDetailRight(-1L);
    this.RefreshHighlight();
    this.RefreshButton();
    if (Info.option.bShowWeaponSell)
      return;
    Info.option.bShowWeaponSell = true;
    UIMgr.TooltipShow(BData.GetString(this.strTooltip.strTooltip));
    SaveManager.SaveOption();
  }

  public void ModifyMode()
  {
    this.eMode = PopupWeaponSelect.Mode.eModify;
    this.nGold = this.nGold;
    this.nInven = this.nInven;
    this.nSelectModSlot = -1;
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    this.ReallocElt(playerItemDataList.Count);
    playerItemDataList.Sort((Comparison<PlayerItemData>) ((x, y) =>
    {
      if (!Info.IsEquipped((long) x.UID) && Info.IsEquipped((long) y.UID))
        return 1;
      if (Info.IsEquipped((long) x.UID) && !Info.IsEquipped((long) y.UID))
        return -1;
      switch (Info.option.byItemFilter)
      {
        case 0:
          if ((double) Info.GetBattleItem((long) x.UID).fDPS < (double) Info.GetBattleItem((long) y.UID).fDPS)
            return 1;
          if ((double) Info.GetBattleItem((long) x.UID).fDPS > (double) Info.GetBattleItem((long) y.UID).fDPS)
            return -1;
          break;
        case 1:
          if ((int) x.nLv < (int) y.nLv)
            return 1;
          if ((int) x.nLv > (int) y.nLv)
            return -1;
          break;
        case 2:
          if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
            return 1;
          if ((int) (byte) x.byGrade > (int) (byte) y.byGrade)
            return -1;
          break;
        case 3:
          if ((double) (float) x.fPower < (double) (float) y.fPower)
            return 1;
          if ((double) (float) x.fPower > (double) (float) y.fPower)
            return -1;
          break;
      }
      return 0;
    }));
    for (int index = 0; index < playerItemDataList.Count; ++index)
      this.listWeapon[index].SetItem((long) playerItemDataList[index].UID, WeaponElt.Type.WeaponSelect, 0);
    this.RefreshDetailRight(-1L);
    this.RefreshModHighlight();
    this.RefreshHighlight();
    this.RefreshButton();
    if (Info.option.bShowWeaponMod)
      return;
    Info.option.bShowWeaponMod = true;
    UIMgr.TooltipShow(BData.GetString(this.strTooltip.strTooltip));
    SaveManager.SaveOption();
  }

  public void EnchantMode(long nWeapon = -1)
  {
    this.textBtnE.text = BData.GetString("UI0332");
    this.eMode = PopupWeaponSelect.Mode.eEnchant;
    this.nGold = this.nGold;
    this.nInven = this.nInven;
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    this.ReallocElt(playerItemDataList.Count);
    playerItemDataList.Sort((Comparison<PlayerItemData>) ((x, y) =>
    {
      if (!Info.IsEquipped((long) x.UID) && Info.IsEquipped((long) y.UID))
        return 1;
      if (Info.IsEquipped((long) x.UID) && !Info.IsEquipped((long) y.UID))
        return -1;
      switch (Info.option.byItemFilter)
      {
        case 0:
          if ((double) Info.GetBattleItem((long) x.UID).fDPS < (double) Info.GetBattleItem((long) y.UID).fDPS)
            return 1;
          if ((double) Info.GetBattleItem((long) x.UID).fDPS > (double) Info.GetBattleItem((long) y.UID).fDPS)
            return -1;
          break;
        case 1:
          if ((int) x.nLv < (int) y.nLv)
            return 1;
          if ((int) x.nLv > (int) y.nLv)
            return -1;
          break;
        case 2:
          if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
            return 1;
          if ((int) (byte) x.byGrade > (int) (byte) y.byGrade)
            return -1;
          break;
        case 3:
          if ((double) (float) x.fPower < (double) (float) y.fPower)
            return 1;
          if ((double) (float) x.fPower > (double) (float) y.fPower)
            return -1;
          break;
      }
      return 0;
    }));
    for (int index = 0; index < playerItemDataList.Count; ++index)
      this.listWeapon[index].SetItem((long) playerItemDataList[index].UID, WeaponElt.Type.WeaponSelect, 0);
    this.RefreshDetailRight(nWeapon);
    this.RefreshHighlight();
    this.RefreshButton();
    if (Info.option.bShowWeaponEnchant)
      return;
    Info.option.bShowWeaponEnchant = true;
    UIMgr.TooltipShow(BData.GetString(this.strTooltip.strTooltip));
    SaveManager.SaveOption();
  }

  public void InheritMode()
  {
    this.eMode = PopupWeaponSelect.Mode.eInherit;
    this.nInheritInven = this.nInheritInven;
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    this.ReallocElt(playerItemDataList.Count);
    playerItemDataList.Sort((Comparison<PlayerItemData>) ((x, y) =>
    {
      switch (Info.option.byItemFilter)
      {
        case 0:
          if ((double) Info.GetBattleItem((long) x.UID).fDPS < (double) Info.GetBattleItem((long) y.UID).fDPS)
            return 1;
          if ((double) Info.GetBattleItem((long) x.UID).fDPS > (double) Info.GetBattleItem((long) y.UID).fDPS)
            return -1;
          break;
        case 1:
          if ((int) x.nLv < (int) y.nLv)
            return 1;
          if ((int) x.nLv > (int) y.nLv)
            return -1;
          break;
        case 2:
          if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
            return 1;
          if ((int) (byte) x.byGrade > (int) (byte) y.byGrade)
            return -1;
          break;
        case 3:
          if ((double) (float) x.fPower < (double) (float) y.fPower)
            return 1;
          if ((double) (float) x.fPower > (double) (float) y.fPower)
            return -1;
          break;
      }
      return 0;
    }));
    for (int index = 0; index < playerItemDataList.Count; ++index)
      this.listWeapon[index].SetItem((long) playerItemDataList[index].UID, WeaponElt.Type.WeaponSelect, 0);
    this.RefreshDetailRight(-1L);
    this.RefreshHighlight();
    this.RefreshButton();
    this.RefreshChecker();
    UIMgr.popupMsg.SetMsg(BData.GetString("UI0264").Replace("[1]", (1 + Info.GetRebirthFacToInt(RebirthID.eInheritLevel)).ToString()), true, false, string.Empty);
  }

  private void RefreshButton()
  {
    this.goGold.SetActive(this.eMode != PopupWeaponSelect.Mode.eWeaponSelect && this.eMode != PopupWeaponSelect.Mode.eInherit);
    this.goInven.SetActive(this.eMode != PopupWeaponSelect.Mode.eWeaponSelect);
    this.goBtnA.SetActive(true);
    this.goBtnB.SetActive(this.eMode != PopupWeaponSelect.Mode.eModify);
    this.goBtnD.SetActive(this.eMode == PopupWeaponSelect.Mode.eLootItem || this.eMode == PopupWeaponSelect.Mode.eSellItem);
    this.goBtnE.SetActive(this.eMode == PopupWeaponSelect.Mode.eEnchant || this.eMode == PopupWeaponSelect.Mode.eLootItem || this.eMode == PopupWeaponSelect.Mode.eSellItem);
    this.btnBackPanel.interactable = false;
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eWeaponSelect:
        this.strTooltip.gameObject.SetActive(false);
        this.textTitle.text = BData.GetString("UI0045");
        break;
      case PopupWeaponSelect.Mode.eLootItem:
        this.strTooltip.gameObject.SetActive(false);
        this.textTitle.text = BData.GetString("UI0046");
        break;
      case PopupWeaponSelect.Mode.eShop:
        this.strTooltip.gameObject.SetActive(true);
        this.strTooltip.strTooltip = "UI0296";
        this.textTitle.text = BData.GetString("UI0003") + " " + BData.GetString("UI0071");
        break;
      case PopupWeaponSelect.Mode.eSellItem:
        this.strTooltip.gameObject.SetActive(true);
        this.strTooltip.strTooltip = "UI0295";
        this.textTitle.text = BData.GetString("UI0003") + " " + BData.GetString("UI0016");
        break;
      case PopupWeaponSelect.Mode.eModify:
        this.strTooltip.gameObject.SetActive(true);
        this.strTooltip.strTooltip = "UI0294";
        this.textTitle.text = BData.GetString("UI0003") + " " + BData.GetString("UI0093");
        break;
      case PopupWeaponSelect.Mode.eEnchant:
        this.strTooltip.gameObject.SetActive(true);
        this.strTooltip.strTooltip = "UI0293";
        this.textTitle.text = BData.GetString("UI0003") + " " + BData.GetString("UI0100");
        break;
      case PopupWeaponSelect.Mode.eInherit:
        this.strTooltip.gameObject.SetActive(true);
        this.strTooltip.strTooltip = "UI0264";
        this.strTooltip.strTooltipSub1 = (1 + Info.GetRebirthFacToInt(RebirthID.eInheritLevel)).ToString();
        this.textTitle.text = BData.GetString("UI0263");
        break;
    }
  }

  private void ReallocElt(int nCount)
  {
    Vector2 zero = Vector2.zero;
    float num = 0.0f;
    for (int index = 0; index < nCount; ++index)
    {
      WeaponElt component;
      RectTransform transform;
      if (index < this.listWeapon.Count)
      {
        component = this.listWeapon[index];
        transform = component.transform as RectTransform;
      }
      else
      {
        component = UnityEngine.Object.Instantiate<GameObject>(this.objElt).GetComponent<WeaponElt>();
        transform = component.transform as RectTransform;
        transform.SetParent((Transform) this.rtWeaponList);
        transform.localScale = Vector3.one;
        transform.localRotation = Quaternion.identity;
        RectTransform rectTransform = transform;
        Vector2 vector2_1 = new Vector2(0.0f, 0.5f);
        transform.anchorMax = vector2_1;
        Vector2 vector2_2 = vector2_1;
        transform.anchorMin = vector2_2;
        Vector2 vector2_3 = vector2_2;
        rectTransform.pivot = vector2_3;
        this.listWeapon.Add(component);
      }
      component.gameObject.SetActive(true);
      num = zero.x = (float) (10 + 112 * index);
      zero.y = 0.0f;
      transform.anchoredPosition = zero;
    }
    this.rtWeaponList.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num + 112f);
    if (nCount >= this.listWeapon.Count)
      return;
    for (int index = nCount; index < this.listWeapon.Count; ++index)
      this.listWeapon[index].gameObject.SetActive(false);
  }

  public void RefreshDetailRight(long uid)
  {
    this.nSelectedWeapon = uid;
    bool flag1 = false;
    bool flag2 = false;
    for (int index = 0; index < this.arrStrItemDescL.Length; ++index)
    {
      this.arrStrItemDescL[index] = string.Empty;
      this.arrStrItemDescR[index] = string.Empty;
    }
    bool flag3 = Info.IsEquipped(uid);
    PlayerItemData pData = (PlayerItemData) null;
    ItemData itemData = (ItemData) null;
    BattleItemData battleItemData = (BattleItemData) null;
    PlayerItemData playerItemData = (PlayerItemData) null;
    if (this.eMode == PopupWeaponSelect.Mode.eWeaponSelect)
    {
      long nEquip = (long) Info.GetPlayerMon((int) Info.nSelectedMonster).nEquip;
      if (nEquip != -1L)
        playerItemData = Info.GetPlayerWeapon(nEquip);
    }
    if (this.nSelectMonSlot != -1 && Info.currentSave.arrPlayerMon[this.nSelectMonSlot] != null)
      playerItemData = Info.GetPlayerWeapon((long) Info.currentSave.arrPlayerMon[this.nSelectMonSlot].nEquip);
    this.goModPanel.SetActive(this.eMode == PopupWeaponSelect.Mode.eModify);
    this.goEnchantPanel.SetActive(this.eMode == PopupWeaponSelect.Mode.eEnchant);
    this.goRightItem.SetActive(this.eMode != PopupWeaponSelect.Mode.eModify && this.eMode != PopupWeaponSelect.Mode.eEnchant);
    this.goLeftItem.SetActive(playerItemData != null || this.eMode == PopupWeaponSelect.Mode.eEnchant || this.eMode == PopupWeaponSelect.Mode.eModify);
    this.goSpecDiffClose.SetActive(this.nSelectMonSlot != -1);
    this.eltWeaponDetailL.SetItem(-1L, WeaponElt.Type.JustShow, 0);
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eWeaponSelect:
      case PopupWeaponSelect.Mode.eLootItem:
      case PopupWeaponSelect.Mode.eSellItem:
        pData = Info.GetPlayerWeapon(uid);
        this.eltWeaponDetailR.SetItem(uid, WeaponElt.Type.JustShow, 0);
        break;
      case PopupWeaponSelect.Mode.eShop:
        for (int index = 0; index < Info.currentSave.listShopItem.Count; ++index)
        {
          if ((long) Info.currentSave.listShopItem[index].UID == this.nSelectedWeapon)
          {
            pData = Info.currentSave.listShopItem[index];
            this.eltWeaponDetailR.SetItem(pData, WeaponElt.Type.JustShow, 0);
            break;
          }
        }
        if (pData == null)
        {
          this.eltWeaponDetailR.SetItem(-1L, WeaponElt.Type.JustShow, 0);
          break;
        }
        break;
      case PopupWeaponSelect.Mode.eModify:
        playerItemData = Info.GetPlayerWeapon(uid);
        this.eltWeaponDetailL.SetItem(uid, WeaponElt.Type.JustShow, 0);
        break;
      case PopupWeaponSelect.Mode.eEnchant:
        this.textEnchantTitle.text = BData.GetString("UI0129") + "\n(" + (object) Info.currentSave.nEnchant + "/" + (object) Info.nMaxEnchant + ")";
        playerItemData = Info.GetPlayerWeapon(uid);
        int nPlusLv = 1 + Info.GetResearchFacInt(ResearchID.eStone) + Info.GetRebirthFacToInt(RebirthID.eItemEnchantPlus);
        this.eltEnchantL.SetItem(uid, WeaponElt.Type.JustShow, 0);
        this.eltEnchantR.SetItem(uid, WeaponElt.Type.JustShow, nPlusLv);
        bool flag4 = false;
        if (playerItemData != null)
        {
          itemData = BData.GetWeapon((short) playerItemData.sID);
          if (flag3)
          {
            for (int nPos = 0; nPos < 5; ++nPos)
            {
              if (Info.GetPlayerMon(nPos) != null && (long) Info.GetPlayerMon(nPos).nEquip == this.nSelectedWeapon && Info.GetPlayerMon(nPos).dictSkill.ContainsKey(itemData.eMastery))
                flag4 = (int) Info.GetPlayerMon(nPos).dictSkill[itemData.eMastery] < Info.CalcMasteryLv((int) playerItemData.nLv + nPlusLv);
            }
          }
        }
        this.textEnchantOver.gameObject.SetActive(flag3 && flag4);
        break;
      case PopupWeaponSelect.Mode.eInherit:
        pData = Info.GetPlayerWeapon(uid);
        this.eltWeaponDetailR.SetItem(uid, WeaponElt.Type.JustShow, 0);
        this.eltWeaponDetailR.SetChecker(this.listInherit.Contains(pData));
        break;
    }
    this.textItemGradeR.color = Color.white;
    int nLv = 0;
    byte byGrade = 0;
    if (pData != null)
    {
      itemData = BData.GetWeapon((short) pData.sID);
      battleItemData = Info.GetBattleItem((long) pData.UID);
      nLv = (int) pData.nLv;
      byGrade = (byte) pData.byGrade;
      if (this.eMode == PopupWeaponSelect.Mode.eWeaponSelect)
      {
        flag1 = Info.CheckWeaponMastery((int) Info.nSelectedMonster, this.nSelectedWeapon);
        if (flag3)
          flag2 = Info.IsEquipped((int) Info.nSelectedMonster, this.nSelectedWeapon);
      }
      this.textItemGradeR.color = Info.GetGradeColor((byte) pData.byGrade);
      this.arrStrItemDescR = this.MakeItemDesc(pData, playerItemData);
    }
    this.textItemNameR.text = this.arrStrItemDescR[0];
    this.textItemGradeR.text = this.arrStrItemDescR[1];
    this.textItemLevelR.text = this.arrStrItemDescR[2];
    this.textItemTypeR.text = this.arrStrItemDescR[3];
    this.textItemDescR.text = this.arrStrItemDescR[4];
    this.textItemStatR.text = this.arrStrItemDescR[5];
    if (playerItemData != null)
    {
      this.eltWeaponDetailL.SetItem(playerItemData, WeaponElt.Type.JustShow, 0);
      this.arrStrItemDescL = this.MakeItemDesc(playerItemData, (PlayerItemData) null);
      this.textItemGradeL.color = Info.GetGradeColor((byte) playerItemData.byGrade);
    }
    this.textItemNameL.text = this.arrStrItemDescL[0];
    this.textItemGradeL.text = this.arrStrItemDescL[1];
    this.textItemLevelL.text = this.arrStrItemDescL[2];
    this.textItemTypeL.text = this.arrStrItemDescL[3];
    this.textItemDescL.text = this.arrStrItemDescL[4];
    this.textItemStatL.text = this.arrStrItemDescL[5];
    this.goBtnC.SetActive(this.eMode == PopupWeaponSelect.Mode.eLootItem || this.eMode == PopupWeaponSelect.Mode.eSellItem || this.eMode == PopupWeaponSelect.Mode.eInherit);
    this.goSpec.SetActive(this.eMode != PopupWeaponSelect.Mode.eInherit && this.eMode != PopupWeaponSelect.Mode.eWeaponSelect && (this.eMode != PopupWeaponSelect.Mode.eEnchant && this.eMode != PopupWeaponSelect.Mode.eModify) && itemData != null && playerItemData == null);
    if (this.goSpec.activeInHierarchy)
    {
      int num1 = 0;
      for (int nPos = 0; nPos < 5; ++nPos)
      {
        if (this.goSpecChar[nPos].activeInHierarchy)
        {
          float num2 = -1f;
          bool flag5 = Info.GetPlayerMon(nPos).dictSkill.ContainsKey(itemData.eMastery);
          if (flag5)
          {
            num1 = Info.GetSkill(nPos, itemData.eMastery);
            num2 = (long) Info.GetPlayerMon(nPos).nEquip != -1L ? battleItemData.fDPS - Info.GetBattleItem((long) Info.GetPlayerMon(nPos).nEquip).fDPS : 1f;
          }
          this.btnSpecDiff[nPos].interactable = flag5;
          this.btnSpecEquip[nPos].interactable = flag5;
          this.btnSpecEquip[nPos].gameObject.SetActive(this.eMode != PopupWeaponSelect.Mode.eShop);
          this.textSpecEquip[nPos].text = BData.GetString((long) Info.GetPlayerMon(nPos).nEquip != this.nSelectedWeapon ? "UI0042" : "UI0043");
          this.goSpecCant[nPos].SetActive(!flag5);
          this.goSpecUp[nPos].SetActive(flag5 && (double) num2 > 0.0);
          this.goSpecDown[nPos].SetActive(flag5 && (double) num2 < 0.0);
          this.goSpecEqual[nPos].SetActive(flag5 && (double) num2 == 0.0);
          this.textSpecMasLv[nPos].text = !flag5 ? string.Empty : "L" + num1.ToString();
          this.textSpecMasLv[nPos].color = num1 < battleItemData.nMastery ? Color.red : Color.white;
        }
      }
    }
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eWeaponSelect:
        this.btnA.interactable = flag1 || flag3 && flag2;
        this.btnB.interactable = true;
        this.textBtnA.text = !Info.IsEquipped((int) Info.nSelectedMonster, this.nSelectedWeapon) ? BData.GetString("UI0042") : BData.GetString("UI0043");
        this.textBtnB.text = BData.GetString("UI0094");
        break;
      case PopupWeaponSelect.Mode.eLootItem:
        this.btnA.interactable = !flag3;
        this.btnB.interactable = true;
        this.textBtnD.text = pData == null || !(bool) pData.bProtected ? BData.GetString("UI0245") : BData.GetString("UI0246");
        this.textBtnA.text = BData.GetString("UI0016") + (pData == null ? string.Empty : "\n<size='40'>" + Info.GetSellPrice(nLv, byGrade).ToString("N0") + "G</size>");
        this.textBtnB.text = BData.GetString("UI0052");
        break;
      case PopupWeaponSelect.Mode.eShop:
        this.btnA.interactable = pData != null;
        this.btnB.interactable = true;
        this.textBtnA.text = BData.GetString("UI0071") + (pData == null ? string.Empty : "\n<size='40'>" + Info.GetItemPurchasePrice(nLv, byGrade).ToString("N0") + "G</size>");
        this.textBtnB.text = BData.GetString("UI0094");
        break;
      case PopupWeaponSelect.Mode.eSellItem:
        this.btnA.interactable = !flag3;
        this.btnB.interactable = true;
        this.textBtnD.text = pData == null || !(bool) pData.bProtected ? BData.GetString("UI0245") : BData.GetString("UI0246");
        this.textBtnA.text = BData.GetString("UI0016") + (pData == null ? string.Empty : "\n<size='40'>" + Info.GetSellPrice(nLv, byGrade).ToString("N0") + "G</size>");
        this.textBtnB.text = BData.GetString("UI0094");
        break;
      case PopupWeaponSelect.Mode.eModify:
        this.btnA.interactable = true;
        this.textBtnA.text = BData.GetString("UI0095");
        this.textModTitle.text = BData.GetString("UI0093");
        this.textModCost.text = "0G";
        int num = 0;
        if (playerItemData != null)
        {
          this.textModCost.text = Info.GetModCost(this.nSelectedWeapon, this.nSelectModSlot).ToString("N0") + "G";
          for (int index = 0; index < playerItemData.arrMod.Length; ++index)
          {
            this.textModName[index].text = BData.GetString(index >= (int) playerItemData.nMod ? "UI0097" : "UI0096");
            this.imgModCheckOn[index].gameObject.SetActive(index < (int) playerItemData.nMod);
            this.btnModPanel[index].interactable = index < (int) playerItemData.nMod;
            if (playerItemData.arrMod[index] != null && playerItemData.arrMod[index].eMod != ModType.eNone)
            {
              ModData mod = BData.GetMod(playerItemData.arrMod[index].eMod);
              this.textModName[index].text = BData.GetString(mod.strName) + " Lv." + (object) playerItemData.arrMod[index].nModLevel;
              ++num;
            }
          }
          Text textModTitle = this.textModTitle;
          string str = textModTitle.text + " (" + (object) num + "/" + (object) playerItemData.nMod + ")";
          textModTitle.text = str;
          break;
        }
        for (int index = 0; index < this.textModName.Length; ++index)
        {
          this.textModName[index].text = BData.GetString("UI0097");
          this.imgModCheckOn[index].gameObject.SetActive(false);
          this.btnModPanel[index].interactable = false;
        }
        break;
      case PopupWeaponSelect.Mode.eEnchant:
        this.btnB.interactable = playerItemData != null;
        this.textBtnA.text = BData.GetString("UI0094");
        this.textBtnB.text = BData.GetString("UI0356");
        if (playerItemData != null)
        {
          this.textEnchantCost.text = Info.GetEnchantCost(this.nSelectedWeapon).ToString("N0") + " G";
          break;
        }
        this.textEnchantCost.text = string.Empty;
        break;
      case PopupWeaponSelect.Mode.eInherit:
        this.btnA.interactable = pData != null;
        this.btnB.interactable = true;
        this.textBtnA.text = pData == null || !this.listInherit.Contains(pData) ? BData.GetString("UI0265") : BData.GetString("UI0094");
        this.textBtnB.text = BData.GetString("UI0193");
        this.textBtnC.text = BData.GetString("UI0267");
        break;
    }
  }

  public void RefreshMod()
  {
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eWeaponSelect:
        this.WeaponSelectMode();
        break;
      case PopupWeaponSelect.Mode.eLootItem:
        this.LootItemMode(true);
        break;
      case PopupWeaponSelect.Mode.eShop:
        this.ShopMode();
        break;
      case PopupWeaponSelect.Mode.eSellItem:
        this.SellMode(true);
        break;
      case PopupWeaponSelect.Mode.eModify:
        this.ModifyMode();
        break;
      case PopupWeaponSelect.Mode.eEnchant:
        this.EnchantMode(-1L);
        break;
      case PopupWeaponSelect.Mode.eInherit:
        this.InheritMode();
        break;
    }
  }

  private string[] MakeItemDesc(PlayerItemData pData, PlayerItemData lData = null)
  {
    ItemData weapon = BData.GetWeapon((short) pData.sID);
    BattleItemData battleItem1 = Info.GetBattleItem((long) pData.UID);
    bool flag1 = true;
    bool flag2 = true;
    if (this.eMode == PopupWeaponSelect.Mode.eWeaponSelect)
    {
      flag1 = Info.GetPlayerMon((int) Info.nSelectedMonster).dictSkill.ContainsKey(weapon.eMastery);
      flag2 = flag1 && (int) Info.GetPlayerMon((int) Info.nSelectedMonster).dictSkill[weapon.eMastery] >= battleItem1.nMastery;
    }
    else if (this.nSelectMonSlot != -1)
    {
      flag1 = Info.GetPlayerMon(this.nSelectMonSlot).dictSkill.ContainsKey(weapon.eMastery);
      flag2 = flag1 && (int) Info.GetPlayerMon(this.nSelectMonSlot).dictSkill[weapon.eMastery] >= battleItem1.nMastery;
    }
    float[] numArray = new float[10];
    string[] strArray = new string[10];
    bool[] flagArray = new bool[10];
    for (int index = 0; index < numArray.Length; ++index)
    {
      numArray[index] = 0.0f;
      strArray[index] = string.Empty;
      flagArray[index] = false;
    }
    if (lData != null)
    {
      BattleItemData battleItem2 = Info.GetBattleItem((long) lData.UID);
      numArray[0] = battleItem1.fDPS - battleItem2.fDPS;
      numArray[1] = battleItem1.fDmg - battleItem2.fDmg;
      numArray[2] = (float) (1.0 / (double) battleItem1.fRate - 1.0 / (double) battleItem2.fRate);
      numArray[3] = battleItem1.fReload - battleItem2.fReload;
      numArray[4] = battleItem1.fAcc - battleItem2.fAcc;
      numArray[5] = (float) (battleItem1.nAmmo - battleItem2.nAmmo);
      numArray[6] = (float) (((double) battleItem1.fvsArmor - (double) battleItem2.fvsArmor) * 100.0);
      numArray[7] = (float) (((double) battleItem1.fvsMagic - (double) battleItem2.fvsMagic) * 100.0);
      numArray[8] = battleItem1.fSpd - battleItem2.fSpd;
      numArray[9] = (float) ((int) pData.nMod - (int) lData.nMod);
      strArray[0] = (double) numArray[0] != 0.0 ? ((double) numArray[0] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[0]).ToString("####0.#") : PopupWeaponSelect.strGoodArw + numArray[0].ToString("###0.#")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[1] = (double) numArray[1] != 0.0 ? ((double) numArray[1] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[1]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[1].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[2] = (double) numArray[2] != 0.0 ? ((double) numArray[2] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[2]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[2].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[3] = (double) numArray[3] != 0.0 ? ((double) numArray[3] >= 0.0 ? PopupWeaponSelect.strBadArw + numArray[3].ToString("####0.##") : PopupWeaponSelect.strGoodArw + (-numArray[3]).ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[4] = (double) numArray[4] != 0.0 ? ((double) numArray[4] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[4]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[4].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[5] = (double) numArray[5] != 0.0 ? ((double) numArray[5] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[5]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[5].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[6] = (double) numArray[6] != 0.0 ? ((double) numArray[6] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[6]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[6].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[7] = (double) numArray[7] != 0.0 ? ((double) numArray[7] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[7]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[7].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[8] = (double) numArray[8] != 0.0 ? ((double) numArray[8] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[8]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[8].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
      strArray[9] = (double) numArray[9] != 0.0 ? ((double) numArray[9] <= 0.0 ? PopupWeaponSelect.strBadArw + (-numArray[9]).ToString("####0.##") : PopupWeaponSelect.strGoodArw + numArray[9].ToString("###0.##")) + PopupWeaponSelect.strEnd : "(-)";
    }
    int num = 0;
    string str1 = string.Empty;
    bool flag3 = true;
    for (int index = 0; index < pData.arrMod.Length; ++index)
    {
      if (pData.arrMod[index] != null && pData.arrMod[index].eMod != ModType.eNone)
      {
        string str2 = flag3 ? " : <color='#77FF00'>" : str1 + ", ";
        switch (pData.arrMod[index].eMod)
        {
          case ModType.eAcc:
            flagArray[4] = true;
            break;
          case ModType.eDmg:
            flagArray[0] = flagArray[1] = true;
            break;
          case ModType.eReload:
            flagArray[0] = flagArray[3] = true;
            break;
          case ModType.eAmmo:
            flagArray[0] = flagArray[5] = true;
            break;
          case ModType.eAsp:
            flagArray[0] = flagArray[2] = true;
            break;
          case ModType.eCri:
            flagArray[0] = true;
            break;
          case ModType.eVsA:
            flagArray[6] = true;
            break;
          case ModType.eVsM:
            flagArray[7] = true;
            break;
          case ModType.eBulSpd:
            flagArray[8] = true;
            break;
        }
        str1 = str2 + BData.GetString(BData.GetMod(pData.arrMod[index].eMod).strName) + "(Lv." + (object) pData.arrMod[index].nModLevel + ")";
        flag3 = false;
        ++num;
      }
    }
    for (int index = 0; index < 10; ++index)
    {
      if (flagArray[index])
        strArray[index] = "</color>" + strArray[index];
    }
    if (!flag3)
      str1 += "</color>";
    return new string[6]
    {
      BData.GetString(weapon.strName),
      Info.GetGradeString((byte) pData.byGrade, false) + " (" + pData.fPower.ToString("P2") + ")",
      BData.GetString("UI0009") + " " + (object) pData.nLv,
      (!flag1 ? PopupWeaponSelect.red : PopupWeaponSelect.white) + BData.GetString(BData.GetSkill(weapon.eMastery).strName) + "</color>" + (!flag2 ? PopupWeaponSelect.red : PopupWeaponSelect.white) + " Lv." + battleItem1.nMastery.ToString("N0") + "</color>",
      "<size='28'>" + BData.GetString("UI0091") + "</size>\n" + BData.GetString("UI0013") + "\n" + BData.GetString("UI0014") + "\n" + BData.GetString("UI0015") + "\n" + BData.GetString("UI0012") + "\n" + BData.GetString("UI0101") + "\n" + BData.GetString("UI0102") + "\n" + BData.GetString("MOD010") + "\n" + BData.GetString("UI0093") + "\n" + str1,
      "<size='28'>" + (!flagArray[0] ? string.Empty : PopupWeaponSelect.strGood) + battleItem1.fDPS.ToString("######0.#") + strArray[0] + "</size>\n" + (!flagArray[1] ? string.Empty : PopupWeaponSelect.strGood) + battleItem1.fDmg.ToString("######0.#") + (battleItem1.nSpread <= 1 ? string.Empty : "x" + (object) battleItem1.nSpread) + strArray[1] + "\n" + (!flagArray[2] ? string.Empty : PopupWeaponSelect.strGood) + (1f / battleItem1.fRate).ToString("##0.##") + strArray[2] + "\n" + (!flagArray[3] ? string.Empty : PopupWeaponSelect.strGood) + battleItem1.fReload.ToString("##0.##") + strArray[3] + "\n" + (!flagArray[5] ? string.Empty : PopupWeaponSelect.strGood) + (object) battleItem1.nAmmo + strArray[5] + "\n" + (!flagArray[6] ? string.Empty : PopupWeaponSelect.strGood) + (battleItem1.fvsArmor * 100f).ToString("##0.##") + strArray[6] + "%\n" + (!flagArray[7] ? string.Empty : PopupWeaponSelect.strGood) + (battleItem1.fvsMagic * 100f).ToString("##0.##") + strArray[7] + "%\n" + (!flagArray[8] ? string.Empty : PopupWeaponSelect.strGood) + battleItem1.fSpd.ToString("N0") + strArray[8] + "\n" + (object) num + " / " + (object) pData.nMod + strArray[9]
    };
  }

  private void RefreshHighlight()
  {
    for (int index = 0; index < this.listWeapon.Count; ++index)
      this.listWeapon[index].SetHighlight(this.listWeapon[index].uid == this.nSelectedWeapon);
  }

  private void RefreshModHighlight()
  {
    if (this.eMode != PopupWeaponSelect.Mode.eModify)
      return;
    for (int index = 0; index < this.imgModCheckOff.Length; ++index)
    {
      this.imgModCheckOff[index].gameObject.SetActive(index == this.nSelectModSlot);
      this.imgModPanel[index].color = index != this.nSelectModSlot ? Color.gray : Color.white;
    }
    this.btnModA.interactable = this.nSelectModSlot != -1;
    this.btnModB.interactable = this.nSelectedWeapon != -1L && (int) Info.GetPlayerWeapon(this.nSelectedWeapon).nMod < 6;
  }

  public void OnClick(long uid)
  {
    this.nSelectMonSlot = -1;
    this.nSelectModSlot = -1;
    this.RefreshDetailRight(uid);
    this.RefreshHighlight();
    this.RefreshModHighlight();
  }

  public void OnClose()
  {
    if (this.eMode == PopupWeaponSelect.Mode.eWeaponSelect)
      UIMgr.PlaySound("Negative", false);
    else
      UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
  }

  public void OnModClick(int nSlot)
  {
    UIMgr.PlaySound("ItemPick", false);
    this.nSelectModSlot = nSlot;
    this.RefreshDetailRight(this.nSelectedWeapon);
    this.RefreshModHighlight();
  }

  public void OnNext()
  {
    if (this.nInven > Info.nMaxInven)
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0057"), true, false, string.Empty);
      this.bAutoSell = false;
    }
    else
    {
      UIMgr.RemoveTop();
      PageBattle.obj.MoveToNextDay();
    }
  }

  public void OnSellAuto()
  {
    int num = 0;
    List<long> longList = new List<long>();
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    for (int index = 0; index < playerItemDataList.Count; ++index)
    {
      PlayerItemData playerItemData = playerItemDataList[index];
      if (!Info.IsEquipped((long) playerItemDataList[index].UID) && !(bool) playerItemData.bProtected)
      {
        float fDps = Info.GetBattleItem((long) playerItemData.UID).fDPS;
        bool flag = true;
        for (int nPos = 0; nPos < 5; ++nPos)
        {
          if (Info.GetPlayerMon(nPos) != null && (long) Info.GetPlayerMon(nPos).nEquip != -1L && (Info.GetPlayerMon(nPos).dictSkill.ContainsKey(BData.GetWeapon((short) playerItemData.sID).eMastery) && (double) Info.GetBattleItem((long) Info.GetPlayerMon(nPos).nEquip).fDPS < (double) fDps))
            flag = false;
        }
        if (flag)
        {
          num += Info.GetSellPrice((int) playerItemData.nLv, (byte) playerItemData.byGrade);
          longList.Add((long) playerItemData.UID);
        }
      }
    }
    for (int index = 0; index < longList.Count; ++index)
      Info.currentSave.dictItem.Remove((ObscuredLong) longList[index]);
    this.RefreshLootItem(false);
    this.RefreshDetailRight((long) (playerItemDataList.Count <= 0 ? (ObscuredLong) -1L : playerItemDataList[0].UID));
    this.nGold += (long) num;
    if (num > 0)
      UIMgr.PlaySound("Sell", false);
    this.RefreshHighlight();
  }

  public void OnSellOnlyLegend()
  {
    int num = 0;
    List<long> longList = new List<long>();
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    for (int index = 0; index < playerItemDataList.Count; ++index)
    {
      PlayerItemData playerItemData = playerItemDataList[index];
      if (!Info.IsEquipped((long) playerItemDataList[index].UID) && !(bool) playerItemData.bProtected && (int) (byte) playerItemData.byGrade < 4)
      {
        num += Info.GetSellPrice((int) playerItemData.nLv, (byte) playerItemData.byGrade);
        longList.Add((long) playerItemData.UID);
      }
    }
    for (int index = 0; index < longList.Count; ++index)
      Info.currentSave.dictItem.Remove((ObscuredLong) longList[index]);
    this.RefreshLootItem(false);
    this.RefreshDetailRight((long) (playerItemDataList.Count <= 0 ? (ObscuredLong) -1L : playerItemDataList[0].UID));
    this.nGold += (long) num;
    if (num > 0)
      UIMgr.PlaySound("Sell", false);
    this.RefreshHighlight();
  }

  public void OnSellAll()
  {
    int num = 0;
    List<long> longList = new List<long>();
    List<PlayerItemData> playerItemDataList1 = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    for (int index = 0; index < playerItemDataList1.Count; ++index)
    {
      if (!Info.IsEquipped((long) playerItemDataList1[index].UID) && !(bool) playerItemDataList1[index].bProtected)
      {
        num += Info.GetSellPrice((int) playerItemDataList1[index].nLv, (byte) playerItemDataList1[index].byGrade);
        longList.Add((long) playerItemDataList1[index].UID);
      }
    }
    for (int index = 0; index < longList.Count; ++index)
      Info.currentSave.dictItem.Remove((ObscuredLong) longList[index]);
    List<PlayerItemData> playerItemDataList2 = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    if (this.eMode == PopupWeaponSelect.Mode.eLootItem)
      this.RefreshLootItem(false);
    else
      this.SellMode(false);
    this.RefreshDetailRight((long) (playerItemDataList2.Count <= 0 ? (ObscuredLong) -1L : playerItemDataList2[0].UID));
    this.nGold += (long) num;
    if (num > 0)
      UIMgr.PlaySound("Sell", false);
    this.RefreshHighlight();
  }

  public void OnButtonA()
  {
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eWeaponSelect:
        this.EquipOrUnequip();
        break;
      case PopupWeaponSelect.Mode.eLootItem:
        this.PlayerItemSell();
        break;
      case PopupWeaponSelect.Mode.eShop:
        this.ItemPurchase();
        break;
      case PopupWeaponSelect.Mode.eSellItem:
        this.PlayerItemSell();
        break;
      case PopupWeaponSelect.Mode.eModify:
        this.OnClose();
        break;
      case PopupWeaponSelect.Mode.eEnchant:
        this.OnClose();
        break;
      case PopupWeaponSelect.Mode.eInherit:
        this.OnInherit();
        break;
    }
  }

  public void OnButtonB()
  {
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eWeaponSelect:
      case PopupWeaponSelect.Mode.eShop:
      case PopupWeaponSelect.Mode.eSellItem:
        this.OnClose();
        break;
      case PopupWeaponSelect.Mode.eLootItem:
        this.OnNext();
        break;
      case PopupWeaponSelect.Mode.eEnchant:
        this.OnSpecialEnchant();
        break;
      case PopupWeaponSelect.Mode.eInherit:
        this.OnRebirth();
        break;
    }
  }

  public void OnButtonC()
  {
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eLootItem:
        UIMgr.popupMsg.SetYesNo("SellAuto", BData.GetString("UI0133"), false);
        break;
      case PopupWeaponSelect.Mode.eSellItem:
        UIMgr.popupMsg.SetYesNo("SellAll", BData.GetString("UI0319"), false);
        break;
      case PopupWeaponSelect.Mode.eInherit:
        this.OnClose();
        break;
    }
  }

  public void OnButtonD()
  {
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eLootItem:
      case PopupWeaponSelect.Mode.eSellItem:
        this.OnPlayerItemProtect();
        break;
    }
  }

  public void OnButtonE()
  {
    switch (this.eMode)
    {
      case PopupWeaponSelect.Mode.eLootItem:
        UIMgr.popupMsg.SetYesNo("SellAll", BData.GetString("UI0319"), false);
        break;
      case PopupWeaponSelect.Mode.eSellItem:
        UIMgr.popupMsg.SetYesNo("SellAuto", BData.GetString("UI0133"), false);
        break;
      case PopupWeaponSelect.Mode.eEnchant:
        Info.OnWeaponEqualEnchant(false);
        this.EnchantMode(this.nSelectedWeapon);
        break;
      case PopupWeaponSelect.Mode.eInherit:
        this.OnClose();
        break;
    }
  }

  private void RefreshItemSellMode()
  {
    if (this.eMode == PopupWeaponSelect.Mode.eLootItem)
      this.LootItemMode(false);
    else
      this.SellMode(false);
  }

  private void PlayerItemSell()
  {
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(this.nSelectedWeapon);
    int index1 = 0;
    if (playerWeapon == null)
      this.RefreshItemSellMode();
    else if ((bool) playerWeapon.bProtected)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0247"), true, false, string.Empty);
    }
    else
    {
      if (Info.IsEquipped(this.nSelectedWeapon))
        return;
      List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
      for (int index2 = 0; index2 < playerItemDataList.Count; ++index2)
      {
        if ((long) playerItemDataList[index2].UID == this.nSelectedWeapon)
        {
          index1 = index2;
          break;
        }
      }
      UIMgr.PlaySound("Sell", false);
      this.nGold += (long) Info.GetSellPrice((int) playerWeapon.nLv, (byte) playerWeapon.byGrade);
      Info.currentSave.dictItem.Remove((ObscuredLong) this.nSelectedWeapon);
      playerItemDataList.Remove(playerWeapon);
      if (index1 >= Info.currentSave.dictItem.Count)
        index1 = Info.currentSave.dictItem.Count - 1;
      this.RefreshItemSellMode();
      this.RefreshDetailRight((long) (Info.currentSave.dictItem.Count != 0 ? playerItemDataList[index1].UID : (ObscuredLong) -1L));
      this.RefreshHighlight();
    }
  }

  private void OnPlayerItemProtect()
  {
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(this.nSelectedWeapon);
    if (playerWeapon == null)
    {
      UIMgr.PlaySound("Negative", false);
    }
    else
    {
      playerWeapon.bProtected = (ObscuredBool) (!(bool) playerWeapon.bProtected);
      UIMgr.PlaySound(!(bool) playerWeapon.bProtected ? "Negative" : "Hire", false);
      this.RefreshItemSellMode();
      this.RefreshDetailRight((long) playerWeapon.UID);
      this.RefreshHighlight();
    }
  }

  private void ItemPurchase()
  {
    if (this.nInven > Info.nMaxInven)
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0072"), true, false, string.Empty);
    }
    else
    {
      PlayerItemData pData = (PlayerItemData) null;
      int index1 = 0;
      for (int index2 = 0; index2 < Info.currentSave.listShopItem.Count; ++index2)
      {
        if ((long) Info.currentSave.listShopItem[index2].UID == this.nSelectedWeapon)
        {
          pData = Info.currentSave.listShopItem[index2];
          index1 = index2;
          break;
        }
      }
      if (pData == null)
      {
        this.ShopMode();
      }
      else
      {
        int itemPurchasePrice = Info.GetItemPurchasePrice((int) pData.nLv, (byte) pData.byGrade);
        if (this.nGold < (long) itemPurchasePrice)
        {
          UIMgr.NotEnoughGold();
        }
        else
        {
          UIMgr.PlaySound("Sell", false);
          this.nGold -= (long) itemPurchasePrice;
          PageLobby.obj.nGold = this.nGold;
          Info.AddWeaponToInventory(pData);
          Info.currentSave.listShopItem.Remove(pData);
          if (index1 >= Info.currentSave.listShopItem.Count)
            index1 = Info.currentSave.listShopItem.Count - 1;
          this.ShopMode();
          this.RefreshDetailRight((long) (Info.currentSave.listShopItem.Count != 0 ? Info.currentSave.listShopItem[index1].UID : (ObscuredLong) -1L));
          this.RefreshHighlight();
        }
      }
    }
  }

  private void LootItemSell()
  {
    PlayerItemData playerItemData = (PlayerItemData) null;
    int index1 = 0;
    for (int index2 = 0; index2 < Info.listDropItem.Count; ++index2)
    {
      if ((long) Info.listDropItem[index2].UID == this.nSelectedWeapon)
      {
        playerItemData = Info.listDropItem[index2];
        index1 = index2;
        break;
      }
    }
    if (playerItemData == null)
      this.LootItemMode(false);
    else if ((bool) playerItemData.bProtected)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0247"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("Sell", false);
      this.nGold += (long) Info.GetSellPrice((int) playerItemData.nLv, (byte) playerItemData.byGrade);
      Info.listDropItem.Remove(playerItemData);
      if (index1 >= Info.listDropItem.Count)
        index1 = Info.listDropItem.Count - 1;
      this.LootItemMode(false);
      this.RefreshDetailRight((long) (Info.listDropItem.Count != 0 ? Info.listDropItem[index1].UID : (ObscuredLong) -1L));
      this.RefreshHighlight();
    }
  }

  private void EquipOrUnequip()
  {
    if (Info.IsEquipped(this.nSelectedWeapon) && !Info.IsEquipped((int) Info.nSelectedMonster, this.nSelectedWeapon))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0234"), true, false, string.Empty);
    }
    else
    {
      bool flag = (long) Info.GetPlayerMon((int) Info.nSelectedMonster).nEquip != this.nSelectedWeapon;
      for (int index = 0; index < 5; ++index)
      {
        if (Info.IsEquipped(index, this.nSelectedWeapon))
          Info.GetPlayerMon(index).nEquip = (ObscuredLong) -1L;
      }
      if (flag)
        Info.GetPlayerMon((int) Info.nSelectedMonster).nEquip = (ObscuredLong) this.nSelectedWeapon;
      if ((long) Info.GetPlayerMon((int) Info.nSelectedMonster).nEquip == (long) Info.currentSave.uSpecialEnchant)
        Info.currentSave.uSpecialEnchant = (ObscuredLong) -1L;
      if (flag)
        UIMgr.PlaySound("Equip", false);
      else
        UIMgr.PlaySound("Unequip", false);
      PageLobby.obj.RefreshCharUnitInfo((int) Info.nSelectedMonster);
      UIMgr.RemoveTop();
    }
  }

  public void OnRealMod()
  {
    int modCost = Info.GetModCost(this.nSelectedWeapon, this.nSelectModSlot);
    if ((long) modCost > this.nGold)
    {
      UIMgr.NotEnoughGold();
    }
    else
    {
      this.nGold -= (long) modCost;
      ItemModData randomMod = Info.GetRandomMod(this.nSelectedWeapon, this.nSelectModSlot);
      if ((int) randomMod.nModLevel >= 7)
        UIMgr.PlaySound("Fanfare", false);
      else
        UIMgr.PlaySound("LevelUp", false);
      Info.GetPlayerWeapon(this.nSelectedWeapon).arrMod[this.nSelectModSlot] = randomMod;
      Info.RefreshBattleItemData(Info.GetPlayerWeapon(this.nSelectedWeapon));
      this.RefreshDetailRight(this.nSelectedWeapon);
      this.RefreshModHighlight();
      ModData mod = BData.GetMod(randomMod.eMod);
      int nModLevel = (int) randomMod.nModLevel;
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0103") + "\n< " + BData.GetString(mod.strName) + " Lv." + (object) nModLevel + " >\n(" + BData.GetString(mod.strDesc).Replace("[1]", randomMod.fFactor.ToString("###0.##")) + ")", true, false, string.Empty);
      ++Info.currentSave.nMod;
      if ((int) Info.currentSave.nMod >= 10)
        Info.CheckAchievement(AchievementType.eModify10);
      if ((int) Info.currentSave.nMod >= 25)
        Info.CheckAchievement(AchievementType.eModify25);
      if ((int) Info.currentSave.nMod >= 50)
        Info.CheckAchievement(AchievementType.eModify50);
      if ((int) Info.currentSave.nMod >= 100)
        Info.CheckAchievement(AchievementType.eModify100);
      if ((int) Info.currentSave.nMod >= 200)
        Info.CheckAchievement(AchievementType.eModify200);
      Info.TrySaveAchievement();
    }
  }

  public void OnMod()
  {
    if ((long) Info.GetModCost(this.nSelectedWeapon, this.nSelectModSlot) > this.nGold)
      UIMgr.NotEnoughGold();
    else
      this.OnRealMod();
  }

  public void OnAddModSlot()
  {
    if ((int) Info.GetPlayerWeapon(this.nSelectedWeapon).nMod >= 6)
      return;
    if (!Info.CheckResearch(ResearchID.eSocket))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0167"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("LevelUp", false);
      ++Info.GetPlayerWeapon(this.nSelectedWeapon).nMod;
      Info.RefreshBattleItemData(Info.GetPlayerWeapon(this.nSelectedWeapon));
      this.RefreshDetailRight(this.nSelectedWeapon);
      this.RefreshModHighlight();
    }
  }

  public void OnEnchant()
  {
    Info.OnWeaponEnchant(this.nSelectedWeapon);
    this.EnchantMode(this.nSelectedWeapon);
  }

  public void OnSimpleEnchant()
  {
    Info.OnWeaponSimpleEnchant(this.nSelectedWeapon, false);
    this.EnchantMode(this.nSelectedWeapon);
  }

  public void OnMonDiff(int n)
  {
    this.nSelectMonSlot = n;
    this.RefreshDetailRight(this.nSelectedWeapon);
  }

  public void OnSpecEquip(int n)
  {
    if (Info.IsEquipped(this.nSelectedWeapon) && !Info.IsEquipped(n, this.nSelectedWeapon))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0234"), true, false, string.Empty);
    }
    else
    {
      bool flag = (long) Info.GetPlayerMon(n).nEquip != this.nSelectedWeapon;
      BattleItemData battleItem = Info.GetBattleItem(this.nSelectedWeapon);
      if (!Info.CheckWeaponMastery(n, this.nSelectedWeapon) && flag)
      {
        UIMgr.PlaySound("Negative", false);
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0041") + " : " + BData.GetString(BData.GetSkill(battleItem.eMastery).strName) + " Lv." + (object) battleItem.nMastery + "\n(" + BData.GetString("UI0051") + Info.GetSkill(n, battleItem.eMastery).ToString() + ")", true, false, string.Empty);
      }
      else
      {
        for (int index = 0; index < 5; ++index)
        {
          if (Info.IsEquipped(index, this.nSelectedWeapon))
            Info.GetPlayerMon(index).nEquip = (ObscuredLong) -1L;
        }
        if (flag)
          Info.GetPlayerMon(n).nEquip = (ObscuredLong) this.nSelectedWeapon;
        if ((long) Info.GetPlayerMon(n).nEquip == (long) Info.currentSave.uSpecialEnchant)
          Info.currentSave.uSpecialEnchant = (ObscuredLong) -1L;
        if (flag)
          UIMgr.PlaySound("Equip", false);
        else
          UIMgr.PlaySound("Unequip", false);
        long nSelectedWeapon = this.nSelectedWeapon;
        this.RefreshItemSellMode();
        this.RefreshDetailRight(nSelectedWeapon);
        this.RefreshHighlight();
      }
    }
  }

  public void OnCancelDiff()
  {
    if (this.nSelectMonSlot == -1)
      return;
    this.nSelectMonSlot = -1;
    this.RefreshDetailRight(this.nSelectedWeapon);
  }

  public void OnInherit()
  {
    if (this.nSelectedWeapon == -1L)
      return;
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(this.nSelectedWeapon);
    if (this.listInherit.Contains(playerWeapon))
    {
      UIMgr.PlaySound("Negative", false);
      this.listInherit.Remove(playerWeapon);
    }
    else
    {
      if (this.nInheritInven >= this.nMaxInherit)
      {
        UIMgr.PlaySound("Negative", false);
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0266"), true, false, string.Empty);
        return;
      }
      UIMgr.PlaySound("Hire", false);
      this.listInherit.Add(playerWeapon);
    }
    this.RefreshDetailRight(this.nSelectedWeapon);
    this.RefreshChecker();
    this.nInheritInven = this.nInheritInven;
  }

  public void OnRebirth()
  {
    UIMgr.popupMsg.SetYesNo("AskInherit", BData.GetString("UI0299").Replace("[1]", this.nInheritInven.ToString() + " / " + this.nMaxInherit.ToString()) + "\n" + BData.GetString("UI0300"), true);
  }

  public void OnRealRebirth()
  {
    Info.Rebirth(Info.currentSave, (short) Info.sSelectedRebirthCharID, Info.nSelectedDiff, true, this.listInherit);
  }

  public void RefreshChecker()
  {
    for (int index = 0; index < this.listWeapon.Count; ++index)
      this.listWeapon[index].SetChecker(this.listInherit.Contains(Info.GetPlayerWeapon(this.listWeapon[index].uid)));
  }

  public void RefreshSpecial()
  {
    for (int index = 0; index < this.listWeapon.Count; ++index)
      this.listWeapon[index].SetSpecial(this.listWeapon[index].uid == (long) Info.currentSave.uSpecialEnchant);
  }

  public void OnSpecialEnchant()
  {
    if (!Info.CheckRebirth(RebirthID.eEnchantManage))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0355"), true, false, string.Empty);
    }
    else if (Info.IsEquipped(this.nSelectedWeapon))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0234"), true, false, string.Empty);
    }
    else
    {
      if ((long) Info.GetPlayerWeapon(this.nSelectedWeapon).UID == (long) Info.currentSave.uSpecialEnchant)
      {
        Info.currentSave.uSpecialEnchant = (ObscuredLong) -1L;
        UIMgr.PlaySound("Negative", false);
      }
      else
      {
        Info.currentSave.uSpecialEnchant = (ObscuredLong) this.nSelectedWeapon;
        UIMgr.PlaySound("Hire", false);
      }
      this.RefreshDetailRight(this.nSelectedWeapon);
      this.RefreshSpecial();
    }
  }

  public void OnItemFilter()
  {
    UIMgr.AddPage("PopupTypeSelect");
    PopupTypeSelect.obj.ItemFilterType();
  }

  private enum Mode
  {
    eWeaponSelect,
    eLootItem,
    eShop,
    eSellItem,
    eModify,
    eEnchant,
    eInherit,
  }
}
