using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x2000028")]
	[Serializable]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1D351C", Offset = "0x1D351C", VA = "0x61D351C")]
		private ObscuredULong(ulong value)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x3B78EC", Offset = "0x3B78EC", VA = "0x63B78EC")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x3B7980", Offset = "0x3B7980", VA = "0x63B7980")]
		public static ulong Encrypt(ulong value)
		{
			return 0UL;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x3B7AC4", Offset = "0x3B7AC4", VA = "0x63B7AC4")]
		public static ulong Decrypt(ulong value)
		{
			return 0UL;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x3B7A18", Offset = "0x3B7A18", VA = "0x63B7A18")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return 0UL;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x3B7B5C", Offset = "0x3B7B5C", VA = "0x63B7B5C")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return 0UL;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1D3538", Offset = "0x1D3538", VA = "0x61D3538")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1D3540", Offset = "0x1D3540", VA = "0x61D3540")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1D3548", Offset = "0x1D3548", VA = "0x61D3548")]
		public ulong GetEncrypted()
		{
			return 0UL;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1D3564", Offset = "0x1D3564", VA = "0x61D3564")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1D3580", Offset = "0x1D3580", VA = "0x61D3580")]
		private ulong InternalDecrypt()
		{
			return 0UL;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x3B7FE4", Offset = "0x3B7FE4", VA = "0x63B7FE4")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x3B80C0", Offset = "0x3B80C0", VA = "0x63B80C0")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return 0UL;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x3B80FC", Offset = "0x3B80FC", VA = "0x63B80FC")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x3B8214", Offset = "0x3B8214", VA = "0x63B8214")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1D3588", Offset = "0x1D3588", VA = "0x61D3588", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1D3590", Offset = "0x1D3590", VA = "0x61D3590", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1D35D8", Offset = "0x1D35D8", VA = "0x61D35D8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1D3604", Offset = "0x1D3604", VA = "0x61D3604", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1D3630", Offset = "0x1D3630", VA = "0x61D3630")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1D3664", Offset = "0x1D3664", VA = "0x61D3664")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1D3698", Offset = "0x1D3698", VA = "0x61D3698", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x0")]
		private static ulong cryptoKey;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x0")]
		private ulong currentCryptoKey;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x8")]
		private ulong hiddenValue;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x10")]
		private ulong fakeValue;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x18")]
		private bool inited;
	}
}
