// Decompiled with JetBrains decompiler
// Type: UnityStandardAssets.Water.SpecularLighting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
