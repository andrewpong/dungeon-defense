// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  [Serializable]
  public sealed class LightningBoltParameters
  {
    public float EndWidthMultiplier = 0.5f;
    public float Intensity = 1f;
    public int GenerationWhereForksStopSubtractor = 5;
    public float ForkLengthMultiplier = 0.6f;
    public float ForkLengthVariance = 0.2f;
    public float ForkEndWidthMultiplier = 1f;
    private static readonly List<LightningBoltParameters> cache = new List<LightningBoltParameters>();
    public static float Scale = 1f;
    public static readonly Dictionary<int, LightningQualityMaximum> QualityMaximums = new Dictionary<int, LightningQualityMaximum>();
    internal int generationWhereForksStop;
    internal int forkednessCalculated;
    internal LightningBoltQualitySetting quality;
    internal float delaySeconds;
    internal int maxLights;
    public LightningGenerator Generator;
    public Vector3 Start;
    public Vector3 End;
    public Vector3 StartVariance;
    public Vector3 EndVariance;
    private int generations;
    public float LifeTime;
    public float Delay;
    public RangeOfFloats DelayRange;
    public float ChaosFactor;
    public float TrunkWidth;
    public float GlowIntensity;
    public float GlowWidthMultiplier;
    public float Forkedness;
    public System.Random Random;
    public float FadePercent;
    private float growthMultiplier;
    public LightningLightParameters LightParameters;
    public int SmoothingFactor;

    public int Generations
    {
      get
      {
        return this.generations;
      }
      set
      {
        int b = Mathf.Clamp(value, 1, 8);
        if (this.quality == LightningBoltQualitySetting.UseScript)
        {
          this.generations = b;
        }
        else
        {
          int qualityLevel = QualitySettings.GetQualityLevel();
          LightningQualityMaximum lightningQualityMaximum;
          if (LightningBoltParameters.QualityMaximums.TryGetValue(qualityLevel, out lightningQualityMaximum))
          {
            this.generations = Mathf.Min(lightningQualityMaximum.MaximumGenerations, b);
          }
          else
          {
            this.generations = b;
            Debug.LogError((object) ("Unable to read lightning quality settings from level " + qualityLevel.ToString()));
          }
        }
      }
    }

    public float GrowthMultiplier
    {
      get
      {
        return this.growthMultiplier;
      }
      set
      {
        this.growthMultiplier = Mathf.Clamp(value, 0.0f, 0.999f);
      }
    }

    public List<Vector3> Points { get; set; }

    static LightningBoltParameters()
    {
      string[] names = QualitySettings.names;
      for (int index = 0; index < names.Length; ++index)
      {
        switch (index)
        {
          case 0:
            LightningBoltParameters.QualityMaximums[index] = new LightningQualityMaximum()
            {
              MaximumGenerations = 3,
              MaximumLightPercent = 0.0f,
              MaximumShadowPercent = 0.0f
            };
            break;
          case 1:
            LightningBoltParameters.QualityMaximums[index] = new LightningQualityMaximum()
            {
              MaximumGenerations = 4,
              MaximumLightPercent = 0.0f,
              MaximumShadowPercent = 0.0f
            };
            break;
          case 2:
            LightningBoltParameters.QualityMaximums[index] = new LightningQualityMaximum()
            {
              MaximumGenerations = 5,
              MaximumLightPercent = 0.1f,
              MaximumShadowPercent = 0.0f
            };
            break;
          case 3:
            LightningBoltParameters.QualityMaximums[index] = new LightningQualityMaximum()
            {
              MaximumGenerations = 5,
              MaximumLightPercent = 0.1f,
              MaximumShadowPercent = 0.0f
            };
            break;
          case 4:
            LightningBoltParameters.QualityMaximums[index] = new LightningQualityMaximum()
            {
              MaximumGenerations = 6,
              MaximumLightPercent = 0.05f,
              MaximumShadowPercent = 0.1f
            };
            break;
          case 5:
            LightningBoltParameters.QualityMaximums[index] = new LightningQualityMaximum()
            {
              MaximumGenerations = 7,
              MaximumLightPercent = 0.025f,
              MaximumShadowPercent = 0.05f
            };
            break;
          default:
            LightningBoltParameters.QualityMaximums[index] = new LightningQualityMaximum()
            {
              MaximumGenerations = 8,
              MaximumLightPercent = 0.025f,
              MaximumShadowPercent = 0.05f
            };
            break;
        }
      }
    }

    public float ForkMultiplier()
    {
      return (float) this.Random.NextDouble() * this.ForkLengthVariance + this.ForkLengthMultiplier;
    }

    public Vector3 ApplyVariance(Vector3 pos, Vector3 variance)
    {
      return new Vector3(pos.x + (float) (this.Random.NextDouble() * 2.0 - 1.0) * variance.x, pos.y + (float) (this.Random.NextDouble() * 2.0 - 1.0) * variance.y, pos.z + (float) (this.Random.NextDouble() * 2.0 - 1.0) * variance.z);
    }

    public static LightningBoltParameters GetOrCreateParameters()
    {
      LightningBoltParameters lightningBoltParameters;
      if (LightningBoltParameters.cache.Count == 0)
      {
        lightningBoltParameters = new LightningBoltParameters()
        {
          Random = new System.Random(UnityEngine.Random.Range(int.MinValue, int.MaxValue))
        };
      }
      else
      {
        int index = LightningBoltParameters.cache.Count - 1;
        lightningBoltParameters = LightningBoltParameters.cache[index];
        LightningBoltParameters.cache.RemoveAt(index);
      }
      return lightningBoltParameters;
    }

    public static void ReturnParametersToCache(LightningBoltParameters p)
    {
      if (LightningBoltParameters.cache.Contains(p))
        return;
      p.Start = p.End = Vector3.zero;
      p.Points = (List<Vector3>) null;
      p.Generator = (LightningGenerator) null;
      p.SmoothingFactor = 0;
      LightningBoltParameters.cache.Add(p);
    }
  }
}
