// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningParticleCollisionForwarder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  [RequireComponent(typeof (ParticleSystem))]
  public class LightningParticleCollisionForwarder : MonoBehaviour
  {
    private readonly List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();
    [Tooltip("The script to forward the collision to. Must implement ICollisionHandler.")]
    public MonoBehaviour CollisionHandler;
    private ParticleSystem _particleSystem;

    private void Start()
    {
      this._particleSystem = this.GetComponent<ParticleSystem>();
    }

    private void OnParticleCollision(GameObject other)
    {
      ICollisionHandler collisionHandler = this.CollisionHandler as ICollisionHandler;
      if (collisionHandler == null)
        return;
      int collisionEvents = this._particleSystem.GetCollisionEvents(other, this.collisionEvents);
      if (collisionEvents == 0)
        return;
      collisionHandler.HandleCollision(other, this.collisionEvents, collisionEvents);
    }
  }
}
