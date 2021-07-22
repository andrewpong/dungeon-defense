using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x2000027")]
	[Serializable]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1D333C", Offset = "0x1D333C", VA = "0x61D333C")]
		private ObscuredUInt(uint value)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3B6C10", Offset = "0x3B6C10", VA = "0x63B6C10")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x3B6CA0", Offset = "0x3B6CA0", VA = "0x63B6CA0")]
		public static uint Encrypt(uint value)
		{
			return 0U;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x3B6DC4", Offset = "0x3B6DC4", VA = "0x63B6DC4")]
		public static uint Decrypt(uint value)
		{
			return 0U;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x3B6D24", Offset = "0x3B6D24", VA = "0x63B6D24")]
		public static uint Encrypt(uint value, uint key)
		{
			return 0U;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x3B6E48", Offset = "0x3B6E48", VA = "0x63B6E48")]
		public static uint Decrypt(uint value, uint key)
		{
			return 0U;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1D3344", Offset = "0x1D3344", VA = "0x61D3344")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1D334C", Offset = "0x1D334C", VA = "0x61D334C")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1D3354", Offset = "0x1D3354", VA = "0x61D3354")]
		public uint GetEncrypted()
		{
			return 0U;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1D3370", Offset = "0x1D3370", VA = "0x61D3370")]
		public void SetEncrypted(uint encrypted)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1D3378", Offset = "0x1D3378", VA = "0x61D3378")]
		private uint InternalDecrypt()
		{
			return 0U;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3B7250", Offset = "0x3B7250", VA = "0x63B7250")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x3B7310", Offset = "0x3B7310", VA = "0x63B7310")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return 0U;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x3B732C", Offset = "0x3B732C", VA = "0x63B732C")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x3B73D8", Offset = "0x3B73D8", VA = "0x63B73D8")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x3B74A8", Offset = "0x3B74A8", VA = "0x63B74A8")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1D3380", Offset = "0x1D3380", VA = "0x61D3380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1D3388", Offset = "0x1D3388", VA = "0x61D3388", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1D33AC", Offset = "0x1D33AC", VA = "0x61D33AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1D33D8", Offset = "0x1D33D8", VA = "0x61D33D8")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1D340C", Offset = "0x1D340C", VA = "0x61D340C", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1D3438", Offset = "0x1D3438", VA = "0x61D3438")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1D346C", Offset = "0x1D346C", VA = "0x61D346C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x0")]
		private static uint cryptoKey;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x0")]
		private uint currentCryptoKey;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x4")]
		private uint hiddenValue;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x8")]
		private uint fakeValue;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xC")]
		private bool inited;
	}
}
