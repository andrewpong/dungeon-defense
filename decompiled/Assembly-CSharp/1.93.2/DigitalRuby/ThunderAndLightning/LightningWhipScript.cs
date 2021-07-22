using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x2000221")]
	[Attribute(Name = "RequireComponent", RVA = "0x17F33C", Offset = "0x17F33C")]
	public class LightningWhipScript : MonoBehaviour
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x2E9C54", Offset = "0x2E9C54", VA = "0x62E9C54")]
		public LightningWhipScript()
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x2E9C64", Offset = "0x2E9C64", VA = "0x62E9C64")]
		[DebuggerHidden]
		private IEnumerator WhipForward()
		{
			return null;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x2E9CF0", Offset = "0x2E9CF0", VA = "0x62E9CF0")]
		private void Start()
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x2E9DC8", Offset = "0x2E9DC8", VA = "0x62E9DC8")]
		private void Update()
		{
		}

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0xC")]
		public AudioClip WhipCrack;

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip WhipCrackThunder;

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x14")]
		private AudioSource audioSource;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x18")]
		private GameObject whipStart;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x1C")]
		private GameObject whipEndStrike;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x20")]
		private GameObject whipHandle;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x24")]
		private GameObject whipSpring;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 prevDrag;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x30")]
		private bool dragging;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x31")]
		private bool canWhip;

		// Token: 0x020002B1 RID: 689
		[Token(Token = "0x2000344")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FDB0", Offset = "0x17FDB0")]
		private sealed class <WhipForward>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06001062 RID: 4194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015A8")]
			[Address(RVA = "0x2E9CE8", Offset = "0x2E9CE8", VA = "0x62E9CE8")]
			[DebuggerHidden]
			public <WhipForward>c__Iterator0()
			{
			}

			// Token: 0x06001063 RID: 4195 RVA: 0x00006BA0 File Offset: 0x00004DA0
			[Token(Token = "0x60015A9")]
			[Address(RVA = "0x2EA178", Offset = "0x2EA178", VA = "0x62EA178", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x06001064 RID: 4196 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001BB")]
			private object Current
			{
				[Token(Token = "0x60015AA")]
				[Address(RVA = "0x2EAAFC", Offset = "0x2EAAFC", VA = "0x62EAAFC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x06001065 RID: 4197 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001BC")]
			private object Current
			{
				[Token(Token = "0x60015AB")]
				[Address(RVA = "0x2EAB04", Offset = "0x2EAB04", VA = "0x62EAB04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015AC")]
			[Address(RVA = "0x2EAB0C", Offset = "0x2EAB0C", VA = "0x62EAB0C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015AD")]
			[Address(RVA = "0x2EAB20", Offset = "0x2EAB20", VA = "0x62EAB20", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000932 RID: 2354
			[Token(Token = "0x4001441")]
			[FieldOffset(Offset = "0x8")]
			internal LightningWhipScript $this;

			// Token: 0x04000933 RID: 2355
			[Token(Token = "0x4001442")]
			[FieldOffset(Offset = "0xC")]
			internal object $current;

			// Token: 0x04000934 RID: 2356
			[Token(Token = "0x4001443")]
			[FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			// Token: 0x04000935 RID: 2357
			[Token(Token = "0x4001444")]
			[FieldOffset(Offset = "0x14")]
			internal int $PC;
		}
	}
}
