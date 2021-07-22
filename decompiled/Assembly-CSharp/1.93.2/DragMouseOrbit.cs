using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000265 RID: 613
[Token(Token = "0x20001DB")]
[Attribute(Name = "AddComponentMenu", RVA = "0x17F084", Offset = "0x17F084")]
public class DragMouseOrbit : MonoBehaviour
{
	// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x2EF9A0", Offset = "0x2EF9A0", VA = "0x62EF9A0")]
	public DragMouseOrbit()
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x2EF9E8", Offset = "0x2EF9E8", VA = "0x62EF9E8")]
	private void Start()
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x2EFB10", Offset = "0x2EFB10", VA = "0x62EFB10")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x2F003C", Offset = "0x2F003C", VA = "0x62F003C")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	// Token: 0x04000761 RID: 1889
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0xC")]
	public Transform target;

	// Token: 0x04000762 RID: 1890
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x10")]
	public float distance;

	// Token: 0x04000763 RID: 1891
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x14")]
	public float xSpeed;

	// Token: 0x04000764 RID: 1892
	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x18")]
	public float ySpeed;

	// Token: 0x04000765 RID: 1893
	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x1C")]
	public float yMinLimit;

	// Token: 0x04000766 RID: 1894
	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x20")]
	public float yMaxLimit;

	// Token: 0x04000767 RID: 1895
	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x24")]
	public float distanceMin;

	// Token: 0x04000768 RID: 1896
	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x28")]
	public float distanceMax;

	// Token: 0x04000769 RID: 1897
	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x2C")]
	public float smoothTime;

	// Token: 0x0400076A RID: 1898
	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x30")]
	private float rotationYAxis;

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x34")]
	private float rotationXAxis;

	// Token: 0x0400076C RID: 1900
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x38")]
	private float velocityX;

	// Token: 0x0400076D RID: 1901
	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x3C")]
	private float velocityY;
}
