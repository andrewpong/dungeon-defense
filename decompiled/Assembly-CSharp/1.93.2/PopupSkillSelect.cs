using System;
using CC;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200035D RID: 861
[Token(Token = "0x20002A3")]
public class PopupSkillSelect : UIPage
{
	// Token: 0x060015C7 RID: 5575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001375")]
	[Address(RVA = "0x419824", Offset = "0x419824", VA = "0x6419824")]
	public PopupSkillSelect()
	{
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001376")]
	[Address(RVA = "0x4198A4", Offset = "0x4198A4", VA = "0x64198A4", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001377")]
	[Address(RVA = "0x419C1C", Offset = "0x419C1C", VA = "0x6419C1C", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001378")]
	[Address(RVA = "0x419C3C", Offset = "0x419C3C", VA = "0x6419C3C")]
	public void RefreshSelect()
	{
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001379")]
	[Address(RVA = "0x41AD60", Offset = "0x41AD60", VA = "0x641AD60")]
	public void RefreshDetail(int n)
	{
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600137A")]
	[Address(RVA = "0x41B7E0", Offset = "0x41B7E0", VA = "0x641B7E0")]
	public void RefreshHighlight()
	{
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600137B")]
	[Address(RVA = "0x41B908", Offset = "0x41B908", VA = "0x641B908", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600137C")]
	[Address(RVA = "0x41A6C4", Offset = "0x41A6C4", VA = "0x641A6C4")]
	public void OnClick(int n)
	{
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600137D")]
	[Address(RVA = "0x41A7B0", Offset = "0x41A7B0", VA = "0x641A7B0")]
	public void OnLearn()
	{
	}

	// Token: 0x04001476 RID: 5238
	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0x1C")]
	public Text textTitle;

	// Token: 0x04001477 RID: 5239
	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0x20")]
	public Text textTitleSub;

	// Token: 0x04001478 RID: 5240
	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0x24")]
	public Text textSelectTitle;

	// Token: 0x04001479 RID: 5241
	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0x28")]
	public Text textDetailTitle;

	// Token: 0x0400147A RID: 5242
	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0x2C")]
	public Text textDetailType;

	// Token: 0x0400147B RID: 5243
	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0x30")]
	public Text textDetailDesc;

	// Token: 0x0400147C RID: 5244
	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0x34")]
	public Text textDetailCur;

	// Token: 0x0400147D RID: 5245
	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0x38")]
	public Text textDetailNext;

	// Token: 0x0400147E RID: 5246
	[Token(Token = "0x400119C")]
	[FieldOffset(Offset = "0x3C")]
	public Text textBtnLearn;

	// Token: 0x0400147F RID: 5247
	[Token(Token = "0x400119D")]
	[FieldOffset(Offset = "0x40")]
	public Image imgUnit;

	// Token: 0x04001480 RID: 5248
	[Token(Token = "0x400119E")]
	[FieldOffset(Offset = "0x44")]
	public Button[] arrBtnSkill;

	// Token: 0x04001481 RID: 5249
	[Token(Token = "0x400119F")]
	[FieldOffset(Offset = "0x48")]
	public Image[] arrImgSkill;

	// Token: 0x04001482 RID: 5250
	[Token(Token = "0x40011A0")]
	[FieldOffset(Offset = "0x4C")]
	public Text[] arrSkillLv;

	// Token: 0x04001483 RID: 5251
	[Token(Token = "0x40011A1")]
	[FieldOffset(Offset = "0x50")]
	public Image[] arrHighlight;

	// Token: 0x04001484 RID: 5252
	[Token(Token = "0x40011A2")]
	[FieldOffset(Offset = "0x54")]
	public Button btnLearn;

	// Token: 0x04001485 RID: 5253
	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0x58")]
	private SkillKey[] arrSkill;

	// Token: 0x04001486 RID: 5254
	[Token(Token = "0x40011A4")]
	[FieldOffset(Offset = "0x5C")]
	private int nSelectedSkill;

	// Token: 0x04001487 RID: 5255
	[Token(Token = "0x40011A5")]
	[FieldOffset(Offset = "0x60")]
	private SkillKey ePreLearn;

	// Token: 0x04001488 RID: 5256
	[Token(Token = "0x40011A6")]
	[FieldOffset(Offset = "0x64")]
	private int nPreLv;
}
