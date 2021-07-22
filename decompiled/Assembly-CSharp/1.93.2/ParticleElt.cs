using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000339 RID: 825
[Token(Token = "0x2000284")]
public class ParticleElt : MonoBehaviour
{
	// Token: 0x06001475 RID: 5237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001235")]
	[Address(RVA = "0x363FD4", Offset = "0x363FD4", VA = "0x6363FD4")]
	public ParticleElt()
	{
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001236")]
	[Address(RVA = "0x363FDC", Offset = "0x363FDC", VA = "0x6363FDC")]
	private void Awake()
	{
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001237")]
	[Address(RVA = "0x36412C", Offset = "0x36412C", VA = "0x636412C")]
	public void Play(Vector3 vPos)
	{
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001238")]
	[Address(RVA = "0x3643F0", Offset = "0x3643F0", VA = "0x63643F0")]
	public void Play(Transform tr)
	{
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001239")]
	[Address(RVA = "0x3644C8", Offset = "0x3644C8", VA = "0x63644C8")]
	public void Play(Vector3 vPos, Vector3 vSca)
	{
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123A")]
	[Address(RVA = "0x36462C", Offset = "0x36462C", VA = "0x636462C")]
	public void Play(Vector3 vPos, Quaternion qRot, Vector3 vSca)
	{
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123B")]
	[Address(RVA = "0x364248", Offset = "0x364248", VA = "0x6364248")]
	public void Play(bool bForce = false)
	{
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123C")]
	[Address(RVA = "0x364734", Offset = "0x364734", VA = "0x6364734")]
	public void Stop()
	{
	}

	// Token: 0x040012A6 RID: 4774
	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0xC")]
	public ParticleSystem[] ps;

	// Token: 0x040012A7 RID: 4775
	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x10")]
	public ParticleSystem.EmissionModule[] emm;
}
