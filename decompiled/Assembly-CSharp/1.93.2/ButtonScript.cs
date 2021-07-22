using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000264 RID: 612
[Token(Token = "0x20001DA")]
public class ButtonScript : MonoBehaviour
{
	// Token: 0x06000ED2 RID: 3794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x2920F0", Offset = "0x2920F0", VA = "0x62920F0")]
	public ButtonScript()
	{
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x2920F8", Offset = "0x2920F8", VA = "0x62920F8")]
	private void Start()
	{
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x292360", Offset = "0x292360", VA = "0x6292360")]
	private void Update()
	{
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x292244", Offset = "0x292244", VA = "0x6292244")]
	public void getProjectileNames()
	{
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x29239C", Offset = "0x29239C", VA = "0x629239C")]
	public bool overButton()
	{
		return default(bool);
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x2924F4", Offset = "0x2924F4", VA = "0x62924F4")]
	public void LoadStage1()
	{
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x292554", Offset = "0x292554", VA = "0x6292554")]
	public void LoadStage2()
	{
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x2925B4", Offset = "0x2925B4", VA = "0x62925B4")]
	public void LoadStage3()
	{
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x292614", Offset = "0x292614", VA = "0x6292614")]
	public void LoadStage4()
	{
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x292674", Offset = "0x292674", VA = "0x6292674")]
	public void LoadStage5()
	{
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x2926D4", Offset = "0x2926D4", VA = "0x62926D4")]
	public void LoadStage6()
	{
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x292734", Offset = "0x292734", VA = "0x6292734")]
	public void LoadStage7()
	{
	}

	// Token: 0x04000757 RID: 1879
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Button;

	// Token: 0x04000758 RID: 1880
	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x10")]
	private Text MyButtonText;

	// Token: 0x04000759 RID: 1881
	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x14")]
	private string projectileParticleName;

	// Token: 0x0400075A RID: 1882
	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x18")]
	private FireProjectile effectScript;

	// Token: 0x0400075B RID: 1883
	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x1C")]
	private ProjectileScript projectileScript;

	// Token: 0x0400075C RID: 1884
	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x20")]
	public float buttonsX;

	// Token: 0x0400075D RID: 1885
	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x24")]
	public float buttonsY;

	// Token: 0x0400075E RID: 1886
	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x28")]
	public float buttonsSizeX;

	// Token: 0x0400075F RID: 1887
	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x2C")]
	public float buttonsSizeY;

	// Token: 0x04000760 RID: 1888
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x30")]
	public float buttonsDistance;
}
