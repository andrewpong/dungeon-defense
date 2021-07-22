using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x200021A")]
	public class LightningFieldScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x2E18F0", Offset = "0x2E18F0", VA = "0x62E18F0")]
		public LightningFieldScript()
		{
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x2E1900", Offset = "0x2E1900", VA = "0x62E1900")]
		private Vector3 RandomPointInBounds()
		{
			return default(Vector3);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x2E19E8", Offset = "0x2E19E8", VA = "0x62E19E8", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x2E1AA8", Offset = "0x2E1AA8", VA = "0x62E1AA8", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x2E1BE4", Offset = "0x2E1BE4", VA = "0x62E1BE4", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x18336C", Offset = "0x18336C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18336C", Offset = "0x18336C")]
		public float MinimumLength;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x134")]
		private float minimumLengthSquared;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183400", Offset = "0x183400")]
		public Bounds FieldBounds;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18344C", Offset = "0x18344C")]
		public Light Light;
	}
}
