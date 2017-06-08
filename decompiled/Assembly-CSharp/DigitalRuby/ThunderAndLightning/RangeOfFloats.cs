// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.RangeOfFloats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  [Serializable]
  public struct RangeOfFloats
  {
    [Tooltip("Minimum value (inclusive)")]
    public float Minimum;
    [Tooltip("Maximum value (inclusive)")]
    public float Maximum;

    public float Random()
    {
      return UnityEngine.Random.Range(this.Minimum, this.Maximum);
    }

    public float Random(System.Random r)
    {
      return this.Minimum + (float) r.NextDouble() * (this.Maximum - this.Minimum);
    }
  }
}
