using System;
using CC;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200034F RID: 847
[Token(Token = "0x2000297")]
public class PopupMercenarySkill : UIPage
{
	// Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x388B68", Offset = "0x388B68", VA = "0x6388B68")]
	public PopupMercenarySkill()
	{
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x388B70", Offset = "0x388B70", VA = "0x6388B70", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x388BE0", Offset = "0x388BE0", VA = "0x6388BE0", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x388CDC", Offset = "0x388CDC", VA = "0x6388CDC")]
	public void OnClose()
	{
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x384B10", Offset = "0x384B10", VA = "0x6384B10")]
	public void ShowSkill(PlayerMonsterData pData)
	{
	}

	// Token: 0x040013A8 RID: 5032
	[Token(Token = "0x40010CA")]
	[FieldOffset(Offset = "0x1C")]
	public Image imgMon;

	// Token: 0x040013A9 RID: 5033
	[Token(Token = "0x40010CB")]
	[FieldOffset(Offset = "0x20")]
	public CharSkillElt[] arrSkillElt;

	// Token: 0x040013AA RID: 5034
	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x0")]
	public static PopupMercenarySkill obj;
}
