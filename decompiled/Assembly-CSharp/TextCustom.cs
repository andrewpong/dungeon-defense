// Decompiled with JetBrains decompiler
// Type: TextCustom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class TextCustom : Text
{
  protected override void Awake()
  {
    base.Awake();
    Debug.Log((object) this.font.fontNames[0]);
    if (!(this.font.fontNames[0] == "DungGeunMo") || Info.option.nLanguage != 1)
      return;
    this.font = RSMgr.GetFont("JackeyFont");
  }
}
