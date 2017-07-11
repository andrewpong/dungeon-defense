// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScriptPrefabTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScriptPrefabTutorial : MonoBehaviour
  {
    public LightningBoltPrefabScript LightningScript;

    private void Start()
    {
    }

    private void Update()
    {
      if (!Input.GetKey(KeyCode.Space))
        return;
      this.LightningScript.Trigger();
    }
  }
}
