// Decompiled with JetBrains decompiler
// Type: PopupRebirthDiff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupRebirthDiff : UIPage
{
  private List<short> listMon = new List<short>();
  public Text textDesc;
  public Text textSelDiff;
  public Text textBtnRebirth;
  public Text textBtnCancel;
  public Text textCharSel;
  public Text textCharName;
  public Text[] textDiff;
  public GameObject[] arrChecker;
  public GameObject goLock;
  public Image imgMon;
  public Button btnRebirth;
  public static PopupRebirthDiff obj;
  private int nCharPos;

  protected override void Awake()
  {
    base.Awake();
    PopupRebirthDiff.obj = this;
    this.textDesc.text = BData.GetString("UI0172") + "\n" + BData.GetString("UI0192");
    this.textBtnRebirth.text = BData.GetString("UI0193");
    this.textBtnCancel.text = BData.GetString("UI0094");
    this.textCharSel.text = BData.GetString("UI0137");
    this.textSelDiff.text = BData.GetString("UI0040");
    for (int nDiff = 0; nDiff < this.textDiff.Length; ++nDiff)
      this.textDiff[nDiff].text = Info.GetDiffText(nDiff, true);
    this.listMon = new List<short>((IEnumerable<short>) BData.dictMonster.Keys);
    for (int index = 0; index < this.listMon.Count; ++index)
    {
      if ((int) this.listMon[index] == (int) (short) Info.currentSave.arrPlayerMon[0].sID)
      {
        this.nCharPos = index;
        Info.sSelectedRebirthCharID = (ObscuredShort) this.listMon[index];
        break;
      }
    }
    Info.nSelectedDiff = (int) Info.currentSave.nDiff;
    this.RefreshDiffHighlight();
    this.RefreshChar();
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
    UIMgr.RemoveTop();
  }

  public void OnDifficult(int nDiff)
  {
    UIMgr.PlaySound("Character", false);
    Info.nSelectedDiff = nDiff;
    this.RefreshDiffHighlight();
  }

  public void MoveChar(int nMove)
  {
    UIMgr.PlaySound("Character", false);
    this.nCharPos = this.nCharPos + nMove;
    if (this.nCharPos < 0)
      this.nCharPos = this.listMon.Count - 1;
    if (this.nCharPos > this.listMon.Count - 1)
      this.nCharPos = 0;
    Info.sSelectedRebirthCharID = (ObscuredShort) this.listMon[this.nCharPos];
    this.RefreshChar();
  }

  public void RefreshChar()
  {
    MonsterData monster = BData.GetMonster(this.listMon[(int) (short) Info.sSelectedRebirthCharID]);
    this.imgMon.sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster.eAwaken) ? monster.strSprite : monster.strSpriteAwk);
    this.textCharName.text = BData.GetString(monster.strName);
    bool flag = Info.achievement.listAcv.Count >= monster.nNeedAcv && (monster.eNeedRebirth == RebirthID.eNone || Info.CheckRebirth(monster.eNeedRebirth));
    this.goLock.SetActive(!flag);
    this.btnRebirth.interactable = flag;
  }

  public void RefreshDiffHighlight()
  {
    for (int index = 0; index < this.arrChecker.Length; ++index)
      this.arrChecker[index].SetActive(index == Info.nSelectedDiff);
  }

  public void OnRebirth()
  {
    if (Info.GetRebirth(RebirthID.eInheritor) > 0)
    {
      UIMgr.PlaySound("MainButton", false);
      UIMgr.AddPage("PopupWeaponSelect");
      PopupWeaponSelect.obj.InheritMode();
    }
    else
      Info.Rebirth(Info.currentSave, (short) Info.sSelectedRebirthCharID, Info.nSelectedDiff, true, new List<PlayerItemData>());
  }
}
