// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltPrefabScriptBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public abstract class LightningBoltPrefabScriptBase : LightningBoltScript
  {
    private readonly List<LightningBoltParameters> batchParameters = new List<LightningBoltParameters>();
    private readonly System.Random random = new System.Random();
    [Header("Lightning Spawn Properties")]
    [SingleLineClamp("How long to wait before creating another round of lightning bolts in seconds", 0.001, 1.79769313486232E+308)]
    public RangeOfFloats IntervalRange = new RangeOfFloats() { Minimum = 0.05f, Maximum = 0.1f };
    [SingleLineClamp("How many lightning bolts to emit for each interval", 0.0, 100.0)]
    public RangeOfIntegers CountRange = new RangeOfIntegers() { Minimum = 1, Maximum = 1 };
    [Tooltip("Reduces the probability that additional bolts from CountRange will actually happen (0 - 1).")]
    [Range(0.0f, 1f)]
    public float CountProbabilityModifier = 1f;
    [SingleLineClamp("Delay in seconds (range) before each additional lightning bolt in count range is emitted", 0.0, 30.0)]
    public RangeOfFloats DelayRange = new RangeOfFloats() { Minimum = 0.0f, Maximum = 0.0f };
    [SingleLineClamp("For each bolt emitted, how long should it stay in seconds", 0.01, 10.0)]
    public RangeOfFloats DurationRange = new RangeOfFloats() { Minimum = 0.06f, Maximum = 0.12f };
    [Header("Lightning Appearance Properties")]
    [SingleLineClamp("The trunk width range in unity units (x = min, y = max)", 0.0001, 100.0)]
    public RangeOfFloats TrunkWidthRange = new RangeOfFloats() { Minimum = 0.1f, Maximum = 0.2f };
    [Tooltip("Generations (1 - 8, higher makes more detailed but more expensive lightning)")]
    [Range(1f, 8f)]
    public int Generations = 6;
    [Tooltip("The chaos factor determines how far the lightning can spread out, higher numbers spread out more. 0 - 1.")]
    [Range(0.0f, 1f)]
    public float ChaosFactor = 0.075f;
    [Tooltip("Intensity of the lightning")]
    [Range(0.0f, 10f)]
    public float Intensity = 1f;
    [Tooltip("The intensity of the glow")]
    [Range(0.0f, 10f)]
    public float GlowIntensity = 0.1f;
    [Tooltip("The width multiplier for the glow, 0 - 64")]
    [Range(0.0f, 64f)]
    public float GlowWidthMultiplier = 4f;
    [Tooltip("How forked should the lightning be? (0 - 1, 0 for none, 1 for lots of forks)")]
    [Range(0.0f, 1f)]
    public float Forkedness = 0.25f;
    [Range(0.0f, 10f)]
    [Tooltip("Minimum distance multiplier for forks")]
    public float ForkLengthMultiplier = 0.6f;
    [Range(0.0f, 10f)]
    [Tooltip("Fork distance multiplier variance. Random range of 0 to n that is added to Fork Length Multiplier.")]
    public float ForkLengthVariance = 0.2f;
    [Tooltip("What percent of time the lightning should fade in and out. For example, 0.15 fades in 15% of the time and fades out 15% of the time, with full visibility 70% of the time.")]
    [Range(0.0f, 0.5f)]
    public float FadePercent = 0.15f;
    [Tooltip("How much smaller the lightning should get as it goes towards the end of the bolt. For example, 0.5 will make the end 50% the width of the start.")]
    [Range(0.0f, 10f)]
    public float EndWidthMultiplier = 0.5f;
    [Tooltip("Forks have their EndWidthMultiplier multiplied by this value")]
    [Range(0.0f, 10f)]
    public float ForkEndWidthMultiplier = 1f;
    [Tooltip("Maximum number of lights that can be created per batch of lightning")]
    [Range(0.0f, 64f)]
    public int MaximumLightsPerBatch = 8;
    [Tooltip("How long (in seconds) this game object should live before destroying itself. Leave as 0 for infinite.")]
    [Range(0.0f, 1000f)]
    public float LifeTime;
    [Tooltip("0 - 1, how slowly the lightning should grow. 0 for instant, 1 for slow.")]
    [Range(0.0f, 1f)]
    public float GrowthMultiplier;
    [Header("Lightning Light Properties")]
    [Tooltip("Light parameters")]
    public LightningLightParameters LightParameters;
    [Header("Lightning Trigger Type")]
    [Tooltip("Manual or automatic mode. Manual requires that you call the Trigger method in script. Automatic uses the interval to create lightning continuously.")]
    public bool ManualMode;
    private float nextArc;
    private float lifeTimeRemaining;

    private void CreateInterval(float offset)
    {
      this.nextArc = (double) this.IntervalRange.Minimum != (double) this.IntervalRange.Maximum ? offset + UnityEngine.Random.value * (this.IntervalRange.Maximum - this.IntervalRange.Minimum) + this.IntervalRange.Minimum : this.IntervalRange.Minimum;
    }

    private void CallLightning()
    {
      this.CallLightning(new Vector3?(), new Vector3?());
    }

    private void CallLightning(Vector3? start, Vector3? end)
    {
      int num = this.CountRange.Random(this.random);
      for (int index = 0; index < num; ++index)
      {
        LightningBoltParameters parameters = this.CreateParameters();
        if ((double) this.CountProbabilityModifier == 1.0 || index == 0 || parameters.Random.NextDouble() <= (double) this.CountProbabilityModifier)
        {
          this.CreateLightningBolt(parameters);
          if (start.HasValue)
            parameters.Start = start.Value;
          if (end.HasValue)
            parameters.End = end.Value;
        }
      }
      this.CreateLightningBoltsNow();
    }

    protected void CreateLightningBoltsNow()
    {
      int maximumLightsPerBatch = LightningBolt.MaximumLightsPerBatch;
      LightningBolt.MaximumLightsPerBatch = this.MaximumLightsPerBatch;
      this.CreateLightningBolts((ICollection<LightningBoltParameters>) this.batchParameters);
      LightningBolt.MaximumLightsPerBatch = maximumLightsPerBatch;
      this.batchParameters.Clear();
    }

    protected override void PopulateParameters(LightningBoltParameters p)
    {
      base.PopulateParameters(p);
      float num1 = this.DurationRange.Random(p.Random);
      float num2 = this.TrunkWidthRange.Random(p.Random);
      p.Generations = this.Generations;
      p.LifeTime = num1;
      p.ChaosFactor = this.ChaosFactor;
      p.TrunkWidth = num2;
      p.Intensity = this.Intensity;
      p.GlowIntensity = this.GlowIntensity;
      p.GlowWidthMultiplier = this.GlowWidthMultiplier;
      p.Forkedness = this.Forkedness;
      p.ForkLengthMultiplier = this.ForkLengthMultiplier;
      p.ForkLengthVariance = this.ForkLengthVariance;
      p.FadePercent = this.FadePercent;
      p.GrowthMultiplier = this.GrowthMultiplier;
      p.EndWidthMultiplier = this.EndWidthMultiplier;
      p.ForkEndWidthMultiplier = this.ForkEndWidthMultiplier;
      p.DelayRange = this.DelayRange;
      p.LightParameters = this.LightParameters;
    }

    protected override void Start()
    {
      base.Start();
      this.CreateInterval(0.0f);
      this.lifeTimeRemaining = (double) this.LifeTime > 0.0 ? this.LifeTime : float.MaxValue;
    }

    protected override void Update()
    {
      base.Update();
      if ((double) (this.lifeTimeRemaining -= Time.deltaTime) < 0.0)
      {
        UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
      }
      else
      {
        if ((double) (this.nextArc -= Time.deltaTime) > 0.0)
          return;
        this.CreateInterval(this.nextArc);
        if (this.ManualMode)
          return;
        this.CallLightning();
      }
    }

    public override void CreateLightningBolt(LightningBoltParameters p)
    {
      this.batchParameters.Add(p);
    }

    public void Trigger()
    {
      this.CallLightning();
    }

    public void Trigger(Vector3? start, Vector3? end)
    {
      this.CallLightning(start, end);
    }
  }
}
