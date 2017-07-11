// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoPathScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoPathScript : MonoBehaviour
  {
    public GameObject Crate;

    private void Start()
    {
      this.Crate.GetComponent<Rigidbody>().angularVelocity = new Vector3(0.2f, 0.3f, 0.4f);
    }
  }
}
