// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScriptRotate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScriptRotate : MonoBehaviour
  {
    public Vector3 Rotation;

    private void Update()
    {
      this.gameObject.transform.Rotate(this.Rotation * Time.deltaTime);
    }
  }
}
