// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningLightParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  [Serializable]
  public class LightningLightParameters
  {
    [Tooltip("Color of the light")]
    public Color LightColor = Color.white;
    [Tooltip("What percent of segments should have a light? For performance you may want to keep this small.")]
    [Range(0.0f, 1f)]
    public float LightPercent = 1E-06f;
    [Tooltip("Light intensity")]
    [Range(0.0f, 8f)]
    public float LightIntensity = 0.5f;
    [Tooltip("Shadow strength, 0 means all light, 1 means all shadow")]
    [Range(0.0f, 1f)]
    public float ShadowStrength = 1f;
    [Tooltip("Shadow bias, 0 - 2")]
    [Range(0.0f, 2f)]
    public float ShadowBias = 0.05f;
    [Tooltip("Shadow normal bias, 0 - 3")]
    [Range(0.0f, 3f)]
    public float ShadowNormalBias = 0.4f;
    [Tooltip("Only light objects that match this layer mask")]
    public LayerMask CullingMask = (LayerMask) -1;
    [Tooltip("Light render mode - leave as auto unless you have special use cases")]
    [HideInInspector]
    public LightRenderMode RenderMode;
    [Tooltip("What percent of lights created should cast shadows?")]
    [Range(0.0f, 1f)]
    public float LightShadowPercent;
    [Tooltip("Bounce intensity")]
    [Range(0.0f, 8f)]
    public float BounceIntensity;
    [Tooltip("The range of each light created")]
    public float LightRange;

    public bool HasLight
    {
      get
      {
        if ((double) this.LightColor.a > 0.0 && (double) this.LightIntensity >= 0.00999999977648258 && (double) this.LightPercent >= 1.0000000116861E-07)
          return (double) this.LightRange > 0.00999999977648258;
        return false;
      }
    }
  }
}
