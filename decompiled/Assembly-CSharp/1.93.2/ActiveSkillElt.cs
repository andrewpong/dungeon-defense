using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C2 RID: 706
[Token(Token = "0x200022F")]
public class ActiveSkillElt : MonoBehaviour
{
	// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x2827F0", Offset = "0x2827F0", VA = "0x62827F0")]
	public ActiveSkillElt()
	{
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00006D80 File Offset: 0x00004F80
	// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000140")]
	private bool bActive
	{
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x2827F8", Offset = "0x2827F8", VA = "0x62827F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x282824", Offset = "0x282824", VA = "0x6282824")]
		set
		{
		}
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x2828A4", Offset = "0x2828A4", VA = "0x62828A4")]
	public void SetSkill(int _nPos, SkillKey _eSkill)
	{
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x282A94", Offset = "0x282A94", VA = "0x6282A94")]
	private void ActiveElt(bool bEnable)
	{
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x282B18", Offset = "0x282B18", VA = "0x6282B18")]
	public void UpdateGuage(float fG, bool bUpdate, bool bAuto = false)
	{
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x28322C", Offset = "0x28322C", VA = "0x628322C")]
	public void OnClick()
	{
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x283630", Offset = "0x283630", VA = "0x6283630")]
	public void OnUsed()
	{
	}

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x10")]
	public Image imgCool;

	// Token: 0x040009BA RID: 2490
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x14")]
	public Image imgHighlight;

	// Token: 0x040009BB RID: 2491
	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x18")]
	private int nPos;

	// Token: 0x040009BC RID: 2492
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x1C")]
	private float fMax;

	// Token: 0x040009BD RID: 2493
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x20")]
	private float fTime;

	// Token: 0x040009BE RID: 2494
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x24")]
	private SkillKey eSkill;
}
