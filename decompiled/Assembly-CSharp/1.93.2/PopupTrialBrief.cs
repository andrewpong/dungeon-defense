using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200035E RID: 862
[Token(Token = "0x20002A4")]
public class PopupTrialBrief : UIPage
{
	// Token: 0x060015D0 RID: 5584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600137E")]
	[Address(RVA = "0x41BA18", Offset = "0x41BA18", VA = "0x641BA18")]
	public PopupTrialBrief()
	{
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600137F")]
	[Address(RVA = "0x41BA28", Offset = "0x41BA28", VA = "0x641BA28", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001380")]
	[Address(RVA = "0x41C118", Offset = "0x41C118", VA = "0x641C118")]
	private void RefreshDetail()
	{
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001381")]
	[Address(RVA = "0x41EF38", Offset = "0x41EF38", VA = "0x641EF38")]
	public void BattleStart()
	{
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001382")]
	[Address(RVA = "0x41BEC8", Offset = "0x41BEC8", VA = "0x641BEC8")]
	public void MoveTrial(int n)
	{
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001383")]
	[Address(RVA = "0x41F550", Offset = "0x41F550", VA = "0x641F550")]
	public void SelDiff(int n)
	{
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001384")]
	[Address(RVA = "0x41F4B0", Offset = "0x41F4B0", VA = "0x641F4B0")]
	public void RefreshMonster(int nMon)
	{
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001385")]
	[Address(RVA = "0x41F688", Offset = "0x41F688", VA = "0x641F688")]
	public void OnClose()
	{
	}

	// Token: 0x04001489 RID: 5257
	[Token(Token = "0x40011A7")]
	[FieldOffset(Offset = "0x1C")]
	public Text textTitle;

	// Token: 0x0400148A RID: 5258
	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x20")]
	public Text textName;

	// Token: 0x0400148B RID: 5259
	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x24")]
	public Text textDescTop;

	// Token: 0x0400148C RID: 5260
	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x28")]
	public Text textDesc;

	// Token: 0x0400148D RID: 5261
	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0x2C")]
	public Text textDropTop;

	// Token: 0x0400148E RID: 5262
	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x30")]
	public Text textDrop;

	// Token: 0x0400148F RID: 5263
	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0x34")]
	public Text textStart;

	// Token: 0x04001490 RID: 5264
	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x38")]
	public Text textDiffEasy;

	// Token: 0x04001491 RID: 5265
	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x3C")]
	public Text textDiffNormal;

	// Token: 0x04001492 RID: 5266
	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x40")]
	public Text textDiffHard;

	// Token: 0x04001493 RID: 5267
	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0x44")]
	public Text textDiffInsane;

	// Token: 0x04001494 RID: 5268
	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0x48")]
	public Button btnStart;

	// Token: 0x04001495 RID: 5269
	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject goLeft;

	// Token: 0x04001496 RID: 5270
	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x50")]
	public GameObject goRight;

	// Token: 0x04001497 RID: 5271
	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x54")]
	public GameObject[] goDiffChecker;

	// Token: 0x04001498 RID: 5272
	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x58")]
	public GameObject[] goMonster;

	// Token: 0x04001499 RID: 5273
	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0x5C")]
	private int nFloor;

	// Token: 0x0400149A RID: 5274
	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x60")]
	public int nMaxFloor;
}
