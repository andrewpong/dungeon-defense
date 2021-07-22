using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x2000225")]
	public interface ICollisionHandler
	{
		// Token: 0x06001086 RID: 4230
		[Token(Token = "0x6000F18")]
		void HandleCollision(GameObject obj, List<ParticleCollisionEvent> collision, int collisionCount);
	}
}
