using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033A RID: 826
[Token(Token = "0x2000285")]
public class ParticleMgr : MonoBehaviour
{
	// Token: 0x0600147D RID: 5245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123D")]
	[Address(RVA = "0x364838", Offset = "0x364838", VA = "0x6364838")]
	public ParticleMgr()
	{
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123E")]
	[Address(RVA = "0x364840", Offset = "0x364840", VA = "0x6364840")]
	private void Awake()
	{
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x364EA4", Offset = "0x364EA4", VA = "0x6364EA4")]
	public static void Play(string str, Transform tr)
	{
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x365238", Offset = "0x365238", VA = "0x6365238")]
	public static void Play(string str, Vector3 vPos)
	{
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x3653F0", Offset = "0x3653F0", VA = "0x63653F0")]
	public static void Play(string str, Vector3 vPos, Vector3 vSca)
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001242")]
	[Address(RVA = "0x3655B8", Offset = "0x3655B8", VA = "0x63655B8")]
	public static void Play(string str, Vector3 vPos, Quaternion qRot, Vector3 vSca)
	{
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001243")]
	[Address(RVA = "0x3657BC", Offset = "0x3657BC", VA = "0x63657BC")]
	public static void Play(string str)
	{
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001244")]
	[Address(RVA = "0x365044", Offset = "0x365044", VA = "0x6365044")]
	private static void IncNum(string str)
	{
	}

	// Token: 0x040012A8 RID: 4776
	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x0")]
	public static ParticleMgr single;

	// Token: 0x040012A9 RID: 4777
	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0xC")]
	public List<ParticleElt> listPS;

	// Token: 0x040012AA RID: 4778
	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, List<ParticleElt>> dicParticle;

	// Token: 0x040012AB RID: 4779
	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, int> dicNum;

	// Token: 0x040012AC RID: 4780
	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0xC")]
	private static int nMax;

	// Token: 0x040012AD RID: 4781
	[Token(Token = "0x4000FE0")]
	[FieldOffset(Offset = "0x10")]
	private static bool bLoaded;
}
