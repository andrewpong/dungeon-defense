using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x200021E")]
	public class LightningLightsabreScript : LightningBoltPrefabScript
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x2E3EA8", Offset = "0x2E3EA8", VA = "0x62E3EA8")]
		public LightningLightsabreScript()
		{
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x2E3EC0", Offset = "0x2E3EC0", VA = "0x62E3EC0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x2E3EC4", Offset = "0x2E3EC4", VA = "0x62E3EC4", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x2E4110", Offset = "0x2E4110", VA = "0x62E4110")]
		public bool TurnOn(bool value)
		{
			return default(bool);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x2E43E0", Offset = "0x2E43E0", VA = "0x62E43E0")]
		public void TurnOnGUI(bool value)
		{
		}

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1834A8", Offset = "0x1834A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1834A8", Offset = "0x1834A8")]
		public float BladeHeight;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x154")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183524", Offset = "0x183524")]
		public float ActivationTime;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183584", Offset = "0x183584")]
		public AudioSource StartSound;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x15C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1835DC", Offset = "0x1835DC")]
		public AudioSource StopSound;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183634", Offset = "0x183634")]
		public AudioSource ConstantSound;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x164")]
		private int state;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x168")]
		private Vector3 bladeStart;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x174")]
		private Vector3 bladeDir;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x180")]
		private float bladeTime;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x184")]
		private float bladeIntensity;
	}
}
