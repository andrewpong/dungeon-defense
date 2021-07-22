using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000368 RID: 872
[Token(Token = "0x20002AE")]
public class StringTooltip : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	// Token: 0x0600165A RID: 5722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001408")]
	[Address(RVA = "0xCA3AC4", Offset = "0xCA3AC4", VA = "0x6CA3AC4")]
	public StringTooltip()
	{
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001409")]
	[Address(RVA = "0xCA3B64", Offset = "0xCA3B64", VA = "0x6CA3B64", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140A")]
	[Address(RVA = "0xCA3C60", Offset = "0xCA3C60", VA = "0x6CA3C60", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0400157D RID: 5501
	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0xC")]
	public string strTooltip;

	// Token: 0x0400157E RID: 5502
	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x10")]
	public string strTooltipSub1;
}
