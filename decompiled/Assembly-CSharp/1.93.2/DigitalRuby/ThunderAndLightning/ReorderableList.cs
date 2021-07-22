using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002A4 RID: 676
	[Token(Token = "0x2000215")]
	[Serializable]
	public class ReorderableList<T> : ReorderableListBase
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBE")]
		public ReorderableList()
		{
		}

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x0")]
		public List<T> List;
	}
}
