using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000316 RID: 790
[Token(Token = "0x200027F")]
public class MonTraitElt : MonoBehaviour
{
	// Token: 0x060012FE RID: 4862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001166")]
	[Address(RVA = "0x2A8C1C", Offset = "0x2A8C1C", VA = "0x62A8C1C")]
	public MonTraitElt()
	{
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x060012FF RID: 4863 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000180")]
	private Text textPoint
	{
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x2A8C24", Offset = "0x2A8C24", VA = "0x62A8C24")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06001300 RID: 4864 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000181")]
	private Button btn
	{
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x2A8CD8", Offset = "0x2A8CD8", VA = "0x62A8CD8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x2A8E60", Offset = "0x2A8E60", VA = "0x62A8E60")]
	public void Refresh()
	{
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x2A8D98", Offset = "0x2A8D98", VA = "0x62A8D98")]
	private void AddUpListener(Button b)
	{
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x2A91A8", Offset = "0x2A91A8", VA = "0x62A91A8")]
	public void RefreshHighlight(short sID, MonTraitID _eID)
	{
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116C")]
	[Address(RVA = "0x2A91F8", Offset = "0x2A91F8", VA = "0x62A91F8")]
	public void OnSelected()
	{
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x2A927C", Offset = "0x2A927C", VA = "0x62A927C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187ABC", Offset = "0x187ABC")]
	private void <AddUpListener>m__0()
	{
	}

	// Token: 0x0400107A RID: 4218
	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x0400107B RID: 4219
	[Token(Token = "0x4000EC0")]
	[FieldOffset(Offset = "0x10")]
	public Image imgHighlight;

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x14")]
	public int nMonID;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x18")]
	public MonTraitID eID;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x1C")]
	public MonTraitID ePreID;

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x20")]
	public int nPreLearn;

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4000EC5")]
	[FieldOffset(Offset = "0x24")]
	private Text _textPoint;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x28")]
	private Button _btn;
}
