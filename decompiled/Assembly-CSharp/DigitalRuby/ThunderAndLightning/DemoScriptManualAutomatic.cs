// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScriptManualAutomatic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScriptManualAutomatic : MonoBehaviour
  {
    public GameObject LightningPrefab;
    public Toggle AutomaticToggle;

    private void Update()
    {
      if (!Input.GetMouseButton(0))
        return;
      Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      worldPoint.z = 0.0f;
      this.LightningPrefab.GetComponent<LightningBoltPrefabScriptBase>().Trigger(new Vector3?(), new Vector3?(worldPoint));
    }

    public void AutomaticToggled()
    {
      this.LightningPrefab.GetComponent<LightningBoltPrefabScriptBase>().ManualMode = !this.AutomaticToggle.isOn;
    }

    public void ManualTriggerClicked()
    {
      this.LightningPrefab.GetComponent<LightningBoltPrefabScriptBase>().Trigger();
    }
  }
}
