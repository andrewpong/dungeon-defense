// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.ThunderAndLightningScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class ThunderAndLightningScript : MonoBehaviour
  {
    [SingleLine("Random interval between strikes.")]
    public RangeOfFloats LightningIntervalTimeRange = new RangeOfFloats() { Minimum = 10f, Maximum = 25f };
    [Tooltip("Probability (0-1) of an intense lightning bolt that hits really close. Intense lightning has increased brightness and louder thunder compared to normal lightning, and the thunder sounds plays a lot sooner.")]
    [Range(0.0f, 1f)]
    public float LightningIntenseProbability = 0.2f;
    [Tooltip("Whether lightning strikes should always try to be in the camera view")]
    public bool LightningAlwaysVisible = true;
    [Tooltip("The chance lightning will simply be in the clouds with no visible bolt")]
    [Range(0.0f, 1f)]
    public float CloudLightningChance = 0.5f;
    [Tooltip("Base point light range for lightning bolts. Increases as intensity increases.")]
    [Range(1f, 10000f)]
    public float BaseLightRange = 2000f;
    [Tooltip("Starting y value for the lightning strikes")]
    [Range(0.0f, 100000f)]
    public float LightningYStart = 500f;
    [Tooltip("Lightning bolt script - optional, leave null if you don't want lightning bolts")]
    public LightningBoltPrefabScript LightningBoltScript;
    [Tooltip("Camera where the lightning should be centered over. Defaults to main camera.")]
    public Camera Camera;
    [Tooltip("Sounds to play for normal thunder. One will be chosen at random for each lightning strike. Depending on intensity, some normal lightning may not play a thunder sound.")]
    public AudioClip[] ThunderSoundsNormal;
    [Tooltip("Sounds to play for intense thunder. One will be chosen at random for each lightning strike.")]
    public AudioClip[] ThunderSoundsIntense;
    [Tooltip("Whether to modify the skybox exposure when lightning is created")]
    public bool ModifySkyboxExposure;
    private float skyboxExposureOriginal;
    private float skyboxExposureStorm;
    private float nextLightningTime;
    private bool lightningInProgress;
    private AudioSource audioSourceThunder;
    private ThunderAndLightningScript.LightningBoltHandler lightningBoltHandler;
    private Material skyboxMaterial;
    private AudioClip lastThunderSound;

    public float SkyboxExposureOriginal
    {
      get
      {
        return this.skyboxExposureOriginal;
      }
    }

    public bool EnableLightning { get; set; }

    private void Start()
    {
      this.EnableLightning = true;
      if ((UnityEngine.Object) this.Camera == (UnityEngine.Object) null)
        this.Camera = Camera.main;
      if ((UnityEngine.Object) RenderSettings.skybox != (UnityEngine.Object) null)
      {
        Material material = new Material(RenderSettings.skybox);
        RenderSettings.skybox = material;
        this.skyboxMaterial = material;
      }
      this.skyboxExposureOriginal = this.skyboxExposureStorm = (UnityEngine.Object) this.skyboxMaterial == (UnityEngine.Object) null || !this.skyboxMaterial.HasProperty("_Exposure") ? 1f : this.skyboxMaterial.GetFloat("_Exposure");
      this.audioSourceThunder = this.gameObject.AddComponent<AudioSource>();
      this.lightningBoltHandler = new ThunderAndLightningScript.LightningBoltHandler(this);
    }

    private void Update()
    {
      if (this.lightningBoltHandler == null || !this.EnableLightning)
        return;
      this.lightningBoltHandler.Update();
    }

    public void CallNormalLightning()
    {
      this.CallNormalLightning(new Vector3?(), new Vector3?());
    }

    public void CallNormalLightning(Vector3? start, Vector3? end)
    {
      this.StartCoroutine(this.lightningBoltHandler.ProcessLightning(start, end, false, true));
    }

    public void CallIntenseLightning()
    {
      this.CallIntenseLightning(new Vector3?(), new Vector3?());
    }

    public void CallIntenseLightning(Vector3? start, Vector3? end)
    {
      this.StartCoroutine(this.lightningBoltHandler.ProcessLightning(start, end, true, true));
    }

    private class LightningBoltHandler
    {
      private readonly System.Random random = new System.Random();
      private ThunderAndLightningScript script;

      public LightningBoltHandler(ThunderAndLightningScript script)
      {
        this.script = script;
        this.CalculateNextLightningTime();
      }

      private void UpdateLighting()
      {
        if (this.script.lightningInProgress)
          return;
        if (this.script.ModifySkyboxExposure)
        {
          this.script.skyboxExposureStorm = 0.35f;
          if ((UnityEngine.Object) this.script.skyboxMaterial != (UnityEngine.Object) null && this.script.skyboxMaterial.HasProperty("_Exposure"))
            this.script.skyboxMaterial.SetFloat("_Exposure", this.script.skyboxExposureStorm);
        }
        this.CheckForLightning();
      }

      private void CalculateNextLightningTime()
      {
        this.script.nextLightningTime = Time.time + this.script.LightningIntervalTimeRange.Random(this.random);
        this.script.lightningInProgress = false;
        if (!this.script.ModifySkyboxExposure || !this.script.skyboxMaterial.HasProperty("_Exposure"))
          return;
        this.script.skyboxMaterial.SetFloat("_Exposure", this.script.skyboxExposureStorm);
      }

      [DebuggerHidden]
      public IEnumerator ProcessLightning(Vector3? _start, Vector3? _end, bool intense, bool visible)
      {
        // ISSUE: object of a compiler-generated type is created
        return (IEnumerator) new ThunderAndLightningScript.LightningBoltHandler.\u003CProcessLightning\u003Ec__Iterator0() { intense = intense, _start = _start, _end = _end, visible = visible, \u0024this = this };
      }

      private void Strike(Vector3? _start, Vector3? _end, bool intense, float intensity, Camera camera, Camera visibleInCamera)
      {
        float min1 = !intense ? -5000f : -1000f;
        float max = !intense ? 5000f : 1000f;
        float min2 = !intense ? 2500f : 500f;
        float num1 = UnityEngine.Random.Range(0, 2) != 0 ? UnityEngine.Random.Range(min2, max) : UnityEngine.Random.Range(min1, -min2);
        float lightningYstart = this.script.LightningYStart;
        float num2 = UnityEngine.Random.Range(0, 2) != 0 ? UnityEngine.Random.Range(min2, max) : UnityEngine.Random.Range(min1, -min2);
        Vector3 origin = this.script.Camera.transform.position;
        origin.x += num1;
        origin.y = lightningYstart;
        origin.z += num2;
        if ((UnityEngine.Object) visibleInCamera != (UnityEngine.Object) null)
        {
          Quaternion rotation = visibleInCamera.transform.rotation;
          visibleInCamera.transform.rotation = Quaternion.Euler(0.0f, rotation.eulerAngles.y, 0.0f);
          float x = UnityEngine.Random.Range((float) visibleInCamera.pixelWidth * 0.1f, (float) visibleInCamera.pixelWidth * 0.9f);
          float z = UnityEngine.Random.Range(visibleInCamera.nearClipPlane + min2 + min2, max);
          origin = visibleInCamera.ScreenToWorldPoint(new Vector3(x, 0.0f, z));
          origin.y = lightningYstart;
          visibleInCamera.transform.rotation = rotation;
        }
        Vector3 vector3 = origin;
        float num3 = UnityEngine.Random.Range(-100f, 100f);
        float num4 = UnityEngine.Random.Range(0, 4) != 0 ? -1f : UnityEngine.Random.Range(-1f, 600f);
        float num5 = num2 + UnityEngine.Random.Range(-100f, 100f);
        vector3.x += num3;
        vector3.y = num4;
        vector3.z += num5;
        vector3.x += min2 * camera.transform.forward.x;
        vector3.z += min2 * camera.transform.forward.z;
        while ((double) (origin - vector3).magnitude < 500.0)
        {
          vector3.x += min2 * camera.transform.forward.x;
          vector3.z += min2 * camera.transform.forward.z;
        }
        origin = !_start.HasValue ? origin : _start.Value;
        vector3 = !_end.HasValue ? vector3 : _end.Value;
        RaycastHit hitInfo;
        if (Physics.Raycast(origin, (origin - vector3).normalized, out hitInfo, float.MaxValue))
          vector3 = hitInfo.point;
        int generations = this.script.LightningBoltScript.Generations;
        RangeOfFloats trunkWidthRange = this.script.LightningBoltScript.TrunkWidthRange;
        if ((double) UnityEngine.Random.value < (double) this.script.CloudLightningChance)
        {
          this.script.LightningBoltScript.TrunkWidthRange = new RangeOfFloats();
          this.script.LightningBoltScript.Generations = 1;
        }
        this.script.LightningBoltScript.LightParameters.LightIntensity = intensity * 0.5f;
        this.script.LightningBoltScript.Trigger(new Vector3?(origin), new Vector3?(vector3));
        this.script.LightningBoltScript.TrunkWidthRange = trunkWidthRange;
        this.script.LightningBoltScript.Generations = generations;
      }

      private void CheckForLightning()
      {
        if ((double) Time.time < (double) this.script.nextLightningTime)
          return;
        this.script.StartCoroutine(this.ProcessLightning(new Vector3?(), new Vector3?(), (double) UnityEngine.Random.value < (double) this.script.LightningIntenseProbability, this.script.LightningAlwaysVisible));
      }

      public void Update()
      {
        this.UpdateLighting();
      }
    }
  }
}
