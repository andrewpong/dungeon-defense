// Decompiled with JetBrains decompiler
// Type: CharUnitTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class CharUnitTab : MonoBehaviour
{
  public Image imgFrame;
  public Image imgChar;
  public GameObject goLock;
  public GameObject goHighlight;
  public Button btnFrame;
  private int nSlot;

  public int nCharSlot
  {
    get
    {
      return this.nSlot;
    }
  }

  public void SetUnitTab(PlayerMonsterData pData, int _nSlot)
  {
    bool flag = pData == null;
    this.imgChar.enabled = !flag;
    this.goLock.SetActive(flag);
    this.btnFrame.interactable = !flag;
    this.goHighlight.SetActive(false);
    if (pData == null)
      return;
    MonsterData monster = BData.GetMonster((short) pData.sID);
    this.imgChar.sprite = RSMgr.GetSprite(!Info.CheckRebirth(monster.eAwaken) && !(bool) pData.bAwaken ? monster.strSprite : monster.strSpriteAwk);
    this.imgChar.color = Color.white;
    this.nSlot = _nSlot;
  }

  public void SetHighlight(bool bActive)
  {
    this.goHighlight.SetActive(bActive);
  }

  public void OnClick()
  {
    PageLobby.obj.OnCharUnitTab(this.nSlot);
  }
}
