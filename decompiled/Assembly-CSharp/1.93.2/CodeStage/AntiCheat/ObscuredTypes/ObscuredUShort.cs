using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000029")]
	[Serializable]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1D3728", Offset = "0x1D3728", VA = "0x61D3728")]
		private ObscuredUShort(ushort value)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x3B86E4", Offset = "0x3B86E4", VA = "0x63B86E4")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x3B8774", Offset = "0x3B8774", VA = "0x63B8774")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return 0;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x3B87F8", Offset = "0x3B87F8", VA = "0x63B87F8")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return 0;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1D3730", Offset = "0x1D3730", VA = "0x61D3730")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1D3738", Offset = "0x1D3738", VA = "0x61D3738")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1D3740", Offset = "0x1D3740", VA = "0x61D3740")]
		public ushort GetEncrypted()
		{
			return 0;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1D375C", Offset = "0x1D375C", VA = "0x61D375C")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1D3764", Offset = "0x1D3764", VA = "0x61D3764")]
		private ushort InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x3B8C04", Offset = "0x3B8C04", VA = "0x63B8C04")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x3B8CC4", Offset = "0x3B8CC4", VA = "0x63B8CC4")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return 0;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x3B8CE0", Offset = "0x3B8CE0", VA = "0x63B8CE0")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x3B8DA8", Offset = "0x3B8DA8", VA = "0x63B8DA8")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1D376C", Offset = "0x1D376C", VA = "0x61D376C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1D3774", Offset = "0x1D3774", VA = "0x61D3774", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1D377C", Offset = "0x1D377C", VA = "0x61D377C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1D37A8", Offset = "0x1D37A8", VA = "0x61D37A8")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1D37DC", Offset = "0x1D37DC", VA = "0x61D37DC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1D3808", Offset = "0x1D3808", VA = "0x61D3808")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1D383C", Offset = "0x1D383C", VA = "0x61D383C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x0")]
		private static ushort cryptoKey;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		private ushort currentCryptoKey;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x2")]
		private ushort hiddenValue;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x4")]
		private ushort fakeValue;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x6")]
		private bool inited;
	}
}
