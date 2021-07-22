using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000261 RID: 609
[Token(Token = "0x20001D7")]
public class Strings : ScriptableObject
{
	// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0xCA3CDC", Offset = "0xCA3CDC", VA = "0x6CA3CDC")]
	public Strings()
	{
	}

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0xC")]
	public List<Strings.Sheet> sheets;

	// Token: 0x02000262 RID: 610
	[Token(Token = "0x20001D8")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0xCA3D70", Offset = "0xCA3D70", VA = "0x6CA3D70")]
		public Sheet()
		{
		}

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0xC")]
		public List<Strings.Param> list;
	}

	// Token: 0x02000263 RID: 611
	[Token(Token = "0x20001D9")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0xCA3D68", Offset = "0xCA3D68", VA = "0x6CA3D68")]
		public Param()
		{
		}

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x8")]
		public string ID;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0xC")]
		public string Kor;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x10")]
		public string Jpn;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x14")]
		public string Eng;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x18")]
		public string Ger;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x1C")]
		public string Rus;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x20")]
		public string zhCN;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x24")]
		public string zhTW;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x28")]
		public string Frc;
	}
}
