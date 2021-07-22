using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x200021C")]
	public class LightningGeneratorPath : LightningGenerator
	{
		// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x2E33D4", Offset = "0x2E33D4", VA = "0x62E33D4")]
		public LightningGeneratorPath()
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x2E3458", Offset = "0x2E3458", VA = "0x62E3458")]
		public void GenerateLightningBoltPath(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x2E3D10", Offset = "0x2E3D10", VA = "0x62E3D10", Slot = "4")]
		protected override void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
		{
		}

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LightningGeneratorPath PathGeneratorInstance;
	}
}
