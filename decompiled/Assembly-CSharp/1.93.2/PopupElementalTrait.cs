using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000345 RID: 837
[Token(Token = "0x200028F")]
public class PopupElementalTrait : UIPage
{
	// Token: 0x060014DE RID: 5342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001298")]
	[Address(RVA = "0x37806C", Offset = "0x37806C", VA = "0x637806C")]
	public PopupElementalTrait()
	{
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x378074", Offset = "0x378074", VA = "0x6378074", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x37921C", Offset = "0x37921C", VA = "0x637921C", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x379318", Offset = "0x379318", VA = "0x6379318")]
	public void OnClose()
	{
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129C")]
	[Address(RVA = "0x3793B8", Offset = "0x3793B8", VA = "0x63793B8")]
	private void OnDetailView(ElementalID _eID)
	{
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129D")]
	[Address(RVA = "0x378278", Offset = "0x378278", VA = "0x6378278")]
	private void RefreshTraitTree()
	{
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129E")]
	[Address(RVA = "0x378FF8", Offset = "0x378FF8", VA = "0x6378FF8")]
	public void OnTraitSelected(int i)
	{
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129F")]
	[Address(RVA = "0x37A58C", Offset = "0x37A58C", VA = "0x637A58C")]
	public void OnLearn()
	{
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x37A7BC", Offset = "0x37A7BC", VA = "0x637A7BC")]
	public void OnInit()
	{
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x060014E7 RID: 5351 RVA: 0x00008598 File Offset: 0x00006798
	[Token(Token = "0x17000195")]
	private int nInitCost
	{
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x37A398", Offset = "0x37A398", VA = "0x637A398")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x37A9D8", Offset = "0x37A9D8", VA = "0x637A9D8")]
	public void OnRealInit()
	{
	}

	// Token: 0x04001330 RID: 4912
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x0")]
	public static PopupElementalTrait obj;

	// Token: 0x04001331 RID: 4913
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x1C")]
	private ElementalID eID;

	// Token: 0x04001332 RID: 4914
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x20")]
	private ElementalID eBase;

	// Token: 0x04001333 RID: 4915
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x24")]
	public Image[] imgTraitIcon;

	// Token: 0x04001334 RID: 4916
	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x28")]
	public Image[] imgTraitFrame;

	// Token: 0x04001335 RID: 4917
	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x2C")]
	public Image[] imgTraitHighlight;

	// Token: 0x04001336 RID: 4918
	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x30")]
	public Image imgDetailTraitIcon;

	// Token: 0x04001337 RID: 4919
	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0x34")]
	public Text textDetailTraitName;

	// Token: 0x04001338 RID: 4920
	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x38")]
	public Text textDetailTraitDesc;

	// Token: 0x04001339 RID: 4921
	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0x3C")]
	public Text textDetailTraitWarn;

	// Token: 0x0400133A RID: 4922
	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x40")]
	public Text textDetailLearnBtn;

	// Token: 0x0400133B RID: 4923
	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x44")]
	public Button btnDetailLearn;

	// Token: 0x0400133C RID: 4924
	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x48")]
	public Text textTitle;

	// Token: 0x0400133D RID: 4925
	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x4C")]
	public Text textTraitPoints;

	// Token: 0x0400133E RID: 4926
	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x50")]
	public Text textInitButton;

	// Token: 0x0400133F RID: 4927
	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x54")]
	public Text textInitNeed;

	// Token: 0x04001340 RID: 4928
	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x58")]
	public GameObject goInitNeed;

	// Token: 0x04001341 RID: 4929
	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject goInitButton;
}
