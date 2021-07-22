using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000181")]
	internal class SnapshotManager
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x4860A4", Offset = "0x4860A4", VA = "0x64860A4")]
		internal SnapshotManager(GameServices services)
		{
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x48611C", Offset = "0x48611C", VA = "0x648611C")]
		internal void FetchAll(Types.DataSource source, Action<SnapshotManager.FetchAllResponse> callback)
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x485D48", Offset = "0x485D48", VA = "0x6485D48")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186C7C", Offset = "0x186C7C")]
		internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x4862F0", Offset = "0x4862F0", VA = "0x64862F0")]
		internal void SnapshotSelectUI(bool allowCreate, bool allowDelete, uint maxSnapshots, string uiTitle, Action<SnapshotManager.SnapshotSelectUIResponse> callback)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x485DF4", Offset = "0x485DF4", VA = "0x6485DF4")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186CF4", Offset = "0x186CF4")]
		internal static void InternalSnapshotSelectUICallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x4864E0", Offset = "0x4864E0", VA = "0x64864E0")]
		internal void Open(string fileName, Types.DataSource source, Types.SnapshotConflictPolicy conflictPolicy, Action<SnapshotManager.OpenResponse> callback)
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x485EA0", Offset = "0x485EA0", VA = "0x6485EA0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186D6C", Offset = "0x186D6C")]
		internal static void InternalOpenCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x4866F8", Offset = "0x4866F8", VA = "0x64866F8")]
		internal void Commit(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, byte[] updatedData, Action<SnapshotManager.CommitResponse> callback)
		{
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x48697C", Offset = "0x48697C", VA = "0x648697C")]
		internal void Resolve(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, string conflictId, Action<SnapshotManager.OpenResponse> callback)
		{
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x486BEC", Offset = "0x486BEC", VA = "0x6486BEC")]
		internal void Resolve(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, string conflictId, byte[] updatedData, Action<SnapshotManager.OpenResponse> callback)
		{
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x485F4C", Offset = "0x485F4C", VA = "0x6485F4C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186DE4", Offset = "0x186DE4")]
		internal static void InternalCommitCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x486EB0", Offset = "0x486EB0", VA = "0x6486EB0")]
		internal void Delete(NativeSnapshotMetadata metadata)
		{
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x486F70", Offset = "0x486F70", VA = "0x6486F70")]
		internal void Read(NativeSnapshotMetadata metadata, Action<SnapshotManager.ReadResponse> callback)
		{
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x485FF8", Offset = "0x485FF8", VA = "0x6485FF8")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186E5C", Offset = "0x186E5C")]
		internal static void InternalReadCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly GameServices mServices;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1812A0", Offset = "0x1812A0")]
		private static Func<IntPtr, SnapshotManager.FetchAllResponse> <>f__mg$cache0;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1812B0", Offset = "0x1812B0")]
		private static SnapshotManager.FetchAllCallback <>f__mg$cache1;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1812C0", Offset = "0x1812C0")]
		private static Func<IntPtr, SnapshotManager.SnapshotSelectUIResponse> <>f__mg$cache2;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1812D0", Offset = "0x1812D0")]
		private static SnapshotManager.SnapshotSelectUICallback <>f__mg$cache3;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1812E0", Offset = "0x1812E0")]
		private static Func<IntPtr, SnapshotManager.OpenResponse> <>f__mg$cache4;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1812F0", Offset = "0x1812F0")]
		private static SnapshotManager.OpenCallback <>f__mg$cache5;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181300", Offset = "0x181300")]
		private static Func<IntPtr, SnapshotManager.CommitResponse> <>f__mg$cache6;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181310", Offset = "0x181310")]
		private static SnapshotManager.CommitCallback <>f__mg$cache7;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181320", Offset = "0x181320")]
		private static Func<IntPtr, SnapshotManager.OpenResponse> <>f__mg$cache8;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181330", Offset = "0x181330")]
		private static SnapshotManager.OpenCallback <>f__mg$cache9;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181340", Offset = "0x181340")]
		private static Func<IntPtr, SnapshotManager.OpenResponse> <>f__mg$cacheA;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181350", Offset = "0x181350")]
		private static SnapshotManager.OpenCallback <>f__mg$cacheB;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181360", Offset = "0x181360")]
		private static Func<IntPtr, SnapshotManager.ReadResponse> <>f__mg$cacheC;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181370", Offset = "0x181370")]
		private static SnapshotManager.ReadCallback <>f__mg$cacheD;

		// Token: 0x02000209 RID: 521
		[Token(Token = "0x2000182")]
		internal class OpenResponse : BaseReferenceHolder
		{
			// Token: 0x06000DC9 RID: 3529 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x4877B4", Offset = "0x4877B4", VA = "0x64877B4")]
			internal OpenResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DCA RID: 3530 RVA: 0x000063C0 File Offset: 0x000045C0
			[Token(Token = "0x6000C7E")]
			[Address(RVA = "0x487840", Offset = "0x487840", VA = "0x6487840")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000DCB RID: 3531 RVA: 0x000063D8 File Offset: 0x000045D8
			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x487880", Offset = "0x487880", VA = "0x6487880")]
			internal CommonErrorStatus.SnapshotOpenStatus ResponseStatus()
			{
				return (CommonErrorStatus.SnapshotOpenStatus)0;
			}

			// Token: 0x06000DCC RID: 3532 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C80")]
			[Address(RVA = "0x4878B0", Offset = "0x4878B0", VA = "0x64878B0")]
			internal string ConflictId()
			{
				return null;
			}

			// Token: 0x06000DCD RID: 3533 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x4879EC", Offset = "0x4879EC", VA = "0x64879EC")]
			internal NativeSnapshotMetadata Data()
			{
				return null;
			}

			// Token: 0x06000DCE RID: 3534 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x487B00", Offset = "0x487B00", VA = "0x6487B00")]
			internal NativeSnapshotMetadata ConflictOriginal()
			{
				return null;
			}

			// Token: 0x06000DCF RID: 3535 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x487C14", Offset = "0x487C14", VA = "0x6487C14")]
			internal NativeSnapshotMetadata ConflictUnmerged()
			{
				return null;
			}

			// Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x487D28", Offset = "0x487D28", VA = "0x6487D28", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DD1 RID: 3537 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x487D38", Offset = "0x487D38", VA = "0x6487D38")]
			internal static SnapshotManager.OpenResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			// Token: 0x06000DD2 RID: 3538 RVA: 0x000063F0 File Offset: 0x000045F0
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x487DEC", Offset = "0x487DEC", VA = "0x6487DEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x186ED4", Offset = "0x186ED4")]
			private UIntPtr <ConflictId>m__0(byte[] out_string, UIntPtr out_size)
			{
				return 0;
			}
		}

		// Token: 0x0200020A RID: 522
		[Token(Token = "0x2000183")]
		internal class FetchAllResponse : BaseReferenceHolder
		{
			// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x487454", Offset = "0x487454", VA = "0x6487454")]
			internal FetchAllResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DD4 RID: 3540 RVA: 0x00006408 File Offset: 0x00004608
			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x4874E0", Offset = "0x4874E0", VA = "0x64874E0")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000DD5 RID: 3541 RVA: 0x00006420 File Offset: 0x00004620
			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x487510", Offset = "0x487510", VA = "0x6487510")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000DD6 RID: 3542 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x487550", Offset = "0x487550", VA = "0x6487550")]
			internal IEnumerable<NativeSnapshotMetadata> Data()
			{
				return null;
			}

			// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x487650", Offset = "0x487650", VA = "0x6487650", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DD8 RID: 3544 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x487660", Offset = "0x487660", VA = "0x6487660")]
			internal static SnapshotManager.FetchAllResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			// Token: 0x06000DD9 RID: 3545 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x487714", Offset = "0x487714", VA = "0x6487714")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x186EE4", Offset = "0x186EE4")]
			private NativeSnapshotMetadata <Data>m__0(UIntPtr index)
			{
				return null;
			}
		}

		// Token: 0x0200020B RID: 523
		[Token(Token = "0x2000184")]
		internal class CommitResponse : BaseReferenceHolder
		{
			// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x487194", Offset = "0x487194", VA = "0x6487194")]
			internal CommitResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DDB RID: 3547 RVA: 0x00006438 File Offset: 0x00004638
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x487220", Offset = "0x487220", VA = "0x6487220")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000DDC RID: 3548 RVA: 0x00006450 File Offset: 0x00004650
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x487250", Offset = "0x487250", VA = "0x6487250")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000DDD RID: 3549 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x487290", Offset = "0x487290", VA = "0x6487290")]
			internal NativeSnapshotMetadata Data()
			{
				return null;
			}

			// Token: 0x06000DDE RID: 3550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x487390", Offset = "0x487390", VA = "0x6487390", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DDF RID: 3551 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x4873A0", Offset = "0x4873A0", VA = "0x64873A0")]
			internal static SnapshotManager.CommitResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x0200020C RID: 524
		[Token(Token = "0x2000185")]
		internal class ReadResponse : BaseReferenceHolder
		{
			// Token: 0x06000DE0 RID: 3552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x487E34", Offset = "0x487E34", VA = "0x6487E34")]
			internal ReadResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DE1 RID: 3553 RVA: 0x00006468 File Offset: 0x00004668
			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x487EC0", Offset = "0x487EC0", VA = "0x6487EC0")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x00006480 File Offset: 0x00004680
			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x487EF0", Offset = "0x487EF0", VA = "0x6487EF0")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000DE3 RID: 3555 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x487F30", Offset = "0x487F30", VA = "0x6487F30")]
			internal byte[] Data()
			{
				return null;
			}

			// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x48806C", Offset = "0x48806C", VA = "0x648806C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DE5 RID: 3557 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x48807C", Offset = "0x48807C", VA = "0x648807C")]
			internal static SnapshotManager.ReadResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			// Token: 0x06000DE6 RID: 3558 RVA: 0x00006498 File Offset: 0x00004698
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x488130", Offset = "0x488130", VA = "0x6488130")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x186EF4", Offset = "0x186EF4")]
			private UIntPtr <Data>m__0(byte[] out_bytes, UIntPtr out_size)
			{
				return 0;
			}
		}

		// Token: 0x0200020D RID: 525
		[Token(Token = "0x2000186")]
		internal class SnapshotSelectUIResponse : BaseReferenceHolder
		{
			// Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x488178", Offset = "0x488178", VA = "0x6488178")]
			internal SnapshotSelectUIResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DE8 RID: 3560 RVA: 0x000064B0 File Offset: 0x000046B0
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x488204", Offset = "0x488204", VA = "0x6488204")]
			internal CommonErrorStatus.UIStatus RequestStatus()
			{
				return (CommonErrorStatus.UIStatus)0;
			}

			// Token: 0x06000DE9 RID: 3561 RVA: 0x000064C8 File Offset: 0x000046C8
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x488234", Offset = "0x488234", VA = "0x6488234")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000DEA RID: 3562 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x488274", Offset = "0x488274", VA = "0x6488274")]
			internal NativeSnapshotMetadata Data()
			{
				return null;
			}

			// Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x488374", Offset = "0x488374", VA = "0x6488374", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DEC RID: 3564 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x488384", Offset = "0x488384", VA = "0x6488384")]
			internal static SnapshotManager.SnapshotSelectUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}
	}
}
