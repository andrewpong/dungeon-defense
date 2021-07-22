using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200030B RID: 779
[Token(Token = "0x2000276")]
public class DungeonElt : MonoBehaviour
{
	// Token: 0x0600116C RID: 4460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x2F0108", Offset = "0x2F0108", VA = "0x62F0108")]
	public DungeonElt()
	{
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x2F0110", Offset = "0x2F0110", VA = "0x62F0110")]
	public void Refresh(DungeonType _eID)
	{
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x2F085C", Offset = "0x2F085C", VA = "0x62F085C")]
	public void OnBuild()
	{
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x2F08E8", Offset = "0x2F08E8", VA = "0x62F08E8")]
	public void OnBuildMulti()
	{
	}

	// Token: 0x04000F48 RID: 3912
	[Token(Token = "0x4000D99")]
	[FieldOffset(Offset = "0xC")]
	public Image imgIcon;

	// Token: 0x04000F49 RID: 3913
	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x10")]
	public Button btnBuild;

	// Token: 0x04000F4A RID: 3914
	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0x14")]
	public Button btnBuild10;

	// Token: 0x04000F4B RID: 3915
	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x18")]
	public Text textName;

	// Token: 0x04000F4C RID: 3916
	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x1C")]
	public Text textDesc;

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x20")]
	public Text textGold;

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x24")]
	public Text textLevel;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x28")]
	public Text textBuild;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x2C")]
	public Text textBuild10;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x30")]
	private DungeonType eID;
}
