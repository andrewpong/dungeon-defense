using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C5 RID: 709
[Token(Token = "0x2000232")]
public class BattleCoinElt : MonoBehaviour
{
	// Token: 0x060010F7 RID: 4343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x28DC30", Offset = "0x28DC30", VA = "0x628DC30")]
	public BattleCoinElt()
	{
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00006DB0 File Offset: 0x00004FB0
	[Token(Token = "0x17000142")]
	public float fEarnGold
	{
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x28DC38", Offset = "0x28DC38", VA = "0x628DC38")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00006DC8 File Offset: 0x00004FC8
	[Token(Token = "0x17000143")]
	public bool isGold
	{
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x28DC40", Offset = "0x28DC40", VA = "0x628DC40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x060010FA RID: 4346 RVA: 0x00006DE0 File Offset: 0x00004FE0
	[Token(Token = "0x17000144")]
	public bool isItem
	{
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x28DC54", Offset = "0x28DC54", VA = "0x628DC54")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x060010FB RID: 4347 RVA: 0x00006DF8 File Offset: 0x00004FF8
	[Token(Token = "0x17000145")]
	public bool isHP
	{
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x28DC64", Offset = "0x28DC64", VA = "0x628DC64")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x28DC78", Offset = "0x28DC78", VA = "0x628DC78")]
	public void SetGold(BattleCoinElt.Type _eType, float _fGold, Vector3 vOri, float x, float y)
	{
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x28DD68", Offset = "0x28DD68", VA = "0x628DD68")]
	[DebuggerHidden]
	private IEnumerator MoveGold(Vector3 vOri, float fMoveX, float fMoveY)
	{
		return null;
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x28DE40", Offset = "0x28DE40", VA = "0x628DE40")]
	public void Reach()
	{
	}

	// Token: 0x040009CB RID: 2507
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goCoin;

	// Token: 0x040009CC RID: 2508
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goItem;

	// Token: 0x040009CD RID: 2509
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goHP;

	// Token: 0x040009CE RID: 2510
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x18")]
	private float fGold;

	// Token: 0x040009CF RID: 2511
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184920", Offset = "0x184920")]
	public BattleCoinElt.Type eType;

	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x2000233")]
	public enum Type
	{
		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x4000833")]
		eGold,
		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x4000834")]
		eItem,
		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x4000835")]
		eHP
	}

	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x2000348")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FDF0", Offset = "0x17FDF0")]
	private sealed class <MoveGold>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x28DE38", Offset = "0x28DE38", VA = "0x628DE38")]
		[DebuggerHidden]
		public <MoveGold>c__Iterator0()
		{
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x28DEF0", Offset = "0x28DEF0", VA = "0x628DEF0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C3")]
		private object Current
		{
			[Token(Token = "0x60015C2")]
			[Address(RVA = "0x28E798", Offset = "0x28E798", VA = "0x628E798", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C4")]
		private object Current
		{
			[Token(Token = "0x60015C3")]
			[Address(RVA = "0x28E7A0", Offset = "0x28E7A0", VA = "0x628E7A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x28E7A8", Offset = "0x28E7A8", VA = "0x628E7A8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x28E7BC", Offset = "0x28E7BC", VA = "0x628E7BC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 <vDiff>__0;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x14")]
		internal float <fTime>__0;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x18")]
		internal float <fRate>__0;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0x1C")]
		internal Vector3 vOri;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x4001464")]
		[FieldOffset(Offset = "0x28")]
		internal float fMoveY;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x4001465")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 <vTgt>__0;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x4001466")]
		[FieldOffset(Offset = "0x38")]
		internal float <fMax>__0;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x4001467")]
		[FieldOffset(Offset = "0x3C")]
		internal BattleCoinElt $this;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x4001468")]
		[FieldOffset(Offset = "0x40")]
		internal object $current;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x4001469")]
		[FieldOffset(Offset = "0x44")]
		internal bool $disposing;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x400146A")]
		[FieldOffset(Offset = "0x48")]
		internal int $PC;
	}
}
