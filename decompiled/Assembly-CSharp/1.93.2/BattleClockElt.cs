using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C4 RID: 708
[Token(Token = "0x2000231")]
public class BattleClockElt : MonoBehaviour
{
	// Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x28D83C", Offset = "0x28D83C", VA = "0x628D83C")]
	public BattleClockElt()
	{
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x28D844", Offset = "0x28D844", VA = "0x628D844")]
	private void Awake()
	{
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x28D920", Offset = "0x28D920", VA = "0x628D920")]
	private void Update()
	{
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x28D854", Offset = "0x28D854", VA = "0x628D854")]
	private void ResetClock()
	{
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x28DB88", Offset = "0x28DB88", VA = "0x628DB88")]
	public void OnClick()
	{
	}

	// Token: 0x040009C6 RID: 2502
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0xC")]
	public Text textClock;

	// Token: 0x040009C7 RID: 2503
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x10")]
	public RectTransform rt;

	// Token: 0x040009C8 RID: 2504
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x14")]
	private float fTime;

	// Token: 0x040009C9 RID: 2505
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x18")]
	private float fMax;

	// Token: 0x040009CA RID: 2506
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x1C")]
	private int nHit;
}
