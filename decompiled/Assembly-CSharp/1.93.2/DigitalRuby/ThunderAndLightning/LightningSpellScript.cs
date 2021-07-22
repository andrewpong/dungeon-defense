using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x2000228")]
	public abstract class LightningSpellScript : MonoBehaviour
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x2E5BE0", Offset = "0x2E5BE0", VA = "0x62E5BE0")]
		protected LightningSpellScript()
		{
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x2E6F9C", Offset = "0x2E6F9C", VA = "0x62E6F9C")]
		[DebuggerHidden]
		private IEnumerator StopAfterSecondsCoRoutine(float seconds)
		{
			return null;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x00006C90 File Offset: 0x00004E90
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013A")]
		private protected float DurationTimer
		{
			[Token(Token = "0x6000F28")]
			[Address(RVA = "0x2E7050", Offset = "0x2E7050", VA = "0x62E7050")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18763C", Offset = "0x18763C")]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x6000F29")]
			[Address(RVA = "0x2E7058", Offset = "0x2E7058", VA = "0x62E7058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18764C", Offset = "0x18764C")]
			private set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00006CA8 File Offset: 0x00004EA8
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		private protected float CooldownTimer
		{
			[Token(Token = "0x6000F2A")]
			[Address(RVA = "0x2E7060", Offset = "0x2E7060", VA = "0x62E7060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18765C", Offset = "0x18765C")]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x6000F2B")]
			[Address(RVA = "0x2E7068", Offset = "0x2E7068", VA = "0x62E7068")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18766C", Offset = "0x18766C")]
			private set
			{
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x2E6D04", Offset = "0x2E6D04", VA = "0x62E6D04")]
		protected void ApplyCollisionForce(Vector3 point)
		{
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x2E6B68", Offset = "0x2E6B68", VA = "0x62E6B68")]
		protected void PlayCollisionSound(Vector3 pos)
		{
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x2E667C", Offset = "0x2E667C", VA = "0x62E667C", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x2E6770", Offset = "0x2E6770", VA = "0x62E6770", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x2E7070", Offset = "0x2E7070", VA = "0x62E7070", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x2E6674", Offset = "0x2E6674", VA = "0x62E6674", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060010A0 RID: 4256
		[Token(Token = "0x6000F32")]
		protected abstract void OnCastSpell();

		// Token: 0x060010A1 RID: 4257
		[Token(Token = "0x6000F33")]
		protected abstract void OnStopSpell();

		// Token: 0x060010A2 RID: 4258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x2E7074", Offset = "0x2E7074", VA = "0x62E7074", Slot = "10")]
		protected virtual void OnActivated()
		{
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x2E7078", Offset = "0x2E7078", VA = "0x62E7078", Slot = "11")]
		protected virtual void OnDeactivated()
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x2E707C", Offset = "0x2E707C", VA = "0x62E707C")]
		public bool CastSpell()
		{
			return default(bool);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x2E7370", Offset = "0x2E7370", VA = "0x62E7370")]
		public void StopSpell()
		{
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x2E7560", Offset = "0x2E7560", VA = "0x62E7560")]
		public void ActivateSpell()
		{
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x2E7570", Offset = "0x2E7570", VA = "0x62E7570")]
		public void DeactivateSpell()
		{
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x2E734C", Offset = "0x2E734C", VA = "0x62E734C")]
		public void StopAfterSeconds(float seconds)
		{
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x2E7580", Offset = "0x2E7580", VA = "0x62E7580")]
		public static GameObject FindChildRecursively(Transform t, string name)
		{
			return null;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00006CD8 File Offset: 0x00004ED8
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013C")]
		public bool Casting
		{
			[Token(Token = "0x6000F3C")]
			[Address(RVA = "0x2E7558", Offset = "0x2E7558", VA = "0x62E7558")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18767C", Offset = "0x18767C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x2E7344", Offset = "0x2E7344", VA = "0x62E7344")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18768C", Offset = "0x18768C")]
			private set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x1700013D")]
		public bool CanCastSpell
		{
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x2E7318", Offset = "0x2E7318", VA = "0x62E7318")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183D74", Offset = "0x183D74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183D74", Offset = "0x183D74")]
		public GameObject SpellStart;

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183E1C", Offset = "0x183E1C")]
		public GameObject SpellEnd;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "HideInInspector", RVA = "0x183E50", Offset = "0x183E50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183E50", Offset = "0x183E50")]
		public Vector3 Direction;

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183E98", Offset = "0x183E98")]
		public float MaxDistance;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183EE8", Offset = "0x183EE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183EE8", Offset = "0x183EE8")]
		public bool CollisionIsExplosion;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183F4C", Offset = "0x183F4C")]
		public float CollisionRadius;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183FA0", Offset = "0x183FA0")]
		public float CollisionForce;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184000", Offset = "0x184000")]
		public ForceMode CollisionForceMode;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184044", Offset = "0x184044")]
		public ParticleSystem CollisionParticleSystem;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184078", Offset = "0x184078")]
		public LayerMask CollisionMask;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1840D4", Offset = "0x1840D4")]
		public AudioSource CollisionAudioSource;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184118", Offset = "0x184118")]
		public AudioClip[] CollisionAudioClips;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18414C", Offset = "0x18414C")]
		public RangeOfFloats CollisionVolumeRange;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x184198", Offset = "0x184198")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184198", Offset = "0x184198")]
		public float Duration;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184208", Offset = "0x184208")]
		public float Cooldown;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x18423C", Offset = "0x18423C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18423C", Offset = "0x18423C")]
		public AudioSource EmissionSound;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1842A8", Offset = "0x1842A8")]
		public ParticleSystem EmissionParticleSystem;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1842DC", Offset = "0x1842DC")]
		public Light EmissionLight;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x60")]
		private int stopToken;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184330", Offset = "0x184330")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x184330", Offset = "0x184330")]
		private float <DurationTimer>k__BackingField;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184364", Offset = "0x184364")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x184364", Offset = "0x184364")]
		private float <CooldownTimer>k__BackingField;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184398", Offset = "0x184398")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x184398", Offset = "0x184398")]
		private bool <Casting>k__BackingField;

		// Token: 0x020002B9 RID: 697
		[Token(Token = "0x2000345")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FDC0", Offset = "0x17FDC0")]
		private sealed class <StopAfterSecondsCoRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x060010AD RID: 4269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015AE")]
			[Address(RVA = "0x2E7048", Offset = "0x2E7048", VA = "0x62E7048")]
			[DebuggerHidden]
			public <StopAfterSecondsCoRoutine>c__Iterator0()
			{
			}

			// Token: 0x060010AE RID: 4270 RVA: 0x00006D08 File Offset: 0x00004F08
			[Token(Token = "0x60015AF")]
			[Address(RVA = "0x2E76F8", Offset = "0x2E76F8", VA = "0x62E76F8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060010AF RID: 4271 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001BD")]
			private object Current
			{
				[Token(Token = "0x60015B0")]
				[Address(RVA = "0x2E7824", Offset = "0x2E7824", VA = "0x62E7824", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001BE")]
			private object Current
			{
				[Token(Token = "0x60015B1")]
				[Address(RVA = "0x2E782C", Offset = "0x2E782C", VA = "0x62E782C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060010B1 RID: 4273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015B2")]
			[Address(RVA = "0x2E7834", Offset = "0x2E7834", VA = "0x62E7834", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x060010B2 RID: 4274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x2E7848", Offset = "0x2E7848", VA = "0x62E7848", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400096B RID: 2411
			[Token(Token = "0x4001445")]
			[FieldOffset(Offset = "0x8")]
			internal int <token>__0;

			// Token: 0x0400096C RID: 2412
			[Token(Token = "0x4001446")]
			[FieldOffset(Offset = "0xC")]
			internal float seconds;

			// Token: 0x0400096D RID: 2413
			[Token(Token = "0x4001447")]
			[FieldOffset(Offset = "0x10")]
			internal LightningSpellScript $this;

			// Token: 0x0400096E RID: 2414
			[Token(Token = "0x4001448")]
			[FieldOffset(Offset = "0x14")]
			internal object $current;

			// Token: 0x0400096F RID: 2415
			[Token(Token = "0x4001449")]
			[FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			// Token: 0x04000970 RID: 2416
			[Token(Token = "0x400144A")]
			[FieldOffset(Offset = "0x1C")]
			internal int $PC;
		}
	}
}
