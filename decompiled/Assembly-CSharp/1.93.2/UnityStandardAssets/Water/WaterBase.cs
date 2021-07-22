using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x02000281 RID: 641
	[Token(Token = "0x20001F6")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x17F30C", Offset = "0x17F30C")]
	public class WaterBase : MonoBehaviour
	{
		// Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0xBDC718", Offset = "0xBDC718", VA = "0x6BDC718")]
		public WaterBase()
		{
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0xBDC730", Offset = "0xBDC730", VA = "0x6BDC730")]
		public void UpdateShader()
		{
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0xBDC944", Offset = "0xBDC944", VA = "0x6BDC944")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0xBDCA30", Offset = "0xBDCA30", VA = "0x6BDCA30")]
		public void Update()
		{
		}

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0xC")]
		public Material sharedMaterial;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x10")]
		public WaterQuality waterQuality;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x14")]
		public bool edgeBlend;
	}
}
