using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x2000026")]
	[Serializable]
	public sealed class ObscuredString
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x3B58C8", Offset = "0x3B58C8", VA = "0x63B58C8")]
		private ObscuredString()
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x3B58D0", Offset = "0x3B58D0", VA = "0x63B58D0")]
		private ObscuredString(byte[] value)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x3B5984", Offset = "0x3B5984", VA = "0x63B5984")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x3B5A14", Offset = "0x3B5A14", VA = "0x63B5A14")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3B23C0", Offset = "0x3B23C0", VA = "0x63B23C0")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x3B5ADC", Offset = "0x3B5ADC", VA = "0x63B5ADC")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x3B5F58", Offset = "0x3B5F58", VA = "0x63B5F58")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x3B60A8", Offset = "0x3B60A8", VA = "0x63B60A8")]
		public string GetEncrypted()
		{
			return null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3B61FC", Offset = "0x3B61FC", VA = "0x63B61FC")]
		public void SetEncrypted(string encrypted)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x3B5EC0", Offset = "0x3B5EC0", VA = "0x63B5EC0")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x3B601C", Offset = "0x3B601C", VA = "0x63B601C")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x3B5C14", Offset = "0x3B5C14", VA = "0x63B5C14")]
		private string InternalDecrypt()
		{
			return null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3B638C", Offset = "0x3B638C", VA = "0x63B638C")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3B6468", Offset = "0x3B6468", VA = "0x63B6468")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3B6664", Offset = "0x3B6664", VA = "0x63B6664", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3B6510", Offset = "0x3B6510", VA = "0x63B6510")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x3B6718", Offset = "0x3B6718", VA = "0x63B6718")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3B67A4", Offset = "0x3B67A4", VA = "0x63B67A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x3B682C", Offset = "0x3B682C", VA = "0x63B682C")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x3B69B8", Offset = "0x3B69B8", VA = "0x63B69B8")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x3B6ABC", Offset = "0x3B6ABC", VA = "0x63B6ABC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x3B62A8", Offset = "0x3B62A8", VA = "0x63B62A8")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x3B6134", Offset = "0x3B6134", VA = "0x63B6134")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x3B6668", Offset = "0x3B6668", VA = "0x63B6668")]
		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return default(bool);
		}

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		private static string cryptoKey;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string currentCryptoKey;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private byte[] hiddenValue;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string fakeValue;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;
	}
}
