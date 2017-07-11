// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.NativeSavedGameClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GooglePlayGames.Native
{
  internal class NativeSavedGameClient : ISavedGameClient
  {
    private static readonly Regex ValidFilenameRegex = new Regex("\\A[a-zA-Z0-9-._~]{1,100}\\Z");
    private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mSnapshotManager;

    internal NativeSavedGameClient(GooglePlayGames.Native.PInvoke.SnapshotManager manager)
    {
      this.mSnapshotManager = Misc.CheckNotNull<GooglePlayGames.Native.PInvoke.SnapshotManager>(manager);
    }

    public void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeSavedGameClient.\u003COpenWithAutomaticConflictResolution\u003Ec__AnonStorey0 resolutionCAnonStorey0 = new NativeSavedGameClient.\u003COpenWithAutomaticConflictResolution\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      resolutionCAnonStorey0.resolutionStrategy = resolutionStrategy;
      // ISSUE: reference to a compiler-generated field
      resolutionCAnonStorey0.callback = callback;
      Misc.CheckNotNull<string>(filename);
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<SavedGameRequestStatus, ISavedGameMetadata>>(resolutionCAnonStorey0.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      resolutionCAnonStorey0.callback = NativeSavedGameClient.ToOnGameThread<SavedGameRequestStatus, ISavedGameMetadata>(resolutionCAnonStorey0.callback);
      if (!NativeSavedGameClient.IsValidFilename(filename))
      {
        Logger.e("Received invalid filename: " + filename);
        // ISSUE: reference to a compiler-generated field
        resolutionCAnonStorey0.callback(SavedGameRequestStatus.BadInputError, (ISavedGameMetadata) null);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        this.OpenWithManualConflictResolution(filename, source, false, new ConflictCallback(resolutionCAnonStorey0.\u003C\u003Em__0), resolutionCAnonStorey0.callback);
      }
    }

    private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return new ConflictCallback(new NativeSavedGameClient.\u003CToOnGameThread\u003Ec__AnonStorey1() { conflictCallback = conflictCallback }.\u003C\u003Em__0);
    }

    public void OpenWithManualConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
    {
      Misc.CheckNotNull<string>(filename);
      Misc.CheckNotNull<ConflictCallback>(conflictCallback);
      Misc.CheckNotNull<Action<SavedGameRequestStatus, ISavedGameMetadata>>(completedCallback);
      conflictCallback = this.ToOnGameThread(conflictCallback);
      completedCallback = NativeSavedGameClient.ToOnGameThread<SavedGameRequestStatus, ISavedGameMetadata>(completedCallback);
      if (!NativeSavedGameClient.IsValidFilename(filename))
      {
        Logger.e("Received invalid filename: " + filename);
        completedCallback(SavedGameRequestStatus.BadInputError, (ISavedGameMetadata) null);
      }
      else
        this.InternalManualOpen(filename, source, prefetchDataOnConflict, conflictCallback, completedCallback);
    }

    private void InternalManualOpen(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeSavedGameClient.\u003CInternalManualOpen\u003Ec__AnonStorey3 openCAnonStorey3 = new NativeSavedGameClient.\u003CInternalManualOpen\u003Ec__AnonStorey3();
      // ISSUE: reference to a compiler-generated field
      openCAnonStorey3.completedCallback = completedCallback;
      // ISSUE: reference to a compiler-generated field
      openCAnonStorey3.filename = filename;
      // ISSUE: reference to a compiler-generated field
      openCAnonStorey3.source = source;
      // ISSUE: reference to a compiler-generated field
      openCAnonStorey3.prefetchDataOnConflict = prefetchDataOnConflict;
      // ISSUE: reference to a compiler-generated field
      openCAnonStorey3.conflictCallback = conflictCallback;
      // ISSUE: reference to a compiler-generated field
      openCAnonStorey3.\u0024this = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      this.mSnapshotManager.Open(openCAnonStorey3.filename, NativeSavedGameClient.AsDataSource(openCAnonStorey3.source), Types.SnapshotConflictPolicy.MANUAL, new Action<GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse>(openCAnonStorey3.\u003C\u003Em__0));
    }

    public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeSavedGameClient.\u003CReadBinaryData\u003Ec__AnonStorey5 dataCAnonStorey5 = new NativeSavedGameClient.\u003CReadBinaryData\u003Ec__AnonStorey5();
      // ISSUE: reference to a compiler-generated field
      dataCAnonStorey5.completedCallback = completedCallback;
      Misc.CheckNotNull<ISavedGameMetadata>(metadata);
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<SavedGameRequestStatus, byte[]>>(dataCAnonStorey5.completedCallback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      dataCAnonStorey5.completedCallback = NativeSavedGameClient.ToOnGameThread<SavedGameRequestStatus, byte[]>(dataCAnonStorey5.completedCallback);
      NativeSnapshotMetadata metadata1 = metadata as NativeSnapshotMetadata;
      if (metadata1 == null)
      {
        Logger.e("Encountered metadata that was not generated by this ISavedGameClient");
        // ISSUE: reference to a compiler-generated field
        dataCAnonStorey5.completedCallback(SavedGameRequestStatus.BadInputError, (byte[]) null);
      }
      else if (!metadata1.IsOpen)
      {
        Logger.e("This method requires an open ISavedGameMetadata.");
        // ISSUE: reference to a compiler-generated field
        dataCAnonStorey5.completedCallback(SavedGameRequestStatus.BadInputError, (byte[]) null);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mSnapshotManager.Read(metadata1, new Action<GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse>(dataCAnonStorey5.\u003C\u003Em__0));
      }
    }

    public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeSavedGameClient.\u003CShowSelectSavedGameUI\u003Ec__AnonStorey6 gameUiCAnonStorey6 = new NativeSavedGameClient.\u003CShowSelectSavedGameUI\u003Ec__AnonStorey6();
      // ISSUE: reference to a compiler-generated field
      gameUiCAnonStorey6.callback = callback;
      Misc.CheckNotNull<string>(uiTitle);
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<SelectUIStatus, ISavedGameMetadata>>(gameUiCAnonStorey6.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      gameUiCAnonStorey6.callback = NativeSavedGameClient.ToOnGameThread<SelectUIStatus, ISavedGameMetadata>(gameUiCAnonStorey6.callback);
      if (maxDisplayedSavedGames <= 0U)
      {
        Logger.e("maxDisplayedSavedGames must be greater than 0");
        // ISSUE: reference to a compiler-generated field
        gameUiCAnonStorey6.callback(SelectUIStatus.BadInputError, (ISavedGameMetadata) null);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mSnapshotManager.SnapshotSelectUI(showCreateSaveUI, showDeleteSaveUI, maxDisplayedSavedGames, uiTitle, new Action<GooglePlayGames.Native.PInvoke.SnapshotManager.SnapshotSelectUIResponse>(gameUiCAnonStorey6.\u003C\u003Em__0));
      }
    }

    public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeSavedGameClient.\u003CCommitUpdate\u003Ec__AnonStorey7 updateCAnonStorey7 = new NativeSavedGameClient.\u003CCommitUpdate\u003Ec__AnonStorey7();
      // ISSUE: reference to a compiler-generated field
      updateCAnonStorey7.callback = callback;
      Misc.CheckNotNull<ISavedGameMetadata>(metadata);
      Misc.CheckNotNull<byte[]>(updatedBinaryData);
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<SavedGameRequestStatus, ISavedGameMetadata>>(updateCAnonStorey7.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      updateCAnonStorey7.callback = NativeSavedGameClient.ToOnGameThread<SavedGameRequestStatus, ISavedGameMetadata>(updateCAnonStorey7.callback);
      NativeSnapshotMetadata metadata1 = metadata as NativeSnapshotMetadata;
      if (metadata1 == null)
      {
        Logger.e("Encountered metadata that was not generated by this ISavedGameClient");
        // ISSUE: reference to a compiler-generated field
        updateCAnonStorey7.callback(SavedGameRequestStatus.BadInputError, (ISavedGameMetadata) null);
      }
      else if (!metadata1.IsOpen)
      {
        Logger.e("This method requires an open ISavedGameMetadata.");
        // ISSUE: reference to a compiler-generated field
        updateCAnonStorey7.callback(SavedGameRequestStatus.BadInputError, (ISavedGameMetadata) null);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.mSnapshotManager.Commit(metadata1, NativeSavedGameClient.AsMetadataChange(updateForMetadata), updatedBinaryData, new Action<GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse>(updateCAnonStorey7.\u003C\u003Em__0));
      }
    }

    public void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeSavedGameClient.\u003CFetchAllSavedGames\u003Ec__AnonStorey8 gamesCAnonStorey8 = new NativeSavedGameClient.\u003CFetchAllSavedGames\u003Ec__AnonStorey8();
      // ISSUE: reference to a compiler-generated field
      gamesCAnonStorey8.callback = callback;
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<SavedGameRequestStatus, List<ISavedGameMetadata>>>(gamesCAnonStorey8.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      gamesCAnonStorey8.callback = NativeSavedGameClient.ToOnGameThread<SavedGameRequestStatus, List<ISavedGameMetadata>>(gamesCAnonStorey8.callback);
      // ISSUE: reference to a compiler-generated method
      this.mSnapshotManager.FetchAll(NativeSavedGameClient.AsDataSource(source), new Action<GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse>(gamesCAnonStorey8.\u003C\u003Em__0));
    }

    public void Delete(ISavedGameMetadata metadata)
    {
      Misc.CheckNotNull<ISavedGameMetadata>(metadata);
      this.mSnapshotManager.Delete((NativeSnapshotMetadata) metadata);
    }

    internal static bool IsValidFilename(string filename)
    {
      if (filename == null)
        return false;
      return NativeSavedGameClient.ValidFilenameRegex.IsMatch(filename);
    }

    private static Types.SnapshotConflictPolicy AsConflictPolicy(ConflictResolutionStrategy strategy)
    {
      switch (strategy)
      {
        case ConflictResolutionStrategy.UseLongestPlaytime:
          return Types.SnapshotConflictPolicy.LONGEST_PLAYTIME;
        case ConflictResolutionStrategy.UseOriginal:
          return Types.SnapshotConflictPolicy.LAST_KNOWN_GOOD;
        case ConflictResolutionStrategy.UseUnmerged:
          return Types.SnapshotConflictPolicy.MOST_RECENTLY_MODIFIED;
        default:
          throw new InvalidOperationException("Found unhandled strategy: " + (object) strategy);
      }
    }

    private static SavedGameRequestStatus AsRequestStatus(CommonErrorStatus.SnapshotOpenStatus status)
    {
      switch (status + 5)
      {
        case ~(CommonErrorStatus.SnapshotOpenStatus.ERROR_INTERNAL | CommonErrorStatus.SnapshotOpenStatus.VALID):
          return SavedGameRequestStatus.TimeoutError;
        case ~CommonErrorStatus.SnapshotOpenStatus.ERROR_NOT_AUTHORIZED:
          return SavedGameRequestStatus.AuthenticationError;
        default:
          if (status == CommonErrorStatus.SnapshotOpenStatus.VALID)
            return SavedGameRequestStatus.Success;
          Logger.e("Encountered unknown status: " + (object) status);
          return SavedGameRequestStatus.InternalError;
      }
    }

    private static Types.DataSource AsDataSource(GooglePlayGames.BasicApi.DataSource source)
    {
      if (source == GooglePlayGames.BasicApi.DataSource.ReadCacheOrNetwork)
        return Types.DataSource.CACHE_OR_NETWORK;
      if (source == GooglePlayGames.BasicApi.DataSource.ReadNetworkOnly)
        return Types.DataSource.NETWORK_ONLY;
      throw new InvalidOperationException("Found unhandled DataSource: " + (object) source);
    }

    private static SavedGameRequestStatus AsRequestStatus(CommonErrorStatus.ResponseStatus status)
    {
      switch (status + 5)
      {
        case ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED:
          return SavedGameRequestStatus.TimeoutError;
        case CommonErrorStatus.ResponseStatus.VALID_BUT_STALE:
          Logger.e("User was not authorized (they were probably not logged in).");
          return SavedGameRequestStatus.AuthenticationError;
        case CommonErrorStatus.ResponseStatus.VALID | CommonErrorStatus.ResponseStatus.VALID_BUT_STALE:
          return SavedGameRequestStatus.InternalError;
        case ~CommonErrorStatus.ResponseStatus.ERROR_TIMEOUT:
          Logger.e("User attempted to use the game without a valid license.");
          return SavedGameRequestStatus.AuthenticationError;
        case (CommonErrorStatus.ResponseStatus) 6:
        case (CommonErrorStatus.ResponseStatus) 7:
          return SavedGameRequestStatus.Success;
        default:
          Logger.e("Unknown status: " + (object) status);
          return SavedGameRequestStatus.InternalError;
      }
    }

    private static SelectUIStatus AsUIStatus(CommonErrorStatus.UIStatus uiStatus)
    {
      switch (uiStatus + 6)
      {
        case ~(CommonErrorStatus.UIStatus.ERROR_INTERNAL | CommonErrorStatus.UIStatus.VALID):
          return SelectUIStatus.UserClosedUI;
        case CommonErrorStatus.UIStatus.VALID:
          return SelectUIStatus.TimeoutError;
        case ~CommonErrorStatus.UIStatus.ERROR_VERSION_UPDATE_REQUIRED:
          return SelectUIStatus.AuthenticationError;
        case ~CommonErrorStatus.UIStatus.ERROR_TIMEOUT:
          return SelectUIStatus.InternalError;
        case (CommonErrorStatus.UIStatus) 7:
          return SelectUIStatus.SavedGameSelected;
        default:
          Logger.e("Encountered unknown UI Status: " + (object) uiStatus);
          return SelectUIStatus.InternalError;
      }
    }

    private static NativeSnapshotMetadataChange AsMetadataChange(SavedGameMetadataUpdate update)
    {
      NativeSnapshotMetadataChange.Builder builder = new NativeSnapshotMetadataChange.Builder();
      if (update.IsCoverImageUpdated)
        builder.SetCoverImageFromPngData(update.UpdatedPngCoverImage);
      if (update.IsDescriptionUpdated)
        builder.SetDescription(update.UpdatedDescription);
      if (update.IsPlayedTimeUpdated)
        builder.SetPlayedTime((ulong) update.UpdatedPlayedTime.Value.TotalMilliseconds);
      return builder.Build();
    }

    private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return new Action<T1, T2>(new NativeSavedGameClient.\u003CToOnGameThread\u003Ec__AnonStorey9<T1, T2>() { toConvert = toConvert }.\u003C\u003Em__0);
    }

    private class NativeConflictResolver : IConflictResolver
    {
      private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mManager;
      private readonly string mConflictId;
      private readonly NativeSnapshotMetadata mOriginal;
      private readonly NativeSnapshotMetadata mUnmerged;
      private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;
      private readonly Action mRetryFileOpen;

      internal NativeConflictResolver(GooglePlayGames.Native.PInvoke.SnapshotManager manager, string conflictId, NativeSnapshotMetadata original, NativeSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen)
      {
        this.mManager = Misc.CheckNotNull<GooglePlayGames.Native.PInvoke.SnapshotManager>(manager);
        this.mConflictId = Misc.CheckNotNull<string>(conflictId);
        this.mOriginal = Misc.CheckNotNull<NativeSnapshotMetadata>(original);
        this.mUnmerged = Misc.CheckNotNull<NativeSnapshotMetadata>(unmerged);
        this.mCompleteCallback = Misc.CheckNotNull<Action<SavedGameRequestStatus, ISavedGameMetadata>>(completeCallback);
        this.mRetryFileOpen = Misc.CheckNotNull<Action>(retryOpen);
      }

      public void ChooseMetadata(ISavedGameMetadata chosenMetadata)
      {
        NativeSnapshotMetadata metadata = chosenMetadata as NativeSnapshotMetadata;
        if (metadata != this.mOriginal && metadata != this.mUnmerged)
        {
          Logger.e("Caller attempted to choose a version of the metadata that was not part of the conflict");
          this.mCompleteCallback(SavedGameRequestStatus.BadInputError, (ISavedGameMetadata) null);
        }
        else
          this.mManager.Resolve(metadata, new NativeSnapshotMetadataChange.Builder().Build(), this.mConflictId, (Action<GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse>) (response =>
          {
            if (!response.RequestSucceeded())
              this.mCompleteCallback(NativeSavedGameClient.AsRequestStatus(response.ResponseStatus()), (ISavedGameMetadata) null);
            else
              this.mRetryFileOpen();
          }));
      }
    }

    private class Prefetcher
    {
      private readonly object mLock = new object();
      private bool mOriginalDataFetched;
      private byte[] mOriginalData;
      private bool mUnmergedDataFetched;
      private byte[] mUnmergedData;
      private Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;
      private readonly Action<byte[], byte[]> mDataFetchedCallback;

      internal Prefetcher(Action<byte[], byte[]> dataFetchedCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
      {
        this.mDataFetchedCallback = Misc.CheckNotNull<Action<byte[], byte[]>>(dataFetchedCallback);
        this.completedCallback = Misc.CheckNotNull<Action<SavedGameRequestStatus, ISavedGameMetadata>>(completedCallback);
      }

      internal void OnOriginalDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
      {
        lock (this.mLock)
        {
          if (!readResponse.RequestSucceeded())
          {
            Logger.e("Encountered error while prefetching original data.");
            this.completedCallback(NativeSavedGameClient.AsRequestStatus(readResponse.ResponseStatus()), (ISavedGameMetadata) null);
            this.completedCallback = (Action<SavedGameRequestStatus, ISavedGameMetadata>) ((param0, param1) => {});
          }
          else
          {
            Logger.d("Successfully fetched original data");
            this.mOriginalDataFetched = true;
            this.mOriginalData = readResponse.Data();
            this.MaybeProceed();
          }
        }
      }

      internal void OnUnmergedDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
      {
        lock (this.mLock)
        {
          if (!readResponse.RequestSucceeded())
          {
            Logger.e("Encountered error while prefetching unmerged data.");
            this.completedCallback(NativeSavedGameClient.AsRequestStatus(readResponse.ResponseStatus()), (ISavedGameMetadata) null);
            this.completedCallback = (Action<SavedGameRequestStatus, ISavedGameMetadata>) ((param0, param1) => {});
          }
          else
          {
            Logger.d("Successfully fetched unmerged data");
            this.mUnmergedDataFetched = true;
            this.mUnmergedData = readResponse.Data();
            this.MaybeProceed();
          }
        }
      }

      private void MaybeProceed()
      {
        if (this.mOriginalDataFetched && this.mUnmergedDataFetched)
        {
          Logger.d("Fetched data for original and unmerged, proceeding");
          this.mDataFetchedCallback(this.mOriginalData, this.mUnmergedData);
        }
        else
          Logger.d("Not all data fetched - original:" + (object) this.mOriginalDataFetched + " unmerged:" + (object) this.mUnmergedDataFetched);
      }
    }
  }
}
