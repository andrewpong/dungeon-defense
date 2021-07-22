using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025E RID: 606
[Token(Token = "0x20001D4")]
public class DataWeapon : ScriptableObject
{
	// Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x3C3D30", Offset = "0x3C3D30", VA = "0x63C3D30")]
	public DataWeapon()
	{
	}

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0xC")]
	public List<DataWeapon.Sheet> sheets;

	// Token: 0x0200025F RID: 607
	[Token(Token = "0x20001D5")]
	[Serializable]
	public class Sheet
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x3C3DC4", Offset = "0x3C3DC4", VA = "0x63C3DC4")]
		public Sheet()
		{
		}

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0xC")]
		public List<DataWeapon.Param> list;
	}

	// Token: 0x02000260 RID: 608
	[Token(Token = "0x20001D6")]
	[Serializable]
	public class Param
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x3C3DBC", Offset = "0x3C3DBC", VA = "0x63C3DBC")]
		public Param()
		{
		}

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x10")]
		public string ItemType;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x14")]
		public string Sprite;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x18")]
		public string BulletSprite;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x1C")]
		public string Type;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x20")]
		public string Trail;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x24")]
		public string Mastery;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x28")]
		public int DropMin;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x2C")]
		public int DropMax;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x30")]
		public int Grade;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x34")]
		public float Dmg;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x38")]
		public float FireRate;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x3C")]
		public int Ammo;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x40")]
		public int Reload;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x44")]
		public float Speed;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x48")]
		public int Spread;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x4C")]
		public float vsArmor;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x50")]
		public float vsMagic;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x54")]
		public float Acc;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x58")]
		public int Pen;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x5C")]
		public bool Spin;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x60")]
		public float Range;
	}
}
