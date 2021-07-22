using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x2000160")]
	internal class NativeScore : BaseReferenceHolder
	{
		// Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x478D54", Offset = "0x478D54", VA = "0x6478D54")]
		internal NativeScore(IntPtr selfPtr)
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x478DE0", Offset = "0x478DE0", VA = "0x6478DE0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x478E10", Offset = "0x478E10", VA = "0x6478E10")]
		internal ulong GetDate()
		{
			return 0UL;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x478E1C", Offset = "0x478E1C", VA = "0x6478E1C")]
		internal string GetMetadata()
		{
			return null;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x478ED4", Offset = "0x478ED4", VA = "0x6478ED4")]
		internal ulong GetRank()
		{
			return 0UL;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x478F04", Offset = "0x478F04", VA = "0x6478F04")]
		internal ulong GetValue()
		{
			return 0UL;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x478F34", Offset = "0x478F34", VA = "0x6478F34")]
		internal PlayGamesScore AsScore(string leaderboardId, string selfPlayerId)
		{
			return null;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x4790C8", Offset = "0x4790C8", VA = "0x64790C8")]
		internal static NativeScore FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x47917C", Offset = "0x47917C", VA = "0x647917C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1861FC", Offset = "0x1861FC")]
		private UIntPtr <GetMetadata>m__0(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000406")]
		private const ulong MinusOne = 18446744073709551615UL;
	}
}
