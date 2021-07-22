// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScript2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScript2D : MonoBehaviour
  {
    public GameObject spriteToRotate;

    private void Start()
    {
    }

    private void Update()
    {
      this.spriteToRotate.transform.Rotate(0.0f, 0.0f, Time.deltaTime * 10f);
    }
  }
}
