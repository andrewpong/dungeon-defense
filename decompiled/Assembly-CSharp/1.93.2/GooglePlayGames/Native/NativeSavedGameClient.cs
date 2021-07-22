using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x2000137")]
	internal class NativeSavedGameClient : ISavedGameClient
	{
		// Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x445978", Offset = "0x445978", VA = "0x6445978")]
		internal NativeSavedGameClient(GooglePlayGames.Native.PInvoke.SnapshotManager manager)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x4459F0", Offset = "0x4459F0", VA = "0x64459F0")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x446088", Offset = "0x446088", VA = "0x6446088", Slot = "4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x445CD0", Offset = "0x445CD0", VA = "0x6445CD0")]
		private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback)
		{
			return null;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x4460BC", Offset = "0x4460BC", VA = "0x64460BC", Slot = "5")]
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x445E4C", Offset = "0x445E4C", VA = "0x6445E4C")]
		private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x4463D4", Offset = "0x4463D4", VA = "0x64463D4", Slot = "6")]
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x4466B8", Offset = "0x4466B8", VA = "0x64466B8", Slot = "7")]
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x446910", Offset = "0x446910", VA = "0x6446910", Slot = "8")]
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x446EB0", Offset = "0x446EB0", VA = "0x6446EB0", Slot = "9")]
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x447068", Offset = "0x447068", VA = "0x6447068", Slot = "10")]
		public void Delete(ISavedGameMetadata metadata)
		{
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x445D8C", Offset = "0x445D8C", VA = "0x6445D8C")]
		internal static bool IsValidFilename(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x447148", Offset = "0x447148", VA = "0x6447148")]
		private static Types.SnapshotConflictPolicy AsConflictPolicy(ConflictResolutionStrategy strategy)
		{
			return (Types.SnapshotConflictPolicy)0;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x447258", Offset = "0x447258", VA = "0x6447258")]
		private static SavedGameRequestStatus AsRequestStatus(CommonErrorStatus.SnapshotOpenStatus status)
		{
			return (SavedGameRequestStatus)0;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x4462B4", Offset = "0x4462B4", VA = "0x64462B4")]
		private static Types.DataSource AsDataSource(DataSource source)
		{
			return (Types.DataSource)0;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x447384", Offset = "0x447384", VA = "0x6447384")]
		private static SavedGameRequestStatus AsRequestStatus(CommonErrorStatus.ResponseStatus status)
		{
			return (SavedGameRequestStatus)0;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x447558", Offset = "0x447558", VA = "0x6447558")]
		private static SelectUIStatus AsUIStatus(CommonErrorStatus.UIStatus uiStatus)
		{
			return (SelectUIStatus)0;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x446CBC", Offset = "0x446CBC", VA = "0x6446CBC")]
		private static NativeSnapshotMetadataChange AsMetadataChange(SavedGameMetadataUpdate update)
		{
			return null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009F6")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex ValidFilenameRegex;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x8")]
		private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mSnapshotManager;

		// Token: 0x0200018B RID: 395
		[Token(Token = "0x2000138")]
		private class NativeConflictResolver : IConflictResolver
		{
			// Token: 0x06000AC8 RID: 2760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x447F70", Offset = "0x447F70", VA = "0x6447F70")]
			internal NativeConflictResolver(GooglePlayGames.Native.PInvoke.SnapshotManager manager, string conflictId, NativeSnapshotMetadata original, NativeSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen)
			{
			}

			// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x448C3C", Offset = "0x448C3C", VA = "0x6448C3C", Slot = "5")]
			public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
			{
			}

			// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x448EA4", Offset = "0x448EA4", VA = "0x6448EA4", Slot = "4")]
			public void ChooseMetadata(ISavedGameMetadata chosenMetadata)
			{
			}

			// Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x449090", Offset = "0x449090", VA = "0x6449090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18573C", Offset = "0x18573C")]
			private void <ResolveConflict>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
			{
			}

			// Token: 0x06000ACC RID: 2764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x4491B4", Offset = "0x4491B4", VA = "0x64491B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18574C", Offset = "0x18574C")]
			private void <ChooseMetadata>m__1(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
			{
			}

			// Token: 0x040004AB RID: 1195
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x8")]
			private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mManager;

			// Token: 0x040004AC RID: 1196
			[Token(Token = "0x40003CC")]
			[FieldOffset(Offset = "0xC")]
			private readonly string mConflictId;

			// Token: 0x040004AD RID: 1197
			[Token(Token = "0x40003CD")]
			[FieldOffset(Offset = "0x10")]
			private readonly NativeSnapshotMetadata mOriginal;

			// Token: 0x040004AE RID: 1198
			[Token(Token = "0x40003CE")]
			[FieldOffset(Offset = "0x14")]
			private readonly NativeSnapshotMetadata mUnmerged;

			// Token: 0x040004AF RID: 1199
			[Token(Token = "0x40003CF")]
			[FieldOffset(Offset = "0x18")]
			private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;

			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40003D0")]
			[FieldOffset(Offset = "0x1C")]
			private readonly Action mRetryFileOpen;
		}

		// Token: 0x0200018C RID: 396
		[Token(Token = "0x2000139")]
		private class Prefetcher
		{
			// Token: 0x06000ACD RID: 2765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x448084", Offset = "0x448084", VA = "0x6448084")]
			internal Prefetcher(Action<byte[], byte[]> dataFetchedCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
			{
			}

			// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x4492D8", Offset = "0x4492D8", VA = "0x64492D8")]
			internal void OnOriginalDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
			{
			}

			// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x4498E0", Offset = "0x4498E0", VA = "0x64498E0")]
			internal void OnUnmergedDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
			{
			}

			// Token: 0x06000AD0 RID: 2768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x449590", Offset = "0x449590", VA = "0x6449590")]
			private void MaybeProceed()
			{
			}

			// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x449B94", Offset = "0x449B94", VA = "0x6449B94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18575C", Offset = "0x18575C")]
			private static void <OnOriginalDataRead>m__0(SavedGameRequestStatus A_0, ISavedGameMetadata A_1)
			{
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x449B98", Offset = "0x449B98", VA = "0x6449B98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18576C", Offset = "0x18576C")]
			private static void <OnUnmergedDataRead>m__1(SavedGameRequestStatus A_0, ISavedGameMetadata A_1)
			{
			}

			// Token: 0x040004B1 RID: 1201
			[Token(Token = "0x40003D1")]
			[FieldOffset(Offset = "0x8")]
			private readonly object mLock;

			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40003D2")]
			[FieldOffset(Offset = "0xC")]
			private bool mOriginalDataFetched;

			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x10")]
			private byte[] mOriginalData;

			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x14")]
			private bool mUnmergedDataFetched;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0x18")]
			private byte[] mUnmergedData;

			// Token: 0x040004B6 RID: 1206
			[Token(Token = "0x40003D6")]
			[FieldOffset(Offset = "0x1C")]
			private Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40003D7")]
			[FieldOffset(Offset = "0x20")]
			private readonly Action<byte[], byte[]> mDataFetchedCallback;

			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40003D8")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180E90", Offset = "0x180E90")]
			private static Action<SavedGameRequestStatus, ISavedGameMetadata> <>f__am$cache0;

			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180EA0", Offset = "0x180EA0")]
			private static Action<SavedGameRequestStatus, ISavedGameMetadata> <>f__am$cache1;
		}

		// Token: 0x0200018D RID: 397
		[Token(Token = "0x2000308")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA40", Offset = "0x17FA40")]
		private sealed class <OpenWithAutomaticConflictResolution>c__AnonStorey0
		{
			// Token: 0x06000AD3 RID: 2771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001510")]
			[Address(RVA = "0x445CC8", Offset = "0x445CC8", VA = "0x6445CC8")]
			public <OpenWithAutomaticConflictResolution>c__AnonStorey0()
			{
			}

			// Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x4482D0", Offset = "0x4482D0", VA = "0x64482D0")]
			internal void <>m__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}

			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40013A2")]
			[FieldOffset(Offset = "0x8")]
			internal ConflictResolutionStrategy resolutionStrategy;

			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40013A3")]
			[FieldOffset(Offset = "0xC")]
			internal Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;
		}

		// Token: 0x0200018E RID: 398
		[Token(Token = "0x2000309")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA50", Offset = "0x17FA50")]
		private sealed class <ToOnGameThread>c__AnonStorey1
		{
			// Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x4460B4", Offset = "0x4460B4", VA = "0x64460B4")]
			public <ToOnGameThread>c__AnonStorey1()
			{
			}

			// Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001513")]
			[Address(RVA = "0x448A10", Offset = "0x448A10", VA = "0x6448A10")]
			internal void <>m__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}

			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40013A4")]
			[FieldOffset(Offset = "0x8")]
			internal ConflictCallback conflictCallback;

			// Token: 0x0200018F RID: 399
			[Token(Token = "0x2000310")]
			private sealed class <ToOnGameThread>c__AnonStorey2
			{
				// Token: 0x06000AD7 RID: 2775 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001520")]
				[Address(RVA = "0x448BC4", Offset = "0x448BC4", VA = "0x6448BC4")]
				public <ToOnGameThread>c__AnonStorey2()
				{
				}

				// Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001521")]
				[Address(RVA = "0x448BCC", Offset = "0x448BCC", VA = "0x6448BCC")]
				internal void <>m__0()
				{
				}

				// Token: 0x040004BD RID: 1213
				[Token(Token = "0x40013B1")]
				[FieldOffset(Offset = "0x8")]
				internal IConflictResolver resolver;

				// Token: 0x040004BE RID: 1214
				[Token(Token = "0x40013B2")]
				[FieldOffset(Offset = "0xC")]
				internal ISavedGameMetadata original;

				// Token: 0x040004BF RID: 1215
				[Token(Token = "0x40013B3")]
				[FieldOffset(Offset = "0x10")]
				internal byte[] originalData;

				// Token: 0x040004C0 RID: 1216
				[Token(Token = "0x40013B4")]
				[FieldOffset(Offset = "0x14")]
				internal ISavedGameMetadata unmerged;

				// Token: 0x040004C1 RID: 1217
				[Token(Token = "0x40013B5")]
				[FieldOffset(Offset = "0x18")]
				internal byte[] unmergedData;

				// Token: 0x040004C2 RID: 1218
				[Token(Token = "0x40013B6")]
				[FieldOffset(Offset = "0x1C")]
				internal NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1 <>f__ref$1;
			}
		}

		// Token: 0x02000190 RID: 400
		[Token(Token = "0x200030A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA60", Offset = "0x17FA60")]
		private sealed class <InternalOpen>c__AnonStorey3
		{
			// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001514")]
			[Address(RVA = "0x4462AC", Offset = "0x4462AC", VA = "0x64462AC")]
			public <InternalOpen>c__AnonStorey3()
			{
			}

			// Token: 0x06000ADA RID: 2778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001515")]
			[Address(RVA = "0x447A40", Offset = "0x447A40", VA = "0x6447A40")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
			{
			}

			// Token: 0x040004C3 RID: 1219
			[Token(Token = "0x40013A5")]
			[FieldOffset(Offset = "0x8")]
			internal Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			// Token: 0x040004C4 RID: 1220
			[Token(Token = "0x40013A6")]
			[FieldOffset(Offset = "0xC")]
			internal string filename;

			// Token: 0x040004C5 RID: 1221
			[Token(Token = "0x40013A7")]
			[FieldOffset(Offset = "0x10")]
			internal DataSource source;

			// Token: 0x040004C6 RID: 1222
			[Token(Token = "0x40013A8")]
			[FieldOffset(Offset = "0x14")]
			internal ConflictResolutionStrategy resolutionStrategy;

			// Token: 0x040004C7 RID: 1223
			[Token(Token = "0x40013A9")]
			[FieldOffset(Offset = "0x18")]
			internal bool prefetchDataOnConflict;

			// Token: 0x040004C8 RID: 1224
			[Token(Token = "0x40013AA")]
			[FieldOffset(Offset = "0x1C")]
			internal ConflictCallback conflictCallback;

			// Token: 0x040004C9 RID: 1225
			[Token(Token = "0x40013AB")]
			[FieldOffset(Offset = "0x20")]
			internal NativeSavedGameClient $this;

			// Token: 0x02000191 RID: 401
			[Token(Token = "0x2000311")]
			private sealed class <InternalOpen>c__AnonStorey4
			{
				// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001522")]
				[Address(RVA = "0x447F68", Offset = "0x447F68", VA = "0x6447F68")]
				public <InternalOpen>c__AnonStorey4()
				{
				}

				// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001523")]
				[Address(RVA = "0x448140", Offset = "0x448140", VA = "0x6448140")]
				internal void <>m__0()
				{
				}

				// Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001524")]
				[Address(RVA = "0x44825C", Offset = "0x44825C", VA = "0x644825C")]
				internal void <>m__1(byte[] originalData, byte[] unmergedData)
				{
				}

				// Token: 0x040004CA RID: 1226
				[Token(Token = "0x40013B7")]
				[FieldOffset(Offset = "0x8")]
				internal NativeSavedGameClient.NativeConflictResolver resolver;

				// Token: 0x040004CB RID: 1227
				[Token(Token = "0x40013B8")]
				[FieldOffset(Offset = "0xC")]
				internal NativeSnapshotMetadata original;

				// Token: 0x040004CC RID: 1228
				[Token(Token = "0x40013B9")]
				[FieldOffset(Offset = "0x10")]
				internal NativeSnapshotMetadata unmerged;

				// Token: 0x040004CD RID: 1229
				[Token(Token = "0x40013BA")]
				[FieldOffset(Offset = "0x14")]
				internal NativeSavedGameClient.<InternalOpen>c__AnonStorey3 <>f__ref$3;
			}
		}

		// Token: 0x02000192 RID: 402
		[Token(Token = "0x200030B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA70", Offset = "0x17FA70")]
		private sealed class <ReadBinaryData>c__AnonStorey5
		{
			// Token: 0x06000ADE RID: 2782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x4466B0", Offset = "0x4466B0", VA = "0x64466B0")]
			public <ReadBinaryData>c__AnonStorey5()
			{
			}

			// Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001517")]
			[Address(RVA = "0x448794", Offset = "0x448794", VA = "0x6448794")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse response)
			{
			}

			// Token: 0x040004CE RID: 1230
			[Token(Token = "0x40013AC")]
			[FieldOffset(Offset = "0x8")]
			internal Action<SavedGameRequestStatus, byte[]> completedCallback;
		}

		// Token: 0x02000193 RID: 403
		[Token(Token = "0x200030C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA80", Offset = "0x17FA80")]
		private sealed class <ShowSelectSavedGameUI>c__AnonStorey6
		{
			// Token: 0x06000AE0 RID: 2784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001518")]
			[Address(RVA = "0x446908", Offset = "0x446908", VA = "0x6446908")]
			public <ShowSelectSavedGameUI>c__AnonStorey6()
			{
			}

			// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001519")]
			[Address(RVA = "0x4488EC", Offset = "0x4488EC", VA = "0x64488EC")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.SnapshotSelectUIResponse response)
			{
			}

			// Token: 0x040004CF RID: 1231
			[Token(Token = "0x40013AD")]
			[FieldOffset(Offset = "0x8")]
			internal Action<SelectUIStatus, ISavedGameMetadata> callback;
		}

		// Token: 0x02000194 RID: 404
		[Token(Token = "0x200030D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FA90", Offset = "0x17FA90")]
		private sealed class <CommitUpdate>c__AnonStorey7
		{
			// Token: 0x06000AE2 RID: 2786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600151A")]
			[Address(RVA = "0x446CB4", Offset = "0x446CB4", VA = "0x6446CB4")]
			public <CommitUpdate>c__AnonStorey7()
			{
			}

			// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600151B")]
			[Address(RVA = "0x447738", Offset = "0x447738", VA = "0x6447738")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse response)
			{
			}

			// Token: 0x040004D0 RID: 1232
			[Token(Token = "0x40013AE")]
			[FieldOffset(Offset = "0x8")]
			internal Action<SavedGameRequestStatus, ISavedGameMetadata> callback;
		}

		// Token: 0x02000195 RID: 405
		[Token(Token = "0x200030E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FAA0", Offset = "0x17FAA0")]
		private sealed class <FetchAllSavedGames>c__AnonStorey8
		{
			// Token: 0x06000AE4 RID: 2788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600151C")]
			[Address(RVA = "0x447060", Offset = "0x447060", VA = "0x6447060")]
			public <FetchAllSavedGames>c__AnonStorey8()
			{
			}

			// Token: 0x06000AE5 RID: 2789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600151D")]
			[Address(RVA = "0x447890", Offset = "0x447890", VA = "0x6447890")]
			internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse response)
			{
			}

			// Token: 0x040004D1 RID: 1233
			[Token(Token = "0x40013AF")]
			[FieldOffset(Offset = "0x8")]
			internal Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback;
		}

		// Token: 0x02000196 RID: 406
		[Token(Token = "0x200030F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FAB0", Offset = "0x17FAB0")]
		private sealed class <ToOnGameThread>c__AnonStorey9<T1, T2>
		{
			// Token: 0x06000AE6 RID: 2790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600151E")]
			public <ToOnGameThread>c__AnonStorey9()
			{
			}

			// Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600151F")]
			internal void <>m__0(T1 val1, T2 val2)
			{
			}

			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40013B0")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T1, T2> toConvert;

			// Token: 0x02000197 RID: 407
			[Token(Token = "0x2000312")]
			private sealed class <ToOnGameThread>c__AnonStoreyA
			{
				// Token: 0x06000AE8 RID: 2792 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001525")]
				public <ToOnGameThread>c__AnonStoreyA()
				{
				}

				// Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001526")]
				internal void <>m__0()
				{
				}

				// Token: 0x040004D3 RID: 1235
				[Token(Token = "0x40013BB")]
				[FieldOffset(Offset = "0x0")]
				internal T1 val1;

				// Token: 0x040004D4 RID: 1236
				[Token(Token = "0x40013BC")]
				[FieldOffset(Offset = "0x0")]
				internal T2 val2;

				// Token: 0x040004D5 RID: 1237
				[Token(Token = "0x40013BD")]
				[FieldOffset(Offset = "0x0")]
				internal NativeSavedGameClient.<ToOnGameThread>c__AnonStorey9<T1, T2> <>f__ref$9;
			}
		}
	}
}
