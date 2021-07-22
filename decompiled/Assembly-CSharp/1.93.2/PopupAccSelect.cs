using System;
using System.Collections.Generic;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200033C RID: 828
[Token(Token = "0x2000287")]
public class PopupAccSelect : UIPage
{
	// Token: 0x06001496 RID: 5270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001256")]
	[Address(RVA = "0x368468", Offset = "0x368468", VA = "0x6368468")]
	public PopupAccSelect()
	{
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06001497 RID: 5271 RVA: 0x00008538 File Offset: 0x00006738
	// (set) Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000193")]
	private long nMedal
	{
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x36852C", Offset = "0x36852C", VA = "0x636852C")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x368630", Offset = "0x368630", VA = "0x6368630")]
		set
		{
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06001499 RID: 5273 RVA: 0x00008550 File Offset: 0x00006750
	// (set) Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000194")]
	private long nStone
	{
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x3687A4", Offset = "0x3687A4", VA = "0x63687A4")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x600125A")]
		[Address(RVA = "0x3688A8", Offset = "0x3688A8", VA = "0x63688A8")]
		set
		{
		}
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125B")]
	[Address(RVA = "0x368A1C", Offset = "0x368A1C", VA = "0x6368A1C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125C")]
	[Address(RVA = "0x368E5C", Offset = "0x368E5C", VA = "0x6368E5C", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125D")]
	[Address(RVA = "0x3690F0", Offset = "0x3690F0", VA = "0x63690F0")]
	public void AccSelectMode(bool bRing)
	{
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125E")]
	[Address(RVA = "0x36C994", Offset = "0x36C994", VA = "0x636C994")]
	public void AccSellMode()
	{
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125F")]
	[Address(RVA = "0x36CE1C", Offset = "0x36CE1C", VA = "0x636CE1C")]
	public void AccEnchantMode()
	{
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001260")]
	[Address(RVA = "0x36D2A4", Offset = "0x36D2A4", VA = "0x636D2A4")]
	public void SellMode(bool bSort = false)
	{
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x36C6B0", Offset = "0x36C6B0", VA = "0x636C6B0")]
	private void RefreshButton()
	{
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001262")]
	[Address(RVA = "0x369A3C", Offset = "0x369A3C", VA = "0x6369A3C")]
	private void ReallocElt(int nCount)
	{
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x36A05C", Offset = "0x36A05C", VA = "0x636A05C")]
	public void RefreshDetailAcc(long uid, bool bRing = false)
	{
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x36C548", Offset = "0x36C548", VA = "0x636C548")]
	private void RefreshHighlight()
	{
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x36D644", Offset = "0x36D644", VA = "0x636D644")]
	public void OnClick(long uid, bool bRing)
	{
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001266")]
	[Address(RVA = "0x368F68", Offset = "0x368F68", VA = "0x6368F68")]
	public void OnClose()
	{
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001267")]
	[Address(RVA = "0x36D674", Offset = "0x36D674", VA = "0x636D674")]
	public void OnButtonA()
	{
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x36F410", Offset = "0x36F410", VA = "0x636F410")]
	public void OnButtonB()
	{
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x36F420", Offset = "0x36F420", VA = "0x636F420")]
	public void OnButtonC()
	{
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x36F424", Offset = "0x36F424", VA = "0x636F424")]
	private void OnProtect()
	{
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126B")]
	[Address(RVA = "0x36E854", Offset = "0x36E854", VA = "0x636E854")]
	private void PlayerItemSell()
	{
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126C")]
	[Address(RVA = "0x36D69C", Offset = "0x36D69C", VA = "0x636D69C")]
	private void EquipOrUnequip()
	{
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126D")]
	[Address(RVA = "0x36DFE8", Offset = "0x36DFE8", VA = "0x636DFE8")]
	public void OnAccEnchant()
	{
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x00008568 File Offset: 0x00006768
	[Token(Token = "0x600126E")]
	[Address(RVA = "0x36FDC8", Offset = "0x36FDC8", VA = "0x636FDC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187C7C", Offset = "0x187C7C")]
	private static int <Awake>m__0(PlayerAccData x, PlayerAccData y)
	{
		return 0;
	}

	// Token: 0x040012CB RID: 4811
	[Token(Token = "0x4000FFE")]
	[FieldOffset(Offset = "0x0")]
	public static PopupAccSelect obj;

	// Token: 0x040012CC RID: 4812
	[Token(Token = "0x4000FFF")]
	[FieldOffset(Offset = "0x1C")]
	public StringTooltip strTooltip;

	// Token: 0x040012CD RID: 4813
	[Token(Token = "0x4001000")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goLeftItem;

	// Token: 0x040012CE RID: 4814
	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goRightItem;

	// Token: 0x040012CF RID: 4815
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0x28")]
	public AccElt eltAccDetailL;

	// Token: 0x040012D0 RID: 4816
	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x2C")]
	public AccElt eltAccDetailR;

	// Token: 0x040012D1 RID: 4817
	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x30")]
	public Text textItemNameL;

	// Token: 0x040012D2 RID: 4818
	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x34")]
	public Text textItemNameR;

	// Token: 0x040012D3 RID: 4819
	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0x38")]
	public Text textItemGradeL;

	// Token: 0x040012D4 RID: 4820
	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x3C")]
	public Text textItemGradeR;

	// Token: 0x040012D5 RID: 4821
	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0x40")]
	public Text textItemDescL;

	// Token: 0x040012D6 RID: 4822
	[Token(Token = "0x4001009")]
	[FieldOffset(Offset = "0x44")]
	public Text textItemDescR;

	// Token: 0x040012D7 RID: 4823
	[Token(Token = "0x400100A")]
	[FieldOffset(Offset = "0x48")]
	public Text textItemOnlyL;

	// Token: 0x040012D8 RID: 4824
	[Token(Token = "0x400100B")]
	[FieldOffset(Offset = "0x4C")]
	public Text textItemOnlyR;

	// Token: 0x040012D9 RID: 4825
	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0x50")]
	public Text textBtnA;

	// Token: 0x040012DA RID: 4826
	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x54")]
	public Text textBtnB;

	// Token: 0x040012DB RID: 4827
	[Token(Token = "0x400100E")]
	[FieldOffset(Offset = "0x58")]
	public Text textBtnC;

	// Token: 0x040012DC RID: 4828
	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0x5C")]
	public Text textMedal;

	// Token: 0x040012DD RID: 4829
	[Token(Token = "0x4001010")]
	[FieldOffset(Offset = "0x60")]
	public Text textStone;

	// Token: 0x040012DE RID: 4830
	[Token(Token = "0x4001011")]
	[FieldOffset(Offset = "0x64")]
	public Text textTitle;

	// Token: 0x040012DF RID: 4831
	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0x68")]
	public Text textEnchantMedal;

	// Token: 0x040012E0 RID: 4832
	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x6C")]
	public Text textEnchantStone;

	// Token: 0x040012E1 RID: 4833
	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x70")]
	public GameObject objElt;

	// Token: 0x040012E2 RID: 4834
	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0x74")]
	public GameObject goMedal;

	// Token: 0x040012E3 RID: 4835
	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x78")]
	public GameObject goStone;

	// Token: 0x040012E4 RID: 4836
	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject goBtnA;

	// Token: 0x040012E5 RID: 4837
	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x80")]
	public GameObject goBtnB;

	// Token: 0x040012E6 RID: 4838
	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x84")]
	public GameObject goBtnC;

	// Token: 0x040012E7 RID: 4839
	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x88")]
	public GameObject goPriceMedal;

	// Token: 0x040012E8 RID: 4840
	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject goPriceStone;

	// Token: 0x040012E9 RID: 4841
	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x90")]
	public Button btnA;

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x94")]
	public Button btnB;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x98")]
	public RectTransform rtAccList;

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x400101F")]
	[FieldOffset(Offset = "0x9C")]
	private List<AccElt> listAcc;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0xA0")]
	private PopupAccSelect.Mode eMode;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "HideInInspector", RVA = "0x185198", Offset = "0x185198")]
	public long nSelectedAcc;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0xB0")]
	private string[] arrStrItemDescL;

	// Token: 0x040012F0 RID: 4848
	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0xB4")]
	private string[] arrStrItemDescR;

	// Token: 0x040012F1 RID: 4849
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1851A8", Offset = "0x1851A8")]
	private static Comparison<PlayerAccData> <>f__am$cache0;

	// Token: 0x0200033D RID: 829
	[Token(Token = "0x2000288")]
	private enum Mode
	{
		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x4001026")]
		eAccSelect,
		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x4001027")]
		eSellAcc,
		// Token: 0x040012F5 RID: 4853
		[Token(Token = "0x4001028")]
		eEnchant
	}
}
