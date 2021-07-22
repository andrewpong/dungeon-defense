using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000341 RID: 833
[Token(Token = "0x200028C")]
public class PopupBuildOrder : UIPage
{
	// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001280")]
	[Address(RVA = "0x373038", Offset = "0x373038", VA = "0x6373038")]
	public PopupBuildOrder()
	{
	}

	// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x373040", Offset = "0x373040", VA = "0x6373040", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x373BA4", Offset = "0x373BA4", VA = "0x6373BA4")]
	private void Refresh()
	{
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x374190", Offset = "0x374190", VA = "0x6374190")]
	public void OnBuildOrderUp(int nPos)
	{
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x3745C0", Offset = "0x3745C0", VA = "0x63745C0")]
	public void OnBuildOrderDown(int nPos)
	{
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x3749F0", Offset = "0x3749F0", VA = "0x63749F0")]
	public void OnBuildNumberUp(int nPos)
	{
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x374BE0", Offset = "0x374BE0", VA = "0x6374BE0")]
	public void OnBuildNumberDown(int nPos)
	{
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x374DD0", Offset = "0x374DD0", VA = "0x6374DD0")]
	public void OnRepeatUp()
	{
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x374F5C", Offset = "0x374F5C", VA = "0x6374F5C")]
	public void OnRepeatDown()
	{
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x3750E8", Offset = "0x3750E8", VA = "0x63750E8", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x3751E4", Offset = "0x3751E4", VA = "0x63751E4")]
	public void OnClose()
	{
	}

	// Token: 0x04001308 RID: 4872
	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x1C")]
	public Text textTitle;

	// Token: 0x04001309 RID: 4873
	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x20")]
	public Text textBuildOrder;

	// Token: 0x0400130A RID: 4874
	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0x24")]
	public Text textBuildNumber;

	// Token: 0x0400130B RID: 4875
	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0x28")]
	public Text textRepeat;

	// Token: 0x0400130C RID: 4876
	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x2C")]
	public Text textRepeatNumber;

	// Token: 0x0400130D RID: 4877
	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goRepeatDown;

	// Token: 0x0400130E RID: 4878
	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0x34")]
	public Text[] arrBuildOrder;

	// Token: 0x0400130F RID: 4879
	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x38")]
	public Text[] arrBuildNumber;

	// Token: 0x04001310 RID: 4880
	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x3C")]
	public Text[] arrBuildName;

	// Token: 0x04001311 RID: 4881
	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] arrBuildOrderUp;

	// Token: 0x04001312 RID: 4882
	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0x44")]
	public GameObject[] arrBuildOrderDown;

	// Token: 0x04001313 RID: 4883
	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] arrBuildNumberUp;

	// Token: 0x04001314 RID: 4884
	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject[] arrBuildNumberDown;
}
