// Decompiled with JetBrains decompiler
// Type: PopupResearchPlanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PopupResearchPlanner : UIPage
{
  public static PopupResearchPlanner obj;
  public Text textTitle;
  public Image[] arrPlanIcon;
  public Text[] arrPlanName;
  public Text[] arrPlanCondition;
  public Text[] arrPlanDesc;
  public Text[] arrPlanOrder;
  public Text[] arrPlanNeed;
  public Image[] arrPlanUp;
  public Image[] arrPlanDown;
  public Button[] arrPlanBtnUp;
  public Button[] arrPlanBtnDown;

  protected override void Awake()
  {
    base.Awake();
    PopupResearchPlanner.obj = this;
    this.textTitle.text = BData.GetString("UI0401");
    this.arrPlanUp[0].gameObject.SetActive(false);
    this.arrPlanDown[this.arrPlanDown.Length - 1].gameObject.SetActive(false);
    if (Info.option.listResearchOrder.Count == 0)
    {
      List<ResearchID> researchIdList = new List<ResearchID>((IEnumerable<ResearchID>) BData.dictRsc.Keys);
      researchIdList.Remove(ResearchID.eUnlimitedPower);
      researchIdList.Remove(ResearchID.eUnlimitedShield);
      while (researchIdList.Count > 0)
      {
        for (int index1 = 0; index1 < researchIdList.Count; ++index1)
        {
          ResearchData research = BData.GetResearch(researchIdList[index1]);
          if (research.listPre.Count == 0)
          {
            Info.option.listResearchOrder.Add(researchIdList[index1]);
            researchIdList.Remove(researchIdList[index1]);
            break;
          }
          bool flag = true;
          for (int index2 = 0; index2 < research.listPre.Count; ++index2)
          {
            if (!Info.option.listResearchOrder.Contains(research.listPre[index2]))
              flag = false;
          }
          if (flag)
          {
            Info.option.listResearchOrder.Add(researchIdList[index1]);
            researchIdList.Remove(researchIdList[index1]);
          }
        }
      }
      Debug.Log((object) Info.option.listResearchOrder.Count);
    }
    this.RefreshPlan();
  }

  protected override void Start()
  {
    base.Start();
    for (int index = 0; index < this.arrPlanBtnUp.Length; ++index)
    {
      this.AddUpListener(this.arrPlanBtnUp[index], index);
      this.AddDownListener(this.arrPlanBtnDown[index], index);
    }
  }

  private void AddUpListener(Button b, int value)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: reference to a compiler-generated method
    b.onClick.AddListener(new UnityAction(new PopupResearchPlanner.\u003CAddUpListener\u003Ec__AnonStorey0()
    {
      value = value,
      \u0024this = this
    }.\u003C\u003Em__0));
  }

  private void AddDownListener(Button b, int value)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: reference to a compiler-generated method
    b.onClick.AddListener(new UnityAction(new PopupResearchPlanner.\u003CAddDownListener\u003Ec__AnonStorey1()
    {
      value = value,
      \u0024this = this
    }.\u003C\u003Em__0));
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
    UIMgr.PlaySound("DoorClose", false);
    SaveManager.SaveOption();
    UIMgr.RemoveTop();
  }

  public void RefreshPlan()
  {
    for (int index1 = 0; index1 < Info.option.listResearchOrder.Count; ++index1)
    {
      ResearchData research = BData.GetResearch(Info.option.listResearchOrder[index1]);
      this.arrPlanName[index1].text = BData.GetString(research.strName);
      this.arrPlanDesc[index1].text = BData.GetString(research.strDesc);
      this.arrPlanCondition[index1].text = BData.GetString(research.strName);
      this.arrPlanIcon[index1].sprite = RSMgr.GetSprite(research.strIcon);
      this.arrPlanNeed[index1].text = research.nCost.ToString("N0") + " pt";
      this.arrPlanOrder[index1].text = index1.ToString();
      bool flag = true;
      if (index1 > 0)
        this.arrPlanDown[index1 - 1].color = Color.white;
      if (research.listPre.Count != 0)
      {
        this.arrPlanCondition[index1].text = BData.GetString("UI0162") + " : ";
        for (int index2 = 0; index2 < research.listPre.Count; ++index2)
        {
          if (index1 > 0 && Info.option.listResearchOrder[index1 - 1] == research.listPre[index2])
          {
            flag = false;
            this.arrPlanDown[index1 - 1].color = Color.red;
          }
          Text text = this.arrPlanCondition[index1];
          string str = text.text + "<" + BData.GetString(BData.GetResearch(research.listPre[index2]).strName) + ">";
          text.text = str;
          if (index2 < research.listPre.Count - 1)
            this.arrPlanCondition[index1].text += ", ";
        }
      }
      this.arrPlanUp[index1].color = !flag ? Color.red : Color.white;
    }
  }

  public void OnPlanUp(int i)
  {
    if (i == 0)
      return;
    ResearchData research = BData.GetResearch(Info.option.listResearchOrder[i]);
    for (int index = 0; index < research.listPre.Count; ++index)
    {
      if (Info.option.listResearchOrder[i - 1] == research.listPre[index])
      {
        UIMgr.PlaySound("Negative", false);
        return;
      }
    }
    UIMgr.PlaySound("Character", false);
    Info.option.listResearchOrder.Remove(research.eID);
    Info.option.listResearchOrder.Insert(i - 1, research.eID);
    this.RefreshPlan();
  }

  public void OnPlanDown(int i)
  {
    ResearchData research = BData.GetResearch(Info.option.listResearchOrder[i + 1]);
    for (int index = 0; index < research.listPre.Count; ++index)
    {
      if (Info.option.listResearchOrder[i] == research.listPre[index])
      {
        UIMgr.PlaySound("Negative", false);
        return;
      }
    }
    UIMgr.PlaySound("Character", false);
    Info.option.listResearchOrder.Remove(research.eID);
    Info.option.listResearchOrder.Insert(i, research.eID);
    this.RefreshPlan();
  }
}
