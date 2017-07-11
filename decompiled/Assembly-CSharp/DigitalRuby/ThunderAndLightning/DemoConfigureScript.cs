// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoConfigureScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoConfigureScript : MonoBehaviour
  {
    private const string scriptTemplate = "// Important, make sure this script is assigned properly, or you will get null ref exceptions.\r\n    DigitalRuby.ThunderAndLightning.LightningBoltScript script = gameObject.GetComponent<DigitalRuby.ThunderAndLightning.LightningBoltScript>();\r\n    int count = {0};\r\n    float duration = {1}f;\r\n    float delay = 0.0f;\r\n    int seed = {2};\r\n    System.Random r = new System.Random(seed);\r\n    Vector3 start = new Vector3({3}f, {4}f, {5}f);\r\n    Vector3 end = new Vector3({6}f, {7}f, {8}f);\r\n    int generations = {9};\r\n    float chaosFactor = {10}f;\r\n    float trunkWidth = {11}f;\r\n    float intensity = {12}f;\r\n    float glowIntensity = {13}f;\r\n    float glowWidthMultiplier = {14}f;\r\n    float forkedness = {15}f;\r\n    float singleDuration = Mathf.Max(1.0f / 30.0f, (duration / (float)count));\r\n    float fadePercent = {16}f;\r\n    float growthMultiplier = {17}f;\r\n    System.Collections.Generic.List<LightningBoltParameters> paramList = new System.Collections.Generic.List<LightningBoltParameters>();\r\n    while (count-- > 0)\r\n    {{\r\n        DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters = new DigitalRuby.ThunderAndLightning.LightningBoltParameters\r\n        {{\r\n            Start = start,\r\n            End = end,\r\n            Generations = generations,\r\n            LifeTime = (count == 1 ? singleDuration : (singleDuration * (((float)r.NextDouble() * 0.4f) + 0.8f))),\r\n            Delay = delay,\r\n            ChaosFactor = chaosFactor,\r\n            TrunkWidth = trunkWidth,\r\n            GlowIntensity = glowIntensity,\r\n            GlowWidthMultiplier = glowWidthMultiplier,\r\n            Forkedness = forkedness,\r\n            Random = r,\r\n            FadePercent = fadePercent, // set to 0 to disable fade in / out\r\n            GrowthMultiplier = growthMultiplier\r\n        }};\r\n        paramList.Add(parameters);\r\n        delay += (singleDuration * (((float)r.NextDouble() * 0.8f) + 0.4f));\r\n    }}\r\n    script.CreateLightningBolts(paramList);\r\n";
    private int lastSeed;
    private Vector3 lastStart;
    private Vector3 lastEnd;
    public LightningBoltScript LightningBoltScript;
    public Slider GenerationsSlider;
    public Slider BoltCountSlider;
    public Slider DurationSlider;
    public Slider ChaosSlider;
    public Slider TrunkWidthSlider;
    public Slider ForkednessSlider;
    public Slider IntensitySlider;
    public Text IntensityValueLabel;
    public Slider GlowIntensitySlider;
    public Slider GlowWidthSlider;
    public Slider FadePercentSlider;
    public Slider GrowthMultiplierSlider;
    public Slider DistanceSlider;
    public Text GenerationsValueLabel;
    public Text BoltCountValueLabel;
    public Text DurationValueLabel;
    public Text ChaosValueLabel;
    public Text TrunkWidthValueLabel;
    public Text ForkednessValueLabel;
    public Text GlowIntensityValueLabel;
    public Text GlowWidthValueLabel;
    public Text FadePercentValueLabel;
    public Text GrowthMultiplierValueLabel;
    public Text DistanceValueLabel;
    public Text SeedLabel;
    public RawImage StartImage;
    public RawImage EndImage;
    public Button CopySeedButton;
    public InputField SeedInputField;
    public Text SpaceBarLabel;
    public Toggle OrthographicToggle;

    public void GenerationsSliderChanged(float value)
    {
      this.UpdateUI();
    }

    public void BoltCountSliderChanged(float value)
    {
      this.UpdateUI();
    }

    public void DurationSliderChanged(float value)
    {
      this.UpdateUI();
    }

    public void LengthSliderValueChanged(float value)
    {
      this.UpdateUI();
    }

    public void TrunkSliderValueChanged(float value)
    {
      this.UpdateUI();
    }

    public void intensitySliderValueChanged(float value)
    {
      this.UpdateUI();
    }

    public void GlowSliderValueChanged(float value)
    {
      this.UpdateUI();
    }

    public void FadePercentValueChanged(float value)
    {
      this.UpdateUI();
    }

    public void GrowthMultiplierValueChanged(float value)
    {
      this.UpdateUI();
    }

    public void DistanceValueChanged(float value)
    {
      this.UpdateUI();
    }

    public void StartLightningDrag()
    {
      this.StartImage.transform.position = Input.mousePosition;
    }

    public void EndLightningDrag()
    {
      this.EndImage.transform.position = Input.mousePosition;
    }

    public void CreateButtonClicked()
    {
      this.CallLightning();
    }

    public void OrthographicToggleClicked()
    {
      if (this.OrthographicToggle.isOn)
      {
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = (float) Camera.main.pixelHeight * 0.5f;
        Camera.main.nearClipPlane = 0.0f;
      }
      else
      {
        Camera.main.orthographic = false;
        Camera.main.nearClipPlane = 0.01f;
      }
    }

    public void CopyButtonClicked()
    {
      this.SeedInputField.text = this.lastSeed.ToString();
      TextEditor textEditor = new TextEditor();
      textEditor.text = string.Format("// Important, make sure this script is assigned properly, or you will get null ref exceptions.\r\n    DigitalRuby.ThunderAndLightning.LightningBoltScript script = gameObject.GetComponent<DigitalRuby.ThunderAndLightning.LightningBoltScript>();\r\n    int count = {0};\r\n    float duration = {1}f;\r\n    float delay = 0.0f;\r\n    int seed = {2};\r\n    System.Random r = new System.Random(seed);\r\n    Vector3 start = new Vector3({3}f, {4}f, {5}f);\r\n    Vector3 end = new Vector3({6}f, {7}f, {8}f);\r\n    int generations = {9};\r\n    float chaosFactor = {10}f;\r\n    float trunkWidth = {11}f;\r\n    float intensity = {12}f;\r\n    float glowIntensity = {13}f;\r\n    float glowWidthMultiplier = {14}f;\r\n    float forkedness = {15}f;\r\n    float singleDuration = Mathf.Max(1.0f / 30.0f, (duration / (float)count));\r\n    float fadePercent = {16}f;\r\n    float growthMultiplier = {17}f;\r\n    System.Collections.Generic.List<LightningBoltParameters> paramList = new System.Collections.Generic.List<LightningBoltParameters>();\r\n    while (count-- > 0)\r\n    {{\r\n        DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters = new DigitalRuby.ThunderAndLightning.LightningBoltParameters\r\n        {{\r\n            Start = start,\r\n            End = end,\r\n            Generations = generations,\r\n            LifeTime = (count == 1 ? singleDuration : (singleDuration * (((float)r.NextDouble() * 0.4f) + 0.8f))),\r\n            Delay = delay,\r\n            ChaosFactor = chaosFactor,\r\n            TrunkWidth = trunkWidth,\r\n            GlowIntensity = glowIntensity,\r\n            GlowWidthMultiplier = glowWidthMultiplier,\r\n            Forkedness = forkedness,\r\n            Random = r,\r\n            FadePercent = fadePercent, // set to 0 to disable fade in / out\r\n            GrowthMultiplier = growthMultiplier\r\n        }};\r\n        paramList.Add(parameters);\r\n        delay += (singleDuration * (((float)r.NextDouble() * 0.8f) + 0.4f));\r\n    }}\r\n    script.CreateLightningBolts(paramList);\r\n", (object) this.BoltCountSlider.value, (object) this.DurationSlider.value, (object) this.SeedInputField.text, (object) this.lastStart.x, (object) this.lastStart.y, (object) this.lastStart.z, (object) this.lastEnd.x, (object) this.lastEnd.y, (object) this.lastEnd.z, (object) this.GenerationsSlider.value, (object) this.ChaosSlider.value, (object) this.TrunkWidthSlider.value, (object) this.IntensitySlider.value, (object) this.GlowIntensitySlider.value, (object) this.GlowWidthSlider.value, (object) this.ForkednessSlider.value, (object) this.FadePercentSlider.value, (object) this.GrowthMultiplierSlider.value);
      textEditor.SelectAll();
      textEditor.Copy();
    }

    public void ClearButtonClicked()
    {
      this.SeedInputField.text = string.Empty;
    }

    private void UpdateUI()
    {
      this.GenerationsValueLabel.text = this.GenerationsSlider.value.ToString("0");
      this.BoltCountValueLabel.text = this.BoltCountSlider.value.ToString("0");
      this.DurationValueLabel.text = this.DurationSlider.value.ToString("0.00");
      this.ChaosValueLabel.text = this.ChaosSlider.value.ToString("0.00");
      this.TrunkWidthValueLabel.text = this.TrunkWidthSlider.value.ToString("0.00");
      this.ForkednessValueLabel.text = this.ForkednessSlider.value.ToString("0.00");
      this.IntensityValueLabel.text = this.IntensitySlider.value.ToString("0.00");
      this.GlowIntensityValueLabel.text = this.GlowIntensitySlider.value.ToString("0.00");
      this.GlowWidthValueLabel.text = this.GlowWidthSlider.value.ToString("0.00");
      this.FadePercentValueLabel.text = this.FadePercentSlider.value.ToString("0.00");
      this.GrowthMultiplierValueLabel.text = this.GrowthMultiplierSlider.value.ToString("0.00");
      this.DistanceValueLabel.text = this.DistanceSlider.value.ToString("0.00");
    }

    private void CallLightning()
    {
      if ((UnityEngine.Object) this.SpaceBarLabel != (UnityEngine.Object) null)
      {
        this.SpaceBarLabel.CrossFadeColor(new Color(0.0f, 0.0f, 0.0f, 0.0f), 1f, true, true);
        this.SpaceBarLabel = (Text) null;
      }
      this.lastStart = this.StartImage.transform.position + Camera.main.transform.forward * this.DistanceSlider.value;
      this.lastEnd = this.EndImage.transform.position + Camera.main.transform.forward * this.DistanceSlider.value;
      this.lastStart = Camera.main.ScreenToWorldPoint(this.lastStart);
      this.lastEnd = Camera.main.ScreenToWorldPoint(this.lastEnd);
      int num1 = (int) this.BoltCountSlider.value;
      float num2 = this.DurationSlider.value;
      float num3 = 0.0f;
      float num4 = this.ChaosSlider.value;
      float num5 = this.TrunkWidthSlider.value;
      float num6 = this.ForkednessSlider.value;
      if (!int.TryParse(this.SeedInputField.text, out this.lastSeed))
        this.lastSeed = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
      System.Random random = new System.Random(this.lastSeed);
      float num7 = Mathf.Max(0.03333334f, num2 / (float) num1);
      float num8 = this.FadePercentSlider.value;
      float num9 = this.GrowthMultiplierSlider.value;
      List<LightningBoltParameters> lightningBoltParametersList = new List<LightningBoltParameters>();
      Stopwatch stopwatch = Stopwatch.StartNew();
      while (num1-- > 0)
      {
        LightningBoltParameters lightningBoltParameters = new LightningBoltParameters() { Start = this.lastStart, End = this.lastEnd, Generations = (int) this.GenerationsSlider.value, LifeTime = num1 != 1 ? num7 * (float) (random.NextDouble() * 0.400000005960464 + 0.800000011920929) : num7, Delay = num3, ChaosFactor = num4, TrunkWidth = num5, Intensity = this.IntensitySlider.value, GlowIntensity = this.GlowIntensitySlider.value, GlowWidthMultiplier = this.GlowWidthSlider.value, Forkedness = num6, Random = random, FadePercent = num8, GrowthMultiplier = num9 };
        lightningBoltParametersList.Add(lightningBoltParameters);
        num3 += num7 * (float) (random.NextDouble() * 0.800000011920929 + 0.400000005960464);
      }
      this.LightningBoltScript.CreateLightningBolts((ICollection<LightningBoltParameters>) lightningBoltParametersList);
      stopwatch.Stop();
      this.UpdateStatusLabel(stopwatch.Elapsed);
    }

    private void UpdateStatusLabel(TimeSpan time)
    {
      this.SeedLabel.text = "Time to create: " + time.TotalMilliseconds.ToString() + "ms" + Environment.NewLine + "Seed: " + this.lastSeed.ToString() + Environment.NewLine + "Start: " + this.lastStart.ToString() + Environment.NewLine + "End: " + this.lastEnd.ToString() + Environment.NewLine + Environment.NewLine + "Use SPACE to create a bolt" + Environment.NewLine + "Drag circle and anchor" + Environment.NewLine + "Type in seed or clear for random" + Environment.NewLine + "Click copy to generate script";
    }

    private void Start()
    {
      this.UpdateUI();
      this.UpdateStatusLabel(TimeSpan.Zero);
    }

    private void Update()
    {
      if (this.SeedInputField.isFocused || !Input.GetKeyDown(KeyCode.Space))
        return;
      this.CallLightning();
    }
  }
}
