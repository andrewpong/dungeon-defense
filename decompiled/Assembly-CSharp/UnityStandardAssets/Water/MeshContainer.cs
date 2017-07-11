// Decompiled with JetBrains decompiler
// Type: UnityStandardAssets.Water.MeshContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
