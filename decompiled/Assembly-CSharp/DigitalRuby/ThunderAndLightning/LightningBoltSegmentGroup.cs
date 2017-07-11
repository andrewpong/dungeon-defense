// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBoltSegmentGroup
  {
    public readonly List<LightningBoltSegment> Segments = new List<LightningBoltSegment>();
    public readonly List<Light> Lights = new List<Light>();
    public float LineWidth;
    public int StartIndex;
    public int Generation;
    public float Delay;
    public float PeakStart;
    public float PeakEnd;
    public float LifeTime;
    public float EndWidthMultiplier;
    public Color32 Color;
    public LightningLightParameters LightParameters;

    public int SegmentCount
    {
      get
      {
        return this.Segments.Count - this.StartIndex;
      }
    }

    public void Reset()
    {
      this.LightParameters = (LightningLightParameters) null;
      this.Segments.Clear();
      this.Lights.Clear();
      this.StartIndex = 0;
    }
  }
}
