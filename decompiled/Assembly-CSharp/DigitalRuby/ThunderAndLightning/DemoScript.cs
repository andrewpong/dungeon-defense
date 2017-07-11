// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoScript : MonoBehaviour
  {
    private static readonly GUIStyle style = new GUIStyle();
    public float MoveSpeed = 250f;
    public bool EnableMouseLook = true;
    private float sensitivityX = 15f;
    private float sensitivityY = 15f;
    private float minimumX = -360f;
    private float maximumX = 360f;
    private float minimumY = -60f;
    private float maximumY = 60f;
    public ThunderAndLightningScript ThunderAndLightningScript;
    public LightningBoltScript LightningBoltScript;
    public ParticleSystem CloudParticleSystem;
    private const float fastCloudSpeed = 50f;
    private float deltaTime;
    private float fpsIncrement;
    private string fpsText;
    private DemoScript.RotationAxes axes;
    private float rotationX;
    private float rotationY;
    private Quaternion originalRotation;

    private void UpdateThunder()
    {
      if (!((Object) this.ThunderAndLightningScript != (Object) null))
        return;
      if (Input.GetKeyDown(KeyCode.Alpha1))
        this.ThunderAndLightningScript.CallNormalLightning();
      else if (Input.GetKeyDown(KeyCode.Alpha2))
      {
        this.ThunderAndLightningScript.CallIntenseLightning();
      }
      else
      {
        if (!Input.GetKeyDown(KeyCode.Alpha3) || !((Object) this.CloudParticleSystem != (Object) null))
          return;
        ParticleSystem.MainModule main = this.CloudParticleSystem.main;
        main.simulationSpeed = (double) main.simulationSpeed != 1.0 ? 1f : 50f;
      }
    }

    private void UpdateMovement()
    {
      float num = this.MoveSpeed * Time.deltaTime;
      if (Input.GetKey(KeyCode.W))
        Camera.main.transform.Translate(0.0f, 0.0f, num);
      if (Input.GetKey(KeyCode.S))
        Camera.main.transform.Translate(0.0f, 0.0f, -num);
      if (Input.GetKey(KeyCode.A))
        Camera.main.transform.Translate(-num, 0.0f, 0.0f);
      if (!Input.GetKey(KeyCode.D))
        return;
      Camera.main.transform.Translate(num, 0.0f, 0.0f);
    }

    private void UpdateMouseLook()
    {
      if (!this.EnableMouseLook)
        return;
      if (this.axes == DemoScript.RotationAxes.MouseXAndY)
      {
        this.rotationX += Input.GetAxis("Mouse X") * this.sensitivityX;
        this.rotationY += Input.GetAxis("Mouse Y") * this.sensitivityY;
        this.rotationX = DemoScript.ClampAngle(this.rotationX, this.minimumX, this.maximumX);
        this.rotationY = DemoScript.ClampAngle(this.rotationY, this.minimumY, this.maximumY);
        this.transform.localRotation = this.originalRotation * Quaternion.AngleAxis(this.rotationX, Vector3.up) * Quaternion.AngleAxis(this.rotationY, -Vector3.right);
      }
      else if (this.axes == DemoScript.RotationAxes.MouseX)
      {
        this.rotationX += Input.GetAxis("Mouse X") * this.sensitivityX;
        this.rotationX = DemoScript.ClampAngle(this.rotationX, this.minimumX, this.maximumX);
        this.transform.localRotation = this.originalRotation * Quaternion.AngleAxis(this.rotationX, Vector3.up);
      }
      else
      {
        this.rotationY += Input.GetAxis("Mouse Y") * this.sensitivityY;
        this.rotationY = DemoScript.ClampAngle(this.rotationY, this.minimumY, this.maximumY);
        this.transform.localRotation = this.originalRotation * Quaternion.AngleAxis(-this.rotationY, Vector3.right);
      }
    }

    private void UpdateQuality()
    {
      if (Input.GetKeyDown(KeyCode.F1))
        QualitySettings.SetQualityLevel(0);
      else if (Input.GetKeyDown(KeyCode.F2))
        QualitySettings.SetQualityLevel(1);
      else if (Input.GetKeyDown(KeyCode.F3))
        QualitySettings.SetQualityLevel(2);
      else if (Input.GetKeyDown(KeyCode.F4))
        QualitySettings.SetQualityLevel(3);
      else if (Input.GetKeyDown(KeyCode.F5))
      {
        QualitySettings.SetQualityLevel(4);
      }
      else
      {
        if (!Input.GetKeyDown(KeyCode.F6))
          return;
        QualitySettings.SetQualityLevel(5);
      }
    }

    private void UpdateOther()
    {
      this.deltaTime += (float) (((double) Time.deltaTime - (double) this.deltaTime) * 0.100000001490116);
      if (!Input.GetKeyDown(KeyCode.Escape))
        return;
      DemoScript.ReloadCurrentScene();
    }

    private void OnGUI()
    {
      int width = Screen.width;
      int height = Screen.height;
      Rect position = new Rect(10f, (float) (height - 50), (float) width, (float) (height * 2 / 100));
      DemoScript.style.alignment = TextAnchor.UpperLeft;
      DemoScript.style.fontSize = height * 2 / 50;
      DemoScript.style.normal.textColor = Color.white;
      if ((double) (this.fpsIncrement += Time.deltaTime) > 1.0)
      {
        --this.fpsIncrement;
        this.fpsText = string.Format("{0:0.0} ms ({1:0.} fps)", (object) (this.deltaTime * 1000f), (object) (1f / this.deltaTime));
      }
      GUI.Label(position, this.fpsText, DemoScript.style);
    }

    private void Update()
    {
      this.UpdateThunder();
      this.UpdateMovement();
      this.UpdateMouseLook();
      this.UpdateQuality();
      this.UpdateOther();
    }

    private void Start()
    {
      this.originalRotation = this.transform.localRotation;
      if (!((Object) this.CloudParticleSystem != (Object) null))
        return;
      this.CloudParticleSystem.main.simulationSpeed = 50f;
    }

    public static float ClampAngle(float angle, float min, float max)
    {
      if ((double) angle < -360.0)
        angle += 360f;
      if ((double) angle > 360.0)
        angle -= 360f;
      return Mathf.Clamp(angle, min, max);
    }

    public static void ReloadCurrentScene()
    {
      SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    private enum RotationAxes
    {
      MouseXAndY,
      MouseX,
      MouseY,
    }
  }
}
