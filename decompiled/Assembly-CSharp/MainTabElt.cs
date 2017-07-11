// Decompiled with JetBrains decompiler
// Type: MainTabElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
