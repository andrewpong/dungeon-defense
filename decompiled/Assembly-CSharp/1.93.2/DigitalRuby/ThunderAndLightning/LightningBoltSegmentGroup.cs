using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000287 RID: 647
	[Token(Token = "0x20001FC")]
	public class LightningBoltSegmentGroup
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x2E10A8", Offset = "0x2E10A8", VA = "0x62E10A8")]
		public LightningBoltSegmentGroup()
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x17000120")]
		public int SegmentCount
		{
			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x2E1168", Offset = "0x2E1168", VA = "0x62E1168")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x2E11E8", Offset = "0x2E11E8", VA = "0x62E11E8")]
		public void Reset()
		{
		}

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x8")]
		public float LineWidth;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0xC")]
		public int StartIndex;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x10")]
		public int Generation;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x14")]
		public float Delay;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x18")]
		public float PeakStart;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x1C")]
		public float PeakEnd;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x40006D8")]
		[FieldOffset(Offset = "0x20")]
		public float LifeTime;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x40006D9")]
		[FieldOffset(Offset = "0x24")]
		public float EndWidthMultiplier;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x40006DA")]
		[FieldOffset(Offset = "0x28")]
		public Color32 Color;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x40006DB")]
		[FieldOffset(Offset = "0x2C")]
		public readonly List<LightningBoltSegment> Segments;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0x30")]
		public readonly List<Light> Lights;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x34")]
		public LightningLightParameters LightParameters;
	}
}
