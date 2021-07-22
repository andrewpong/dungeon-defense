using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000310 RID: 784
[Token(Token = "0x200027B")]
public class ItemModElt : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x2A46C8", Offset = "0x2A46C8", VA = "0x62A46C8")]
	public ItemModElt()
	{
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x2A46D0", Offset = "0x2A46D0", VA = "0x62A46D0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x2A5178", Offset = "0x2A5178", VA = "0x62A5178", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x04001014 RID: 4116
	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0xC")]
	public int nSlot;
}
