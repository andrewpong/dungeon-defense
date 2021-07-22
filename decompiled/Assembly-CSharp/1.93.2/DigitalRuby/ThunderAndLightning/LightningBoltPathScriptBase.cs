using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000203")]
	public abstract class LightningBoltPathScriptBase : LightningBoltPrefabScriptBase
	{
		// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x2DCB28", Offset = "0x2DCB28", VA = "0x62DCB28")]
		protected LightningBoltPathScriptBase()
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x2DD12C", Offset = "0x2DD12C", VA = "0x62DD12C")]
		protected List<GameObject> GetCurrentPathObjects()
		{
			return null;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x2DD57C", Offset = "0x2DD57C", VA = "0x62DD57C", Slot = "8")]
		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181C88", Offset = "0x181C88")]
		[Attribute(Name = "ReorderableListAttribute", RVA = "0x181C88", Offset = "0x181C88")]
		public ReorderableList_GameObject LightningPath;

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x134")]
		private readonly List<GameObject> currentPathObjects;
	}
}
