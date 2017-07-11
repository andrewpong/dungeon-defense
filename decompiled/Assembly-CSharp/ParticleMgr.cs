// Decompiled with JetBrains decompiler
// Type: ParticleMgr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections.Generic;
using UnityEngine;

public class ParticleMgr : MonoBehaviour
{
  private static Dictionary<string, List<ParticleElt>> dicParticle = new Dictionary<string, List<ParticleElt>>();
  private static Dictionary<string, int> dicNum = new Dictionary<string, int>();
  private static int nMax = 4;
  private static bool bLoaded = false;
  public static ParticleMgr single;
  public List<ParticleElt> listPS;

  private void Awake()
  {
    ParticleMgr.single = this;
    Object.DontDestroyOnLoad((Object) this);
    if (ParticleMgr.bLoaded)
    {
      Object.Destroy((Object) this.gameObject);
    }
    else
    {
      foreach (ParticleElt particleElt in this.listPS)
      {
        List<ParticleElt> particleEltList = new List<ParticleElt>();
        particleEltList.Add(particleElt);
        for (int index = 1; index < ParticleMgr.nMax; ++index)
        {
          particleEltList.Add(Object.Instantiate<GameObject>(particleElt.gameObject).GetComponent<ParticleElt>());
          particleEltList[index].transform.SetParent(this.transform);
        }
        ParticleMgr.dicParticle.Add(particleElt.name.ToLower(), particleEltList);
        ParticleMgr.dicNum.Add(particleElt.name.ToLower(), 0);
      }
      ParticleMgr.bLoaded = true;
    }
  }

  public static void Play(string str, Transform tr)
  {
    ParticleMgr.dicParticle[str.ToLower()][ParticleMgr.dicNum[str.ToLower()]].Play(tr);
    ParticleMgr.IncNum(str);
  }

  public static void Play(string str, Vector3 vPos)
  {
    ParticleMgr.dicParticle[str.ToLower()][ParticleMgr.dicNum[str.ToLower()]].Play(vPos);
    ParticleMgr.IncNum(str);
  }

  public static void Play(string str, Vector3 vPos, Vector3 vSca)
  {
    ParticleMgr.dicParticle[str.ToLower()][ParticleMgr.dicNum[str.ToLower()]].Play(vPos, vSca);
    ParticleMgr.IncNum(str);
  }

  public static void Play(string str, Vector3 vPos, Quaternion qRot, Vector3 vSca)
  {
    ParticleMgr.dicParticle[str.ToLower()][ParticleMgr.dicNum[str.ToLower()]].Play(vPos, qRot, vSca);
    ParticleMgr.IncNum(str);
  }

  public static void Play(string str)
  {
    ParticleMgr.dicParticle[str.ToLower()][ParticleMgr.dicNum[str.ToLower()]].Play(false);
    ParticleMgr.IncNum(str);
  }

  private static void IncNum(string str)
  {
    ParticleMgr.dicNum[str.ToLower()] = ParticleMgr.dicNum[str.ToLower()] < ParticleMgr.nMax - 1 ? ParticleMgr.dicNum[str.ToLower()] + 1 : 0;
  }
}
