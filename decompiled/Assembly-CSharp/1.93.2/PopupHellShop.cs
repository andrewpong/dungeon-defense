using System;
using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200034C RID: 844
[Token(Token = "0x2000294")]
public class PopupHellShop : UIPage
{
	// Token: 0x0600150B RID: 5387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x380B7C", Offset = "0x380B7C", VA = "0x6380B7C")]
	public PopupHellShop()
	{
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x0600150C RID: 5388 RVA: 0x000085E0 File Offset: 0x000067E0
	// (set) Token: 0x0600150D RID: 5389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000196")]
	public ObscuredInt nHell
	{
		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x380B84", Offset = "0x380B84", VA = "0x6380B84")]
		get
		{
			return default(ObscuredInt);
		}
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x380C30", Offset = "0x380C30", VA = "0x6380C30")]
		set
		{
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x0600150E RID: 5390 RVA: 0x000085F8 File Offset: 0x000067F8
	// (set) Token: 0x0600150F RID: 5391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000197")]
	public ObscuredInt nRuby
	{
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x380D4C", Offset = "0x380D4C", VA = "0x6380D4C")]
		get
		{
			return default(ObscuredInt);
		}
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x380DF8", Offset = "0x380DF8", VA = "0x6380DF8")]
		set
		{
		}
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x380F14", Offset = "0x380F14", VA = "0x6380F14", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x38153C", Offset = "0x38153C", VA = "0x638153C")]
	public void RefreshFeature()
	{
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x381B70", Offset = "0x381B70", VA = "0x6381B70")]
	public void RefreshStat()
	{
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x382EEC", Offset = "0x382EEC", VA = "0x6382EEC", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x381400", Offset = "0x381400", VA = "0x6381400")]
	public void OnMoveMenu(int n)
	{
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x3830C8", Offset = "0x3830C8", VA = "0x63830C8")]
	private void RefreshPanel(int n)
	{
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x38428C", Offset = "0x38428C", VA = "0x638428C")]
	private void RefreshMenu()
	{
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x383370", Offset = "0x383370", VA = "0x6383370")]
	private void RefreshHighlight(int n)
	{
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x383964", Offset = "0x383964", VA = "0x6383964")]
	public void RefreshForbidden()
	{
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x383430", Offset = "0x383430", VA = "0x6383430")]
	public void RefreshChar()
	{
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x382FEC", Offset = "0x382FEC", VA = "0x6382FEC")]
	public void OnClose()
	{
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x384334", Offset = "0x384334", VA = "0x6384334")]
	public void OnPurchase(string strID)
	{
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x3846F0", Offset = "0x3846F0", VA = "0x63846F0")]
	public void OnPayment(string strID)
	{
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x384468", Offset = "0x384468", VA = "0x6384468")]
	public void OnPurchase(RebirthID eID)
	{
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x38481C", Offset = "0x38481C", VA = "0x638481C")]
	public void OnPayment(ShopID eID)
	{
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x384964", Offset = "0x384964", VA = "0x6384964")]
	public void RefreshFromPurchase()
	{
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x3849A0", Offset = "0x3849A0", VA = "0x63849A0")]
	public void CheckSkill(string strID)
	{
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x385418", Offset = "0x385418", VA = "0x6385418")]
	public void OnRebirthStore()
	{
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06001522 RID: 5410 RVA: 0x00008610 File Offset: 0x00006810
	[Token(Token = "0x17000198")]
	private int nInitRubyCost
	{
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x382CE4", Offset = "0x382CE4", VA = "0x6382CE4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x3854C8", Offset = "0x3854C8", VA = "0x63854C8")]
	public void OnInit()
	{
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x385718", Offset = "0x385718", VA = "0x6385718")]
	public void OnRealInit()
	{
	}

	// Token: 0x0400136E RID: 4974
	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x0")]
	public static PopupHellShop obj;

	// Token: 0x0400136F RID: 4975
	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x1C")]
	public Text textTitle;

	// Token: 0x04001370 RID: 4976
	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x20")]
	public Text textHell;

	// Token: 0x04001371 RID: 4977
	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0x24")]
	public Text textRuby;

	// Token: 0x04001372 RID: 4978
	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] goShopPanel;

	// Token: 0x04001373 RID: 4979
	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x2C")]
	public Text[] textBotBtn;

	// Token: 0x04001374 RID: 4980
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x30")]
	public Text[] textStatDesc;

	// Token: 0x04001375 RID: 4981
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x34")]
	public Text[] textStatCount;

	// Token: 0x04001376 RID: 4982
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x38")]
	public Text[] textStatPrice;

	// Token: 0x04001377 RID: 4983
	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x3C")]
	public Text[] textStatButton;

	// Token: 0x04001378 RID: 4984
	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x40")]
	public Text[] textFeatureDesc;

	// Token: 0x04001379 RID: 4985
	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x44")]
	public Text[] textFeaturePrice;

	// Token: 0x0400137A RID: 4986
	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x48")]
	public Text[] textFeatureButton;

	// Token: 0x0400137B RID: 4987
	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x4C")]
	public Text[] textCharacterDesc;

	// Token: 0x0400137C RID: 4988
	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x50")]
	public Text[] textCharacterPrice;

	// Token: 0x0400137D RID: 4989
	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x54")]
	public Text[] textCharacterButton;

	// Token: 0x0400137E RID: 4990
	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x58")]
	public Text[] textCharacterSkill;

	// Token: 0x0400137F RID: 4991
	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x5C")]
	public Text[] textShopCashDesc;

	// Token: 0x04001380 RID: 4992
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x60")]
	public Text[] textShopCashPrice;

	// Token: 0x04001381 RID: 4993
	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x64")]
	public Text[] textShopCashBonus;

	// Token: 0x04001382 RID: 4994
	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x68")]
	public Text[] textShopBtnPurchase;

	// Token: 0x04001383 RID: 4995
	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x6C")]
	public Text[] textOnlyOnce;

	// Token: 0x04001384 RID: 4996
	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x70")]
	public Button[] btnStatPurchase;

	// Token: 0x04001385 RID: 4997
	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0x74")]
	public Button[] btnFeaturePurchase;

	// Token: 0x04001386 RID: 4998
	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0x78")]
	public Button[] btnCharacterPurchase;

	// Token: 0x04001387 RID: 4999
	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0x7C")]
	public Button[] btnCashPurchase;

	// Token: 0x04001388 RID: 5000
	[Token(Token = "0x40010AA")]
	[FieldOffset(Offset = "0x80")]
	public Image[] imgBtnHighlight;

	// Token: 0x04001389 RID: 5001
	[Token(Token = "0x40010AB")]
	[FieldOffset(Offset = "0x84")]
	public GameObject goForbidden;

	// Token: 0x0400138A RID: 5002
	[Token(Token = "0x40010AC")]
	[FieldOffset(Offset = "0x88")]
	public Text textInitCount;

	// Token: 0x0400138B RID: 5003
	[Token(Token = "0x40010AD")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject goInitRuby;

	// Token: 0x0400138C RID: 5004
	[Token(Token = "0x40010AE")]
	[FieldOffset(Offset = "0x90")]
	public Text textInitButton;

	// Token: 0x0400138D RID: 5005
	[Token(Token = "0x40010AF")]
	[FieldOffset(Offset = "0x94")]
	public Button btnInit;

	// Token: 0x0400138E RID: 5006
	[Token(Token = "0x40010B0")]
	[FieldOffset(Offset = "0x98")]
	public int nMaxInitCount;

	// Token: 0x0400138F RID: 5007
	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x9C")]
	private bool bChange;

	// Token: 0x04001390 RID: 5008
	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0x4")]
	private static int[] nCashBonus;
}
