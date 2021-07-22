using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x200018E")]
	internal class TurnBasedMatchConfig : BaseReferenceHolder
	{
		// Token: 0x06000E2A RID: 3626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x48B6DC", Offset = "0x48B6DC", VA = "0x648B6DC")]
		internal TurnBasedMatchConfig(IntPtr selfPointer)
		{
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x48B768", Offset = "0x48B768", VA = "0x648B768")]
		private string PlayerIdAtIndex(UIntPtr index)
		{
			return null;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x48B878", Offset = "0x48B878", VA = "0x648B878")]
		internal IEnumerator<string> PlayerIdsToInvite()
		{
			return null;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x48B978", Offset = "0x48B978", VA = "0x648B978")]
		internal uint Variant()
		{
			return 0U;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x48B9A8", Offset = "0x48B9A8", VA = "0x648B9A8")]
		internal long ExclusiveBitMask()
		{
			return 0L;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x48B9D8", Offset = "0x48B9D8", VA = "0x648B9D8")]
		internal uint MinimumAutomatchingPlayers()
		{
			return 0U;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x48BA08", Offset = "0x48BA08", VA = "0x648BA08")]
		internal uint MaximumAutomatchingPlayers()
		{
			return 0U;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x48BA38", Offset = "0x48BA38", VA = "0x648BA38", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x02000216 RID: 534
		[Token(Token = "0x200033C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD30", Offset = "0x17FD30")]
		private sealed class <PlayerIdAtIndex>c__AnonStorey0
		{
			// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600158C")]
			[Address(RVA = "0x48B870", Offset = "0x48B870", VA = "0x648B870")]
			public <PlayerIdAtIndex>c__AnonStorey0()
			{
			}

			// Token: 0x06000E33 RID: 3635 RVA: 0x00006630 File Offset: 0x00004830
			[Token(Token = "0x600158D")]
			[Address(RVA = "0x48BA48", Offset = "0x48BA48", VA = "0x648BA48")]
			internal UIntPtr <>m__0(byte[] out_string, UIntPtr size)
			{
				return 0;
			}

			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x4001422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal UIntPtr index;

			// Token: 0x040005B6 RID: 1462
			[Token(Token = "0x4001423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal TurnBasedMatchConfig $this;
		}
	}
}
