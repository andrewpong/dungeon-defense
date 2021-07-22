using System;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000208")]
	public class LightningBoltShapeConeScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x2E129C", Offset = "0x2E129C", VA = "0x62E129C")]
		public LightningBoltShapeConeScript()
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x2E12BC", Offset = "0x2E12BC", VA = "0x62E12BC", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182FA4", Offset = "0x182FA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182FA4", Offset = "0x182FA4")]
		public float InnerRadius;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x134")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183048", Offset = "0x183048")]
		public float OuterRadius;

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1830B0", Offset = "0x1830B0")]
		public float Length;
	}
}
