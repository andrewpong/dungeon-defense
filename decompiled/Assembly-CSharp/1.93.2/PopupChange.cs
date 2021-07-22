using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000342 RID: 834
[Token(Token = "0x200028D")]
public class PopupChange : UIPage
{
	// Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x375284", Offset = "0x375284", VA = "0x6375284")]
	public PopupChange()
	{
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600128C")]
	[Address(RVA = "0x37528C", Offset = "0x37528C", VA = "0x637528C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014CD RID: 5325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600128D")]
	[Address(RVA = "0x375338", Offset = "0x375338", VA = "0x6375338")]
	public void SetFlash(string strLevel, Color color, float fFadeIn, float fFadeOut)
	{
	}

	// Token: 0x060014CE RID: 5326 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600128E")]
	[Address(RVA = "0x375384", Offset = "0x375384", VA = "0x6375384")]
	[DebuggerHidden]
	private IEnumerator UpdateScreen(string strLevel, Color color, float fFadeIn, float fFadeOut)
	{
		return null;
	}

	// Token: 0x04001315 RID: 4885
	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x0")]
	public static PopupChange obj;

	// Token: 0x04001316 RID: 4886
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x1C")]
	public Image imgScreenFX;

	// Token: 0x02000343 RID: 835
	[Token(Token = "0x2000370")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180020", Offset = "0x180020")]
	private sealed class <UpdateScreen>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x375490", Offset = "0x375490", VA = "0x6375490")]
		[DebuggerHidden]
		public <UpdateScreen>c__Iterator0()
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x375498", Offset = "0x375498", VA = "0x6375498", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000201")]
		private object Current
		{
			[Token(Token = "0x6001682")]
			[Address(RVA = "0x37593C", Offset = "0x37593C", VA = "0x637593C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000202")]
		private object Current
		{
			[Token(Token = "0x6001683")]
			[Address(RVA = "0x375944", Offset = "0x375944", VA = "0x6375944", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x37594C", Offset = "0x37594C", VA = "0x637594C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x375960", Offset = "0x375960", VA = "0x6375960", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001317 RID: 4887
		[Token(Token = "0x400159D")]
		[FieldOffset(Offset = "0x8")]
		internal float <fTime>__0;

		// Token: 0x04001318 RID: 4888
		[Token(Token = "0x400159E")]
		[FieldOffset(Offset = "0xC")]
		internal float <fRate>__0;

		// Token: 0x04001319 RID: 4889
		[Token(Token = "0x400159F")]
		[FieldOffset(Offset = "0x10")]
		internal Color color;

		// Token: 0x0400131A RID: 4890
		[Token(Token = "0x40015A0")]
		[FieldOffset(Offset = "0x20")]
		internal Color <clCurrent>__0;

		// Token: 0x0400131B RID: 4891
		[Token(Token = "0x40015A1")]
		[FieldOffset(Offset = "0x30")]
		internal float fFadeIn;

		// Token: 0x0400131C RID: 4892
		[Token(Token = "0x40015A2")]
		[FieldOffset(Offset = "0x34")]
		internal string strLevel;

		// Token: 0x0400131D RID: 4893
		[Token(Token = "0x40015A3")]
		[FieldOffset(Offset = "0x38")]
		internal float fFadeOut;

		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x40015A4")]
		[FieldOffset(Offset = "0x3C")]
		internal PopupChange $this;

		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x40015A5")]
		[FieldOffset(Offset = "0x40")]
		internal object $current;

		// Token: 0x04001320 RID: 4896
		[Token(Token = "0x40015A6")]
		[FieldOffset(Offset = "0x44")]
		internal bool $disposing;

		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x40015A7")]
		[FieldOffset(Offset = "0x48")]
		internal int $PC;
	}
}
