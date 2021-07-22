using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000308 RID: 776
[Token(Token = "0x2000274")]
public class CharUnitTab : MonoBehaviour
{
	// Token: 0x0600115E RID: 4446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x294CB8", Offset = "0x294CB8", VA = "0x6294CB8")]
	public CharUnitTab()
	{
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x0600115F RID: 4447 RVA: 0x00006F48 File Offset: 0x00005148
	[Token(Token = "0x17000147")]
	public int nCharSlot
	{
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x294CC0", Offset = "0x294CC0", VA = "0x6294CC0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x294CC8", Offset = "0x294CC8", VA = "0x6294CC8")]
	public void SetUnitTab(PlayerMonsterData pData, int _nSlot)
	{
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x294FB8", Offset = "0x294FB8", VA = "0x6294FB8")]
	public void SetHighlight(bool bActive)
	{
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x294FEC", Offset = "0x294FEC", VA = "0x6294FEC")]
	public void OnClick()
	{
	}

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0xC")]
	public Image imgFrame;

	// Token: 0x04000F33 RID: 3891
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x10")]
	public Image imgChar;

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goLock;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goHighlight;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x1C")]
	public Button btnFrame;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x20")]
	private int nSlot;
}
