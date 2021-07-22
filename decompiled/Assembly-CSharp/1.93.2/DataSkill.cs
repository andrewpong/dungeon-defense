using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000255 RID: 597
[Token(Token = "0x20001CB")]
public class DataSkill : ScriptableObject
{
	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x3C38F8", Offset = "0x3C38F8", VA = "0x63C38F8")]
	public DataSkill()
	{
	}

	// Token: 0x040006E9 RID: 1769
	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0xC")]
	public List<DataSkill.Sheet> sheets;

	// Token: 0x02000256 RID: 598
	[Token(Token = "0x20001CC")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x3C398C", Offset = "0x3C398C", VA = "0x63C398C")]
		public Sheet()
		{
		}

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0xC")]
		public List<DataSkill.Param> list;
	}

	// Token: 0x02000257 RID: 599
	[Token(Token = "0x20001CD")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x3C3984", Offset = "0x3C3984", VA = "0x63C3984")]
		public Param()
		{
		}

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x8")]
		public string Key;

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x14")]
		public string Summary;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x18")]
		public string Type;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x1C")]
		public string Icon;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x20")]
		public float Factor;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x24")]
		public float Scale;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x28")]
		public float Fac2;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x2C")]
		public float Scale2;

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x30")]
		public int Max;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x34")]
		public float Guage;
	}
}
