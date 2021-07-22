using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000246 RID: 582
[Token(Token = "0x20001BC")]
public class DataQuest : ScriptableObject
{
	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x3C31F0", Offset = "0x3C31F0", VA = "0x63C31F0")]
	public DataQuest()
	{
	}

	// Token: 0x040006A4 RID: 1700
	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0xC")]
	public List<DataQuest.Sheet> sheets;

	// Token: 0x02000247 RID: 583
	[Token(Token = "0x20001BD")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x3C3284", Offset = "0x3C3284", VA = "0x63C3284")]
		public Sheet()
		{
		}

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0xC")]
		public List<DataQuest.Param> list;
	}

	// Token: 0x02000248 RID: 584
	[Token(Token = "0x20001BE")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x3C327C", Offset = "0x3C327C", VA = "0x63C327C")]
		public Param()
		{
		}

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0xC")]
		public string Desc;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x10")]
		public int Max;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x14")]
		public int Reward;
	}
}
