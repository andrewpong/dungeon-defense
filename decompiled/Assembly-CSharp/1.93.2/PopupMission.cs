using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000350 RID: 848
[Token(Token = "0x2000298")]
public class PopupMission : UIPage
{
	// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x388D74", Offset = "0x388D74", VA = "0x6388D74")]
	public PopupMission()
	{
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x388D7C", Offset = "0x388D7C", VA = "0x6388D7C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x388EC8", Offset = "0x388EC8", VA = "0x6388EC8", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x388FC4", Offset = "0x388FC4", VA = "0x6388FC4")]
	public void OnClose()
	{
	}

	// Token: 0x040013AB RID: 5035
	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x1C")]
	public Text textTitle;

	// Token: 0x040013AC RID: 5036
	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x20")]
	public MissionElt[] arrMission;
}
