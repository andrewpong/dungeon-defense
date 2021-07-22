using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000359 RID: 857
[Token(Token = "0x20002A1")]
public class PopupResearchPlanner : UIPage
{
	// Token: 0x060015A4 RID: 5540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001356")]
	[Address(RVA = "0x4120E4", Offset = "0x4120E4", VA = "0x64120E4")]
	public PopupResearchPlanner()
	{
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x4120EC", Offset = "0x4120EC", VA = "0x64120EC", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001358")]
	[Address(RVA = "0x4136F8", Offset = "0x4136F8", VA = "0x64136F8", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001359")]
	[Address(RVA = "0x4137C0", Offset = "0x4137C0", VA = "0x64137C0")]
	private void AddUpListener(Button b, int value)
	{
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x4138D8", Offset = "0x4138D8", VA = "0x64138D8")]
	private void AddDownListener(Button b, int value)
	{
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x413A00", Offset = "0x413A00", VA = "0x6413A00", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x413AFC", Offset = "0x413AFC", VA = "0x6413AFC")]
	public void OnClose()
	{
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x412AA0", Offset = "0x412AA0", VA = "0x6412AA0")]
	public void RefreshPlan()
	{
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135E")]
	[Address(RVA = "0x413B9C", Offset = "0x413B9C", VA = "0x6413B9C")]
	public void OnPlanUp(int i)
	{
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135F")]
	[Address(RVA = "0x413F78", Offset = "0x413F78", VA = "0x6413F78")]
	public void OnPlanDown(int i)
	{
	}

	// Token: 0x04001449 RID: 5193
	[Token(Token = "0x400116B")]
	[FieldOffset(Offset = "0x0")]
	public static PopupResearchPlanner obj;

	// Token: 0x0400144A RID: 5194
	[Token(Token = "0x400116C")]
	[FieldOffset(Offset = "0x1C")]
	public Text textTitle;

	// Token: 0x0400144B RID: 5195
	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x20")]
	public Image[] arrPlanIcon;

	// Token: 0x0400144C RID: 5196
	[Token(Token = "0x400116E")]
	[FieldOffset(Offset = "0x24")]
	public Text[] arrPlanName;

	// Token: 0x0400144D RID: 5197
	[Token(Token = "0x400116F")]
	[FieldOffset(Offset = "0x28")]
	public Text[] arrPlanCondition;

	// Token: 0x0400144E RID: 5198
	[Token(Token = "0x4001170")]
	[FieldOffset(Offset = "0x2C")]
	public Text[] arrPlanDesc;

	// Token: 0x0400144F RID: 5199
	[Token(Token = "0x4001171")]
	[FieldOffset(Offset = "0x30")]
	public Text[] arrPlanOrder;

	// Token: 0x04001450 RID: 5200
	[Token(Token = "0x4001172")]
	[FieldOffset(Offset = "0x34")]
	public Text[] arrPlanNeed;

	// Token: 0x04001451 RID: 5201
	[Token(Token = "0x4001173")]
	[FieldOffset(Offset = "0x38")]
	public Image[] arrPlanUp;

	// Token: 0x04001452 RID: 5202
	[Token(Token = "0x4001174")]
	[FieldOffset(Offset = "0x3C")]
	public Image[] arrPlanDown;

	// Token: 0x04001453 RID: 5203
	[Token(Token = "0x4001175")]
	[FieldOffset(Offset = "0x40")]
	public Button[] arrPlanBtnUp;

	// Token: 0x04001454 RID: 5204
	[Token(Token = "0x4001176")]
	[FieldOffset(Offset = "0x44")]
	public Button[] arrPlanBtnDown;

	// Token: 0x0200035A RID: 858
	[Token(Token = "0x2000375")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180050", Offset = "0x180050")]
	private sealed class <AddUpListener>c__AnonStorey0
	{
		// Token: 0x060015AE RID: 5550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x4139F0", Offset = "0x4139F0", VA = "0x64139F0")]
		public <AddUpListener>c__AnonStorey0()
		{
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x41436C", Offset = "0x41436C", VA = "0x641436C")]
		internal void <>m__0()
		{
		}

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x40015AE")]
		[FieldOffset(Offset = "0x8")]
		internal int value;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x40015AF")]
		[FieldOffset(Offset = "0xC")]
		internal PopupResearchPlanner $this;
	}

	// Token: 0x0200035B RID: 859
	[Token(Token = "0x2000376")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180060", Offset = "0x180060")]
	private sealed class <AddDownListener>c__AnonStorey1
	{
		// Token: 0x060015B0 RID: 5552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x4139F8", Offset = "0x4139F8", VA = "0x64139F8")]
		public <AddDownListener>c__AnonStorey1()
		{
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x41433C", Offset = "0x41433C", VA = "0x641433C")]
		internal void <>m__0()
		{
		}

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x40015B0")]
		[FieldOffset(Offset = "0x8")]
		internal int value;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x40015B1")]
		[FieldOffset(Offset = "0xC")]
		internal PopupResearchPlanner $this;
	}
}
