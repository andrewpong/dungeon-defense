// Decompiled with JetBrains decompiler
// Type: UnityStandardAssets.Water.Displace
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace UnityStandardAssets.Water
{
  [ExecuteInEditMode]
  [RequireComponent(typeof (WaterBase))]
  public class Displace : MonoBehaviour
  {
    public void Awake()
    {
      if (this.enabled)
        this.OnEnable();
      else
        this.OnDisable();
    }

    public void OnEnable()
    {
      Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
      Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
    }

    public void OnDisable()
    {
      Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
      Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
    }
  }
}
