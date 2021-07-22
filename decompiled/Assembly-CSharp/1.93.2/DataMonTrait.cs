using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000240 RID: 576
[Token(Token = "0x20001B6")]
public class DataMonTrait : ScriptableObject
{
	// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x3C2DB8", Offset = "0x3C2DB8", VA = "0x63C2DB8")]
	public DataMonTrait()
	{
	}

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0xC")]
	public List<DataMonTrait.Sheet> sheets;

	// Token: 0x02000241 RID: 577
	[Token(Token = "0x20001B7")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x3C2E4C", Offset = "0x3C2E4C", VA = "0x63C2E4C")]
		public Sheet()
		{
		}

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0xC")]
		public List<DataMonTrait.Param> list;
	}

	// Token: 0x02000242 RID: 578
	[Token(Token = "0x20001B8")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x3C2E44", Offset = "0x3C2E44", VA = "0x63C2E44")]
		public Param()
		{
		}

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x8")]
		public string Index;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x10")]
		public string Desc;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x14")]
		public string Icon;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x18")]
		public int Max;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x1C")]
		public float Fac1;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x20")]
		public float Grow1;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x24")]
		public float Fac2;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x28")]
		public float Grow2;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x2C")]
		public float Fac3;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x30")]
		public float Grow3;
	}
}
