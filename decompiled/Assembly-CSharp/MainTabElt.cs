// Decompiled with JetBrains decompiler
// Type: MainTabElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
