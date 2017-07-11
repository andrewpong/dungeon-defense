// Decompiled with JetBrains decompiler
// Type: StringTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
