using System;
using System.Collections.Generic;
using CC;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200030C RID: 780
[Token(Token = "0x2000277")]
[Attribute(Name = "RequireComponent", RVA = "0x17F4A4", Offset = "0x17F4A4")]
[Attribute(Name = "RequireComponent", RVA = "0x17F4A4", Offset = "0x17F4A4")]
public class Enemy : MonoBehaviour
{
	// Token: 0x06001170 RID: 4464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x2F0A48", Offset = "0x2F0A48", VA = "0x62F0A48")]
	public Enemy()
	{
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06001171 RID: 4465 RVA: 0x00006F78 File Offset: 0x00005178
	[Token(Token = "0x17000148")]
	public Vector3 vPos
	{
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x2F0BF4", Offset = "0x2F0BF4", VA = "0x62F0BF4")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06001172 RID: 4466 RVA: 0x00006F90 File Offset: 0x00005190
	[Token(Token = "0x17000149")]
	public bool isDivine
	{
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x2F0D08", Offset = "0x2F0D08", VA = "0x62F0D08")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06001173 RID: 4467 RVA: 0x00006FA8 File Offset: 0x000051A8
	[Token(Token = "0x1700014A")]
	public bool isHide
	{
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x2F0D10", Offset = "0x2F0D10", VA = "0x62F0D10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06001174 RID: 4468 RVA: 0x00006FC0 File Offset: 0x000051C0
	[Token(Token = "0x1700014B")]
	public bool isInvincible
	{
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x2F0D18", Offset = "0x2F0D18", VA = "0x62F0D18")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06001175 RID: 4469 RVA: 0x00006FD8 File Offset: 0x000051D8
	[Token(Token = "0x1700014C")]
	public bool isProtected
	{
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x2F0E28", Offset = "0x2F0E28", VA = "0x62F0E28")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06001176 RID: 4470 RVA: 0x00006FF0 File Offset: 0x000051F0
	[Token(Token = "0x1700014D")]
	public bool isTaunt
	{
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x2F0E3C", Offset = "0x2F0E3C", VA = "0x62F0E3C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06001177 RID: 4471 RVA: 0x00007008 File Offset: 0x00005208
	[Token(Token = "0x1700014E")]
	public bool isReflect
	{
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x2F0E44", Offset = "0x2F0E44", VA = "0x62F0E44")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x2F0E4C", Offset = "0x2F0E4C", VA = "0x62F0E4C")]
	private void Awake()
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x2F0EF0", Offset = "0x2F0EF0", VA = "0x62F0EF0")]
	public void SetEnemy(short _sID, int nDiff, int nDay, bool _bBoss = false)
	{
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x2F33EC", Offset = "0x2F33EC", VA = "0x62F33EC")]
	public void SetStop()
	{
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x2F2F3C", Offset = "0x2F2F3C", VA = "0x62F2F3C")]
	public Enemy AddMutation(MutateType eID, float fActive, float fTime = 0f)
	{
		return null;
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x0600117C RID: 4476 RVA: 0x00007020 File Offset: 0x00005220
	[Token(Token = "0x1700014F")]
	public bool isDead
	{
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x2F3498", Offset = "0x2F3498", VA = "0x62F3498")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x0600117D RID: 4477 RVA: 0x00007038 File Offset: 0x00005238
	[Token(Token = "0x17000150")]
	public bool isClose
	{
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x2F34A0", Offset = "0x2F34A0", VA = "0x62F34A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x2F3500", Offset = "0x2F3500", VA = "0x62F3500")]
	private void Update()
	{
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00007050 File Offset: 0x00005250
	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x2F0D54", Offset = "0x2F0D54", VA = "0x62F0D54")]
	public bool CheckMutate(MutateType eID)
	{
		return default(bool);
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x2F540C", Offset = "0x2F540C", VA = "0x62F540C")]
	public void SetCursed(bool _bCursed)
	{
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x2F4DD0", Offset = "0x2F4DD0", VA = "0x62F4DD0")]
	public void OnActiveMut(MutateType eID)
	{
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x2F50A0", Offset = "0x2F50A0", VA = "0x62F50A0")]
	public void OnDeactiveMut(MutateType eID)
	{
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x2F599C", Offset = "0x2F599C", VA = "0x62F599C")]
	public void SetInvincible(float fTime)
	{
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x2F5A78", Offset = "0x2F5A78", VA = "0x62F5A78")]
	public void Shoot()
	{
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x2F5B94", Offset = "0x2F5B94", VA = "0x62F5B94")]
	public void OnCastComplete()
	{
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x2F5CB0", Offset = "0x2F5CB0", VA = "0x62F5CB0")]
	public void OnCastEffect()
	{
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x2F5134", Offset = "0x2F5134", VA = "0x62F5134")]
	private void Stop()
	{
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x2F5CB4", Offset = "0x2F5CB4", VA = "0x62F5CB4")]
	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x2F5460", Offset = "0x2F5460", VA = "0x62F5460")]
	public void SetDamage(double fDmg)
	{
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x2F5E18", Offset = "0x2F5E18", VA = "0x62F5E18")]
	public void SetKnockback(float fKnockback)
	{
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x2F5EB4", Offset = "0x2F5EB4", VA = "0x62F5EB4")]
	public void SetStun(float fTime)
	{
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x2F52A4", Offset = "0x2F52A4", VA = "0x62F52A4")]
	public void SetEntangle(float fTime)
	{
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x2F6038", Offset = "0x2F6038", VA = "0x62F6038")]
	public void SetPolymorph(double fFac)
	{
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001002")]
	[Address(RVA = "0x2F2CE8", Offset = "0x2F2CE8", VA = "0x62F2CE8")]
	public void EndStun()
	{
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001003")]
	[Address(RVA = "0x2F2C8C", Offset = "0x2F2C8C", VA = "0x62F2C8C")]
	public void EndEntangle()
	{
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06001190 RID: 4496 RVA: 0x00007068 File Offset: 0x00005268
	[Token(Token = "0x17000151")]
	public bool isStun
	{
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x2F525C", Offset = "0x2F525C", VA = "0x62F525C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06001191 RID: 4497 RVA: 0x00007080 File Offset: 0x00005280
	[Token(Token = "0x17000152")]
	public bool isEntangle
	{
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x2F528C", Offset = "0x2F528C", VA = "0x62F528C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x2F2D44", Offset = "0x2F2D44", VA = "0x62F2D44")]
	public void SetSlow(float fFac)
	{
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x2F3178", Offset = "0x2F3178", VA = "0x62F3178")]
	public void UpdateHealthbar()
	{
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x2F61FC", Offset = "0x2F61FC", VA = "0x62F61FC")]
	public void SetTakeDmg(float fAdd)
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x2F6298", Offset = "0x2F6298", VA = "0x62F6298")]
	public void SetTakeDmg2(float fAdd)
	{
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x2F6334", Offset = "0x2F6334", VA = "0x62F6334")]
	public void OnSleep()
	{
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100B")]
	[Address(RVA = "0x2F639C", Offset = "0x2F639C", VA = "0x62F639C")]
	public void OnWakeUp()
	{
	}

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0xC")]
	public Rigidbody2D rigid;

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer hpbar;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer hpbarBack;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0x18")]
	public ParticleElt psInvincible;

	// Token: 0x04000F56 RID: 3926
	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3 vAddPos;

	// Token: 0x04000F57 RID: 3927
	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer sr;

	// Token: 0x04000F58 RID: 3928
	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x20")]
	private Animator animator;

	// Token: 0x04000F59 RID: 3929
	[Token(Token = "0x4000DAA")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 movePos;

	// Token: 0x04000F5A RID: 3930
	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 moveZigPos;

	// Token: 0x04000F5B RID: 3931
	[Token(Token = "0x4000DAC")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A80", Offset = "0x184A80")]
	public double hp;

	// Token: 0x04000F5C RID: 3932
	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x184A90", Offset = "0x184A90")]
	public double maxhp;

	// Token: 0x04000F5D RID: 3933
	[Token(Token = "0x4000DAE")]
	[FieldOffset(Offset = "0x48")]
	private bool bDead;

	// Token: 0x04000F5E RID: 3934
	[Token(Token = "0x4000DAF")]
	[FieldOffset(Offset = "0x4C")]
	private float fDeadTime;

	// Token: 0x04000F5F RID: 3935
	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x50")]
	private float fSpeed;

	// Token: 0x04000F60 RID: 3936
	[Token(Token = "0x4000DB1")]
	[FieldOffset(Offset = "0x54")]
	private float fZigSpd;

	// Token: 0x04000F61 RID: 3937
	[Token(Token = "0x4000DB2")]
	[FieldOffset(Offset = "0x58")]
	private bool bAttack;

	// Token: 0x04000F62 RID: 3938
	[Token(Token = "0x4000DB3")]
	[FieldOffset(Offset = "0x59")]
	private bool bRange;

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x5A")]
	private bool bZigZag;

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x5B")]
	[Attribute(Name = "HideInInspector", RVA = "0x184AA0", Offset = "0x184AA0")]
	public bool bBoss;

	// Token: 0x04000F65 RID: 3941
	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184AB0", Offset = "0x184AB0")]
	public bool bAtkDungeon;

	// Token: 0x04000F66 RID: 3942
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x60")]
	private float fAtkTimer;

	// Token: 0x04000F67 RID: 3943
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x64")]
	private float fAtkCool;

	// Token: 0x04000F68 RID: 3944
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x68")]
	private float fMoveTimer;

	// Token: 0x04000F69 RID: 3945
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x6C")]
	private float fStopTimer;

	// Token: 0x04000F6A RID: 3946
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "HideInInspector", RVA = "0x184AC0", Offset = "0x184AC0")]
	public float fTakeDmg;

	// Token: 0x04000F6B RID: 3947
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "HideInInspector", RVA = "0x184AD0", Offset = "0x184AD0")]
	public float fTakeDmg2;

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "HideInInspector", RVA = "0x184AE0", Offset = "0x184AE0")]
	public float fGiveDmg;

	// Token: 0x04000F6D RID: 3949
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184AF0", Offset = "0x184AF0")]
	public float fRange;

	// Token: 0x04000F6E RID: 3950
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B00", Offset = "0x184B00")]
	public int nDropGold;

	// Token: 0x04000F6F RID: 3951
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B10", Offset = "0x184B10")]
	public int nExp;

	// Token: 0x04000F70 RID: 3952
	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B20", Offset = "0x184B20")]
	public MoveType eMove;

	// Token: 0x04000F71 RID: 3953
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B30", Offset = "0x184B30")]
	public float fDmg;

	// Token: 0x04000F72 RID: 3954
	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B40", Offset = "0x184B40")]
	public ArmorType eArmor;

	// Token: 0x04000F73 RID: 3955
	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B50", Offset = "0x184B50")]
	public short sID;

	// Token: 0x04000F74 RID: 3956
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x96")]
	private bool bDivine;

	// Token: 0x04000F75 RID: 3957
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0x97")]
	private bool bHide;

	// Token: 0x04000F76 RID: 3958
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x98")]
	private bool bTryAttack;

	// Token: 0x04000F77 RID: 3959
	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x9C")]
	public Transform trCastGuage;

	// Token: 0x04000F78 RID: 3960
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject goCastGuage;

	// Token: 0x04000F79 RID: 3961
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0xA4")]
	public SpriteRenderer srCastFill;

	// Token: 0x04000F7A RID: 3962
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0xA8")]
	private float fInvincibleDur;

	// Token: 0x04000F7B RID: 3963
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0xAC")]
	private float fStunReduce;

	// Token: 0x04000F7C RID: 3964
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0xB0")]
	private float fEntangleReduce;

	// Token: 0x04000F7D RID: 3965
	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "HideInInspector", RVA = "0x184B60", Offset = "0x184B60")]
	public float fSlowRate;

	// Token: 0x04000F7E RID: 3966
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0xB8")]
	private MutateType eGuageMut;

	// Token: 0x04000F7F RID: 3967
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0xBC")]
	private List<MutateType> listMut;

	// Token: 0x04000F80 RID: 3968
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<MutateType, float> dictMutTimer;

	// Token: 0x04000F81 RID: 3969
	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0xC4")]
	private Dictionary<MutateType, float> dictMutActive;

	// Token: 0x04000F82 RID: 3970
	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<MutateType, float> dictMutDur;

	// Token: 0x04000F83 RID: 3971
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0xCC")]
	private Dictionary<MutateType, float> dictMutTime;

	// Token: 0x04000F84 RID: 3972
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0xD0")]
	private int nProtect;

	// Token: 0x04000F85 RID: 3973
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0xD4")]
	private Vector2 vKnockback;

	// Token: 0x04000F86 RID: 3974
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0xC")]
	private static Color colorHide;

	// Token: 0x04000F87 RID: 3975
	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0xDC")]
	public bool bNatureObs;

	// Token: 0x04000F88 RID: 3976
	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0xDD")]
	public bool bCursed;

	// Token: 0x04000F89 RID: 3977
	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0xE0")]
	public float fHPRate;

	// Token: 0x04000F8A RID: 3978
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0xE8")]
	private double dMaxHPDivider;

	// Token: 0x04000F8B RID: 3979
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0xF0")]
	private bool bClose;

	// Token: 0x04000F8C RID: 3980
	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0xF4")]
	private float fStunDur;

	// Token: 0x04000F8D RID: 3981
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0xF8")]
	private Coroutine cr;

	// Token: 0x04000F8E RID: 3982
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0xFC")]
	private float fEntangleDur;

	// Token: 0x04000F8F RID: 3983
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x100")]
	private Vector2 vMove;
}
