// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningCameraScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
