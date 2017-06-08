// Decompiled with JetBrains decompiler
// Type: GPGSMgr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using UnityEngine;

public class GPGSMgr : MonoBehaviour
{
  private string strCloud = "DungeonDefenseCloud";
  public static GPGSMgr single;
  private bool isSaving;

  public bool bLogin { get; set; }

  public bool bInit { get; set; }

  public bool isLogin
  {
    get
    {
      if (!Social.localUser.authenticated)
        return this.bLogin;
      return true;
    }
  }

  private void Awake()
  {
    if ((UnityEngine.Object) GPGSMgr.single != (UnityEngine.Object) null)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    }
    else
    {
      GPGSMgr.single = this;
      UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) this.gameObject);
    }
  }

  public void InitializeGPGS()
  {
    this.bLogin = false;
    this.bInit = false;
    PlayGamesPlatform.InitializeInstance(new PlayGamesClientConfiguration.Builder().EnableSavedGames().Build());
    PlayGamesPlatform.DebugLogEnabled = false;
    PlayGamesPlatform.Activate();
    PlayGamesPlatform.Instance.Authenticate(new Action<bool>(this.LoginCallBackGPGS));
    this.bInit = true;
  }

  public void LoginGPGS()
  {
    if (Social.localUser.authenticated)
      return;
    Social.localUser.Authenticate(new Action<bool>(this.LoginCallBackGPGS));
  }

  public void LoginCallBackGPGS(bool result)
  {
    this.bLogin = result;
  }

  public void LogoutGPGS()
  {
    if (!Social.localUser.authenticated)
      return;
    ((PlayGamesPlatform) Social.Active).SignOut();
    this.bLogin = false;
  }

  public Texture2D GetImageGPGS()
  {
    if (Social.localUser.authenticated)
      return Social.localUser.image;
    return (Texture2D) null;
  }

  public string GetNameGPGS()
  {
    if (!Social.localUser.authenticated)
      return PlayerPrefs.GetString("UserName", "You");
    PlayerPrefs.SetString("UserName", Social.localUser.userName);
    return Social.localUser.userName;
  }

  public void ShowAchievement()
  {
    Social.ShowAchievementsUI();
  }

  public void ShowLeaderboardUI()
  {
    Social.ShowLeaderboardUI();
  }

  public void CheckAchievementDayPass()
  {
    if (!this.bLogin || (bool) Info.rebirth.bVIP)
      return;
    if ((int) Info.currentSave.nDiff == 0 && (int) Info.currentSave.nDay >= 100)
      Social.ReportProgress("CgkIu5mC6tcCEAIQAw", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 1 && (int) Info.currentSave.nDay >= 100)
      Social.ReportProgress("CgkIu5mC6tcCEAIQAg", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 2 && (int) Info.currentSave.nDay >= 100)
      Social.ReportProgress("CgkIu5mC6tcCEAIQBA", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 3 && (int) Info.currentSave.nDay >= 100)
      Social.ReportProgress("CgkIu5mC6tcCEAIQBQ", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 4 && (int) Info.currentSave.nDay >= 100)
      Social.ReportProgress("CgkIu5mC6tcCEAIQCg", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 4 && (int) Info.currentSave.nDay >= 500)
      Social.ReportProgress("CgkIu5mC6tcCEAIQCw", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 4 && (int) Info.currentSave.nDay >= 1000)
      Social.ReportProgress("CgkIu5mC6tcCEAIQDA", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 5 && (int) Info.currentSave.nDay >= 100)
      Social.ReportProgress("CgkIu5mC6tcCEAIQEw", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff == 5 && (int) Info.currentSave.nDay >= 500)
      Social.ReportProgress("CgkIu5mC6tcCEAIQFA", 100.0, (Action<bool>) (success => {}));
    if ((int) Info.currentSave.nDiff != 5 || (int) Info.currentSave.nDay < 1000)
      return;
    Social.ReportProgress("CgkIu5mC6tcCEAIQFQ", 100.0, (Action<bool>) (success => {}));
  }

  public void CheckAchievementRebirth()
  {
    if (!this.isLogin || (bool) Info.rebirth.bVIP || (int) Info.rebirth.nRebirth <= 0)
      return;
    Social.ReportProgress("CgkIu5mC6tcCEAIQAQ", 100.0, (Action<bool>) (success => {}));
  }

  public void ReportLeaderBoard()
  {
    if (!this.isLogin || !Info.currentSave.bAfterRebirth || (bool) Info.rebirth.bVIP)
      return;
    switch ((int) Info.currentSave.nDiff)
    {
      case 0:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQEQ", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQBw", (Action<bool>) (obj => {}));
        break;
      case 1:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQEg", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQBg", (Action<bool>) (obj => {}));
        break;
      case 2:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQEA", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQCA", (Action<bool>) (obj => {}));
        break;
      case 3:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQDw", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQCQ", (Action<bool>) (obj => {}));
        break;
      case 4:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQDg", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQDQ", (Action<bool>) (obj => {}));
        break;
      case 5:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQFw", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQFg", (Action<bool>) (obj => {}));
        break;
      case 6:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQHQ", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQGA", (Action<bool>) (obj => {}));
        break;
      case 7:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQHg", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQGQ", (Action<bool>) (obj => {}));
        break;
      case 8:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQHw", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQGg", (Action<bool>) (obj => {}));
        break;
      case 9:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQIQ", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQGw", (Action<bool>) (obj => {}));
        break;
      case 10:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQIA", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQHA", (Action<bool>) (obj => {}));
        break;
      case 11:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQJw", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQIg", (Action<bool>) (obj => {}));
        break;
      case 12:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQKA", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQIw", (Action<bool>) (obj => {}));
        break;
      case 13:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQKQ", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQJA", (Action<bool>) (obj => {}));
        break;
      case 14:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQKg", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQJQ", (Action<bool>) (obj => {}));
        break;
      case 15:
        if ((int) Info.currentSave.nMaxEndless > 0)
          Social.ReportScore((long) (int) Info.currentSave.nMaxEndless, "CgkIu5mC6tcCEAIQKw", (Action<bool>) (obj => {}));
        Social.ReportScore((long) (int) Info.currentSave.nDay, "CgkIu5mC6tcCEAIQJg", (Action<bool>) (obj => {}));
        break;
    }
  }

  public void ShowCloudData(bool bSave)
  {
    this.isSaving = bSave;
    PlayGamesPlatform.Instance.SavedGame.ShowSelectSavedGameUI(!bSave ? BData.GetString("UI0205") : BData.GetString("UI0204"), 3U, bSave, bSave, new Action<SelectUIStatus, ISavedGameMetadata>(this.SavedGameSelected));
  }

  public void CloudSave()
  {
    this.OpenSavedGame(this.strCloud, true);
  }

  public void CloudLoad()
  {
    this.OpenSavedGame(this.strCloud, false);
  }

  public void SavedGameSelected(SelectUIStatus _status, ISavedGameMetadata _game)
  {
    UIMgr.AddPage("PopupBlock");
    if (_status == SelectUIStatus.SavedGameSelected)
    {
      Debug.Log((object) _game.Filename);
      string filename = _game.Filename;
      if (this.isSaving && (filename == null || filename.Length == 0 || filename == string.Empty))
        filename = "DD" + (object) DateTime.Now.ToBinary();
      PlayGamesPlatform.Instance.SavedGame.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork, ConflictResolutionStrategy.UseLongestPlaytime, new Action<SavedGameRequestStatus, ISavedGameMetadata>(this.SavedGameOpened));
    }
    else
    {
      UIMgr.RemoveTop();
      Debug.LogWarning((object) ("Error select saved game" + (object) _status));
    }
  }

  public void SavedGameOpened(SavedGameRequestStatus _status, ISavedGameMetadata _game)
  {
    if (_status == SavedGameRequestStatus.Success)
    {
      if (this.isSaving)
      {
        byte[] updatedBinaryData = SaveManager.GetSaveData();
        SavedGameMetadataUpdate updateForMetadata = new SavedGameMetadataUpdate.Builder().WithUpdatedPlayedTime(TimeSpan.Zero).WithUpdatedDescription(DateTime.Now.ToString()).Build();
        if ((bool) Info.rebirth.bVIP)
          updatedBinaryData = new byte[0];
        PlayGamesPlatform.Instance.SavedGame.CommitUpdate(_game, updateForMetadata, updatedBinaryData, new Action<SavedGameRequestStatus, ISavedGameMetadata>(this.OnSavedGameWritten));
      }
      else
        PlayGamesPlatform.Instance.SavedGame.ReadBinaryData(_game, new Action<SavedGameRequestStatus, byte[]>(this.OnSavedGameDataRead));
    }
    else
    {
      UIMgr.RemoveTop();
      Debug.LogWarning((object) ("Error open saved game" + (object) _status));
    }
  }

  private void OpenSavedGame(string filename, bool bSave)
  {
    UIMgr.AddPage("PopupBlock");
    ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
    if (bSave)
      savedGame.OpenWithAutomaticConflictResolution(filename, DataSource.ReadNetworkOnly, ConflictResolutionStrategy.UseLongestPlaytime, new Action<SavedGameRequestStatus, ISavedGameMetadata>(this.OnSavedGameOpened));
    else
      savedGame.OpenWithAutomaticConflictResolution(filename, DataSource.ReadNetworkOnly, ConflictResolutionStrategy.UseLongestPlaytime, new Action<SavedGameRequestStatus, ISavedGameMetadata>(this.OnSavedLoadOpened));
  }

  public void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
  {
    Debug.Log((object) status.ToString());
    if (status == SavedGameRequestStatus.Success)
      this.SaveGame(game, SaveManager.GetSaveData(), TimeSpan.Zero);
    else
      UIMgr.RemoveTop();
  }

  public void OnSavedLoadOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
  {
    if (status == SavedGameRequestStatus.Success)
      this.LoadGameData(game);
    else
      UIMgr.RemoveTop();
  }

  private void LoadGameData(ISavedGameMetadata game)
  {
    PlayGamesPlatform.Instance.SavedGame.ReadBinaryData(game, new Action<SavedGameRequestStatus, byte[]>(this.OnSavedGameDataRead));
  }

  public void OnSavedGameDataRead(SavedGameRequestStatus status, byte[] data)
  {
    if (status == SavedGameRequestStatus.Success)
    {
      SaveManager.GetLoadData(data);
    }
    else
    {
      UIMgr.RemoveTop();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0244") + "\n(" + status.ToString() + ")", true, false, string.Empty);
    }
  }

  private void SaveGame(ISavedGameMetadata game, byte[] savedData, TimeSpan totalPlaytime)
  {
    if (savedData == null)
    {
      UIMgr.RemoveTop();
      UIMgr.popupMsg.SetMsg("Failed to Save Cloud Data. there is no saved data.", true, false, string.Empty);
      UIMgr.PlaySound("GameOver", false);
    }
    else
    {
      Debug.Log((object) "Try Save Game - Check SavedData");
      if (savedData.Length == 0)
      {
        UIMgr.RemoveTop();
        UIMgr.popupMsg.SetMsg("Failed to Save Cloud Data. savedData length is 0", true, false, string.Empty);
        UIMgr.PlaySound("GameOver", false);
      }
      else
      {
        ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
        SavedGameMetadataUpdate updateForMetadata = new SavedGameMetadataUpdate.Builder().WithUpdatedPlayedTime(totalPlaytime).WithUpdatedDescription("Saved game at " + DateTime.Now.ToString()).Build();
        savedGame.CommitUpdate(game, updateForMetadata, savedData, new Action<SavedGameRequestStatus, ISavedGameMetadata>(this.OnSavedGameWritten));
      }
    }
  }

  public void OnSavedGameWritten(SavedGameRequestStatus status, ISavedGameMetadata game)
  {
    UIMgr.RemoveTop();
    if (status == SavedGameRequestStatus.Success)
    {
      UIMgr.PlaySound("Fanfare", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0200"), true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("GameOver", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0244") + "\n(" + status.ToString() + ")", true, false, string.Empty);
    }
  }
}
