// Decompiled with JetBrains decompiler
// Type: StringTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
