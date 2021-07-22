using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x200002A")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x17F00C", Offset = "0x17F00C")]
	[Serializable]
	public struct ObscuredVector2
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1D38DC", Offset = "0x1D38DC", VA = "0x61D38DC")]
		private ObscuredVector2(ObscuredVector2.RawEncryptedVector2 value)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000038B8 File Offset: 0x00001AB8
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public float x
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1D38E4", Offset = "0x1D38E4", VA = "0x61D38E4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1D38EC", Offset = "0x1D38EC", VA = "0x61D38EC")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public float y
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1D38F4", Offset = "0x1D38F4", VA = "0x61D38F4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1D38FC", Offset = "0x1D38FC", VA = "0x61D38FC")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public float Item
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1D3904", Offset = "0x1D3904", VA = "0x61D3904")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1D390C", Offset = "0x1D390C", VA = "0x61D390C")]
			set
			{
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x3B97F8", Offset = "0x3B97F8", VA = "0x63B97F8")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x3B9888", Offset = "0x3B9888", VA = "0x63B9888")]
		public static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(ObscuredVector2.RawEncryptedVector2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x3B9924", Offset = "0x3B9924", VA = "0x63B9924")]
		public static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(ObscuredVector2.RawEncryptedVector2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x3B9A20", Offset = "0x3B9A20", VA = "0x63B9A20")]
		public static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x3B9ABC", Offset = "0x3B9ABC", VA = "0x63B9ABC")]
		public static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1D3914", Offset = "0x1D3914", VA = "0x61D3914")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1D391C", Offset = "0x1D391C", VA = "0x61D391C")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1D3924", Offset = "0x1D3924", VA = "0x61D3924")]
		public ObscuredVector2.RawEncryptedVector2 GetEncrypted()
		{
			return default(ObscuredVector2.RawEncryptedVector2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1D394C", Offset = "0x1D394C", VA = "0x61D394C")]
		public void SetEncrypted(ObscuredVector2.RawEncryptedVector2 encrypted)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1D3954", Offset = "0x1D3954", VA = "0x61D3954")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1D3968", Offset = "0x1D3968", VA = "0x61D3968")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1D3988", Offset = "0x1D3988", VA = "0x61D3988")]
		private float InternalDecryptField(int encrypted)
		{
			return 0f;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1D3990", Offset = "0x1D3990", VA = "0x61D3990")]
		private int InternalEncryptField(float encrypted)
		{
			return 0;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x3BA0D8", Offset = "0x3BA0D8", VA = "0x63BA0D8")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x3BA1BC", Offset = "0x3BA1BC", VA = "0x63BA1BC")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x3BA1F0", Offset = "0x3BA1F0", VA = "0x63BA1F0")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1D3994", Offset = "0x1D3994", VA = "0x61D3994", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1D39D0", Offset = "0x1D39D0", VA = "0x61D39D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1D3A0C", Offset = "0x1D3A0C", VA = "0x61D3A0C")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector2 initialFakeValue;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredVector2.RawEncryptedVector2 hiddenValue;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector2 fakeValue;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x200002B")]
		[Serializable]
		public struct RawEncryptedVector2
		{
			// Token: 0x04000179 RID: 377
			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x0400017A RID: 378
			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x4")]
			public int y;
		}
	}
}
