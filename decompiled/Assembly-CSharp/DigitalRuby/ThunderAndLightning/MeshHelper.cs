// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.MeshHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class MeshHelper
  {
    private Mesh mesh;
    private int[] triangles;
    private Vector3[] vertices;
    private Vector3[] normals;
    private float[] normalizedAreaWeights;

    public Mesh Mesh
    {
      get
      {
        return this.mesh;
      }
    }

    public int[] Triangles
    {
      get
      {
        return this.triangles;
      }
    }

    public Vector3[] Vertices
    {
      get
      {
        return this.vertices;
      }
    }

    public Vector3[] Normals
    {
      get
      {
        return this.normals;
      }
    }

    public MeshHelper(Mesh mesh)
    {
      this.mesh = mesh;
      this.triangles = mesh.triangles;
      this.vertices = mesh.vertices;
      this.normals = mesh.normals;
      this.CalculateNormalizedAreaWeights();
    }

    public void GenerateRandomPoint(ref RaycastHit hit, out int triangleIndex)
    {
      triangleIndex = this.SelectRandomTriangle();
      this.GetRaycastFromTriangleIndex(triangleIndex, ref hit);
    }

    public void GetRaycastFromTriangleIndex(int triangleIndex, ref RaycastHit hit)
    {
      Vector3 barycentricCoordinates = this.GenerateRandomBarycentricCoordinates();
      Vector3 vertex1 = this.vertices[this.triangles[triangleIndex]];
      Vector3 vertex2 = this.vertices[this.triangles[triangleIndex + 1]];
      Vector3 vertex3 = this.vertices[this.triangles[triangleIndex + 2]];
      hit.barycentricCoordinate = barycentricCoordinates;
      hit.point = vertex1 * barycentricCoordinates.x + vertex2 * barycentricCoordinates.y + vertex3 * barycentricCoordinates.z;
      if (this.normals == null)
      {
        hit.normal = Vector3.Cross(vertex3 - vertex2, vertex1 - vertex2).normalized;
      }
      else
      {
        Vector3 normal1 = this.normals[this.triangles[triangleIndex]];
        Vector3 normal2 = this.normals[this.triangles[triangleIndex + 1]];
        Vector3 normal3 = this.normals[this.triangles[triangleIndex + 2]];
        hit.normal = normal1 * barycentricCoordinates.x + normal2 * barycentricCoordinates.y + normal3 * barycentricCoordinates.z;
      }
    }

    private float[] CalculateSurfaceAreas(out float totalSurfaceArea)
    {
      int num1 = 0;
      totalSurfaceArea = 0.0f;
      float[] numArray = new float[this.triangles.Length / 3];
      int index = 0;
      while (index < this.triangles.Length)
      {
        Vector3 vertex1 = this.vertices[this.triangles[index]];
        Vector3 vertex2 = this.vertices[this.triangles[index + 1]];
        Vector3 vertex3 = this.vertices[this.triangles[index + 2]];
        float sqrMagnitude1 = (vertex1 - vertex2).sqrMagnitude;
        float sqrMagnitude2 = (vertex1 - vertex3).sqrMagnitude;
        float sqrMagnitude3 = (vertex2 - vertex3).sqrMagnitude;
        float num2 = PathGenerator.SquareRoot((float) ((2.0 * (double) sqrMagnitude1 * (double) sqrMagnitude2 + 2.0 * (double) sqrMagnitude2 * (double) sqrMagnitude3 + 2.0 * (double) sqrMagnitude3 * (double) sqrMagnitude1 - (double) sqrMagnitude1 * (double) sqrMagnitude1 - (double) sqrMagnitude2 * (double) sqrMagnitude2 - (double) sqrMagnitude3 * (double) sqrMagnitude3) / 16.0));
        numArray[num1++] = num2;
        totalSurfaceArea = totalSurfaceArea + num2;
        index += 3;
      }
      return numArray;
    }

    private void CalculateNormalizedAreaWeights()
    {
      float totalSurfaceArea;
      this.normalizedAreaWeights = this.CalculateSurfaceAreas(out totalSurfaceArea);
      if (this.normalizedAreaWeights.Length == 0)
        return;
      float num1 = 0.0f;
      for (int index = 0; index < this.normalizedAreaWeights.Length; ++index)
      {
        float num2 = this.normalizedAreaWeights[index] / totalSurfaceArea;
        this.normalizedAreaWeights[index] = num1;
        num1 += num2;
      }
    }

    private int SelectRandomTriangle()
    {
      float num1 = Random.value;
      int num2 = 0;
      int num3 = this.normalizedAreaWeights.Length - 1;
      while (num2 < num3)
      {
        int index = (num2 + num3) / 2;
        if ((double) this.normalizedAreaWeights[index] < (double) num1)
          num2 = index + 1;
        else
          num3 = index;
      }
      return num2 * 3;
    }

    private Vector3 GenerateRandomBarycentricCoordinates()
    {
      Vector3 vector3 = new Vector3(Random.Range(Mathf.Epsilon, 1f), Random.Range(Mathf.Epsilon, 1f), Random.Range(Mathf.Epsilon, 1f));
      return vector3 / (vector3.x + vector3.y + vector3.z);
    }
  }
}
