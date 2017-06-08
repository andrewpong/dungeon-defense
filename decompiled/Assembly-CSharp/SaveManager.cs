// Decompiled with JetBrains decompiler
// Type: SaveManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
  public static SaveManager obj;

  private void Awake()
  {
    SaveManager.obj = this;
    UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) this.gameObject);
  }

  public static void Save()
  {
    string strSummary = Info.currentSave.strSummary;
    Info.currentSave.strSummary = string.Empty;
    SaveManager.Save(Info.currentSave.bySlot);
    SaveManager.SaveBak(Info.currentSave.bySlot);
    Info.currentSave.strSummary = strSummary;
  }

  public static void Save(byte bySlot)
  {
    if ((bool) Info.rebirth.bVIP)
      return;
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    SavedData currentSave = Info.currentSave;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      binaryFormatter.Serialize((Stream) memoryStream, (object) currentSave);
      ObscuredPrefs.SetString("DD_SaveData_" + (object) bySlot, Convert.ToBase64String(memoryStream.ToArray()));
      ObscuredPrefs.Save();
    }
  }

  public static bool SaveBak(byte bySlot)
  {
    return true;
  }

  public static void SaveOption()
  {
    if ((bool) Info.rebirth.bVIP)
      return;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      new BinaryFormatter()
      {
        AssemblyFormat = FormatterAssemblyStyle.Simple
      }.Serialize((Stream) memoryStream, (object) Info.option);
      ObscuredPrefs.SetString("DD_Option2", Convert.ToBase64String(memoryStream.ToArray()));
      ObscuredPrefs.Save();
    }
  }

  public static void SaveAchievement()
  {
    if ((bool) Info.rebirth.bVIP)
      return;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      new BinaryFormatter()
      {
        AssemblyFormat = FormatterAssemblyStyle.Simple
      }.Serialize((Stream) memoryStream, (object) Info.achievement);
      ObscuredPrefs.SetString("DD_Achievement", Convert.ToBase64String(memoryStream.ToArray()));
      ObscuredPrefs.Save();
    }
  }

  public static void SaveRebirth()
  {
    if ((bool) Info.rebirth.bVIP)
      return;
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    SavedRebirth rebirth = Info.rebirth;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      binaryFormatter.Serialize((Stream) memoryStream, (object) rebirth);
      ObscuredPrefs.SetString("DD_Rebirth", Convert.ToBase64String(memoryStream.ToArray()));
      ObscuredPrefs.Save();
    }
  }

  public static SavedData Load(byte bySlot)
  {
    SavedData savedData1 = (SavedData) null;
    string[] strArray = new string[4]{ "/SavedData" + (object) bySlot + ".dat", "/SavedData" + (object) bySlot + ".bakup", "/SavedData" + (object) bySlot + "_bak.dat", "/SavedData" + (object) bySlot + "_bak2.bak" };
    bool flag1 = false;
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    string s = ObscuredPrefs.GetString("DD_SaveData_" + (object) bySlot, string.Empty);
    if (s != string.Empty)
    {
      savedData1 = (SavedData) binaryFormatter.Deserialize((Stream) new MemoryStream(Convert.FromBase64String(s)));
    }
    else
    {
      for (int index = 0; index < strArray.Length; ++index)
      {
        if (savedData1 == null && File.Exists(Application.persistentDataPath + strArray[index]))
        {
          using (FileStream fileStream = File.Open(Application.persistentDataPath + strArray[index], FileMode.Open, FileAccess.Read))
          {
            if (fileStream.Length == 0L)
            {
              fileStream.Dispose();
              flag1 = true;
              Debug.LogError((object) ("Failed to Load SavedData" + strArray[index] + ". It's Empty."));
            }
            else
            {
              try
              {
                savedData1 = (SavedData) binaryFormatter.Deserialize((Stream) fileStream);
              }
              catch (SerializationException ex)
              {
                UIMgr.popupMsg.SetMsg("Failed to Load Saved Data. Reason: " + ex.Message, true, false, string.Empty);
              }
              finally
              {
                fileStream.Dispose();
              }
            }
          }
        }
      }
    }
    if (savedData1 != null)
    {
      bool flag2 = false;
      for (int index1 = 0; index1 < savedData1.arrPlayerMon.Length; ++index1)
      {
        if (savedData1.arrPlayerMon[index1] != null)
        {
          for (int index2 = 0; index2 < savedData1.arrPlayerMon.Length; ++index2)
          {
            if (savedData1.arrPlayerMon[index2] != null && savedData1.arrPlayerMon[index1] != savedData1.arrPlayerMon[index2] && (int) savedData1.arrPlayerMon[index1].byBatch == (int) savedData1.arrPlayerMon[index2].byBatch)
              flag2 = true;
          }
          if (flag2)
          {
            savedData1.bBatched = false;
            break;
          }
        }
      }
      if (!savedData1.bAfterAmulet)
      {
        savedData1.bAfterAmulet = true;
        for (int index = 0; index < savedData1.arrPlayerMon.Length; ++index)
        {
          if (savedData1.arrPlayerMon[index] != null)
          {
            savedData1.arrPlayerMon[index].nAmulet = (ObscuredLong) -1L;
            savedData1.arrPlayerMon[index].nRing = (ObscuredLong) -1L;
          }
        }
      }
      if (!savedData1.bBatched)
      {
        savedData1.bBatched = true;
        for (int index = 0; index < savedData1.arrPlayerMon.Length; ++index)
        {
          if (savedData1.arrPlayerMon[index] != null)
            savedData1.arrPlayerMon[index].byBatch = (byte) Info.byInitBatch[index];
        }
      }
      if (savedData1.listResearch == null)
        savedData1.listResearch = new List<ResearchID>();
      if (savedData1.dictRepeatResearch == null)
        savedData1.dictRepeatResearch = new Dictionary<ResearchID, ObscuredInt>();
      for (int index = 0; index < savedData1.nEquipWeapon.Length; ++index)
      {
        if ((long) savedData1.nEquipWeapon[index] != -1L)
          savedData1.arrPlayerMon[0].nEquip = savedData1.nEquipWeapon[index];
        savedData1.nEquipWeapon[index] = (ObscuredLong) -1L;
      }
      if ((int) savedData1.nGold > 0)
      {
        SavedData savedData2 = savedData1;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) savedData2.nNewGold + (long) (int) savedData1.nGold);
        savedData2.nNewGold = obscuredLong;
        savedData1.nGold = (ObscuredInt) 0;
      }
      if (savedData1.bDeleted)
        savedData1 = (SavedData) null;
      if (savedData1 != null && Info.rebirth.listRebirthID.Contains((ObscuredLong) savedData1.uRebirthID))
      {
        Debug.LogError((object) ("Failed to Load SavedData" + strArray[0] + " is already Revived."));
        savedData1 = (SavedData) null;
      }
      if (savedData1 != null && (int) savedData1.bySlot != (int) bySlot)
      {
        Debug.LogError((object) ("Failed to Load SavedData" + strArray[0] + " have a wrong slot number."));
        savedData1 = (SavedData) null;
      }
    }
    if (savedData1 == null && flag1 && (UnityEngine.Object) UIMgr.focused == (UnityEngine.Object) UIMgr.single)
      UIMgr.popupMsg.SetMsg("Failed to Load SavedData" + bySlot.ToString("00") + ". It's Corrupted. Please Use Cloud Load.", true, false, string.Empty);
    return savedData1;
  }

  public static void LoadOption()
  {
    string str = "/option.dat";
    string s = ObscuredPrefs.GetString("DD_Option2", string.Empty);
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    if (s != string.Empty)
    {
      Info.option = (SavedOption) binaryFormatter.Deserialize((Stream) new MemoryStream(Convert.FromBase64String(s)));
    }
    else
    {
      if (!File.Exists(Application.persistentDataPath + str))
        return;
      using (FileStream fileStream = File.Open(Application.persistentDataPath + str, FileMode.Open, FileAccess.Read))
      {
        if (fileStream.Length == 0L)
        {
          fileStream.Dispose();
          return;
        }
        try
        {
          Info.option = (SavedOption) binaryFormatter.Deserialize((Stream) fileStream);
        }
        catch (SerializationException ex)
        {
          UIMgr.popupMsg.SetMsg("Failed to Load Option Data. Reason: " + ex.Message, true, false, string.Empty);
        }
        finally
        {
          fileStream.Dispose();
        }
      }
      if (Info.option.listAutoBuildCount == null)
        Info.option.listAutoBuildCount = new List<int>();
      if (Info.option.listAutoBuildOrder == null)
        Info.option.listAutoBuildOrder = new List<DungeonType>();
      if (Info.option.listResearchOrder != null)
        return;
      Info.option.listResearchOrder = new List<ResearchID>();
    }
  }

  public static void LoadAchievement()
  {
    string str = "/achievement.dat";
    string s = ObscuredPrefs.GetString("DD_Achievement", string.Empty);
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    if (s != string.Empty)
      Info.achievement = (SavedAchievement) binaryFormatter.Deserialize((Stream) new MemoryStream(Convert.FromBase64String(s)));
    else if (File.Exists(Application.persistentDataPath + str))
    {
      using (FileStream fileStream = File.Open(Application.persistentDataPath + str, FileMode.Open, FileAccess.Read))
      {
        if (fileStream.Length == 0L)
        {
          fileStream.Dispose();
          return;
        }
        try
        {
          Info.achievement = (SavedAchievement) binaryFormatter.Deserialize((Stream) fileStream);
        }
        catch (SerializationException ex)
        {
          UIMgr.popupMsg.SetMsg("Failed to Load Achievement Data. Reason: " + ex.Message, true, false, string.Empty);
        }
        finally
        {
          fileStream.Dispose();
        }
      }
    }
    Info.RefreshAcvReward();
  }

  public static void LoadRebirth()
  {
    string[] strArray = new string[3]{ Application.persistentDataPath + "/Rebirth.dat", Application.persistentDataPath + "/Rebirth.bakup", Application.persistentDataPath + "/Rebirth_bak.dat" };
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    bool flag = false;
    string s = ObscuredPrefs.GetString("DD_Rebirth", string.Empty);
    if (s != string.Empty)
    {
      Info.rebirth = (SavedRebirth) binaryFormatter.Deserialize((Stream) new MemoryStream(Convert.FromBase64String(s)));
    }
    else
    {
      for (int index = 0; index < strArray.Length; ++index)
      {
        if (!flag && File.Exists(strArray[index]))
        {
          using (FileStream fileStream = File.Open(strArray[index], FileMode.Open, FileAccess.Read))
          {
            if (fileStream.Length == 0L)
            {
              fileStream.Dispose();
            }
            else
            {
              try
              {
                Info.rebirth = (SavedRebirth) binaryFormatter.Deserialize((Stream) fileStream);
              }
              catch (SerializationException ex)
              {
                UIMgr.popupMsg.SetMsg("Failed to Load Rebirth Data. Reason: " + ex.Message, true, false, string.Empty);
              }
              finally
              {
                fileStream.Dispose();
              }
              if (Info.rebirth != null)
                flag = true;
            }
            fileStream.Close();
          }
        }
      }
    }
    if (Info.rebirth == null)
      return;
    SaveManager.CheckRebirthInit();
  }

  private static void CheckRebirthInit()
  {
    if (Info.rebirth.listRebirthID == null)
      Info.rebirth.listRebirthID = new List<ObscuredLong>();
    if (Info.rebirth.dictTrialClear == null)
      Info.rebirth.dictTrialClear = new Dictionary<ObscuredLong, ObscuredInt>();
    if (Info.rebirth.listAchievementAccReward == null)
      Info.rebirth.listAchievementAccReward = new List<ObscuredShort>();
    if (Info.rebirth.listMission == null)
      Info.rebirth.listMission = new List<QuestID>();
    if (Info.rebirth.dictRebirthHistory == null)
      Info.rebirth.dictRebirthHistory = new Dictionary<ObscuredInt, List<ObscuredInt>>();
    if (Info.rebirth.dictHellQuest == null)
      Info.rebirth.dictHellQuest = new Dictionary<ObscuredInt, Dictionary<ObscuredInt, ObscuredInt>>();
    if (Info.rebirth.dictAcc == null)
      Info.rebirth.dictAcc = new Dictionary<ObscuredLong, PlayerAccData>();
    if (Info.rebirth.dictElementalExp == null)
      Info.rebirth.dictElementalExp = new Dictionary<ObscuredInt, ObscuredLong>();
    if (Info.rebirth.dictElementalTrait == null)
      Info.rebirth.dictElementalTrait = new Dictionary<ElementalID, ObscuredInt>();
    if (Info.rebirth.dictUnitPromote == null)
      Info.rebirth.dictUnitPromote = new Dictionary<ObscuredShort, ObscuredInt>();
    if ((long) Info.rebirth.uAccUID == 0L)
      Info.rebirth.uAccUID = (ObscuredLong) 1L;
    if ((int) Info.rebirth.nMedal != 0)
    {
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewMedal + (long) (int) Info.rebirth.nMedal);
      rebirth.nNewMedal = obscuredLong;
      Info.rebirth.nMedal = (ObscuredInt) 0;
    }
    if ((int) Info.rebirth.nStone != 0)
    {
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) (int) Info.rebirth.nStone);
      rebirth.nNewStone = obscuredLong;
      Info.rebirth.nStone = (ObscuredInt) 0;
    }
    while (Info.rebirth.dictAcc.ContainsKey(Info.rebirth.uAccUID))
      ++Info.rebirth.uAccUID;
  }

  public static byte[] GetSaveData()
  {
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    MemoryStream memoryStream = new MemoryStream();
    CloudSavedData cloudSavedData = new CloudSavedData();
    cloudSavedData.savedData = new SavedData[9];
    for (int index = 0; index < 9; ++index)
    {
      cloudSavedData.savedData[index] = SaveManager.Load((byte) index);
      if (cloudSavedData.savedData[index] != null)
        cloudSavedData.savedData[index].strSummary = string.Empty;
    }
    cloudSavedData.achievement = Info.achievement;
    cloudSavedData.rebirth = Info.rebirth;
    binaryFormatter.Serialize((Stream) memoryStream, (object) cloudSavedData);
    return memoryStream.ToArray();
  }

  public static void GetLoadData(byte[] bytes)
  {
    if (bytes == null)
    {
      UIMgr.RemoveTop();
      UIMgr.PlaySound("GameOver", false);
      UIMgr.popupMsg.SetMsg("Failed to Load Cloud Data. there is no saved data.", true, false, string.Empty);
    }
    else if (bytes.Length == 0)
    {
      UIMgr.RemoveTop();
      UIMgr.PlaySound("GameOver", false);
      UIMgr.popupMsg.SetMsg("Failed to Load Cloud Data. data length is zero." + (!(bool) Info.rebirth.bVIP ? string.Empty : "..") + "\nVer " + Application.version, true, false, string.Empty);
    }
    else
    {
      UIMgr.PlaySound("Hire", false);
      CloudSavedData cloudSavedData = (CloudSavedData) new BinaryFormatter().Deserialize((Stream) new MemoryStream(bytes));
      Info.rebirth = cloudSavedData.rebirth;
      SaveManager.CheckRebirthInit();
      for (int index = 0; index < 9; ++index)
      {
        if (cloudSavedData.savedData[index] != null)
        {
          Info.currentSave = cloudSavedData.savedData[index];
          if (!(bool) Info.rebirth.bRebirthInit)
            Info.currentSave.uRebirthID = (long) Info.rebirth.uRebirthID++;
          SaveManager.Save();
        }
        else if (SaveManager.Load((byte) index) != null)
        {
          Info.currentSave = SaveManager.Load((byte) index);
          Info.currentSave.bDeleted = true;
          SaveManager.Save();
        }
      }
      Info.rebirth.bRebirthInit = (ObscuredBool) true;
      Info.achievement = cloudSavedData.achievement;
      SaveManager.SaveAchievement();
      SaveManager.SaveRebirth();
      SceneManager.LoadScene("Main");
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0201"), true, false, string.Empty);
    }
  }
}
