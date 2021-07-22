using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x2000016")]
	[Serializable]
	public struct ObscuredChar : IEquatable<ObscuredChar>
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1D0514", Offset = "0x1D0514", VA = "0x61D0514")]
		private ObscuredChar(char value)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2A010C", Offset = "0x2A010C", VA = "0x62A010C")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2A019C", Offset = "0x2A019C", VA = "0x62A019C")]
		public static char EncryptDecrypt(char value)
		{
			return '\0';
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2A0220", Offset = "0x2A0220", VA = "0x62A0220")]
		public static char EncryptDecrypt(char value, char key)
		{
			return '\0';
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1D051C", Offset = "0x1D051C", VA = "0x61D051C")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1D0524", Offset = "0x1D0524", VA = "0x61D0524")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1D052C", Offset = "0x1D052C", VA = "0x61D052C")]
		public char GetEncrypted()
		{
			return '\0';
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1D0548", Offset = "0x1D0548", VA = "0x61D0548")]
		public void SetEncrypted(char encrypted)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1D0550", Offset = "0x1D0550", VA = "0x61D0550")]
		private char InternalDecrypt()
		{
			return '\0';
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2A066C", Offset = "0x2A066C", VA = "0x62A066C")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2A0728", Offset = "0x2A0728", VA = "0x62A0728")]
		public static implicit operator char(ObscuredChar value)
		{
			return '\0';
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2A0744", Offset = "0x2A0744", VA = "0x62A0744")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2A0808", Offset = "0x2A0808", VA = "0x62A0808")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1D0558", Offset = "0x1D0558", VA = "0x61D0558", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1D0560", Offset = "0x1D0560", VA = "0x61D0560", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1D0568", Offset = "0x1D0568", VA = "0x61D0568", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1D0594", Offset = "0x1D0594", VA = "0x61D0594")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1D05C8", Offset = "0x1D05C8", VA = "0x61D05C8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x0")]
		private static char cryptoKey;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x0")]
		private char currentCryptoKey;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x2")]
		private char hiddenValue;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x4")]
		private char fakeValue;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x6")]
		private bool inited;
	}
}
