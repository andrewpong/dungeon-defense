// Decompiled with JetBrains decompiler
// Type: MonTraitElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MonTraitElt : MonoBehaviour
{
  public Image imgIcon;
  public Image imgHighlight;
  public int nMonID;
  public MonTraitID eID;
  public MonTraitID ePreID;
  public int nPreLearn;
  private Text _textPoint;
  private Button _btn;

  private Text textPoint
  {
    get
    {
      if ((Object) this._textPoint == (Object) null)
        this._textPoint = this.GetComponentInChildren<Text>();
      return this._textPoint;
    }
  }

  private Button btn
  {
    get
    {
      if ((Object) this._btn == (Object) null)
      {
        this._btn = this.GetComponent<Button>();
        this.AddUpListener(this._btn);
      }
      return this._btn;
    }
  }

  public void Refresh()
  {
    this.btn.interactable = true;
    short nMonId = (short) this.nMonID;
    int monTrait1 = Info.GetMonTrait(nMonId, this.eID);
    MonTraitData monTrait2 = BData.GetMonTrait(this.eID);
    this.imgIcon.sprite = RSMgr.GetSprite(monTrait2.strIcon);
    this.imgIcon.color = Info.CanUpgMonTrait(nMonId, this) || monTrait1 > 0 ? Color.white : Color.gray;
    this.textPoint.text = monTrait1 <= 0 ? string.Empty : monTrait1.ToString() + "/" + (object) monTrait2.nMax;
    this.imgHighlight.enabled = false;
  }

  private void AddUpListener(Button b)
  {
    b.onClick.AddListener((UnityAction) (() => this.OnSelected()));
  }

  public void RefreshHighlight(short sID, MonTraitID _eID)
  {
    this.imgHighlight.enabled = (int) sID == (int) (short) this.nMonID && this.eID == _eID;
  }

  public void OnSelected()
  {
    PopupMonsterTrait.obj.OnSelected(this);
  }
}
