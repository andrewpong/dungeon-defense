// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningSplineScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningSplineScript : LightningBoltPathScriptBase
  {
    private readonly List<Vector3> prevSourcePoints = new List<Vector3>((IEnumerable<Vector3>) new Vector3[1]{ Vector3.zero });
    private readonly List<Vector3> sourcePoints = new List<Vector3>();
    private int previousGenerations = -1;
    private float previousDistancePerSegment = -1f;
    public const int MaxSplineGenerations = 5;
    [Header("Lightning Spline Properties")]
    [Tooltip("The distance hint for each spline segment. Set to <= 0 to use the generations to determine how many spline segments to use. If > 0, it will be divided by Generations before being applied. This value is a guideline and is approximate, and not uniform on the spline.")]
    public float DistancePerSegmentHint;
    private List<Vector3> savedSplinePoints;

    private bool SourceChanged()
    {
      if (this.sourcePoints.Count != this.prevSourcePoints.Count)
        return true;
      for (int index = 0; index < this.sourcePoints.Count; ++index)
      {
        if (this.sourcePoints[index] != this.prevSourcePoints[index])
          return true;
      }
      return false;
    }

    protected override void Start()
    {
      base.Start();
    }

    protected override void Update()
    {
      base.Update();
    }

    public override void CreateLightningBolt(LightningBoltParameters parameters)
    {
      if (this.LightningPath == null || this.LightningPath.List == null)
        return;
      this.sourcePoints.Clear();
      try
      {
        foreach (GameObject gameObject in this.LightningPath.List)
        {
          if ((UnityEngine.Object) gameObject != (UnityEngine.Object) null)
            this.sourcePoints.Add(gameObject.transform.position);
        }
      }
      catch (NullReferenceException ex)
      {
        return;
      }
      if (this.sourcePoints.Count < 4)
        Debug.LogError((object) ("To create spline lightning, you need a lightning path with at least " + (object) 4 + " points."));
      int num = Mathf.Clamp(this.Generations, 1, 5);
      parameters.Generations = num;
      this.Generations = num;
      if (this.previousGenerations != this.Generations || (double) this.previousDistancePerSegment != (double) this.DistancePerSegmentHint || this.SourceChanged())
      {
        this.previousGenerations = this.Generations;
        this.previousDistancePerSegment = this.DistancePerSegmentHint;
        parameters.Points = new List<Vector3>(this.sourcePoints.Count * this.Generations);
        LightningSplineScript.PopulateSpline(parameters.Points, this.sourcePoints, this.Generations, this.DistancePerSegmentHint, this.Camera);
        this.prevSourcePoints.Clear();
        this.prevSourcePoints.AddRange((IEnumerable<Vector3>) this.sourcePoints);
        this.savedSplinePoints = parameters.Points;
      }
      else
        parameters.Points = this.savedSplinePoints;
      parameters.SmoothingFactor = (parameters.Points.Count - 1) / this.sourcePoints.Count;
      base.CreateLightningBolt(parameters);
    }

    protected override LightningBoltParameters OnCreateParameters()
    {
      LightningBoltParameters parameters = LightningBoltParameters.GetOrCreateParameters();
      parameters.Generator = (LightningGenerator) LightningGeneratorPath.PathGeneratorInstance;
      return parameters;
    }

    public void Trigger(List<Vector3> points, bool spline)
    {
      if (points.Count < 2)
        return;
      this.Generations = Mathf.Clamp(this.Generations, 1, 5);
      LightningBoltParameters parameters = this.CreateParameters();
      if (spline && points.Count > 3)
      {
        parameters.Points = new List<Vector3>(points.Count * this.Generations);
        LightningSplineScript.PopulateSpline(parameters.Points, points, this.Generations, this.DistancePerSegmentHint, this.Camera);
        parameters.SmoothingFactor = (parameters.Points.Count - 1) / points.Count;
      }
      else
      {
        parameters.Points = new List<Vector3>((IEnumerable<Vector3>) points);
        parameters.SmoothingFactor = 1;
      }
      base.CreateLightningBolt(parameters);
      this.CreateLightningBoltsNow();
    }

    public static void PopulateSpline(List<Vector3> splinePoints, List<Vector3> sourcePoints, int generations, float distancePerSegmentHit, Camera camera)
    {
      splinePoints.Clear();
      PathGenerator.Is2D = (UnityEngine.Object) camera != (UnityEngine.Object) null && camera.orthographic;
      if ((double) distancePerSegmentHit > 0.0)
        PathGenerator.CreateSplineWithSegmentDistance((ICollection<Vector3>) splinePoints, (IList<Vector3>) sourcePoints, distancePerSegmentHit / (float) generations, false);
      else
        PathGenerator.CreateSpline((ICollection<Vector3>) splinePoints, (IList<Vector3>) sourcePoints, sourcePoints.Count * generations * generations, false);
    }
  }
}
