// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScript2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScript2D : MonoBehaviour
  {
    public GameObject spriteToRotate;

    private void Start()
    {
    }

    private void Update()
    {
      this.spriteToRotate.transform.Rotate(0.0f, 0.0f, Time.deltaTime * 10f);
    }
  }
}
