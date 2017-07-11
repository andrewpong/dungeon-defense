// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.RangeOfIntegers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  [Serializable]
  public struct RangeOfIntegers
  {
    [Tooltip("Minimum value (inclusive)")]
    public int Minimum;
    [Tooltip("Maximum value (inclusive)")]
    public int Maximum;

    public int Random()
    {
      return UnityEngine.Random.Range(this.Minimum, this.Maximum + 1);
    }

    public int Random(System.Random r)
    {
      return r.Next(this.Minimum, this.Maximum + 1);
    }
  }
}
