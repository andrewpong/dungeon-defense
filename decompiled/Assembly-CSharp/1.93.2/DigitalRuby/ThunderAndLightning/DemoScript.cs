using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000272 RID: 626
	[Token(Token = "0x20001E7")]
	public class DemoScript : MonoBehaviour
	{
		// Token: 0x06000F30 RID: 3888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x3C79E8", Offset = "0x3C79E8", VA = "0x63C79E8")]
		public DemoScript()
		{
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x3C7A40", Offset = "0x3C7A40", VA = "0x63C7A40")]
		private void UpdateThunder()
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x3C7C10", Offset = "0x3C7C10", VA = "0x63C7C10")]
		private void UpdateMovement()
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x3C7DF8", Offset = "0x3C7DF8", VA = "0x63C7DF8")]
		private void UpdateMouseLook()
		{
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x3C8408", Offset = "0x3C8408", VA = "0x63C8408")]
		private void UpdateQuality()
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x3C84C0", Offset = "0x3C84C0", VA = "0x63C84C0")]
		private void UpdateOther()
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x3C8594", Offset = "0x3C8594", VA = "0x63C8594")]
		private void OnGUI()
		{
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x3C88F0", Offset = "0x3C88F0", VA = "0x63C88F0")]
		private void Update()
		{
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x3C8920", Offset = "0x3C8920", VA = "0x63C8920")]
		private void Start()
		{
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x3C833C", Offset = "0x3C833C", VA = "0x63C833C")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x3C7404", Offset = "0x3C7404", VA = "0x63C7404")]
		public static void ReloadCurrentScene()
		{
		}

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0xC")]
		public ThunderAndLightningScript ThunderAndLightningScript;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x10")]
		public LightningBoltScript LightningBoltScript;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x14")]
		public ParticleSystem CloudParticleSystem;

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x18")]
		public float MoveSpeed;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x1C")]
		public bool EnableMouseLook;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x4000658")]
		private const float fastCloudSpeed = 50f;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x20")]
		private float deltaTime;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x24")]
		private float fpsIncrement;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x28")]
		private string fpsText;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x2C")]
		private DemoScript.RotationAxes axes;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x30")]
		private float sensitivityX;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x34")]
		private float sensitivityY;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x38")]
		private float minimumX;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x3C")]
		private float maximumX;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x40")]
		private float minimumY;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x44")]
		private float maximumY;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x48")]
		private float rotationX;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x4C")]
		private float rotationY;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion originalRotation;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GUIStyle style;

		// Token: 0x02000273 RID: 627
		[Token(Token = "0x20001E8")]
		private enum RotationAxes
		{
			// Token: 0x040007D1 RID: 2001
			[Token(Token = "0x4000668")]
			MouseXAndY,
			// Token: 0x040007D2 RID: 2002
			[Token(Token = "0x4000669")]
			MouseX,
			// Token: 0x040007D3 RID: 2003
			[Token(Token = "0x400066A")]
			MouseY
		}
	}
}
