using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x2000014")]
	[Serializable]
	public struct ObscuredBool : IEquatable<ObscuredBool>
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1D025C", Offset = "0x1D025C", VA = "0x61D025C")]
		private ObscuredBool(int value)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x29ED90", Offset = "0x29ED90", VA = "0x629ED90")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x29EE20", Offset = "0x29EE20", VA = "0x629EE20")]
		public static int Encrypt(bool value)
		{
			return 0;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x29EEA4", Offset = "0x29EEA4", VA = "0x629EEA4")]
		public static int Encrypt(bool value, byte key)
		{
			return 0;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x29EF50", Offset = "0x29EF50", VA = "0x629EF50")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x29EFD4", Offset = "0x29EFD4", VA = "0x629EFD4")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1D0264", Offset = "0x1D0264", VA = "0x61D0264")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1D026C", Offset = "0x1D026C", VA = "0x61D026C")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1D0274", Offset = "0x1D0274", VA = "0x61D0274")]
		public int GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1D0290", Offset = "0x1D0290", VA = "0x61D0290")]
		public void SetEncrypted(int encrypted)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1D0298", Offset = "0x1D0298", VA = "0x61D0298")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x29373C", Offset = "0x29373C", VA = "0x629373C")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x281914", Offset = "0x281914", VA = "0x6281914")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1D02A0", Offset = "0x1D02A0", VA = "0x61D02A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1D02A8", Offset = "0x1D02A8", VA = "0x61D02A8", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1D02C4", Offset = "0x1D02C4", VA = "0x61D02C4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1D02F0", Offset = "0x1D02F0", VA = "0x61D02F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte currentCryptoKey;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool fakeValue;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool fakeValueChanged;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0xA")]
		[SerializeField]
		private bool inited;
	}
}
