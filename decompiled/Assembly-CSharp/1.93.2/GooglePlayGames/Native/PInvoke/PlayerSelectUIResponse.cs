using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001FD RID: 509
	[Token(Token = "0x2000178")]
	internal class PlayerSelectUIResponse : BaseReferenceHolder, IEnumerable<string>, IEnumerable
	{
		// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x4816E4", Offset = "0x4816E4", VA = "0x64816E4")]
		internal PlayerSelectUIResponse(IntPtr selfPointer)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x481770", Offset = "0x481770", VA = "0x6481770")]
		internal CommonErrorStatus.UIStatus Status()
		{
			return (CommonErrorStatus.UIStatus)0;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x4817A0", Offset = "0x4817A0", VA = "0x64817A0")]
		private string PlayerIdAtIndex(UIntPtr index)
		{
			return null;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x4818B0", Offset = "0x4818B0", VA = "0x64818B0", Slot = "6")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x4819B0", Offset = "0x4819B0", VA = "0x64819B0", Slot = "7")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x4819B4", Offset = "0x4819B4", VA = "0x64819B4")]
		internal uint MinimumAutomatchingPlayers()
		{
			return 0U;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x4819E4", Offset = "0x4819E4", VA = "0x64819E4")]
		internal uint MaximumAutomatchingPlayers()
		{
			return 0U;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x481A14", Offset = "0x481A14", VA = "0x6481A14", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x481A24", Offset = "0x481A24", VA = "0x6481A24")]
		internal static PlayerSelectUIResponse FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x020001FE RID: 510
		[Token(Token = "0x200033A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD10", Offset = "0x17FD10")]
		private sealed class <PlayerIdAtIndex>c__AnonStorey0
		{
			// Token: 0x06000D6D RID: 3437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001588")]
			[Address(RVA = "0x4818A8", Offset = "0x4818A8", VA = "0x64818A8")]
			public <PlayerIdAtIndex>c__AnonStorey0()
			{
			}

			// Token: 0x06000D6E RID: 3438 RVA: 0x000062D0 File Offset: 0x000044D0
			[Token(Token = "0x6001589")]
			[Address(RVA = "0x481AD4", Offset = "0x481AD4", VA = "0x6481AD4")]
			internal UIntPtr <>m__0(byte[] out_string, UIntPtr size)
			{
				return 0;
			}

			// Token: 0x04000579 RID: 1401
			[Token(Token = "0x400141F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal UIntPtr index;

			// Token: 0x0400057A RID: 1402
			[Token(Token = "0x4001420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal PlayerSelectUIResponse $this;
		}
	}
}
