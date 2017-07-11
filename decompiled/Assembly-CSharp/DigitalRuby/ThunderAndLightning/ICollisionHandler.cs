// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.ICollisionHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public interface ICollisionHandler
  {
    void HandleCollision(GameObject obj, List<ParticleCollisionEvent> collision, int collisionCount);
  }
}
