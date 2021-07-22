using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Google.Developers
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x200007C")]
	public class JavaObjWrapper
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x93CC4C", Offset = "0x93CC4C", VA = "0x693CC4C")]
		protected JavaObjWrapper()
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x93CCAC", Offset = "0x93CCAC", VA = "0x693CCAC")]
		public JavaObjWrapper(string clazzName)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x93CD28", Offset = "0x93CD28", VA = "0x693CD28")]
		public JavaObjWrapper(IntPtr rawObject)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x170000D7")]
		public IntPtr RawObject
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x93CD90", Offset = "0x93CD90", VA = "0x693CD90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x170000D8")]
		public virtual IntPtr RawClass
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x93CD98", Offset = "0x93CD98", VA = "0x693CD98", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x93CE28", Offset = "0x93CE28", VA = "0x693CE28")]
		public void CreateInstance(string clazzName, params object[] args)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x93CF9C", Offset = "0x93CF9C", VA = "0x693CF9C")]
		protected static jvalue[] ConstructArgArray(object[] theArgs)
		{
			return null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000575")]
		public static T StaticInvokeObjectCall<T>(string type, string name, string sig, params object[] args)
		{
			return null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x93D788", Offset = "0x93D788", VA = "0x693D788")]
		public static void StaticInvokeCallVoid(string type, string name, string sig, params object[] args)
		{
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000577")]
		public static T GetStaticObjectField<T>(string clsName, string name, string sig)
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x93D838", Offset = "0x93D838", VA = "0x693D838")]
		public static int GetStaticIntField(string clsName, string name)
		{
			return 0;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x93D8C8", Offset = "0x93D8C8", VA = "0x693D8C8")]
		public static string GetStaticStringField(string clsName, string name)
		{
			return null;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x93D958", Offset = "0x93D958", VA = "0x693D958")]
		public static float GetStaticFloatField(string clsName, string name)
		{
			return 0f;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x93D9E8", Offset = "0x93D9E8", VA = "0x693D9E8")]
		public void InvokeCallVoid(string name, string sig, params object[] args)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600057C")]
		public T InvokeCall<T>(string name, string sig, params object[] args)
		{
			return null;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600057D")]
		public static T StaticInvokeCall<T>(string type, string name, string sig, params object[] args)
		{
			return null;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600057E")]
		public T InvokeObjectCall<T>(string name, string sig, params object[] theArgs)
		{
			return null;
		}

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr raw;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0xC")]
		private IntPtr cachedRawClass;
	}
}
