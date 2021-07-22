using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200036D RID: 877
[Token(Token = "0x20002B3")]
public class WeaponElt : MonoBehaviour
{
	// Token: 0x06001688 RID: 5768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001436")]
	[Address(RVA = "0xBDCE94", Offset = "0xBDCE94", VA = "0x6BDCE94")]
	public WeaponElt()
	{
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001437")]
	[Address(RVA = "0xBDCE9C", Offset = "0xBDCE9C", VA = "0x6BDCE9C")]
	public void SetItemByID(short sID, WeaponElt.Type _eType = WeaponElt.Type.JustShow)
	{
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001438")]
	[Address(RVA = "0xBDD1B0", Offset = "0xBDD1B0", VA = "0x6BDD1B0")]
	public void SetItem(long _uid, WeaponElt.Type _eType = WeaponElt.Type.JustShow, int nPlusLv = 0)
	{
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001439")]
	[Address(RVA = "0xBDD538", Offset = "0xBDD538", VA = "0x6BDD538")]
	public void SetItem(PlayerItemData pData, WeaponElt.Type _eType, int nPlusLv = 0)
	{
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143A")]
	[Address(RVA = "0xBDDAB8", Offset = "0xBDDAB8", VA = "0x6BDDAB8")]
	public void SetHighlight(bool bEnable)
	{
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143B")]
	[Address(RVA = "0xBDDAEC", Offset = "0xBDDAEC", VA = "0x6BDDAEC")]
	public void SetChecker(bool bCheck)
	{
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143C")]
	[Address(RVA = "0xBDDB20", Offset = "0xBDDB20", VA = "0x6BDDB20")]
	public void SetSpecial(bool bSpecial)
	{
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143D")]
	[Address(RVA = "0xBDDB54", Offset = "0xBDDB54", VA = "0x6BDDB54")]
	public void SetNew(bool bNew)
	{
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143E")]
	[Address(RVA = "0xBDD170", Offset = "0xBDD170", VA = "0x6BDD170")]
	private void SetType(WeaponElt.Type type)
	{
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143F")]
	[Address(RVA = "0xBDDB88", Offset = "0xBDDB88", VA = "0x6BDDB88")]
	public void OnClick()
	{
	}

	// Token: 0x04001590 RID: 5520
	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x04001591 RID: 5521
	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0x10")]
	public Image imgFrame;

	// Token: 0x04001592 RID: 5522
	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0x14")]
	public Button btnFrame;

	// Token: 0x04001593 RID: 5523
	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0x18")]
	public Text textLv;

	// Token: 0x04001594 RID: 5524
	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goEquip;

	// Token: 0x04001595 RID: 5525
	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goBlank;

	// Token: 0x04001596 RID: 5526
	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goHighlight;

	// Token: 0x04001597 RID: 5527
	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goLock;

	// Token: 0x04001598 RID: 5528
	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goChecker;

	// Token: 0x04001599 RID: 5529
	[Token(Token = "0x40012B7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goNew;

	// Token: 0x0400159A RID: 5530
	[Token(Token = "0x40012B8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject goSpecial;

	// Token: 0x0400159B RID: 5531
	[Token(Token = "0x40012B9")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x185278", Offset = "0x185278")]
	public WeaponElt.Type eType;

	// Token: 0x0400159C RID: 5532
	[Token(Token = "0x40012BA")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x185288", Offset = "0x185288")]
	public long uid;

	// Token: 0x0200036E RID: 878
	[Token(Token = "0x20002B4")]
	public enum Type
	{
		// Token: 0x0400159E RID: 5534
		[Token(Token = "0x40012BC")]
		JustShow,
		// Token: 0x0400159F RID: 5535
		[Token(Token = "0x40012BD")]
		CharEquip,
		// Token: 0x040015A0 RID: 5536
		[Token(Token = "0x40012BE")]
		WeaponSelect,
		// Token: 0x040015A1 RID: 5537
		[Token(Token = "0x40012BF")]
		LootItem,
		// Token: 0x040015A2 RID: 5538
		[Token(Token = "0x40012C0")]
		Shop,
		// Token: 0x040015A3 RID: 5539
		[Token(Token = "0x40012C1")]
		SellItem
	}
}
