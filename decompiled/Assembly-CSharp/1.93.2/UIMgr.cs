using System;
using System.Collections.Generic;
using CC;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036B RID: 875
[Token(Token = "0x20002B1")]
public class UIMgr : UIPage
{
	// Token: 0x06001662 RID: 5730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001410")]
	[Address(RVA = "0xBD382C", Offset = "0xBD382C", VA = "0x6BD382C")]
	public UIMgr()
	{
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001411")]
	[Address(RVA = "0xBD383C", Offset = "0xBD383C", VA = "0x6BD383C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001412")]
	[Address(RVA = "0xBD3B64", Offset = "0xBD3B64", VA = "0x6BD3B64")]
	public static UIPage AddPage(string strName)
	{
		return null;
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001413")]
	[Address(RVA = "0xBD40F0", Offset = "0xBD40F0", VA = "0x6BD40F0", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001414")]
	[Address(RVA = "0xBD40F8", Offset = "0xBD40F8", VA = "0x6BD40F8")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001415")]
	[Address(RVA = "0xBD40FC", Offset = "0xBD40FC", VA = "0x6BD40FC", Slot = "9")]
	public virtual void Resume()
	{
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001416")]
	[Address(RVA = "0xBD3CB4", Offset = "0xBD3CB4", VA = "0x6BD3CB4")]
	public static void Register(UIPage page)
	{
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001417")]
	[Address(RVA = "0xBD4100", Offset = "0xBD4100", VA = "0x6BD4100")]
	public static void RemoveTop()
	{
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001418")]
	[Address(RVA = "0xBD468C", Offset = "0xBD468C", VA = "0x6BD468C")]
	public static void Shake(Vector3 pos, float fTime)
	{
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001419")]
	[Address(RVA = "0xBD4690", Offset = "0xBD4690", VA = "0x6BD4690")]
	public void ShowAd(Ads eAd)
	{
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141A")]
	[Address(RVA = "0xBD4760", Offset = "0xBD4760", VA = "0x6BD4760")]
	private void OnAdsComplete()
	{
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141B")]
	[Address(RVA = "0xBD482C", Offset = "0xBD482C", VA = "0x6BD482C")]
	private void OnAdsSkipped()
	{
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141C")]
	[Address(RVA = "0xBD4830", Offset = "0xBD4830", VA = "0x6BD4830")]
	private void OnAdsFailed()
	{
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141D")]
	[Address(RVA = "0xBD48C0", Offset = "0xBD48C0", VA = "0x6BD48C0")]
	public static void ShowMsg(string strMsg)
	{
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06001670 RID: 5744 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001A0")]
	public static PopupMsg popupMsg
	{
		[Token(Token = "0x600141E")]
		[Address(RVA = "0xBD48C4", Offset = "0xBD48C4", VA = "0x6BD48C4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600141F")]
	[Address(RVA = "0xBD4998", Offset = "0xBD4998", VA = "0x6BD4998")]
	public static PopupMsg GetMsg()
	{
		return null;
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001420")]
	[Address(RVA = "0xBD4A6C", Offset = "0xBD4A6C", VA = "0x6BD4A6C")]
	public static void ShowCashShop()
	{
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001421")]
	[Address(RVA = "0xBD4AF4", Offset = "0xBD4AF4", VA = "0x6BD4AF4")]
	public static void CallOption()
	{
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001422")]
	[Address(RVA = "0xBD4B7C", Offset = "0xBD4B7C", VA = "0x6BD4B7C")]
	public static void NotEnoughGold()
	{
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001423")]
	[Address(RVA = "0xBD4D54", Offset = "0xBD4D54", VA = "0x6BD4D54")]
	public static void NotEnoughStone()
	{
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001424")]
	[Address(RVA = "0xBD4DDC", Offset = "0xBD4DDC", VA = "0x6BD4DDC")]
	public static void NotEnoughRuby()
	{
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001425")]
	[Address(RVA = "0xBD4E64", Offset = "0xBD4E64", VA = "0x6BD4E64")]
	public static void NotEnoughHellStone()
	{
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001426")]
	[Address(RVA = "0xBD4EEC", Offset = "0xBD4EEC", VA = "0x6BD4EEC")]
	public static void NotEnoughMedal()
	{
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001427")]
	[Address(RVA = "0xBD4C04", Offset = "0xBD4C04", VA = "0x6BD4C04")]
	public static void OnErrorPopup(string strMsg)
	{
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001428")]
	[Address(RVA = "0xBD4F74", Offset = "0xBD4F74", VA = "0x6BD4F74")]
	public static void PlaySound(string strName, bool bPass = false)
	{
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001429")]
	[Address(RVA = "0xBD5398", Offset = "0xBD5398", VA = "0x6BD5398")]
	public static void PlayMusic()
	{
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600142A")]
	[Address(RVA = "0xBD5570", Offset = "0xBD5570", VA = "0x6BD5570")]
	public static void PlayMusic(string strName)
	{
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600142B")]
	[Address(RVA = "0xBD5698", Offset = "0xBD5698", VA = "0x6BD5698")]
	public static void StopMusic()
	{
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600142C")]
	[Address(RVA = "0xBD5740", Offset = "0xBD5740", VA = "0x6BD5740")]
	public static void LoadLevel(string strLevel, float fFadeIn, float fFadeOut, Color cl)
	{
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600142D")]
	[Address(RVA = "0xBD5858", Offset = "0xBD5858", VA = "0x6BD5858")]
	public static void TooltipShow(string strMsg)
	{
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600142E")]
	[Address(RVA = "0xBD5DAC", Offset = "0xBD5DAC", VA = "0x6BD5DAC")]
	public static void TooltipHide()
	{
	}

	// Token: 0x04001583 RID: 5507
	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0x0")]
	private static bool loadPackage;

	// Token: 0x04001584 RID: 5508
	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0x4")]
	public static Camera uiCamera;

	// Token: 0x04001585 RID: 5509
	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0x8")]
	public static UIMgr single;

	// Token: 0x04001586 RID: 5510
	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0xC")]
	public static UIPage focused;

	// Token: 0x04001587 RID: 5511
	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0x10")]
	public static List<UIPage> listPage;

	// Token: 0x04001588 RID: 5512
	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0x1C")]
	public Camera _uiCamera;

	// Token: 0x04001589 RID: 5513
	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0x14")]
	public static AudioSource asFX;

	// Token: 0x0400158A RID: 5514
	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0x18")]
	public static AudioSource asMusic;

	// Token: 0x0400158B RID: 5515
	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0x1C")]
	public static Dictionary<string, float> dictPlaylist;
}
