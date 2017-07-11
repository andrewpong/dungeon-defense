// Decompiled with JetBrains decompiler
// Type: Thinksquirrel.CShakeExample.CameraShakeExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Diagnostics;
using Thinksquirrel.CShake;
using UnityEngine;

namespace Thinksquirrel.CShakeExample
{
  [AddComponentMenu("Camera Shake Example/Camera Shake Example")]
  [RequireComponent(typeof (CameraShake))]
  public class CameraShakeExample : MonoBehaviour
  {
    public float rigidbodyForceModifier = 2f;
    public float rigidbodyTorqueModifier = 0.2f;
    public bool is2DExample;
    private CanvasGroup m_Canvas;
    private CameraShake m_Shake;
    private bool m_ShakeEverything;
    private Rigidbody[] m_Rigidbodies;
    private Rigidbody2D[] m_Rigidbodies2D;
    private bool m_MultiShake;

    private void Start()
    {
      this.m_Canvas = UnityEngine.Object.FindObjectOfType<CanvasGroup>();
      this.m_Shake = this.GetComponent<CameraShake>();
      this.m_Shake.onShakeOffset += new Action<Vector3, Quaternion>(this.OnShakeOffset);
      this.m_Rigidbodies = UnityEngine.Object.FindObjectsOfType<Rigidbody>();
      this.m_Rigidbodies2D = UnityEngine.Object.FindObjectsOfType<Rigidbody2D>();
    }

    private void Update()
    {
      if ((bool) ((UnityEngine.Object) this.m_Canvas))
        this.m_Canvas.interactable = !this.m_Shake.IsShaking() && !this.m_MultiShake;
      if (this.m_Shake.shakeType == CameraShake.ShakeType.CameraMatrix)
      {
        this.transform.parent.position = new Vector3(this.transform.parent.position.x, Mathf.Cos(Time.time) * 0.35f, this.transform.parent.position.z);
        this.transform.localPosition = new Vector3(Mathf.Sin(Time.time) * 0.5f, this.transform.localPosition.y, this.transform.localPosition.z);
      }
      else
        this.transform.parent.position = new Vector3(Mathf.Sin(Time.time) * 0.5f, Mathf.Cos(Time.time) * 0.35f, this.transform.parent.position.z);
    }

    private void OnShakeOffset(Vector3 translation, Quaternion rotation)
    {
      if (!this.m_ShakeEverything)
        return;
      if (this.is2DExample)
      {
        foreach (Rigidbody2D rigidbody2D in this.m_Rigidbodies2D)
        {
          if ((bool) ((UnityEngine.Object) rigidbody2D))
          {
            rigidbody2D.AddForce((Vector2) (translation * this.rigidbodyForceModifier), ForceMode2D.Impulse);
            Quaternion a = Quaternion.Euler(0.0f, 0.0f, this.transform.eulerAngles.z);
            Quaternion b = Quaternion.Euler(0.0f, 0.0f, rotation.eulerAngles.z);
            rigidbody2D.AddTorque(Quaternion.Angle(a, b) * this.rigidbodyTorqueModifier, ForceMode2D.Impulse);
          }
        }
      }
      else
      {
        foreach (Rigidbody rigidbody in this.m_Rigidbodies)
        {
          if ((bool) ((UnityEngine.Object) rigidbody))
          {
            rigidbody.AddForce(translation * this.rigidbodyForceModifier, ForceMode.Impulse);
            Quaternion a1 = Quaternion.Euler(this.transform.eulerAngles.x, 0.0f, 0.0f);
            Quaternion b1 = Quaternion.Euler(rotation.eulerAngles.x, 0.0f, 0.0f);
            Vector3 vector3;
            vector3.x = Quaternion.Angle(a1, b1);
            Quaternion a2 = Quaternion.Euler(0.0f, this.transform.eulerAngles.y, 0.0f);
            Quaternion b2 = Quaternion.Euler(0.0f, this.transform.eulerAngles.y, 0.0f);
            vector3.y = Quaternion.Angle(a2, b2);
            Quaternion a3 = Quaternion.Euler(0.0f, 0.0f, this.transform.eulerAngles.z);
            Quaternion b3 = Quaternion.Euler(0.0f, 0.0f, rotation.eulerAngles.z);
            vector3.z = Quaternion.Angle(a3, b3);
            rigidbody.AddTorque(vector3 * this.rigidbodyTorqueModifier, ForceMode.Impulse);
          }
        }
      }
    }

    private void Explosion()
    {
      this.m_MultiShake = true;
      this.m_ShakeEverything = true;
      Vector3 one = Vector3.one;
      Vector3 rotationAmount = new Vector3(0.2f, 0.05f, 1f);
      if (this.is2DExample)
      {
        one.z = 0.0f;
        rotationAmount.x = 0.0f;
        rotationAmount.y = 0.0f;
      }
      this.m_Shake.Shake(this.m_Shake.shakeType, 5, one, rotationAmount, 0.25f, 50f, 0.2f, 1f, true, (Action) (() => this.m_MultiShake = false));
    }

    private void Footsteps()
    {
      this.m_ShakeEverything = true;
      this.m_MultiShake = true;
      this.StartCoroutine(this.DoFootsteps());
    }

    [DebuggerHidden]
    private IEnumerator DoFootsteps()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new CameraShakeExample.\u003CDoFootsteps\u003Ec__Iterator0()
      {
        \u0024this = this
      };
    }

    private void Earthquake()
    {
      this.m_ShakeEverything = true;
      this.m_MultiShake = true;
      this.StartCoroutine(this.DoEarthquake());
      this.StartCoroutine(this.DoEarthquake2());
    }

    [DebuggerHidden]
    private IEnumerator DoEarthquake()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new CameraShakeExample.\u003CDoEarthquake\u003Ec__Iterator1()
      {
        \u0024this = this
      };
    }

    [DebuggerHidden]
    private IEnumerator DoEarthquake2()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new CameraShakeExample.\u003CDoEarthquake2\u003Ec__Iterator2()
      {
        \u0024this = this
      };
    }

    public void OnShakeCamera()
    {
      this.m_ShakeEverything = false;
      this.m_Shake.Shake();
    }

    public void OnShakeEverything()
    {
      this.m_ShakeEverything = true;
      this.m_Shake.Shake();
    }

    public void OnNumberOfShakesSlider(float val)
    {
      this.m_Shake.numberOfShakes = (int) val;
    }

    public void OnShakeAmountXSlider(float val)
    {
      Vector3 shakeAmount = this.m_Shake.shakeAmount;
      shakeAmount.x = val;
      this.m_Shake.shakeAmount = shakeAmount;
    }

    public void OnShakeAmountYSlider(float val)
    {
      Vector3 shakeAmount = this.m_Shake.shakeAmount;
      shakeAmount.y = val;
      this.m_Shake.shakeAmount = shakeAmount;
    }

    public void OnShakeAmountZSlider(float val)
    {
      Vector3 shakeAmount = this.m_Shake.shakeAmount;
      shakeAmount.z = val;
      this.m_Shake.shakeAmount = shakeAmount;
    }

    public void OnRotationAmountXSlider(float val)
    {
      Vector3 rotationAmount = this.m_Shake.rotationAmount;
      rotationAmount.x = val;
      this.m_Shake.rotationAmount = rotationAmount;
    }

    public void OnRotationAmountYSlider(float val)
    {
      Vector3 rotationAmount = this.m_Shake.rotationAmount;
      rotationAmount.y = val;
      this.m_Shake.rotationAmount = rotationAmount;
    }

    public void OnRotationAmountZSlider(float val)
    {
      Vector3 rotationAmount = this.m_Shake.rotationAmount;
      rotationAmount.z = val;
      this.m_Shake.rotationAmount = rotationAmount;
    }

    public void OnDistanceSlider(float val)
    {
      this.m_Shake.distance = val;
    }

    public void OnSpeedSlider(float val)
    {
      this.m_Shake.distance = val;
    }

    public void OnDecaySlider(float val)
    {
      this.m_Shake.decay = val;
    }

    public void OnPresetExplosion()
    {
      this.Explosion();
    }

    public void OnPresetFootsteps()
    {
      this.Footsteps();
    }

    public void OnPresetEarthquake()
    {
      this.Earthquake();
    }
  }
}
