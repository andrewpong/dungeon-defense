// Decompiled with JetBrains decompiler
// Type: UnityStandardAssets.Water.SpecularLighting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace UnityStandardAssets.Water
{
  [RequireComponent(typeof (WaterBase))]
  [ExecuteInEditMode]
  public class SpecularLighting : MonoBehaviour
  {
    public Transform specularLight;
    private WaterBase m_WaterBase;

    public void Start()
    {
      this.m_WaterBase = (WaterBase) this.gameObject.GetComponent(typeof (WaterBase));
    }

    public void Update()
    {
      if (!(bool) ((Object) this.m_WaterBase))
        this.m_WaterBase = (WaterBase) this.gameObject.GetComponent(typeof (WaterBase));
      if (!(bool) ((Object) this.specularLight) || !(bool) ((Object) this.m_WaterBase.sharedMaterial))
        return;
      this.m_WaterBase.sharedMaterial.SetVector("_WorldLightDir", (Vector4) this.specularLight.transform.forward);
    }
  }
}
