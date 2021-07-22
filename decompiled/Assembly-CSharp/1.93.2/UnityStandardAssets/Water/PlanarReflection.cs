using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x0200027C RID: 636
	[Token(Token = "0x20001F1")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x17F1EC", Offset = "0x17F1EC")]
	[Attribute(Name = "RequireComponent", RVA = "0x17F1EC", Offset = "0x17F1EC")]
	public class PlanarReflection : MonoBehaviour
	{
		// Token: 0x06000F52 RID: 3922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0xBD65AC", Offset = "0xBD65AC", VA = "0x6BD65AC")]
		public PlanarReflection()
		{
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0xBD664C", Offset = "0xBD664C", VA = "0x6BD664C")]
		public void Start()
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0xBD67B0", Offset = "0xBD67B0", VA = "0x6BD67B0")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0xBD6C50", Offset = "0xBD6C50", VA = "0x6BD6C50")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0xBD6D54", Offset = "0xBD6D54", VA = "0x6BD6D54")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0xBD6EA8", Offset = "0xBD6EA8", VA = "0x6BD6EA8")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0xBD8014", Offset = "0xBD8014", VA = "0x6BD8014")]
		public void LateUpdate()
		{
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0xBD8080", Offset = "0xBD8080", VA = "0x6BD8080")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0xBD81B8", Offset = "0xBD81B8", VA = "0x6BD81B8")]
		public void OnEnable()
		{
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0xBD8230", Offset = "0xBD8230", VA = "0x6BD8230")]
		public void OnDisable()
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0xBD707C", Offset = "0xBD707C", VA = "0x6BD707C")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0xBD82A8", Offset = "0xBD82A8", VA = "0x6BD82A8")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0xBD891C", Offset = "0xBD891C", VA = "0x6BD891C")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0xBD8364", Offset = "0xBD8364", VA = "0x6BD8364")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0xBD8CEC", Offset = "0xBD8CEC", VA = "0x6BD8CEC")]
		private static float Sgn(float a)
		{
			return 0f;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0xBD86C8", Offset = "0xBD86C8", VA = "0x6BD86C8")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0xC")]
		public LayerMask reflectionMask;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x10")]
		public bool reflectSkybox;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x14")]
		public Color clearColor;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x24")]
		public string reflectionSampler;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x28")]
		public float clipPlaneOffset;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_Oldpos;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_ReflectionCamera;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x3C")]
		private Material m_SharedMaterial;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<Camera, bool> m_HelperCameras;
	}
}
