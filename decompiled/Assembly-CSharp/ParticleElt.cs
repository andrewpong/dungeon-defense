// Decompiled with JetBrains decompiler
// Type: ParticleElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ParticleElt : MonoBehaviour
{
  public ParticleSystem[] ps;
  public ParticleSystem.EmissionModule[] emm;

  private void Awake()
  {
    this.emm = new ParticleSystem.EmissionModule[this.ps.Length];
    for (int index = 0; index < this.ps.Length; ++index)
      this.emm[index] = this.ps[index].emission;
  }

  public void Play(Vector3 vPos)
  {
    this.transform.position = vPos;
    this.transform.localRotation = Quaternion.identity;
    this.Play(false);
  }

  public void Play(Transform tr)
  {
    this.transform.localPosition = tr.localPosition;
    this.transform.localRotation = tr.localRotation;
    this.Play(false);
  }

  public void Play(Vector3 vPos, Vector3 vSca)
  {
    this.transform.position = vPos;
    this.transform.localRotation = Quaternion.identity;
    this.transform.localScale = vSca;
    this.Play(false);
  }

  public void Play(Vector3 vPos, Quaternion qRot, Vector3 vSca)
  {
    this.transform.localPosition = vPos;
    this.transform.localRotation = qRot;
    this.transform.localScale = vSca;
    this.Play(false);
  }

  public void Play(bool bForce = false)
  {
    if (Info.option.bAllFXOff && !bForce)
      return;
    for (int index = 0; index < this.emm.Length; ++index)
      this.emm[index].enabled = true;
    for (int index = 0; index < this.ps.Length; ++index)
      this.ps[index].Play();
  }

  public void Stop()
  {
    for (int index = 0; index < this.ps.Length; ++index)
      this.ps[index].Stop();
    for (int index = 0; index < this.emm.Length; ++index)
      this.emm[index].enabled = false;
  }
}
