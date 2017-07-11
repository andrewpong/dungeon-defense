// Decompiled with JetBrains decompiler
// Type: PopupMonsterTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class PopupMonsterTrait : UIPage
{
  public static PopupMonsterTrait obj;
  public GameObject[] arrCharacterTree;
  public MonTraitElt[] arrMonTraitElt;
  public Text textTitle;
  public Image imgBackMonster;
  public Image imgDetailMonsterIcon;
  public Image imgDetailTraitIcon;
  public Text textDetailTraitName;
  public Text textDetailTraitDesc;
  public Text textDetailTraitWarn;
  public Text textDetailLearnBtn;
  public Button btnDetailLearn;
  public Text textTraitPoints;
  public Text textInitButton;
  public Text textInitNeed;
  public GameObject goInitNeed;
  public GameObject goInitButton;
  private MonTraitElt currentElt;
  private int nCurrentMon;

  protected override void Awake()
  {
    base.Awake();
    PopupMonsterTrait.obj = this;
    this.textTitle.text = BData.GetString("UI0402");
    PlayerMonsterData playerMon = Info.GetPlayerMon((int) Info.nSelectedMonster);
    if (playerMon != null)
      this.nCurrentMon = (int) (short) playerMon.sID;
    this.RefreshTree();
    this.RefreshDetail((MonTraitElt) null);
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void MoveTree(int n)
  {
    UIMgr.PlaySound("Character", false);
    this.nCurrentMon += n;
    if (this.nCurrentMon >= BData.dictMonster.Count)
      this.nCurrentMon = 0;
    else if (this.nCurrentMon < 0)
      this.nCurrentMon = BData.dictMonster.Count - 1;
    this.RefreshTree();
    this.RefreshDetail((MonTraitElt) null);
  }

  public void RefreshTree()
  {
    short nCurrentMon = (short) this.nCurrentMon;
    for (int index = 0; index < this.arrCharacterTree.Length; ++index)
      this.arrCharacterTree[index].SetActive(index == this.nCurrentMon);
    for (int index = 0; index < this.arrMonTraitElt.Length; ++index)
    {
      if (this.arrMonTraitElt[index].nMonID == this.nCurrentMon)
        this.arrMonTraitElt[index].Refresh();
    }
    int rebirthLevel = Info.GetRebirthLevel(nCurrentMon);
    int spendRebirthPoint = Info.GetSpendRebirthPoint(nCurrentMon);
    Image detailMonsterIcon = this.imgDetailMonsterIcon;
    Sprite sprite1 = RSMgr.GetSprite(BData.GetMonster(nCurrentMon).strSprite);
    this.imgBackMonster.sprite = sprite1;
    Sprite sprite2 = sprite1;
    detailMonsterIcon.sprite = sprite2;
    this.textTraitPoints.text = BData.GetString("UI0404") + " : " + rebirthLevel.ToString() + " (" + Info.GetNeedRebirthExpRate(nCurrentMon).ToString("P1") + ")\n" + BData.GetString("UI0368") + " : <color='#44ff00'>" + (rebirthLevel - spendRebirthPoint).ToString() + "</color>\n" + BData.GetString("UI0369") + " : <color='red'>" + spendRebirthPoint.ToString() + "</color>";
  }

  public void RefreshDetail(MonTraitElt elt)
  {
    this.imgDetailTraitIcon.enabled = (Object) elt != (Object) null;
    if ((Object) elt == (Object) null)
    {
      this.textDetailTraitName.text = string.Empty;
      this.textDetailTraitDesc.text = string.Empty;
      this.textDetailTraitWarn.text = string.Empty;
      this.textDetailLearnBtn.text = string.Empty;
      this.btnDetailLearn.interactable = false;
    }
    else
    {
      short nMonId = (short) elt.nMonID;
      MonTraitID eId = elt.eID;
      MonTraitData monTrait1 = BData.GetMonTrait(eId);
      int monTrait2 = Info.GetMonTrait(nMonId, eId);
      bool flag = monTrait1.nMax <= monTrait2;
      float num1 = monTrait1.fFac1 + monTrait1.fGrow1 * (float) monTrait2;
      float num2 = monTrait1.fFac2 + monTrait1.fGrow2 * (float) monTrait2;
      float num3 = monTrait1.fFac3 + monTrait1.fGrow3 * (float) monTrait2;
      this.imgDetailTraitIcon.sprite = RSMgr.GetSprite(monTrait1.strIcon);
      this.textDetailTraitName.text = BData.GetString(monTrait1.strName) + " (" + monTrait2.ToString() + "/" + monTrait1.nMax.ToString() + ")";
      this.textDetailTraitDesc.text = BData.GetString(monTrait1.strDesc).Replace("[1]", num1.ToString("N0") + (!flag ? " (" + ((double) monTrait1.fGrow1 <= 0.0 ? "-" : "+") + monTrait1.fGrow1.ToString("N0") + ")" : string.Empty)).Replace("[2]", num2.ToString("N0") + (!flag ? " (" + ((double) monTrait1.fGrow2 <= 0.0 ? "-" : "+") + monTrait1.fGrow2.ToString("N0") + ")" : string.Empty)).Replace("[3]", num3.ToString("N0") + (!flag ? " (" + ((double) monTrait1.fGrow3 <= 0.0 ? "-" : "+") + monTrait1.fGrow3.ToString("N0") + ")" : string.Empty));
      this.textDetailTraitWarn.text = Info.GetSpendRebirthPoint(nMonId) >= elt.nPreLearn ? string.Empty : BData.GetString("UI0370").Replace("[1]", BData.GetString(monTrait1.strName)).Replace("[2]", elt.nPreLearn.ToString());
      if (elt.ePreID != MonTraitID.eNone)
        this.textDetailTraitWarn.text += !Info.CheckMonTrait(nMonId, elt.ePreID) ? "\n" + BData.GetString("UI0041") + " : " + BData.GetString(BData.GetMonTrait(elt.ePreID).strName) : string.Empty;
      this.textDetailLearnBtn.text = BData.GetString(!flag ? "UI0053" : "UI0157");
      this.btnDetailLearn.interactable = !flag && Info.CanUpgMonTrait(nMonId, elt);
    }
  }

  public void OnClose()
  {
    UIMgr.PlaySound("Negative", false);
    UIMgr.RemoveTop();
    SaveManager.SaveRebirth();
  }

  public void OnSelected(MonTraitElt elt)
  {
    for (int index = 0; index < this.arrMonTraitElt.Length; ++index)
    {
      if (this.arrMonTraitElt[index].isActiveAndEnabled)
        this.arrMonTraitElt[index].RefreshHighlight((short) elt.nMonID, elt.eID);
    }
    this.nCurrentMon = elt.nMonID;
    this.currentElt = elt;
    this.RefreshDetail(elt);
  }

  public void OnLearnTrait()
  {
    short nMonId = (short) this.currentElt.nMonID;
    if (!Info.CanUpgMonTrait(nMonId, this.currentElt))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0371"), true, false, string.Empty);
      UIMgr.PlaySound("Negative", false);
    }
    else
    {
      Info.AddMonTrait(nMonId, this.currentElt.eID);
      this.RefreshTree();
      this.RefreshDetail(this.currentElt);
      UIMgr.PlaySound("Hire", false);
    }
  }
}
