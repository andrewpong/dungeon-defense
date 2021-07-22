using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200034D RID: 845
[Token(Token = "0x2000295")]
public class PopupHellStone : UIPage
{
	// Token: 0x06001526 RID: 5414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x3866EC", Offset = "0x3866EC", VA = "0x63866EC")]
	public PopupHellStone()
	{
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x386708", Offset = "0x386708", VA = "0x6386708", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x3869F4", Offset = "0x3869F4", VA = "0x63869F4")]
	private void RefreshQuest()
	{
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x3870D8", Offset = "0x3870D8", VA = "0x63870D8")]
	public void OnComplete(int nNum)
	{
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x3873D4", Offset = "0x3873D4", VA = "0x63873D4")]
	public void OnMoveDiff(int nMove)
	{
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x387408", Offset = "0x387408", VA = "0x6387408", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x3875B8", Offset = "0x3875B8", VA = "0x63875B8")]
	public void OnHellStore()
	{
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x387508", Offset = "0x387508", VA = "0x6387508")]
	public void OnClose()
	{
	}

	// Token: 0x04001391 RID: 5009
	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0x1C")]
	public Text textHellShop;

	// Token: 0x04001392 RID: 5010
	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x20")]
	public Text textTitle;

	// Token: 0x04001393 RID: 5011
	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0x24")]
	public Text textWarning;

	// Token: 0x04001394 RID: 5012
	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0x28")]
	public Text[] textQuestTitle;

	// Token: 0x04001395 RID: 5013
	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0x2C")]
	public Text[] textQuestProgress;

	// Token: 0x04001396 RID: 5014
	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0x30")]
	public Text[] textQuestReward;

	// Token: 0x04001397 RID: 5015
	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0x34")]
	public Text[] textQuestComplete;

	// Token: 0x04001398 RID: 5016
	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x38")]
	public Image[] imgQuestFill;

	// Token: 0x04001399 RID: 5017
	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x3C")]
	public Button[] btnQuestComplete;

	// Token: 0x0400139A RID: 5018
	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x40")]
	public int nSpendHellStone;

	// Token: 0x0400139B RID: 5019
	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x44")]
	private int nDiff;

	// Token: 0x0400139C RID: 5020
	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x48")]
	private int nMinDiff;

	// Token: 0x0400139D RID: 5021
	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x4C")]
	private int nMaxDiff;

	// Token: 0x0400139E RID: 5022
	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x50")]
	private bool bChanged;
}
