using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026C RID: 620
[Token(Token = "0x20001E2")]
public class loopScript : MonoBehaviour
{
	// Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0xBDE1A8", Offset = "0xBDE1A8", VA = "0x6BDE1A8")]
	public loopScript()
	{
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0xBDE1B8", Offset = "0xBDE1B8", VA = "0x6BDE1B8")]
	private void Start()
	{
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0xBDE1BC", Offset = "0xBDE1BC", VA = "0x6BDE1BC")]
	public void PlayLoopingPEffect()
	{
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0xBDE224", Offset = "0xBDE224", VA = "0x6BDE224")]
	[DebuggerHidden]
	private IEnumerator EffectLoop()
	{
		return null;
	}

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0xC")]
	public GameObject chosenEffect;

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x10")]
	public float loopTimeLimit;

	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200033F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD60", Offset = "0x17FD60")]
	private sealed class <EffectLoop>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06000F08 RID: 3848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001592")]
		[Address(RVA = "0xBDE2A8", Offset = "0xBDE2A8", VA = "0x6BDE2A8")]
		[DebuggerHidden]
		public <EffectLoop>c__Iterator0()
		{
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x6001593")]
		[Address(RVA = "0xBDE2B0", Offset = "0xBDE2B0", VA = "0x6BDE2B0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001B5")]
		private object Current
		{
			[Token(Token = "0x6001594")]
			[Address(RVA = "0xBDE50C", Offset = "0xBDE50C", VA = "0x6BDE50C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001B6")]
		private object Current
		{
			[Token(Token = "0x6001595")]
			[Address(RVA = "0xBDE514", Offset = "0xBDE514", VA = "0x6BDE514", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001596")]
		[Address(RVA = "0xBDE51C", Offset = "0xBDE51C", VA = "0x6BDE51C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001597")]
		[Address(RVA = "0xBDE530", Offset = "0xBDE530", VA = "0x6BDE530", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x4001426")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject <effectPlayer>__0;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x4001427")]
		[FieldOffset(Offset = "0xC")]
		internal loopScript $this;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x4001428")]
		[FieldOffset(Offset = "0x10")]
		internal object $current;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x18")]
		internal int $PC;
	}
}
