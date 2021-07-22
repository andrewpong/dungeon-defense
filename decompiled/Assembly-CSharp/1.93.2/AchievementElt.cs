using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x200022E")]
public class AchievementElt : MonoBehaviour
{
	// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x281F0C", Offset = "0x281F0C", VA = "0x6281F0C")]
	public AchievementElt()
	{
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x281F14", Offset = "0x281F14", VA = "0x6281F14")]
	public void Refresh(AchievementType eID)
	{
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x282738", Offset = "0x282738", VA = "0x6282738")]
	public void OnShow()
	{
	}

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0xC")]
	public Text textName;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x10")]
	private bool bUnlock;

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x14")]
	private string strTooltip;
}
