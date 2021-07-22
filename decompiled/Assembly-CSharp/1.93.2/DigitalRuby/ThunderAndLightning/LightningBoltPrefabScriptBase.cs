using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000205")]
	public abstract class LightningBoltPrefabScriptBase : LightningBoltScript
	{
		// Token: 0x06000FE0 RID: 4064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x2DD3E0", Offset = "0x2DD3E0", VA = "0x62DD3E0")]
		protected LightningBoltPrefabScriptBase()
		{
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x2DDAD4", Offset = "0x2DDAD4", VA = "0x62DDAD4")]
		private void CreateInterval(float offset)
		{
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x2DDB2C", Offset = "0x2DDB2C", VA = "0x62DDB2C")]
		private void CallLightning()
		{
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x2DDB68", Offset = "0x2DDB68", VA = "0x62DDB68")]
		private void CallLightning(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x2DDE30", Offset = "0x2DDE30", VA = "0x62DDE30")]
		protected void CreateLightningBoltsNow()
		{
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x2DE038", Offset = "0x2DE038", VA = "0x62DE038", Slot = "9")]
		protected override void PopulateParameters(LightningBoltParameters p)
		{
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x2DE2D4", Offset = "0x2DE2D4", VA = "0x62DE2D4", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x2DE414", Offset = "0x2DE414", VA = "0x62DE414", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x2DD340", Offset = "0x2DD340", VA = "0x62DD340", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x2DE5C4", Offset = "0x2DE5C4", VA = "0x62DE5C4")]
		public void Trigger()
		{
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x2DE600", Offset = "0x2DE600", VA = "0x62DE600")]
		public void Trigger(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0xB4")]
		private readonly List<LightningBoltParameters> batchParameters;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0xB8")]
		private readonly System.Random random;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0xBC")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181E08", Offset = "0x181E08")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x181E08", Offset = "0x181E08")]
		public RangeOfFloats IntervalRange;

		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x181EA8", Offset = "0x181EA8")]
		public RangeOfIntegers CountRange;

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181F28", Offset = "0x181F28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x181F28", Offset = "0x181F28")]
		public float CountProbabilityModifier;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x181F78", Offset = "0x181F78")]
		public RangeOfFloats DelayRange;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x181FD0", Offset = "0x181FD0")]
		public RangeOfFloats DurationRange;

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182068", Offset = "0x182068")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x182068", Offset = "0x182068")]
		public RangeOfFloats TrunkWidthRange;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182138", Offset = "0x182138")]
		[Attribute(Name = "RangeAttribute", RVA = "0x182138", Offset = "0x182138")]
		public float LifeTime;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0xEC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18218C", Offset = "0x18218C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x18218C", Offset = "0x18218C")]
		public int Generations;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1821DC", Offset = "0x1821DC")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1821DC", Offset = "0x1821DC")]
		public float ChaosFactor;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0xF4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18222C", Offset = "0x18222C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x18222C", Offset = "0x18222C")]
		public float Intensity;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182294", Offset = "0x182294")]
		[Attribute(Name = "RangeAttribute", RVA = "0x182294", Offset = "0x182294")]
		public float GlowIntensity;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0xFC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1822FC", Offset = "0x1822FC")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1822FC", Offset = "0x1822FC")]
		public float GlowWidthMultiplier;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182374", Offset = "0x182374")]
		[Attribute(Name = "RangeAttribute", RVA = "0x182374", Offset = "0x182374")]
		public float Forkedness;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x104")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1823C4", Offset = "0x1823C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1823C4", Offset = "0x1823C4")]
		public float ForkLengthMultiplier;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "RangeAttribute", RVA = "0x182438", Offset = "0x182438")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182438", Offset = "0x182438")]
		public float ForkLengthVariance;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x10C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18248C", Offset = "0x18248C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x18248C", Offset = "0x18248C")]
		public float FadePercent;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1824DC", Offset = "0x1824DC")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1824DC", Offset = "0x1824DC")]
		public float GrowthMultiplier;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x114")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18252C", Offset = "0x18252C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x18252C", Offset = "0x18252C")]
		public float EndWidthMultiplier;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182580", Offset = "0x182580")]
		[Attribute(Name = "RangeAttribute", RVA = "0x182580", Offset = "0x182580")]
		public float ForkEndWidthMultiplier;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x11C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x18260C", Offset = "0x18260C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18260C", Offset = "0x18260C")]
		public LightningLightParameters LightParameters;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18268C", Offset = "0x18268C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x18268C", Offset = "0x18268C")]
		public int MaximumLightsPerBatch;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x124")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1826E0", Offset = "0x1826E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1826E0", Offset = "0x1826E0")]
		public bool ManualMode;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x128")]
		private float nextArc;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x12C")]
		private float lifeTimeRemaining;
	}
}
