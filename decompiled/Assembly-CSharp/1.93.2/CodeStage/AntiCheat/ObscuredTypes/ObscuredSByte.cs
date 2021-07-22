using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x2000024")]
	[Serializable]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1D2FF4", Offset = "0x1D2FF4", VA = "0x61D2FF4")]
		private ObscuredSByte(sbyte value)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x3B43B8", Offset = "0x3B43B8", VA = "0x63B43B8")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x3B4448", Offset = "0x3B4448", VA = "0x63B4448")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return 0;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x3B44CC", Offset = "0x3B44CC", VA = "0x63B44CC")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return 0;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1D2FFC", Offset = "0x1D2FFC", VA = "0x61D2FFC")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1D3004", Offset = "0x1D3004", VA = "0x61D3004")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1D300C", Offset = "0x1D300C", VA = "0x61D300C")]
		public sbyte GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1D3028", Offset = "0x1D3028", VA = "0x61D3028")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1D3030", Offset = "0x1D3030", VA = "0x61D3030")]
		private sbyte InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x3B48E0", Offset = "0x3B48E0", VA = "0x63B48E0")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x3B4990", Offset = "0x3B4990", VA = "0x63B4990")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return 0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x3B49B0", Offset = "0x3B49B0", VA = "0x63B49B0")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3B4A6C", Offset = "0x3B4A6C", VA = "0x63B4A6C")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1D3038", Offset = "0x1D3038", VA = "0x61D3038", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1D3040", Offset = "0x1D3040", VA = "0x61D3040", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1D3048", Offset = "0x1D3048", VA = "0x61D3048", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1D3074", Offset = "0x1D3074", VA = "0x61D3074")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1D30A8", Offset = "0x1D30A8", VA = "0x61D30A8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1D30D4", Offset = "0x1D30D4", VA = "0x61D30D4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1D3108", Offset = "0x1D3108", VA = "0x61D3108", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x0")]
		private static sbyte cryptoKey;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x0")]
		private sbyte currentCryptoKey;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x1")]
		private sbyte hiddenValue;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x2")]
		private sbyte fakeValue;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x3")]
		private bool inited;
	}
}
