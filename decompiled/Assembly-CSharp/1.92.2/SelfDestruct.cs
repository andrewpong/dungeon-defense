// Decompiled with JetBrains decompiler
// Type: SelfDestruct
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
  public float selfdestruct_in = 4f;

  private void Start()
  {
    Object.Destroy((Object) this.gameObject, this.selfdestruct_in);
  }
}
