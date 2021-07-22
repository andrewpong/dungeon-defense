using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C3 RID: 707
[Token(Token = "0x2000230")]
public class AwakenSkillElt : MonoBehaviour
{
	// Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x283850", Offset = "0x283850", VA = "0x6283850")]
	public AwakenSkillElt()
	{
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x060010EB RID: 4331 RVA: 0x00006D98 File Offset: 0x00004F98
	// (set) Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000141")]
	private bool bActive
	{
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x283858", Offset = "0x283858", VA = "0x6283858")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x283884", Offset = "0x283884", VA = "0x6283884")]
		set
		{
		}
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x283904", Offset = "0x283904", VA = "0x6283904")]
	public void SetSkill(int _nPos, SkillKey _eSkill)
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x283A98", Offset = "0x283A98", VA = "0x6283A98")]
	private void ActiveElt(bool bEnable)
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x283B1C", Offset = "0x283B1C", VA = "0x6283B1C")]
	public void UpdateGuage(float fG)
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x283FD0", Offset = "0x283FD0", VA = "0x6283FD0")]
	public void OnClick()
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x28435C", Offset = "0x28435C", VA = "0x628435C")]
	public void OnUsed()
	{
	}

	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x10")]
	public Image imgCool;

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x14")]
	public Image imgHighlight;

	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x18")]
	private int nPos;

	// Token: 0x040009C3 RID: 2499
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x1C")]
	private float fMax;

	// Token: 0x040009C4 RID: 2500
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x20")]
	private float fTime;

	// Token: 0x040009C5 RID: 2501
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x24")]
	private SkillKey eSkill;
}
