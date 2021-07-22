using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x2000025")]
	[Serializable]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1D3198", Offset = "0x1D3198", VA = "0x61D3198")]
		private ObscuredShort(short value)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x3B4E7C", Offset = "0x3B4E7C", VA = "0x63B4E7C")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x3B4F0C", Offset = "0x3B4F0C", VA = "0x63B4F0C")]
		public static short EncryptDecrypt(short value)
		{
			return 0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x3B4F90", Offset = "0x3B4F90", VA = "0x63B4F90")]
		public static short EncryptDecrypt(short value, short key)
		{
			return 0;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1D31A0", Offset = "0x1D31A0", VA = "0x61D31A0")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1D31A8", Offset = "0x1D31A8", VA = "0x61D31A8")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1D31B0", Offset = "0x1D31B0", VA = "0x61D31B0")]
		public short GetEncrypted()
		{
			return 0;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1D31CC", Offset = "0x1D31CC", VA = "0x61D31CC")]
		public void SetEncrypted(short encrypted)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1D31D4", Offset = "0x1D31D4", VA = "0x61D31D4")]
		private short InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3B53B8", Offset = "0x3B53B8", VA = "0x63B53B8")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x3B5478", Offset = "0x3B5478", VA = "0x63B5478")]
		public static implicit operator short(ObscuredShort value)
		{
			return 0;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x3B5494", Offset = "0x3B5494", VA = "0x63B5494")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x3B5558", Offset = "0x3B5558", VA = "0x63B5558")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1D31DC", Offset = "0x1D31DC", VA = "0x61D31DC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1D31E4", Offset = "0x1D31E4", VA = "0x61D31E4", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1D31EC", Offset = "0x1D31EC", VA = "0x61D31EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1D3218", Offset = "0x1D3218", VA = "0x61D3218")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1D324C", Offset = "0x1D324C", VA = "0x61D324C", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1D3278", Offset = "0x1D3278", VA = "0x61D3278")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1D32AC", Offset = "0x1D32AC", VA = "0x61D32AC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x0")]
		private static short cryptoKey;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x0")]
		private short currentCryptoKey;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x2")]
		private short hiddenValue;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x4")]
		private short fakeValue;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x6")]
		private bool inited;
	}
}
