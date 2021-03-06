﻿// Decompiled with JetBrains decompiler
// Type: PopupMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
