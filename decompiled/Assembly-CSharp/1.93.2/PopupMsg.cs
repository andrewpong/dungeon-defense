using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000352 RID: 850
[Token(Token = "0x200029A")]
public class PopupMsg : UIPage
{
	// Token: 0x06001549 RID: 5449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x38BC40", Offset = "0x38BC40", VA = "0x638BC40")]
	public PopupMsg()
	{
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x36FC80", Offset = "0x36FC80", VA = "0x636FC80")]
	public void SetMsg(string strMsg, bool bConfirm = true, bool bClose = false, string cmd = "")
	{
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x377200", Offset = "0x377200", VA = "0x6377200")]
	public void SetYesNo(string cmd, string strMsg, bool canClose = false)
	{
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x38BCE0", Offset = "0x38BCE0", VA = "0x638BCE0", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x38C154", Offset = "0x38C154", VA = "0x638C154")]
	public void ClickYes()
	{
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x38BEC0", Offset = "0x38BEC0", VA = "0x638BEC0")]
	public void ClickNo()
	{
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x38BE44", Offset = "0x38BE44", VA = "0x638BE44")]
	public void Close()
	{
	}

	// Token: 0x040013C1 RID: 5057
	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0x1C")]
	public Text textMsg;

	// Token: 0x040013C2 RID: 5058
	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goConfirm;

	// Token: 0x040013C3 RID: 5059
	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goYes;

	// Token: 0x040013C4 RID: 5060
	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goNo;

	// Token: 0x040013C5 RID: 5061
	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goClose;

	// Token: 0x040013C6 RID: 5062
	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform rtPanel;

	// Token: 0x040013C7 RID: 5063
	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x34")]
	private string strCmd;

	// Token: 0x040013C8 RID: 5064
	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1851B8", Offset = "0x1851B8")]
	private static Dictionary<string, int> <>f__switch$map0;
}
