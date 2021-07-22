using System;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200020B")]
	[Serializable]
	public struct RangeOfIntegers
	{
		// Token: 0x0600101A RID: 4122 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x1D12C0", Offset = "0x1D12C0", VA = "0x61D12C0")]
		public int Random()
		{
			return 0;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x1D12D8", Offset = "0x1D12D8", VA = "0x61D12D8")]
		public int Random(Random r)
		{
			return 0;
		}

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1831CC", Offset = "0x1831CC")]
		public int Minimum;

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183200", Offset = "0x183200")]
		public int Maximum;
	}
}
