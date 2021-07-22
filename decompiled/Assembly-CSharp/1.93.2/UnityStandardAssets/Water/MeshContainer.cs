using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x0200027B RID: 635
	[Token(Token = "0x20001F0")]
	public class MeshContainer
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0xBD64E0", Offset = "0xBD64E0", VA = "0x6BD64E0")]
		public MeshContainer(Mesh m)
		{
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0xBD654C", Offset = "0xBD654C", VA = "0x6BD654C")]
		public void Update()
		{
		}

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x8")]
		public Mesh mesh;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0xC")]
		public Vector3[] vertices;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] normals;
	}
}
