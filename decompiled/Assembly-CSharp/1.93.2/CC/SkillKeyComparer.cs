using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000270")]
	public struct SkillKeyComparer : IEqualityComparer<SkillKey>
	{
		// Token: 0x06001154 RID: 4436 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x1D01D0", Offset = "0x1D01D0", VA = "0x61D01D0", Slot = "4")]
		public bool Equals(SkillKey x, SkillKey y)
		{
			return default(bool);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x1D01E0", Offset = "0x1D01E0", VA = "0x61D01E0", Slot = "5")]
		public int GetHashCode(SkillKey obj)
		{
			return 0;
		}
	}
}
