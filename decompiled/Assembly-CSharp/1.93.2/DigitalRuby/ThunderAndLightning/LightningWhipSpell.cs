using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x2000229")]
	public class LightningWhipSpell : LightningSpellScript
	{
		// Token: 0x060010B3 RID: 4275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x2EABA8", Offset = "0x2EABA8", VA = "0x62EABA8")]
		public LightningWhipSpell()
		{
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x2EABAC", Offset = "0x2EABAC", VA = "0x62EABAC")]
		[DebuggerHidden]
		private IEnumerator WhipForward()
		{
			return null;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x2EAC38", Offset = "0x2EAC38", VA = "0x62EAC38", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x2EAC94", Offset = "0x2EAC94", VA = "0x62EAC94", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x2EADEC", Offset = "0x2EADEC", VA = "0x62EADEC", Slot = "8")]
		protected override void OnCastSpell()
		{
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x2EAE10", Offset = "0x2EAE10", VA = "0x62EAE10", Slot = "9")]
		protected override void OnStopSpell()
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x2EAE14", Offset = "0x2EAE14", VA = "0x62EAE14", Slot = "10")]
		protected override void OnActivated()
		{
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x2EAE44", Offset = "0x2EAE44", VA = "0x62EAE44", Slot = "11")]
		protected override void OnDeactivated()
		{
		}

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1843CC", Offset = "0x1843CC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1843CC", Offset = "0x1843CC")]
		public GameObject AttachTo;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184444", Offset = "0x184444")]
		public GameObject RotateWith;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184494", Offset = "0x184494")]
		public GameObject WhipHandle;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1844CC", Offset = "0x1844CC")]
		public GameObject WhipStart;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184504", Offset = "0x184504")]
		public GameObject WhipSpring;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18453C", Offset = "0x18453C")]
		public AudioSource WhipCrackAudioSource;

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HideInInspector", RVA = "0x184580", Offset = "0x184580")]
		public Action<Vector3> CollisionCallback;

		// Token: 0x020002BB RID: 699
		[Token(Token = "0x2000346")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FDD0", Offset = "0x17FDD0")]
		private sealed class <WhipForward>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015B4")]
			[Address(RVA = "0x2EAC30", Offset = "0x2EAC30", VA = "0x62EAC30")]
			[DebuggerHidden]
			public <WhipForward>c__Iterator0()
			{
			}

			// Token: 0x060010BC RID: 4284 RVA: 0x00006D20 File Offset: 0x00004F20
			[Token(Token = "0x60015B5")]
			[Address(RVA = "0x2EAE74", Offset = "0x2EAE74", VA = "0x62EAE74", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x060010BD RID: 4285 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001BF")]
			private object Current
			{
				[Token(Token = "0x60015B6")]
				[Address(RVA = "0x2EBBE4", Offset = "0x2EBBE4", VA = "0x62EBBE4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060010BE RID: 4286 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001C0")]
			private object Current
			{
				[Token(Token = "0x60015B7")]
				[Address(RVA = "0x2EBBEC", Offset = "0x2EBBEC", VA = "0x62EBBEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060010BF RID: 4287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015B8")]
			[Address(RVA = "0x2EBBF4", Offset = "0x2EBBF4", VA = "0x62EBBF4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x060010C0 RID: 4288 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015B9")]
			[Address(RVA = "0x2EBC08", Offset = "0x2EBC08", VA = "0x62EBC08", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000978 RID: 2424
			[Token(Token = "0x400144B")]
			[FieldOffset(Offset = "0x8")]
			internal Vector3 <anchor>__0;

			// Token: 0x04000979 RID: 2425
			[Token(Token = "0x400144C")]
			[FieldOffset(Offset = "0x14")]
			internal RaycastHit <hit>__0;

			// Token: 0x0400097A RID: 2426
			[Token(Token = "0x400144D")]
			[FieldOffset(Offset = "0x40")]
			internal Vector3 <whipPositionForwards>__1;

			// Token: 0x0400097B RID: 2427
			[Token(Token = "0x400144E")]
			[FieldOffset(Offset = "0x4C")]
			internal Vector3 <whipPositionBackwards>__1;

			// Token: 0x0400097C RID: 2428
			[Token(Token = "0x400144F")]
			[FieldOffset(Offset = "0x58")]
			internal LightningWhipSpell $this;

			// Token: 0x0400097D RID: 2429
			[Token(Token = "0x4001450")]
			[FieldOffset(Offset = "0x5C")]
			internal object $current;

			// Token: 0x0400097E RID: 2430
			[Token(Token = "0x4001451")]
			[FieldOffset(Offset = "0x60")]
			internal bool $disposing;

			// Token: 0x0400097F RID: 2431
			[Token(Token = "0x4001452")]
			[FieldOffset(Offset = "0x64")]
			internal int $PC;
		}
	}
}
