// Decompiled with JetBrains decompiler
// Type: PopupAccBook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupAccBook : UIPage
{
  private List<AccElt> listAcc = new List<AccElt>();
  [HideInInspector]
  public short sSelectedAcc = -1;
  private List<short> listAccID = new List<short>();
  private string[] arrStrItemDescR = new string[4];
  public static PopupAccBook obj;
  public AccElt eltAccDetail;
  public Text textItemName;
  public Text textItemGrade;
  public Text textItemDesc;
  public Text textItemOnly;
  public Text textItemSource;
  public Text textBtnA;
  public Text textBtnB;
  public Text textMedal;
  public Text textStone;
  public Text textRuby;
  public Text textTitle;
  public Text textPrice;
  public Text textMedalNeed;
  public Text textBookDesc;
  public Text textItemOwn;
  public GameObject objElt;
  public GameObject goMedal;
  public GameObject goStone;
  public GameObject goRuby;
  public GameObject goItemOwn;
  public Button btnA;
  public Button btnB;
  public RectTransform rtAccList;

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

  private int nRuby
  {
    get
    {
      return (int) Info.rebirth.nRuby;
    }
    set
    {
      Info.rebirth.nRuby = (ObscuredInt) value;
      this.textRuby.text = Info.rebirth.nRuby.ToString();
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PopupAccBook.obj = this;
    this.textBookDesc.text = BData.GetString("UI0286");
    this.textTitle.text = BData.GetString("UI0287");
    this.textBtnB.text = BData.GetString("UI0094");
    this.textItemOwn.text = BData.GetString("UI0289");
    this.nMedal = this.nMedal;
    this.nStone = this.nStone;
    this.nRuby = this.nRuby;
    this.listAccID = new List<short>((IEnumerable<short>) BData.dictAcc.Keys);
    this.ReallocElt(this.listAccID.Count);
    for (int index = 0; index < this.listAccID.Count; ++index)
      this.listAcc[index].SetItemByID(this.listAccID[index], AccElt.Type.AccBook);
    this.RefreshDetailAcc((short) -1);
    this.RefreshHighlight();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
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
        component = Object.Instantiate<GameObject>(this.objElt).GetComponent<AccElt>();
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

  public void RefreshDetailAcc(short sID)
  {
    this.sSelectedAcc = sID;
    for (int index = 0; index < this.arrStrItemDescR.Length; ++index)
      this.arrStrItemDescR[index] = string.Empty;
    bool flag1 = Info.IsOwnedAcc(this.sSelectedAcc);
    this.goItemOwn.SetActive(flag1);
    bool flag2 = false;
    AccData accData = (AccData) null;
    if ((int) this.sSelectedAcc != -1)
      accData = BData.GetAccessory(this.sSelectedAcc);
    this.eltAccDetail.SetItemByID(this.sSelectedAcc, AccElt.Type.JustShow);
    Text textPrice = this.textPrice;
    string empty = string.Empty;
    this.textItemSource.text = empty;
    string str = empty;
    textPrice.text = str;
    this.textItemGrade.color = Color.white;
    bool flag3 = true;
    bool flag4 = true;
    if (accData != null)
    {
      switch (accData.eDrop)
      {
        case AccDropType.eDrop:
          this.textItemSource.text = BData.GetString("UI0285").Replace("[1]", BData.GetString("UI0214"));
          flag2 = !flag1;
          break;
        case AccDropType.eAchieve:
          this.textItemSource.text = BData.GetString("UI0285").Replace("[1]", BData.GetString("UI0005"));
          flag2 = !flag1 && (accData.eAchieve == AchievementType.eNone || Info.achievement.listAcv.Contains(accData.eAchieve));
          break;
        case AccDropType.ePurchase:
          this.textItemSource.text = BData.GetString("UI0285").Replace("[1]", "???");
          break;
      }
      flag4 = accData.bSell;
      this.textItemGrade.color = Info.GetGradeColor((byte) accData.nGrade);
      this.arrStrItemDescR[0] = BData.GetString(accData.strName);
      this.arrStrItemDescR[1] = Info.GetGradeString((byte) accData.nGrade, false);
      this.arrStrItemDescR[2] = Info.GetAccDesc(accData.sID, 0);
      this.arrStrItemDescR[3] = (int) accData.sOnly != -1 ? BData.GetString("UI0235").Replace("[1]", "'" + BData.GetString(BData.GetMonster(accData.sOnly).strName) + "'") : string.Empty;
      this.textItemOnly.color = !flag3 ? Color.red : Color.white;
      this.textPrice.text = accData.nPrice.ToString();
      this.textMedalNeed.text = Mathf.RoundToInt((float) (int) Info.nAccEnchantMedal[accData.nGrade, 0]).ToString();
      this.goRuby.SetActive(accData.eType == ItemType.eRing);
    }
    this.textItemName.text = this.arrStrItemDescR[0];
    this.textItemGrade.text = this.arrStrItemDescR[1];
    this.textItemDesc.text = this.arrStrItemDescR[2];
    this.textItemOnly.text = this.arrStrItemDescR[3];
    this.btnA.interactable = flag2 && flag4;
    this.btnB.interactable = true;
    this.textBtnA.text = !flag4 ? BData.GetString("UI0288") : BData.GetString("UI0071");
  }

  private void RefreshHighlight()
  {
    for (int index = 0; index < this.listAcc.Count; ++index)
      this.listAcc[index].SetHighlight((int) this.listAcc[index].sID == (int) this.sSelectedAcc);
  }

  public void OnClick(short sID)
  {
    this.RefreshDetailAcc(sID);
    this.RefreshHighlight();
  }

  public void OnClose()
  {
    UIMgr.PlaySound("DoorClose", false);
    if (Info.bRebirthChanged)
      SaveManager.SaveRebirth();
    Info.RefreshAccMod();
    UIMgr.RemoveTop();
  }

  public void OnButtonB()
  {
    this.OnClose();
  }

  public void OnPurchase()
  {
    AccData accessory = BData.GetAccessory(this.sSelectedAcc);
    if (accessory == null)
      return;
    int nPrice = accessory.nPrice;
    int num = Mathf.RoundToInt((float) (int) Info.nAccEnchantMedal[accessory.nGrade, 0]);
    bool flag1 = accessory.eType == ItemType.eAmulet;
    if (flag1 && this.nStone < (long) nPrice)
      UIMgr.NotEnoughStone();
    else if (!flag1 && this.nRuby < nPrice)
      UIMgr.NotEnoughRuby();
    else if (this.nMedal < (long) num)
    {
      UIMgr.NotEnoughMedal();
    }
    else
    {
      bool flag2 = Info.IsOwnedAcc(this.sSelectedAcc);
      bool flag3 = true;
      if (accessory.eAchieve != AchievementType.eNone)
        flag3 = Info.achievement.listAcv.Contains(accessory.eAchieve);
      if (flag2 || !flag3)
        return;
      PlayerAccData newAcc = Info.GetNewAcc(this.sSelectedAcc);
      if (flag1)
        this.nStone -= (long) nPrice;
      else
        this.nRuby -= nPrice;
      this.nMedal -= (long) num;
      Info.rebirth.dictAcc.Add(newAcc.UID, newAcc);
      Info.bRebirthChanged = true;
      UIMgr.PlaySound("Sell", false);
      this.RefreshDetailAcc(this.sSelectedAcc);
    }
  }
}
