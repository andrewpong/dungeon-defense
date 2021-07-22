// Decompiled with JetBrains decompiler
// Type: UnityStandardAssets.Water.MeshContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace UnityStandardAssets.Water
{
  public class MeshContainer
  {
    public Mesh mesh;
    public Vector3[] vertices;
    public Vector3[] normals;

    public MeshContainer(Mesh m)
    {
      this.mesh = m;
      this.vertices = m.vertices;
      this.normals = m.normals;
    }

    public void Update()
    {
      this.mesh.vertices = this.vertices;
      this.mesh.normals = this.normals;
    }
  }
}
