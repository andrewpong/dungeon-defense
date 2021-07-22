using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200035F RID: 863
[Token(Token = "0x20002A5")]
public class PopupTypeSelect : UIPage
{
	// Token: 0x060015D8 RID: 5592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001386")]
	[Address(RVA = "0x41F704", Offset = "0x41F704", VA = "0x641F704")]
	public PopupTypeSelect()
	{
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001387")]
	[Address(RVA = "0x41F70C", Offset = "0x41F70C", VA = "0x641F70C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001388")]
	[Address(RVA = "0x41F77C", Offset = "0x41F77C", VA = "0x641F77C")]
	public void EnchantType()
	{
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001389")]
	[Address(RVA = "0x41FC14", Offset = "0x41FC14", VA = "0x641FC14")]
	public void ItemSellType()
	{
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138A")]
	[Address(RVA = "0x41FECC", Offset = "0x41FECC", VA = "0x641FECC")]
	public void ItemFilterType()
	{
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138B")]
	[Address(RVA = "0x420134", Offset = "0x420134", VA = "0x6420134")]
	public void ResearchType()
	{
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138C")]
	[Address(RVA = "0x41F99C", Offset = "0x41F99C", VA = "0x641F99C")]
	public void RefreshChecker()
	{
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138D")]
	[Address(RVA = "0x420354", Offset = "0x420354", VA = "0x6420354")]
	public void SetType(int n)
	{
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138E")]
	[Address(RVA = "0x42058C", Offset = "0x42058C", VA = "0x642058C", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138F")]
	[Address(RVA = "0x42068C", Offset = "0x42068C", VA = "0x642068C")]
	public void OnClose()
	{
	}

	// Token: 0x0400149B RID: 5275
	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x0")]
	public static PopupTypeSelect obj;

	// Token: 0x0400149C RID: 5276
	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject[] goSelect;

	// Token: 0x0400149D RID: 5277
	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0x20")]
	public Text[] textSelect;

	// Token: 0x0400149E RID: 5278
	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject[] goCheck;

	// Token: 0x0400149F RID: 5279
	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0x28")]
	private PopupTypeSelect.Mode eMode;

	// Token: 0x02000360 RID: 864
	[Token(Token = "0x20002A6")]
	private enum Mode
	{
		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40011BF")]
		eNone = -1,
		// Token: 0x040014A2 RID: 5282
		[Token(Token = "0x40011C0")]
		eEnchant,
		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40011C1")]
		eItemSell,
		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40011C2")]
		eItemFilter,
		// Token: 0x040014A5 RID: 5285
		[Token(Token = "0x40011C3")]
		eResearch
	}
}
