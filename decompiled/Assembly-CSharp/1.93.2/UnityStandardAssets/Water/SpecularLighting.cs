using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x20001F2")]
	[Attribute(Name = "RequireComponent", RVA = "0x17F274", Offset = "0x17F274")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x17F274", Offset = "0x17F274")]
	public class SpecularLighting : MonoBehaviour
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0xBD8D20", Offset = "0xBD8D20", VA = "0x6BD8D20")]
		public SpecularLighting()
		{
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0xBD8D28", Offset = "0xBD8D28", VA = "0x6BD8D28")]
		public void Start()
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0xBD8E44", Offset = "0xBD8E44", VA = "0x6BD8E44")]
		public void Update()
		{
		}

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0xC")]
		public Transform specularLight;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x10")]
		private WaterBase m_WaterBase;
	}
}
