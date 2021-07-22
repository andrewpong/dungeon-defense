using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x2000222")]
	public class MeshHelper
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x2E4660", Offset = "0x2E4660", VA = "0x62E4660")]
		public MeshHelper(Mesh mesh)
		{
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x2E4CEC", Offset = "0x2E4CEC", VA = "0x62E4CEC")]
		public void GenerateRandomPoint(ref RaycastHit hit, out int triangleIndex)
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x2E4D24", Offset = "0x2E4D24", VA = "0x62E4D24")]
		public void GetRaycastFromTriangleIndex(int triangleIndex, ref RaycastHit hit)
		{
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000136")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0x2EBFE8", Offset = "0x2EBFE8", VA = "0x62EBFE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000137")]
		public int[] Triangles
		{
			[Token(Token = "0x6000EFE")]
			[Address(RVA = "0x2E4D1C", Offset = "0x2E4D1C", VA = "0x62E4D1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000138")]
		public Vector3[] Vertices
		{
			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0x2EBFF0", Offset = "0x2EBFF0", VA = "0x62EBFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000139")]
		public Vector3[] Normals
		{
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x2EBFF8", Offset = "0x2EBFF8", VA = "0x62EBFF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x2EC000", Offset = "0x2EC000", VA = "0x62EC000")]
		private float[] CalculateSurfaceAreas(out float totalSurfaceArea)
		{
			return null;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x2EBC90", Offset = "0x2EBC90", VA = "0x62EBC90")]
		private void CalculateNormalizedAreaWeights()
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x2EBDA4", Offset = "0x2EBDA4", VA = "0x62EBDA4")]
		private int SelectRandomTriangle()
		{
			return 0;
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x2EBE68", Offset = "0x2EBE68", VA = "0x62EBE68")]
		private Vector3 GenerateRandomBarycentricCoordinates()
		{
			return default(Vector3);
		}

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x8")]
		private Mesh mesh;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0xC")]
		private int[] triangles;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x10")]
		private Vector3[] vertices;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x14")]
		private Vector3[] normals;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x18")]
		private float[] normalizedAreaWeights;
	}
}
