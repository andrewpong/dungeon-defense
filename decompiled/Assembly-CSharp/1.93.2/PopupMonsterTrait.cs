using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000351 RID: 849
[Token(Token = "0x2000299")]
public class PopupMonsterTrait : UIPage
{
	// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x38905C", Offset = "0x38905C", VA = "0x638905C")]
	public PopupMonsterTrait()
	{
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x0600153E RID: 5438 RVA: 0x00008628 File Offset: 0x00006828
	[Token(Token = "0x17000199")]
	private int nInitCost
	{
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x38906C", Offset = "0x38906C", VA = "0x638906C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x3891A8", Offset = "0x3891A8", VA = "0x63891A8", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x38AF70", Offset = "0x38AF70", VA = "0x638AF70", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x38B10C", Offset = "0x38B10C", VA = "0x638B10C")]
	public void OnInit()
	{
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x38B328", Offset = "0x38B328", VA = "0x638B328")]
	public void OnRealInit()
	{
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x38B6E4", Offset = "0x38B6E4", VA = "0x638B6E4")]
	public void MoveTree(int n)
	{
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x3893E0", Offset = "0x3893E0", VA = "0x63893E0")]
	public void RefreshTree()
	{
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x389E14", Offset = "0x389E14", VA = "0x6389E14")]
	public void RefreshDetail(MonTraitElt elt)
	{
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x38B06C", Offset = "0x38B06C", VA = "0x638B06C")]
	public void OnClose()
	{
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x38B894", Offset = "0x38B894", VA = "0x638B894")]
	public void OnSelected(MonTraitElt elt)
	{
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x38B9D8", Offset = "0x38B9D8", VA = "0x638B9D8")]
	public void OnLearnTrait()
	{
	}

	// Token: 0x040013AD RID: 5037
	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x0")]
	public static PopupMonsterTrait obj;

	// Token: 0x040013AE RID: 5038
	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject[] arrCharacterTree;

	// Token: 0x040013AF RID: 5039
	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x20")]
	public MonTraitElt[] arrMonTraitElt;

	// Token: 0x040013B0 RID: 5040
	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x24")]
	public Text textTitle;

	// Token: 0x040013B1 RID: 5041
	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x28")]
	public Image imgBackMonster;

	// Token: 0x040013B2 RID: 5042
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x2C")]
	public Image imgDetailMonsterIcon;

	// Token: 0x040013B3 RID: 5043
	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x30")]
	public Image imgDetailTraitIcon;

	// Token: 0x040013B4 RID: 5044
	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x34")]
	public Text textDetailTraitName;

	// Token: 0x040013B5 RID: 5045
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x38")]
	public Text textDetailTraitDesc;

	// Token: 0x040013B6 RID: 5046
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x3C")]
	public Text textDetailTraitWarn;

	// Token: 0x040013B7 RID: 5047
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x40")]
	public Text textDetailLearnBtn;

	// Token: 0x040013B8 RID: 5048
	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x44")]
	public Button btnDetailLearn;

	// Token: 0x040013B9 RID: 5049
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x48")]
	public Text textTraitPoints;

	// Token: 0x040013BA RID: 5050
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x4C")]
	public Text textInitButton;

	// Token: 0x040013BB RID: 5051
	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x50")]
	public Text textInitNeed;

	// Token: 0x040013BC RID: 5052
	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x54")]
	public GameObject goInitNeed;

	// Token: 0x040013BD RID: 5053
	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x58")]
	public GameObject goInitButton;

	// Token: 0x040013BE RID: 5054
	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x5C")]
	private MonTraitElt currentElt;

	// Token: 0x040013BF RID: 5055
	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x60")]
	private int nCurrentMon;

	// Token: 0x040013C0 RID: 5056
	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0x64")]
	private short sID;
}
