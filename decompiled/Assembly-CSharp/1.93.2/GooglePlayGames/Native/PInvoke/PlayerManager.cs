using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x2000173")]
	internal class PlayerManager
	{
		// Token: 0x06000D43 RID: 3395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x47FE0C", Offset = "0x47FE0C", VA = "0x647FE0C")]
		internal PlayerManager(GameServices services)
		{
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x47FE84", Offset = "0x47FE84", VA = "0x647FE84")]
		internal void FetchSelf(Action<PlayerManager.FetchSelfResponse> callback)
		{
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x47FC08", Offset = "0x47FC08", VA = "0x647FC08")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1864CC", Offset = "0x1864CC")]
		private static void InternalFetchSelfCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x480054", Offset = "0x480054", VA = "0x6480054")]
		internal void FetchList(string[] userIds, Action<NativePlayer[]> callback)
		{
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x47FCB4", Offset = "0x47FCB4", VA = "0x647FCB4")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186544", Offset = "0x186544")]
		private static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x4804D0", Offset = "0x4804D0", VA = "0x64804D0")]
		internal void HandleFetchResponse(PlayerManager.FetchResponseCollector collector, PlayerManager.FetchResponse resp)
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x48078C", Offset = "0x48078C", VA = "0x648078C")]
		internal void FetchFriends(Action<ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x47FD60", Offset = "0x47FD60", VA = "0x647FD60")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1865BC", Offset = "0x1865BC")]
		private static void InternalFetchConnectedCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x480A08", Offset = "0x480A08", VA = "0x6480A08")]
		internal void HandleFetchCollected(PlayerManager.FetchListResponse rsp, Action<ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
		{
		}

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly GameServices mGameServices;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181100", Offset = "0x181100")]
		private static Func<IntPtr, PlayerManager.FetchSelfResponse> <>f__mg$cache0;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181110", Offset = "0x181110")]
		private static PlayerManager.FetchSelfCallback <>f__mg$cache1;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181120", Offset = "0x181120")]
		private static Func<IntPtr, PlayerManager.FetchResponse> <>f__mg$cache2;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181130", Offset = "0x181130")]
		private static PlayerManager.FetchCallback <>f__mg$cache3;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181140", Offset = "0x181140")]
		private static Func<IntPtr, PlayerManager.FetchListResponse> <>f__mg$cache4;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181150", Offset = "0x181150")]
		private static PlayerManager.FetchListCallback <>f__mg$cache5;

		// Token: 0x020001F7 RID: 503
		[Token(Token = "0x2000174")]
		internal class FetchListResponse : BaseReferenceHolder, IEnumerable<NativePlayer>, IEnumerable
		{
			// Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x481098", Offset = "0x481098", VA = "0x6481098")]
			internal FetchListResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x481124", Offset = "0x481124", VA = "0x6481124", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000D4E RID: 3406 RVA: 0x00006228 File Offset: 0x00004428
			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x480ED0", Offset = "0x480ED0", VA = "0x6480ED0")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000D4F RID: 3407 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x480F30", Offset = "0x480F30", VA = "0x6480F30", Slot = "6")]
			public IEnumerator<NativePlayer> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000D50 RID: 3408 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x481154", Offset = "0x481154", VA = "0x6481154", Slot = "7")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000D51 RID: 3409 RVA: 0x00006240 File Offset: 0x00004440
			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x480F00", Offset = "0x480F00", VA = "0x6480F00")]
			internal UIntPtr Length()
			{
				return 0;
			}

			// Token: 0x06000D52 RID: 3410 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x481158", Offset = "0x481158", VA = "0x6481158")]
			internal NativePlayer GetElement(UIntPtr index)
			{
				return null;
			}

			// Token: 0x06000D53 RID: 3411 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x481290", Offset = "0x481290", VA = "0x6481290")]
			internal static PlayerManager.FetchListResponse FromPointer(IntPtr selfPointer)
			{
				return null;
			}

			// Token: 0x06000D54 RID: 3412 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x481340", Offset = "0x481340", VA = "0x6481340")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x186634", Offset = "0x186634")]
			private NativePlayer <GetEnumerator>m__0(UIntPtr index)
			{
				return null;
			}
		}

		// Token: 0x020001F8 RID: 504
		[Token(Token = "0x2000175")]
		internal class FetchResponseCollector
		{
			// Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x480444", Offset = "0x480444", VA = "0x6480444")]
			public FetchResponseCollector()
			{
			}

			// Token: 0x04000572 RID: 1394
			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int pendingCount;

			// Token: 0x04000573 RID: 1395
			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal List<NativePlayer> results;

			// Token: 0x04000574 RID: 1396
			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Action<NativePlayer[]> callback;
		}

		// Token: 0x020001F9 RID: 505
		[Token(Token = "0x2000176")]
		internal class FetchResponse : BaseReferenceHolder
		{
			// Token: 0x06000D56 RID: 3414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x481344", Offset = "0x481344", VA = "0x6481344")]
			internal FetchResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x4813D0", Offset = "0x4813D0", VA = "0x64813D0", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x4806F4", Offset = "0x4806F4", VA = "0x64806F4")]
			internal NativePlayer GetPlayer()
			{
				return null;
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x00006258 File Offset: 0x00004458
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x4806C4", Offset = "0x4806C4", VA = "0x64806C4")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x481400", Offset = "0x481400", VA = "0x6481400")]
			internal static PlayerManager.FetchResponse FromPointer(IntPtr selfPointer)
			{
				return null;
			}
		}

		// Token: 0x020001FA RID: 506
		[Token(Token = "0x2000177")]
		internal class FetchSelfResponse : BaseReferenceHolder
		{
			// Token: 0x06000D5B RID: 3419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x4814B0", Offset = "0x4814B0", VA = "0x64814B0")]
			internal FetchSelfResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000D5C RID: 3420 RVA: 0x00006270 File Offset: 0x00004470
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x48153C", Offset = "0x48153C", VA = "0x648153C")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x48156C", Offset = "0x48156C", VA = "0x648156C")]
			internal NativePlayer Self()
			{
				return null;
			}

			// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x481604", Offset = "0x481604", VA = "0x6481604", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000D5F RID: 3423 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x481634", Offset = "0x481634", VA = "0x6481634")]
			internal static PlayerManager.FetchSelfResponse FromPointer(IntPtr selfPointer)
			{
				return null;
			}
		}

		// Token: 0x020001FB RID: 507
		[Token(Token = "0x2000338")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FCF0", Offset = "0x17FCF0")]
		private sealed class <FetchList>c__AnonStorey0
		{
			// Token: 0x06000D60 RID: 3424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001584")]
			[Address(RVA = "0x48043C", Offset = "0x48043C", VA = "0x648043C")]
			public <FetchList>c__AnonStorey0()
			{
			}

			// Token: 0x06000D61 RID: 3425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001585")]
			[Address(RVA = "0x481064", Offset = "0x481064", VA = "0x6481064")]
			internal void <>m__0(PlayerManager.FetchResponse rsp)
			{
			}

			// Token: 0x04000575 RID: 1397
			[Token(Token = "0x400141B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal PlayerManager.FetchResponseCollector coll;

			// Token: 0x04000576 RID: 1398
			[Token(Token = "0x400141C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal PlayerManager $this;
		}

		// Token: 0x020001FC RID: 508
		[Token(Token = "0x2000339")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD00", Offset = "0x17FD00")]
		private sealed class <FetchFriends>c__AnonStorey1
		{
			// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001586")]
			[Address(RVA = "0x480A00", Offset = "0x480A00", VA = "0x6480A00")]
			public <FetchFriends>c__AnonStorey1()
			{
			}

			// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001587")]
			[Address(RVA = "0x481030", Offset = "0x481030", VA = "0x6481030")]
			internal void <>m__0(PlayerManager.FetchListResponse rsp)
			{
			}

			// Token: 0x04000577 RID: 1399
			[Token(Token = "0x400141D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback;

			// Token: 0x04000578 RID: 1400
			[Token(Token = "0x400141E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal PlayerManager $this;
		}
	}
}
