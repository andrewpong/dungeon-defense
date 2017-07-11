// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBolt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Rendering;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBolt
  {
    public static int MaximumLightCount = 128;
    public static int MaximumLightsPerBatch = 8;
    private readonly List<LightningBoltSegmentGroup> segmentGroups = new List<LightningBoltSegmentGroup>();
    private readonly List<LightningBoltSegmentGroup> segmentGroupsWithLight = new List<LightningBoltSegmentGroup>();
    private readonly List<LightningBolt.LineRendererMesh> activeLineRenderers = new List<LightningBolt.LineRendererMesh>();
    private readonly List<LightningBolt.LineRendererMesh> lineRendererCache = new List<LightningBolt.LineRendererMesh>();
    private readonly List<LightningBoltSegmentGroup> groupCache = new List<LightningBoltSegmentGroup>();
    private readonly List<Light> lightCache = new List<Light>();
    private LightningBoltDependencies dependencies;
    private float elapsedTime;
    private float lifeTime;
    private bool hasLight;
    private float timeSinceLevelLoad;
    private static int lightCount;

    public float MinimumDelay { get; private set; }

    public bool HasGlow { get; private set; }

    public bool IsActive
    {
      get
      {
        return (double) this.elapsedTime < (double) this.lifeTime;
      }
    }

    public CameraMode CameraMode { get; private set; }

    public float StartTimeOffset { get; private set; }

    public void SetupLightningBolt(LightningBoltDependencies dependencies)
    {
      if (dependencies == null || dependencies.Parameters.Count == 0)
        UnityEngine.Debug.LogError((object) "Lightning bolt dependencies must not be null");
      else if (this.dependencies != null)
      {
        UnityEngine.Debug.LogError((object) "This lightning bolt is already in use!");
      }
      else
      {
        this.dependencies = dependencies;
        this.CameraMode = dependencies.CameraMode;
        this.timeSinceLevelLoad = Time.timeSinceLevelLoad;
        this.CheckForGlow((IEnumerable<LightningBoltParameters>) dependencies.Parameters);
        this.MinimumDelay = float.MaxValue;
        this.GetOrCreateLineRenderer();
        if (dependencies.ThreadState != null)
        {
          this.StartTimeOffset = 0.01666667f;
          dependencies.ThreadState.AddActionForBackgroundThread(new Action(this.ProcessAllLightningParameters));
        }
        else
        {
          this.StartTimeOffset = 0.0f;
          this.ProcessAllLightningParameters();
        }
      }
    }

    public bool Update()
    {
      this.elapsedTime += Time.deltaTime;
      if ((double) this.elapsedTime > (double) this.lifeTime)
        return false;
      if (this.hasLight)
        this.UpdateLights();
      return true;
    }

    public void Cleanup(bool willCache)
    {
      foreach (LightningBoltSegmentGroup boltSegmentGroup in this.segmentGroupsWithLight)
      {
        foreach (Light light in boltSegmentGroup.Lights)
          this.CleanupLight(light, willCache);
      }
      foreach (LightningBoltSegmentGroup segmentGroup in this.segmentGroups)
        this.groupCache.Add(segmentGroup);
      this.segmentGroups.Clear();
      this.segmentGroupsWithLight.Clear();
      this.hasLight = false;
      this.elapsedTime = 0.0f;
      this.lifeTime = 0.0f;
      if (this.dependencies != null)
      {
        this.dependencies.ReturnToCache(this.dependencies);
        this.dependencies = (LightningBoltDependencies) null;
      }
      if (willCache)
      {
        foreach (LightningBolt.LineRendererMesh activeLineRenderer in this.activeLineRenderers)
        {
          if (activeLineRenderer != null)
          {
            activeLineRenderer.Reset();
            this.lineRendererCache.Add(activeLineRenderer);
          }
        }
      }
      else
      {
        foreach (LightningBolt.LineRendererMesh activeLineRenderer in this.activeLineRenderers)
        {
          if (activeLineRenderer != null)
            activeLineRenderer.Cleanup();
        }
        foreach (LightningBolt.LineRendererMesh lineRendererMesh in this.lineRendererCache)
          lineRendererMesh.Cleanup();
        this.lineRendererCache.Clear();
        foreach (Light light in this.lightCache)
        {
          if ((UnityEngine.Object) light != (UnityEngine.Object) null && (UnityEngine.Object) light.gameObject != (UnityEngine.Object) null)
            UnityEngine.Object.Destroy((UnityEngine.Object) light.gameObject);
        }
        this.lightCache.Clear();
      }
      this.activeLineRenderers.Clear();
    }

    public LightningBoltSegmentGroup AddGroup()
    {
      LightningBoltSegmentGroup boltSegmentGroup;
      if (this.groupCache.Count == 0)
      {
        boltSegmentGroup = new LightningBoltSegmentGroup();
      }
      else
      {
        int index = this.groupCache.Count - 1;
        boltSegmentGroup = this.groupCache[index];
        boltSegmentGroup.Reset();
        this.groupCache.RemoveAt(index);
      }
      this.segmentGroups.Add(boltSegmentGroup);
      return boltSegmentGroup;
    }

    private void CleanupLight(Light l, bool returnToCache)
    {
      if (!((UnityEngine.Object) l != (UnityEngine.Object) null))
        return;
      this.dependencies.LightRemoved(l);
      if (returnToCache)
      {
        this.lightCache.Add(l);
        l.gameObject.SetActive(false);
      }
      else
        UnityEngine.Object.Destroy((UnityEngine.Object) l.gameObject);
      --LightningBolt.lightCount;
    }

    private void EnableLineRenderer(LightningBolt.LineRendererMesh lineRenderer, int tag)
    {
      if (lineRenderer == null || !((UnityEngine.Object) lineRenderer.GameObject != (UnityEngine.Object) null) || lineRenderer.Tag != tag || !this.IsActive)
        return;
      lineRenderer.PopulateMesh();
    }

    [DebuggerHidden]
    private IEnumerator EnableLastRendererCoRoutine()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new LightningBolt.\u003CEnableLastRendererCoRoutine\u003Ec__Iterator0()
      {
        \u0024this = this
      };
    }

    private LightningBolt.LineRendererMesh GetOrCreateLineRenderer()
    {
      LightningBolt.LineRendererMesh lineRendererMesh;
      if (this.lineRendererCache.Count == 0)
      {
        lineRendererMesh = new LightningBolt.LineRendererMesh();
      }
      else
      {
        int index = this.lineRendererCache.Count - 1;
        lineRendererMesh = this.lineRendererCache[index];
        this.lineRendererCache.RemoveAt(index);
      }
      lineRendererMesh.GameObject.transform.parent = (Transform) null;
      lineRendererMesh.GameObject.transform.rotation = Quaternion.identity;
      lineRendererMesh.GameObject.transform.localScale = Vector3.one;
      lineRendererMesh.GameObject.transform.parent = this.dependencies.Parent.transform;
      lineRendererMesh.GameObject.layer = this.dependencies.Parent.layer;
      if (this.dependencies.UseWorldSpace)
        lineRendererMesh.GameObject.transform.position = Vector3.zero;
      else
        lineRendererMesh.GameObject.transform.localPosition = Vector3.zero;
      lineRendererMesh.Material = !this.HasGlow ? this.dependencies.LightningMaterialMeshNoGlow : this.dependencies.LightningMaterialMesh;
      lineRendererMesh.MeshRenderer.sortingLayerName = this.dependencies.SortLayerName;
      lineRendererMesh.MeshRenderer.sortingOrder = this.dependencies.SortOrderInLayer;
      this.activeLineRenderers.Add(lineRendererMesh);
      return lineRendererMesh;
    }

    private void RenderGroup(LightningBoltSegmentGroup group, LightningBoltParameters p)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      LightningBolt.\u003CRenderGroup\u003Ec__AnonStorey2 groupCAnonStorey2 = new LightningBolt.\u003CRenderGroup\u003Ec__AnonStorey2();
      // ISSUE: reference to a compiler-generated field
      groupCAnonStorey2.\u0024this = this;
      if (group.SegmentCount == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      groupCAnonStorey2.currentLineRenderer = this.activeLineRenderers[this.activeLineRenderers.Count - 1];
      float x = this.timeSinceLevelLoad + group.Delay + this.StartTimeOffset;
      Vector4 fadeLifeTime = new Vector4(x, x + group.PeakStart, x + group.PeakEnd, x + group.LifeTime);
      float radius = group.LineWidth * 0.5f * LightningBoltParameters.Scale;
      int lineCount = group.Segments.Count - group.StartIndex;
      float num1 = (radius - radius * group.EndWidthMultiplier) / (float) lineCount;
      float num2;
      float num3;
      if ((double) p.GrowthMultiplier > 0.0)
      {
        num2 = group.LifeTime / (float) lineCount * p.GrowthMultiplier;
        num3 = 0.0f;
      }
      else
      {
        num2 = 0.0f;
        num3 = 0.0f;
      }
      // ISSUE: reference to a compiler-generated field
      if (!groupCAnonStorey2.currentLineRenderer.PrepareForLines(lineCount))
      {
        if (this.dependencies.ThreadState != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.dependencies.ThreadState.AddActionForMainThread(new Action(groupCAnonStorey2.\u003C\u003Em__0), true);
        }
        else
        {
          this.EnableCurrentLineRenderer();
          // ISSUE: reference to a compiler-generated field
          groupCAnonStorey2.currentLineRenderer = this.GetOrCreateLineRenderer();
        }
      }
      // ISSUE: reference to a compiler-generated field
      groupCAnonStorey2.currentLineRenderer.BeginLine(group.Segments[group.StartIndex].Start, group.Segments[group.StartIndex].End, radius, group.Color, p.Intensity, fadeLifeTime, p.GlowWidthMultiplier, p.GlowIntensity);
      for (int index = group.StartIndex + 1; index < group.Segments.Count; ++index)
      {
        radius -= num1;
        if ((double) p.GrowthMultiplier < 1.0)
        {
          num3 += num2;
          fadeLifeTime = (Vector4) new Color(x + num3, x + group.PeakStart + num3, x + group.PeakEnd, x + group.LifeTime);
        }
        // ISSUE: reference to a compiler-generated field
        groupCAnonStorey2.currentLineRenderer.AppendLine(group.Segments[index].Start, group.Segments[index].End, radius, group.Color, p.Intensity, fadeLifeTime, p.GlowWidthMultiplier, p.GlowIntensity);
      }
    }

    private void ProcessParameters(LightningBoltParameters p, RangeOfFloats delay)
    {
      this.MinimumDelay = Mathf.Min(delay.Minimum, this.MinimumDelay);
      p.Random = p.Random ?? new System.Random(UnityEngine.Random.Range(int.MinValue, int.MaxValue));
      p.delaySeconds = delay.Random(p.Random);
      p.generationWhereForksStop = p.Generations - p.GenerationWhereForksStopSubtractor;
      this.lifeTime = Mathf.Max(p.LifeTime + p.delaySeconds, this.lifeTime);
      p.forkednessCalculated = (int) Mathf.Ceil(p.Forkedness * (float) p.Generations);
      if (p.Generations <= 0)
        return;
      p.Generator = p.Generator ?? LightningGenerator.GeneratorInstance;
      p.Generator.GenerateLightningBolt(this, p);
    }

    private void ProcessAllLightningParameters()
    {
      int num = LightningBolt.MaximumLightsPerBatch / this.dependencies.Parameters.Count;
      RangeOfFloats delay = new RangeOfFloats();
      List<int> intList = new List<int>(this.dependencies.Parameters.Count + 1);
      int index = 0;
      foreach (LightningBoltParameters parameter in (IEnumerable<LightningBoltParameters>) this.dependencies.Parameters)
      {
        delay.Minimum = parameter.DelayRange.Minimum + parameter.Delay;
        delay.Maximum = parameter.DelayRange.Maximum + parameter.Delay;
        parameter.maxLights = num;
        intList.Add(this.segmentGroups.Count);
        this.ProcessParameters(parameter, delay);
      }
      intList.Add(this.segmentGroups.Count);
      foreach (LightningBoltParameters parameter in (IEnumerable<LightningBoltParameters>) this.dependencies.Parameters)
        this.RenderLightningBolt(parameter.quality, parameter.Generations, intList[index], intList[++index], parameter);
      if (this.dependencies.ThreadState != null)
      {
        this.dependencies.ThreadState.AddActionForMainThread(new Action(this.EnableCurrentLineRendererFromThread), false);
      }
      else
      {
        this.EnableCurrentLineRenderer();
        this.dependencies.AddActiveBolt(this);
      }
    }

    private void EnableCurrentLineRendererFromThread()
    {
      this.EnableCurrentLineRenderer();
      this.dependencies.ThreadState = (LightningThreadState) null;
      this.dependencies.AddActiveBolt(this);
    }

    private void EnableCurrentLineRenderer()
    {
      if ((double) this.MinimumDelay <= 0.0)
      {
        this.EnableLineRenderer(this.activeLineRenderers[this.activeLineRenderers.Count - 1], this.activeLineRenderers[this.activeLineRenderers.Count - 1].Tag);
      }
      else
      {
        Coroutine coroutine = this.dependencies.StartCoroutine(this.EnableLastRendererCoRoutine());
      }
    }

    private void RenderParticleSystems(Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds)
    {
      if ((double) trunkWidth <= 0.0)
        return;
      if ((UnityEngine.Object) this.dependencies.OriginParticleSystem != (UnityEngine.Object) null)
      {
        Coroutine coroutine1 = this.dependencies.StartCoroutine(this.GenerateParticleCoRoutine(this.dependencies.OriginParticleSystem, start, delaySeconds));
      }
      if (!((UnityEngine.Object) this.dependencies.DestParticleSystem != (UnityEngine.Object) null))
        return;
      Coroutine coroutine2 = this.dependencies.StartCoroutine(this.GenerateParticleCoRoutine(this.dependencies.DestParticleSystem, end, delaySeconds + lifeTime * 0.8f));
    }

    private void RenderLightningBolt(LightningBoltQualitySetting quality, int generations, int startGroupIndex, int endGroupIndex, LightningBoltParameters parameters)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      LightningBolt.\u003CRenderLightningBolt\u003Ec__AnonStorey3 boltCAnonStorey3 = new LightningBolt.\u003CRenderLightningBolt\u003Ec__AnonStorey3();
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.parameters = parameters;
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.startGroupIndex = startGroupIndex;
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.quality = quality;
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      if (this.segmentGroups.Count == 0 || boltCAnonStorey3.startGroupIndex >= this.segmentGroups.Count || endGroupIndex > this.segmentGroups.Count)
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.lp = boltCAnonStorey3.parameters.LightParameters;
      // ISSUE: reference to a compiler-generated field
      if (boltCAnonStorey3.lp != null)
      {
        // ISSUE: reference to a compiler-generated field
        if (this.hasLight |= boltCAnonStorey3.lp.HasLight)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          boltCAnonStorey3.lp.LightPercent = Mathf.Clamp(boltCAnonStorey3.lp.LightPercent, Mathf.Epsilon, 1f);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          boltCAnonStorey3.lp.LightShadowPercent = Mathf.Clamp(boltCAnonStorey3.lp.LightShadowPercent, 0.0f, 1f);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          boltCAnonStorey3.lp = (LightningLightParameters) null;
        }
      }
      // ISSUE: reference to a compiler-generated field
      LightningBoltSegmentGroup segmentGroup1 = this.segmentGroups[boltCAnonStorey3.startGroupIndex];
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.start = segmentGroup1.Segments[segmentGroup1.StartIndex].Start;
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.end = segmentGroup1.Segments[segmentGroup1.StartIndex + segmentGroup1.SegmentCount - 1].End;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      boltCAnonStorey3.parameters.FadePercent = Mathf.Clamp(boltCAnonStorey3.parameters.FadePercent, 0.0f, 0.5f);
      // ISSUE: reference to a compiler-generated field
      for (int startGroupIndex1 = boltCAnonStorey3.startGroupIndex; startGroupIndex1 < endGroupIndex; ++startGroupIndex1)
      {
        LightningBoltSegmentGroup segmentGroup2 = this.segmentGroups[startGroupIndex1];
        // ISSUE: reference to a compiler-generated field
        segmentGroup2.Delay = boltCAnonStorey3.parameters.delaySeconds;
        // ISSUE: reference to a compiler-generated field
        segmentGroup2.LifeTime = boltCAnonStorey3.parameters.LifeTime;
        // ISSUE: reference to a compiler-generated field
        segmentGroup2.PeakStart = segmentGroup2.LifeTime * boltCAnonStorey3.parameters.FadePercent;
        segmentGroup2.PeakEnd = segmentGroup2.LifeTime - segmentGroup2.PeakStart;
        // ISSUE: reference to a compiler-generated field
        segmentGroup2.LightParameters = boltCAnonStorey3.lp;
        // ISSUE: reference to a compiler-generated field
        this.RenderGroup(segmentGroup2, boltCAnonStorey3.parameters);
      }
      if (this.dependencies.ThreadState != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.dependencies.ThreadState.AddActionForMainThread(new Action(boltCAnonStorey3.\u003C\u003Em__0), false);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.RenderParticleSystems(boltCAnonStorey3.start, boltCAnonStorey3.end, boltCAnonStorey3.parameters.TrunkWidth, boltCAnonStorey3.parameters.LifeTime, boltCAnonStorey3.parameters.delaySeconds);
        // ISSUE: reference to a compiler-generated field
        if (boltCAnonStorey3.lp != null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.CreateLightsForGroup(this.segmentGroups[boltCAnonStorey3.startGroupIndex], boltCAnonStorey3.lp, boltCAnonStorey3.quality, boltCAnonStorey3.parameters.maxLights);
        }
        // ISSUE: reference to a compiler-generated field
        LightningBoltParameters.ReturnParametersToCache(boltCAnonStorey3.parameters);
      }
    }

    private void CreateLightsForGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, LightningBoltQualitySetting quality, int maxLights)
    {
      if (LightningBolt.lightCount == LightningBolt.MaximumLightCount || maxLights <= 0)
        return;
      this.segmentGroupsWithLight.Add(group);
      int segmentCount = group.SegmentCount;
      float num1;
      float num2;
      if (quality == LightningBoltQualitySetting.LimitToQualitySetting)
      {
        int qualityLevel = QualitySettings.GetQualityLevel();
        LightningQualityMaximum lightningQualityMaximum;
        if (LightningBoltParameters.QualityMaximums.TryGetValue(qualityLevel, out lightningQualityMaximum))
        {
          num1 = Mathf.Min(lp.LightPercent, lightningQualityMaximum.MaximumLightPercent);
          num2 = Mathf.Min(lp.LightShadowPercent, lightningQualityMaximum.MaximumShadowPercent);
        }
        else
        {
          UnityEngine.Debug.LogError((object) ("Unable to read lightning quality for level " + qualityLevel.ToString()));
          num1 = lp.LightPercent;
          num2 = lp.LightShadowPercent;
        }
      }
      else
      {
        num1 = lp.LightPercent;
        num2 = lp.LightShadowPercent;
      }
      maxLights = Mathf.Max(1, Mathf.Min(maxLights, (int) ((double) segmentCount * (double) num1)));
      int nthLight = Mathf.Max(1, segmentCount / maxLights);
      int nthShadows = maxLights - (int) ((double) maxLights * (double) num2);
      int nthShadowCounter = nthShadows;
      int segmentIndex = group.StartIndex + (int) ((double) nthLight * 0.5);
      while (segmentIndex < group.Segments.Count && !this.AddLightToGroup(group, lp, segmentIndex, nthLight, nthShadows, ref maxLights, ref nthShadowCounter))
        segmentIndex += nthLight;
    }

    private bool AddLightToGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, int segmentIndex, int nthLight, int nthShadows, ref int maxLights, ref int nthShadowCounter)
    {
      Light light = this.GetOrCreateLight(lp);
      group.Lights.Add(light);
      Vector3 vector3 = (group.Segments[segmentIndex].Start + group.Segments[segmentIndex].End) * 0.5f;
      if (this.dependencies.CameraIsOrthographic)
        vector3.z = this.dependencies.CameraPos.z;
      light.gameObject.transform.position = vector3;
      if ((double) lp.LightShadowPercent == 0.0 || (nthShadowCounter = nthShadowCounter + 1) < nthShadows)
      {
        light.shadows = LightShadows.None;
      }
      else
      {
        light.shadows = LightShadows.Soft;
        nthShadowCounter = 0;
      }
      if (++LightningBolt.lightCount != LightningBolt.MaximumLightCount)
        return (maxLights = maxLights - 1) == 0;
      return true;
    }

    private Light GetOrCreateLight(LightningLightParameters lp)
    {
      Light light;
      while (this.lightCache.Count != 0)
      {
        light = this.lightCache[this.lightCache.Count - 1];
        this.lightCache.RemoveAt(this.lightCache.Count - 1);
        if (!((UnityEngine.Object) light == (UnityEngine.Object) null))
          goto label_3;
      }
      light = new GameObject("LightningBoltLight").AddComponent<Light>();
      light.type = LightType.Point;
label_3:
      light.bounceIntensity = lp.BounceIntensity;
      light.shadowNormalBias = lp.ShadowNormalBias;
      light.color = lp.LightColor;
      light.renderMode = lp.RenderMode;
      light.range = lp.LightRange;
      light.shadowStrength = lp.ShadowStrength;
      light.shadowBias = lp.ShadowBias;
      light.intensity = 0.0f;
      light.gameObject.transform.parent = this.dependencies.Parent.transform;
      light.gameObject.SetActive(true);
      this.dependencies.LightAdded(light);
      return light;
    }

    private void UpdateLight(LightningLightParameters lp, IEnumerable<Light> lights, float delay, float peakStart, float peakEnd, float lifeTime)
    {
      if ((double) this.elapsedTime < (double) delay)
        return;
      float num = this.elapsedTime - delay;
      if ((double) num >= (double) peakStart)
      {
        if ((double) num <= (double) peakEnd)
        {
          foreach (Light light in lights)
            light.intensity = lp.LightIntensity;
        }
        else
        {
          float t = (float) (((double) num - (double) peakEnd) / ((double) lifeTime - (double) peakEnd));
          foreach (Light light in lights)
            light.intensity = Mathf.Lerp(lp.LightIntensity, 0.0f, t);
        }
      }
      else
      {
        float t = num / peakStart;
        foreach (Light light in lights)
          light.intensity = Mathf.Lerp(0.0f, lp.LightIntensity, t);
      }
    }

    private void UpdateLights()
    {
      foreach (LightningBoltSegmentGroup boltSegmentGroup in this.segmentGroupsWithLight)
        this.UpdateLight(boltSegmentGroup.LightParameters, (IEnumerable<Light>) boltSegmentGroup.Lights, boltSegmentGroup.Delay, boltSegmentGroup.PeakStart, boltSegmentGroup.PeakEnd, boltSegmentGroup.LifeTime);
    }

    [DebuggerHidden]
    private IEnumerator GenerateParticleCoRoutine(ParticleSystem p, Vector3 pos, float delay)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new LightningBolt.\u003CGenerateParticleCoRoutine\u003Ec__Iterator1()
      {
        delay = delay,
        pos = pos,
        p = p
      };
    }

    private void CheckForGlow(IEnumerable<LightningBoltParameters> parameters)
    {
      foreach (LightningBoltParameters parameter in parameters)
      {
        this.HasGlow = (double) parameter.GlowIntensity >= (double) Mathf.Epsilon && (double) parameter.GlowWidthMultiplier >= (double) Mathf.Epsilon;
        if (this.HasGlow)
          break;
      }
    }

    public class LineRendererMesh
    {
      private static readonly Vector2 uv1 = new Vector2(0.0f, 0.0f);
      private static readonly Vector2 uv2 = new Vector2(1f, 0.0f);
      private static readonly Vector2 uv3 = new Vector2(0.0f, 1f);
      private static readonly Vector2 uv4 = new Vector2(1f, 1f);
      private readonly List<int> indices = new List<int>();
      private readonly List<Vector3> vertices = new List<Vector3>();
      private readonly List<Vector4> lineDirs = new List<Vector4>();
      private readonly List<Color32> colors = new List<Color32>();
      private readonly List<Vector3> ends = new List<Vector3>();
      private readonly List<Vector4> texCoordsAndGlowModifiers = new List<Vector4>();
      private readonly List<Vector4> fadeLifetimes = new List<Vector4>();
      private int currentBoundsMinX = 1147483647;
      private int currentBoundsMinY = 1147483647;
      private int currentBoundsMinZ = 1147483647;
      private int currentBoundsMaxX = -1147483648;
      private int currentBoundsMaxY = -1147483648;
      private int currentBoundsMaxZ = -1147483648;
      private const int boundsPadder = 1000000000;
      private Mesh mesh;
      private MeshFilter meshFilter;
      private MeshRenderer meshRenderer;

      public GameObject GameObject { get; private set; }

      public Material Material
      {
        get
        {
          return this.meshRenderer.sharedMaterial;
        }
        set
        {
          this.meshRenderer.sharedMaterial = value;
        }
      }

      public MeshRenderer MeshRenderer
      {
        get
        {
          return this.meshRenderer;
        }
      }

      public int Tag { get; set; }

      public LineRendererMesh()
      {
        this.GameObject = new GameObject("LightningBoltMeshRenderer");
        this.GameObject.SetActive(false);
        Mesh mesh = new Mesh();
        mesh.name = "ProceduralLightningMesh";
        this.mesh = mesh;
        this.mesh.MarkDynamic();
        this.meshFilter = this.GameObject.AddComponent<MeshFilter>();
        this.meshFilter.sharedMesh = this.mesh;
        this.meshRenderer = this.GameObject.AddComponent<MeshRenderer>();
        this.meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
        this.meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.Off;
        this.meshRenderer.lightProbeUsage = LightProbeUsage.Off;
        this.meshRenderer.receiveShadows = false;
      }

      public void Cleanup()
      {
        UnityEngine.Object.Destroy((UnityEngine.Object) this.GameObject);
      }

      public void PopulateMesh()
      {
        if (this.vertices.Count == 0)
          this.mesh.Clear();
        else
          this.PopulateMeshInternal();
      }

      public bool PrepareForLines(int lineCount)
      {
        return this.vertices.Count + lineCount * 4 <= 64999;
      }

      public void BeginLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
      {
        Vector4 vector4 = (Vector4) (end - start);
        vector4.w = radius;
        this.AppendLineInternal(ref start, ref end, ref vector4, ref vector4, ref vector4, color, colorIntensity, ref fadeLifeTime, glowWidthModifier, glowIntensity);
      }

      public void AppendLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
      {
        Vector4 dir = (Vector4) (end - start);
        dir.w = radius;
        Vector4 lineDir1 = this.lineDirs[this.lineDirs.Count - 3];
        Vector4 lineDir2 = this.lineDirs[this.lineDirs.Count - 1];
        this.AppendLineInternal(ref start, ref end, ref dir, ref lineDir1, ref lineDir2, color, colorIntensity, ref fadeLifeTime, glowWidthModifier, glowIntensity);
      }

      public void Reset()
      {
        ++this.Tag;
        this.GameObject.SetActive(false);
        this.mesh.Clear();
        this.indices.Clear();
        this.vertices.Clear();
        this.colors.Clear();
        this.lineDirs.Clear();
        this.ends.Clear();
        this.texCoordsAndGlowModifiers.Clear();
        this.fadeLifetimes.Clear();
        this.currentBoundsMaxX = this.currentBoundsMaxY = this.currentBoundsMaxZ = -1147483648;
        this.currentBoundsMinX = this.currentBoundsMinY = this.currentBoundsMinZ = 1147483647;
      }

      private void PopulateMeshInternal()
      {
        this.GameObject.SetActive(true);
        this.mesh.SetVertices(this.vertices);
        this.mesh.SetTangents(this.lineDirs);
        this.mesh.SetColors(this.colors);
        this.mesh.SetUVs(0, this.texCoordsAndGlowModifiers);
        this.mesh.SetUVs(1, this.fadeLifetimes);
        this.mesh.SetNormals(this.ends);
        this.mesh.SetTriangles(this.indices, 0);
        Bounds bounds = new Bounds();
        Vector3 vector3_1 = new Vector3((float) (this.currentBoundsMinX - 2), (float) (this.currentBoundsMinY - 2), (float) (this.currentBoundsMinZ - 2));
        Vector3 vector3_2 = new Vector3((float) (this.currentBoundsMaxX + 2), (float) (this.currentBoundsMaxY + 2), (float) (this.currentBoundsMaxZ + 2));
        bounds.center = (vector3_2 + vector3_1) * 0.5f;
        bounds.size = (vector3_2 - vector3_1) * 1.2f;
        this.mesh.bounds = bounds;
      }

      private void UpdateBounds(ref Vector3 point1, ref Vector3 point2)
      {
        int num1 = (int) point1.x - (int) point2.x;
        int num2 = num1 & num1 >> 31;
        int num3 = (int) point2.x + num2;
        int num4 = (int) point1.x - num2;
        int num5 = this.currentBoundsMinX - num3;
        int num6 = num5 & num5 >> 31;
        this.currentBoundsMinX = num3 + num6;
        int num7 = this.currentBoundsMaxX - num4;
        this.currentBoundsMaxX = this.currentBoundsMaxX - (num7 & num7 >> 31);
        int num8 = (int) point1.y - (int) point2.y;
        int num9 = num8 & num8 >> 31;
        int num10 = (int) point2.y + num9;
        int num11 = (int) point1.y - num9;
        int num12 = this.currentBoundsMinY - num10;
        int num13 = num12 & num12 >> 31;
        this.currentBoundsMinY = num10 + num13;
        int num14 = this.currentBoundsMaxY - num11;
        this.currentBoundsMaxY = this.currentBoundsMaxY - (num14 & num14 >> 31);
        int num15 = (int) point1.z - (int) point2.z;
        int num16 = num15 & num15 >> 31;
        int num17 = (int) point2.z + num16;
        int num18 = (int) point1.z - num16;
        int num19 = this.currentBoundsMinZ - num17;
        int num20 = num19 & num19 >> 31;
        this.currentBoundsMinZ = num17 + num20;
        int num21 = this.currentBoundsMaxZ - num18;
        this.currentBoundsMaxZ = this.currentBoundsMaxZ - (num21 & num21 >> 31);
      }

      private void AddIndices()
      {
        int count = this.vertices.Count;
        List<int> indices1 = this.indices;
        int num1 = count;
        int num2 = 1;
        int num3 = num1 + num2;
        indices1.Add(num1);
        List<int> indices2 = this.indices;
        int num4 = num3;
        int num5 = 1;
        int num6 = num4 + num5;
        indices2.Add(num4);
        this.indices.Add(num6);
        List<int> indices3 = this.indices;
        int num7 = num6;
        int num8 = 1;
        int num9 = num7 - num8;
        indices3.Add(num7);
        this.indices.Add(num9);
        int num10;
        this.indices.Add(num10 = num9 + 2);
      }

      private void AppendLineInternal(ref Vector3 start, ref Vector3 end, ref Vector4 dir, ref Vector4 dirPrev1, ref Vector4 dirPrev2, Color32 color, float colorIntensity, ref Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
      {
        this.AddIndices();
        color.a = (byte) Mathf.Lerp(0.0f, (float) byte.MaxValue, colorIntensity * 0.1f);
        Vector4 vector4 = new Vector4(LightningBolt.LineRendererMesh.uv1.x, LightningBolt.LineRendererMesh.uv1.y, glowWidthModifier, glowIntensity);
        this.vertices.Add(start);
        this.lineDirs.Add(dirPrev1);
        this.colors.Add(color);
        this.ends.Add((Vector3) dir);
        this.vertices.Add(end);
        this.lineDirs.Add(dir);
        this.colors.Add(color);
        this.ends.Add((Vector3) dir);
        dir.w = -dir.w;
        this.vertices.Add(start);
        this.lineDirs.Add(dirPrev2);
        this.colors.Add(color);
        this.ends.Add((Vector3) dir);
        this.vertices.Add(end);
        this.lineDirs.Add(dir);
        this.colors.Add(color);
        this.ends.Add((Vector3) dir);
        this.texCoordsAndGlowModifiers.Add(vector4);
        vector4.x = LightningBolt.LineRendererMesh.uv2.x;
        vector4.y = LightningBolt.LineRendererMesh.uv2.y;
        this.texCoordsAndGlowModifiers.Add(vector4);
        vector4.x = LightningBolt.LineRendererMesh.uv3.x;
        vector4.y = LightningBolt.LineRendererMesh.uv3.y;
        this.texCoordsAndGlowModifiers.Add(vector4);
        vector4.x = LightningBolt.LineRendererMesh.uv4.x;
        vector4.y = LightningBolt.LineRendererMesh.uv4.y;
        this.texCoordsAndGlowModifiers.Add(vector4);
        this.fadeLifetimes.Add(fadeLifeTime);
        this.fadeLifetimes.Add(fadeLifeTime);
        this.fadeLifetimes.Add(fadeLifeTime);
        this.fadeLifetimes.Add(fadeLifeTime);
        this.UpdateBounds(ref start, ref end);
      }
    }
  }
}
