using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200033E RID: 830
[Token(Token = "0x2000289")]
public class PopupAwakening : UIPage
{
	// Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126F")]
	[Address(RVA = "0x36FF08", Offset = "0x36FF08", VA = "0x636FF08")]
	public PopupAwakening()
	{
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001270")]
	[Address(RVA = "0x36FF10", Offset = "0x36FF10", VA = "0x636FF10", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001271")]
	[Address(RVA = "0x3700B0", Offset = "0x3700B0", VA = "0x63700B0", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001272")]
	[Address(RVA = "0x371748", Offset = "0x371748", VA = "0x6371748", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001273")]
	[Address(RVA = "0x371844", Offset = "0x371844", VA = "0x6371844")]
	public void OnClose()
	{
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x3718DC", Offset = "0x3718DC", VA = "0x63718DC")]
	public void OnAwaken()
	{
	}

	// Token: 0x040012F6 RID: 4854
	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x1C")]
	public Image imgMonPre;

	// Token: 0x040012F7 RID: 4855
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x20")]
	public Image imgMonAft;

	// Token: 0x040012F8 RID: 4856
	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x24")]
	public Text textTitle;

	// Token: 0x040012F9 RID: 4857
	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x28")]
	public Text textCondition;

	// Token: 0x040012FA RID: 4858
	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x2C")]
	public Text textDesc;

	// Token: 0x040012FB RID: 4859
	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x30")]
	public Text textSkill;

	// Token: 0x040012FC RID: 4860
	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0x34")]
	public Text textBtnAwk;

	// Token: 0x040012FD RID: 4861
	[Token(Token = "0x4001030")]
	[FieldOffset(Offset = "0x38")]
	public Button btnAwaken;

	// Token: 0x040012FE RID: 4862
	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x3C")]
	public CharSkillElt[] arrSkillElt;

	// Token: 0x040012FF RID: 4863
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x0")]
	public static PopupAwakening obj;

	// Token: 0x04001300 RID: 4864
	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x40")]
	private bool canAwake;

	// Token: 0x04001301 RID: 4865
	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x4")]
	private static string red;

	// Token: 0x04001302 RID: 4866
	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x8")]
	private static string white;
}
