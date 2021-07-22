using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000269 RID: 617
[Token(Token = "0x20001DF")]
public class ProjectileScript : MonoBehaviour
{
	// Token: 0x06000EF6 RID: 3830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0xC7F310", Offset = "0xC7F310", VA = "0x6C7F310")]
	public ProjectileScript()
	{
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0xC7F318", Offset = "0xC7F318", VA = "0x6C7F318")]
	private void Start()
	{
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0xC7F494", Offset = "0xC7F494", VA = "0x6C7F494")]
	private void OnCollisionEnter(Collision hit)
	{
	}

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0xC")]
	public GameObject impactParticle;

	// Token: 0x04000775 RID: 1909
	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x10")]
	public GameObject projectileParticle;

	// Token: 0x04000776 RID: 1910
	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x14")]
	public GameObject[] trailParticles;

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HideInInspector", RVA = "0x181564", Offset = "0x181564")]
	public Vector3 impactNormal;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x24")]
	private bool hasCollided;
}
