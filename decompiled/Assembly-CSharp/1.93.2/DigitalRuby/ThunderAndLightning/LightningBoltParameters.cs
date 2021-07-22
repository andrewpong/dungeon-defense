using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000286 RID: 646
	[Token(Token = "0x20001FB")]
	[Serializable]
	public sealed class LightningBoltParameters
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x2DC3D4", Offset = "0x2DC3D4", VA = "0x62DC3D4")]
		public LightningBoltParameters()
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00006888 File Offset: 0x00004A88
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		public int Generations
		{
			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x2DC410", Offset = "0x2DC410", VA = "0x62DC410")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E24")]
			[Address(RVA = "0x2DC418", Offset = "0x2DC418", VA = "0x62DC418")]
			set
			{
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x000068A0 File Offset: 0x00004AA0
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011E")]
		public float GrowthMultiplier
		{
			[Token(Token = "0x6000E25")]
			[Address(RVA = "0x2DC65C", Offset = "0x2DC65C", VA = "0x62DC65C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x2DC664", Offset = "0x2DC664", VA = "0x62DC664")]
			set
			{
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011F")]
		public List<Vector3> Points
		{
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x2DC6FC", Offset = "0x2DC6FC", VA = "0x62DC6FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1873BC", Offset = "0x1873BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E28")]
			[Address(RVA = "0x2DC704", Offset = "0x2DC704", VA = "0x62DC704")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1873CC", Offset = "0x1873CC")]
			set
			{
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x2DC70C", Offset = "0x2DC70C", VA = "0x62DC70C")]
		public float ForkMultiplier()
		{
			return 0f;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x2DC760", Offset = "0x2DC760", VA = "0x62DC760")]
		public Vector3 ApplyVariance(Vector3 pos, Vector3 variance)
		{
			return default(Vector3);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x2DC8B0", Offset = "0x2DC8B0", VA = "0x62DC8B0")]
		public static LightningBoltParameters GetOrCreateParameters()
		{
			return null;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x2D9E40", Offset = "0x2D9E40", VA = "0x62D9E40")]
		public static void ReturnParametersToCache(LightningBoltParameters p)
		{
		}

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<LightningBoltParameters> cache;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x8")]
		internal int generationWhereForksStop;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0xC")]
		internal int forkednessCalculated;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x10")]
		internal LightningBoltQualitySetting quality;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x14")]
		internal float delaySeconds;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x18")]
		internal int maxLights;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x4")]
		public static float Scale;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Dictionary<int, LightningQualityMaximum> QualityMaximums;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x1C")]
		public LightningGenerator Generator;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 Start;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 End;

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 StartVariance;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 EndVariance;

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x50")]
		private int generations;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x54")]
		public float LifeTime;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x58")]
		public float Delay;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x5C")]
		public RangeOfFloats DelayRange;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x64")]
		public float ChaosFactor;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x68")]
		public float TrunkWidth;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0x6C")]
		public float EndWidthMultiplier;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0x70")]
		public float Intensity;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0x74")]
		public float GlowIntensity;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x78")]
		public float GlowWidthMultiplier;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x7C")]
		public float Forkedness;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x80")]
		public int GenerationWhereForksStopSubtractor;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x84")]
		public System.Random Random;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x88")]
		public float FadePercent;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x8C")]
		private float growthMultiplier;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x90")]
		public float ForkLengthMultiplier;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x94")]
		public float ForkLengthVariance;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x98")]
		public float ForkEndWidthMultiplier;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x9C")]
		public LightningLightParameters LightParameters;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x40006D0")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181A80", Offset = "0x181A80")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181A80", Offset = "0x181A80")]
		private List<Vector3> <Points>k__BackingField;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x40006D1")]
		[FieldOffset(Offset = "0xA4")]
		public int SmoothingFactor;
	}
}
