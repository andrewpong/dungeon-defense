// Decompiled with JetBrains decompiler
// Type: SelfDestruct
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
  public float selfdestruct_in = 4f;

  private void Start()
  {
    Object.Destroy((Object) this.gameObject, this.selfdestruct_in);
  }
}
