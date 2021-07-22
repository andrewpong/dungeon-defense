using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x2000224")]
	public class LightningBeamSpellScript : LightningSpellScript
	{
		// Token: 0x06001080 RID: 4224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x3C937C", Offset = "0x3C937C", VA = "0x63C937C")]
		public LightningBeamSpellScript()
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x3C938C", Offset = "0x3C938C", VA = "0x63C938C")]
		private void CheckCollision()
		{
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x3C99C8", Offset = "0x3C99C8", VA = "0x63C99C8", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x3C99FC", Offset = "0x3C99FC", VA = "0x63C99FC", Slot = "6")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x3C9A30", Offset = "0x3C9A30", VA = "0x63C9A30", Slot = "8")]
		protected override void OnCastSpell()
		{
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x3C9A58", Offset = "0x3C9A58", VA = "0x63C9A58", Slot = "9")]
		protected override void OnStopSpell()
		{
		}

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183964", Offset = "0x183964")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183964", Offset = "0x183964")]
		public LightningBoltPathScriptBase LightningPathScript;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1839F8", Offset = "0x1839F8")]
		public float EndPointRandomization;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HideInInspector", RVA = "0x183A4C", Offset = "0x183A4C")]
		public Action<RaycastHit> CollisionCallback;
	}
}
