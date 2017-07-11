// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltPrefabScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
