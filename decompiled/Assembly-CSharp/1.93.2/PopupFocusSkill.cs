using System;
using System.Collections.Generic;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000348 RID: 840
[Token(Token = "0x2000292")]
public class PopupFocusSkill : UIPage
{
	// Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x37CC5C", Offset = "0x37CC5C", VA = "0x637CC5C")]
	public PopupFocusSkill()
	{
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x37CCE8", Offset = "0x37CCE8", VA = "0x637CCE8", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x37DF34", Offset = "0x37DF34", VA = "0x637DF34", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x37DCF0", Offset = "0x37DCF0", VA = "0x637DCF0")]
	private void RefreshChecker()
	{
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x37E200", Offset = "0x37E200", VA = "0x637E200")]
	public void OnCheckSkill(int nPos)
	{
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x37E030", Offset = "0x37E030", VA = "0x637E030")]
	public void OnClose()
	{
	}

	// Token: 0x04001358 RID: 4952
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x1C")]
	public Text textDesc;

	// Token: 0x04001359 RID: 4953
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x20")]
	public Text[] textSkillName;

	// Token: 0x0400135A RID: 4954
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x24")]
	public Image imgChar;

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x28")]
	public Button[] btnSkill;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject[] goChecker;

	// Token: 0x0400135D RID: 4957
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform rtContent;

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x34")]
	private List<SkillKey> listSkill;

	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000371")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180030", Offset = "0x180030")]
	private sealed class <Awake>c__AnonStorey0
	{
		// Token: 0x060014FA RID: 5370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x37DCE8", Offset = "0x37DCE8", VA = "0x637DCE8")]
		public <Awake>c__AnonStorey0()
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x37EBE0", Offset = "0x37EBE0", VA = "0x637EBE0")]
		internal int <>m__0(SkillKey x, SkillKey y)
		{
			return 0;
		}

		// Token: 0x0400135F RID: 4959
		[Token(Token = "0x40015A8")]
		[FieldOffset(Offset = "0x8")]
		internal PlayerMonsterData pData;
	}
}
