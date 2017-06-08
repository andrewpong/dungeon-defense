// Decompiled with JetBrains decompiler
// Type: UnityStandardAssets.Water.Water
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Water
{
  [ExecuteInEditMode]
  public class Water : MonoBehaviour
  {
    public UnityStandardAssets.Water.Water.WaterMode waterMode = UnityStandardAssets.Water.Water.WaterMode.Refractive;
    public bool disablePixelLights = true;
    public int textureSize = 256;
    public float clipPlaneOffset = 0.07f;
    public LayerMask reflectLayers = (LayerMask) -1;
    public LayerMask refractLayers = (LayerMask) -1;
    private Dictionary<Camera, Camera> m_ReflectionCameras = new Dictionary<Camera, Camera>();
    private Dictionary<Camera, Camera> m_RefractionCameras = new Dictionary<Camera, Camera>();
    private UnityStandardAssets.Water.Water.WaterMode m_HardwareWaterSupport = UnityStandardAssets.Water.Water.WaterMode.Refractive;
    private RenderTexture m_ReflectionTexture;
    private RenderTexture m_RefractionTexture;
    private int m_OldReflectionTextureSize;
    private int m_OldRefractionTextureSize;
    private static bool s_InsideWater;

    public void OnWillRenderObject()
    {
      if (!this.enabled || !(bool) ((UnityEngine.Object) this.GetComponent<Renderer>()) || (!(bool) ((UnityEngine.Object) this.GetComponent<Renderer>().sharedMaterial) || !this.GetComponent<Renderer>().enabled))
        return;
      Camera current = Camera.current;
      if (!(bool) ((UnityEngine.Object) current) || UnityStandardAssets.Water.Water.s_InsideWater)
        return;
      UnityStandardAssets.Water.Water.s_InsideWater = true;
      this.m_HardwareWaterSupport = this.FindHardwareWaterSupport();
      UnityStandardAssets.Water.Water.WaterMode waterMode = this.GetWaterMode();
      Camera reflectionCamera;
      Camera refractionCamera;
      this.CreateWaterObjects(current, out reflectionCamera, out refractionCamera);
      Vector3 position1 = this.transform.position;
      Vector3 up = this.transform.up;
      int pixelLightCount = QualitySettings.pixelLightCount;
      if (this.disablePixelLights)
        QualitySettings.pixelLightCount = 0;
      this.UpdateCameraModes(current, reflectionCamera);
      this.UpdateCameraModes(current, refractionCamera);
      if (waterMode >= UnityStandardAssets.Water.Water.WaterMode.Reflective)
      {
        float w = -Vector3.Dot(up, position1) - this.clipPlaneOffset;
        Vector4 plane = new Vector4(up.x, up.y, up.z, w);
        Matrix4x4 zero = Matrix4x4.zero;
        UnityStandardAssets.Water.Water.CalculateReflectionMatrix(ref zero, plane);
        Vector3 position2 = current.transform.position;
        Vector3 vector3 = zero.MultiplyPoint(position2);
        reflectionCamera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
        Vector4 clipPlane = this.CameraSpacePlane(reflectionCamera, position1, up, 1f);
        reflectionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
        reflectionCamera.cullingMask = -17 & this.reflectLayers.value;
        reflectionCamera.targetTexture = this.m_ReflectionTexture;
        GL.invertCulling = true;
        reflectionCamera.transform.position = vector3;
        Vector3 eulerAngles = current.transform.eulerAngles;
        reflectionCamera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
        reflectionCamera.Render();
        reflectionCamera.transform.position = position2;
        GL.invertCulling = false;
        this.GetComponent<Renderer>().sharedMaterial.SetTexture("_ReflectionTex", (Texture) this.m_ReflectionTexture);
      }
      if (waterMode >= UnityStandardAssets.Water.Water.WaterMode.Refractive)
      {
        refractionCamera.worldToCameraMatrix = current.worldToCameraMatrix;
        Vector4 clipPlane = this.CameraSpacePlane(refractionCamera, position1, up, -1f);
        refractionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
        refractionCamera.cullingMask = -17 & this.refractLayers.value;
        refractionCamera.targetTexture = this.m_RefractionTexture;
        refractionCamera.transform.position = current.transform.position;
        refractionCamera.transform.rotation = current.transform.rotation;
        refractionCamera.Render();
        this.GetComponent<Renderer>().sharedMaterial.SetTexture("_RefractionTex", (Texture) this.m_RefractionTexture);
      }
      if (this.disablePixelLights)
        QualitySettings.pixelLightCount = pixelLightCount;
      if (waterMode != UnityStandardAssets.Water.Water.WaterMode.Simple)
      {
        if (waterMode != UnityStandardAssets.Water.Water.WaterMode.Reflective)
        {
          if (waterMode == UnityStandardAssets.Water.Water.WaterMode.Refractive)
          {
            Shader.DisableKeyword("WATER_SIMPLE");
            Shader.DisableKeyword("WATER_REFLECTIVE");
            Shader.EnableKeyword("WATER_REFRACTIVE");
          }
        }
        else
        {
          Shader.DisableKeyword("WATER_SIMPLE");
          Shader.EnableKeyword("WATER_REFLECTIVE");
          Shader.DisableKeyword("WATER_REFRACTIVE");
        }
      }
      else
      {
        Shader.EnableKeyword("WATER_SIMPLE");
        Shader.DisableKeyword("WATER_REFLECTIVE");
        Shader.DisableKeyword("WATER_REFRACTIVE");
      }
      UnityStandardAssets.Water.Water.s_InsideWater = false;
    }

    private void OnDisable()
    {
      if ((bool) ((UnityEngine.Object) this.m_ReflectionTexture))
      {
        UnityEngine.Object.DestroyImmediate((UnityEngine.Object) this.m_ReflectionTexture);
        this.m_ReflectionTexture = (RenderTexture) null;
      }
      if ((bool) ((UnityEngine.Object) this.m_RefractionTexture))
      {
        UnityEngine.Object.DestroyImmediate((UnityEngine.Object) this.m_RefractionTexture);
        this.m_RefractionTexture = (RenderTexture) null;
      }
      foreach (KeyValuePair<Camera, Camera> reflectionCamera in this.m_ReflectionCameras)
        UnityEngine.Object.DestroyImmediate((UnityEngine.Object) reflectionCamera.Value.gameObject);
      this.m_ReflectionCameras.Clear();
      foreach (KeyValuePair<Camera, Camera> refractionCamera in this.m_RefractionCameras)
        UnityEngine.Object.DestroyImmediate((UnityEngine.Object) refractionCamera.Value.gameObject);
      this.m_RefractionCameras.Clear();
    }

    private void Update()
    {
      if (!(bool) ((UnityEngine.Object) this.GetComponent<Renderer>()))
        return;
      Material sharedMaterial = this.GetComponent<Renderer>().sharedMaterial;
      if (!(bool) ((UnityEngine.Object) sharedMaterial))
        return;
      Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
      float num1 = sharedMaterial.GetFloat("_WaveScale");
      Vector4 vector4_1 = new Vector4(num1, num1, num1 * 0.4f, num1 * 0.45f);
      double num2 = (double) Time.timeSinceLevelLoad / 20.0;
      Vector4 vector4_2 = new Vector4((float) Math.IEEERemainder((double) vector.x * (double) vector4_1.x * num2, 1.0), (float) Math.IEEERemainder((double) vector.y * (double) vector4_1.y * num2, 1.0), (float) Math.IEEERemainder((double) vector.z * (double) vector4_1.z * num2, 1.0), (float) Math.IEEERemainder((double) vector.w * (double) vector4_1.w * num2, 1.0));
      sharedMaterial.SetVector("_WaveOffset", vector4_2);
      sharedMaterial.SetVector("_WaveScale4", vector4_1);
    }

    private void UpdateCameraModes(Camera src, Camera dest)
    {
      if ((UnityEngine.Object) dest == (UnityEngine.Object) null)
        return;
      dest.clearFlags = src.clearFlags;
      dest.backgroundColor = src.backgroundColor;
      if (src.clearFlags == CameraClearFlags.Skybox)
      {
        Skybox component1 = src.GetComponent<Skybox>();
        Skybox component2 = dest.GetComponent<Skybox>();
        if (!(bool) ((UnityEngine.Object) component1) || !(bool) ((UnityEngine.Object) component1.material))
        {
          component2.enabled = false;
        }
        else
        {
          component2.enabled = true;
          component2.material = component1.material;
        }
      }
      dest.farClipPlane = src.farClipPlane;
      dest.nearClipPlane = src.nearClipPlane;
      dest.orthographic = src.orthographic;
      dest.fieldOfView = src.fieldOfView;
      dest.aspect = src.aspect;
      dest.orthographicSize = src.orthographicSize;
    }

    private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
    {
      UnityStandardAssets.Water.Water.WaterMode waterMode = this.GetWaterMode();
      reflectionCamera = (Camera) null;
      refractionCamera = (Camera) null;
      if (waterMode >= UnityStandardAssets.Water.Water.WaterMode.Reflective)
      {
        if (!(bool) ((UnityEngine.Object) this.m_ReflectionTexture) || this.m_OldReflectionTextureSize != this.textureSize)
        {
          if ((bool) ((UnityEngine.Object) this.m_ReflectionTexture))
            UnityEngine.Object.DestroyImmediate((UnityEngine.Object) this.m_ReflectionTexture);
          this.m_ReflectionTexture = new RenderTexture(this.textureSize, this.textureSize, 16);
          this.m_ReflectionTexture.name = "__WaterReflection" + (object) this.GetInstanceID();
          this.m_ReflectionTexture.isPowerOfTwo = true;
          this.m_ReflectionTexture.hideFlags = HideFlags.DontSave;
          this.m_OldReflectionTextureSize = this.textureSize;
        }
        this.m_ReflectionCameras.TryGetValue(currentCamera, out reflectionCamera);
        if (!(bool) ((UnityEngine.Object) reflectionCamera))
        {
          GameObject gameObject = new GameObject("Water Refl Camera id" + (object) this.GetInstanceID() + " for " + (object) currentCamera.GetInstanceID(), new System.Type[2]{ typeof (Camera), typeof (Skybox) });
          reflectionCamera = gameObject.GetComponent<Camera>();
          reflectionCamera.enabled = false;
          reflectionCamera.transform.position = this.transform.position;
          reflectionCamera.transform.rotation = this.transform.rotation;
          reflectionCamera.gameObject.AddComponent<FlareLayer>();
          gameObject.hideFlags = HideFlags.HideAndDontSave;
          this.m_ReflectionCameras[currentCamera] = reflectionCamera;
        }
      }
      if (waterMode < UnityStandardAssets.Water.Water.WaterMode.Refractive)
        return;
      if (!(bool) ((UnityEngine.Object) this.m_RefractionTexture) || this.m_OldRefractionTextureSize != this.textureSize)
      {
        if ((bool) ((UnityEngine.Object) this.m_RefractionTexture))
          UnityEngine.Object.DestroyImmediate((UnityEngine.Object) this.m_RefractionTexture);
        this.m_RefractionTexture = new RenderTexture(this.textureSize, this.textureSize, 16);
        this.m_RefractionTexture.name = "__WaterRefraction" + (object) this.GetInstanceID();
        this.m_RefractionTexture.isPowerOfTwo = true;
        this.m_RefractionTexture.hideFlags = HideFlags.DontSave;
        this.m_OldRefractionTextureSize = this.textureSize;
      }
      this.m_RefractionCameras.TryGetValue(currentCamera, out refractionCamera);
      if ((bool) ((UnityEngine.Object) refractionCamera))
        return;
      GameObject gameObject1 = new GameObject("Water Refr Camera id" + (object) this.GetInstanceID() + " for " + (object) currentCamera.GetInstanceID(), new System.Type[2]{ typeof (Camera), typeof (Skybox) });
      refractionCamera = gameObject1.GetComponent<Camera>();
      refractionCamera.enabled = false;
      refractionCamera.transform.position = this.transform.position;
      refractionCamera.transform.rotation = this.transform.rotation;
      refractionCamera.gameObject.AddComponent<FlareLayer>();
      gameObject1.hideFlags = HideFlags.HideAndDontSave;
      this.m_RefractionCameras[currentCamera] = refractionCamera;
    }

    private UnityStandardAssets.Water.Water.WaterMode GetWaterMode()
    {
      if (this.m_HardwareWaterSupport < this.waterMode)
        return this.m_HardwareWaterSupport;
      return this.waterMode;
    }

    private UnityStandardAssets.Water.Water.WaterMode FindHardwareWaterSupport()
    {
      if (!(bool) ((UnityEngine.Object) this.GetComponent<Renderer>()))
        return UnityStandardAssets.Water.Water.WaterMode.Simple;
      Material sharedMaterial = this.GetComponent<Renderer>().sharedMaterial;
      if (!(bool) ((UnityEngine.Object) sharedMaterial))
        return UnityStandardAssets.Water.Water.WaterMode.Simple;
      string tag = sharedMaterial.GetTag("WATERMODE", false);
      if (tag == "Refractive")
        return UnityStandardAssets.Water.Water.WaterMode.Refractive;
      return tag == "Reflective" ? UnityStandardAssets.Water.Water.WaterMode.Reflective : UnityStandardAssets.Water.Water.WaterMode.Simple;
    }

    private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
    {
      Vector3 v = pos + normal * this.clipPlaneOffset;
      Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
      Vector3 lhs = worldToCameraMatrix.MultiplyPoint(v);
      Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
      return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
    }

    private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
    {
      reflectionMat.m00 = (float) (1.0 - 2.0 * (double) plane[0] * (double) plane[0]);
      reflectionMat.m01 = -2f * plane[0] * plane[1];
      reflectionMat.m02 = -2f * plane[0] * plane[2];
      reflectionMat.m03 = -2f * plane[3] * plane[0];
      reflectionMat.m10 = -2f * plane[1] * plane[0];
      reflectionMat.m11 = (float) (1.0 - 2.0 * (double) plane[1] * (double) plane[1]);
      reflectionMat.m12 = -2f * plane[1] * plane[2];
      reflectionMat.m13 = -2f * plane[3] * plane[1];
      reflectionMat.m20 = -2f * plane[2] * plane[0];
      reflectionMat.m21 = -2f * plane[2] * plane[1];
      reflectionMat.m22 = (float) (1.0 - 2.0 * (double) plane[2] * (double) plane[2]);
      reflectionMat.m23 = -2f * plane[3] * plane[2];
      reflectionMat.m30 = 0.0f;
      reflectionMat.m31 = 0.0f;
      reflectionMat.m32 = 0.0f;
      reflectionMat.m33 = 1f;
    }

    public enum WaterMode
    {
      Simple,
      Reflective,
      Refractive,
    }
  }
}
