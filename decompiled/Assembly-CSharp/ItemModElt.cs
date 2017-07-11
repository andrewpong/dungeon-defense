// Decompiled with JetBrains decompiler
// Type: ItemModElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemModElt : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
  public int nSlot;

  public void OnPointerDown(PointerEventData eventData)
  {
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(PopupWeaponSelect.obj.nSelectedWeapon);
    if (playerWeapon == null || playerWeapon.arrMod[this.nSlot] == null)
      return;
    int nModLevel = (int) playerWeapon.arrMod[this.nSlot].nModLevel;
    ModData mod = BData.GetMod(playerWeapon.arrMod[this.nSlot].eMod);
    object[] objArray = new object[6]
    {
      (object) BData.GetString(mod.strName),
      (object) " Lv.",
      (object) nModLevel,
      (object) "\n",
      (object) BData.GetString(mod.strDesc).Replace("[1]", playerWeapon.arrMod[this.nSlot].fFactor.ToString("N2")),
      null
    };
    int index = 5;
    string str;
    if ((double) (float) playerWeapon.arrMod[this.nSlot].fBonus != 1.0)
      str = " (" + BData.GetString("UI0397") + "+" + ((float) playerWeapon.arrMod[this.nSlot].fBonus - 1f).ToString("P0") + ")";
    else
      str = string.Empty;
    objArray[index] = (object) str;
    UIMgr.TooltipShow(string.Concat(objArray));
  }

  public void OnPointerUp(PointerEventData eventData)
  {
    UIMgr.TooltipHide();
  }
}
