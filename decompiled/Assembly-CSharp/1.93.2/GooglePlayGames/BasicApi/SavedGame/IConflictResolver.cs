using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x2000064")]
	public interface IConflictResolver
	{
		// Token: 0x06000496 RID: 1174
		[Token(Token = "0x600046A")]
		void ChooseMetadata(ISavedGameMetadata chosenMetadata);

		// Token: 0x06000497 RID: 1175
		[Token(Token = "0x600046B")]
		void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
	}
}
