using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200028A RID: 650
	[Token(Token = "0x20001FF")]
	public class LightningBoltDependencies
	{
		// Token: 0x06000F90 RID: 3984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x2DBD08", Offset = "0x2DBD08", VA = "0x62DBD08")]
		public LightningBoltDependencies()
		{
		}

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x8")]
		public GameObject Parent;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0xC")]
		public Material LightningMaterialMesh;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x10")]
		public Material LightningMaterialMeshNoGlow;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x14")]
		public ParticleSystem OriginParticleSystem;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x18")]
		public ParticleSystem DestParticleSystem;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 CameraPos;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x28")]
		public bool CameraIsOrthographic;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x40006EA")]
		[FieldOffset(Offset = "0x2C")]
		public CameraMode CameraMode;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x30")]
		public bool UseWorldSpace;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x34")]
		public string SortLayerName;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x38")]
		public int SortOrderInLayer;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x3C")]
		public ICollection<LightningBoltParameters> Parameters;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x40")]
		public LightningThreadState ThreadState;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x44")]
		public Func<IEnumerator, Coroutine> StartCoroutine;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x48")]
		public Action<Light> LightAdded;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x4C")]
		public Action<Light> LightRemoved;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x50")]
		public Action<LightningBolt> AddActiveBolt;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x54")]
		public Action<LightningBoltDependencies> ReturnToCache;
	}
}
