using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C8 RID: 712
[Token(Token = "0x2000234")]
public class BattleLaserElt : MonoBehaviour
{
	// Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x28E844", Offset = "0x28E844", VA = "0x628E844")]
	public BattleLaserElt()
	{
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x28E858", Offset = "0x28E858", VA = "0x628E858")]
	private void Awake()
	{
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x28E888", Offset = "0x28E888", VA = "0x628E888")]
	private void Update()
	{
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x28E9FC", Offset = "0x28E9FC", VA = "0x628E9FC")]
	public void OnCreated(float _fSize, Vector3 vStart, Vector3 vEnd)
	{
	}

	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0xC")]
	public LineRenderer line;

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HideInInspector", RVA = "0x184930", Offset = "0x184930")]
	public bool bCreated;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HideInInspector", RVA = "0x184940", Offset = "0x184940")]
	public float fSize;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x18")]
	private float fOriSize;
}
