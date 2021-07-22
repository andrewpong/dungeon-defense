using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x200021B")]
	public class LightningGenerator
	{
		// Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x2E1E20", Offset = "0x2E1E20", VA = "0x62E1E20")]
		public LightningGenerator()
		{
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x2E1E28", Offset = "0x2E1E28", VA = "0x62E1E28")]
		private void GetPerpendicularVector(ref Vector3 directionNormalized, out Vector3 side)
		{
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x2E2020", Offset = "0x2E2020", VA = "0x62E2020", Slot = "4")]
		protected virtual void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
		{
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x2E26D8", Offset = "0x2E26D8", VA = "0x62E26D8")]
		public bool ShouldCreateFork(LightningBoltParameters p, int generation, int totalGenerations)
		{
			return default(bool);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x2E2764", Offset = "0x2E2764", VA = "0x62E2764")]
		public void CreateFork(LightningBolt bolt, LightningBoltParameters p, int generation, int totalGenerations, Vector3 start, Vector3 midPoint)
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x2E20D0", Offset = "0x2E20D0", VA = "0x62E20D0")]
		public void GenerateLightningBoltStandard(LightningBolt bolt, Vector3 start, Vector3 end, int generation, int totalGenerations, float offsetAmount, LightningBoltParameters p)
		{
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x2E2E70", Offset = "0x2E2E70", VA = "0x62E2E70")]
		public Vector3 RandomDirection3D(System.Random r)
		{
			return default(Vector3);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x2E2FC8", Offset = "0x2E2FC8", VA = "0x62E2FC8")]
		public Vector3 RandomDirection2D(System.Random r)
		{
			return default(Vector3);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x2E30D0", Offset = "0x2E30D0", VA = "0x62E30D0")]
		public Vector3 RandomDirection2DXZ(System.Random r)
		{
			return default(Vector3);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x2E28E4", Offset = "0x2E28E4", VA = "0x62E28E4")]
		public void RandomVector(LightningBolt bolt, ref Vector3 start, ref Vector3 end, float offsetAmount, System.Random random, out Vector3 result)
		{
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x2E31D8", Offset = "0x2E31D8", VA = "0x62E31D8")]
		public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters p)
		{
		}

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LightningGenerator GeneratorInstance;
	}
}
