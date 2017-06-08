// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScriptTriggerPath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScriptTriggerPath : MonoBehaviour
  {
    private readonly List<Vector3> points = new List<Vector3>();
    public LightningSplineScript Script;
    public Toggle SplineToggle;

    private void Start()
    {
      this.Script.ManualMode = true;
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
        DemoScript.ReloadCurrentScene();
      }
      else
      {
        if (!Input.GetMouseButton(0) || EventSystem.current.IsPointerOverGameObject())
          return;
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Camera.main.orthographic)
          worldPoint.z = 0.0f;
        if (this.points.Count != 0 && (double) (this.points[this.points.Count - 1] - worldPoint).magnitude <= 8.0)
          return;
        this.points.Add(worldPoint);
        this.Script.Trigger(this.points, this.SplineToggle.isOn);
      }
    }
  }
}
