using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000206")]
	public class LightningBoltPrefabScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x06000FEB RID: 4075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x2DD6A0", Offset = "0x2DD6A0", VA = "0x62DD6A0")]
		public LightningBoltPrefabScript()
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x2DD6A4", Offset = "0x2DD6A4", VA = "0x62DD6A4", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182750", Offset = "0x182750")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182750", Offset = "0x182750")]
		public GameObject Source;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x134")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1827D0", Offset = "0x1827D0")]
		public GameObject Destination;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182828", Offset = "0x182828")]
		public Vector3 StartVariance;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x144")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18285C", Offset = "0x18285C")]
		public Vector3 EndVariance;
	}
}
