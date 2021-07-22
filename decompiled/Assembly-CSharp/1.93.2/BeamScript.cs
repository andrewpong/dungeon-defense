using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200026A RID: 618
[Token(Token = "0x20001E0")]
public class BeamScript : MonoBehaviour
{
	// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x28EB10", Offset = "0x28EB10", VA = "0x628EB10")]
	public BeamScript()
	{
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x28EB34", Offset = "0x28EB34", VA = "0x628EB34")]
	private void Start()
	{
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x28ED40", Offset = "0x28ED40", VA = "0x628ED40")]
	private void Update()
	{
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x28F980", Offset = "0x28F980", VA = "0x628F980")]
	public void nextBeam()
	{
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x28FACC", Offset = "0x28FACC", VA = "0x628FACC")]
	public void previousBeam()
	{
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x28FC10", Offset = "0x28FC10", VA = "0x628FC10")]
	public void UpdateEndOffset()
	{
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x28FC4C", Offset = "0x28FC4C", VA = "0x628FC4C")]
	public void UpdateScrollSpeed()
	{
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x28F318", Offset = "0x28F318", VA = "0x628F318")]
	private void ShootBeamInDir(Vector3 start, Vector3 dir)
	{
	}

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x181574", Offset = "0x181574")]
	public GameObject[] beamLineRendererPrefab;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x10")]
	public GameObject[] beamStartPrefab;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x14")]
	public GameObject[] beamEndPrefab;

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x18")]
	private int currentBeam;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject beamStart;

	// Token: 0x0400077E RID: 1918
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x20")]
	private GameObject beamEnd;

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x24")]
	private GameObject beam;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x28")]
	private LineRenderer line;

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1815A8", Offset = "0x1815A8")]
	public float beamEndOffset;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0x30")]
	public float textureScrollSpeed;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0x34")]
	public float textureLengthScale;

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1815EC", Offset = "0x1815EC")]
	public Slider endOffSetSlider;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x3C")]
	public Slider scrollSpeedSlider;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x181634", Offset = "0x181634")]
	public Text textBeamName;
}
