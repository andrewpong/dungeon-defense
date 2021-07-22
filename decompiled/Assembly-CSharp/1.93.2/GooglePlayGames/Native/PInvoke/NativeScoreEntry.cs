using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x2000161")]
	internal class NativeScoreEntry : BaseReferenceHolder
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x4791C4", Offset = "0x4791C4", VA = "0x64791C4")]
		internal NativeScoreEntry(IntPtr selfPtr)
		{
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x479250", Offset = "0x479250", VA = "0x6479250", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x479260", Offset = "0x479260", VA = "0x6479260")]
		internal ulong GetLastModifiedTime()
		{
			return 0UL;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x479290", Offset = "0x479290", VA = "0x6479290")]
		internal string GetPlayerId()
		{
			return null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x479348", Offset = "0x479348", VA = "0x6479348")]
		internal NativeScore GetScore()
		{
			return null;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x4793E0", Offset = "0x4793E0", VA = "0x64793E0")]
		internal PlayGamesScore AsScore(string leaderboardId)
		{
			return null;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x47960C", Offset = "0x47960C", VA = "0x647960C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18620C", Offset = "0x18620C")]
		private UIntPtr <GetPlayerId>m__0(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x4000407")]
		private const ulong MinusOne = 18446744073709551615UL;
	}
}
