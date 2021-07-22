using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000337 RID: 823
[Token(Token = "0x2000283")]
public class PageStart : UIMgr
{
	// Token: 0x0600146A RID: 5226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x3636E8", Offset = "0x3636E8", VA = "0x63636E8")]
	public PageStart()
	{
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x36376C", Offset = "0x36376C", VA = "0x636376C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x3637DC", Offset = "0x3637DC", VA = "0x63637DC", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x363D0C", Offset = "0x363D0C", VA = "0x6363D0C", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x363C88", Offset = "0x363C88", VA = "0x6363C88")]
	[DebuggerHidden]
	private IEnumerator RepeatFade()
	{
		return null;
	}

	// Token: 0x0400129E RID: 4766
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x0")]
	public static PageStart obj;

	// Token: 0x0400129F RID: 4767
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x20")]
	public Text textStart;

	// Token: 0x040012A0 RID: 4768
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x24")]
	public bool bLoaded;

	// Token: 0x040012A1 RID: 4769
	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x25")]
	private bool bFadeIn;

	// Token: 0x02000338 RID: 824
	[Token(Token = "0x200036F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180010", Offset = "0x180010")]
	private sealed class <RepeatFade>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x363DB8", Offset = "0x363DB8", VA = "0x6363DB8")]
		[DebuggerHidden]
		public <RepeatFade>c__Iterator0()
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x363DC0", Offset = "0x363DC0", VA = "0x6363DC0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FF")]
		private object Current
		{
			[Token(Token = "0x600167C")]
			[Address(RVA = "0x363F28", Offset = "0x363F28", VA = "0x6363F28", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000200")]
		private object Current
		{
			[Token(Token = "0x600167D")]
			[Address(RVA = "0x363F30", Offset = "0x363F30", VA = "0x6363F30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x363F38", Offset = "0x363F38", VA = "0x6363F38", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x363F4C", Offset = "0x363F4C", VA = "0x6363F4C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x4001599")]
		[FieldOffset(Offset = "0x8")]
		internal PageStart $this;

		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x400159A")]
		[FieldOffset(Offset = "0xC")]
		internal object $current;

		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x400159B")]
		[FieldOffset(Offset = "0x10")]
		internal bool $disposing;

		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x400159C")]
		[FieldOffset(Offset = "0x14")]
		internal int $PC;
	}
}
