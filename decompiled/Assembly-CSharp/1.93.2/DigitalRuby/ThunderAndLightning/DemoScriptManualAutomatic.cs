using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000275 RID: 629
	[Token(Token = "0x20001EA")]
	public class DemoScriptManualAutomatic : MonoBehaviour
	{
		// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x3C8B4C", Offset = "0x3C8B4C", VA = "0x63C8B4C")]
		public DemoScriptManualAutomatic()
		{
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x3C8B54", Offset = "0x3C8B54", VA = "0x63C8B54")]
		private void Update()
		{
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x3C8CA4", Offset = "0x3C8CA4", VA = "0x63C8CA4")]
		public void AutomaticToggled()
		{
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x3C8D5C", Offset = "0x3C8D5C", VA = "0x63C8D5C")]
		public void ManualTriggerClicked()
		{
		}

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0xC")]
		public GameObject LightningPrefab;

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x10")]
		public Toggle AutomaticToggle;
	}
}
