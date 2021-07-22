using System;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000209")]
	public class LightningBoltShapeSphereScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x2E1614", Offset = "0x2E1614", VA = "0x62E1614")]
		public LightningBoltShapeSphereScript()
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x2E1630", Offset = "0x2E1630", VA = "0x62E1630", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1830E4", Offset = "0x1830E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1830E4", Offset = "0x1830E4")]
		public float InnerRadius;

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x134")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183188", Offset = "0x183188")]
		public float Radius;
	}
}
