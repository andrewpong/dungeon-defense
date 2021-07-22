using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x02000282 RID: 642
	[Token(Token = "0x20001F7")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x17F31C", Offset = "0x17F31C")]
	public class WaterTile : MonoBehaviour
	{
		// Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0xBDCAC8", Offset = "0xBDCAC8", VA = "0x6BDCAC8")]
		public WaterTile()
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0xBDCAD0", Offset = "0xBDCAD0", VA = "0x6BDCAD0")]
		public void Start()
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0xBDCAD4", Offset = "0xBDCAD4", VA = "0x6BDCAD4")]
		private void AcquireComponents()
		{
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0xBDCD50", Offset = "0xBDCD50", VA = "0x6BDCD50")]
		public void OnWillRenderObject()
		{
		}

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0xC")]
		public PlanarReflection reflection;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x10")]
		public WaterBase waterBase;
	}
}
