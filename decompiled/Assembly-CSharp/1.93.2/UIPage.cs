using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200036C RID: 876
[Token(Token = "0x20002B2")]
public class UIPage : MonoBehaviour
{
	// Token: 0x06001682 RID: 5762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001430")]
	[Address(RVA = "0xBD3834", Offset = "0xBD3834", VA = "0x6BD3834")]
	public UIPage()
	{
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001431")]
	[Address(RVA = "0xBD3A44", Offset = "0xBD3A44", VA = "0x6BD3A44", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001432")]
	[Address(RVA = "0xBD5E98", Offset = "0xBD5E98", VA = "0x6BD5E98", Slot = "5")]
	protected virtual void Start()
	{
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001433")]
	[Address(RVA = "0xBD40F4", Offset = "0xBD40F4", VA = "0x6BD40F4", Slot = "6")]
	protected virtual void Update()
	{
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001434")]
	[Address(RVA = "0xBD62DC", Offset = "0xBD62DC", VA = "0x6BD62DC", Slot = "7")]
	public virtual void Focused()
	{
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001435")]
	[Address(RVA = "0xBD62E0", Offset = "0xBD62E0", VA = "0x6BD62E0", Slot = "8")]
	public virtual void PageClose()
	{
	}

	// Token: 0x0400158C RID: 5516
	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "HideInInspector", RVA = "0x185258", Offset = "0x185258")]
	public Canvas canvas;

	// Token: 0x0400158D RID: 5517
	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HideInInspector", RVA = "0x185268", Offset = "0x185268")]
	public bool registered;

	// Token: 0x0400158E RID: 5518
	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x14")]
	public Text[] textAll;

	// Token: 0x0400158F RID: 5519
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0x18")]
	protected RectTransform rtCanvas;
}
