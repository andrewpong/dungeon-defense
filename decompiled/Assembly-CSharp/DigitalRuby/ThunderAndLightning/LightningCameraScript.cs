// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningCameraScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
