// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningSpellScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public abstract class LightningSpellScript : MonoBehaviour
  {
    [Tooltip("The maximum distance of the spell")]
    public float MaxDistance = 15f;
    [Tooltip("The radius of the collision explosion")]
    public float CollisionRadius = 1f;
    [Tooltip("The force to explode with when there is a collision")]
    public float CollisionForce = 50f;
    [Tooltip("Collision force mode")]
    public ForceMode CollisionForceMode = ForceMode.Impulse;
    [Tooltip("The layers that the spell should collide with")]
    public LayerMask CollisionMask = (LayerMask) -1;
    [Tooltip("Collision sound volume range.")]
    public RangeOfFloats CollisionVolumeRange = new RangeOfFloats() { Minimum = 0.4f, Maximum = 0.6f };
    [Header("Direction and distance")]
    [Tooltip("The start point of the spell. Set this to a muzzle end or hand.")]
    public GameObject SpellStart;
    [Tooltip("The end point of the spell. Set this to an empty game object. This will change depending on things like collisions, randomness, etc. Not all spells need an end object, but create this anyway to be sure.")]
    public GameObject SpellEnd;
    [HideInInspector]
    [Tooltip("The direction of the spell. Should be normalized. Does not change unless explicitly modified.")]
    public Vector3 Direction;
    [Header("Collision")]
    [Tooltip("Whether the collision is an exploision. If not explosion, collision is directional.")]
    public bool CollisionIsExplosion;
    [Tooltip("The particle system for collisions. For best effects, this should emit particles in bursts at time 0 and not loop.")]
    public ParticleSystem CollisionParticleSystem;
    [Tooltip("Collision audio source")]
    public AudioSource CollisionAudioSource;
    [Tooltip("Collision audio clips. One will be chosen at random and played one shot with CollisionAudioSource.")]
    public AudioClip[] CollisionAudioClips;
    [Header("Duration and Cooldown")]
    [Tooltip("The duration in seconds that the spell will last. Not all spells support a duration. For one shot spells, this is how long the spell cast / emission light, etc. will last.")]
    public float Duration;
    [Tooltip("The cooldown in seconds. Once cast, the spell must wait for the cooldown before being cast again.")]
    public float Cooldown;
    [Header("Emission")]
    [Tooltip("Emission sound")]
    public AudioSource EmissionSound;
    [Tooltip("Emission particle system. For best results use world space, turn off looping and play on awake.")]
    public ParticleSystem EmissionParticleSystem;
    [Tooltip("Light to illuminate when spell is cast")]
    public Light EmissionLight;
    private int stopToken;

    protected float DurationTimer { get; private set; }

    protected float CooldownTimer { get; private set; }

    public bool Casting { get; private set; }

    public bool CanCastSpell
    {
      get
      {
        if (!this.Casting)
          return (double) this.CooldownTimer <= 0.0;
        return false;
      }
    }

    [DebuggerHidden]
    private IEnumerator StopAfterSecondsCoRoutine(float seconds)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new LightningSpellScript.\u003CStopAfterSecondsCoRoutine\u003Ec__Iterator0() { seconds = seconds, \u0024this = this };
    }

    protected void ApplyCollisionForce(Vector3 point)
    {
      if ((double) this.CollisionForce <= 0.0 || (double) this.CollisionRadius <= 0.0)
        return;
      foreach (Component component1 in Physics.OverlapSphere(point, this.CollisionRadius, (int) this.CollisionMask))
      {
        Rigidbody component2 = component1.GetComponent<Rigidbody>();
        if ((Object) component2 != (Object) null)
        {
          if (this.CollisionIsExplosion)
            component2.AddExplosionForce(this.CollisionForce, point, this.CollisionRadius, this.CollisionForce * 0.02f, this.CollisionForceMode);
          else
            component2.AddForce(this.CollisionForce * this.Direction, this.CollisionForceMode);
        }
      }
    }

    protected void PlayCollisionSound(Vector3 pos)
    {
      if (!((Object) this.CollisionAudioSource != (Object) null) || this.CollisionAudioClips == null || this.CollisionAudioClips.Length == 0)
        return;
      int index = Random.Range(0, this.CollisionAudioClips.Length - 1);
      float volumeScale = Random.Range(this.CollisionVolumeRange.Minimum, this.CollisionVolumeRange.Maximum);
      this.CollisionAudioSource.transform.position = pos;
      this.CollisionAudioSource.PlayOneShot(this.CollisionAudioClips[index], volumeScale);
    }

    protected virtual void Start()
    {
      if (!((Object) this.EmissionLight != (Object) null))
        return;
      this.EmissionLight.enabled = false;
    }

    protected virtual void Update()
    {
      this.CooldownTimer = Mathf.Max(0.0f, this.CooldownTimer - Time.deltaTime);
      this.DurationTimer = Mathf.Max(0.0f, this.DurationTimer - Time.deltaTime);
    }

    protected virtual void LateUpdate()
    {
    }

    protected virtual void OnDestroy()
    {
    }

    protected abstract void OnCastSpell();

    protected abstract void OnStopSpell();

    protected virtual void OnActivated()
    {
    }

    protected virtual void OnDeactivated()
    {
    }

    public bool CastSpell()
    {
      if (!this.CanCastSpell)
        return false;
      this.Casting = true;
      this.DurationTimer = this.Duration;
      this.CooldownTimer = this.Cooldown;
      this.OnCastSpell();
      if ((double) this.Duration > 0.0)
        this.StopAfterSeconds(this.Duration);
      if ((Object) this.EmissionParticleSystem != (Object) null)
        this.EmissionParticleSystem.Play();
      if ((Object) this.EmissionLight != (Object) null)
      {
        this.EmissionLight.transform.position = this.SpellStart.transform.position;
        this.EmissionLight.enabled = true;
      }
      if ((Object) this.EmissionSound != (Object) null)
        this.EmissionSound.Play();
      return true;
    }

    public void StopSpell()
    {
      if (!this.Casting)
        return;
      ++this.stopToken;
      if ((Object) this.EmissionParticleSystem != (Object) null)
        this.EmissionParticleSystem.Stop();
      if ((Object) this.EmissionLight != (Object) null)
        this.EmissionLight.enabled = false;
      if ((Object) this.EmissionSound != (Object) null && this.EmissionSound.loop)
        this.EmissionSound.Stop();
      this.DurationTimer = 0.0f;
      this.Casting = false;
      this.OnStopSpell();
    }

    public void ActivateSpell()
    {
      this.OnActivated();
    }

    public void DeactivateSpell()
    {
      this.OnDeactivated();
    }

    public void StopAfterSeconds(float seconds)
    {
      this.StartCoroutine(this.StopAfterSecondsCoRoutine(seconds));
    }

    public static GameObject FindChildRecursively(Transform t, string name)
    {
      if (t.name == name)
        return t.gameObject;
      for (int index = 0; index < t.childCount; ++index)
      {
        GameObject childRecursively = LightningSpellScript.FindChildRecursively(t.GetChild(index), name);
        if ((Object) childRecursively != (Object) null)
          return childRecursively;
      }
      return (GameObject) null;
    }
  }
}
