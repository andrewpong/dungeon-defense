using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000278 RID: 632
	[Token(Token = "0x20001ED")]
	public class DemoScriptTriggerPath : MonoBehaviour
	{
		// Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x3C8F68", Offset = "0x3C8F68", VA = "0x63C8F68")]
		public DemoScriptTriggerPath()
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x3C8FF4", Offset = "0x3C8FF4", VA = "0x63C8FF4")]
		private void Start()
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x3C901C", Offset = "0x3C901C", VA = "0x63C901C")]
		private void Update()
		{
		}

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0xC")]
		public LightningSplineScript Script;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x10")]
		public Toggle SplineToggle;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<Vector3> points;
	}
}
