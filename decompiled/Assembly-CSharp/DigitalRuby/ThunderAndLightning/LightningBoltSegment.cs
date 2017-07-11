// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public struct LightningBoltSegment
  {
    public Vector3 Start;
    public Vector3 End;

    public override string ToString()
    {
      return this.Start.ToString() + ", " + this.End.ToString();
    }
  }
}
