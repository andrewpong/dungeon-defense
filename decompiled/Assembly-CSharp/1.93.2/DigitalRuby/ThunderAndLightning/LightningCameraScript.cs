using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x200020A")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x17F32C", Offset = "0x17F32C")]
	public class LightningCameraScript : MonoBehaviour
	{
		// Token: 0x06001018 RID: 4120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x2E1784", Offset = "0x2E1784", VA = "0x62E1784")]
		public LightningCameraScript()
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x2E178C", Offset = "0x2E178C", VA = "0x62E178C")]
		private void Update()
		{
		}

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0xC")]
		public DepthTextureMode DepthTextureMode;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;
	}
}
