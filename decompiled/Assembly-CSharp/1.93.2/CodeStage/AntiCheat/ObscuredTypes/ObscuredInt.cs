using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x200001D")]
	[Serializable]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1D1120", Offset = "0x1D1120", VA = "0x61D1120")]
		private ObscuredInt(int value)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2A39D0", Offset = "0x2A39D0", VA = "0x62A39D0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2A3A60", Offset = "0x2A3A60", VA = "0x62A3A60")]
		public static int Encrypt(int value)
		{
			return 0;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2A3AE4", Offset = "0x2A3AE4", VA = "0x62A3AE4")]
		public static int Encrypt(int value, int key)
		{
			return 0;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2A3B84", Offset = "0x2A3B84", VA = "0x62A3B84")]
		public static int Decrypt(int value)
		{
			return 0;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2A3C08", Offset = "0x2A3C08", VA = "0x62A3C08")]
		public static int Decrypt(int value, int key)
		{
			return 0;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1D1128", Offset = "0x1D1128", VA = "0x61D1128")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1D1130", Offset = "0x1D1130", VA = "0x61D1130")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1D1138", Offset = "0x1D1138", VA = "0x61D1138")]
		public int GetEncrypted()
		{
			return 0;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1D1154", Offset = "0x1D1154", VA = "0x61D1154")]
		public void SetEncrypted(int encrypted)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1D115C", Offset = "0x1D115C", VA = "0x61D115C")]
		private int InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x293314", Offset = "0x293314", VA = "0x6293314")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2818F8", Offset = "0x2818F8", VA = "0x62818F8")]
		public static implicit operator int(ObscuredInt value)
		{
			return 0;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2A405C", Offset = "0x2A405C", VA = "0x62A405C")]
		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2A410C", Offset = "0x2A410C", VA = "0x62A410C")]
		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2A41C0", Offset = "0x2A41C0", VA = "0x62A41C0")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2A426C", Offset = "0x2A426C", VA = "0x62A426C")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2A4338", Offset = "0x2A4338", VA = "0x62A4338")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1D1164", Offset = "0x1D1164", VA = "0x61D1164", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1D116C", Offset = "0x1D116C", VA = "0x61D116C", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1D1190", Offset = "0x1D1190", VA = "0x61D1190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1D11BC", Offset = "0x1D11BC", VA = "0x61D11BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1D11E8", Offset = "0x1D11E8", VA = "0x61D11E8")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1D121C", Offset = "0x1D121C", VA = "0x61D121C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1D1250", Offset = "0x1D1250", VA = "0x61D1250", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int fakeValue;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;
	}
}
