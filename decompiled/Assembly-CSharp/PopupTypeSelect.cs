// Decompiled with JetBrains decompiler
// Type: PopupTypeSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class PopupTypeSelect : UIPage
{
  public static PopupTypeSelect obj;
  public GameObject[] goSelect;
  public Text[] textSelect;
  public GameObject[] goCheck;
  private PopupTypeSelect.Mode eMode;

  protected override void Awake()
  {
    base.Awake();
    PopupTypeSelect.obj = this;
  }

  public void EnchantType()
  {
    this.eMode = PopupTypeSelect.Mode.eEnchant;
    this.goSelect[2].SetActive(false);
    this.goSelect[3].SetActive(false);
    this.textSelect[0].text = BData.GetString("UI0333");
    this.textSelect[1].text = BData.GetString("UI0332");
    this.RefreshChecker();
  }

  public void ItemSellType()
  {
    this.eMode = PopupTypeSelect.Mode.eItemSell;
    this.textSelect[0].text = BData.GetString("UI0132");
    this.textSelect[1].text = BData.GetString("UI0039");
    this.textSelect[2].text = BData.GetString("UI0334");
    this.textSelect[3].text = BData.GetString("UI0336").Replace("[1]", BData.GetString("UI0090"));
    this.RefreshChecker();
  }

  public void ItemFilterType()
  {
    this.eMode = PopupTypeSelect.Mode.eItemFilter;
    this.textSelect[0].text = BData.GetString("UI0394");
    this.textSelect[1].text = BData.GetString("UI0392");
    this.textSelect[2].text = BData.GetString("UI0393");
    this.textSelect[3].text = BData.GetString("UI0395");
    this.RefreshChecker();
  }

  public void ResearchType()
  {
    this.eMode = PopupTypeSelect.Mode.eResearch;
    this.goSelect[2].SetActive(false);
    this.goSelect[3].SetActive(false);
    this.textSelect[0].text = BData.GetString("UI0260");
    this.textSelect[1].text = BData.GetString("UI0401");
    this.RefreshChecker();
  }

  public void RefreshChecker()
  {
    byte num = 0;
    switch (this.eMode)
    {
      case PopupTypeSelect.Mode.eEnchant:
        num = Info.option.byAutoEnchantType;
        break;
      case PopupTypeSelect.Mode.eItemSell:
        num = Info.option.byAutoItemSellType;
        break;
      case PopupTypeSelect.Mode.eItemFilter:
        num = Info.option.byItemFilter;
        break;
      case PopupTypeSelect.Mode.eResearch:
        num = Info.option.byAutoResearchType;
        break;
    }
    for (byte index = 0; (int) index < this.goCheck.Length; ++index)
      this.goCheck[(int) index].SetActive((int) index == (int) num);
  }

  public void SetType(int n)
  {
    UIMgr.PlaySound("Character", false);
    byte num = (byte) n;
    switch (this.eMode)
    {
      case PopupTypeSelect.Mode.eEnchant:
        Info.option.byAutoEnchantType = num;
        break;
      case PopupTypeSelect.Mode.eItemSell:
        Info.option.byAutoItemSellType = num;
        break;
      case PopupTypeSelect.Mode.eItemFilter:
        Info.option.byItemFilter = num;
        break;
      case PopupTypeSelect.Mode.eResearch:
        Info.option.byAutoResearchType = num;
        break;
    }
    this.RefreshChecker();
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
    UIMgr.RemoveTop();
    if ((bool) ((Object) PopupWeaponSelect.obj))
    {
      PopupWeaponSelect.obj.RefreshMod();
      SaveManager.SaveOption();
    }
    if (this.eMode != PopupTypeSelect.Mode.eResearch || (int) Info.option.byAutoResearchType != 1)
      return;
    UIMgr.AddPage("PopupResearchPlanner");
  }

  private enum Mode
  {
    eNone = -1,
    eEnchant = 0,
    eItemSell = 1,
    eItemFilter = 2,
    eResearch = 3,
  }
}
