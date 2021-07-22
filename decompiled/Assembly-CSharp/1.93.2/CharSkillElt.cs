using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000307 RID: 775
[Token(Token = "0x2000273")]
public class CharSkillElt : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
{
	// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x294254", Offset = "0x294254", VA = "0x6294254")]
	public CharSkillElt()
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x29425C", Offset = "0x29425C", VA = "0x629425C")]
	public void SetSkillElt(SkillKey _eKey, int _nLevel, bool bAwaken, bool bFocused = false)
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x294BB4", Offset = "0x294BB4", VA = "0x6294BB4", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x294C3C", Offset = "0x294C3C", VA = "0x6294C3C", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x04000F2C RID: 3884
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x04000F2D RID: 3885
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x10")]
	public Image imgFrame;

	// Token: 0x04000F2E RID: 3886
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x14")]
	public Text textName;

	// Token: 0x04000F2F RID: 3887
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x18")]
	private SkillKey eKey;

	// Token: 0x04000F30 RID: 3888
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x1C")]
	private int nLevel;

	// Token: 0x04000F31 RID: 3889
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x20")]
	private string strTooltip;
}
