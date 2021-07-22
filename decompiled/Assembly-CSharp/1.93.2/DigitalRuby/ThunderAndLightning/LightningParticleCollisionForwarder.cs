using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x2000226")]
	[Attribute(Name = "RequireComponent", RVA = "0x17F3B4", Offset = "0x17F3B4")]
	public class LightningParticleCollisionForwarder : MonoBehaviour
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x2E58A4", Offset = "0x2E58A4", VA = "0x62E58A4")]
		public LightningParticleCollisionForwarder()
		{
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x2E5930", Offset = "0x2E5930", VA = "0x62E5930")]
		private void Start()
		{
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x2E5998", Offset = "0x2E5998", VA = "0x62E5998")]
		private void OnParticleCollision(GameObject other)
		{
		}

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183A5C", Offset = "0x183A5C")]
		public MonoBehaviour CollisionHandler;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x10")]
		private ParticleSystem _particleSystem;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<ParticleCollisionEvent> collisionEvents;
	}
}
