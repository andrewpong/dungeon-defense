// Decompiled with JetBrains decompiler
// Type: PopupMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class PopupMission : UIPage
{
  public Text textTitle;
  public MissionElt[] arrMission;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0301");
    for (int index = 0; index < this.arrMission.Length; ++index)
      this.arrMission[index].Refresh();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void OnClose()
  {
    UIMgr.PlaySound("DoorClose", false);
    UIMgr.RemoveTop();
  }
}
