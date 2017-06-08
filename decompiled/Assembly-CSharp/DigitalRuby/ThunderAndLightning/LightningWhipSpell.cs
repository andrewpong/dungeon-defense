// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningWhipSpell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningWhipSpell : LightningSpellScript
  {
    [Header("Whip")]
    [Tooltip("Attach the whip to what object")]
    public GameObject AttachTo;
    [Tooltip("Rotate the whip with this object")]
    public GameObject RotateWith;
    [Tooltip("Whip handle")]
    public GameObject WhipHandle;
    [Tooltip("Whip start")]
    public GameObject WhipStart;
    [Tooltip("Whip spring")]
    public GameObject WhipSpring;
    [Tooltip("Whip crack audio source")]
    public AudioSource WhipCrackAudioSource;
    [HideInInspector]
    public Action<Vector3> CollisionCallback;

    [DebuggerHidden]
    private IEnumerator WhipForward()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new LightningWhipSpell.\u003CWhipForward\u003Ec__Iterator0() { \u0024this = this };
    }

    protected override void Start()
    {
      base.Start();
      this.WhipSpring.SetActive(false);
      this.WhipHandle.SetActive(false);
    }

    protected override void Update()
    {
      base.Update();
      this.gameObject.transform.position = this.AttachTo.transform.position;
      this.gameObject.transform.rotation = this.RotateWith.transform.rotation;
    }

    protected override void OnCastSpell()
    {
      this.StartCoroutine(this.WhipForward());
    }

    protected override void OnStopSpell()
    {
    }

    protected override void OnActivated()
    {
      base.OnActivated();
      this.WhipHandle.SetActive(true);
    }

    protected override void OnDeactivated()
    {
      base.OnDeactivated();
      this.WhipHandle.SetActive(false);
    }
  }
}
