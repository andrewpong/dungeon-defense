using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.Utils
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x200002E")]
	internal class xxHash
	{
		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x3BCB08", Offset = "0x3BCB08", VA = "0x63BCB08")]
		public xxHash()
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x3B28F8", Offset = "0x3B28F8", VA = "0x63B28F8")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return 0U;
		}

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000138")]
		private const uint PRIME32_1 = 2654435761U;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000139")]
		private const uint PRIME32_2 = 2246822519U;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x400013A")]
		private const uint PRIME32_3 = 3266489917U;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x400013B")]
		private const uint PRIME32_4 = 668265263U;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x400013C")]
		private const uint PRIME32_5 = 374761393U;
	}
}
