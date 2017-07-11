// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningMeshSurfaceScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningMeshSurfaceScript : LightningBoltPrefabScriptBase
  {
    [SingleLine("Random range that the point will offset from the mesh, using the normal of the chosen point to offset")]
    public RangeOfFloats MeshOffsetRange = new RangeOfFloats() { Minimum = 0.5f, Maximum = 1f };
    [Header("Lightning Path Properties")]
    [SingleLine("Range for points in the lightning path")]
    public RangeOfIntegers PathLengthCount = new RangeOfIntegers() { Minimum = 3, Maximum = 6 };
    [SingleLine("Range for minimum distance between points in the lightning path")]
    public RangeOfFloats MinimumPathDistanceRange = new RangeOfFloats() { Minimum = 0.5f, Maximum = 1f };
    [Tooltip("The maximum distance between mesh points. When walking the mesh, if a point is greater than this, the path direction is reversed. This tries to avoid paths crossing between mesh points that are not actually physically touching.")]
    public float MaximumPathDistance = 2f;
    private readonly List<Vector3> sourcePoints = new List<Vector3>();
    [Header("Lightning Mesh Properties")]
    [Tooltip("The mesh filter. You must assign a mesh filter in order to create lightning on the mesh.")]
    public MeshFilter MeshFilter;
    [Tooltip("The mesh collider. This is used to get random points on the mesh.")]
    public Collider MeshCollider;
    private float maximumPathDistanceSquared;
    [Tooltip("Whether to use spline interpolation between the path points. Paths must be at least 4 points long to be splined.")]
    public bool Spline;
    [Tooltip("For spline. the distance hint for each spline segment. Set to <= 0 to use the generations to determine how many spline segments to use. If > 0, it will be divided by Generations before being applied. This value is a guideline and is approximate, and not uniform on the spline.")]
    public float DistancePerSegmentHint;
    private Mesh previousMesh;
    private MeshHelper meshHelper;

    private void CheckMesh()
    {
      if ((Object) this.MeshFilter == (Object) null || (Object) this.MeshFilter.sharedMesh == (Object) null)
      {
        this.meshHelper = (MeshHelper) null;
      }
      else
      {
        if (!((Object) this.MeshFilter.sharedMesh != (Object) this.previousMesh))
          return;
        this.previousMesh = this.MeshFilter.sharedMesh;
        this.meshHelper = new MeshHelper(this.previousMesh);
      }
    }

    protected override LightningBoltParameters OnCreateParameters()
    {
      LightningBoltParameters parameters = base.OnCreateParameters();
      parameters.Generator = (LightningGenerator) LightningGeneratorPath.PathGeneratorInstance;
      return parameters;
    }

    protected virtual void PopulateSourcePoints(List<Vector3> points)
    {
      if (this.meshHelper == null)
        return;
      this.CreateRandomLightningPath(this.sourcePoints);
    }

    public void CreateRandomLightningPath(List<Vector3> points)
    {
      if (this.meshHelper == null)
        return;
      RaycastHit hit = new RaycastHit();
      this.maximumPathDistanceSquared = this.MaximumPathDistance * this.MaximumPathDistance;
      int triangleIndex;
      this.meshHelper.GenerateRandomPoint(ref hit, out triangleIndex);
      hit.distance = Random.Range(this.MeshOffsetRange.Minimum, this.MeshOffsetRange.Maximum);
      Vector3 position1 = hit.point + hit.normal * hit.distance;
      float num1 = Random.Range(this.MinimumPathDistanceRange.Minimum, this.MinimumPathDistanceRange.Maximum);
      float num2 = num1 * num1;
      this.sourcePoints.Add(this.MeshFilter.transform.TransformPoint(position1));
      int num3 = Random.Range(0, 1) != 1 ? -3 : 3;
      int num4 = Random.Range(this.PathLengthCount.Minimum, this.PathLengthCount.Maximum);
      while (num4 != 0)
      {
        triangleIndex += num3;
        if (triangleIndex >= 0 && triangleIndex < this.meshHelper.Triangles.Length)
        {
          this.meshHelper.GetRaycastFromTriangleIndex(triangleIndex, ref hit);
          hit.distance = Random.Range(this.MeshOffsetRange.Minimum, this.MeshOffsetRange.Maximum);
          Vector3 position2 = hit.point + hit.normal * hit.distance;
          float sqrMagnitude = (position2 - position1).sqrMagnitude;
          if ((double) sqrMagnitude > (double) this.maximumPathDistanceSquared)
            break;
          if ((double) sqrMagnitude >= (double) num2)
          {
            position1 = position2;
            this.sourcePoints.Add(this.MeshFilter.transform.TransformPoint(position2));
            --num4;
            float num5 = Random.Range(this.MinimumPathDistanceRange.Minimum, this.MinimumPathDistanceRange.Maximum);
            num2 = num5 * num5;
          }
        }
        else
        {
          num3 = -num3;
          triangleIndex += num3;
          --num4;
        }
      }
    }

    protected override void Start()
    {
      base.Start();
    }

    protected override void Update()
    {
      this.CheckMesh();
      base.Update();
    }

    public override void CreateLightningBolt(LightningBoltParameters parameters)
    {
      if (this.meshHelper == null)
        return;
      int num = Mathf.Clamp(this.Generations, 1, 5);
      parameters.Generations = num;
      this.Generations = num;
      this.sourcePoints.Clear();
      this.PopulateSourcePoints(this.sourcePoints);
      if (this.sourcePoints.Count <= 1)
        return;
      if (this.Spline && this.sourcePoints.Count > 3)
      {
        parameters.Points = new List<Vector3>(this.sourcePoints.Count * this.Generations);
        LightningSplineScript.PopulateSpline(parameters.Points, this.sourcePoints, this.Generations, this.DistancePerSegmentHint, this.Camera);
        parameters.SmoothingFactor = (parameters.Points.Count - 1) / this.sourcePoints.Count;
      }
      else
      {
        parameters.Points = new List<Vector3>((IEnumerable<Vector3>) this.sourcePoints);
        parameters.SmoothingFactor = 1;
      }
      base.CreateLightningBolt(parameters);
    }
  }
}
