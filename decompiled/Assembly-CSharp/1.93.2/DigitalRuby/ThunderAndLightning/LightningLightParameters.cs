using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x20001FA")]
	[Serializable]
	public class LightningLightParameters
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x2E3DC4", Offset = "0x2E3DC4", VA = "0x62E3DC4")]
		public LightningLightParameters()
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x1700011C")]
		public bool HasLight
		{
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x2E3E48", Offset = "0x2E3E48", VA = "0x62E3E48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18168C", Offset = "0x18168C")]
		[Attribute(Name = "HideInInspector", RVA = "0x18168C", Offset = "0x18168C")]
		public LightRenderMode RenderMode;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1816D4", Offset = "0x1816D4")]
		public Color LightColor;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181714", Offset = "0x181714")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181714", Offset = "0x181714")]
		public float LightPercent;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181764", Offset = "0x181764")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181764", Offset = "0x181764")]
		public float LightShadowPercent;

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1817E0", Offset = "0x1817E0")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1817E0", Offset = "0x1817E0")]
		public float LightIntensity;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181838", Offset = "0x181838")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181838", Offset = "0x181838")]
		public float BounceIntensity;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181894", Offset = "0x181894")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181894", Offset = "0x181894")]
		public float ShadowStrength;

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181914", Offset = "0x181914")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181914", Offset = "0x181914")]
		public float ShadowBias;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181970", Offset = "0x181970")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181970", Offset = "0x181970")]
		public float ShadowNormalBias;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1819D8", Offset = "0x1819D8")]
		public float LightRange;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181A24", Offset = "0x181A24")]
		public LayerMask CullingMask;
	}
}
