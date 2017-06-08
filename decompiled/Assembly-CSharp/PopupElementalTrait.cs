// Decompiled with JetBrains decompiler
// Type: PopupElementalTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class PopupElementalTrait : UIPage
{
  public static PopupElementalTrait obj;
  private ElementalID eID;
  private ElementalID eBase;
  public Image[] imgTraitIcon;
  public Image[] imgTraitFrame;
  public Image[] imgTraitHighlight;
  public Image imgDetailTraitIcon;
  public Text textDetailTraitName;
  public Text textDetailTraitDesc;
  public Text textDetailTraitWarn;
  public Text textDetailLearnBtn;
  public Button btnDetailLearn;
  public Text textTitle;
  public Text textTraitPoints;
  public Text textInitButton;
  public Text textInitNeed;
  public GameObject goInitNeed;
  public GameObject goInitButton;

  private int nInitCost
  {
    get
    {
      if ((int) Info.rebirth.nInitElementalTrait < 3)
        return 0;
      return Mathf.Min(1000 + ((int) Info.rebirth.nInitElementalTrait - 3) * 100, 10000);
    }
  }

  protected override void Awake()
  {
    base.Awake();
    PopupElementalTrait.obj = this;
    this.eBase = ElementalID.eNone;
    switch ((int) Info.nSelectedElementalView)
    {
      case 1:
        this.eBase = ElementalID.eFireBase1;
        break;
      case 2:
        this.eBase = ElementalID.eWaterBase1;
        break;
      case 3:
        this.eBase = ElementalID.eNatureBase1;
        break;
      case 4:
        this.eBase = ElementalID.eLightBase1;
        break;
      case 5:
        this.eBase = ElementalID.eDarkBase1;
        break;
    }
    if (this.eBase == ElementalID.eNone)
    {
      UIMgr.RemoveTop();
    }
    else
    {
      this.textTitle.text = BData.GetString("UI0367");
      this.RefreshTraitTree();
      this.OnTraitSelected(0);
    }
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void OnClose()
  {
    UIMgr.PlaySound("Negative", false);
    UIMgr.RemoveTop();
    SaveManager.SaveRebirth();
  }

  private void OnDetailView(ElementalID _eID)
  {
    this.eID = _eID;
    ElementalData elemental = BData.GetElemental(this.eID);
    int elementalTrait = Info.GetElementalTrait(elemental.eID);
    bool flag1 = elemental.nMaxLv <= elementalTrait;
    this.imgDetailTraitIcon.sprite = RSMgr.GetSprite(elemental.strIcon);
    Text textDetailTraitName = this.textDetailTraitName;
    string str1 = BData.GetString(elemental.strName);
    string str2;
    if (elemental.nMaxLv != 1)
      str2 = " (" + (object) elementalTrait + "/" + (object) elemental.nMaxLv + ")";
    else
      str2 = string.Empty;
    string str3 = str1 + str2;
    textDetailTraitName.text = str3;
    this.textDetailTraitDesc.text = BData.GetString(elemental.strDesc).Replace("[1]", (elemental.fBase1 + elemental.fGrow1 * (float) elementalTrait).ToString("###0.##") + (flag1 || elemental.nMaxLv == 1 ? string.Empty : "(" + ((double) elemental.fGrow1 <= 0.0 ? string.Empty : "+") + elemental.fGrow1.ToString("###0.##") + ")")).Replace("[2]", (elemental.fBase2 + elemental.fGrow2 * (float) elementalTrait).ToString("###0.##") + (flag1 || elemental.nMaxLv == 1 ? string.Empty : "(" + ((double) elemental.fGrow2 <= 0.0 ? string.Empty : "+") + elemental.fGrow2.ToString("###0.##") + ")")).Replace("[3]", (elemental.fBase3 + elemental.fGrow3 * (float) elementalTrait).ToString("###0.##") + (flag1 || elemental.nMaxLv == 1 ? string.Empty : "(" + ((double) elemental.fGrow3 <= 0.0 ? string.Empty : "+") + elemental.fGrow3.ToString("###0.##") + ")"));
    bool flag2 = Info.CanUpgElementalTrait(elemental.eID, true);
    this.textDetailTraitWarn.text = Info.GetTraitNumberByElement(elemental.eElm) >= elemental.nNeed ? string.Empty : BData.GetString("UI0370").Replace("[1]", BData.GetString(elemental.strName)).Replace("[2]", elemental.nNeed.ToString());
    if (elemental.eNeed != ElementalID.eNone)
      this.textDetailTraitWarn.text += !Info.CheckElementalTrait(elemental.eNeed) ? "\n" + BData.GetString("UI0041") + " : " + BData.GetString(BData.GetElemental(elemental.eNeed).strName) : string.Empty;
    this.textDetailLearnBtn.text = BData.GetString(!flag1 ? "UI0053" : "UI0157");
    this.btnDetailLearn.interactable = !flag1 && flag2;
  }

  private void RefreshTraitTree()
  {
    int elementalLevel = Info.GetElementalLevel((int) Info.nSelectedElementalView);
    int traitNumberByElement = Info.GetTraitNumberByElement((int) Info.nSelectedElementalView);
    this.textInitButton.text = BData.GetString("UI0383");
    if ((int) Info.rebirth.nInitElementalTrait < 3)
    {
      Text textInitButton = this.textInitButton;
      string str = textInitButton.text + "(" + (object) (3 - (int) Info.rebirth.nInitElementalTrait) + "/3)";
      textInitButton.text = str;
    }
    this.goInitButton.SetActive(Info.CheckElementalTrait(this.eBase));
    this.goInitNeed.SetActive((int) Info.rebirth.nInitElementalTrait >= 3);
    this.textInitNeed.text = this.nInitCost.ToString();
    this.textInitNeed.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.textInitNeed.preferredWidth);
    for (int index = 0; index < 15; ++index)
    {
      ElementalData elemental = BData.GetElemental(this.eBase + index);
      bool flag1 = Info.CheckElementalTrait(elemental.eID);
      this.imgTraitIcon[index].sprite = RSMgr.GetSprite(elemental.strIcon);
      bool flag2 = Info.CanUpgElementalTrait(elemental.eID, false);
      Image image = this.imgTraitFrame[index];
      Color color1 = flag2 || flag1 ? Color.white : new Color(0.2f, 0.2f, 0.2f);
      this.imgTraitIcon[index].color = color1;
      Color color2 = color1;
      image.color = color2;
    }
    this.textTraitPoints.text = BData.GetString("UI0368") + " : <color='#44ff00'>" + (elementalLevel - traitNumberByElement).ToString() + "</color>\n" + BData.GetString("UI0369") + " : <color='red'>" + traitNumberByElement.ToString() + "</color>";
  }

  public void OnTraitSelected(int i)
  {
    for (int index = 0; index < this.imgTraitHighlight.Length; ++index)
      this.imgTraitHighlight[index].enabled = i == index;
    UIMgr.PlaySound("Character", false);
    switch ((int) Info.nSelectedElementalView)
    {
      case 1:
        this.OnDetailView((ElementalID) (1001 + i));
        break;
      case 2:
        this.OnDetailView((ElementalID) (2001 + i));
        break;
      case 3:
        this.OnDetailView((ElementalID) (3001 + i));
        break;
      case 4:
        this.OnDetailView((ElementalID) (4001 + i));
        break;
      case 5:
        this.OnDetailView((ElementalID) (5001 + i));
        break;
    }
  }

  public void OnLearn()
  {
    if (!Info.CanUpgElementalTrait(this.eID, true))
    {
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0371"), true, false, string.Empty);
      UIMgr.PlaySound("Negative", false);
    }
    else
    {
      Info.UpgElementalTrait(this.eID);
      this.RefreshTraitTree();
      this.OnDetailView(this.eID);
      UIMgr.PlaySound("Hire", false);
    }
  }

  public void OnInit()
  {
    if ((int) Info.rebirth.nRuby < this.nInitCost)
    {
      UIMgr.NotEnoughRuby();
      UIMgr.PlaySound("Negative", false);
    }
    else
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetYesNo("InitTrait", BData.GetString("UI0396"), true);
    }
  }

  public void OnRealInit()
  {
    SavedRebirth rebirth = Info.rebirth;
    ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby - this.nInitCost);
    rebirth.nRuby = obscuredInt;
    ++Info.rebirth.nInitElementalTrait;
    for (int index = 0; index < 15; ++index)
    {
      if (index != 0 && (index != 9 || !Info.CheckShop(ShopID.eElementalPackage)) && Info.rebirth.dictElementalTrait.ContainsKey(this.eBase + index))
        Info.rebirth.dictElementalTrait.Remove(this.eBase + index);
    }
    if (!Info.CheckElementalTrait(ElementalID.eFireChar) && Info.CheckRebirth(RebirthID.eFireElemental))
      Info.rebirth.dictRebirth.Remove(RebirthID.eFireElemental);
    if (!Info.CheckElementalTrait(ElementalID.eWaterChar) && Info.CheckRebirth(RebirthID.eWaterElemental))
      Info.rebirth.dictRebirth.Remove(RebirthID.eWaterElemental);
    if (!Info.CheckElementalTrait(ElementalID.eNatureChar) && Info.CheckRebirth(RebirthID.eNatureElemental))
      Info.rebirth.dictRebirth.Remove(RebirthID.eNatureElemental);
    if (!Info.CheckElementalTrait(ElementalID.eLightChar) && Info.CheckRebirth(RebirthID.eLightElemental))
      Info.rebirth.dictRebirth.Remove(RebirthID.eLightElemental);
    if (!Info.CheckElementalTrait(ElementalID.eDarkChar) && Info.CheckRebirth(RebirthID.eDarkElemental))
      Info.rebirth.dictRebirth.Remove(RebirthID.eDarkElemental);
    Info.RefreshElementalFac();
    this.RefreshTraitTree();
    this.OnDetailView(this.eBase);
    UIMgr.PlaySound("Hire", false);
    SaveManager.SaveRebirth();
  }
}
