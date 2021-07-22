using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200036A RID: 874
[Token(Token = "0x20002B0")]
public class TooltipWindow : MonoBehaviour
{
	// Token: 0x0600165F RID: 5727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140D")]
	[Address(RVA = "0xBD3714", Offset = "0xBD3714", VA = "0x6BD3714")]
	public TooltipWindow()
	{
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140E")]
	[Address(RVA = "0xBD371C", Offset = "0xBD371C", VA = "0x6BD371C")]
	private void Awake()
	{
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140F")]
	[Address(RVA = "0xBD37C8", Offset = "0xBD37C8", VA = "0x6BD37C8")]
	private void Update()
	{
	}

	// Token: 0x0400157F RID: 5503
	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0x0")]
	public static TooltipWindow obj;

	// Token: 0x04001580 RID: 5504
	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0xC")]
	public Text textMsg;

	// Token: 0x04001581 RID: 5505
	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0x10")]
	public RectTransform rt;

	// Token: 0x04001582 RID: 5506
	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0x14")]
	public bool bInit;
}
