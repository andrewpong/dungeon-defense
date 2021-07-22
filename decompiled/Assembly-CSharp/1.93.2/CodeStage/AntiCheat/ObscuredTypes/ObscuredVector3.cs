using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x200002C")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x17F040", Offset = "0x17F040")]
	[Serializable]
	public struct ObscuredVector3
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1D3AD4", Offset = "0x1D3AD4", VA = "0x61D3AD4")]
		private ObscuredVector3(ObscuredVector3.RawEncryptedVector3 encrypted)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public float x
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1D3AF0", Offset = "0x1D3AF0", VA = "0x61D3AF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1D3AF8", Offset = "0x1D3AF8", VA = "0x61D3AF8")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00003A50 File Offset: 0x00001C50
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public float y
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1D3B00", Offset = "0x1D3B00", VA = "0x61D3B00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1D3B08", Offset = "0x1D3B08", VA = "0x61D3B08")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00003A68 File Offset: 0x00001C68
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public float z
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1D3B10", Offset = "0x1D3B10", VA = "0x61D3B10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1D3B18", Offset = "0x1D3B18", VA = "0x61D3B18")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00003A80 File Offset: 0x00001C80
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public float Item
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1D3B20", Offset = "0x1D3B20", VA = "0x61D3B20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1D3B28", Offset = "0x1D3B28", VA = "0x61D3B28")]
			set
			{
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x3BAC74", Offset = "0x3BAC74", VA = "0x63BAC74")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x3BAD04", Offset = "0x3BAD04", VA = "0x63BAD04")]
		public static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(ObscuredVector3.RawEncryptedVector3);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x3BADAC", Offset = "0x3BADAC", VA = "0x63BADAC")]
		public static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(ObscuredVector3.RawEncryptedVector3);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x3BAEC4", Offset = "0x3BAEC4", VA = "0x63BAEC4")]
		public static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x3BAF6C", Offset = "0x3BAF6C", VA = "0x63BAF6C")]
		public static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1D3B30", Offset = "0x1D3B30", VA = "0x61D3B30")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1D3B38", Offset = "0x1D3B38", VA = "0x61D3B38")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1D3B40", Offset = "0x1D3B40", VA = "0x61D3B40")]
		public ObscuredVector3.RawEncryptedVector3 GetEncrypted()
		{
			return default(ObscuredVector3.RawEncryptedVector3);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1D3B6C", Offset = "0x1D3B6C", VA = "0x61D3B6C")]
		public void SetEncrypted(ObscuredVector3.RawEncryptedVector3 encrypted)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1D3B88", Offset = "0x1D3B88", VA = "0x61D3B88")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1D3B9C", Offset = "0x1D3B9C", VA = "0x61D3B9C")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1D3BC0", Offset = "0x1D3BC0", VA = "0x61D3BC0")]
		private float InternalDecryptField(int encrypted)
		{
			return 0f;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1D3BC8", Offset = "0x1D3BC8", VA = "0x61D3BC8")]
		private int InternalEncryptField(float encrypted)
		{
			return 0;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x3BB618", Offset = "0x3BB618", VA = "0x63BB618")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x3BB720", Offset = "0x3BB720", VA = "0x63BB720")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x3BB764", Offset = "0x3BB764", VA = "0x63BB764")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x3BB8C8", Offset = "0x3BB8C8", VA = "0x63BB8C8")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x3BB9F8", Offset = "0x3BB9F8", VA = "0x63BB9F8")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x3BBB1C", Offset = "0x3BBB1C", VA = "0x63BBB1C")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x3BBC80", Offset = "0x3BBC80", VA = "0x63BBC80")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x3BBDB0", Offset = "0x3BBDB0", VA = "0x63BBDB0")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x3BBED4", Offset = "0x3BBED4", VA = "0x63BBED4")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x3BBFE8", Offset = "0x3BBFE8", VA = "0x63BBFE8")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x3BC10C", Offset = "0x3BC10C", VA = "0x63BC10C")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x3BC228", Offset = "0x3BC228", VA = "0x63BC228")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x3BC34C", Offset = "0x3BC34C", VA = "0x63BC34C")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x3BC470", Offset = "0x3BC470", VA = "0x63BC470")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x3BC55C", Offset = "0x3BC55C", VA = "0x63BC55C")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x3BC640", Offset = "0x3BC640", VA = "0x63BC640")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x3BC764", Offset = "0x3BC764", VA = "0x63BC764")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x3BC850", Offset = "0x3BC850", VA = "0x63BC850")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1D3BCC", Offset = "0x1D3BCC", VA = "0x61D3BCC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1D3C14", Offset = "0x1D3C14", VA = "0x61D3C14", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1D3C54", Offset = "0x1D3C54", VA = "0x61D3C54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1D3C94", Offset = "0x1D3C94", VA = "0x61D3C94")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector3 initialFakeValue;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredVector3.RawEncryptedVector3 hiddenValue;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 fakeValue;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool inited;

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x200002D")]
		[Serializable]
		public struct RawEncryptedVector3
		{
			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04000182 RID: 386
			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x8")]
			public int z;
		}
	}
}
