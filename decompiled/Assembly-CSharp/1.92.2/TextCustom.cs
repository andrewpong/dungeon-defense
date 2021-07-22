// Decompiled with JetBrains decompiler
// Type: TextCustom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
