using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000197")]
	internal class UnsupportedSavedGamesClient : ISavedGameClient
	{
		// Token: 0x06000E6F RID: 3695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x48C734", Offset = "0x48C734", VA = "0x648C734")]
		public UnsupportedSavedGamesClient(string message)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x48C7AC", Offset = "0x48C7AC", VA = "0x648C7AC", Slot = "4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x48C840", Offset = "0x48C840", VA = "0x648C840", Slot = "5")]
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x48C8D4", Offset = "0x48C8D4", VA = "0x648C8D4", Slot = "6")]
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x48C968", Offset = "0x48C968", VA = "0x648C968", Slot = "7")]
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x48C9FC", Offset = "0x48C9FC", VA = "0x648C9FC", Slot = "8")]
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x48CA90", Offset = "0x48CA90", VA = "0x648CA90", Slot = "9")]
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x48CB24", Offset = "0x48CB24", VA = "0x648CB24", Slot = "10")]
		public void Delete(ISavedGameMetadata metadata)
		{
		}

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mMessage;
	}
}
