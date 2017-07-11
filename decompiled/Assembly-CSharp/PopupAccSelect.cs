// Decompiled with JetBrains decompiler
// Type: PopupAccSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupAccSelect : UIPage
{
  private List<AccElt> listAcc = new List<AccElt>();
  [HideInInspector]
  public long nSelectedAcc = -1;
  private string[] arrStrItemDescL = new string[4];
  private string[] arrStrItemDescR = new string[4];
  public static PopupAccSelect obj;
  public StringTooltip strTooltip;
  public GameObject goLeftItem;
  public GameObject goRightItem;
  public AccElt eltAccDetailL;
  public AccElt eltAccDetailR;
  public Text textItemNameL;
  public Text textItemNameR;
  public Text textItemGradeL;
  public Text textItemGradeR;
  public Text textItemDescL;
  public Text textItemDescR;
  public Text textItemOnlyL;
  public Text textItemOnlyR;
  public Text textBtnA;
  public Text textBtnB;
  public Text textBtnC;
  public Text textMedal;
  public Text textStone;
  public Text textTitle;
  public Text textEnchantMedal;
  public Text textEnchantStone;
  public GameObject objElt;
  public GameObject goMedal;
  public GameObject goStone;
  public GameObject goBtnA;
  public GameObject goBtnB;
  public GameObject goBtnC;
  public GameObject goPriceMedal;
  public GameObject goPriceStone;
  public Button btnA;
  public Button btnB;
  public RectTransform rtAccList;
  private PopupAccSelect.Mode eMode;

  private long nMedal
  {
    get
    {
      return (long) Info.rebirth.nNewMedal;
    }
    set
    {
      Info.rebirth.nNewMedal = (ObscuredLong) value;
      this.textMedal.text = Info.rebirth.nNewMedal.ToString();
    }
  }

  private long nStone
  {
    get
    {
      return (long) Info.rebirth.nNewStone;
    }
    set
    {
      Info.rebirth.nNewStone = (ObscuredLong) value;
      this.textStone.text = Info.rebirth.nNewStone.ToString();
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PopupAccSelect.obj = this;
    List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    playerAccDataList.Sort((Comparison<PlayerAccData>) ((x, y) =>
    {
      if ((int) (short) x.sID > (int) (short) y.sID)
        return 1;
      return (int) (short) x.sID < (int) (short) y.sID ? -1 : 0;
    }));
    Info.rebirth.dictAcc.Clear();
    for (int index = 0; index < playerAccDataList.Count; ++index)
      Info.rebirth.dictAcc.Add(playerAccDataList[index].UID, playerAccDataList[index]);
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((UnityEngine.Object) UIMgr.focused == (UnityEngine.Object) this))
      return;
    switch (this.eMode)
    {
      case PopupAccSelect.Mode.eAccSelect:
      case PopupAccSelect.Mode.eSellAcc:
      case PopupAccSelect.Mode.eEnchant:
        this.OnClose();
        break;
    }
  }

  public void AccSelectMode(bool bRing)
  {
    this.eMode = PopupAccSelect.Mode.eAccSelect;
    this.nMedal = this.nMedal;
    this.nStone = this.nStone;
    List<PlayerAccData> playerAccDataList1 = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    List<PlayerAccData> playerAccDataList2 = new List<PlayerAccData>();
    for (int index = 0; index < playerAccDataList1.Count; ++index)
    {
      if (bRing && BData.GetAccessory((short) playerAccDataList1[index].sID).eType != ItemType.eRing)
        playerAccDataList2.Add(playerAccDataList1[index]);
      else if (!bRing && BData.GetAccessory((short) playerAccDataList1[index].sID).eType == ItemType.eRing)
        playerAccDataList2.Add(playerAccDataList1[index]);
    }
    for (int index = 0; index < playerAccDataList2.Count; ++index)
      playerAccDataList1.Remove(playerAccDataList2[index]);
    this.ReallocElt(playerAccDataList1.Count);
    for (int index = 0; index < playerAccDataList1.Count; ++index)
    {
      this.listAcc[index].SetItem((long) playerAccDataList1[index].UID, AccElt.Type.AccSelect, 0);
      this.listAcc[index].bRing = bRing;
    }
    this.RefreshDetailAcc((long) (!bRing ? Info.GetPlayerMon((int) Info.nSelectedMonster).nAmulet : Info.GetPlayerMon((int) Info.nSelectedMonster).nRing), bRing);
    this.RefreshHighlight();
    this.RefreshButton();
  }

  public void AccSellMode()
  {
    this.eMode = PopupAccSelect.Mode.eSellAcc;
    this.nMedal = this.nMedal;
    this.nStone = this.nStone;
    List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    this.ReallocElt(playerAccDataList.Count);
    for (int index = 0; index < playerAccDataList.Count; ++index)
      this.listAcc[index].SetItem((long) playerAccDataList[index].UID, AccElt.Type.AccSelect, 0);
    this.RefreshDetailAcc(-1L, false);
    this.RefreshHighlight();
    this.RefreshButton();
    if (Info.option.bShowAccSell)
      return;
    Info.option.bShowAccSell = true;
    UIMgr.TooltipShow(BData.GetString(this.strTooltip.strTooltip));
    SaveManager.SaveOption();
  }

  public void AccEnchantMode()
  {
    this.eMode = PopupAccSelect.Mode.eEnchant;
    this.nMedal = this.nMedal;
    this.nStone = this.nStone;
    List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    this.ReallocElt(playerAccDataList.Count);
    for (int index = 0; index < playerAccDataList.Count; ++index)
      this.listAcc[index].SetItem((long) playerAccDataList[index].UID, AccElt.Type.AccSelect, 0);
    this.RefreshDetailAcc(-1L, false);
    this.RefreshHighlight();
    this.RefreshButton();
    if (Info.option.bShowAccEnchant)
      return;
    Info.option.bShowAccEnchant = true;
    UIMgr.TooltipShow(BData.GetString(this.strTooltip.strTooltip));
    SaveManager.SaveOption();
  }

  public void SellMode(bool bSort = false)
  {
    this.textBtnC.text = BData.GetString("UI0039");
    this.eMode = PopupAccSelect.Mode.eSellAcc;
    this.nMedal = this.nMedal;
    List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    this.ReallocElt(playerAccDataList.Count);
    for (int index = 0; index < playerAccDataList.Count; ++index)
      this.listAcc[index].SetItem((long) playerAccDataList[index].UID, AccElt.Type.AccSelect, 0);
    this.RefreshDetailAcc(-1L, false);
    this.RefreshHighlight();
    this.RefreshButton();
  }

  private void RefreshButton()
  {
    this.goMedal.SetActive(true);
    this.goStone.SetActive(true);
    this.goBtnC.SetActive(true);
    switch (this.eMode)
    {
      case PopupAccSelect.Mode.eAccSelect:
        this.strTooltip.gameObject.SetActive(false);
        this.textTitle.text = BData.GetString("UI0233");
        break;
      case PopupAccSelect.Mode.eEnchant:
        this.strTooltip.gameObject.SetActive(true);
        this.strTooltip.strTooltip = "UI0297";
        this.textTitle.text = BData.GetString("UI0239");
        break;
      case PopupAccSelect.Mode.eSellAcc:
        this.strTooltip.gameObject.SetActive(true);
        this.strTooltip.strTooltip = "UI0298";
        this.textTitle.text = BData.GetString("UI0241");
        break;
    }
  }

  private void ReallocElt(int nCount)
  {
    Vector2 zero = Vector2.zero;
    float num = 0.0f;
    for (int index = 0; index < nCount; ++index)
    {
      AccElt component;
      RectTransform transform;
      if (index < this.listAcc.Count)
      {
        component = this.listAcc[index];
        transform = component.transform as RectTransform;
      }
      else
      {
        component = UnityEngine.Object.Instantiate<GameObject>(this.objElt).GetComponent<AccElt>();
        transform = component.transform as RectTransform;
        transform.SetParent((Transform) this.rtAccList);
        transform.localScale = Vector3.one;
        transform.localRotation = Quaternion.identity;
        RectTransform rectTransform = transform;
        Vector2 vector2_1 = new Vector2(0.0f, 0.5f);
        transform.anchorMax = vector2_1;
        Vector2 vector2_2 = vector2_1;
        transform.anchorMin = vector2_2;
        Vector2 vector2_3 = vector2_2;
        rectTransform.pivot = vector2_3;
        this.listAcc.Add(component);
      }
      component.gameObject.SetActive(true);
      num = zero.x = (float) (10 + 112 * index);
      zero.y = 0.0f;
      transform.anchoredPosition = zero;
    }
    this.rtAccList.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num + 112f);
    if (nCount >= this.listAcc.Count)
      return;
    for (int index = nCount; index < this.listAcc.Count; ++index)
      this.listAcc[index].gameObject.SetActive(false);
  }

  public void RefreshDetailAcc(long uid, bool bRing = false)
  {
    this.nSelectedAcc = uid;
    bool flag1 = false;
    for (int index = 0; index < this.arrStrItemDescL.Length; ++index)
    {
      this.arrStrItemDescL[index] = string.Empty;
      this.arrStrItemDescR[index] = string.Empty;
    }
    bool flag2 = Info.IsEquippedAcc(uid);
    PlayerAccData playerAccData = (PlayerAccData) null;
    PlayerAccData pData = (PlayerAccData) null;
    if (this.eMode == PopupAccSelect.Mode.eAccSelect)
    {
      long uid1 = (long) (!bRing ? Info.GetPlayerMon((int) Info.nSelectedMonster).nAmulet : Info.GetPlayerMon((int) Info.nSelectedMonster).nRing);
      if (uid1 != -1L)
        pData = Info.GetPlayerAcc(uid1);
    }
    this.eltAccDetailR.bRing = this.eltAccDetailL.bRing = bRing;
    this.goRightItem.SetActive(true);
    this.eltAccDetailL.SetItem(-1L, AccElt.Type.JustShow, 0);
    int nPlusLv = 0;
    switch (this.eMode)
    {
      case PopupAccSelect.Mode.eAccSelect:
      case PopupAccSelect.Mode.eSellAcc:
        playerAccData = Info.GetPlayerAcc(uid);
        this.eltAccDetailR.SetItem(uid, AccElt.Type.JustShow, 0);
        break;
      case PopupAccSelect.Mode.eEnchant:
        playerAccData = Info.GetPlayerAcc(uid);
        pData = Info.GetPlayerAcc(uid);
        if (playerAccData != null && (int) playerAccData.nLv < 10)
          nPlusLv = 1;
        this.eltAccDetailR.SetItem(uid, AccElt.Type.JustShow, nPlusLv);
        break;
    }
    this.goLeftItem.SetActive(pData != null);
    this.textItemGradeR.color = Color.white;
    this.goPriceMedal.SetActive(false);
    this.goPriceStone.SetActive(false);
    bool flag3 = true;
    if (playerAccData != null)
    {
      AccData accessory = BData.GetAccessory((short) playerAccData.sID);
      if (this.eMode == PopupAccSelect.Mode.eAccSelect)
      {
        if (flag2)
          flag1 = Info.IsEquippedAcc((int) Info.nSelectedMonster, this.nSelectedAcc);
        flag3 = (int) accessory.sOnly == (int) (short) Info.GetPlayerMon((int) Info.nSelectedMonster).sID || (int) accessory.sOnly == -1;
      }
      this.textItemGradeR.color = Info.GetGradeColor((byte) accessory.nGrade);
      this.arrStrItemDescR[0] = BData.GetString(accessory.strName) + " Lv." + ((int) playerAccData.nLv != 10 ? ((int) playerAccData.nLv + nPlusLv).ToString() : "Max");
      this.arrStrItemDescR[1] = Info.GetGradeString((byte) accessory.nGrade, false);
      this.arrStrItemDescR[2] = Info.GetAccDesc(accessory.sID, (int) playerAccData.nLv + nPlusLv);
      this.arrStrItemDescR[3] = (int) accessory.sOnly != -1 ? BData.GetString("UI0235").Replace("[1]", "'" + BData.GetString(BData.GetMonster(accessory.sOnly).strName) + "'") : string.Empty;
      this.textItemOnlyR.color = !flag3 ? Color.red : Color.white;
      if (this.eMode == PopupAccSelect.Mode.eEnchant)
      {
        this.goPriceMedal.SetActive(true);
        this.goPriceStone.SetActive(true);
        this.textEnchantMedal.text = Info.nAccEnchantMedal[accessory.nGrade, (int) playerAccData.nLv].ToString();
        this.textEnchantStone.text = Info.nAccEnchantStone[accessory.nGrade, (int) playerAccData.nLv].ToString();
      }
      else if (this.eMode == PopupAccSelect.Mode.eSellAcc)
      {
        this.goPriceMedal.SetActive(true);
        this.textEnchantMedal.text = Mathf.RoundToInt((float) (int) Info.nAccEnchantMedal[accessory.nGrade, (int) playerAccData.nLv] * 0.7f).ToString();
      }
    }
    this.textItemNameR.text = this.arrStrItemDescR[0];
    this.textItemGradeR.text = this.arrStrItemDescR[1];
    this.textItemDescR.text = this.arrStrItemDescR[2];
    this.textItemOnlyR.text = this.arrStrItemDescR[3];
    bool flag4 = true;
    if (pData != null)
    {
      AccData accessory = BData.GetAccessory((short) pData.sID);
      this.eltAccDetailL.SetItem(pData, AccElt.Type.JustShow, 0);
      this.textItemGradeL.color = Info.GetGradeColor((byte) accessory.nGrade);
      if (this.eMode == PopupAccSelect.Mode.eAccSelect)
        flag4 = (int) accessory.sOnly == (int) (short) Info.GetPlayerMon((int) Info.nSelectedMonster).sID || (int) accessory.sOnly == -1;
      this.arrStrItemDescL[0] = BData.GetString(accessory.strName) + " Lv." + ((int) pData.nLv != 10 ? pData.nLv.ToString() : "Max");
      this.arrStrItemDescL[1] = Info.GetGradeString((byte) accessory.nGrade, false);
      this.arrStrItemDescL[2] = Info.GetAccDesc(accessory.sID, (int) pData.nLv);
      this.arrStrItemDescL[3] = (int) accessory.sOnly != -1 ? BData.GetString("UI0235").Replace("[1]", "'" + BData.GetString(BData.GetMonster(accessory.sOnly).strName) + "'") : string.Empty;
      this.textItemOnlyL.color = !flag4 ? Color.red : Color.white;
    }
    this.textItemNameL.text = this.arrStrItemDescL[0];
    this.textItemGradeL.text = this.arrStrItemDescL[1];
    this.textItemDescL.text = this.arrStrItemDescL[2];
    this.textItemOnlyL.text = this.arrStrItemDescL[3];
    this.textBtnC.text = playerAccData == null || !(bool) playerAccData.bProtected ? BData.GetString("UI0245") : BData.GetString("UI0246");
    switch (this.eMode)
    {
      case PopupAccSelect.Mode.eAccSelect:
        this.btnA.interactable = (uid != -1L || flag2 && flag1) && flag3;
        this.btnB.interactable = true;
        this.textBtnA.text = !Info.IsEquippedAcc((int) Info.nSelectedMonster, this.nSelectedAcc) ? BData.GetString("UI0042") : BData.GetString("UI0043");
        this.textBtnB.text = BData.GetString("UI0094");
        break;
      case PopupAccSelect.Mode.eEnchant:
        this.btnA.interactable = nPlusLv > 0;
        this.textBtnA.text = BData.GetString("UI0100");
        this.textBtnB.text = BData.GetString("UI0094");
        break;
      case PopupAccSelect.Mode.eSellAcc:
        this.btnA.interactable = playerAccData != null;
        this.textBtnA.text = BData.GetString("UI0016");
        this.textBtnB.text = BData.GetString("UI0094");
        break;
    }
  }

  private void RefreshHighlight()
  {
    for (int index = 0; index < this.listAcc.Count; ++index)
      this.listAcc[index].SetHighlight(this.listAcc[index].uid == this.nSelectedAcc);
  }

  public void OnClick(long uid, bool bRing)
  {
    this.RefreshDetailAcc(uid, bRing);
    this.RefreshHighlight();
  }

  public void OnClose()
  {
    if (this.eMode == PopupAccSelect.Mode.eAccSelect)
      UIMgr.PlaySound("Negative", false);
    else
      UIMgr.PlaySound("DoorClose", false);
    if (Info.bRebirthChanged)
      SaveManager.SaveRebirth();
    Info.RefreshAccMod();
    UIMgr.RemoveTop();
  }

  public void OnButtonA()
  {
    switch (this.eMode)
    {
      case PopupAccSelect.Mode.eAccSelect:
        this.EquipOrUnequip();
        break;
      case PopupAccSelect.Mode.eEnchant:
        this.OnAccEnchant();
        break;
      case PopupAccSelect.Mode.eSellAcc:
        this.PlayerItemSell();
        break;
    }
  }

  public void OnButtonB()
  {
    switch (this.eMode)
    {
      case PopupAccSelect.Mode.eAccSelect:
      case PopupAccSelect.Mode.eEnchant:
      case PopupAccSelect.Mode.eSellAcc:
        this.OnClose();
        break;
    }
  }

  public void OnButtonC()
  {
    this.OnProtect();
  }

  private void OnProtect()
  {
    PlayerAccData playerAcc = Info.GetPlayerAcc(this.nSelectedAcc);
    if (playerAcc == null)
      return;
    playerAcc.bProtected = (ObscuredBool) (!(bool) playerAcc.bProtected);
    UIMgr.PlaySound(!(bool) playerAcc.bProtected ? "Negative" : "Hire", false);
    this.RefreshDetailAcc(this.nSelectedAcc, false);
    bool flag = BData.GetAccessory((short) playerAcc.sID).eType == ItemType.eRing;
    List<PlayerAccData> playerAccDataList1 = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    if (this.eMode == PopupAccSelect.Mode.eAccSelect)
    {
      List<PlayerAccData> playerAccDataList2 = new List<PlayerAccData>();
      for (int index = 0; index < playerAccDataList1.Count; ++index)
      {
        if (flag && BData.GetAccessory((short) playerAccDataList1[index].sID).eType != ItemType.eRing)
          playerAccDataList2.Add(playerAccDataList1[index]);
        else if (!flag && BData.GetAccessory((short) playerAccDataList1[index].sID).eType == ItemType.eRing)
          playerAccDataList2.Add(playerAccDataList1[index]);
      }
      for (int index = 0; index < playerAccDataList2.Count; ++index)
        playerAccDataList1.Remove(playerAccDataList2[index]);
    }
    for (int index = 0; index < playerAccDataList1.Count; ++index)
      this.listAcc[index].SetItem((long) playerAccDataList1[index].UID, AccElt.Type.AccSelect, 0);
    this.RefreshHighlight();
  }

  private void PlayerItemSell()
  {
    PlayerAccData playerAcc = Info.GetPlayerAcc(this.nSelectedAcc);
    int index1 = 0;
    if (playerAcc == null)
      return;
    if (Info.IsEquippedAcc(this.nSelectedAcc))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0234"), true, false, string.Empty);
    }
    else if ((bool) playerAcc.bProtected)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0247"), true, false, string.Empty);
    }
    else
    {
      AccData accessory = BData.GetAccessory((short) playerAcc.sID);
      List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
      for (int index2 = 0; index2 < playerAccDataList.Count; ++index2)
      {
        if ((long) playerAccDataList[index2].UID == this.nSelectedAcc)
        {
          index1 = index2;
          break;
        }
      }
      UIMgr.PlaySound("Sell", false);
      this.nMedal += (long) Mathf.RoundToInt((float) (int) Info.nAccEnchantMedal[accessory.nGrade, (int) playerAcc.nLv] * 0.7f);
      Info.rebirth.dictAcc.Remove((ObscuredLong) this.nSelectedAcc);
      playerAccDataList.Remove(playerAcc);
      if (index1 >= Info.rebirth.dictAcc.Count)
        index1 = Info.rebirth.dictAcc.Count - 1;
      this.SellMode(false);
      this.RefreshDetailAcc((long) (Info.rebirth.dictAcc.Count != 0 ? playerAccDataList[index1].UID : (ObscuredLong) -1L), false);
      this.RefreshHighlight();
      Info.bRebirthChanged = true;
    }
  }

  private void EquipOrUnequip()
  {
    if (Info.IsEquippedAcc(this.nSelectedAcc) && !Info.IsEquippedAcc((int) Info.nSelectedMonster, this.nSelectedAcc))
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0234"), true, false, string.Empty);
    }
    else
    {
      bool flag1 = BData.GetAccessory((short) Info.GetPlayerAcc(this.nSelectedAcc).sID).eType == ItemType.eRing;
      bool flag2 = !Info.IsEquippedAcc((int) Info.nSelectedMonster, this.nSelectedAcc);
      if (flag2)
      {
        if (flag1)
          Info.GetPlayerMon((int) Info.nSelectedMonster).nRing = (ObscuredLong) this.nSelectedAcc;
        else
          Info.GetPlayerMon((int) Info.nSelectedMonster).nAmulet = (ObscuredLong) this.nSelectedAcc;
      }
      else if (flag1)
        Info.GetPlayerMon((int) Info.nSelectedMonster).nRing = (ObscuredLong) -1L;
      else
        Info.GetPlayerMon((int) Info.nSelectedMonster).nAmulet = (ObscuredLong) -1L;
      if (flag2)
        UIMgr.PlaySound("Equip", false);
      else
        UIMgr.PlaySound("Unequip", false);
      Info.RefreshAccMod();
      PageLobby.obj.RefreshCharUnitInfo((int) Info.nSelectedMonster);
      UIMgr.RemoveTop();
    }
  }

  public void OnAccEnchant()
  {
    PlayerAccData playerAcc = Info.GetPlayerAcc(this.nSelectedAcc);
    AccData accessory = BData.GetAccessory((short) playerAcc.sID);
    int num1 = (int) Info.nAccEnchantMedal[accessory.nGrade, (int) playerAcc.nLv];
    int num2 = (int) Info.nAccEnchantStone[accessory.nGrade, (int) playerAcc.nLv];
    if ((int) playerAcc.nLv >= 10)
      return;
    if (this.nMedal < (long) num1)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0240"), true, false, string.Empty);
    }
    else if (this.nStone < (long) num2)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0174"), true, false, string.Empty);
    }
    else
    {
      this.nMedal -= (long) num1;
      this.nStone -= (long) num2;
      ++playerAcc.nLv;
      UIMgr.PlaySound("Hire", false);
      Info.bRebirthChanged = true;
      this.RefreshDetailAcc(this.nSelectedAcc, false);
      List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
      for (int index = 0; index < playerAccDataList.Count; ++index)
        this.listAcc[index].SetItem((long) playerAccDataList[index].UID, AccElt.Type.AccSelect, 0);
      this.RefreshHighlight();
    }
  }

  private enum Mode
  {
    eAccSelect,
    eSellAcc,
    eEnchant,
  }
}
