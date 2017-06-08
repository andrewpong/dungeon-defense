// Decompiled with JetBrains decompiler
// Type: PopupChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PopupChange : UIPage
{
  public static PopupChange obj;
  public Image imgScreenFX;

  protected override void Awake()
  {
    PopupChange.obj = this;
    Object.DontDestroyOnLoad((Object) this.gameObject);
  }

  public void SetFlash(string strLevel, Color color, float fFadeIn, float fFadeOut)
  {
    this.StartCoroutine(this.UpdateScreen(strLevel, color, fFadeIn, fFadeOut));
  }

  [DebuggerHidden]
  private IEnumerator UpdateScreen(string strLevel, Color color, float fFadeIn, float fFadeOut)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PopupChange.\u003CUpdateScreen\u003Ec__Iterator0()
    {
      color = color,
      fFadeIn = fFadeIn,
      strLevel = strLevel,
      fFadeOut = fFadeOut,
      \u0024this = this
    };
  }
}
