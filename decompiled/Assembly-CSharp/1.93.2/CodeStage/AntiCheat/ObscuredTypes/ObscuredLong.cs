using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x200001E")]
	[Serializable]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1D2BF4", Offset = "0x1D2BF4", VA = "0x61D2BF4")]
		private ObscuredLong(long value)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x3AA334", Offset = "0x3AA334", VA = "0x63AA334")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3AA3C8", Offset = "0x3AA3C8", VA = "0x63AA3C8")]
		public static long Encrypt(long value)
		{
			return 0L;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x3AA50C", Offset = "0x3AA50C", VA = "0x63AA50C")]
		public static long Decrypt(long value)
		{
			return 0L;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x3AA460", Offset = "0x3AA460", VA = "0x63AA460")]
		public static long Encrypt(long value, long key)
		{
			return 0L;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x3AA5A4", Offset = "0x3AA5A4", VA = "0x63AA5A4")]
		public static long Decrypt(long value, long key)
		{
			return 0L;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1D2C10", Offset = "0x1D2C10", VA = "0x61D2C10")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1D2C18", Offset = "0x1D2C18", VA = "0x61D2C18")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1D2C20", Offset = "0x1D2C20", VA = "0x61D2C20")]
		public long GetEncrypted()
		{
			return 0L;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1D2C3C", Offset = "0x1D2C3C", VA = "0x61D2C3C")]
		public void SetEncrypted(long encrypted)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1D2C58", Offset = "0x1D2C58", VA = "0x61D2C58")]
		private long InternalDecrypt()
		{
			return 0L;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x3AAA34", Offset = "0x3AAA34", VA = "0x63AAA34")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x3AAB10", Offset = "0x3AAB10", VA = "0x63AAB10")]
		public static implicit operator long(ObscuredLong value)
		{
			return 0L;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3AAB4C", Offset = "0x3AAB4C", VA = "0x63AAB4C")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3AAC64", Offset = "0x3AAC64", VA = "0x63AAC64")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1D2C60", Offset = "0x1D2C60", VA = "0x61D2C60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1D2C68", Offset = "0x1D2C68", VA = "0x61D2C68", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1D2CB0", Offset = "0x1D2CB0", VA = "0x61D2CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1D2CDC", Offset = "0x1D2CDC", VA = "0x61D2CDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1D2D08", Offset = "0x1D2D08", VA = "0x61D2D08")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1D2D3C", Offset = "0x1D2D3C", VA = "0x61D2D3C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1D2D70", Offset = "0x1D2D70", VA = "0x61D2D70", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private long fakeValue;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;
	}
}
