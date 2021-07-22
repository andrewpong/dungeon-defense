using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000019")]
	[Serializable]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1D0BE0", Offset = "0x1D0BE0", VA = "0x61D0BE0")]
		private ObscuredDouble(ACTkByte8 value)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2A1FB8", Offset = "0x2A1FB8", VA = "0x62A1FB8")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2A204C", Offset = "0x2A204C", VA = "0x62A204C")]
		public static long Encrypt(double value)
		{
			return 0L;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2A20E8", Offset = "0x2A20E8", VA = "0x62A20E8")]
		public static long Encrypt(double value, long key)
		{
			return 0L;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2A20F4", Offset = "0x2A20F4", VA = "0x62A20F4")]
		private static ACTkByte8 InternalEncrypt(double value)
		{
			return default(ACTkByte8);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2A2198", Offset = "0x2A2198", VA = "0x62A2198")]
		private static ACTkByte8 InternalEncrypt(double value, long key)
		{
			return default(ACTkByte8);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2A2250", Offset = "0x2A2250", VA = "0x62A2250")]
		public static double Decrypt(long value)
		{
			return 0.0;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2A22EC", Offset = "0x2A22EC", VA = "0x62A22EC")]
		public static double Decrypt(long value, long key)
		{
			return 0.0;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1D0BE8", Offset = "0x1D0BE8", VA = "0x61D0BE8")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1D0BF0", Offset = "0x1D0BF0", VA = "0x61D0BF0")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1D0BF8", Offset = "0x1D0BF8", VA = "0x61D0BF8")]
		public long GetEncrypted()
		{
			return 0L;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1D0C18", Offset = "0x1D0C18", VA = "0x61D0C18")]
		public void SetEncrypted(long encrypted)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1D0C34", Offset = "0x1D0C34", VA = "0x61D0C34")]
		private double InternalDecrypt()
		{
			return 0.0;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2A2720", Offset = "0x2A2720", VA = "0x62A2720")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2A2810", Offset = "0x2A2810", VA = "0x62A2810")]
		public static implicit operator double(ObscuredDouble value)
		{
			return 0.0;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2A285C", Offset = "0x2A285C", VA = "0x62A285C")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2A2980", Offset = "0x2A2980", VA = "0x62A2980")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1D0C3C", Offset = "0x1D0C3C", VA = "0x61D0C3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1D0C68", Offset = "0x1D0C68", VA = "0x61D0C68")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1D0C9C", Offset = "0x1D0C9C", VA = "0x61D0C9C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1D0CD0", Offset = "0x1D0CD0", VA = "0x61D0CD0", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1D0D0C", Offset = "0x1D0D0C", VA = "0x61D0D0C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1D0D14", Offset = "0x1D0D14", VA = "0x61D0D14", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1D0D6C", Offset = "0x1D0D6C", VA = "0x61D0D6C", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ACTkByte8 hiddenValue;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1808D4", Offset = "0x1808D4")]
		private byte[] hiddenValueOld;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private double fakeValue;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool inited;

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x200001A")]
		[StructLayout(2)]
		private struct DoubleLongBytesUnion
		{
			// Token: 0x04000113 RID: 275
			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double d;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte8 b8;
		}
	}
}
