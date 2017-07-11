// Decompiled with JetBrains decompiler
// Type: StringTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.EventSystems;

public class StringTooltip : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
  public string strTooltipSub1 = string.Empty;
  public string strTooltip;

  public void OnPointerDown(PointerEventData eventData)
  {
    UIMgr.TooltipShow(BData.GetString(this.strTooltip).Replace("[1]", this.strTooltipSub1));
  }

  public void OnPointerUp(PointerEventData eventData)
  {
    UIMgr.TooltipHide();
  }
}
