// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltDependencies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningBoltDependencies
  {
    public GameObject Parent;
    public Material LightningMaterialMesh;
    public Material LightningMaterialMeshNoGlow;
    public ParticleSystem OriginParticleSystem;
    public ParticleSystem DestParticleSystem;
    public Vector3 CameraPos;
    public bool CameraIsOrthographic;
    public CameraMode CameraMode;
    public bool UseWorldSpace;
    public string SortLayerName;
    public int SortOrderInLayer;
    public ICollection<LightningBoltParameters> Parameters;
    public LightningThreadState ThreadState;
    public Func<IEnumerator, Coroutine> StartCoroutine;
    public Action<Light> LightAdded;
    public Action<Light> LightRemoved;
    public Action<LightningBolt> AddActiveBolt;
    public Action<LightningBoltDependencies> ReturnToCache;
  }
}
