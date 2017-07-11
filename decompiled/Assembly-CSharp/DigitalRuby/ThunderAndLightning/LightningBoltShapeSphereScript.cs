// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltShapeSphereScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
