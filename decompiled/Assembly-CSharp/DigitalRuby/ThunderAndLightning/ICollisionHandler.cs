﻿// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.ICollisionHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public interface ICollisionHandler
  {
    void HandleCollision(GameObject obj, List<ParticleCollisionEvent> collision, int collisionCount);
  }
}
