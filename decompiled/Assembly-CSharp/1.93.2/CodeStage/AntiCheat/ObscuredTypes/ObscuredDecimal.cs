using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x2000017")]
	[Serializable]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1D07D8", Offset = "0x1D07D8", VA = "0x61D07D8")]
		private ObscuredDecimal(ACTkByte16 value)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2A0C08", Offset = "0x2A0C08", VA = "0x62A0C08")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2A0C9C", Offset = "0x2A0C9C", VA = "0x62A0C9C")]
		public static decimal Encrypt(decimal value)
		{
			return 0m;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2A0D54", Offset = "0x2A0D54", VA = "0x62A0D54")]
		public static decimal Encrypt(decimal value, long key)
		{
			return 0m;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2A0D80", Offset = "0x2A0D80", VA = "0x62A0D80")]
		private static ACTkByte16 InternalEncrypt(decimal value)
		{
			return default(ACTkByte16);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2A0E34", Offset = "0x2A0E34", VA = "0x62A0E34")]
		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return default(ACTkByte16);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2A0F0C", Offset = "0x2A0F0C", VA = "0x62A0F0C")]
		public static decimal Decrypt(decimal value)
		{
			return 0m;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2A0FC4", Offset = "0x2A0FC4", VA = "0x62A0FC4")]
		public static decimal Decrypt(decimal value, long key)
		{
			return 0m;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1D07FC", Offset = "0x1D07FC", VA = "0x61D07FC")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1D0804", Offset = "0x1D0804", VA = "0x61D0804")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1D080C", Offset = "0x1D080C", VA = "0x61D080C")]
		public decimal GetEncrypted()
		{
			return 0m;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1D0834", Offset = "0x1D0834", VA = "0x61D0834")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1D0858", Offset = "0x1D0858", VA = "0x61D0858")]
		private decimal InternalDecrypt()
		{
			return 0m;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2A15B4", Offset = "0x2A15B4", VA = "0x62A15B4")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2A16B4", Offset = "0x2A16B4", VA = "0x62A16B4")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return 0m;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2A1720", Offset = "0x2A1720", VA = "0x62A1720")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2A1854", Offset = "0x2A1854", VA = "0x62A1854")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2A1A14", Offset = "0x2A1A14", VA = "0x62A1A14")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1D086C", Offset = "0x1D086C", VA = "0x61D086C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1D08A4", Offset = "0x1D08A4", VA = "0x61D08A4")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1D08E4", Offset = "0x1D08E4", VA = "0x61D08E4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1D0924", Offset = "0x1D0924", VA = "0x61D0924", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1D096C", Offset = "0x1D096C", VA = "0x61D096C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1D0974", Offset = "0x1D0974", VA = "0x61D0974", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1D09D4", Offset = "0x1D09D4", VA = "0x61D09D4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long currentCryptoKey;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x180880", Offset = "0x180880")]
		private byte[] hiddenValueOld;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private ACTkByte16 hiddenValue;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private decimal fakeValue;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool inited;

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x2000018")]
		[StructLayout(2)]
		private struct DecimalLongBytesUnion
		{
			// Token: 0x04000109 RID: 265
			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public decimal d;

			// Token: 0x0400010A RID: 266
			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l1;

			// Token: 0x0400010B RID: 267
			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long l2;

			// Token: 0x0400010C RID: 268
			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte16 b16;
		}
	}
}
