// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScriptPrefabTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
