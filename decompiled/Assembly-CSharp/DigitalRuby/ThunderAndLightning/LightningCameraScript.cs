// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningCameraScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  [ExecuteInEditMode]
  public class LightningCameraScript : MonoBehaviour
  {
    public DepthTextureMode DepthTextureMode;
    public Camera Camera;

    private void Update()
    {
      if ((Object) this.Camera == (Object) null)
      {
        this.Camera = Camera.main;
        if ((Object) this.Camera == (Object) null)
        {
          this.Camera = Camera.current;
          if ((Object) this.Camera == (Object) null)
            return;
        }
      }
      this.Camera.depthTextureMode = this.DepthTextureMode;
    }
  }
}
