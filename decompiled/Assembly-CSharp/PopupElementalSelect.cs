// Decompiled with JetBrains decompiler
// Type: PopupElementalSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupElementalSelect : UIPage
{
  private ObscuredInt nSelected = (ObscuredInt) 0;
  private List<RebirthID> list = new List<RebirthID>();
  private List<ElementalID> listElemental = new List<ElementalID>();
  public static PopupElementalSelect obj;
  public Text[] textElementalSelect;
  public Text[] textElementalTrait;
  public Text[] textElementalName;
  public Text[] textElementalLevel;
  public Image[] imgElemental;
  public Image[] imgGaugeFill;
  public Button[] btnElementalSelect;
  public Text textElementalTitle;
  public Text textElementalWarn;
  private bool bCanSelect;

  protected override void Awake()
  {
    base.Awake();
    PopupElementalSelect.obj = this;
    this.list.Add(RebirthID.eFireDungeon);
    this.list.Add(RebirthID.eWaterDungeon);
    this.list.Add(RebirthID.eNatureDungeon);
    this.list.Add(RebirthID.eLightDungeon);
    this.list.Add(RebirthID.eDarkDungeon);
    this.listElemental.Add(ElementalID.eFireBase1);
    this.listElemental.Add(ElementalID.eWaterBase1);
    this.listElemental.Add(ElementalID.eNatureBase1);
    this.listElemental.Add(ElementalID.eLightBase1);
    this.listElemental.Add(ElementalID.eDarkBase1);
    for (int index = 0; index < this.textElementalTrait.Length; ++index)
      this.textElementalTrait[index].text = BData.GetString("UI0367");
    this.textElementalName[0].text = BData.GetString("UI0362");
    this.textElementalName[1].text = BData.GetString("UI0363");
    this.textElementalName[2].text = BData.GetString("UI0364");
    this.textElementalName[3].text = BData.GetString("UI0365");
    this.textElementalName[4].text = BData.GetString("UI0366");
    this.textElementalTitle.text = BData.GetString("UI0360");
    this.textElementalWarn.text = BData.GetString("UI0379");
    for (int index = 0; index < this.textElementalLevel.Length; ++index)
      this.textElementalLevel[index].text = "L" + (object) Info.GetElementalLevel(index + 1);
  }

  protected override void Start()
  {
    base.Start();
    this.Refresh();
  }

  private void Refresh()
  {
    int num1 = 0;
    int num2 = 0;
    for (int index = 0; index < this.list.Count; ++index)
    {
      if (!Info.CheckRebirth(this.list[index]))
        ++num2;
    }
    if (Info.CheckElementalTrait(ElementalID.eFireChar))
      ++num1;
    if (Info.CheckElementalTrait(ElementalID.eWaterChar))
      ++num1;
    if (Info.CheckElementalTrait(ElementalID.eNatureChar))
      ++num1;
    if (Info.CheckElementalTrait(ElementalID.eLightChar))
      ++num1;
    if (Info.CheckElementalTrait(ElementalID.eDarkChar))
      ++num1;
    this.bCanSelect = num1 + 1 > 5 - num2;
    if (num2 == 0)
      this.bCanSelect = false;
    if (this.bCanSelect)
    {
      UIMgr.PlaySound("Fanfare", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0376"), true, false, string.Empty);
    }
    if (this.bCanSelect)
    {
      for (int index = 0; index < 5; ++index)
      {
        this.textElementalSelect[index].text = BData.GetString(!Info.CheckRebirth(this.list[index]) ? "UI0380" : "UI0289");
        this.btnElementalSelect[index].interactable = !Info.CheckRebirth(this.list[index]);
      }
    }
    else
    {
      for (int index = 0; index < 5; ++index)
      {
        bool flag1 = index == (int) Info.rebirth.nEquippedElemental - 1;
        bool flag2 = Info.CheckRebirth(this.list[index]);
        long[] elementalAllExp = Info.GetElementalAllExp(index + 1);
        this.imgGaugeFill[index].fillAmount = (float) (elementalAllExp[2] - elementalAllExp[0]) / (float) (elementalAllExp[1] - elementalAllExp[0]);
        this.textElementalSelect[index].text = BData.GetString(!flag1 ? "UI0373" : "UI0374");
        this.btnElementalSelect[index].interactable = flag2;
        this.imgElemental[index].color = !flag1 ? (!flag2 ? new Color(0.2f, 0.2f, 0.2f, 0.2f) : new Color(0.5f, 0.5f, 0.5f, 0.5f)) : Color.white;
      }
    }
  }

  public void OnSelect(int n)
  {
    if (this.bCanSelect)
    {
      UIMgr.PlaySound("Negative", false);
      this.nSelected = (ObscuredInt) n;
      UIMgr.popupMsg.SetYesNo("ElementalSelect", BData.GetString("UI0381"), true);
    }
    else
    {
      if ((int) Info.rebirth.nEquippedElemental == n)
      {
        UIMgr.PlaySound("Negative", false);
        Info.rebirth.nEquippedElemental = (ObscuredInt) 0;
      }
      else if (Info.CheckRebirth(this.list[n - 1]))
      {
        UIMgr.PlaySound("Hire", false);
        Info.rebirth.nEquippedElemental = (ObscuredInt) n;
      }
      this.Refresh();
    }
  }

  public void OnRealSelect()
  {
    if (Info.CheckRebirth(this.list[(int) this.nSelected - 1]))
      return;
    UIMgr.PlaySound("Hire", false);
    Info.UpgRebirth(this.list[(int) this.nSelected - 1], 1);
    Info.UpgElementalTrait(this.listElemental[(int) this.nSelected - 1]);
    bool flag = true;
    for (int index = 0; index < this.list.Count; ++index)
    {
      if (index != (int) this.nSelected - 1 && Info.CheckRebirth(this.list[index]))
      {
        flag = false;
        break;
      }
    }
    if (flag)
      Info.rebirth.nEquippedElemental = this.nSelected;
    this.Refresh();
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
    SaveManager.SaveRebirth();
    Info.RefreshElementalFac();
    if (!(bool) ((Object) PageLobby.obj))
      return;
    Info.RefreshDungeonHP();
    PageLobby.obj.RefreshAction();
  }

  public void OnOpenTrait(int i)
  {
    UIMgr.PlaySound("MainButton", false);
    Info.nSelectedElementalView = (ObscuredInt) i;
    UIMgr.AddPage("PopupElementalTrait");
  }
}
