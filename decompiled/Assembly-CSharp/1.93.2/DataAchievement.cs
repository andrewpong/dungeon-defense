using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022E RID: 558
[Token(Token = "0x20001A4")]
public class DataAchievement : ScriptableObject
{
	// Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x3C26B0", Offset = "0x3C26B0", VA = "0x63C26B0")]
	public DataAchievement()
	{
	}

	// Token: 0x04000628 RID: 1576
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0xC")]
	public List<DataAchievement.Sheet> sheets;

	// Token: 0x0200022F RID: 559
	[Token(Token = "0x20001A5")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x3C2744", Offset = "0x3C2744", VA = "0x63C2744")]
		public Sheet()
		{
		}

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0xC")]
		public List<DataAchievement.Param> list;
	}

	// Token: 0x02000230 RID: 560
	[Token(Token = "0x20001A6")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x3C273C", Offset = "0x3C273C", VA = "0x63C273C")]
		public Param()
		{
		}

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x14")]
		public string RewardType;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x18")]
		public int RewardFactor;
	}
}
