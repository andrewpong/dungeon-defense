using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x2000146")]
	internal class EventManager
	{
		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x454684", Offset = "0x454684", VA = "0x6454684")]
		internal EventManager(GameServices services)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x4546FC", Offset = "0x4546FC", VA = "0x64546FC")]
		internal void FetchAll(Types.DataSource source, Action<EventManager.FetchAllResponse> callback)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x45453C", Offset = "0x45453C", VA = "0x645453C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185A14", Offset = "0x185A14")]
		internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x4548D0", Offset = "0x4548D0", VA = "0x64548D0")]
		internal void Fetch(Types.DataSource source, string eventId, Action<EventManager.FetchResponse> callback)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x4545E0", Offset = "0x4545E0", VA = "0x64545E0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185A8C", Offset = "0x185A8C")]
		internal static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x454AA8", Offset = "0x454AA8", VA = "0x6454AA8")]
		internal void Increment(string eventId, uint steps)
		{
		}

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly GameServices mServices;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F20", Offset = "0x180F20")]
		private static Func<IntPtr, EventManager.FetchAllResponse> <>f__mg$cache0;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F30", Offset = "0x180F30")]
		private static EventManager.FetchAllCallback <>f__mg$cache1;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F40", Offset = "0x180F40")]
		private static Func<IntPtr, EventManager.FetchResponse> <>f__mg$cache2;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F50", Offset = "0x180F50")]
		private static EventManager.FetchCallback <>f__mg$cache3;

		// Token: 0x020001C6 RID: 454
		[Token(Token = "0x2000147")]
		internal class FetchResponse : BaseReferenceHolder
		{
			// Token: 0x06000BAC RID: 2988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x454EF8", Offset = "0x454EF8", VA = "0x6454EF8")]
			internal FetchResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x00005598 File Offset: 0x00003798
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x454F80", Offset = "0x454F80", VA = "0x6454F80")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000BAE RID: 2990 RVA: 0x000055B0 File Offset: 0x000037B0
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x454FAC", Offset = "0x454FAC", VA = "0x6454FAC")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000BAF RID: 2991 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x454FE8", Offset = "0x454FE8", VA = "0x6454FE8")]
			internal NativeEvent Data()
			{
				return null;
			}

			// Token: 0x06000BB0 RID: 2992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x455094", Offset = "0x455094", VA = "0x6455094", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x4550A4", Offset = "0x4550A4", VA = "0x64550A4")]
			internal static EventManager.FetchResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x020001C7 RID: 455
		[Token(Token = "0x2000148")]
		internal class FetchAllResponse : BaseReferenceHolder
		{
			// Token: 0x06000BB2 RID: 2994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x454B00", Offset = "0x454B00", VA = "0x6454B00")]
			internal FetchAllResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000BB3 RID: 2995 RVA: 0x000055C8 File Offset: 0x000037C8
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x454B88", Offset = "0x454B88", VA = "0x6454B88")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x454BB4", Offset = "0x454BB4", VA = "0x6454BB4")]
			internal List<NativeEvent> Data()
			{
				return null;
			}

			// Token: 0x06000BB5 RID: 2997 RVA: 0x000055E0 File Offset: 0x000037E0
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x454D40", Offset = "0x454D40", VA = "0x6454D40")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x454D7C", Offset = "0x454D7C", VA = "0x6454D7C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000BB7 RID: 2999 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x454D8C", Offset = "0x454D8C", VA = "0x6454D8C")]
			internal static EventManager.FetchAllResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x000055F8 File Offset: 0x000037F8
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x454E40", Offset = "0x454E40", VA = "0x6454E40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185B04", Offset = "0x185B04")]
			private UIntPtr <Data>m__0(IntPtr[] out_arg, UIntPtr out_size)
			{
				return 0;
			}

			// Token: 0x06000BB9 RID: 3001 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x454E84", Offset = "0x454E84", VA = "0x6454E84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185B14", Offset = "0x185B14")]
			private static NativeEvent <Data>m__1(IntPtr ptr)
			{
				return null;
			}

			// Token: 0x04000535 RID: 1333
			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F60", Offset = "0x180F60")]
			private static Func<IntPtr, NativeEvent> <>f__am$cache0;
		}
	}
}
