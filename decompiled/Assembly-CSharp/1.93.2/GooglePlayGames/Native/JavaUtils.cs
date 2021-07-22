using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Native
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000122")]
	internal static class JavaUtils
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x6DA204", Offset = "0x6DA204", VA = "0x66DA204")]
		internal static AndroidJavaObject JavaObjectFromPointer(IntPtr jobject)
		{
			return null;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x6DA3C8", Offset = "0x6DA3C8", VA = "0x66DA3C8")]
		internal static AndroidJavaObject NullSafeCall(this AndroidJavaObject target, string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x0")]
		private static ConstructorInfo IntPtrConstructor;
	}
}
