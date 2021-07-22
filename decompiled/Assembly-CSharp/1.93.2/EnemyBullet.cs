using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200030D RID: 781
[Token(Token = "0x2000278")]
public class EnemyBullet : MonoBehaviour
{
	// Token: 0x06001199 RID: 4505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100D")]
	[Address(RVA = "0x2F64DC", Offset = "0x2F64DC", VA = "0x62F64DC")]
	public EnemyBullet()
	{
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x2F6580", Offset = "0x2F6580", VA = "0x62F6580")]
	public void SetBullet(float _fDmg, float _fSpd, Enemy _em)
	{
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x2F6594", Offset = "0x2F6594", VA = "0x62F6594")]
	private void Update()
	{
	}

	// Token: 0x04000F90 RID: 3984
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B70", Offset = "0x184B70")]
	public float fDmg;

	// Token: 0x04000F91 RID: 3985
	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 vMove;

	// Token: 0x04000F92 RID: 3986
	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B80", Offset = "0x184B80")]
	public Enemy em;
}
