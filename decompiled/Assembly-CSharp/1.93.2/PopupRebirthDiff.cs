using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000358 RID: 856
[Token(Token = "0x20002A0")]
public class PopupRebirthDiff : UIPage
{
	// Token: 0x0600159B RID: 5531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600134D")]
	[Address(RVA = "0x410850", Offset = "0x410850", VA = "0x6410850")]
	public PopupRebirthDiff()
	{
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600134E")]
	[Address(RVA = "0x4108DC", Offset = "0x4108DC", VA = "0x64108DC", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600134F")]
	[Address(RVA = "0x41146C", Offset = "0x41146C", VA = "0x641146C", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001350")]
	[Address(RVA = "0x411568", Offset = "0x411568", VA = "0x6411568")]
	public void OnClose()
	{
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001351")]
	[Address(RVA = "0x411600", Offset = "0x411600", VA = "0x6411600")]
	public void OnDifficult(int nDiff)
	{
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001352")]
	[Address(RVA = "0x4116E4", Offset = "0x4116E4", VA = "0x64116E4")]
	public void MoveChar(int nMove)
	{
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001353")]
	[Address(RVA = "0x4110E8", Offset = "0x4110E8", VA = "0x64110E8")]
	public void RefreshChar()
	{
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001354")]
	[Address(RVA = "0x410FCC", Offset = "0x410FCC", VA = "0x6410FCC")]
	public void RefreshDiffHighlight()
	{
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001355")]
	[Address(RVA = "0x4118D0", Offset = "0x4118D0", VA = "0x64118D0")]
	public void OnRebirth()
	{
	}

	// Token: 0x0400143B RID: 5179
	[Token(Token = "0x400115D")]
	[FieldOffset(Offset = "0x1C")]
	public Text textDesc;

	// Token: 0x0400143C RID: 5180
	[Token(Token = "0x400115E")]
	[FieldOffset(Offset = "0x20")]
	public Text textSelDiff;

	// Token: 0x0400143D RID: 5181
	[Token(Token = "0x400115F")]
	[FieldOffset(Offset = "0x24")]
	public Text textBtnRebirth;

	// Token: 0x0400143E RID: 5182
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x28")]
	public Text textBtnCancel;

	// Token: 0x0400143F RID: 5183
	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x2C")]
	public Text textCharSel;

	// Token: 0x04001440 RID: 5184
	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x30")]
	public Text textCharName;

	// Token: 0x04001441 RID: 5185
	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x34")]
	public Text[] textDiff;

	// Token: 0x04001442 RID: 5186
	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] arrChecker;

	// Token: 0x04001443 RID: 5187
	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject goLock;

	// Token: 0x04001444 RID: 5188
	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x40")]
	public Image imgMon;

	// Token: 0x04001445 RID: 5189
	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x44")]
	public Button btnRebirth;

	// Token: 0x04001446 RID: 5190
	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x0")]
	public static PopupRebirthDiff obj;

	// Token: 0x04001447 RID: 5191
	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0x48")]
	private List<short> listMon;

	// Token: 0x04001448 RID: 5192
	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x4C")]
	private int nCharPos;
}
