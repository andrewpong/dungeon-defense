// Decompiled with JetBrains decompiler
// Type: WeaponElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class WeaponElt : MonoBehaviour
{
  public Image imgIcon;
  public Image imgFrame;
  public Button btnFrame;
  public Text textLv;
  public GameObject goEquip;
  public GameObject goBlank;
  public GameObject goHighlight;
  public GameObject goLock;
  public GameObject goChecker;
  public GameObject goNew;
  public GameObject goSpecial;
  [HideInInspector]
  public WeaponElt.Type eType;
  [HideInInspector]
  public long uid;

  public void SetItemByID(short sID, WeaponElt.Type _eType = WeaponElt.Type.JustShow)
  {
    this.uid = -1L;
    this.textLv.text = string.Empty;
    this.imgFrame.color = Color.white;
    this.imgIcon.sprite = RSMgr.GetSprite(BData.GetWeapon(sID).strSprite);
    this.goEquip.SetActive(false);
    this.goBlank.SetActive(false);
    this.goHighlight.SetActive(false);
    this.goLock.SetActive(false);
    this.goSpecial.SetActive(false);
    this.goChecker.SetActive(false);
    this.goNew.SetActive(false);
    this.SetType(_eType);
  }

  public void SetItem(long _uid, WeaponElt.Type _eType = WeaponElt.Type.JustShow, int nPlusLv = 0)
  {
    this.uid = _uid;
    this.SetType(_eType);
    if (!Info.currentSave.dictItem.ContainsKey((ObscuredLong) this.uid))
    {
      this.textLv.text = string.Empty;
      this.goEquip.SetActive(false);
      this.goHighlight.SetActive(false);
      this.goBlank.SetActive(true);
      this.goLock.SetActive(false);
      this.goSpecial.SetActive(false);
      this.goChecker.SetActive(false);
      this.goNew.SetActive(false);
    }
    else
    {
      this.SetItem(Info.GetPlayerWeapon(this.uid), this.eType, nPlusLv);
      this.goEquip.SetActive(Info.IsEquipped(this.uid));
    }
  }

  public void SetItem(PlayerItemData pData, WeaponElt.Type _eType, int nPlusLv = 0)
  {
    this.uid = (long) pData.UID;
    this.SetType(_eType);
    this.textLv.text = "L" + (object) ((int) pData.nLv + nPlusLv);
    this.imgFrame.color = Info.GetGradeColor((byte) pData.byGrade);
    this.imgIcon.sprite = RSMgr.GetSprite(BData.GetWeapon((short) pData.sID).strSprite);
    this.goSpecial.SetActive(this.uid == (long) Info.currentSave.uSpecialEnchant);
    this.goLock.SetActive((bool) pData.bProtected);
    this.goEquip.SetActive(false);
    this.goBlank.SetActive(false);
    this.goHighlight.SetActive(false);
    this.goChecker.SetActive(false);
    this.goNew.SetActive(false);
  }

  public void SetHighlight(bool bEnable)
  {
    this.goHighlight.SetActive(bEnable);
  }

  public void SetChecker(bool bCheck)
  {
    this.goChecker.SetActive(bCheck);
  }

  public void SetSpecial(bool bSpecial)
  {
    this.goSpecial.SetActive(bSpecial);
  }

  public void SetNew(bool bNew)
  {
    this.goNew.SetActive(bNew);
  }

  private void SetType(WeaponElt.Type type)
  {
    this.eType = type;
    this.btnFrame.interactable = type != WeaponElt.Type.JustShow;
  }

  public void OnClick()
  {
    if (this.eType != WeaponElt.Type.JustShow)
      UIMgr.PlaySound("ItemPick", false);
    switch (this.eType)
    {
      case WeaponElt.Type.CharEquip:
        UIMgr.AddPage("PopupWeaponSelect");
        PopupWeaponSelect.obj.WeaponSelectMode();
        break;
      case WeaponElt.Type.WeaponSelect:
      case WeaponElt.Type.LootItem:
      case WeaponElt.Type.Shop:
      case WeaponElt.Type.SellItem:
        if (!(bool) ((Object) PopupWeaponSelect.obj))
          break;
        PopupWeaponSelect.obj.OnClick(this.uid);
        break;
    }
  }

  public enum Type
  {
    JustShow,
    CharEquip,
    WeaponSelect,
    LootItem,
    Shop,
    SellItem,
  }
}
