// Decompiled with JetBrains decompiler
// Type: AccElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class AccElt : MonoBehaviour
{
  public Image imgIcon;
  public Image imgFrame;
  public Button btnFrame;
  public Text textLv;
  public GameObject goEquip;
  public GameObject goBlank;
  public GameObject goBlankRing;
  public GameObject goHighlight;
  public GameObject goLock;
  public bool bRing;
  [HideInInspector]
  public AccElt.Type eType;
  [HideInInspector]
  public long uid;
  [HideInInspector]
  public short sID;

  public void SetItemByID(short _sID, AccElt.Type _eType = AccElt.Type.JustShow)
  {
    this.sID = _sID;
    this.uid = -1L;
    this.textLv.text = string.Empty;
    this.imgFrame.color = Color.white;
    bool flag = (int) this.sID == -1;
    if (!flag)
    {
      this.imgFrame.color = Info.GetGradeColor((byte) BData.GetAccessory(this.sID).nGrade);
      this.imgIcon.sprite = RSMgr.GetSprite(BData.GetAccessory(this.sID).strSprite);
    }
    this.goEquip.SetActive(false);
    this.goBlank.SetActive(flag);
    this.goBlankRing.SetActive(false);
    this.goHighlight.SetActive(false);
    this.goLock.SetActive(false);
    this.SetType(_eType);
  }

  public void SetItem(long _uid, AccElt.Type _eType = AccElt.Type.JustShow, int nPlusLv = 0)
  {
    this.uid = _uid;
    this.SetType(_eType);
    if (Info.GetPlayerAcc(this.uid) == null)
    {
      this.textLv.text = string.Empty;
      this.goEquip.SetActive(false);
      this.goHighlight.SetActive(false);
      this.goBlank.SetActive(!this.bRing);
      this.goBlankRing.SetActive(this.bRing);
      this.goLock.SetActive(false);
      if (!this.bRing || Info.CheckRebirth(RebirthID.eRingUnlock))
        return;
      this.goLock.SetActive(true);
    }
    else
    {
      this.SetItem(Info.GetPlayerAcc(this.uid), this.eType, nPlusLv);
      this.goEquip.SetActive(Info.IsEquippedAcc(this.uid));
    }
  }

  public void SetItem(PlayerAccData pData, AccElt.Type _eType, int nPlusLv = 0)
  {
    this.uid = (long) pData.UID;
    this.SetType(_eType);
    this.textLv.text = "L" + (object) ((int) pData.nLv + nPlusLv);
    this.imgFrame.color = Info.GetGradeColor((byte) BData.GetAccessory((short) pData.sID).nGrade);
    this.imgIcon.sprite = RSMgr.GetSprite(BData.GetAccessory((short) pData.sID).strSprite);
    this.goEquip.SetActive(false);
    this.goBlank.SetActive(false);
    this.goBlankRing.SetActive(false);
    this.goHighlight.SetActive(false);
    this.goLock.SetActive((bool) pData.bProtected);
  }

  public void SetHighlight(bool bEnable)
  {
    this.goHighlight.SetActive(bEnable);
  }

  private void SetType(AccElt.Type type)
  {
    this.eType = type;
    this.btnFrame.interactable = type != AccElt.Type.JustShow;
  }

  public void OnClick()
  {
    if (this.eType != AccElt.Type.JustShow)
      UIMgr.PlaySound("ItemPick", false);
    switch (this.eType)
    {
      case AccElt.Type.CharEquip:
        if (this.bRing && !Info.CheckRebirth(RebirthID.eRingUnlock))
        {
          UIMgr.popupMsg.SetMsg(BData.GetString("UI0262"), true, false, string.Empty);
          break;
        }
        UIMgr.AddPage("PopupAccSelect");
        PopupAccSelect.obj.AccSelectMode(this.bRing);
        break;
      case AccElt.Type.AccSelect:
        if (!(bool) ((Object) PopupAccSelect.obj))
          break;
        PopupAccSelect.obj.OnClick(this.uid, this.bRing);
        break;
      case AccElt.Type.AccBook:
        if (!(bool) ((Object) PopupAccBook.obj))
          break;
        PopupAccBook.obj.OnClick(this.sID);
        break;
    }
  }

  public enum Type
  {
    JustShow,
    CharEquip,
    AccSelect,
    AccBook,
  }
}
