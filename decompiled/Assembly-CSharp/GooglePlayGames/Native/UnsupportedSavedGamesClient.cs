﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.UnsupportedSavedGamesClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;

namespace GooglePlayGames.Native
{
  internal class UnsupportedSavedGamesClient : ISavedGameClient
  {
    private readonly string mMessage;

    public UnsupportedSavedGamesClient(string message)
    {
      this.mMessage = Misc.CheckNotNull<string>(message);
    }

    public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
    {
      throw new NotImplementedException(this.mMessage);
    }

    public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
    {
      throw new NotImplementedException(this.mMessage);
    }

    public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
    {
      throw new NotImplementedException(this.mMessage);
    }

    public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
    {
      throw new NotImplementedException(this.mMessage);
    }

    public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
    {
      throw new NotImplementedException(this.mMessage);
    }

    public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
    {
      throw new NotImplementedException(this.mMessage);
    }

    public void Delete(ISavedGameMetadata metadata)
    {
      throw new NotImplementedException(this.mMessage);
    }
  }
}
