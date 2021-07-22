// Decompiled with JetBrains decompiler
// Type: PopupBlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
