using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000365 RID: 869
[Token(Token = "0x20002AB")]
public class ResearchElt : MonoBehaviour
{
	// Token: 0x0600163A RID: 5690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E8")]
	[Address(RVA = "0xC9CC94", Offset = "0xC9CC94", VA = "0x6C9CC94")]
	public ResearchElt()
	{
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E9")]
	[Address(RVA = "0xC9CC9C", Offset = "0xC9CC9C", VA = "0x6C9CC9C")]
	public void Refresh()
	{
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0xC9D03C", Offset = "0xC9D03C", VA = "0x6C9D03C")]
	public void SetHighlight(bool bEnable)
	{
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0xC9D070", Offset = "0xC9D070", VA = "0x6C9D070")]
	public void SetProgress(bool bEnable)
	{
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EC")]
	[Address(RVA = "0xC9D0A4", Offset = "0xC9D0A4", VA = "0x6C9D0A4")]
	public void OnClick()
	{
	}

	// Token: 0x04001562 RID: 5474
	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x04001563 RID: 5475
	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goProgress;

	// Token: 0x04001564 RID: 5476
	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goHighlight;

	// Token: 0x04001565 RID: 5477
	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goDone;

	// Token: 0x04001566 RID: 5478
	[Token(Token = "0x4001284")]
	[FieldOffset(Offset = "0x1C")]
	public ResearchID eID;

	// Token: 0x04001567 RID: 5479
	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x0")]
	private static Color clLearn;
}
