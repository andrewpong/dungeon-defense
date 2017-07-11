// Decompiled with JetBrains decompiler
// Type: PopupBuildOrder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupBuildOrder : UIPage
{
  public Text textTitle;
  public Text textBuildOrder;
  public Text textBuildNumber;
  public Text textRepeat;
  public Text textRepeatNumber;
  public GameObject goRepeatDown;
  public Text[] arrBuildOrder;
  public Text[] arrBuildNumber;
  public Text[] arrBuildName;
  public GameObject[] arrBuildOrderUp;
  public GameObject[] arrBuildOrderDown;
  public GameObject[] arrBuildNumberUp;
  public GameObject[] arrBuildNumberDown;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0353");
    this.textBuildOrder.text = BData.GetString("UI0398");
    this.textBuildNumber.text = BData.GetString("UI0399");
    this.textRepeat.text = BData.GetString("UI0400");
    if (Info.option.nBuildRepeat < 1)
      Info.option.nBuildRepeat = 1;
    this.textRepeatNumber.text = Info.option.nBuildRepeat.ToString();
    if (Info.option.listAutoBuildOrder.Count == 0)
    {
      Info.option.listAutoBuildCount.Clear();
      Info.option.listAutoBuildOrder.Add(DungeonType.eExpand);
      Info.option.listAutoBuildCount.Add(1);
      Info.option.listAutoBuildOrder.Add(DungeonType.eLab);
      Info.option.listAutoBuildCount.Add(1);
      Info.option.listAutoBuildOrder.Add(DungeonType.eParty);
      Info.option.listAutoBuildCount.Add(1);
      Info.option.listAutoBuildOrder.Add(DungeonType.eNest);
      Info.option.listAutoBuildCount.Add(1);
      Info.option.listAutoBuildOrder.Add(DungeonType.eDunHP);
      Info.option.listAutoBuildCount.Add(1);
      Info.option.listAutoBuildOrder.Add(DungeonType.eBank);
      Info.option.listAutoBuildCount.Add(1);
      Info.option.listAutoBuildOrder.Add(DungeonType.eStatue);
      Info.option.listAutoBuildCount.Add(1);
      Info.option.listAutoBuildOrder.Add(DungeonType.eAutoRepair);
      Info.option.listAutoBuildCount.Add(0);
      Info.option.listAutoBuildOrder.Add(DungeonType.eStorage);
      Info.option.listAutoBuildCount.Add(0);
      Info.option.listAutoBuildOrder.Add(DungeonType.eRegen);
      Info.option.listAutoBuildCount.Add(0);
      Info.option.listAutoBuildOrder.Add(DungeonType.eShop);
      Info.option.listAutoBuildCount.Add(0);
    }
    this.Refresh();
  }

  private void Refresh()
  {
    for (int index = 0; index < this.arrBuildName.Length; ++index)
    {
      DungeonData dungeon = BData.GetDungeon(Info.option.listAutoBuildOrder[index]);
      this.arrBuildName[index].text = BData.GetString(dungeon.strName);
      this.arrBuildOrder[index].text = index.ToString();
      this.arrBuildNumber[index].text = Info.option.listAutoBuildCount[index].ToString();
      this.arrBuildOrderUp[index].SetActive(index > 0);
      this.arrBuildOrderDown[index].SetActive(index < this.arrBuildName.Length - 1);
      this.arrBuildNumberDown[index].SetActive(Info.option.listAutoBuildCount[index] > 0);
    }
    this.textRepeatNumber.text = Info.option.nBuildRepeat.ToString();
    this.goRepeatDown.SetActive(Info.option.nBuildRepeat > 1);
  }

  public void OnBuildOrderUp(int nPos)
  {
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
    DungeonType dungeonType = Info.option.listAutoBuildOrder[nPos];
    int num = Info.option.listAutoBuildCount[nPos];
    Info.option.listAutoBuildOrder[nPos] = Info.option.listAutoBuildOrder[nPos - 1];
    Info.option.listAutoBuildCount[nPos] = Info.option.listAutoBuildCount[nPos - 1];
    Info.option.listAutoBuildOrder[nPos - 1] = dungeonType;
    Info.option.listAutoBuildCount[nPos - 1] = num;
    this.Refresh();
  }

  public void OnBuildOrderDown(int nPos)
  {
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
    DungeonType dungeonType = Info.option.listAutoBuildOrder[nPos];
    int num = Info.option.listAutoBuildCount[nPos];
    Info.option.listAutoBuildOrder[nPos] = Info.option.listAutoBuildOrder[nPos + 1];
    Info.option.listAutoBuildCount[nPos] = Info.option.listAutoBuildCount[nPos + 1];
    Info.option.listAutoBuildOrder[nPos + 1] = dungeonType;
    Info.option.listAutoBuildCount[nPos + 1] = num;
    this.Refresh();
  }

  public void OnBuildNumberUp(int nPos)
  {
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
    List<int> listAutoBuildCount;
    int index;
    (listAutoBuildCount = Info.option.listAutoBuildCount)[index = nPos] = listAutoBuildCount[index] + 1;
    this.Refresh();
  }

  public void OnBuildNumberDown(int nPos)
  {
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
    List<int> listAutoBuildCount;
    int index;
    (listAutoBuildCount = Info.option.listAutoBuildCount)[index = nPos] = listAutoBuildCount[index] - 1;
    this.Refresh();
  }

  public void OnRepeatUp()
  {
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
    ++Info.option.nBuildRepeat;
    this.Refresh();
  }

  public void OnRepeatDown()
  {
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), true);
    --Info.option.nBuildRepeat;
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
    UIMgr.PlaySound("Hire", false);
    UIMgr.RemoveTop();
    SaveManager.SaveOption();
  }
}
