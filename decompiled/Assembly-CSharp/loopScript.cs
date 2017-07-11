// Decompiled with JetBrains decompiler
// Type: loopScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class loopScript : MonoBehaviour
{
  public float loopTimeLimit = 2f;
  public GameObject chosenEffect;

  private void Start()
  {
    this.PlayLoopingPEffect();
  }

  public void PlayLoopingPEffect()
  {
    this.StartCoroutine("EffectLoop");
  }

  [DebuggerHidden]
  private IEnumerator EffectLoop()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new loopScript.\u003CEffectLoop\u003Ec__Iterator0()
    {
      \u0024this = this
    };
  }
}
