// Decompiled with JetBrains decompiler
// Type: SelfDestruct
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
  public float selfdestruct_in = 4f;

  private void Start()
  {
    Object.Destroy((Object) this.gameObject, this.selfdestruct_in);
  }
}
