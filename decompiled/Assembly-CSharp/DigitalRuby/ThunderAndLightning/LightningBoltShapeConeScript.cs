// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltShapeConeScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBoltShapeConeScript : LightningBoltPrefabScriptBase
  {
    [Header("Lightning Cone Properties")]
    [Tooltip("Radius at base of cone where lightning can emit from")]
    public float InnerRadius = 0.1f;
    [Tooltip("Radius at outer part of the cone where lightning emits to")]
    public float OuterRadius = 4f;
    [Tooltip("The length of the cone from the center of the inner and outer circle")]
    public float Length = 4f;

    public override void CreateLightningBolt(LightningBoltParameters parameters)
    {
      Vector2 vector2_1 = Random.insideUnitCircle * this.InnerRadius;
      Vector3 vector3_1 = this.transform.rotation * new Vector3(vector2_1.x, vector2_1.y, 0.0f);
      Vector2 vector2_2 = Random.insideUnitCircle * this.OuterRadius;
      Vector3 vector3_2 = this.transform.rotation * new Vector3(vector2_2.x, vector2_2.y, 0.0f) + this.transform.forward * this.Length;
      parameters.Start = vector3_1;
      parameters.End = vector3_2;
      base.CreateLightningBolt(parameters);
    }
  }
}
