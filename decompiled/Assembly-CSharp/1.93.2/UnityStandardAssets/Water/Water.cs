using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x20001F3")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x17F2FC", Offset = "0x17F2FC")]
	public class Water : MonoBehaviour
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0xBD912C", Offset = "0xBD912C", VA = "0x6BD912C")]
		public Water()
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0xBD9218", Offset = "0xBD9218", VA = "0x6BD9218")]
		public void OnWillRenderObject()
		{
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0xBDBE80", Offset = "0xBDBE80", VA = "0x6BDBE80")]
		private void OnDisable()
		{
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0xBDC370", Offset = "0xBDC370", VA = "0x6BDC370")]
		private void Update()
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0xBDB510", Offset = "0xBDB510", VA = "0x6BDB510")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0xBDA448", Offset = "0xBDA448", VA = "0x6BDA448")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0xBDA430", Offset = "0xBDA430", VA = "0x6BDA430")]
		private Water.WaterMode GetWaterMode()
		{
			return Water.WaterMode.Simple;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0xBDA22C", Offset = "0xBDA22C", VA = "0x6BDA22C")]
		private Water.WaterMode FindHardwareWaterSupport()
		{
			return Water.WaterMode.Simple;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0xBDBC2C", Offset = "0xBDBC2C", VA = "0x6BDBC2C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0xBDB958", Offset = "0xBDB958", VA = "0x6BDB958")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0xC")]
		public Water.WaterMode waterMode;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x10")]
		public bool disablePixelLights;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x14")]
		public int textureSize;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x18")]
		public float clipPlaneOffset;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask reflectLayers;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask refractLayers;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x2C")]
		private RenderTexture m_ReflectionTexture;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_RefractionTexture;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x34")]
		private Water.WaterMode m_HardwareWaterSupport;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x38")]
		private int m_OldReflectionTextureSize;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x3C")]
		private int m_OldRefractionTextureSize;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		// Token: 0x0200027F RID: 639
		[Token(Token = "0x20001F4")]
		public enum WaterMode
		{
			// Token: 0x040007F9 RID: 2041
			[Token(Token = "0x4000690")]
			Simple,
			// Token: 0x040007FA RID: 2042
			[Token(Token = "0x4000691")]
			Reflective,
			// Token: 0x040007FB RID: 2043
			[Token(Token = "0x4000692")]
			Refractive
		}
	}
}
