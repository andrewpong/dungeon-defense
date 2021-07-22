using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002BF RID: 703
[Token(Token = "0x200022C")]
public class AccElt : MonoBehaviour
{
	// Token: 0x060010D8 RID: 4312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x280D10", Offset = "0x280D10", VA = "0x6280D10")]
	public AccElt()
	{
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x280D18", Offset = "0x280D18", VA = "0x6280D18")]
	public void SetItemByID(short _sID, AccElt.Type _eType = AccElt.Type.JustShow)
	{
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x281150", Offset = "0x281150", VA = "0x6281150")]
	public void SetItem(long _uid, AccElt.Type _eType = AccElt.Type.JustShow, int nPlusLv = 0)
	{
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x281454", Offset = "0x281454", VA = "0x6281454")]
	public void SetItem(PlayerAccData pData, AccElt.Type _eType, int nPlusLv = 0)
	{
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x281934", Offset = "0x281934", VA = "0x6281934")]
	public void SetHighlight(bool bEnable)
	{
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x281110", Offset = "0x281110", VA = "0x6281110")]
	private void SetType(AccElt.Type type)
	{
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x281968", Offset = "0x281968", VA = "0x6281968")]
	public void OnClick()
	{
	}

	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x10")]
	public Image imgFrame;

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x14")]
	public Button btnFrame;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x18")]
	public Text textLv;

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goEquip;

	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goBlank;

	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goBlankRing;

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goHighlight;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goLock;

	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x30")]
	public bool bRing;

	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "HideInInspector", RVA = "0x1848F0", Offset = "0x1848F0")]
	public AccElt.Type eType;

	// Token: 0x040009AE RID: 2478
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x184900", Offset = "0x184900")]
	public long uid;

	// Token: 0x040009AF RID: 2479
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x184910", Offset = "0x184910")]
	public short sID;

	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x200022D")]
	public enum Type
	{
		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x4000813")]
		JustShow,
		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x4000814")]
		CharEquip,
		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x4000815")]
		AccSelect,
		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x4000816")]
		AccBook
	}
}
