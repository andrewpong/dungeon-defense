// Decompiled with JetBrains decompiler
// Type: PageStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PageStart : UIMgr
{
  public static PageStart obj;
  public Text textStart;
  public bool bLoaded;
  private bool bFadeIn;

  protected override void Awake()
  {
    base.Awake();
    PageStart.obj = this;
  }

  protected override void Start()
  {
    base.Start();
    SaveManager.LoadOption();
    SaveManager.LoadAchievement();
    SaveManager.LoadRebirth();
    if (!Info.option.bSelectLang)
    {
      Info.option.bSelectLang = true;
      Info.option.nLanguage = Application.systemLanguage != SystemLanguage.Korean ? (Application.systemLanguage != SystemLanguage.Japanese ? (Application.systemLanguage != SystemLanguage.German ? (Application.systemLanguage != SystemLanguage.Russian ? (Application.systemLanguage == SystemLanguage.ChineseSimplified || Application.systemLanguage == SystemLanguage.Chinese ? 5 : (Application.systemLanguage != SystemLanguage.ChineseTraditional ? (Application.systemLanguage != SystemLanguage.French ? 1 : 7) : 6)) : 4) : 3) : 2) : 0;
    }
    if (Info.option.bAutoLogin)
      GPGSMgr.single.InitializeGPGS();
    this.StartCoroutine(this.RepeatFade());
    this.bLoaded = true;
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetMouseButtonUp(0) || !this.bLoaded)
      return;
    this.StopCoroutine(this.RepeatFade());
    SceneManager.LoadScene("Main");
  }

  [DebuggerHidden]
  private IEnumerator RepeatFade()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageStart.\u003CRepeatFade\u003Ec__Iterator0()
    {
      \u0024this = this
    };
  }
}
