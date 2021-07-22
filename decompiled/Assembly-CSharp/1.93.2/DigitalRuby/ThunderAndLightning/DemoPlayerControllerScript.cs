using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000271 RID: 625
	[Token(Token = "0x20001E6")]
	public class DemoPlayerControllerScript : MonoBehaviour
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x3C67B0", Offset = "0x3C67B0", VA = "0x63C67B0")]
		public DemoPlayerControllerScript()
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x3C67C8", Offset = "0x3C67C8", VA = "0x63C67C8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x3C6A68", Offset = "0x3C6A68", VA = "0x63C6A68")]
		private void Start()
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x3C6C5C", Offset = "0x3C6C5C", VA = "0x63C6C5C")]
		private void Update()
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x3C7424", Offset = "0x3C7424", VA = "0x63C7424")]
		private bool GuiElementShouldPassThrough()
		{
			return default(bool);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x3C6B6C", Offset = "0x3C6B6C", VA = "0x63C6B6C")]
		private void UpdateSpell()
		{
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x3C78C4", Offset = "0x3C78C4", VA = "0x63C78C4")]
		private void ChangeSpell(int dir)
		{
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x3C741C", Offset = "0x3C741C", VA = "0x63C741C")]
		public void PreviousSpell()
		{
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x3C7414", Offset = "0x3C7414", VA = "0x63C7414")]
		public void NextSpell()
		{
		}

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0xC")]
		public Text SpellLabel;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x10")]
		public float Speed;

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x14")]
		public float RotateSpeed;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x18")]
		public LightningSpellScript[] Spells;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x1C")]
		private int spellIndex;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x20")]
		private bool spellMouseButtonDown;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x24")]
		private GameObject rightHand;
	}
}
