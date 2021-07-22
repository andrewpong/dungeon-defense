using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000022")]
	[Serializable]
	public struct ObscuredQuaternion
	{
		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1D2E20", Offset = "0x1D2E20", VA = "0x61D2E20")]
		private ObscuredQuaternion(ObscuredQuaternion.RawEncryptedQuaternion value)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x3B35D8", Offset = "0x3B35D8", VA = "0x63B35D8")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x3B3668", Offset = "0x3B3668", VA = "0x63B3668")]
		public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(ObscuredQuaternion.RawEncryptedQuaternion);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3B3718", Offset = "0x3B3718", VA = "0x63B3718")]
		public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(ObscuredQuaternion.RawEncryptedQuaternion);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3B3854", Offset = "0x3B3854", VA = "0x63B3854")]
		public static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3B3904", Offset = "0x3B3904", VA = "0x63B3904")]
		public static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1D2E44", Offset = "0x1D2E44", VA = "0x61D2E44")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1D2E4C", Offset = "0x1D2E4C", VA = "0x61D2E4C")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1D2E54", Offset = "0x1D2E54", VA = "0x61D2E54")]
		public ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
		{
			return default(ObscuredQuaternion.RawEncryptedQuaternion);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1D2E7C", Offset = "0x1D2E7C", VA = "0x61D2E7C")]
		public void SetEncrypted(ObscuredQuaternion.RawEncryptedQuaternion encrypted)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1D2EA0", Offset = "0x1D2EA0", VA = "0x61D2EA0")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1D2EB4", Offset = "0x1D2EB4", VA = "0x61D2EB4")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x3B4044", Offset = "0x3B4044", VA = "0x63B4044")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x3B414C", Offset = "0x3B414C", VA = "0x63B414C")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1D2EF0", Offset = "0x1D2EF0", VA = "0x61D2EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1D2F28", Offset = "0x1D2F28", VA = "0x61D2F28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1D2F60", Offset = "0x1D2F60", VA = "0x61D2F60")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Quaternion initialFakeValue;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Quaternion fakeValue;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool inited;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x2000023")]
		[Serializable]
		public struct RawEncryptedQuaternion
		{
			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000105")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x8")]
			public int z;

			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0xC")]
			public int w;
		}
	}
}
