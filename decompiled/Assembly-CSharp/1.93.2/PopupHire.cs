using System;
using System.Collections.Generic;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200034E RID: 846
[Token(Token = "0x2000296")]
public class PopupHire : UIPage
{
	// Token: 0x0600152E RID: 5422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x387650", Offset = "0x387650", VA = "0x6387650")]
	public PopupHire()
	{
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x3876DC", Offset = "0x3876DC", VA = "0x63876DC", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x388764", Offset = "0x388764", VA = "0x6388764", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x3888F8", Offset = "0x3888F8", VA = "0x63888F8")]
	public void OnHire(int nPos)
	{
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x388A1C", Offset = "0x388A1C", VA = "0x6388A1C")]
	public void OnShowSkill(int nPos)
	{
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x388860", Offset = "0x388860", VA = "0x6388860")]
	public void OnClose()
	{
	}

	// Token: 0x0400139F RID: 5023
	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x1C")]
	public Text textTitle;

	// Token: 0x040013A0 RID: 5024
	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x20")]
	public Text[] textBtnHire;

	// Token: 0x040013A1 RID: 5025
	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x24")]
	public Text[] textBtnSkill;

	// Token: 0x040013A2 RID: 5026
	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x28")]
	public Text[] textUnitName;

	// Token: 0x040013A3 RID: 5027
	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x2C")]
	public Text[] textHireCost;

	// Token: 0x040013A4 RID: 5028
	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x30")]
	public Image[] imgHireUnit;

	// Token: 0x040013A5 RID: 5029
	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x34")]
	public GameObject[] goUnitPanel;

	// Token: 0x040013A6 RID: 5030
	[Token(Token = "0x40010C8")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform rtContent;

	// Token: 0x040013A7 RID: 5031
	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x3C")]
	private List<PlayerMonsterData> listData;
}
