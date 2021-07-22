using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x2000015")]
	[Serializable]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1D0370", Offset = "0x1D0370", VA = "0x61D0370")]
		private ObscuredByte(byte value)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x29F6D8", Offset = "0x29F6D8", VA = "0x629F6D8")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x29F768", Offset = "0x29F768", VA = "0x629F768")]
		public static byte EncryptDecrypt(byte value)
		{
			return 0;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x29F7EC", Offset = "0x29F7EC", VA = "0x629F7EC")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return 0;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1D0378", Offset = "0x1D0378", VA = "0x61D0378")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1D0380", Offset = "0x1D0380", VA = "0x61D0380")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1D0388", Offset = "0x1D0388", VA = "0x61D0388")]
		public byte GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1D03A4", Offset = "0x1D03A4", VA = "0x61D03A4")]
		public void SetEncrypted(byte encrypted)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1D03AC", Offset = "0x1D03AC", VA = "0x61D03AC")]
		private byte InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x293808", Offset = "0x293808", VA = "0x6293808")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x29FC30", Offset = "0x29FC30", VA = "0x629FC30")]
		public static implicit operator byte(ObscuredByte value)
		{
			return 0;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x29FC50", Offset = "0x29FC50", VA = "0x629FC50")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x29FD04", Offset = "0x29FD04", VA = "0x629FD04")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1D03B4", Offset = "0x1D03B4", VA = "0x61D03B4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1D03BC", Offset = "0x1D03BC", VA = "0x61D03BC", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1D03C4", Offset = "0x1D03C4", VA = "0x61D03C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1D03F0", Offset = "0x1D03F0", VA = "0x61D03F0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1D0424", Offset = "0x1D0424", VA = "0x61D0424", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1D0450", Offset = "0x1D0450", VA = "0x61D0450")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1D0484", Offset = "0x1D0484", VA = "0x61D0484", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		private byte currentCryptoKey;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x1")]
		private byte hiddenValue;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x2")]
		private byte fakeValue;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x3")]
		private bool inited;
	}
}
