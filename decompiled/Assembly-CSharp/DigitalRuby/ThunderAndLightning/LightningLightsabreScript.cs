// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningLightsabreScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningLightsabreScript : LightningBoltPrefabScript
  {
    [Header("Lightsabre Properties")]
    [Tooltip("Height of the blade")]
    public float BladeHeight = 19f;
    [Tooltip("How long it takes to turn the lightsabre on and off")]
    public float ActivationTime = 0.5f;
    [Tooltip("Sound to play when the lightsabre turns on")]
    public AudioSource StartSound;
    [Tooltip("Sound to play when the lightsabre turns off")]
    public AudioSource StopSound;
    [Tooltip("Sound to play when the lightsabre stays on")]
    public AudioSource ConstantSound;
    private int state;
    private Vector3 bladeStart;
    private Vector3 bladeDir;
    private float bladeTime;
    private float bladeIntensity;

    protected override void Start()
    {
      base.Start();
    }

    protected override void Update()
    {
      if (this.state == 2 || this.state == 3)
      {
        this.bladeTime += Time.deltaTime;
        float num = Mathf.Lerp(0.01f, 1f, this.bladeTime / this.ActivationTime);
        this.Destination.transform.position = this.bladeStart + this.bladeDir * num * this.BladeHeight;
        this.GlowIntensity = this.bladeIntensity * (this.state != 3 ? 1f - num : num);
        if ((double) this.bladeTime >= (double) this.ActivationTime)
        {
          this.GlowIntensity = this.bladeIntensity;
          this.bladeTime = 0.0f;
          if (this.state == 2)
          {
            this.ManualMode = true;
            this.state = 0;
          }
          else
            this.state = 1;
        }
      }
      base.Update();
    }

    public bool TurnOn(bool value)
    {
      if (this.state == 2 || this.state == 3 || this.state == 1 && value || this.state == 0 && !value)
        return false;
      this.bladeStart = this.Destination.transform.position;
      this.ManualMode = false;
      this.bladeIntensity = this.GlowIntensity;
      if (value)
      {
        this.bladeDir = !this.Camera.orthographic ? this.transform.forward : this.transform.up;
        this.state = 3;
        this.StartSound.Play();
        this.StopSound.Stop();
        this.ConstantSound.Play();
      }
      else
      {
        this.bladeDir = -(!this.Camera.orthographic ? this.transform.forward : this.transform.up);
        this.state = 2;
        this.StartSound.Stop();
        this.StopSound.Play();
        this.ConstantSound.Stop();
      }
      return true;
    }

    public void TurnOnGUI(bool value)
    {
      this.TurnOn(value);
    }
  }
}
