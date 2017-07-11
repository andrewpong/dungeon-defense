// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScriptPrefabTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
