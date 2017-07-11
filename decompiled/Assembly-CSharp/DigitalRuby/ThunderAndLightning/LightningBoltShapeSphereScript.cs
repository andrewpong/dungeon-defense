// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltShapeSphereScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBoltShapeSphereScript : LightningBoltPrefabScriptBase
  {
    [Header("Lightning Sphere Properties")]
    [Tooltip("Radius inside the sphere where lightning can emit from")]
    public float InnerRadius = 0.1f;
    [Tooltip("Radius of the sphere")]
    public float Radius = 4f;

    public override void CreateLightningBolt(LightningBoltParameters parameters)
    {
      Vector3 vector3_1 = Random.insideUnitSphere * this.InnerRadius;
      Vector3 vector3_2 = Random.onUnitSphere * this.Radius;
      parameters.Start = vector3_1;
      parameters.End = vector3_2;
      base.CreateLightningBolt(parameters);
    }
  }
}
