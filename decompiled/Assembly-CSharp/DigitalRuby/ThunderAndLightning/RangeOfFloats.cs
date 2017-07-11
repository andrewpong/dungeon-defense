// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.RangeOfFloats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
