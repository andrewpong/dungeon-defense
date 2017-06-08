// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningParticleSpellScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningParticleSpellScript : LightningSpellScript, ICollisionHandler
  {
    [Header("Particle Light Properties")]
    [Tooltip("Whether to enable point lights for the particles")]
    public bool EnableParticleLights = true;
    [SingleLineClamp("Possible range for particle lights", 0.001, 100.0)]
    public RangeOfFloats ParticleLightRange = new RangeOfFloats() { Minimum = 2f, Maximum = 5f };
    [SingleLineClamp("Possible range of intensity for particle lights", 0.00999999977648258, 8.0)]
    public RangeOfFloats ParticleLightIntensity = new RangeOfFloats() { Minimum = 0.2f, Maximum = 0.3f };
    [Tooltip("Possible range of colors for particle lights")]
    public Color ParticleLightColor1 = Color.white;
    [Tooltip("Possible range of colors for particle lights")]
    public Color ParticleLightColor2 = Color.white;
    [Tooltip("The culling mask for particle lights")]
    public LayerMask ParticleLightCullingMask = (LayerMask) -1;
    private ParticleSystem.Particle[] particles = new ParticleSystem.Particle[512];
    private readonly List<GameObject> particleLights = new List<GameObject>();
    [Header("Particle system")]
    public ParticleSystem ParticleSystem;
    [Tooltip("Particle system collision interval. This time must elapse before another collision will be registered.")]
    public float CollisionInterval;
    protected float collisionTimer;
    [HideInInspector]
    public Action<GameObject, List<ParticleCollisionEvent>, int> CollisionCallback;

    private void PopulateParticleLight(Light src)
    {
      src.bounceIntensity = 0.0f;
      src.type = LightType.Point;
      src.shadows = LightShadows.None;
      src.color = new Color(UnityEngine.Random.Range(this.ParticleLightColor1.r, this.ParticleLightColor2.r), UnityEngine.Random.Range(this.ParticleLightColor1.g, this.ParticleLightColor2.g), UnityEngine.Random.Range(this.ParticleLightColor1.b, this.ParticleLightColor2.b), 1f);
      src.cullingMask = (int) this.ParticleLightCullingMask;
      src.intensity = UnityEngine.Random.Range(this.ParticleLightIntensity.Minimum, this.ParticleLightIntensity.Maximum);
      src.range = UnityEngine.Random.Range(this.ParticleLightRange.Minimum, this.ParticleLightRange.Maximum);
    }

    private void UpdateParticleLights()
    {
      if (!this.EnableParticleLights)
        return;
      int particles = this.ParticleSystem.GetParticles(this.particles);
      while (this.particleLights.Count < particles)
      {
        GameObject gameObject = new GameObject("LightningParticleSpellLight");
        gameObject.hideFlags = HideFlags.HideAndDontSave;
        this.PopulateParticleLight(gameObject.AddComponent<Light>());
        this.particleLights.Add(gameObject);
      }
      while (this.particleLights.Count > particles)
      {
        UnityEngine.Object.Destroy((UnityEngine.Object) this.particleLights[this.particleLights.Count - 1]);
        this.particleLights.RemoveAt(this.particleLights.Count - 1);
      }
      for (int index = 0; index < particles; ++index)
        this.particleLights[index].transform.position = this.particles[index].position;
    }

    private void UpdateParticleSystems()
    {
      if ((UnityEngine.Object) this.EmissionParticleSystem != (UnityEngine.Object) null && this.EmissionParticleSystem.isPlaying)
      {
        this.EmissionParticleSystem.transform.position = this.SpellStart.transform.position;
        this.EmissionParticleSystem.transform.forward = this.Direction;
      }
      if (!((UnityEngine.Object) this.ParticleSystem != (UnityEngine.Object) null))
        return;
      if (this.ParticleSystem.isPlaying)
      {
        this.ParticleSystem.transform.position = this.SpellStart.transform.position;
        this.ParticleSystem.transform.forward = this.Direction;
      }
      this.UpdateParticleLights();
    }

    protected override void OnDestroy()
    {
      base.OnDestroy();
      foreach (UnityEngine.Object particleLight in this.particleLights)
        UnityEngine.Object.Destroy(particleLight);
    }

    protected override void Start()
    {
      base.Start();
    }

    protected override void Update()
    {
      base.Update();
      this.UpdateParticleSystems();
      this.collisionTimer -= Time.deltaTime;
    }

    protected override void OnCastSpell()
    {
      if (!((UnityEngine.Object) this.ParticleSystem != (UnityEngine.Object) null))
        return;
      this.ParticleSystem.Play();
      this.UpdateParticleSystems();
    }

    protected override void OnStopSpell()
    {
      if (!((UnityEngine.Object) this.ParticleSystem != (UnityEngine.Object) null))
        return;
      this.ParticleSystem.Stop();
    }

    void ICollisionHandler.HandleCollision(GameObject obj, List<ParticleCollisionEvent> collisions, int collisionCount)
    {
      if ((double) this.collisionTimer > 0.0)
        return;
      this.collisionTimer = this.CollisionInterval;
      this.PlayCollisionSound(collisions[0].intersection);
      this.ApplyCollisionForce(collisions[0].intersection);
      if (this.CollisionCallback == null)
        return;
      this.CollisionCallback(obj, collisions, collisionCount);
    }
  }
}
