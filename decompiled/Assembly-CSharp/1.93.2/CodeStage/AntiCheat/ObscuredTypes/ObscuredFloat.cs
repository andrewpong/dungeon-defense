using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x200001B")]
	[Serializable]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1D0F5C", Offset = "0x1D0F5C", VA = "0x61D0F5C")]
		private ObscuredFloat(ACTkByte4 value)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2A2E08", Offset = "0x2A2E08", VA = "0x62A2E08")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2A2E98", Offset = "0x2A2E98", VA = "0x62A2E98")]
		public static int Encrypt(float value)
		{
			return 0;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2A2F2C", Offset = "0x2A2F2C", VA = "0x62A2F2C")]
		public static int Encrypt(float value, int key)
		{
			return 0;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2A2F34", Offset = "0x2A2F34", VA = "0x62A2F34")]
		private static ACTkByte4 InternalEncrypt(float value)
		{
			return default(ACTkByte4);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2A2FB8", Offset = "0x2A2FB8", VA = "0x62A2FB8")]
		private static ACTkByte4 InternalEncrypt(float value, int key)
		{
			return default(ACTkByte4);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2A3058", Offset = "0x2A3058", VA = "0x62A3058")]
		public static float Decrypt(int value)
		{
			return 0f;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2A30EC", Offset = "0x2A30EC", VA = "0x62A30EC")]
		public static float Decrypt(int value, int key)
		{
			return 0f;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1D0F64", Offset = "0x1D0F64", VA = "0x61D0F64")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1D0F6C", Offset = "0x1D0F6C", VA = "0x61D0F6C")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1D0F74", Offset = "0x1D0F74", VA = "0x61D0F74")]
		public int GetEncrypted()
		{
			return 0;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1D0F90", Offset = "0x1D0F90", VA = "0x61D0F90")]
		public void SetEncrypted(int encrypted)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1D0F98", Offset = "0x1D0F98", VA = "0x61D0F98")]
		private float InternalDecrypt()
		{
			return 0f;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x283154", Offset = "0x283154", VA = "0x6283154")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x283130", Offset = "0x283130", VA = "0x6283130")]
		public static implicit operator float(ObscuredFloat value)
		{
			return 0f;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2A34F4", Offset = "0x2A34F4", VA = "0x62A34F4")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2A35DC", Offset = "0x2A35DC", VA = "0x62A35DC")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1D0FA0", Offset = "0x1D0FA0", VA = "0x61D0FA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1D0FA8", Offset = "0x1D0FA8", VA = "0x61D0FA8", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1D0FD0", Offset = "0x1D0FD0", VA = "0x61D0FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1D0FFC", Offset = "0x1D0FFC", VA = "0x61D0FFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1D1028", Offset = "0x1D1028", VA = "0x61D1028")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1D105C", Offset = "0x1D105C", VA = "0x61D105C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1D1090", Offset = "0x1D1090", VA = "0x61D1090", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ACTkByte4 hiddenValue;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x18095C", Offset = "0x18095C")]
		private byte[] hiddenValueOld;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private float fakeValue;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x200001C")]
		[StructLayout(2)]
		private struct FloatIntBytesUnion
		{
			// Token: 0x0400011C RID: 284
			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			// Token: 0x0400011D RID: 285
			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			// Token: 0x0400011E RID: 286
			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte4 b4;
		}
	}
}
