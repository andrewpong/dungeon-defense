// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScriptRotate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScriptRotate : MonoBehaviour
  {
    public Vector3 Rotation;

    private void Update()
    {
      this.gameObject.transform.Rotate(this.Rotation * Time.deltaTime);
    }
  }
}
