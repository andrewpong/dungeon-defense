// Decompiled with JetBrains decompiler
// Type: Thinksquirrel.CShake.CameraShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Thinksquirrel.CShake.Internal;
using UnityEngine;

namespace Thinksquirrel.CShake
{
  [AddComponentMenu("Camera Shake/Camera Shake")]
  [CameraShakeDocumentationName("Thinksquirrel.CShake.CameraShake")]
  public class CameraShake : CameraShakeBase
  {
    private static readonly List<CameraShake> m_Components = new List<CameraShake>();
    [SerializeField]
    private List<Camera> m_Cameras = new List<Camera>();
    [SerializeField]
    private int m_NumberOfShakes = 2;
    [SerializeField]
    private Vector3 m_ShakeAmount = Vector3.one;
    [SerializeField]
    private Vector3 m_RotationAmount = Vector3.one;
    [SerializeField]
    private float m_Distance = 0.1f;
    [SerializeField]
    private float m_Speed = 50f;
    [SerializeField]
    private float m_Decay = 0.2f;
    [SerializeField]
    private float m_UiShakeModifier = 1f;
    [SerializeField]
    private bool m_MultiplyByTimeScale = true;
    private readonly List<Vector3> m_MatrixOffsetCache = new List<Vector3>(10);
    private readonly List<Quaternion> m_MatrixRotationCache = new List<Quaternion>(10);
    private readonly List<Vector3> m_OffsetCache = new List<Vector3>(10);
    private readonly List<Quaternion> m_RotationCache = new List<Quaternion>(10);
    private readonly List<bool> m_IgnoreMatrixCache = new List<bool>(10);
    private readonly List<bool> m_IgnorePositionCache = new List<bool>(10);
    private readonly Dictionary<Camera, List<CameraShake.ShakeState>> m_States = new Dictionary<Camera, List<CameraShake.ShakeState>>();
    private readonly Dictionary<Camera, int> m_ShakeCount = new Dictionary<Camera, int>();
    [SerializeField]
    private CameraShake.ShakeType m_ShakeType;
    private Rect m_ShakeRect;
    private bool m_Shaking;
    private bool m_Cancelling;
    private const float minShakeValue = 0.001f;
    private const float minRotationValue = 0.001f;

    public List<Camera> cameras
    {
      get
      {
        return this.m_Cameras;
      }
      set
      {
        this.m_Cameras = value;
      }
    }

    public CameraShake.ShakeType shakeType
    {
      get
      {
        return this.m_ShakeType;
      }
      set
      {
        this.m_ShakeType = value;
      }
    }

    public int numberOfShakes
    {
      get
      {
        return this.m_NumberOfShakes;
      }
      set
      {
        this.m_NumberOfShakes = value;
      }
    }

    public Vector3 shakeAmount
    {
      get
      {
        return this.m_ShakeAmount;
      }
      set
      {
        this.m_ShakeAmount = value;
      }
    }

    public Vector3 rotationAmount
    {
      get
      {
        return this.m_RotationAmount;
      }
      set
      {
        this.m_RotationAmount = value;
      }
    }

    public float distance
    {
      get
      {
        return this.m_Distance;
      }
      set
      {
        this.m_Distance = value;
      }
    }

    public float speed
    {
      get
      {
        return this.m_Speed;
      }
      set
      {
        this.m_Speed = value;
      }
    }

    public float decay
    {
      get
      {
        return this.m_Decay;
      }
      set
      {
        this.m_Decay = value;
      }
    }

    [Obsolete("Use CameraShake.uiShakeModifier instead")]
    public float guiShakeModifier
    {
      get
      {
        return this.uiShakeModifier;
      }
      set
      {
        this.uiShakeModifier = value;
      }
    }

    public float uiShakeModifier
    {
      get
      {
        return this.m_UiShakeModifier;
      }
      set
      {
        this.m_UiShakeModifier = value;
      }
    }

    public bool multiplyByTimeScale
    {
      get
      {
        return this.m_MultiplyByTimeScale;
      }
      set
      {
        this.m_MultiplyByTimeScale = value;
      }
    }

    public Rect uiShakeRect
    {
      get
      {
        return this.m_ShakeRect;
      }
      set
      {
        this.m_ShakeRect = value;
      }
    }

    public static CameraShake instance
    {
      get
      {
        if (CameraShake.m_Components.Count > 0)
          return CameraShake.m_Components[0];
        return (CameraShake) null;
      }
    }

    [Obsolete("Use IsShaking method on individual Camera Shake components")]
    public static bool isShaking
    {
      get
      {
        int index = 0;
        for (int count = CameraShake.m_Components.Count; index < count; ++index)
        {
          if (CameraShake.m_Components[index].IsShaking())
            return true;
        }
        return false;
      }
    }

    [Obsolete("Use IsCancelling method on individual Camera Shake components")]
    public static bool isCancelling
    {
      get
      {
        CameraShake cameraShake = CameraShake.m_Components.Count <= 0 ? (CameraShake) null : CameraShake.m_Components[0];
        if ((UnityEngine.Object) cameraShake != (UnityEngine.Object) null)
          return cameraShake.IsCancelling();
        return false;
      }
    }

    [Obsolete("Use CameraShake.onStartShaking instead")]
    public event Action cameraShakeStarted
    {
      add
      {
        this.onStartShaking += value;
      }
      remove
      {
        this.onStartShaking -= value;
      }
    }

    [Obsolete("Use CameraShake.onEndShaking")]
    public event Action allCameraShakesCompleted
    {
      add
      {
        this.onEndShaking += value;
      }
      remove
      {
        this.onEndShaking -= value;
      }
    }

    public event Action onStartShaking;

    public event Action onEndShaking;

    public event Action onPreShake;

    public event Action onPostShake;

    public event Action<Vector3, Quaternion> onShakeOffset;

    private void OnEnable()
    {
      if (this.cameras.Count < 1 && (bool) ((UnityEngine.Object) this.GetComponent<Camera>()))
        this.cameras.Add(this.GetComponent<Camera>());
      if (this.cameras.Count < 1 && (bool) ((UnityEngine.Object) Camera.main))
        this.cameras.Add(Camera.main);
      if (this.cameras.Count < 1)
        CameraShakeBase.LogError((object) "No cameras assigned in the inspector!", "Camera Shake", nameof (CameraShake), (UnityEngine.Object) this);
      CameraShake.m_Components.Add(this);
    }

    private void OnDisable()
    {
      CameraShake.m_Components.Remove(this);
    }

    public static CameraShake[] GetComponents()
    {
      return CameraShake.m_Components.ToArray();
    }

    public static void ShakeAll()
    {
      int index = 0;
      for (int count = CameraShake.m_Components.Count; index < count; ++index)
        CameraShake.m_Components[index].Shake();
    }

    public static void ShakeAll(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale)
    {
      int index = 0;
      for (int count = CameraShake.m_Components.Count; index < count; ++index)
        CameraShake.m_Components[index].Shake(shakeType, numberOfShakes, shakeAmount, rotationAmount, distance, speed, decay, uiShakeModifier, multiplyByTimeScale);
    }

    public static void ShakeAll(Action callback)
    {
      int index = 0;
      for (int count = CameraShake.m_Components.Count; index < count; ++index)
        CameraShake.m_Components[index].Shake(callback);
    }

    public static void ShakeAll(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale, Action callback)
    {
      int index = 0;
      for (int count = CameraShake.m_Components.Count; index < count; ++index)
        CameraShake.m_Components[index].Shake(shakeType, numberOfShakes, shakeAmount, rotationAmount, distance, speed, decay, uiShakeModifier, multiplyByTimeScale, callback);
    }

    public static void CancelAllShakes()
    {
      int index = 0;
      for (int count = CameraShake.m_Components.Count; index < count; ++index)
        CameraShake.m_Components[index].CancelShake();
    }

    public static void CancelAllShakes(float time)
    {
      int index = 0;
      for (int count = CameraShake.m_Components.Count; index < count; ++index)
        CameraShake.m_Components[index].CancelShake(time);
    }

    public bool IsShaking()
    {
      return this.m_Shaking;
    }

    public bool IsCancelling()
    {
      return this.m_Cancelling;
    }

    public void Shake()
    {
      Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
      int index = 0;
      for (int count = this.cameras.Count; index < count; ++index)
        this.StartCoroutine(this.DoShake_Internal(this.cameras[index], insideUnitSphere, this.shakeType, this.numberOfShakes, this.shakeAmount, this.rotationAmount, this.distance, this.speed, this.decay, this.uiShakeModifier, this.multiplyByTimeScale, (Action) null));
    }

    public void Shake(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale)
    {
      Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
      int index = 0;
      for (int count = this.cameras.Count; index < count; ++index)
        this.StartCoroutine(this.DoShake_Internal(this.cameras[index], insideUnitSphere, shakeType, numberOfShakes, shakeAmount, rotationAmount, distance, speed, decay, uiShakeModifier, multiplyByTimeScale, (Action) null));
    }

    public void Shake(Action callback)
    {
      Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
      int index = 0;
      for (int count = this.cameras.Count; index < count; ++index)
        this.StartCoroutine(this.DoShake_Internal(this.cameras[index], insideUnitSphere, this.shakeType, this.numberOfShakes, this.shakeAmount, this.rotationAmount, this.distance, this.speed, this.decay, this.uiShakeModifier, this.multiplyByTimeScale, callback));
    }

    public void Shake(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale, Action callback)
    {
      Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
      int index = 0;
      for (int count = this.cameras.Count; index < count; ++index)
        this.StartCoroutine(this.DoShake_Internal(this.cameras[index], insideUnitSphere, shakeType, numberOfShakes, shakeAmount, rotationAmount, distance, speed, decay, uiShakeModifier, multiplyByTimeScale, callback));
    }

    public void CancelShake()
    {
      if (!this.m_Shaking || this.m_Cancelling)
        return;
      this.m_Shaking = false;
      this.StopAllCoroutines();
      int index = 0;
      for (int count = this.cameras.Count; index < count; ++index)
      {
        Camera camera = this.cameras[index];
        if (this.m_ShakeCount.ContainsKey(camera))
          this.m_ShakeCount[camera] = 0;
        this.ResetState(camera);
      }
    }

    public void CancelShake(float time)
    {
      if (!this.m_Shaking || this.m_Cancelling)
        return;
      this.StopAllCoroutines();
      this.StartCoroutine(this.DoResetState((IList<Camera>) this.cameras, (IDictionary<Camera, int>) this.m_ShakeCount, time));
    }

    public void BeginShakeGUI()
    {
      this.CheckShakeRect();
      GUI.BeginGroup(this.m_ShakeRect);
    }

    public void EndShakeGUI()
    {
      GUI.EndGroup();
    }

    public void BeginShakeGUILayout()
    {
      this.CheckShakeRect();
      GUILayout.BeginArea(this.m_ShakeRect);
    }

    public void EndShakeGUILayout()
    {
      GUILayout.EndArea();
    }

    private void OnDrawGizmosSelected()
    {
      int index = 0;
      for (int count = this.cameras.Count; index < count; ++index)
      {
        Camera camera = this.cameras[index];
        if ((bool) ((UnityEngine.Object) camera))
        {
          if (this.IsShaking())
          {
            Vector4 column = camera.worldToCameraMatrix.GetColumn(3);
            column.z *= -1f;
            Gizmos.matrix = Matrix4x4.TRS((Vector3) (Vector4) (camera.transform.position + camera.transform.TransformPoint((Vector3) column)), CameraShake.QuaternionFromMatrix(camera.worldToCameraMatrix.inverse * Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(1f, 1f, -1f))), camera.transform.lossyScale);
          }
          else
            Gizmos.matrix = Matrix4x4.TRS(camera.transform.position, camera.transform.rotation, camera.transform.lossyScale);
          Gizmos.DrawWireCube(Vector3.zero, this.shakeAmount);
          Gizmos.color = Color.cyan;
          if (camera.orthographic)
            Gizmos.DrawWireCube(new Vector3(0.0f, 0.0f, (float) (((double) camera.nearClipPlane + (double) camera.farClipPlane) / 2.0)), new Vector3(camera.orthographicSize / camera.aspect, camera.orthographicSize * 2f, camera.farClipPlane - camera.nearClipPlane));
          else
            Gizmos.DrawFrustum(Vector3.zero, camera.fieldOfView, camera.farClipPlane, camera.nearClipPlane, 0.7f / camera.aspect);
        }
      }
    }

    [DebuggerHidden]
    private IEnumerator DoShake_Internal(Camera cam, Vector3 seed, CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale, Action callback)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new CameraShake.\u003CDoShake_Internal\u003Ec__Iterator0()
      {
        seed = seed,
        cam = cam,
        numberOfShakes = numberOfShakes,
        distance = distance,
        multiplyByTimeScale = multiplyByTimeScale,
        uiShakeModifier = uiShakeModifier,
        shakeType = shakeType,
        rotationAmount = rotationAmount,
        shakeAmount = shakeAmount,
        speed = speed,
        decay = decay,
        callback = callback,
        \u0024this = this
      };
    }

    private void CheckShakeRect()
    {
      if ((double) Mathf.Abs((float) Screen.width - this.m_ShakeRect.width) <= 9.99999974737875E-06 && (double) Mathf.Abs((float) Screen.height - this.m_ShakeRect.height) <= 9.99999974737875E-06)
        return;
      this.m_ShakeRect.width = (float) Screen.width;
      this.m_ShakeRect.height = (float) Screen.height;
    }

    private void ResetState(Camera cam)
    {
      cam.ResetWorldToCameraMatrix();
      this.m_ShakeRect.x = 0.0f;
      this.m_ShakeRect.y = 0.0f;
      this.m_States[cam].Clear();
    }

    [DebuggerHidden]
    private IEnumerator DoResetState(IList<Camera> cameras, IDictionary<Camera, int> shakeCount, float time)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new CameraShake.\u003CDoResetState\u003Ec__Iterator1()
      {
        cameras = cameras,
        shakeCount = shakeCount,
        time = time,
        \u0024this = this
      };
    }

    private static Vector3 GetGeometricAvg(IList<CameraShake.ShakeState> states, bool position)
    {
      float num1 = 0.0f;
      float num2 = 0.0f;
      float num3 = 0.0f;
      float count1 = (float) states.Count;
      int index = 0;
      for (int count2 = states.Count; index < count2; ++index)
      {
        CameraShake.ShakeState state = states[index];
        if (position)
        {
          num1 -= state._shakePosition.x;
          num2 -= state._shakePosition.y;
          num3 -= state._shakePosition.z;
        }
        else
        {
          num1 += state._uiShakePosition.x;
          num2 += state._uiShakePosition.y;
        }
      }
      return new Vector3(num1 / count1, num2 / count1, num3 / count1);
    }

    private static Quaternion GetAvgRotation(IList<CameraShake.ShakeState> states)
    {
      Quaternion b = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
      int index = 0;
      for (int count = states.Count; index < count; ++index)
      {
        CameraShake.ShakeState state = states[index];
        if ((double) Quaternion.Dot(state._shakeRotation, b) > 0.0)
        {
          b.x += state._shakeRotation.x;
          b.y += state._shakeRotation.y;
          b.z += state._shakeRotation.z;
          b.w += state._shakeRotation.w;
        }
        else
        {
          b.x += -state._shakeRotation.x;
          b.y += -state._shakeRotation.y;
          b.z += -state._shakeRotation.z;
          b.w += -state._shakeRotation.w;
        }
      }
      float num = Mathf.Sqrt((float) ((double) b.x * (double) b.x + (double) b.y * (double) b.y + (double) b.z * (double) b.z + (double) b.w * (double) b.w));
      if ((double) num > 9.99999974737875E-05)
      {
        b.x /= num;
        b.y /= num;
        b.z /= num;
        b.w /= num;
      }
      else
        b = states[0]._shakeRotation;
      return b;
    }

    private static float GetPixelWidth(Transform cachedTransform, Camera cachedCamera)
    {
      Vector3 position1 = cachedTransform.position;
      Vector3 screenPoint = cachedCamera.WorldToScreenPoint(position1 - cachedTransform.forward * 0.01f);
      Vector3 vector3_1 = screenPoint;
      Vector3 vector3_2 = (double) screenPoint.x <= 0.0 ? vector3_1 + Vector3.right : vector3_1 - Vector3.right;
      Vector3 position2 = (double) screenPoint.y <= 0.0 ? vector3_2 + Vector3.up : vector3_2 - Vector3.up;
      Vector3 worldPoint = cachedCamera.ScreenToWorldPoint(position2);
      return 1f / (cachedTransform.InverseTransformPoint(position1) - cachedTransform.InverseTransformPoint(worldPoint)).magnitude;
    }

    private static Quaternion QuaternionFromMatrix(Matrix4x4 m)
    {
      return Quaternion.LookRotation((Vector3) m.GetColumn(2), (Vector3) m.GetColumn(1));
    }

    private static void NormalizeQuaternion(ref Quaternion q)
    {
      float f = 0.0f;
      for (int index = 0; index < 4; ++index)
        f += q[index] * q[index];
      float num = 1f / Mathf.Sqrt(f);
      for (int index = 0; index < 4; ++index)
        q[index] *= num;
    }

    public enum ShakeType
    {
      CameraMatrix,
      LocalPosition,
    }

    internal class ShakeState
    {
      internal readonly CameraShake.ShakeType _shakeType;
      internal readonly Vector3 _startPosition;
      internal readonly Quaternion _startRotation;
      internal readonly Vector2 _uiStartPosition;
      internal Vector3 _shakePosition;
      internal Quaternion _shakeRotation;
      internal Vector2 _uiShakePosition;

      internal ShakeState(CameraShake.ShakeType shakeType, Vector3 position, Quaternion rotation, Vector2 uiPosition)
      {
        this._shakeType = shakeType;
        this._startPosition = position;
        this._startRotation = rotation;
        this._uiStartPosition = uiPosition;
        this._shakePosition = position;
        this._shakeRotation = rotation;
        this._uiShakePosition = uiPosition;
      }
    }
  }
}
