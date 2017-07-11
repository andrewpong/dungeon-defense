// Decompiled with JetBrains decompiler
// Type: PopupBlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine.UI;

public class PopupBlock : UIPage
{
  public Text textMsg;

  protected override void Awake()
  {
    base.Awake();
    this.textMsg.text = BData.GetString("UI0199") + "\n" + BData.GetString("UI0202");
  }
}
