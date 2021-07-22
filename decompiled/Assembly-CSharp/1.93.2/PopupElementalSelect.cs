using System;
using System.Collections.Generic;
using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000344 RID: 836
[Token(Token = "0x200028E")]
public class PopupElementalSelect : UIPage
{
	// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x3759E8", Offset = "0x3759E8", VA = "0x63759E8")]
	public PopupElementalSelect()
	{
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x375B00", Offset = "0x375B00", VA = "0x6375B00", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x376280", Offset = "0x376280", VA = "0x6376280", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x3762A0", Offset = "0x3762A0", VA = "0x63762A0")]
	private void Refresh()
	{
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001293")]
	[Address(RVA = "0x376DA0", Offset = "0x376DA0", VA = "0x6376DA0")]
	public void OnSelect(int n)
	{
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001294")]
	[Address(RVA = "0x377340", Offset = "0x377340", VA = "0x6377340")]
	public void OnRealSelect()
	{
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001295")]
	[Address(RVA = "0x377784", Offset = "0x377784", VA = "0x6377784", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001296")]
	[Address(RVA = "0x377880", Offset = "0x377880", VA = "0x6377880")]
	public void OnClose()
	{
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001297")]
	[Address(RVA = "0x377F28", Offset = "0x377F28", VA = "0x6377F28")]
	public void OnOpenTrait(int i)
	{
	}

	// Token: 0x04001322 RID: 4898
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x0")]
	public static PopupElementalSelect obj;

	// Token: 0x04001323 RID: 4899
	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x1C")]
	public Text[] textElementalSelect;

	// Token: 0x04001324 RID: 4900
	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x20")]
	public Text[] textElementalTrait;

	// Token: 0x04001325 RID: 4901
	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x24")]
	public Text[] textElementalName;

	// Token: 0x04001326 RID: 4902
	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x28")]
	public Text[] textElementalLevel;

	// Token: 0x04001327 RID: 4903
	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x2C")]
	public Image[] imgElemental;

	// Token: 0x04001328 RID: 4904
	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x30")]
	public Image[] imgGaugeFill;

	// Token: 0x04001329 RID: 4905
	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x34")]
	public Button[] btnElementalSelect;

	// Token: 0x0400132A RID: 4906
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x38")]
	public Text textElementalTitle;

	// Token: 0x0400132B RID: 4907
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x3C")]
	public Text textElementalWarn;

	// Token: 0x0400132C RID: 4908
	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x40")]
	private bool bCanSelect;

	// Token: 0x0400132D RID: 4909
	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x44")]
	private ObscuredInt nSelected;

	// Token: 0x0400132E RID: 4910
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x54")]
	private List<RebirthID> list;

	// Token: 0x0400132F RID: 4911
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x58")]
	private List<ElementalID> listElemental;
}
