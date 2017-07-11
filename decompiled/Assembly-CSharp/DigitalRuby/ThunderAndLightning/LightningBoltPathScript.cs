// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltPathScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBoltPathScript : LightningBoltPathScriptBase
  {
    [Tooltip("How fast the lightning moves through the points or objects. 1 is normal speed, 0.01 is slower, so the lightning will move slowly between the points or objects.")]
    [Range(0.01f, 1f)]
    public float Speed = 1f;
    [SingleLineClamp("When each new point is moved to, this can provide a random value to make the movement to the next point appear more staggered or random. Leave as 1 and 1 to have constant speed. Use a higher maximum to create more randomness.", 1.0, 500.0)]
    public RangeOfFloats SpeedIntervalRange = new RangeOfFloats()
    {
      Minimum = 1f,
      Maximum = 1f
    };
    [Tooltip("Repeat when the path completes?")]
    public bool Repeat = true;
    private float nextInterval = 1f;
    private int nextIndex;
    private Vector3? lastPoint;

    public override void CreateLightningBolt(LightningBoltParameters parameters)
    {
      Vector3? nullable1 = new Vector3?();
      List<GameObject> currentPathObjects = this.GetCurrentPathObjects();
      if (currentPathObjects.Count < 2)
        return;
      if (this.nextIndex >= currentPathObjects.Count)
      {
        if (!this.Repeat)
          return;
        if ((UnityEngine.Object) currentPathObjects[currentPathObjects.Count - 1] == (UnityEngine.Object) currentPathObjects[0])
        {
          this.nextIndex = 1;
        }
        else
        {
          this.nextIndex = 0;
          this.lastPoint = new Vector3?();
        }
      }
      try
      {
        if (!this.lastPoint.HasValue)
          this.lastPoint = new Vector3?(currentPathObjects[this.nextIndex++].transform.position);
        Vector3? nullable2 = new Vector3?(currentPathObjects[this.nextIndex].transform.position);
        if (!this.lastPoint.HasValue || !nullable2.HasValue)
          return;
        parameters.Start = this.lastPoint.Value;
        parameters.End = nullable2.Value;
        base.CreateLightningBolt(parameters);
        if ((double) (this.nextInterval -= this.Speed) > 0.0)
          return;
        this.nextInterval = UnityEngine.Random.Range(this.SpeedIntervalRange.Minimum, this.SpeedIntervalRange.Maximum) + this.nextInterval;
        this.lastPoint = nullable2;
        ++this.nextIndex;
      }
      catch (NullReferenceException ex)
      {
      }
    }

    public void Reset()
    {
      this.lastPoint = new Vector3?();
      this.nextIndex = 0;
      this.nextInterval = 1f;
    }
  }
}
