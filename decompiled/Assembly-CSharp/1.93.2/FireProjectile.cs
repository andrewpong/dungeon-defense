using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000266 RID: 614
[Token(Token = "0x20001DC")]
public class FireProjectile : MonoBehaviour
{
	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x2F6738", Offset = "0x2F6738", VA = "0x62F6738")]
	public FireProjectile()
	{
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x2F674C", Offset = "0x2F674C", VA = "0x62F674C")]
	private void Start()
	{
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x2F67E0", Offset = "0x2F67E0", VA = "0x62F67E0")]
	private void Update()
	{
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x2F6E7C", Offset = "0x2F6E7C", VA = "0x62F6E7C")]
	public void nextEffect()
	{
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x2F6EC0", Offset = "0x2F6EC0", VA = "0x62F6EC0")]
	public void previousEffect()
	{
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x2F6EFC", Offset = "0x2F6EFC", VA = "0x62F6EFC")]
	public void AdjustSpeed(float newSpeed)
	{
	}

	// Token: 0x0400076E RID: 1902
	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0xC")]
	private RaycastHit hit;

	// Token: 0x0400076F RID: 1903
	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] projectiles;

	// Token: 0x04000770 RID: 1904
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x3C")]
	public Transform spawnPosition;

	// Token: 0x04000771 RID: 1905
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x181554", Offset = "0x181554")]
	public int currentProjectile;

	// Token: 0x04000772 RID: 1906
	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x44")]
	public float speed;

	// Token: 0x04000773 RID: 1907
	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x48")]
	private ButtonScript selectedProjectileButton;
}
