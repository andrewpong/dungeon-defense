// Decompiled with JetBrains decompiler
// Type: UIPage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;
using UnityEngine.UI;

public class UIPage : MonoBehaviour
{
  [HideInInspector]
  public Canvas canvas;
  [HideInInspector]
  public bool registered;
  public Text[] textAll;
  protected RectTransform rtCanvas;

  protected virtual void Awake()
  {
    this.canvas = this.GetComponent<Canvas>();
    this.canvas.worldCamera = UIMgr.uiCamera;
    this.rtCanvas = this.canvas.transform as RectTransform;
  }

  protected virtual void Start()
  {
    if (Info.option.nLanguage == 2)
    {
      for (int index = 0; index < this.textAll.Length; ++index)
      {
        if ((Object) this.textAll[index] != (Object) null)
          this.textAll[index].font = RSMgr.GetFont("hobo");
      }
    }
    else if (Info.option.nLanguage == 5 || Info.option.nLanguage == 6)
    {
      for (int index = 0; index < this.textAll.Length; ++index)
      {
        if ((Object) this.textAll[index] != (Object) null)
          this.textAll[index].font = RSMgr.GetFont("Zpix");
      }
    }
    if (this.registered)
      return;
    UIMgr.Register(this);
  }

  protected virtual void Update()
  {
  }

  public virtual void Focused()
  {
  }

  public virtual void PageClose()
  {
    this.canvas.sortingOrder = this.canvas.sortingOrder + 10;
    this.GetComponent<GraphicRaycaster>().enabled = false;
  }
}
