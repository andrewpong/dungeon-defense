using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000312 RID: 786
[Token(Token = "0x200027D")]
public class MissionElt : MonoBehaviour
{
	// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x2A69BC", Offset = "0x2A69BC", VA = "0x62A69BC")]
	public MissionElt()
	{
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x2A69C4", Offset = "0x2A69C4", VA = "0x62A69C4")]
	public void Refresh()
	{
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00007C68 File Offset: 0x00005E68
	[Token(Token = "0x17000160")]
	private int nCurrent
	{
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x2A6E3C", Offset = "0x2A6E3C", VA = "0x62A6E3C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x2A8908", Offset = "0x2A8908", VA = "0x62A8908")]
	public void OnGet()
	{
	}

	// Token: 0x04001018 RID: 4120
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0xC")]
	public Text textName;

	// Token: 0x04001019 RID: 4121
	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0x10")]
	public Text textGuage;

	// Token: 0x0400101A RID: 4122
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x14")]
	public Text textReward;

	// Token: 0x0400101B RID: 4123
	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x18")]
	public Text textButton;

	// Token: 0x0400101C RID: 4124
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x1C")]
	public Image imgFill;

	// Token: 0x0400101D RID: 4125
	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x20")]
	public Button btnGet;

	// Token: 0x0400101E RID: 4126
	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x24")]
	public QuestID eID;
}
