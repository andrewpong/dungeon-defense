// Decompiled with JetBrains decompiler
// Type: TooltipWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class TooltipWindow : MonoBehaviour
{
  public static TooltipWindow obj;
  public Text textMsg;
  public RectTransform rt;
  public bool bInit;

  private void Awake()
  {
    TooltipWindow.obj = this;
    Object.DontDestroyOnLoad((Object) this.gameObject);
  }

  private void Update()
  {
    if (Input.GetMouseButtonDown(0) && !this.bInit)
      this.gameObject.SetActive(false);
    this.bInit = false;
  }
}
