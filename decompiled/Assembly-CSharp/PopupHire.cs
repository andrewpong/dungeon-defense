// Decompiled with JetBrains decompiler
// Type: PopupHire
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupHire : UIPage
{
  private List<PlayerMonsterData> listData = new List<PlayerMonsterData>();
  public Text textTitle;
  public Text[] textBtnHire;
  public Text[] textBtnSkill;
  public Text[] textUnitName;
  public Text[] textHireCost;
  public Image[] imgHireUnit;
  public GameObject[] goUnitPanel;
  public RectTransform rtContent;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0183");
    for (int index = 0; index < this.textBtnHire.Length; ++index)
    {
      this.textBtnHire[index].text = BData.GetString("UI0044");
      this.textBtnSkill[index].text = BData.GetString("UI0250");
    }
    List<short> shortList = new List<short>();
    for (int index = 0; index < BData.dictMonster.Count; ++index)
    {
      MonsterData monster = BData.GetMonster((short) index);
      if (Info.achievement.listAcv.Count >= monster.nNeedAcv && (monster.eNeedRebirth == RebirthID.eNone || Info.CheckRebirth(monster.eNeedRebirth)))
        shortList.Add((short) index);
    }
    for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
    {
      if (Info.currentSave.arrPlayerMon[index] != null)
        shortList.Remove((short) Info.currentSave.arrPlayerMon[index].sID);
    }
    for (int index = 0; index < shortList.Count; ++index)
      this.listData.Add(Info.GetNewPlayerMon(shortList[index], true, true));
    for (int index = 0; index < this.goUnitPanel.Length; ++index)
    {
      if (index >= shortList.Count)
      {
        this.goUnitPanel[index].SetActive(false);
      }
      else
      {
        PlayerMonsterData pData = this.listData[index];
        MonsterData monster = BData.GetMonster((short) pData.sID);
        this.imgHireUnit[index].sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster.eAwaken) ? monster.strSprite : monster.strSpriteAwk);
        this.textUnitName[index].text = BData.GetString(monster.strName) + " Lv." + (object) pData.nLv;
        this.textHireCost[index].text = BData.GetString("UI0008") + " : " + BData.GetString(monster.strClass) + "  " + BData.GetString("UI0185") + " : " + (object) Info.GetCostHire(pData) + " G";
      }
    }
    this.rtContent.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float) (8 + 108 * shortList.Count));
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void OnHire(int nPos)
  {
    if (nPos >= this.listData.Count)
      return;
    UIMgr.RemoveTop();
    PageLobby.obj.OnUnitHire(this.listData[nPos]);
  }

  public void OnShowSkill(int nPos)
  {
    if (nPos >= this.listData.Count)
      return;
    UIMgr.PlaySound("MainButton", false);
    UIMgr.AddPage("PopupMercenarySkill");
    PopupMercenarySkill.obj.ShowSkill(this.listData[nPos]);
  }

  public void OnClose()
  {
    UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
  }
}
