using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x200022A")]
	public class ThunderAndLightningScript : MonoBehaviour
	{
		// Token: 0x060010C1 RID: 4289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x2ED38C", Offset = "0x2ED38C", VA = "0x62ED38C")]
		public ThunderAndLightningScript()
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x2ED3DC", Offset = "0x2ED3DC", VA = "0x62ED3DC")]
		private void Start()
		{
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x2ED6DC", Offset = "0x2ED6DC", VA = "0x62ED6DC")]
		private void Update()
		{
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x2ED708", Offset = "0x2ED708", VA = "0x62ED708")]
		public void CallNormalLightning()
		{
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x2ED744", Offset = "0x2ED744", VA = "0x62ED744")]
		public void CallNormalLightning(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x2ED908", Offset = "0x2ED908", VA = "0x62ED908")]
		public void CallIntenseLightning()
		{
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x2ED944", Offset = "0x2ED944", VA = "0x62ED944")]
		public void CallIntenseLightning(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x1700013E")]
		public float SkyboxExposureOriginal
		{
			[Token(Token = "0x6000F4E")]
			[Address(RVA = "0x2ED9D4", Offset = "0x2ED9D4", VA = "0x62ED9D4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00006D50 File Offset: 0x00004F50
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013F")]
		public bool EnableLightning
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x2ED6FC", Offset = "0x2ED6FC", VA = "0x62ED6FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1876AC", Offset = "0x1876AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x2ED648", Offset = "0x2ED648", VA = "0x62ED648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1876BC", Offset = "0x1876BC")]
			set
			{
			}
		}

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184590", Offset = "0x184590")]
		public LightningBoltPrefabScript LightningBoltScript;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1845C4", Offset = "0x1845C4")]
		public Camera Camera;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "SingleLineAttribute", RVA = "0x1845F8", Offset = "0x1845F8")]
		public RangeOfFloats LightningIntervalTimeRange;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184648", Offset = "0x184648")]
		[Attribute(Name = "RangeAttribute", RVA = "0x184648", Offset = "0x184648")]
		public float LightningIntenseProbability;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184698", Offset = "0x184698")]
		public AudioClip[] ThunderSoundsNormal;

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1846CC", Offset = "0x1846CC")]
		public AudioClip[] ThunderSoundsIntense;

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184700", Offset = "0x184700")]
		public bool LightningAlwaysVisible;

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184734", Offset = "0x184734")]
		[Attribute(Name = "RangeAttribute", RVA = "0x184734", Offset = "0x184734")]
		public float CloudLightningChance;

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184784", Offset = "0x184784")]
		public bool ModifySkyboxExposure;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1847F0", Offset = "0x1847F0")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1847F0", Offset = "0x1847F0")]
		public float BaseLightRange;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184844", Offset = "0x184844")]
		[Attribute(Name = "RangeAttribute", RVA = "0x184844", Offset = "0x184844")]
		public float LightningYStart;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x3C")]
		private float skyboxExposureOriginal;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x40")]
		private float skyboxExposureStorm;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x44")]
		private float nextLightningTime;

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x48")]
		private bool lightningInProgress;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x4C")]
		private AudioSource audioSourceThunder;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x50")]
		private ThunderAndLightningScript.LightningBoltHandler lightningBoltHandler;

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x54")]
		private Material skyboxMaterial;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x58")]
		private AudioClip lastThunderSound;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1848BC", Offset = "0x1848BC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1848BC", Offset = "0x1848BC")]
		private bool <EnableLightning>k__BackingField;

		// Token: 0x020002BD RID: 701
		[Token(Token = "0x200022B")]
		private class LightningBoltHandler
		{
			// Token: 0x060010CB RID: 4299 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F51")]
			[Address(RVA = "0x2ED650", Offset = "0x2ED650", VA = "0x62ED650")]
			public LightningBoltHandler(ThunderAndLightningScript script)
			{
			}

			// Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x2EDB78", Offset = "0x2EDB78", VA = "0x62EDB78")]
			private void UpdateLighting()
			{
			}

			// Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0x2ED9DC", Offset = "0x2ED9DC", VA = "0x62ED9DC")]
			private void CalculateNextLightningTime()
			{
			}

			// Token: 0x060010CE RID: 4302 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000F54")]
			[Address(RVA = "0x2ED7D8", Offset = "0x2ED7D8", VA = "0x62ED7D8")]
			[DebuggerHidden]
			public IEnumerator ProcessLightning(Vector3? _start, Vector3? _end, bool intense, bool visible)
			{
				return null;
			}

			// Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x2EDE78", Offset = "0x2EDE78", VA = "0x62EDE78")]
			private void Strike(Vector3? _start, Vector3? _end, bool intense, float intensity, Camera camera, Camera visibleInCamera)
			{
			}

			// Token: 0x060010D0 RID: 4304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x2EDD48", Offset = "0x2EDD48", VA = "0x62EDD48")]
			private void CheckForLightning()
			{
			}

			// Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F57")]
			[Address(RVA = "0x2ED704", Offset = "0x2ED704", VA = "0x62ED704")]
			public void Update()
			{
			}

			// Token: 0x04000994 RID: 2452
			[Token(Token = "0x4000803")]
			[FieldOffset(Offset = "0x8")]
			private ThunderAndLightningScript script;

			// Token: 0x04000995 RID: 2453
			[Token(Token = "0x4000804")]
			[FieldOffset(Offset = "0xC")]
			private readonly System.Random random;

			// Token: 0x020002BE RID: 702
			[Token(Token = "0x2000347")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FDE0", Offset = "0x17FDE0")]
			private sealed class <ProcessLightning>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
			{
				// Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60015BA")]
				[Address(RVA = "0x2EDE70", Offset = "0x2EDE70", VA = "0x62EDE70")]
				[DebuggerHidden]
				public <ProcessLightning>c__Iterator0()
				{
				}

				// Token: 0x060010D3 RID: 4307 RVA: 0x00006D68 File Offset: 0x00004F68
				[Token(Token = "0x60015BB")]
				[Address(RVA = "0x2EE9A0", Offset = "0x2EE9A0", VA = "0x62EE9A0", Slot = "5")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000160 RID: 352
				// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x170001C1")]
				private object Current
				{
					[Token(Token = "0x60015BC")]
					[Address(RVA = "0x2EF044", Offset = "0x2EF044", VA = "0x62EF044", Slot = "8")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x17000161 RID: 353
				// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x170001C2")]
				private object Current
				{
					[Token(Token = "0x60015BD")]
					[Address(RVA = "0x2EF04C", Offset = "0x2EF04C", VA = "0x62EF04C", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60015BE")]
				[Address(RVA = "0x2EF054", Offset = "0x2EF054", VA = "0x62EF054", Slot = "7")]
				[DebuggerHidden]
				public void Dispose()
				{
				}

				// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60015BF")]
				[Address(RVA = "0x2EF068", Offset = "0x2EF068", VA = "0x62EF068", Slot = "6")]
				[DebuggerHidden]
				public void Reset()
				{
				}

				// Token: 0x04000996 RID: 2454
				[Token(Token = "0x4001453")]
				[FieldOffset(Offset = "0x8")]
				internal bool intense;

				// Token: 0x04000997 RID: 2455
				[Token(Token = "0x4001454")]
				[FieldOffset(Offset = "0xC")]
				internal float <intensity>__1;

				// Token: 0x04000998 RID: 2456
				[Token(Token = "0x4001455")]
				[FieldOffset(Offset = "0x10")]
				internal float <sleepTime>__1;

				// Token: 0x04000999 RID: 2457
				[Token(Token = "0x4001456")]
				[FieldOffset(Offset = "0x14")]
				internal AudioClip[] <sounds>__1;

				// Token: 0x0400099A RID: 2458
				[Token(Token = "0x4001457")]
				[FieldOffset(Offset = "0x18")]
				internal Vector3? _start;

				// Token: 0x0400099B RID: 2459
				[Token(Token = "0x4001458")]
				[FieldOffset(Offset = "0x28")]
				internal Vector3? _end;

				// Token: 0x0400099C RID: 2460
				[Token(Token = "0x4001459")]
				[FieldOffset(Offset = "0x38")]
				internal bool visible;

				// Token: 0x0400099D RID: 2461
				[Token(Token = "0x400145A")]
				[FieldOffset(Offset = "0x39")]
				internal bool <playThunder>__0;

				// Token: 0x0400099E RID: 2462
				[Token(Token = "0x400145B")]
				[FieldOffset(Offset = "0x3C")]
				internal AudioClip <clip>__2;

				// Token: 0x0400099F RID: 2463
				[Token(Token = "0x400145C")]
				[FieldOffset(Offset = "0x40")]
				internal ThunderAndLightningScript.LightningBoltHandler $this;

				// Token: 0x040009A0 RID: 2464
				[Token(Token = "0x400145D")]
				[FieldOffset(Offset = "0x44")]
				internal object $current;

				// Token: 0x040009A1 RID: 2465
				[Token(Token = "0x400145E")]
				[FieldOffset(Offset = "0x48")]
				internal bool $disposing;

				// Token: 0x040009A2 RID: 2466
				[Token(Token = "0x400145F")]
				[FieldOffset(Offset = "0x4C")]
				internal int $PC;
			}
		}
	}
}
