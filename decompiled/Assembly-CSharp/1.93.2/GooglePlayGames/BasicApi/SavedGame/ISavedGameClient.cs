using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x2000063")]
	public interface ISavedGameClient
	{
		// Token: 0x0600048F RID: 1167
		[Token(Token = "0x6000463")]
		void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

		// Token: 0x06000490 RID: 1168
		[Token(Token = "0x6000464")]
		void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);

		// Token: 0x06000491 RID: 1169
		[Token(Token = "0x6000465")]
		void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback);

		// Token: 0x06000492 RID: 1170
		[Token(Token = "0x6000466")]
		void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback);

		// Token: 0x06000493 RID: 1171
		[Token(Token = "0x6000467")]
		void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

		// Token: 0x06000494 RID: 1172
		[Token(Token = "0x6000468")]
		void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback);

		// Token: 0x06000495 RID: 1173
		[Token(Token = "0x6000469")]
		void Delete(ISavedGameMetadata metadata);
	}
}
