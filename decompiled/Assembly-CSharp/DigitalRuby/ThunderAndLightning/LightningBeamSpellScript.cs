// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBeamSpellScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBeamSpellScript : LightningSpellScript
  {
    [Tooltip("Give the end point some randomization")]
    public float EndPointRandomization = 1.5f;
    [Header("Beam")]
    [Tooltip("The lightning path script creating the beam of lightning")]
    public LightningBoltPathScriptBase LightningPathScript;
    [HideInInspector]
    public Action<RaycastHit> CollisionCallback;

    private void CheckCollision()
    {
      RaycastHit hitInfo;
      if (Physics.Raycast(this.SpellStart.transform.position, this.Direction, out hitInfo, this.MaxDistance, (int) this.CollisionMask))
      {
        this.SpellEnd.transform.position = hitInfo.point;
        this.SpellEnd.transform.position += UnityEngine.Random.insideUnitSphere * this.EndPointRandomization;
        this.PlayCollisionSound(this.SpellEnd.transform.position);
        if ((UnityEngine.Object) this.CollisionParticleSystem != (UnityEngine.Object) null)
        {
          this.CollisionParticleSystem.transform.position = hitInfo.point;
          this.CollisionParticleSystem.Play();
        }
        this.ApplyCollisionForce(hitInfo.point);
        if (this.CollisionCallback == null)
          return;
        this.CollisionCallback(hitInfo);
      }
      else
      {
        if ((UnityEngine.Object) this.CollisionParticleSystem != (UnityEngine.Object) null)
          this.CollisionParticleSystem.Stop();
        this.SpellEnd.transform.position = this.SpellStart.transform.position + this.Direction * this.MaxDistance;
        this.SpellEnd.transform.position += UnityEngine.Random.insideUnitSphere * this.EndPointRandomization;
      }
    }

    protected override void Start()
    {
      base.Start();
      this.LightningPathScript.ManualMode = true;
    }

    protected override void LateUpdate()
    {
      base.LateUpdate();
      if (!this.Casting)
        return;
      this.CheckCollision();
    }

    protected override void OnCastSpell()
    {
      this.LightningPathScript.ManualMode = false;
    }

    protected override void OnStopSpell()
    {
      this.LightningPathScript.ManualMode = true;
    }
  }
}
