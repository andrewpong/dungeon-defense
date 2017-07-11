// Decompiled with JetBrains decompiler
// Type: PopupChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
