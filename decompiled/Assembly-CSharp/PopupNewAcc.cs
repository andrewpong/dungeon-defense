// Decompiled with JetBrains decompiler
// Type: PopupNewAcc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class PopupNewAcc : UIPage
{
  public Text textTitle;
  public Text textLine;
  public Text textAccDesc;
  public Text textGrade;
  public Text textDisappear;
  public Image imgIcon;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0231");
    this.textDisappear.text = BData.GetString("UI0237");
    this.RefreshAcc();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void RefreshAcc()
  {
    if (Info.listGetAcc.Count == 0)
    {
      UIMgr.RemoveTop();
    }
    else
    {
      UIMgr.PlaySound("fanfare", false);
      AccData accessory = BData.GetAccessory((short) Info.listGetAcc[0].sID);
      this.imgIcon.sprite = RSMgr.GetSprite(accessory.strSprite);
      this.textLine.text = string.Empty;
      switch (accessory.eDrop)
      {
        case AccDropType.eDrop:
          this.textLine.text = BData.GetString("UI0228");
          break;
        case AccDropType.ePurchase:
          this.textLine.text = BData.GetString("UI0229");
          break;
        case AccDropType.eAchieve:
          this.textLine.text = BData.GetString("UI0230");
          break;
      }
      int nLv = (int) Info.listGetAcc[0].nLv;
      this.textGrade.text = Info.GetGradeString((byte) accessory.nGrade, false);
      this.textGrade.color = Info.GetGradeColor((byte) accessory.nGrade);
      this.textAccDesc.text = "<size='40'>" + BData.GetString(accessory.strName) + "</size>\n\n";
      this.textAccDesc.text += Info.GetAccDesc(accessory.sID, nLv);
      Info.listGetAcc.RemoveAt(0);
    }
  }

  public void OnClose()
  {
    if (Info.listGetAcc.Count > 0)
    {
      this.RefreshAcc();
    }
    else
    {
      UIMgr.PlaySound("DoorClose", false);
      UIMgr.RemoveTop();
    }
  }
}
