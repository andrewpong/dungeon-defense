using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CA RID: 714
[Token(Token = "0x2000236")]
[Attribute(Name = "RequireComponent", RVA = "0x17F42C", Offset = "0x17F42C")]
public class Bullet : MonoBehaviour
{
	// Token: 0x06001123 RID: 4387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x28FC88", Offset = "0x28FC88", VA = "0x628FC88")]
	public Bullet()
	{
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x28FD3C", Offset = "0x28FD3C", VA = "0x628FD3C")]
	private void SetStat(float fDmg, float vsA, float vsM, float _fSpd, int _nPen)
	{
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x290418", Offset = "0x290418", VA = "0x6290418")]
	private void CalcMonsterBonus()
	{
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x2907C4", Offset = "0x2907C4", VA = "0x62907C4")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x290974", Offset = "0x290974", VA = "0x6290974")]
	private void OnBecameInvisible()
	{
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x290A34", Offset = "0x290A34", VA = "0x6290A34")]
	private void ResetImage(ItemData data)
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x29101C", Offset = "0x29101C", VA = "0x629101C")]
	public Bullet SetTarget(Monster _pMon, TrailType _eTrail, BulletType _eType, Vector2 _vPos, BattleItemData data, float fDmg, bool _bCri, bool _bHuge, bool bAssasin, bool _bCursed, bool _bSpinning, int _nRicochet, float fSpdBonus = 1f)
	{
		return null;
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x291560", Offset = "0x291560", VA = "0x6291560")]
	public Bullet SetTarget(Monster _pMon, TrailType _eTrail, BulletType _eType, Vector2 _vPos, ItemData data, float fDmg, bool _bHuge = false)
	{
		return null;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x291650", Offset = "0x291650", VA = "0x6291650")]
	public void ResetTarget(Vector2 vPos)
	{
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x2917EC", Offset = "0x2917EC", VA = "0x62917EC")]
	public void AddPower(float fPlus, float fMul)
	{
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x291810", Offset = "0x291810", VA = "0x6291810")]
	public void OnDisabled()
	{
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x291820", Offset = "0x291820", VA = "0x6291820")]
	public void OnImpact(Enemy em)
	{
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x291FB8", Offset = "0x291FB8", VA = "0x6291FB8")]
	public void OnKill()
	{
	}

	// Token: 0x04000A0D RID: 2573
	[Token(Token = "0x4000864")]
	[FieldOffset(Offset = "0xC")]
	private float fSpd;

	// Token: 0x04000A0E RID: 2574
	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HideInInspector", RVA = "0x184950", Offset = "0x184950")]
	public float fPow;

	// Token: 0x04000A0F RID: 2575
	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HideInInspector", RVA = "0x184960", Offset = "0x184960")]
	public float fDmgArmor;

	// Token: 0x04000A10 RID: 2576
	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HideInInspector", RVA = "0x184970", Offset = "0x184970")]
	public float fDmgMagic;

	// Token: 0x04000A11 RID: 2577
	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184980", Offset = "0x184980")]
	public Vector2 vPos;

	// Token: 0x04000A12 RID: 2578
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "HideInInspector", RVA = "0x184990", Offset = "0x184990")]
	public BulletType eType;

	// Token: 0x04000A13 RID: 2579
	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x1849A0", Offset = "0x1849A0")]
	public WeaponType eWeapon;

	// Token: 0x04000A14 RID: 2580
	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "HideInInspector", RVA = "0x1849B0", Offset = "0x1849B0")]
	public TrailType eTrail;

	// Token: 0x04000A15 RID: 2581
	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HideInInspector", RVA = "0x1849C0", Offset = "0x1849C0")]
	public int nPen;

	// Token: 0x04000A16 RID: 2582
	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "HideInInspector", RVA = "0x1849D0", Offset = "0x1849D0")]
	public int nRicochet;

	// Token: 0x04000A17 RID: 2583
	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x1849E0", Offset = "0x1849E0")]
	public Monster pMon;

	// Token: 0x04000A18 RID: 2584
	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "HideInInspector", RVA = "0x1849F0", Offset = "0x1849F0")]
	public bool bHuge;

	// Token: 0x04000A19 RID: 2585
	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x3D")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A00", Offset = "0x184A00")]
	public bool bAssasinate;

	// Token: 0x04000A1A RID: 2586
	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x3E")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A10", Offset = "0x184A10")]
	public bool bCursed;

	// Token: 0x04000A1B RID: 2587
	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x3F")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A20", Offset = "0x184A20")]
	public bool bSpinning;

	// Token: 0x04000A1C RID: 2588
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A30", Offset = "0x184A30")]
	public int nKill;

	// Token: 0x04000A1D RID: 2589
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A40", Offset = "0x184A40")]
	public int nHit;

	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A50", Offset = "0x184A50")]
	public bool bCri;

	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject[] goTrail;

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer srWeapon;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x54")]
	private bool bSpin;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 vMovePos;

	// Token: 0x04000A23 RID: 2595
	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x60")]
	private float fSize;

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A60", Offset = "0x184A60")]
	public int nCreated;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A70", Offset = "0x184A70")]
	public int nDeleted;
}
