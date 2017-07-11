// Decompiled with JetBrains decompiler
// Type: TextCustom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
