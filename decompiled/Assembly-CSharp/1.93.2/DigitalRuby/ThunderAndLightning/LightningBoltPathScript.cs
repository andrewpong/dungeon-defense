using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000204")]
	public class LightningBoltPathScript : LightningBoltPathScriptBase
	{
		// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x2DCB08", Offset = "0x2DCB08", VA = "0x62DCB08")]
		public LightningBoltPathScript()
		{
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x2DCBB0", Offset = "0x2DCBB0", VA = "0x62DCBB0", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x2DD3C0", Offset = "0x2DD3C0", VA = "0x62DD3C0")]
		public void Reset()
		{
		}

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181D14", Offset = "0x181D14")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181D14", Offset = "0x181D14")]
		public float Speed;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x13C")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x181D68", Offset = "0x181D68")]
		public RangeOfFloats SpeedIntervalRange;

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x144")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181DBC", Offset = "0x181DBC")]
		public bool Repeat;

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x148")]
		private float nextInterval;

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x14C")]
		private int nextIndex;

		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x150")]
		private Vector3? lastPoint;
	}
}
