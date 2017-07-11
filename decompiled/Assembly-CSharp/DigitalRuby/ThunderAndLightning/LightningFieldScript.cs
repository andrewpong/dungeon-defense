// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningFieldScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningFieldScript : LightningBoltPrefabScriptBase
  {
    [Header("Lightning Field Properties")]
    [Tooltip("The minimum length for a field segment")]
    public float MinimumLength = 0.01f;
    private float minimumLengthSquared;
    [Tooltip("The bounds to put the field in.")]
    public Bounds FieldBounds;
    [Tooltip("Optional light for the lightning field to emit")]
    public Light Light;

    private Vector3 RandomPointInBounds()
    {
      return new Vector3(Random.Range(this.FieldBounds.min.x, this.FieldBounds.max.x), Random.Range(this.FieldBounds.min.y, this.FieldBounds.max.y), Random.Range(this.FieldBounds.min.z, this.FieldBounds.max.z));
    }

    protected override void Start()
    {
      base.Start();
      if (!((Object) this.Light != (Object) null))
        return;
      this.Light.enabled = false;
    }

    protected override void Update()
    {
      base.Update();
      if (!((Object) this.Light != (Object) null))
        return;
      this.Light.transform.position = this.FieldBounds.center;
      this.Light.intensity = Random.Range(2.8f, 3.2f);
    }

    public override void CreateLightningBolt(LightningBoltParameters parameters)
    {
      this.minimumLengthSquared = this.MinimumLength * this.MinimumLength;
      for (int index = 0; index < 16; ++index)
      {
        parameters.Start = this.RandomPointInBounds();
        parameters.End = this.RandomPointInBounds();
        if ((double) (parameters.End - parameters.Start).sqrMagnitude >= (double) this.minimumLengthSquared)
          break;
      }
      if ((Object) this.Light != (Object) null)
        this.Light.enabled = true;
      base.CreateLightningBolt(parameters);
    }
  }
}
