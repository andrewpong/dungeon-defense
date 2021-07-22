using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002A7 RID: 679
	[Token(Token = "0x2000218")]
	public class SingleLineAttribute : PropertyAttribute
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x2ED2F0", Offset = "0x2ED2F0", VA = "0x62ED2F0")]
		public SingleLineAttribute(string tooltip)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000133")]
		public string Tooltip
		{
			[Token(Token = "0x6000EC4")]
			[Address(RVA = "0x2ED318", Offset = "0x2ED318", VA = "0x62ED318")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1875BC", Offset = "0x1875BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EC5")]
			[Address(RVA = "0x2ED310", Offset = "0x2ED310", VA = "0x62ED310")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1875CC", Offset = "0x1875CC")]
			private set
			{
			}
		}

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1832D0", Offset = "0x1832D0")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1832D0", Offset = "0x1832D0")]
		private string <Tooltip>k__BackingField;
	}
}
