// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltPrefabScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBoltPrefabScript : LightningBoltPrefabScriptBase
  {
    [Header("Start/end")]
    [Tooltip("The source game object, can be null")]
    public GameObject Source;
    [Tooltip("The destination game object, can be null")]
    public GameObject Destination;
    [Tooltip("X, Y and Z for variance from the start point. Use positive values.")]
    public Vector3 StartVariance;
    [Tooltip("X, Y and Z for variance from the end point. Use positive values.")]
    public Vector3 EndVariance;

    public override void CreateLightningBolt(LightningBoltParameters parameters)
    {
      parameters.Start = !((Object) this.Source == (Object) null) ? this.Source.transform.position : parameters.Start;
      parameters.End = !((Object) this.Destination == (Object) null) ? this.Destination.transform.position : parameters.End;
      parameters.StartVariance = this.StartVariance;
      parameters.EndVariance = this.EndVariance;
      base.CreateLightningBolt(parameters);
    }
  }
}
