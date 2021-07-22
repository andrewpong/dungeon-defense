using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200033B RID: 827
[Token(Token = "0x2000286")]
public class PopupAccBook : UIPage
{
	// Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001246")]
	[Address(RVA = "0x365A3C", Offset = "0x365A3C", VA = "0x6365A3C")]
	public PopupAccBook()
	{
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06001487 RID: 5255 RVA: 0x000084F0 File Offset: 0x000066F0
	// (set) Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000190")]
	private long nMedal
	{
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x365B20", Offset = "0x365B20", VA = "0x6365B20")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x365C24", Offset = "0x365C24", VA = "0x6365C24")]
		set
		{
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x06001489 RID: 5257 RVA: 0x00008508 File Offset: 0x00006708
	// (set) Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000191")]
	private long nStone
	{
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x365D98", Offset = "0x365D98", VA = "0x6365D98")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x600124A")]
		[Address(RVA = "0x365E9C", Offset = "0x365E9C", VA = "0x6365E9C")]
		set
		{
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x0600148B RID: 5259 RVA: 0x00008520 File Offset: 0x00006720
	// (set) Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000192")]
	private int nRuby
	{
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x366010", Offset = "0x366010", VA = "0x6366010")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x366104", Offset = "0x366104", VA = "0x6366104")]
		set
		{
		}
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x366264", Offset = "0x366264", VA = "0x6366264", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x367C60", Offset = "0x367C60", VA = "0x6367C60", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x3665F0", Offset = "0x3665F0", VA = "0x63665F0")]
	private void ReallocElt(int nCount)
	{
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x366C10", Offset = "0x366C10", VA = "0x6366C10")]
	public void RefreshDetailAcc(short sID)
	{
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x367B1C", Offset = "0x367B1C", VA = "0x6367B1C")]
	private void RefreshHighlight()
	{
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x367EA8", Offset = "0x367EA8", VA = "0x6367EA8")]
	public void OnClick(short sID)
	{
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x367D5C", Offset = "0x367D5C", VA = "0x6367D5C")]
	public void OnClose()
	{
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x367EC4", Offset = "0x367EC4", VA = "0x6367EC4")]
	public void OnButtonB()
	{
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001255")]
	[Address(RVA = "0x367EC8", Offset = "0x367EC8", VA = "0x6367EC8")]
	public void OnPurchase()
	{
	}

	// Token: 0x040012AE RID: 4782
	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0x0")]
	public static PopupAccBook obj;

	// Token: 0x040012AF RID: 4783
	[Token(Token = "0x4000FE2")]
	[FieldOffset(Offset = "0x1C")]
	public AccElt eltAccDetail;

	// Token: 0x040012B0 RID: 4784
	[Token(Token = "0x4000FE3")]
	[FieldOffset(Offset = "0x20")]
	public Text textItemName;

	// Token: 0x040012B1 RID: 4785
	[Token(Token = "0x4000FE4")]
	[FieldOffset(Offset = "0x24")]
	public Text textItemGrade;

	// Token: 0x040012B2 RID: 4786
	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x28")]
	public Text textItemDesc;

	// Token: 0x040012B3 RID: 4787
	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x2C")]
	public Text textItemOnly;

	// Token: 0x040012B4 RID: 4788
	[Token(Token = "0x4000FE7")]
	[FieldOffset(Offset = "0x30")]
	public Text textItemSource;

	// Token: 0x040012B5 RID: 4789
	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x34")]
	public Text textBtnA;

	// Token: 0x040012B6 RID: 4790
	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x38")]
	public Text textBtnB;

	// Token: 0x040012B7 RID: 4791
	[Token(Token = "0x4000FEA")]
	[FieldOffset(Offset = "0x3C")]
	public Text textMedal;

	// Token: 0x040012B8 RID: 4792
	[Token(Token = "0x4000FEB")]
	[FieldOffset(Offset = "0x40")]
	public Text textStone;

	// Token: 0x040012B9 RID: 4793
	[Token(Token = "0x4000FEC")]
	[FieldOffset(Offset = "0x44")]
	public Text textRuby;

	// Token: 0x040012BA RID: 4794
	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x48")]
	public Text textTitle;

	// Token: 0x040012BB RID: 4795
	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x4C")]
	public Text textPrice;

	// Token: 0x040012BC RID: 4796
	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x50")]
	public Text textMedalNeed;

	// Token: 0x040012BD RID: 4797
	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x54")]
	public Text textBookDesc;

	// Token: 0x040012BE RID: 4798
	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x58")]
	public Text textItemOwn;

	// Token: 0x040012BF RID: 4799
	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject objElt;

	// Token: 0x040012C0 RID: 4800
	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x60")]
	public GameObject goMedal;

	// Token: 0x040012C1 RID: 4801
	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x64")]
	public GameObject goStone;

	// Token: 0x040012C2 RID: 4802
	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x68")]
	public GameObject goRuby;

	// Token: 0x040012C3 RID: 4803
	[Token(Token = "0x4000FF6")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject goItemOwn;

	// Token: 0x040012C4 RID: 4804
	[Token(Token = "0x4000FF7")]
	[FieldOffset(Offset = "0x70")]
	public Button btnA;

	// Token: 0x040012C5 RID: 4805
	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0x74")]
	public Button btnB;

	// Token: 0x040012C6 RID: 4806
	[Token(Token = "0x4000FF9")]
	[FieldOffset(Offset = "0x78")]
	public RectTransform rtAccList;

	// Token: 0x040012C7 RID: 4807
	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0x7C")]
	private List<AccElt> listAcc;

	// Token: 0x040012C8 RID: 4808
	[Token(Token = "0x4000FFB")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "HideInInspector", RVA = "0x185188", Offset = "0x185188")]
	public short sSelectedAcc;

	// Token: 0x040012C9 RID: 4809
	[Token(Token = "0x4000FFC")]
	[FieldOffset(Offset = "0x84")]
	private List<short> listAccID;

	// Token: 0x040012CA RID: 4810
	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0x88")]
	private string[] arrStrItemDescR;
}
