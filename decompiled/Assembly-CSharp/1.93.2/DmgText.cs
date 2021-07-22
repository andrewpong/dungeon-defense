using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000309 RID: 777
[Token(Token = "0x2000275")]
public class DmgText : MonoBehaviour
{
	// Token: 0x06001163 RID: 4451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x2EF0F0", Offset = "0x2EF0F0", VA = "0x62EF0F0")]
	public DmgText()
	{
	}

	// Token: 0x06001164 RID: 4452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x2EF1A0", Offset = "0x2EF1A0", VA = "0x62EF1A0")]
	public void SetText(Vector2 vPos, string strText, Color _cl, float fDist = 80f)
	{
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x2EF4A0", Offset = "0x2EF4A0", VA = "0x62EF4A0")]
	[DebuggerHidden]
	private IEnumerator UpdateText()
	{
		return null;
	}

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0xC")]
	public TextMesh text;

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x10")]
	public MeshRenderer ms;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x14")]
	private Vector2 vOriPos;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 vDiffPos;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x24")]
	private Coroutine cr;

	// Token: 0x04000F3D RID: 3901
	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x28")]
	private float fFloatY;

	// Token: 0x04000F3E RID: 3902
	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x2C")]
	private float fMoveX;

	// Token: 0x04000F3F RID: 3903
	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0x30")]
	private float fMaxPos;

	// Token: 0x04000F40 RID: 3904
	[Token(Token = "0x4000D97")]
	[FieldOffset(Offset = "0x34")]
	private Color cl;

	// Token: 0x04000F41 RID: 3905
	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0x44")]
	private Color clAlpha;

	// Token: 0x0200030A RID: 778
	[Token(Token = "0x2000349")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE00", Offset = "0x17FE00")]
	private sealed class <UpdateText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x2EF524", Offset = "0x2EF524", VA = "0x62EF524")]
		[DebuggerHidden]
		public <UpdateText>c__Iterator0()
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x2EF52C", Offset = "0x2EF52C", VA = "0x62EF52C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C5")]
		private object Current
		{
			[Token(Token = "0x60015C8")]
			[Address(RVA = "0x2EF8F0", Offset = "0x2EF8F0", VA = "0x62EF8F0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C6")]
		private object Current
		{
			[Token(Token = "0x60015C9")]
			[Address(RVA = "0x2EF8F8", Offset = "0x2EF8F8", VA = "0x62EF8F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x2EF900", Offset = "0x2EF900", VA = "0x62EF900", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x2EF914", Offset = "0x2EF914", VA = "0x62EF914", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x400146B")]
		[FieldOffset(Offset = "0x8")]
		internal float <fTime>__0;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0xC")]
		internal float <fRate>__0;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0x10")]
		internal DmgText $this;

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x14")]
		internal object $current;

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x400146F")]
		[FieldOffset(Offset = "0x18")]
		internal bool $disposing;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4001470")]
		[FieldOffset(Offset = "0x1C")]
		internal int $PC;
	}
}
