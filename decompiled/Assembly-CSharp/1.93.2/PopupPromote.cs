using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000356 RID: 854
[Token(Token = "0x200029E")]
public class PopupPromote : UIPage
{
	// Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x4083D0", Offset = "0x4083D0", VA = "0x64083D0")]
	public PopupPromote()
	{
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x4083D8", Offset = "0x4083D8", VA = "0x64083D8", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x4085A4", Offset = "0x4085A4", VA = "0x64085A4")]
	private void Refresh()
	{
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001330")]
	[Address(RVA = "0x409B10", Offset = "0x409B10", VA = "0x6409B10", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001331")]
	[Address(RVA = "0x409A60", Offset = "0x409A60", VA = "0x6409A60")]
	public void OnClose()
	{
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001332")]
	[Address(RVA = "0x409C10", Offset = "0x409C10", VA = "0x6409C10")]
	public void OnPromote()
	{
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001333")]
	[Address(RVA = "0x40A1A4", Offset = "0x40A1A4", VA = "0x640A1A4")]
	public void OnInit()
	{
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001334")]
	[Address(RVA = "0x40A51C", Offset = "0x40A51C", VA = "0x640A51C")]
	public void OnRealInit()
	{
	}

	// Token: 0x0400140A RID: 5130
	[Token(Token = "0x400112C")]
	[FieldOffset(Offset = "0x0")]
	public static PopupPromote obj;

	// Token: 0x0400140B RID: 5131
	[Token(Token = "0x400112D")]
	[FieldOffset(Offset = "0x1C")]
	public Text textBtnPromote;

	// Token: 0x0400140C RID: 5132
	[Token(Token = "0x400112E")]
	[FieldOffset(Offset = "0x20")]
	public Text textMedalOwn;

	// Token: 0x0400140D RID: 5133
	[Token(Token = "0x400112F")]
	[FieldOffset(Offset = "0x24")]
	public Text textMedalNeed;

	// Token: 0x0400140E RID: 5134
	[Token(Token = "0x4001130")]
	[FieldOffset(Offset = "0x28")]
	public Text textCurrentPromote;

	// Token: 0x0400140F RID: 5135
	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x2C")]
	public Text textWarning;

	// Token: 0x04001410 RID: 5136
	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x30")]
	public Text textLvBonus;

	// Token: 0x04001411 RID: 5137
	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x34")]
	public Text[] textEffect;

	// Token: 0x04001412 RID: 5138
	[Token(Token = "0x4001134")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] goLock;

	// Token: 0x04001413 RID: 5139
	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x3C")]
	public Image imgChar;

	// Token: 0x04001414 RID: 5140
	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x40")]
	public Button btnPromote;

	// Token: 0x04001415 RID: 5141
	[Token(Token = "0x4001137")]
	[FieldOffset(Offset = "0x44")]
	public Text textInit;

	// Token: 0x04001416 RID: 5142
	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x48")]
	public Text textInitCost;

	// Token: 0x04001417 RID: 5143
	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x4C")]
	public Button btnInit;

	// Token: 0x04001418 RID: 5144
	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x50")]
	private bool bChanged;
}
