using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x200025E")]
	public class ModData
	{
		// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x28BC98", Offset = "0x28BC98", VA = "0x628BC98")]
		public ModData()
		{
		}

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x8")]
		public ModType eID;

		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x10")]
		public string strDesc;

		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x14")]
		public List<ItemType> listTarget;

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x18")]
		public bool bUse;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x1C")]
		public float fBase;

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x20")]
		public float fGrow;
	}
}
