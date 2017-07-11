// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.RangeOfIntegers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
