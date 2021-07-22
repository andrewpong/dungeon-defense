using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x200016F")]
	internal static class PInvokeUtilities
	{
		// Token: 0x06000D26 RID: 3366 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x47F3A4", Offset = "0x47F3A4", VA = "0x647F3A4")]
		internal static HandleRef CheckNonNull(HandleRef reference)
		{
			return default(HandleRef);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x47F480", Offset = "0x47F480", VA = "0x647F480")]
		internal static bool IsNull(HandleRef reference)
		{
			return default(bool);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x47CCD4", Offset = "0x47CCD4", VA = "0x647CCD4")]
		internal static bool IsNull(IntPtr pointer)
		{
			return default(bool);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x47A45C", Offset = "0x47A45C", VA = "0x647A45C")]
		internal static DateTime FromMillisSinceUnixEpoch(long millisSinceEpoch)
		{
			return default(DateTime);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x475A28", Offset = "0x475A28", VA = "0x6475A28")]
		internal static string OutParamsToString(PInvokeUtilities.OutStringMethod outStringMethod)
		{
			return null;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BEF")]
		internal static T[] OutParamsToArray<T>(PInvokeUtilities.OutMethod<T> outMethod)
		{
			return null;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF0")]
		[DebuggerHidden]
		internal static IEnumerable<T> ToEnumerable<T>(UIntPtr size, Func<UIntPtr, T> getElement)
		{
			return null;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF1")]
		internal static IEnumerator<T> ToEnumerator<T>(UIntPtr size, Func<UIntPtr, T> getElement)
		{
			return null;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000BF2")]
		internal static UIntPtr ArrayToSizeT<T>(T[] array)
		{
			return 0;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x47F748", Offset = "0x47F748", VA = "0x647F748")]
		internal static long ToMilliseconds(TimeSpan span)
		{
			return 0L;
		}

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		// Token: 0x020001F2 RID: 498
		// (Invoke) Token: 0x06000D32 RID: 3378
		[Token(Token = "0x2000170")]
		internal delegate UIntPtr OutStringMethod([In] [Out] byte[] out_bytes, UIntPtr out_size);

		// Token: 0x020001F3 RID: 499
		// (Invoke) Token: 0x06000D36 RID: 3382
		[Token(Token = "0x2000171")]
		internal delegate UIntPtr OutMethod<T>([In] [Out] T[] out_bytes, UIntPtr out_size);

		// Token: 0x020001F4 RID: 500
		[Token(Token = "0x2000337")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FCE0", Offset = "0x17FCE0")]
		private sealed class <ToEnumerable>c__Iterator0<T> : IEnumerable, IEnumerable<T>, IEnumerator, IDisposable, IEnumerator<T>
		{
			// Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600157C")]
			[DebuggerHidden]
			public <ToEnumerable>c__Iterator0()
			{
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x000061F8 File Offset: 0x000043F8
			[Token(Token = "0x600157D")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B3")]
			private T Current
			{
				[Token(Token = "0x600157E")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B4")]
			private object Current
			{
				[Token(Token = "0x600157F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001580")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001581")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001582")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001583")]
			[DebuggerHidden]
			private IEnumerator<T> GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000565 RID: 1381
			[Token(Token = "0x4001415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ulong <i>__1;

			// Token: 0x04000566 RID: 1382
			[Token(Token = "0x4001416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal UIntPtr size;

			// Token: 0x04000567 RID: 1383
			[Token(Token = "0x4001417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Func<UIntPtr, T> getElement;

			// Token: 0x04000568 RID: 1384
			[Token(Token = "0x4001418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T $current;

			// Token: 0x04000569 RID: 1385
			[Token(Token = "0x4001419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool $disposing;

			// Token: 0x0400056A RID: 1386
			[Token(Token = "0x400141A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $PC;
		}
	}
}
