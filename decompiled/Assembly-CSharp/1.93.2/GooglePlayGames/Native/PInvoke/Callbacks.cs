using System;
using System.Collections;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x2000142")]
	internal static class Callbacks
	{
		// Token: 0x06000B82 RID: 2946 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x6000A58")]
		internal static IntPtr ToIntPtr<T>(Action<T> callback, Func<IntPtr, T> conversionFunction) where T : BaseReferenceHolder
		{
			return 0;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000A59")]
		internal static IntPtr ToIntPtr<T, P>(Action<T, P> callback, Func<IntPtr, P> conversionFunction) where P : BaseReferenceHolder
		{
			return 0;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x451E7C", Offset = "0x451E7C", VA = "0x6451E7C")]
		internal static IntPtr ToIntPtr(Delegate callback)
		{
			return 0;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A5B")]
		internal static T IntPtrToTempCallback<T>(IntPtr handle) where T : class
		{
			return null;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A5C")]
		private static T IntPtrToCallback<T>(IntPtr handle, bool unpinHandle) where T : class
		{
			return null;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A5D")]
		internal static T IntPtrToPermanentCallback<T>(IntPtr handle) where T : class
		{
			return null;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x453ABC", Offset = "0x453ABC", VA = "0x6453ABC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185914", Offset = "0x185914")]
		internal static void InternalShowUICallback(CommonErrorStatus.UIStatus status, IntPtr data)
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x4520D0", Offset = "0x4520D0", VA = "0x64520D0")]
		internal static void PerformInternalCallback(string callbackName, Callbacks.Type callbackType, IntPtr response, IntPtr userData)
		{
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A60")]
		internal static void PerformInternalCallback<T>(string callbackName, Callbacks.Type callbackType, T param1, IntPtr param2, IntPtr userData)
		{
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A61")]
		internal static Action<T> AsOnGameThreadCallback<T>(Action<T> toInvokeOnGameThread)
		{
			return null;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A62")]
		internal static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return null;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x44B0DC", Offset = "0x44B0DC", VA = "0x644B0DC")]
		internal static void AsCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x453D38", Offset = "0x453D38", VA = "0x6453D38")]
		internal static byte[] IntPtrAndSizeToByteArray(IntPtr data, UIntPtr dataLength)
		{
			return null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x453ED4", Offset = "0x453ED4", VA = "0x6453ED4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18598C", Offset = "0x18598C")]
		private static void <NoopUICallback>m__0(CommonErrorStatus.UIStatus status)
		{
		}

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Action<CommonErrorStatus.UIStatus> NoopUICallback;

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x06000B92 RID: 2962
		[Token(Token = "0x2000143")]
		internal delegate void ShowUICallbackInternal(CommonErrorStatus.UIStatus status, IntPtr data);

		// Token: 0x020001BD RID: 445
		[Token(Token = "0x2000144")]
		internal enum Type
		{
			// Token: 0x04000522 RID: 1314
			[Token(Token = "0x40003E9")]
			Permanent,
			// Token: 0x04000523 RID: 1315
			[Token(Token = "0x40003EA")]
			Temporary
		}

		// Token: 0x020001BE RID: 446
		[Token(Token = "0x200032E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC70", Offset = "0x17FC70")]
		private sealed class <ToIntPtr>c__AnonStorey0<T> where T : BaseReferenceHolder
		{
			// Token: 0x06000B95 RID: 2965 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156A")]
			public <ToIntPtr>c__AnonStorey0()
			{
			}

			// Token: 0x06000B96 RID: 2966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156B")]
			internal void <>m__0(IntPtr result)
			{
			}

			// Token: 0x04000524 RID: 1316
			[Token(Token = "0x40013FB")]
			[FieldOffset(Offset = "0x0")]
			internal Func<IntPtr, T> conversionFunction;

			// Token: 0x04000525 RID: 1317
			[Token(Token = "0x40013FC")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T> callback;
		}

		// Token: 0x020001BF RID: 447
		[Token(Token = "0x200032F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC80", Offset = "0x17FC80")]
		private sealed class <ToIntPtr>c__AnonStorey1<T, P> where P : BaseReferenceHolder
		{
			// Token: 0x06000B97 RID: 2967 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156C")]
			public <ToIntPtr>c__AnonStorey1()
			{
			}

			// Token: 0x06000B98 RID: 2968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156D")]
			internal void <>m__0(T param1, IntPtr param2)
			{
			}

			// Token: 0x04000526 RID: 1318
			[Token(Token = "0x40013FD")]
			[FieldOffset(Offset = "0x0")]
			internal Func<IntPtr, P> conversionFunction;

			// Token: 0x04000527 RID: 1319
			[Token(Token = "0x40013FE")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T, P> callback;
		}

		// Token: 0x020001C0 RID: 448
		[Token(Token = "0x2000330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FC90", Offset = "0x17FC90")]
		private sealed class <AsOnGameThreadCallback>c__AnonStorey2<T>
		{
			// Token: 0x06000B99 RID: 2969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156E")]
			public <AsOnGameThreadCallback>c__AnonStorey2()
			{
			}

			// Token: 0x06000B9A RID: 2970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156F")]
			internal void <>m__0(T result)
			{
			}

			// Token: 0x04000528 RID: 1320
			[Token(Token = "0x40013FF")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T> toInvokeOnGameThread;

			// Token: 0x020001C1 RID: 449
			[Token(Token = "0x2000332")]
			private sealed class <AsOnGameThreadCallback>c__AnonStorey3
			{
				// Token: 0x06000B9B RID: 2971 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001572")]
				public <AsOnGameThreadCallback>c__AnonStorey3()
				{
				}

				// Token: 0x06000B9C RID: 2972 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001573")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000529 RID: 1321
				[Token(Token = "0x4001401")]
				[FieldOffset(Offset = "0x0")]
				internal T result;

				// Token: 0x0400052A RID: 1322
				[Token(Token = "0x4001402")]
				[FieldOffset(Offset = "0x0")]
				internal Callbacks.<AsOnGameThreadCallback>c__AnonStorey2<T> <>f__ref$2;
			}
		}

		// Token: 0x020001C2 RID: 450
		[Token(Token = "0x2000331")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FCA0", Offset = "0x17FCA0")]
		private sealed class <AsOnGameThreadCallback>c__AnonStorey4<T1, T2>
		{
			// Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001570")]
			public <AsOnGameThreadCallback>c__AnonStorey4()
			{
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001571")]
			internal void <>m__0(T1 result1, T2 result2)
			{
			}

			// Token: 0x0400052B RID: 1323
			[Token(Token = "0x4001400")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T1, T2> toInvokeOnGameThread;

			// Token: 0x020001C3 RID: 451
			[Token(Token = "0x2000333")]
			private sealed class <AsOnGameThreadCallback>c__AnonStorey5
			{
				// Token: 0x06000B9F RID: 2975 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001574")]
				public <AsOnGameThreadCallback>c__AnonStorey5()
				{
				}

				// Token: 0x06000BA0 RID: 2976 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001575")]
				internal void <>m__0()
				{
				}

				// Token: 0x0400052C RID: 1324
				[Token(Token = "0x4001403")]
				[FieldOffset(Offset = "0x0")]
				internal T1 result1;

				// Token: 0x0400052D RID: 1325
				[Token(Token = "0x4001404")]
				[FieldOffset(Offset = "0x0")]
				internal T2 result2;

				// Token: 0x0400052E RID: 1326
				[Token(Token = "0x4001405")]
				[FieldOffset(Offset = "0x0")]
				internal Callbacks.<AsOnGameThreadCallback>c__AnonStorey4<T1, T2> <>f__ref$4;
			}
		}
	}
}
