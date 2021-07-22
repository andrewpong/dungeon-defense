using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x2000227")]
	public class LightningParticleSpellScript : LightningSpellScript, ICollisionHandler
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x2E5AC0", Offset = "0x2E5AC0", VA = "0x62E5AC0")]
		public LightningParticleSpellScript()
		{
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x2E5C48", Offset = "0x2E5C48", VA = "0x62E5C48")]
		private void PopulateParticleLight(Light src)
		{
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x2E5DF8", Offset = "0x2E5DF8", VA = "0x62E5DF8")]
		private void UpdateParticleLights()
		{
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x2E61F8", Offset = "0x2E61F8", VA = "0x62E61F8")]
		private void UpdateParticleSystems()
		{
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x2E64FC", Offset = "0x2E64FC", VA = "0x62E64FC", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x2E6678", Offset = "0x2E6678", VA = "0x62E6678", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x2E6734", Offset = "0x2E6734", VA = "0x62E6734", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x2E6844", Offset = "0x2E6844", VA = "0x62E6844", Slot = "8")]
		protected override void OnCastSpell()
		{
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x2E6900", Offset = "0x2E6900", VA = "0x62E6900", Slot = "9")]
		protected override void OnStopSpell()
		{
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x2E69B4", Offset = "0x2E69B4", VA = "0x62E69B4", Slot = "12")]
		private void HandleCollision(GameObject obj, List<ParticleCollisionEvent> collisions, int collisionCount)
		{
		}

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183A90", Offset = "0x183A90")]
		public ParticleSystem ParticleSystem;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183ACC", Offset = "0x183ACC")]
		public float CollisionInterval;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x78")]
		protected float collisionTimer;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "HideInInspector", RVA = "0x183B00", Offset = "0x183B00")]
		public Action<GameObject, List<ParticleCollisionEvent>, int> CollisionCallback;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183B10", Offset = "0x183B10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183B10", Offset = "0x183B10")]
		public bool EnableParticleLights;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x183BB0", Offset = "0x183BB0")]
		public RangeOfFloats ParticleLightRange;

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "SingleLineClampAttribute", RVA = "0x183C30", Offset = "0x183C30")]
		public RangeOfFloats ParticleLightIntensity;

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183CB8", Offset = "0x183CB8")]
		public Color ParticleLightColor1;

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183CEC", Offset = "0x183CEC")]
		public Color ParticleLightColor2;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183D20", Offset = "0x183D20")]
		public LayerMask ParticleLightCullingMask;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0xB8")]
		private ParticleSystem.Particle[] particles;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0xBC")]
		private readonly List<GameObject> particleLights;
	}
}
