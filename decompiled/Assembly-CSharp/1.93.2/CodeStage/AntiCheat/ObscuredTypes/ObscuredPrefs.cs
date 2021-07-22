using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x200001F")]
	public static class ObscuredPrefs
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public static string CryptoKey
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x3AB118", Offset = "0x3AB118", VA = "0x63AB118")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x3AB088", Offset = "0x3AB088", VA = "0x63AB088")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public static string DeviceId
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x3AB1A4", Offset = "0x3AB1A4", VA = "0x63AB1A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x3AB3A0", Offset = "0x3AB3A0", VA = "0x63AB3A0")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x188F64", Offset = "0x188F64")]
		internal static string DeviceID
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x3AB430", Offset = "0x3AB430", VA = "0x63AB430")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x3AB4A8", Offset = "0x3AB4A8", VA = "0x63AB4A8")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x17000024")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x3AB528", Offset = "0x3AB528", VA = "0x63AB528")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x3AB784", Offset = "0x3AB784", VA = "0x63AB784")]
		public static void ForceLockToDeviceInit()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x3AB8F8", Offset = "0x3AB8F8", VA = "0x63AB8F8")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x185398", Offset = "0x185398")]
		internal static void SetNewCryptoKey(string newKey)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x3AB978", Offset = "0x3AB978", VA = "0x63AB978")]
		public static void SetInt(string key, int value)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x3ABC4C", Offset = "0x3ABC4C", VA = "0x63ABC4C")]
		public static int GetInt(string key)
		{
			return 0;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x3ABCD0", Offset = "0x3ABCD0", VA = "0x63ABCD0")]
		public static int GetInt(string key, int defaultValue)
		{
			return 0;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x3ABB84", Offset = "0x3ABB84", VA = "0x63ABB84")]
		internal static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x3AC050", Offset = "0x3AC050", VA = "0x63AC050")]
		internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return 0;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x3AD5C8", Offset = "0x3AD5C8", VA = "0x63AD5C8")]
		public static void SetUInt(string key, uint value)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x3AD734", Offset = "0x3AD734", VA = "0x63AD734")]
		public static uint GetUInt(string key)
		{
			return 0U;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x3AD7B8", Offset = "0x3AD7B8", VA = "0x63AD7B8")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return 0U;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x3AD66C", Offset = "0x3AD66C", VA = "0x63AD66C")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x3AD8E0", Offset = "0x3AD8E0", VA = "0x63AD8E0")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return 0U;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x3ADACC", Offset = "0x3ADACC", VA = "0x63ADACC")]
		public static void SetString(string key, string value)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x3ADC60", Offset = "0x3ADC60", VA = "0x63ADC60")]
		public static string GetString(string key)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x3ADD28", Offset = "0x3ADD28", VA = "0x63ADD28")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x3ADB70", Offset = "0x3ADB70", VA = "0x63ADB70")]
		internal static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3ADF3C", Offset = "0x3ADF3C", VA = "0x63ADF3C")]
		internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x3AE140", Offset = "0x3AE140", VA = "0x63AE140")]
		public static void SetFloat(string key, float value)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x3AE2AC", Offset = "0x3AE2AC", VA = "0x63AE2AC")]
		public static float GetFloat(string key)
		{
			return 0f;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x3AE330", Offset = "0x3AE330", VA = "0x63AE330")]
		public static float GetFloat(string key, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x3AE1E4", Offset = "0x3AE1E4", VA = "0x63AE1E4")]
		internal static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x3AE544", Offset = "0x3AE544", VA = "0x63AE544")]
		internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x3AE73C", Offset = "0x3AE73C", VA = "0x63AE73C")]
		public static void SetDouble(string key, double value)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x3AE8C0", Offset = "0x3AE8C0", VA = "0x63AE8C0")]
		public static double GetDouble(string key)
		{
			return 0.0;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x3AE950", Offset = "0x3AE950", VA = "0x63AE950")]
		public static double GetDouble(string key, double defaultValue)
		{
			return 0.0;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x3AE7F0", Offset = "0x3AE7F0", VA = "0x63AE7F0")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x3AEA90", Offset = "0x3AEA90", VA = "0x63AEA90")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return 0.0;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x3AEC90", Offset = "0x3AEC90", VA = "0x63AEC90")]
		public static void SetLong(string key, long value)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x3AEE14", Offset = "0x3AEE14", VA = "0x63AEE14")]
		public static long GetLong(string key)
		{
			return 0L;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x3AEEA4", Offset = "0x3AEEA4", VA = "0x63AEEA4")]
		public static long GetLong(string key, long defaultValue)
		{
			return 0L;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x3AED44", Offset = "0x3AED44", VA = "0x63AED44")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x3AEFE4", Offset = "0x3AEFE4", VA = "0x63AEFE4")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return 0L;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x3AF1EC", Offset = "0x3AF1EC", VA = "0x63AF1EC")]
		public static void SetBool(string key, bool value)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x3AF358", Offset = "0x3AF358", VA = "0x63AF358")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x3AF3DC", Offset = "0x3AF3DC", VA = "0x63AF3DC")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3AF290", Offset = "0x3AF290", VA = "0x63AF290")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x3AF504", Offset = "0x3AF504", VA = "0x63AF504")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x3AF700", Offset = "0x3AF700", VA = "0x63AF700")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x3AF830", Offset = "0x3AF830", VA = "0x63AF830")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x3AF8B8", Offset = "0x3AF8B8", VA = "0x63AF8B8")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x3AF7A4", Offset = "0x3AF7A4", VA = "0x63AF7A4")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x3AFAD8", Offset = "0x3AFAD8", VA = "0x63AFAD8")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x3AFA1C", Offset = "0x3AFA1C", VA = "0x63AFA1C")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x3AFD0C", Offset = "0x3AFD0C", VA = "0x63AFD0C")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3AFEE8", Offset = "0x3AFEE8", VA = "0x63AFEE8")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x3AFFB8", Offset = "0x3AFFB8", VA = "0x63AFFB8")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x3AFDB8", Offset = "0x3AFDB8", VA = "0x63AFDB8")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x3B0114", Offset = "0x3B0114", VA = "0x63B0114")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x3B0458", Offset = "0x3B0458", VA = "0x63B0458")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x3B0660", Offset = "0x3B0660", VA = "0x63B0660")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x3B0738", Offset = "0x3B0738", VA = "0x63B0738")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x3B0514", Offset = "0x3B0514", VA = "0x63B0514")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x3B08A4", Offset = "0x3B08A4", VA = "0x63B08A4")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x3B0C50", Offset = "0x3B0C50", VA = "0x63B0C50")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x3B0E84", Offset = "0x3B0E84", VA = "0x63B0E84")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x3B0F60", Offset = "0x3B0F60", VA = "0x63B0F60")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x3B0D14", Offset = "0x3B0D14", VA = "0x63B0D14")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x3B10C8", Offset = "0x3B10C8", VA = "0x63B10C8")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x3B14D8", Offset = "0x3B14D8", VA = "0x63B14D8")]
		public static void SetColor(string key, Color32 value)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x3B1668", Offset = "0x3B1668", VA = "0x63B1668")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x3B171C", Offset = "0x3B171C", VA = "0x63B171C")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x3B15A0", Offset = "0x3B15A0", VA = "0x63B15A0")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x3B187C", Offset = "0x3B187C", VA = "0x63B187C")]
		public static void SetRect(string key, Rect value)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3B1AE0", Offset = "0x3B1AE0", VA = "0x63B1AE0")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x3B1BAC", Offset = "0x3B1BAC", VA = "0x63B1BAC")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x3B1940", Offset = "0x3B1940", VA = "0x63B1940")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x3B1D14", Offset = "0x3B1D14", VA = "0x63B1D14")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x3B215C", Offset = "0x3B215C", VA = "0x63B215C")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x3B21EC", Offset = "0x3B21EC", VA = "0x63B21EC")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x3B2274", Offset = "0x3B2274", VA = "0x63B2274")]
		internal static ObscuredPrefs.DataType GetRawValueType(string value)
		{
			return ObscuredPrefs.DataType.Unknown;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x3ABA1C", Offset = "0x3ABA1C", VA = "0x63ABA1C")]
		internal static string EncryptKey(string key)
		{
			return null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x3B2638", Offset = "0x3B2638", VA = "0x63B2638")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x3B26D8", Offset = "0x3B26D8", VA = "0x63B26D8")]
		public static void DeleteKey(string key)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x3B278C", Offset = "0x3B278C", VA = "0x63B278C")]
		public static void DeleteAll()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x3B2794", Offset = "0x3B2794", VA = "0x63B2794")]
		public static void Save()
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x3ABEE4", Offset = "0x3ABEE4", VA = "0x63ABEE4")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x3AC23C", Offset = "0x3AC23C", VA = "0x63AC23C")]
		private static string EncryptData(string key, byte[] cleanBytes, ObscuredPrefs.DataType type)
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x3ACF38", Offset = "0x3ACF38", VA = "0x63ACF38")]
		internal static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x3AB630", Offset = "0x3AB630", VA = "0x63AB630")]
		private static uint CalculateChecksum(string input)
		{
			return 0U;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x3B2ED8", Offset = "0x3B2ED8", VA = "0x63B2ED8")]
		private static void SavesTampered()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x3B2FDC", Offset = "0x3B2FDC", VA = "0x63B2FDC")]
		private static void PossibleForeignSavesDetected()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x3AB2F4", Offset = "0x3AB2F4", VA = "0x63AB2F4")]
		private static string GetDeviceId()
		{
			return null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x3B279C", Offset = "0x3B279C", VA = "0x63B279C")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x3AC6AC", Offset = "0x3AC6AC", VA = "0x63AC6AC")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x3B3270", Offset = "0x3B3270", VA = "0x63B3270")]
		private static string DeprecatedCalculateChecksum(string input)
		{
			return null;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000025")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x3B311C", Offset = "0x3B311C", VA = "0x63B311C")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x40000DD")]
		private const byte VERSION = 2;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x40000DE")]
		private const string RAW_NOT_FOUND = "{not_found}";

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x40000DF")]
		private const string DATA_SEPARATOR = "|";

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x0")]
		private static bool foreignSavesReported;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x4")]
		private static string cryptoKey;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x8")]
		private static string deviceId;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0xC")]
		private static uint deviceIdHash;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x10")]
		public static Action onAlterationDetected;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x14")]
		public static bool preservePlayerPrefs;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x18")]
		public static Action onPossibleForeignSavesDetected;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x1C")]
		public static ObscuredPrefs.DeviceLockLevel lockToDevice;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x1D")]
		public static bool readForeignSaves;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x1E")]
		public static bool emergencyMode;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x40000EA")]
		private const char DEPRECATED_RAW_SEPARATOR = ':';

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x20")]
		private static string deprecatedDeviceId;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000020")]
		internal enum DataType : byte
		{
			// Token: 0x04000139 RID: 313
			[Token(Token = "0x40000ED")]
			Unknown,
			// Token: 0x0400013A RID: 314
			[Token(Token = "0x40000EE")]
			Int = 5,
			// Token: 0x0400013B RID: 315
			[Token(Token = "0x40000EF")]
			UInt = 10,
			// Token: 0x0400013C RID: 316
			[Token(Token = "0x40000F0")]
			String = 15,
			// Token: 0x0400013D RID: 317
			[Token(Token = "0x40000F1")]
			Float = 20,
			// Token: 0x0400013E RID: 318
			[Token(Token = "0x40000F2")]
			Double = 25,
			// Token: 0x0400013F RID: 319
			[Token(Token = "0x40000F3")]
			Long = 30,
			// Token: 0x04000140 RID: 320
			[Token(Token = "0x40000F4")]
			Bool = 35,
			// Token: 0x04000141 RID: 321
			[Token(Token = "0x40000F5")]
			ByteArray = 40,
			// Token: 0x04000142 RID: 322
			[Token(Token = "0x40000F6")]
			Vector2 = 45,
			// Token: 0x04000143 RID: 323
			[Token(Token = "0x40000F7")]
			Vector3 = 50,
			// Token: 0x04000144 RID: 324
			[Token(Token = "0x40000F8")]
			Quaternion = 55,
			// Token: 0x04000145 RID: 325
			[Token(Token = "0x40000F9")]
			Color = 60,
			// Token: 0x04000146 RID: 326
			[Token(Token = "0x40000FA")]
			Rect = 65
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000021")]
		public enum DeviceLockLevel : byte
		{
			// Token: 0x04000148 RID: 328
			[Token(Token = "0x40000FC")]
			None,
			// Token: 0x04000149 RID: 329
			[Token(Token = "0x40000FD")]
			Soft,
			// Token: 0x0400014A RID: 330
			[Token(Token = "0x40000FE")]
			Strict
		}
	}
}
