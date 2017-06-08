// Decompiled with JetBrains decompiler
// Type: MainTabElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class MainTabElt : MonoBehaviour
{
  public Image imgIcon;
  public Text textTab;
  public int nMenu;

  public void OnClick()
  {
    UIMgr.PlaySound("Button" + (object) Random.Range(0, 4), false);
    PageLobby.obj.OnMoveMenu(this.nMenu);
  }
}
