using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200034A RID: 842
[Token(Token = "0x2000293")]
public class PopupGameOver : UIPage
{
	// Token: 0x060014FC RID: 5372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x37EFC0", Offset = "0x37EFC0", VA = "0x637EFC0")]
	public PopupGameOver()
	{
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x37EFC8", Offset = "0x37EFC8", VA = "0x637EFC8", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x37F1A8", Offset = "0x37F1A8", VA = "0x637F1A8", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x37F25C", Offset = "0x37F25C", VA = "0x637F25C", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x37F1D8", Offset = "0x37F1D8", VA = "0x637F1D8")]
	[DebuggerHidden]
	private IEnumerator ShowButton()
	{
		return null;
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x37F3CC", Offset = "0x37F3CC", VA = "0x637F3CC")]
	public void OnLoad()
	{
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x37FEE0", Offset = "0x37FEE0", VA = "0x637FEE0")]
	public void OnLower()
	{
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x380158", Offset = "0x380158", VA = "0x6380158")]
	public void OnLowRestart()
	{
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x3803C8", Offset = "0x3803C8", VA = "0x63803C8")]
	public void OnMain()
	{
	}

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x0")]
	public static PopupGameOver obj;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x1C")]
	public Image imgBack;

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x20")]
	public Text textTitle;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x24")]
	public Text textLoad;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x28")]
	public Text textMain;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x2C")]
	public Text textLower;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goLoad;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x34")]
	public GameObject goLower;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject goMain;

	// Token: 0x0200034B RID: 843
	[Token(Token = "0x2000372")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180040", Offset = "0x180040")]
	private sealed class <ShowButton>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001505 RID: 5381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x37F3C4", Offset = "0x37F3C4", VA = "0x637F3C4")]
		[DebuggerHidden]
		public <ShowButton>c__Iterator0()
		{
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x380480", Offset = "0x380480", VA = "0x6380480", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000203")]
		private object Current
		{
			[Token(Token = "0x600168A")]
			[Address(RVA = "0x380AD0", Offset = "0x380AD0", VA = "0x6380AD0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000204")]
		private object Current
		{
			[Token(Token = "0x600168B")]
			[Address(RVA = "0x380AD8", Offset = "0x380AD8", VA = "0x6380AD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x380AE0", Offset = "0x380AE0", VA = "0x6380AE0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x380AF4", Offset = "0x380AF4", VA = "0x6380AF4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x40015A9")]
		[FieldOffset(Offset = "0x8")]
		internal Color <cl>__0;

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x40015AA")]
		[FieldOffset(Offset = "0x18")]
		internal PopupGameOver $this;

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x40015AB")]
		[FieldOffset(Offset = "0x1C")]
		internal object $current;

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x40015AC")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x40015AD")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}
}
