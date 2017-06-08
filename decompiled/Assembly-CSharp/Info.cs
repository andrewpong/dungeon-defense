// Decompiled with JetBrains decompiler
// Type: Info
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Info
{
  public static WaveData wave = new WaveData();
  public static SavedData currentSave = new SavedData();
  public static SavedOption option = new SavedOption();
  public static SavedAchievement achievement = new SavedAchievement();
  public static SavedRebirth rebirth = new SavedRebirth();
  public static List<PlayerItemData> listDropItem = new List<PlayerItemData>();
  public static Dictionary<SkillKey, ObscuredInt> dictPartySkill = new Dictionary<SkillKey, ObscuredInt>();
  public static Dictionary<SkillKey, ObscuredFloat> dictPSkillFac1 = new Dictionary<SkillKey, ObscuredFloat>();
  public static Dictionary<SkillKey, ObscuredFloat> dictPSkillFac2 = new Dictionary<SkillKey, ObscuredFloat>();
  public static Dictionary<long, BattleItemData> dictBattleItem = new Dictionary<long, BattleItemData>();
  public static ObscuredInt nBattleGold = (ObscuredInt) 0;
  public static ObscuredInt nBattleExp = (ObscuredInt) 0;
  public static ObscuredDouble nGem = (ObscuredDouble) 0.0;
  public static List<AchievementType> listCheck = new List<AchievementType>();
  public static Dictionary<AcvRewardType, ObscuredInt> dictAcvReward = new Dictionary<AcvRewardType, ObscuredInt>();
  public static ObscuredFloat[,] fPlayerAccMod = new ObscuredFloat[5, 64];
  public static ObscuredFloat[] fAllAccMod = new ObscuredFloat[64];
  public static BattleType eBattle = BattleType.eSurvial;
  public static ObscuredByte byCurrentSaveSlot = (ObscuredByte) (byte) 0;
  public static ObscuredInt nSelectedMonster = (ObscuredInt) -1;
  public static bool bAcvChanged = false;
  public static ObscuredFloat fDunMaxHP = (ObscuredFloat) 50f;
  public static ObscuredFloat fDunRegen = (ObscuredFloat) 0.0f;
  public static ObscuredFloat[] fTrialCharge = new ObscuredFloat[5]
  {
    (ObscuredFloat) 0.0f,
    (ObscuredFloat) 0.0f,
    (ObscuredFloat) 0.0f,
    (ObscuredFloat) 0.0f,
    (ObscuredFloat) 0.0f
  };
  public static ObscuredFloat fTrialAwakenCharge = (ObscuredFloat) 0.0f;
  public static ObscuredFloat fAtkBonus = (ObscuredFloat) 1f;
  public static ObscuredFloat fEmAtkBonus = (ObscuredFloat) 1f;
  public static ObscuredFloat fEmAspBonus = (ObscuredFloat) 1f;
  public static ObscuredFloat fResearchPower = (ObscuredFloat) 10f;
  public static ObscuredInt nAwakenCost = (ObscuredInt) 5000000;
  public static ObscuredInt nDiffTrial = (ObscuredInt) 0;
  public static ObscuredInt nStartEndless = (ObscuredInt) 0;
  public static float[] fDiffTrialDiffFac = new float[3]
  {
    0.65f,
    0.825f,
    1f
  };
  public static float[] fDiffTrialDiffDmg = new float[3]
  {
    0.65f,
    0.825f,
    1f
  };
  public static float[] fDiffTrialReward = new float[3]
  {
    0.25f,
    0.5f,
    1f
  };
  public static float[] fDiffSpd = new float[16]
  {
    1f,
    0.8f,
    1.5f,
    2f,
    2f,
    2f,
    3f,
    3f,
    3.5f,
    4f,
    5f,
    5f,
    5f,
    5f,
    5f,
    5f
  };
  public static float[] fDiffFac = new float[16]
  {
    1f,
    0.7f,
    2f,
    4f,
    20f,
    99.99f,
    500f,
    3000f,
    20000f,
    150000f,
    1000000f,
    1E+07f,
    1E+08f,
    1E+09f,
    1E+10f,
    1E+11f
  };
  public static float[] fDiffEmDmgFac = new float[16]
  {
    1f,
    0.5f,
    2f,
    3f,
    16f,
    60f,
    240f,
    480f,
    960f,
    2700f,
    4400f,
    6200f,
    8100f,
    10100f,
    12200f,
    14500f
  };
  public static double[] fDiffEmHpFac = new double[16]
  {
    1.0,
    0.8,
    2.0,
    4.0,
    20.0,
    200.0,
    1000.0,
    10000.0,
    100000.0,
    1000000.0,
    10000000.0,
    100000000.0,
    1000000000.0,
    10000000000.0,
    100000000000.0,
    1000000000000.0
  };
  public static float[] fDiffMutGrow = new float[16]{ 0.5f, 0.4f, 0.8f, 1f, 3f, 5f, 6f, 7f, 8f, 9f, 10f, 11f, 12f, 13f, 14f, 15f };
  public static ObscuredInt[] nEndlessMutationDay = new ObscuredInt[16]{ (ObscuredInt) 200, (ObscuredInt) 240, (ObscuredInt) 160, (ObscuredInt) 120, (ObscuredInt) 80, (ObscuredInt) 40, (ObscuredInt) 35, (ObscuredInt) 30, (ObscuredInt) 25, (ObscuredInt) 20, (ObscuredInt) 10, (ObscuredInt) 9, (ObscuredInt) 8, (ObscuredInt) 7, (ObscuredInt) 6, (ObscuredInt) 5 };
  public static ObscuredInt[] nMutateStartDay = new ObscuredInt[16]{ (ObscuredInt) 50, (ObscuredInt) 60, (ObscuredInt) 30, (ObscuredInt) 10, (ObscuredInt) 5, (ObscuredInt) 3, (ObscuredInt) 3, (ObscuredInt) 3, (ObscuredInt) 3, (ObscuredInt) 3, (ObscuredInt) 2, (ObscuredInt) 2, (ObscuredInt) 2, (ObscuredInt) 2, (ObscuredInt) 2, (ObscuredInt) 2 };
  public static ObscuredInt[] nDiffRepairCost = new ObscuredInt[16]{ (ObscuredInt) 8, (ObscuredInt) 4, (ObscuredInt) 12, (ObscuredInt) 20, (ObscuredInt) 40, (ObscuredInt) 60, (ObscuredInt) 100, (ObscuredInt) 200, (ObscuredInt) 300, (ObscuredInt) 400, (ObscuredInt) 500, (ObscuredInt) 600, (ObscuredInt) 700, (ObscuredInt) 800, (ObscuredInt) 900, (ObscuredInt) 1000 };
  public static ObscuredByte[] byInitBatch = new ObscuredByte[5]{ (ObscuredByte) (byte) 2, (ObscuredByte) (byte) 3, (ObscuredByte) (byte) 1, (ObscuredByte) (byte) 4, (ObscuredByte) (byte) 0 };
  public static List<PlayerAccData> listGetAcc = new List<PlayerAccData>();
  public static bool bRebirthChanged = false;
  public static bool bTempQuitBattle = false;
  public static int[] nMulStone = new int[10]{ 1, 1, 1, 1, 2, 2, 2, 3, 3, 4 };
  public static int nSelectedDiff = 0;
  public static ObscuredShort sSelectedRebirthCharID = (ObscuredShort) (short) 0;
  public static bool bForceQuit = false;
  public static bool bBattleFail = false;
  public static ObscuredFloat fDoubleDayPass = (ObscuredFloat) 1f;
  public static Dictionary<ElementalID, ObscuredFloat[]> dictElementalFac = new Dictionary<ElementalID, ObscuredFloat[]>();
  public static ObscuredInt[,] nAccEnchantMedal = new ObscuredInt[5, 11]{ { (ObscuredInt) 20, (ObscuredInt) 40, (ObscuredInt) 60, (ObscuredInt) 100, (ObscuredInt) 140, (ObscuredInt) 200, (ObscuredInt) 260, (ObscuredInt) 340, (ObscuredInt) 420, (ObscuredInt) 500, (ObscuredInt) 600 }, { (ObscuredInt) 400, (ObscuredInt) 600, (ObscuredInt) 1000, (ObscuredInt) 1400, (ObscuredInt) 2000, (ObscuredInt) 2600, (ObscuredInt) 3400, (ObscuredInt) 4200, (ObscuredInt) 5000, (ObscuredInt) 6000, (ObscuredInt) 7000 }, { (ObscuredInt) 6000, (ObscuredInt) 10000, (ObscuredInt) 14000, (ObscuredInt) 20000, (ObscuredInt) 26000, (ObscuredInt) 34000, (ObscuredInt) 42000, (ObscuredInt) 50000, (ObscuredInt) 60000, (ObscuredInt) 70000, (ObscuredInt) 80000 }, { (ObscuredInt) 10000, (ObscuredInt) 14000, (ObscuredInt) 20000, (ObscuredInt) 26000, (ObscuredInt) 34000, (ObscuredInt) 42000, (ObscuredInt) 50000, (ObscuredInt) 60000, (ObscuredInt) 70000, (ObscuredInt) 80000, (ObscuredInt) 90000 }, { (ObscuredInt) 28000, (ObscuredInt) 40000, (ObscuredInt) 52000, (ObscuredInt) 68000, (ObscuredInt) 84000, (ObscuredInt) 100000, (ObscuredInt) 120000, (ObscuredInt) 140000, (ObscuredInt) 160000, (ObscuredInt) 200000, (ObscuredInt) 300000 } };
  public static ObscuredInt[,] nAccEnchantStone = new ObscuredInt[5, 11]{ { (ObscuredInt) 1, (ObscuredInt) 5, (ObscuredInt) 10, (ObscuredInt) 15, (ObscuredInt) 25, (ObscuredInt) 35, (ObscuredInt) 50, (ObscuredInt) 65, (ObscuredInt) 85, (ObscuredInt) 105, (ObscuredInt) 0 }, { (ObscuredInt) 10, (ObscuredInt) 15, (ObscuredInt) 25, (ObscuredInt) 35, (ObscuredInt) 50, (ObscuredInt) 65, (ObscuredInt) 85, (ObscuredInt) 105, (ObscuredInt) 125, (ObscuredInt) 150, (ObscuredInt) 0 }, { (ObscuredInt) 25, (ObscuredInt) 35, (ObscuredInt) 50, (ObscuredInt) 65, (ObscuredInt) 85, (ObscuredInt) 105, (ObscuredInt) 125, (ObscuredInt) 150, (ObscuredInt) 200, (ObscuredInt) 250, (ObscuredInt) 0 }, { (ObscuredInt) 50, (ObscuredInt) 65, (ObscuredInt) 85, (ObscuredInt) 105, (ObscuredInt) 125, (ObscuredInt) 150, (ObscuredInt) 200, (ObscuredInt) 250, (ObscuredInt) 375, (ObscuredInt) 500, (ObscuredInt) 0 }, { (ObscuredInt) 85, (ObscuredInt) 105, (ObscuredInt) 125, (ObscuredInt) 150, (ObscuredInt) 200, (ObscuredInt) 250, (ObscuredInt) 375, (ObscuredInt) 500, (ObscuredInt) 750, (ObscuredInt) 1000, (ObscuredInt) 0 } };
  private static float[] fGradeRate = new float[5]{ 100f, 52f, 22f, 8f, 1.5f };
  public static Dictionary<int, float> dictItemPower = new Dictionary<int, float>();
  public static Dictionary<int, double> dictMonHP = new Dictionary<int, double>();
  public static Dictionary<int, float> dictMonDmg = new Dictionary<int, float>();
  private static Color[] clGrade = new Color[5]{ new Color(0.5f, 0.5f, 0.5f), new Color(0.0f, 0.921f, 0.182f), new Color(0.0f, 0.5f, 1f), new Color(1f, 0.0f, 0.929f), new Color(1f, 0.5f, 0.0f) };
  private static string[] strClGrade = new string[5]{ "<color='#4D4D4Dff'>", "<color='#00EA2Eff'>", "<color='#004Dffff'>", "<color='#ff00EAff'>", "<color='#ff4D00ff'>" };
  public static int nNewRuby = 0;
  public static int nNewStone = 0;
  public static float[] fAccDropFactor = new float[5]{ 0.0f, 96f, 48f, 12f, 3f };
  public static Ads eAds;
  public static ResearchID eSelectedResearch;
  public static ObscuredInt nSelectedElementalView;

  public static float fDifficult
  {
    get
    {
      return Info.fDiffFac[(int) Info.currentSave.nDiff];
    }
  }

  public static PlayerMonsterData currentMon
  {
    get
    {
      return Info.GetPlayerMon((int) Info.nSelectedMonster);
    }
  }

  public static int nCurHire
  {
    get
    {
      int num = 0;
      for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
      {
        if (Info.currentSave.arrPlayerMon[index] != null)
          ++num;
      }
      return num;
    }
  }

  public static int nMaxHire
  {
    get
    {
      return (int) Info.GetDungeonFactor(DungeonType.eExpand, -1);
    }
  }

  public static int nRepairCostOnePoint
  {
    get
    {
      return (int) Info.nDiffRepairCost[(int) Info.currentSave.nDiff];
    }
  }

  public static int nRepairCost
  {
    get
    {
      return (int) Mathf.Max(0.0f, (float) (((double) (float) Info.fDunMaxHP - (double) (float) Info.currentSave.fDunCurHP) * (1.0 - (double) Info.GetPartySkillFac(SkillKey.eRepairMan) * 0.00999999977648258)) * (float) Info.nRepairCostOnePoint);
    }
  }

  public static int nTodayStone
  {
    get
    {
      return Info.GetStone((int) Info.currentSave.nDay, (int) Info.currentSave.nDiff);
    }
  }

  public static int nTodayRuby
  {
    get
    {
      return Info.GetRuby((int) Info.currentSave.nMaxEndless, (int) Info.currentSave.nDiff);
    }
  }

  public static int nMaxEnchant
  {
    get
    {
      return 4 + Info.GetResearchFacInt(ResearchID.eAnvil) + Mathf.RoundToInt(Info.GetRebirthFac(RebirthID.eEnchant));
    }
  }

  public static int nMaxInven
  {
    get
    {
      return Mathf.RoundToInt(Info.GetDungeonFactor(DungeonType.eStorage, -1) + Info.GetRebirthFac(RebirthID.eItemBag));
    }
  }

  public static PlayerMonsterData GetPlayerMon(int nPos)
  {
    if (nPos >= Info.currentSave.arrPlayerMon.Length || nPos < 0)
      return (PlayerMonsterData) null;
    return Info.currentSave.arrPlayerMon[nPos];
  }

  public static int GetMonPos(PlayerMonsterData pData)
  {
    for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
    {
      if (Info.currentSave.arrPlayerMon[index] == pData)
        return index;
    }
    return -1;
  }

  public static PlayerItemData GetPlayerWeapon(long uid)
  {
    if (!Info.currentSave.dictItem.ContainsKey((ObscuredLong) uid))
      return (PlayerItemData) null;
    return Info.currentSave.dictItem[(ObscuredLong) uid];
  }

  public static PlayerAccData GetPlayerAcc(long uid)
  {
    if (!Info.rebirth.dictAcc.ContainsKey((ObscuredLong) uid))
      return (PlayerAccData) null;
    return Info.rebirth.dictAcc[(ObscuredLong) uid];
  }

  public static int GetDungeon(DungeonType eID)
  {
    if (!Info.currentSave.dictDun.ContainsKey(eID))
      Info.currentSave.dictDun.Add(eID, (ObscuredInt) 0);
    return (int) Info.currentSave.dictDun[eID];
  }

  public static int GetSkill(int nPos, SkillKey eSkill)
  {
    return Info.GetSkill(Info.GetPlayerMon(nPos), eSkill, false);
  }

  public static int GetSkill(PlayerMonsterData pData, SkillKey eSkill, bool bOriginal = false)
  {
    if (!pData.dictSkill.ContainsKey(eSkill))
      return 0;
    int num = (int) pData.dictSkill[eSkill];
    int monPos = Info.GetMonPos(pData);
    if (!bOriginal)
    {
      switch (eSkill)
      {
        case SkillKey.eAddShot:
          num += Info.GetAccModFacToInt(monPos, ModType.eAddShot);
          break;
        case SkillKey.eMultiShot:
          num += Info.GetAccModFacToInt(monPos, ModType.eMultiShot);
          break;
        case SkillKey.eFireBall:
          num += Info.GetAccModFacToInt(monPos, ModType.eFireBall);
          break;
        case SkillKey.eFireLance:
          num += Info.GetAccModFacToInt(monPos, ModType.eFireLance);
          break;
        case SkillKey.eBigShot:
          num += Info.GetAccModFacToInt(monPos, ModType.eBigShot);
          break;
        case SkillKey.eRicochet:
          num += Info.GetAccModFacToInt(monPos, ModType.eRicochet);
          break;
        case SkillKey.eDimensionKick:
          num += Info.GetAccModFacToInt(monPos, ModType.eDimensionKick);
          break;
        case SkillKey.eHighKick:
          num += Info.GetAccModFacToInt(monPos, ModType.eStrongKick);
          break;
        case SkillKey.eTripleSword:
          num += Info.GetAccModFacToInt(monPos, ModType.eTripleSword);
          break;
        case SkillKey.eSevenSword:
          num += Info.GetAccModFacToInt(monPos, ModType.eSevenSword);
          break;
        default:
          if (eSkill == SkillKey.eSoulBomb)
          {
            num += Info.GetAccModFacToInt(monPos, ModType.eSoulBomb);
            break;
          }
          break;
      }
      if (BData.GetSkill(eSkill).eType != SkillType.eMastery)
        num += Info.GetAccModFacToInt(monPos, ModType.eAllSkill);
    }
    return num;
  }

  public static float GetAccModFac(ModType eID)
  {
    return (float) Info.fAllAccMod[(int) eID];
  }

  public static float GetAccModFac(int nPos, ModType eID)
  {
    if (nPos < 0)
      return 0.0f;
    return (float) Info.fPlayerAccMod[nPos, (int) eID];
  }

  public static int GetAccModFacToInt(int nPos, ModType eID)
  {
    return Mathf.FloorToInt(Info.GetAccModFac(nPos, eID));
  }

  public static float GetSkillFac(int nPos, SkillKey eKey)
  {
    return Info.GetSkillFac(Info.GetPlayerMon(nPos), eKey);
  }

  public static float GetSkillFac(PlayerMonsterData pData, SkillKey eKey)
  {
    SkillData skill1 = BData.GetSkill(eKey);
    int skill2 = Info.GetSkill(pData, eKey, false);
    if (skill2 == 0)
      return 0.0f;
    float num = 1f;
    if (eKey == SkillKey.eRicochet && (double) Info.GetAccModFac(Info.GetMonPos(pData), ModType.eRicochetDouble) > 0.0)
      num = 2f;
    return (skill1.fFactor + skill1.fGrow * (float) skill2) * num;
  }

  public static float GetSkillFac2(int nPos, SkillKey eKey)
  {
    return Info.GetSkillFac2(Info.GetPlayerMon(nPos), eKey);
  }

  public static float GetSkillFac2(PlayerMonsterData pData, SkillKey eKey)
  {
    SkillData skill1 = BData.GetSkill(eKey);
    int skill2 = Info.GetSkill(pData, eKey, false);
    if (skill2 == 0)
      return 0.0f;
    return skill1.fFactor2 + skill1.fGrow2 * (float) skill2;
  }

  public static void HireMonster(short sID)
  {
    Info.HireMonster(Info.GetNewPlayerMon(sID, false, true));
  }

  public static int HireMonster(PlayerMonsterData data)
  {
    int index1 = -1;
    for (int index2 = 0; index2 < Info.currentSave.arrPlayerMon.Length; ++index2)
    {
      if (Info.currentSave.arrPlayerMon[index2] == null)
      {
        index1 = index2;
        break;
      }
    }
    List<byte> byteList = new List<byte>();
    for (int index2 = 0; index2 < Info.currentSave.arrPlayerMon.Length; ++index2)
    {
      if (Info.currentSave.arrPlayerMon[index2] != null)
        byteList.Add(Info.currentSave.arrPlayerMon[index2].byBatch);
    }
    for (int index2 = 0; index2 < 5; ++index2)
    {
      bool flag = false;
      for (int index3 = 0; index3 < byteList.Count; ++index3)
      {
        if ((int) (byte) Info.byInitBatch[index2] == (int) byteList[index3])
        {
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        data.byBatch = (byte) Info.byInitBatch[index2];
        break;
      }
    }
    if (index1 == -1)
      return 0;
    long num = (long) Info.AddPlayerWeapon(BData.GetMonster((short) data.sID).sStartItem, (int) Mathf.Max(1f, UnityEngine.Random.Range((float) (int) data.nLv * 0.4f, (float) (int) data.nLv * 0.8f)));
    data.nEquip = (ObscuredLong) num;
    Info.currentSave.arrPlayerMon[index1] = data;
    return index1;
  }

  public static void DismissMonster(int nPos)
  {
    if (Info.currentSave.arrPlayerMon[nPos] == null)
      return;
    SavedData currentSave = Info.currentSave;
    string str = currentSave.strSummary + "\n\n" + BData.GetString("UI0122").Replace("[1]", BData.GetString(BData.GetMonster((short) Info.currentSave.arrPlayerMon[nPos].sID).strName));
    currentSave.strSummary = str;
    Info.currentSave.arrPlayerMon[nPos] = (PlayerMonsterData) null;
  }

  public static bool CanHireMonster()
  {
    return Info.nCurHire < Info.nMaxHire;
  }

  public static void RefreshHireMonster()
  {
    List<short> shortList = new List<short>();
    for (int index = 0; index < BData.dictMonster.Count; ++index)
    {
      MonsterData monster = BData.GetMonster((short) index);
      if (Info.achievement.listAcv.Count >= monster.nNeedAcv && (monster.eNeedRebirth == RebirthID.eNone || Info.CheckRebirth(monster.eNeedRebirth)))
        shortList.Add((short) index);
    }
    for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
    {
      if (Info.currentSave.arrPlayerMon[index] != null)
        shortList.Remove((short) Info.currentSave.arrPlayerMon[index].sID);
    }
    Info.currentSave.pHireMonster = Info.GetNewPlayerMon(shortList[UnityEngine.Random.Range(0, shortList.Count)], true, true);
  }

  public static PlayerMonsterData GetNewPlayerMon(short sID, bool bLevel = false, bool bStartLv = true)
  {
    PlayerMonsterData pData = new PlayerMonsterData();
    MonsterData monster = BData.GetMonster(sID);
    pData.sID = (ObscuredShort) sID;
    pData.nLv = (ObscuredInt) 1;
    pData.nExp = (ObscuredInt) 0;
    for (int index = 0; index < monster.listSkill.Count; ++index)
    {
      if (!pData.dictSkill.ContainsKey(monster.listSkill[index]))
        pData.dictSkill.Add(monster.listSkill[index], (ObscuredInt) 1);
    }
    if (bLevel)
    {
      pData.nLv = (ObscuredInt) UnityEngine.Random.Range(Mathf.Max((int) ((double) (int) Info.currentSave.nDay * 0.5), 1), (int) Info.currentSave.nDay);
      if (Info.CheckResearch(ResearchID.eGuild))
        pData.nLv = (ObscuredInt) Mathf.Max((int) Info.currentSave.arrPlayerMon[0].nLv, (int) pData.nLv);
    }
    else
      pData.nLv = (ObscuredInt) (!bStartLv ? 1 : Mathf.RoundToInt(Info.GetRebirthFac(RebirthID.eStartLevel)) + 1);
    if ((int) pData.nLv > 1)
    {
      List<SkillKey> skillKeyList = new List<SkillKey>();
      for (int index = 0; index < (int) pData.nLv - 1; ++index)
      {
        skillKeyList.Clear();
        List<SkillKey> learnableSkill = Info.GetLearnableSkill(pData);
        if (learnableSkill.Count != 0)
          Info.LearnSkill(pData, learnableSkill[UnityEngine.Random.Range(0, learnableSkill.Count)]);
        Info.LearnSkill(pData, Info.GetRandomMastery(pData));
      }
    }
    return pData;
  }

  public static bool CanUpgDungeon(DungeonType eID, int nNum = 1)
  {
    if (Info.GetDungeon(eID) < BData.GetDungeon(eID).nMax)
      return (long) Info.GetCostDungeon(eID, nNum) <= (long) Info.currentSave.nNewGold;
    return false;
  }

  public static bool UpgDungeon(DungeonType eID, int nNum = 1)
  {
    DungeonData dungeon1 = BData.GetDungeon(eID);
    int dungeon2 = Info.GetDungeon(eID);
    if (dungeon2 >= dungeon1.nMax)
      return false;
    int costDungeon = Info.GetCostDungeon(eID, nNum);
    if ((long) costDungeon > (long) Info.currentSave.nNewGold)
      return false;
    SavedData currentSave1 = Info.currentSave;
    ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave1.nNewGold - (long) costDungeon);
    currentSave1.nNewGold = obscuredLong;
    float fDunMaxHp = (float) Info.fDunMaxHP;
    int num = dungeon2 + nNum;
    Info.currentSave.dictDun[eID] = (ObscuredInt) num;
    if (eID == DungeonType.eDunHP)
    {
      Info.RefreshDungeonHP();
      SavedData currentSave2 = Info.currentSave;
      ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) currentSave2.fDunCurHP + ((float) Info.fDunMaxHP - fDunMaxHp));
      currentSave2.fDunCurHP = obscuredFloat;
    }
    SavedData currentSave3 = Info.currentSave;
    string str = currentSave3.strSummary + "\n" + BData.GetString("UI0069").Replace("[1]", BData.GetString(dungeon1.strName) + " Lv." + Info.currentSave.dictDun[eID].ToString());
    currentSave3.strSummary = str;
    if (eID == DungeonType.eBank)
    {
      if (num >= 10)
        Info.CheckAchievement(AchievementType.eBank10);
      if (num >= 30)
        Info.CheckAchievement(AchievementType.eBank30);
      if (num >= 60)
        Info.CheckAchievement(AchievementType.eBank60);
      if (num >= 100)
        Info.CheckAchievement(AchievementType.eBank100);
      Info.TrySaveAchievement();
    }
    else if (eID == DungeonType.eExpand)
    {
      if (num >= 1)
        Info.CheckAchievement(AchievementType.eExpand1);
      if (num >= 2)
        Info.CheckAchievement(AchievementType.eExpand2);
      if (num >= 3)
        Info.CheckAchievement(AchievementType.eExpand3);
    }
    else if (eID == DungeonType.eLab)
      Info.RefreshResearchPower();
    return true;
  }

  public static void RefreshDungeonHP()
  {
    Info.fDunMaxHP = (ObscuredFloat) (Info.GetDungeonFactor(DungeonType.eDunHP, -1) + Info.GetAccModFac(ModType.eHP) + (float) Info.GetRebirthFacToInt(RebirthID.eDunHp));
    Info.currentSave.fDunCurHP = (ObscuredFloat) Mathf.Clamp((float) Info.currentSave.fDunCurHP, 1f, (float) Info.fDunMaxHP);
    Info.fDunRegen = (ObscuredFloat) (Info.GetDungeonFactor(DungeonType.eAutoRepair, -1) + Info.GetAccModFac(ModType.eRegen));
  }

  public static int GetCostDungeon(DungeonType eID, int nNum = 1)
  {
    DungeonData dungeon1 = BData.GetDungeon(eID);
    int dungeon2 = Info.GetDungeon(eID);
    float num1 = 1f;
    if (eID == DungeonType.eBank)
      num1 *= (float) (1.0 - (double) Info.GetResearchFac(ResearchID.eMiniBank) * 0.00999999977648258);
    float num2 = num1 * (float) ((1.0 - (double) Info.GetPartySkillFac(SkillKey.eBuilder) * 0.00999999977648258) * (1.0 - (double) Info.GetResearchFac(ResearchID.eArchitect) * 0.00999999977648258) * (1.0 - (double) Info.GetElementalFac(ElementalID.eNatureBuild, 0) * 0.00999999977648258));
    int num3 = 0;
    for (int index = 0; index < nNum; ++index)
    {
      num3 += Mathf.RoundToInt((float) (((double) dungeon1.fCost + (double) dungeon1.fCostAdd * (double) dungeon2 + (double) dungeon1.fCostGrow * (double) (dungeon2 * (dungeon2 + 1)) / 2.0) * ((double) dungeon1.fCostMul > 1.0 ? (double) Mathf.Pow(dungeon1.fCostMul, (float) dungeon2) : 1.0)) * num2);
      ++dungeon2;
    }
    return num3;
  }

  public static float GetDungeonFactor(DungeonType eID, int nLv = -1)
  {
    DungeonData dungeon = BData.GetDungeon(eID);
    if (nLv == -1)
      nLv = Info.GetDungeon(eID);
    float num = 1f;
    if (eID == DungeonType.eAutoRepair || eID == DungeonType.eRegen)
      num = (num + Info.GetResearchFac(ResearchID.eHospital) * 0.01f) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eRegen) * 0.00999999977648258);
    else if (eID == DungeonType.eBank)
      num = num * (float) (1.0 + (double) Info.GetAcvReward(AcvRewardType.eBankBonus) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eBank) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eCalculator) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eGuildBank) * 0.00999999977648258 * (double) Info.GetDungeon(DungeonType.eStatue)) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eStockMarket) * 0.00999999977648258 * (double) Info.achievement.listAcv.Count);
    else if (eID == DungeonType.eStatue)
      num = num * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eHugeStatue) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eAcientStatue) * 0.00999999977648258 * (double) (int) Info.currentSave.nDay) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eLightStatue, 0) * 0.00999999977648258);
    else if (eID == DungeonType.eLab)
      num = num * (float) (1.0 + (double) Info.GetAccModFac(ModType.eResearch) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eResearch) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eScientist) * 0.00999999977648258);
    else if (eID == DungeonType.eDunHP)
      num = num * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eDunHealthParty) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eNatureMaxHP, 0) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eFireBase1, 2) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eWaterBase1, 1) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eNatureBase1, 1) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eLightBase1, 1) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eDarkBase1, 0) * 0.00999999977648258);
    return (dungeon.fBase + dungeon.fGrow * (float) nLv) * num;
  }

  public static ObscuredLong AddRandomDropWeapon()
  {
    int nDay = Mathf.RoundToInt(UnityEngine.Random.Range(Mathf.Max(1f, (float) ((double) (int) Info.currentSave.nDay * 0.75 - 1.0)), (float) ((double) (int) Info.currentSave.nDay * 1.25 + 2.0) + Info.GetPartySkillFac(SkillKey.eGoodReward)));
    if ((int) Info.currentSave.nDay < 10 && Info.listDropItem.Count == 0)
      nDay = (int) Info.currentSave.nDay;
    return Info.AddDropWeapon(Info.GetRandomWeapon(nDay, false), nDay);
  }

  public static short GetRandomWeapon(int nItemLv, bool bShop)
  {
    List<short> shortList = new List<short>();
    List<ItemData> itemDataList = new List<ItemData>((IEnumerable<ItemData>) BData.dictWeapon.Values);
    bool flag = (int) Info.currentSave.nDay < 10 && Info.listDropItem.Count == 0 && !bShop;
    for (int index = 0; index < itemDataList.Count; ++index)
    {
      if (itemDataList[index].nDropMin <= nItemLv && itemDataList[index].nDropMax >= nItemLv)
      {
        shortList.Add(itemDataList[index].sID);
        if (flag && Info.GetPlayerMon(0).dictSkill.ContainsKey(itemDataList[index].eMastery))
          return itemDataList[index].sID;
      }
    }
    if (shortList.Count == 0)
      return -1;
    return shortList[UnityEngine.Random.Range(0, shortList.Count)];
  }

  public static void AddWeaponToInventory(PlayerItemData pData)
  {
    Info.currentSave.dictItem.Add(pData.UID, pData);
  }

  public static ObscuredLong AddPlayerWeapon(short sID, int nLv)
  {
    PlayerItemData pData = Info.NewPlayerItem(sID, nLv, false);
    Info.currentSave.dictItem.Add(pData.UID, pData);
    Info.RefreshBattleItemData(pData);
    return pData.UID;
  }

  public static ObscuredLong AddDropWeapon(short sID, int nLv = 1)
  {
    PlayerItemData pData = Info.NewPlayerItem(sID, nLv, false);
    int num = 0;
    for (int index = 0; index < (int) pData.nMod; ++index)
    {
      if (UnityEngine.Random.Range(0, 100) < 25)
        ++num;
    }
    for (int index = 0; index < num; ++index)
      pData.arrMod[index] = Info.GetRandomMod(pData, -1, false);
    Info.listDropItem.Add(pData);
    return pData.UID;
  }

  public static int GetWage(int nPos)
  {
    if (nPos == 0)
      return 0;
    return Info.GetWageByLv((int) Info.GetPlayerMon(nPos).nLv);
  }

  public static int GetWageByLv(int nLv)
  {
    return 10 + nLv * 10;
  }

  public static bool IsEquipped(long uid)
  {
    for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
    {
      if (Info.currentSave.arrPlayerMon[index] != null && (long) Info.currentSave.arrPlayerMon[index].nEquip == uid)
        return true;
    }
    return false;
  }

  public static bool IsEquippedAcc(long uid)
  {
    if (uid == -1L)
      return false;
    for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
    {
      if (Info.currentSave.arrPlayerMon[index] != null && ((long) Info.currentSave.arrPlayerMon[index].nAmulet == uid || (long) Info.currentSave.arrPlayerMon[index].nRing == uid))
        return true;
    }
    return false;
  }

  public static bool IsEquippedAcc(int mon, long uid)
  {
    return uid != -1L && Info.GetPlayerMon(mon) != null && ((long) Info.GetPlayerMon(mon).nAmulet == uid || (long) Info.GetPlayerMon(mon).nRing == uid);
  }

  public static bool IsEquipped(int mon, long uid)
  {
    if (Info.GetPlayerMon(mon) == null)
      return false;
    return (long) Info.GetPlayerMon(mon).nEquip == uid;
  }

  public static void SetWave(int _nDay)
  {
    Info.currentSave.nDay = (ObscuredInt) _nDay;
    Info.wave.fWaveLenth = (ObscuredFloat) Mathf.Min((float) (2.5 + (double) (int) Info.currentSave.nDay * (3.0 / 1000.0)), 4f);
    if (Info.option.bFastSpawn)
      Info.wave.fWaveLenth = (ObscuredFloat) Mathf.Min((float) (2.5 + (double) (int) Info.currentSave.nDay * (1.0 / 400.0)), 3.5f);
    Info.wave.nCurrentWave = (ObscuredInt) 0;
    Info.wave.nMaxWave = (ObscuredInt) (4 + Mathf.Min(5, (int) Info.currentSave.nDay / 50) + ((int) Info.currentSave.nDay <= 2 ? 0 : 1));
    Info.wave.nSpawn = (ObscuredInt) Mathf.Min(9 + (int) Info.currentSave.nDay / 9, 42);
  }

  public static void NextDay()
  {
    Info.currentSave.bChallengeTrial = false;
    Info.currentSave.bChallengeEndless = false;
    Info.currentSave.bHireMonster = false;
    Info.currentSave.bProgressResearch = true;
    Info.currentSave.nEnchant = (ObscuredInt) 0;
    if ((int) Info.currentSave.nDay != 1)
      Info.currentSave.fResearchProgress += Info.currentSave.fResearch + (float) Info.fResearchPower * (float) Info.fDoubleDayPass;
    Info.currentSave.fResearch = 0.0f;
    if ((double) (float) Info.currentSave.fDunCurHP >= (double) (float) Info.fDunMaxHP)
    {
      SavedData currentSave = Info.currentSave;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) currentSave.nPerfect + (int) (float) Info.fDoubleDayPass);
      currentSave.nPerfect = obscuredInt;
      if ((int) Info.currentSave.nPerfect >= 1)
        Info.CheckAchievement(AchievementType.ePerfect1);
      if ((int) Info.currentSave.nPerfect >= 3)
        Info.CheckAchievement(AchievementType.ePerfect3);
      if ((int) Info.currentSave.nPerfect >= 5)
        Info.CheckAchievement(AchievementType.ePerfect5);
      if ((int) Info.currentSave.nPerfect >= 10)
        Info.CheckAchievement(AchievementType.ePerfect10);
      if ((int) Info.currentSave.nPerfect >= 25)
        Info.CheckAchievement(AchievementType.ePerfect25);
      if ((int) Info.currentSave.nPerfect >= 25 && (int) Info.currentSave.nDiff >= 2)
        Info.CheckAchievement(AchievementType.ePerfectHard25);
      if ((int) Info.currentSave.nPerfect >= 100 && (int) Info.currentSave.nDiff >= 2)
        Info.CheckAchievement(AchievementType.ePerfectHard100);
    }
    Info.nBattleGold = (ObscuredInt) ((int) ((double) (int) Info.nBattleGold * (1.0 + (double) Info.GetPartySkillFac(SkillKey.eHunter) * 0.00999999977648258) * (1.0 + (double) Info.GetAccModFac(ModType.eGold) * 0.00999999977648258) * (double) (float) Info.fDoubleDayPass));
    SavedData currentSave1 = Info.currentSave;
    ObscuredInt obscuredInt1 = (ObscuredInt) ((int) currentSave1.nDay + (int) (float) Info.fDoubleDayPass);
    currentSave1.nDay = obscuredInt1;
    float dungeonFactor = Info.GetDungeonFactor(DungeonType.eRegen, -1);
    if ((double) dungeonFactor > 0.0)
    {
      Info.currentSave.fDunCurHP = (ObscuredFloat) Mathf.Clamp((float) Info.currentSave.fDunCurHP + dungeonFactor * (float) Info.fDoubleDayPass, 0.0f, (float) Info.fDunMaxHP);
      SavedData currentSave2 = Info.currentSave;
      string str = currentSave2.strSummary + "\n\n" + BData.GetString("UI0062").Replace("[1]", (dungeonFactor * (float) Info.fDoubleDayPass).ToString("N0"));
      currentSave2.strSummary = str;
    }
    int num1 = Info.CalcLevelUp() * (int) (float) Info.fDoubleDayPass;
    SavedData currentSave3 = Info.currentSave;
    ObscuredLong obscuredLong1 = (ObscuredLong) ((long) currentSave3.nNewGold + (long) ((int) Info.nBattleGold * (int) (float) Info.fDoubleDayPass));
    currentSave3.nNewGold = obscuredLong1;
    SavedData currentSave4 = Info.currentSave;
    string str1 = currentSave4.strSummary + "\n\n" + BData.GetString("UI0070").Replace("[1]", ((float) (int) Info.nBattleGold * (float) Info.fDoubleDayPass).ToString("N0"));
    currentSave4.strSummary = str1;
    Info.nBattleGold = (ObscuredInt) 0;
    int num2 = Mathf.RoundToInt((float) ((double) num1 * ((double) Info.GetPartySkillFac(SkillKey.eAccountant) + (double) Info.GetAcvReward(AcvRewardType.eWageDC)) * 0.00999999977648258));
    int num3 = Mathf.RoundToInt(Info.GetDungeonFactor(DungeonType.eBank, -1) * (float) Info.fDoubleDayPass);
    if (num3 > 0)
    {
      SavedData currentSave2 = Info.currentSave;
      ObscuredLong obscuredLong2 = (ObscuredLong) ((long) currentSave2.nNewGold + (long) num3);
      currentSave2.nNewGold = obscuredLong2;
      SavedData currentSave5 = Info.currentSave;
      string str2 = currentSave5.strSummary + "\n\n" + BData.GetString("UI0068").Replace("[1]", num3.ToString("N0"));
      currentSave5.strSummary = str2;
    }
    int num4 = Mathf.RoundToInt(Info.GetDungeonFactor(DungeonType.eStatue, -1) * (float) Info.achievement.listAcv.Count * (float) Info.fDoubleDayPass);
    if (num4 > 0)
    {
      SavedData currentSave2 = Info.currentSave;
      ObscuredLong obscuredLong2 = (ObscuredLong) ((long) currentSave2.nNewGold + (long) num4);
      currentSave2.nNewGold = obscuredLong2;
      SavedData currentSave5 = Info.currentSave;
      string str2 = currentSave5.strSummary + "\n\n" + BData.GetString("UI0119").Replace("[1]", num4.ToString("N0"));
      currentSave5.strSummary = str2;
    }
    SavedData currentSave6 = Info.currentSave;
    ObscuredLong obscuredLong3 = (ObscuredLong) ((long) currentSave6.nNewGold - (long) (num1 - num2));
    currentSave6.nNewGold = obscuredLong3;
    if ((long) Info.currentSave.nNewGold < 0L)
      Info.currentSave.nNewGold = (ObscuredLong) 0L;
    SavedData currentSave7 = Info.currentSave;
    string str3 = currentSave7.strSummary + "\n\n" + BData.GetString("UI0067").Replace("[1]", num1.ToString("N0")).Replace("[2]", num2.ToString("N0"));
    currentSave7.strSummary = str3;
    Info.RefreshShopItem();
    SavedData currentSave8 = Info.currentSave;
    string str4 = currentSave8.strSummary + "\n\n" + BData.GetString("UI0083").Replace("[1]", ((int) (byte) Info.byCurrentSaveSlot + 1).ToString("0"));
    currentSave8.strSummary = str4;
    if ((double) (float) Info.fDoubleDayPass > 1.0)
    {
      SavedData currentSave2 = Info.currentSave;
      string str2 = currentSave2.strSummary + "\n!" + BData.GetString(BData.GetString(BData.GetElemental(ElementalID.eDarkSkip).strName)) + "!";
      currentSave2.strSummary = str2;
    }
    Info.CheckAcvSurvive();
  }

  public static int CalcLevelUp()
  {
    int wage = Info.GetWage(0);
    for (int nPos = 1; nPos < Info.currentSave.arrPlayerMon.Length; ++nPos)
    {
      if (Info.currentSave.arrPlayerMon[nPos] != null)
      {
        wage += Info.GetWage(nPos);
        PlayerMonsterData playerMonsterData;
        ObscuredInt obscuredInt;
        for (; (int) Info.currentSave.arrPlayerMon[nPos].nExp >= Info.GetNeedExp(nPos); playerMonsterData.nExp = obscuredInt)
        {
          int needExp = Info.GetNeedExp(nPos);
          ++Info.currentSave.arrPlayerMon[nPos].nLv;
          List<SkillKey> learnableSkill = Info.GetLearnableSkill(nPos);
          SkillKey eSkill = learnableSkill[UnityEngine.Random.Range(0, learnableSkill.Count)];
          if ((bool) Info.currentSave.arrPlayerMon[nPos].bFocused)
          {
            for (int index = 0; index < learnableSkill.Count; ++index)
            {
              if (learnableSkill[index] == Info.currentSave.arrPlayerMon[nPos].eFocusedSkill)
                eSkill = learnableSkill[index];
            }
          }
          int nSkillLv1 = Info.LearnSkill(Info.currentSave.arrPlayerMon[nPos], eSkill);
          Info.AddSummaryMessageLv(nPos, (int) Info.currentSave.arrPlayerMon[nPos].nLv);
          Info.AddSummaryMessageSkill(eSkill, nSkillLv1);
          SkillKey randomMastery = Info.GetRandomMastery(nPos);
          int nSkillLv2 = Info.LearnSkill(Info.currentSave.arrPlayerMon[nPos], randomMastery);
          Info.AddSummaryMessageSkill(randomMastery, nSkillLv2);
          playerMonsterData = Info.currentSave.arrPlayerMon[nPos];
          obscuredInt = (ObscuredInt) ((int) playerMonsterData.nExp - needExp);
        }
      }
    }
    return wage;
  }

  public static void CalcExp(bool bClear)
  {
    float num1 = Info.GetDungeonFactor(DungeonType.eNest, -1) * 0.01f;
    int num2 = !bClear ? 0 : 45 * (1 + Mathf.RoundToInt(Info.GetResearchFac(ResearchID.eEducation) * 0.01f));
    for (int index = 0; index < Info.currentSave.arrPlayerMon.Length; ++index)
    {
      if (Info.currentSave.arrPlayerMon[index] != null)
      {
        PlayerMonsterData playerMonsterData = Info.currentSave.arrPlayerMon[index];
        ObscuredInt obscuredInt = (ObscuredInt) ((int) playerMonsterData.nExp + (int) (((double) (int) Info.nBattleExp * 0.200000002980232 + (double) num2) * (1.0 + (double) num1) * (1.0 + (double) Info.GetAccModFac(ModType.eExp) * 0.00999999977648258) * (1.0 + (double) Info.GetResearchFac(ResearchID.eBattleExp) * 0.00999999977648258) * (double) (float) Info.fDoubleDayPass));
        playerMonsterData.nExp = obscuredInt;
      }
    }
  }

  public static string GetWeaponTypeName(WeaponType type)
  {
    return BData.GetString("UI00" + ((int) (21 + type)).ToString("00"));
  }

  public static bool CheckWeaponMastery(int nPos, long uid)
  {
    PlayerMonsterData playerMon = Info.GetPlayerMon(nPos);
    BattleItemData battleItem = Info.GetBattleItem(uid);
    ItemData weapon = BData.GetWeapon((short) battleItem.sID);
    return playerMon.dictSkill.ContainsKey(battleItem.eMastery) && (int) playerMon.dictSkill[weapon.eMastery] >= battleItem.nMastery;
  }

  public static int LearnSkill(int nPos, SkillKey eSkill)
  {
    return Info.LearnSkill(Info.GetPlayerMon(nPos), eSkill);
  }

  public static int LearnSkill(PlayerMonsterData pData, SkillKey eSkill)
  {
    if (pData == null)
      return 0;
    if (!pData.dictSkill.ContainsKey(eSkill))
      pData.dictSkill.Add(eSkill, (ObscuredInt) 0);
    int num = (int) pData.dictSkill[eSkill];
    pData.dictSkill[eSkill] = (ObscuredInt) (num + 1);
    return (int) pData.dictSkill[eSkill];
  }

  public static List<SkillKey> GetLearnableSkill(int nPos)
  {
    return Info.GetLearnableSkill(Info.GetPlayerMon(nPos));
  }

  public static List<SkillKey> GetLearnableSkill(PlayerMonsterData pData)
  {
    MonsterData monster = BData.GetMonster((short) pData.sID);
    List<SkillKey> skillKeyList1 = new List<SkillKey>();
    List<SkillKey> skillKeyList2 = new List<SkillKey>();
    List<SkillKey> skillKeyList3 = new List<SkillKey>();
    skillKeyList3.AddRange((IEnumerable<SkillKey>) monster.listLearnSkill);
    if (Info.isAwaken(pData))
      skillKeyList3.AddRange((IEnumerable<SkillKey>) monster.listAwakenLearnSkill);
    bool flag = Info.currentSave.arrPlayerMon[0] == pData;
    for (int index = 0; index < skillKeyList3.Count; ++index)
    {
      SkillData skill = BData.GetSkill(skillKeyList3[index]);
      if (skill != null && (!pData.dictSkill.ContainsKey(skill.eKey) || (int) pData.dictSkill[skill.eKey] < skill.nMax) && (skill.eType != SkillType.eMastery && (flag || skill.eType != SkillType.eAwaken)))
        skillKeyList1.Add(skill.eKey);
    }
    int num = 2 + Info.GetSkill(pData, SkillKey.ePotential, false);
    Info.GetSkill(pData, SkillKey.ePotential, false);
    for (int index = 0; index < num && skillKeyList1.Count >= 1; ++index)
    {
      SkillKey skillKey = skillKeyList1[UnityEngine.Random.Range(0, skillKeyList1.Count)];
      skillKeyList2.Add(skillKey);
      skillKeyList1.Remove(skillKey);
    }
    return skillKeyList2;
  }

  public static SkillKey GetRandomMastery(int nPos)
  {
    return Info.GetRandomMastery(Info.GetPlayerMon(nPos));
  }

  public static SkillKey GetRandomMastery(PlayerMonsterData pData)
  {
    MonsterData monster = BData.GetMonster((short) pData.sID);
    List<SkillKey> skillKeyList = new List<SkillKey>();
    for (int index = 0; index < monster.listSkill.Count; ++index)
    {
      SkillData skill = BData.GetSkill(monster.listSkill[index]);
      if (skill != null && skill.eType == SkillType.eMastery)
        skillKeyList.Add(skill.eKey);
    }
    return skillKeyList[UnityEngine.Random.Range(0, skillKeyList.Count)];
  }

  public static void RefreshPartySkill()
  {
    Info.dictPartySkill.Clear();
    Info.dictPSkillFac1.Clear();
    Info.dictPSkillFac2.Clear();
    List<SkillData> skillDataList = new List<SkillData>((IEnumerable<SkillData>) BData.dictSkill.Values);
    for (int index = 0; index < skillDataList.Count; ++index)
      Info.dictPartySkill.Add(skillDataList[index].eKey, (ObscuredInt) 0);
    for (int nPos = 0; nPos < Info.currentSave.arrPlayerMon.Length; ++nPos)
    {
      if (Info.currentSave.arrPlayerMon[nPos] != null)
      {
        List<SkillKey> skillKeyList = new List<SkillKey>((IEnumerable<SkillKey>) Info.currentSave.arrPlayerMon[nPos].dictSkill.Keys);
        for (int index = 0; index < skillKeyList.Count; ++index)
        {
          if ((int) Info.dictPartySkill[skillKeyList[index]] < Info.GetSkill(nPos, skillKeyList[index]))
            Info.dictPartySkill[skillKeyList[index]] = (ObscuredInt) Info.GetSkill(nPos, skillKeyList[index]);
        }
      }
    }
    for (int index = 0; index < skillDataList.Count; ++index)
    {
      SkillData skill = BData.GetSkill(skillDataList[index].eKey);
      int num = (int) Info.dictPartySkill[skillDataList[index].eKey];
      Info.dictPSkillFac1.Add(skillDataList[index].eKey, (ObscuredFloat) (num != 0 ? skill.fFactor + skill.fGrow * (float) num : 0.0f));
      Info.dictPSkillFac2.Add(skillDataList[index].eKey, (ObscuredFloat) (num != 0 ? skill.fFactor2 + skill.fGrow2 * (float) num : 0.0f));
    }
  }

  public static float GetPartySkill(SkillKey eSkill)
  {
    if (!Info.dictPartySkill.ContainsKey(eSkill))
      Info.dictPartySkill.Add(eSkill, (ObscuredInt) 0);
    return (float) (int) Info.dictPartySkill[eSkill];
  }

  public static float GetPartySkillFac(SkillKey eSkill)
  {
    return (float) Info.dictPSkillFac1[eSkill];
  }

  public static float GetPartySkillFac2(SkillKey eSkill)
  {
    return (float) Info.dictPSkillFac2[eSkill];
  }

  public static void AddSummaryMessageLv(int nPos, int nLv)
  {
    SavedData currentSave = Info.currentSave;
    string str = currentSave.strSummary + "\n" + BData.GetString("UI0064").Replace("[1]", BData.GetString(BData.GetMonster((short) Info.GetPlayerMon(nPos).sID).strName)).Replace("[2]", nLv.ToString());
    currentSave.strSummary = str;
  }

  public static void AddSummaryMessageSkill(SkillKey eSkill, int nSkillLv)
  {
    SavedData currentSave = Info.currentSave;
    string str = currentSave.strSummary + "\n" + BData.GetString("UI0065").Replace("[1]", BData.GetString(BData.GetSkill(eSkill).strName) + " Lv." + nSkillLv.ToString());
    currentSave.strSummary = str;
  }

  public static void RefreshShopItem()
  {
    Info.currentSave.listShopItem.Clear();
    int dungeonFactor = (int) Info.GetDungeonFactor(DungeonType.eShop, -1);
    for (int index = 0; index < dungeonFactor; ++index)
    {
      int num = UnityEngine.Random.Range(Mathf.Max((int) Info.currentSave.nDay - 5, 1), (int) Info.currentSave.nDay + 3);
      short randomWeapon = Info.GetRandomWeapon(num, true);
      if ((int) randomWeapon != -1)
      {
        PlayerItemData pData = Info.NewPlayerItem(randomWeapon, num, true);
        Info.currentSave.listShopItem.Add(pData);
        Info.RefreshBattleItemData(pData);
      }
    }
    Info.currentSave.listShopItem.Sort((Comparison<PlayerItemData>) ((x, y) =>
    {
      if ((int) x.nLv < (int) y.nLv)
        return 1;
      if ((int) x.nLv > (int) y.nLv)
        return -1;
      if ((int) (byte) x.byGrade < (int) (byte) y.byGrade)
        return 1;
      return (int) (byte) x.byGrade > (int) (byte) y.byGrade ? -1 : 0;
    }));
  }

  public static PlayerItemData NewPlayerItem(short sID, int nLv, bool bShop = false)
  {
    PlayerItemData playerItemData = new PlayerItemData();
    playerItemData.UID = (ObscuredLong) Info.currentSave.uItem++;
    playerItemData.sID = (ObscuredShort) sID;
    playerItemData.arrMod = new ItemModData[6];
    float num1 = UnityEngine.Random.Range(0.0f, 100f);
    for (int index = 0; index < 5; ++index)
    {
      if ((double) Info.fGradeRate[4 - index] >= (double) num1)
      {
        playerItemData.byGrade = (ObscuredByte) ((byte) (4 - index));
        break;
      }
    }
    if (bShop)
      playerItemData.byGrade = (ObscuredByte) ((byte) Mathf.Clamp((int) (byte) playerItemData.byGrade + Info.GetResearchFacInt(ResearchID.eMall), 0, 4));
    float num2 = Info.GetRebirthFac(RebirthID.eItemQuality) * 0.01f;
    switch ((byte) playerItemData.byGrade)
    {
      case 0:
        playerItemData.fPower = (ObscuredFloat) UnityEngine.Random.Range(0.7f, (float) (0.850000023841858 * (1.0 + (double) num2)));
        playerItemData.nMod = (ObscuredInt) UnityEngine.Random.Range(0, 2);
        break;
      case 1:
        playerItemData.fPower = (ObscuredFloat) UnityEngine.Random.Range(0.75f, (float) (0.899999976158142 * (1.0 + (double) num2)));
        playerItemData.nMod = (ObscuredInt) UnityEngine.Random.Range(1, 4);
        break;
      case 2:
        playerItemData.fPower = (ObscuredFloat) UnityEngine.Random.Range(0.8f, (float) (0.949999988079071 * (1.0 + (double) num2)));
        playerItemData.nMod = (ObscuredInt) UnityEngine.Random.Range(2, 5);
        nLv = Mathf.Max(nLv + 1, Mathf.RoundToInt((float) nLv * 1.1f));
        break;
      case 3:
        playerItemData.fPower = (ObscuredFloat) UnityEngine.Random.Range(0.9f, (float) (0.975000023841858 * (1.0 + (double) num2)));
        playerItemData.nMod = (ObscuredInt) UnityEngine.Random.Range(3, 7);
        nLv = Mathf.Max(nLv + 2, Mathf.RoundToInt((float) nLv * 1.2f));
        break;
      case 4:
        playerItemData.fPower = (ObscuredFloat) UnityEngine.Random.Range(0.95f, 1f + num2);
        playerItemData.nMod = (ObscuredInt) 6;
        nLv = Mathf.Max(nLv + 3, Mathf.RoundToInt((float) nLv * 1.3f));
        break;
    }
    playerItemData.nLv = (ObscuredInt) nLv;
    return playerItemData;
  }

  public static int GetItemPrice(PlayerItemData data)
  {
    return (int) ((double) Info.GetItemPriceByLv((int) data.nLv) * (1.0 + (double) (int) data.nMod * 0.200000002980232));
  }

  public static int GetItemPriceByLv(int nLv)
  {
    return 16 + nLv * 12;
  }

  public static float GetItemPower(int nLv)
  {
    if (!Info.dictItemPower.ContainsKey(nLv))
      Info.dictItemPower.Add(nLv, (float) ((double) (nLv * nLv) * (1.0 / 1000.0) + 0.0450000017881393 * (double) nLv + 0.150000005960464));
    return Info.dictItemPower[nLv];
  }

  public static float GetItemPower(int nLv, float fPow)
  {
    return Info.GetItemPower(nLv) * fPow;
  }

  public static float GetItemPower(int nLv, float fPow, float fPow2)
  {
    return Info.GetItemPower(nLv, fPow) * fPow2;
  }

  public static int GetStone(int nDay, int nDiff)
  {
    if (nDay > 1000)
      nDay = 1000;
    if (nDay < 100)
      return 0;
    return BData.GetStone(nDay).nStone[nDiff];
  }

  public static int GetRuby(int nWave, int nDiff)
  {
    if (nWave < 1)
      return 0;
    if (nWave > 1000)
      nWave = 1000;
    if (!Info.currentSave.bAfterEndless)
      nWave = Mathf.Min(150, nWave);
    return BData.GetRuby(nWave).nRuby[nDiff];
  }

  public static double GetMonHP(int nLv)
  {
    if (!Info.dictMonHP.ContainsKey(nLv))
    {
      double num = (double) nLv;
      if (Info.currentSave.bPreResearch)
      {
        if ((int) Info.currentSave.nDiff == 5)
          Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0005 + num * num * 0.005 + 0.1 * num + 0.1) * (nLv <= 50 ? 1.0 : Math.Pow(1.012 + num * 1E-06, (double) (nLv - 50))), 2));
        else if (Info.currentSave.bAfterDiffHpChange)
        {
          switch ((int) Info.currentSave.nDiff)
          {
            case 0:
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 9E-05 + num * num * 0.005 + 0.05 * num + 0.05) * (nLv <= 50 ? 1.0 : Math.Pow(1.0105 + num * 1E-06, (double) (nLv - 50))), 2));
              break;
            case 2:
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.00011 + num * num * 0.005 + 0.065 * num + 0.065) * (nLv <= 50 ? 1.0 : Math.Pow(1.0106 + num * 1E-06, (double) (nLv - 50))), 2));
              break;
            case 3:
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.00023 + num * num * 0.005 + 0.07 * num + 0.07) * (nLv <= 50 ? 1.0 : Math.Pow(1.0108 + num * 1E-06, (double) (nLv - 50))), 2));
              break;
            case 4:
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.00035 + num * num * 0.005 + 0.08 * num + 0.08) * (nLv <= 50 ? 1.0 : Math.Pow(1011.0 / 1000.0 + num * 1E-06, (double) (nLv - 50))), 2));
              break;
            default:
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 8E-05 + num * num * 0.005 + 0.05 * num + 0.05) * (nLv <= 50 ? 1.0 : Math.Pow(1.0104 + num * 1E-06, (double) (nLv - 50))), 2));
              break;
          }
        }
        else
          Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 8E-05 + num * num * 0.004 + 0.04 * num + 0.04) * (nLv <= 50 ? 1.0 : Math.Pow(1.0104 + num * 1E-06, (double) (nLv - 50))), 2));
      }
      else
      {
        switch ((int) Info.currentSave.nDiff)
        {
          case 0:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.00015 + num * num * 0.0045 + 0.045 * num + 0.05) * (nLv <= 50 ? 1.0 : Math.Pow(1.0104 + num * 1E-06, (double) (nLv - 50))), 2));
            break;
          case 2:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0003 + num * num * 0.005 + 0.06 * num + 0.06) * (nLv <= 50 ? 1.0 : Math.Pow(632.0 / 625.0 + num * 1E-06, (double) (nLv - 50))), 2));
            break;
          case 3:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0004 + num * num * 0.005 + 0.075 * num + 0.075) * (nLv <= 50 ? 1.0 : Math.Pow(1.0114 + num * 1E-06, (double) (nLv - 50))), 2));
            break;
          case 4:
            if (Info.currentSave.bAfterMonHpIncrease)
            {
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.00055 + num * num * 0.006 + 0.1 * num + 0.1) * (nLv <= 50 ? 1.0 : Math.Pow(1.012 + num * 1E-06, (double) (nLv - 50))), 2));
              break;
            }
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.00045 + num * num * 0.005 + 0.09 * num + 0.09) * (nLv <= 50 ? 1.0 : Math.Pow(1.0115 + num * 1E-06, (double) (nLv - 50))), 2));
            break;
          case 5:
            if (Info.currentSave.bAfterMonHpIncrease)
            {
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0007 + num * num * 0.006 + 0.11 * num + 0.11) * (nLv <= 50 ? 1.0 : Math.Pow(1.0123 + num * 1E-06, (double) (nLv - 50))), 0));
              break;
            }
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0006 + num * num * 0.005 + 0.1 * num + 0.1) * (nLv <= 50 ? 1.0 : Math.Pow(1.0122 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 6:
            if (Info.currentSave.bAfterMonHpIncrease)
            {
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.001 + num * num * 0.007 + 0.15 * num + 0.15) * (nLv <= 50 ? 1.0 : Math.Pow(1.0135 + num * 1E-06, (double) (nLv - 50))), 0));
              break;
            }
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0008 + num * num * 0.006 + 0.125 * num + 0.125) * (nLv <= 50 ? 1.0 : Math.Pow(1013.0 / 1000.0 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 7:
            if (Info.currentSave.bAfterMonHpIncrease)
            {
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0011 + num * num * 0.008 + 0.2 * num + 0.2) * (nLv <= 50 ? 1.0 : Math.Pow(1.014 + num * 1E-06, (double) (nLv - 50))), 0));
              break;
            }
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.001 + num * num * (3.0 / 400.0) + 0.15 * num + 0.15) * (nLv <= 50 ? 1.0 : Math.Pow(1.0135 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 8:
            if (Info.currentSave.bAfterMonHpIncrease)
            {
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0012 + num * num * 0.01 + 0.25 * num + 0.25) * (nLv <= 50 ? 1.0 : Math.Pow(203.0 / 200.0 + num * 1E-06, (double) (nLv - 50))), 0));
              break;
            }
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.001 + num * num * 0.009 + 0.175 * num + 0.175) * (nLv <= 50 ? 1.0 : Math.Pow(1.014 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 9:
            if (Info.currentSave.bAfterMonHpIncrease)
            {
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0014 + num * num * 0.012 + 0.3 * num + 0.3) * (nLv <= 50 ? 1.0 : Math.Pow(1.016 + num * 1E-06, (double) (nLv - 50))), 0));
              break;
            }
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0014 + num * num * 0.0105 + 0.2 * num + 0.2) * (nLv <= 50 ? 1.0 : Math.Pow(1.0145 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 10:
            if (Info.currentSave.bAfterMonHpIncrease)
            {
              Info.dictMonHP.Add(nLv, Math.Round((num * num * num * (1.0 / 625.0) + num * num * 0.014 + 0.35 * num + 0.35) * (nLv <= 50 ? 1.0 : Math.Pow(1017.0 / 1000.0 + num * 1E-06, (double) (nLv - 50))), 0));
              break;
            }
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * (1.0 / 625.0) + num * num * 0.012 + 0.225 * num + 0.225) * (nLv <= 50 ? 1.0 : Math.Pow(203.0 / 200.0 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 11:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0019 + num * num * 0.017 + 0.4 * num + 0.4) * (nLv <= 50 ? 1.0 : Math.Pow(1.018 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 12:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0022 + num * num * 0.02 + 0.5 * num + 0.5) * (nLv <= 50 ? 1.0 : Math.Pow(1.02 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 13:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0026 + num * num * 0.023 + 0.6 * num + 0.6) * (nLv <= 50 ? 1.0 : Math.Pow(1023.0 / 1000.0 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 14:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.003 + num * num * 0.026 + 0.7 * num + 0.7) * (nLv <= 50 ? 1.0 : Math.Pow(1.026 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          case 15:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.0035 + num * num * 0.029 + 0.8 * num + 0.8) * (nLv <= 50 ? 1.0 : Math.Pow(1.029 + num * 1E-06, (double) (nLv - 50))), 0));
            break;
          default:
            Info.dictMonHP.Add(nLv, Math.Round((num * num * num * 0.00012 + num * num * 0.004 + 0.04 * num + 0.04) * (nLv <= 50 ? 1.0 : Math.Pow(1.0103 + num * 1E-06, (double) (nLv - 50))), 2));
            break;
        }
      }
    }
    return Info.dictMonHP[nLv];
  }

  public static float GetMonDmg(int nLv)
  {
    if (!Info.dictMonDmg.ContainsKey(nLv))
    {
      if (Info.currentSave.bNewBalance)
        Info.dictMonDmg.Add(nLv, (float) ((double) (nLv * nLv) * 0.000199999994947575 + (double) nLv * 0.0500000007450581 - 0.0500000007450581));
      else
        Info.dictMonDmg.Add(nLv, (float) ((double) (nLv * nLv) * 0.000600000028498471 + (double) nLv * 0.0500000007450581 - 0.0500000007450581));
    }
    return Info.dictMonDmg[nLv];
  }

  public static Color GetGradeColor(byte byGrade)
  {
    return Info.clGrade[(int) byGrade];
  }

  public static string GetGradeString(byte byGrade, bool bColor = false)
  {
    if (!bColor)
      return BData.GetString("UI00" + (object) (86 + (int) byGrade));
    return Info.strClGrade[(int) byGrade] + BData.GetString("UI00" + (object) (86 + (int) byGrade)) + "</color>";
  }

  public static bool CheckBattleItem(long uid)
  {
    return Info.dictBattleItem.ContainsKey(uid);
  }

  public static BattleItemData GetBattleItem(long uid)
  {
    return Info.dictBattleItem[uid];
  }

  public static void RefreshBattleItemData()
  {
    Info.dictBattleItem.Clear();
    foreach (KeyValuePair<ObscuredLong, PlayerItemData> keyValuePair in Info.currentSave.dictItem)
      Info.RefreshBattleItemData(keyValuePair.Value);
    for (int index = 0; index < Info.currentSave.listShopItem.Count; ++index)
      Info.RefreshBattleItemData(Info.currentSave.listShopItem[index]);
  }

  public static int CalcMasteryLv(int nLv)
  {
    return Mathf.CeilToInt((float) ((double) nLv * (1.0 - (double) Info.GetResearchFac(ResearchID.eTraining) * 0.00999999977648258) * (1.0 - (double) Info.GetRebirthFac(RebirthID.eMastery) * 0.00999999977648258)));
  }

  public static void RefreshBattleItemData(PlayerItemData pData)
  {
    ItemData weapon = BData.GetWeapon((short) pData.sID);
    BattleItemData battleItemData = new BattleItemData();
    battleItemData.UID = pData.UID;
    battleItemData.sID = pData.sID;
    battleItemData.nMod = pData.nMod;
    battleItemData.nLv = pData.nLv;
    battleItemData.nMastery = Info.CalcMasteryLv((int) pData.nLv);
    battleItemData.fPower = pData.fPower;
    battleItemData.arrMod = pData.arrMod;
    battleItemData.byGrade = pData.byGrade;
    battleItemData.eWeapon = weapon.eWeapon;
    battleItemData.eMastery = weapon.eMastery;
    float[] numArray = new float[64];
    for (int index = 0; index < numArray.Length; ++index)
      numArray[index] = 0.0f;
    int num1 = 0;
    for (int index = 0; index < pData.arrMod.Length; ++index)
    {
      if (pData.arrMod[index] != null && pData.arrMod[index].eMod != ModType.eNone)
      {
        numArray[(int) pData.arrMod[index].eMod] += pData.arrMod[index].fFactor;
        num1 += (int) pData.arrMod[index].nModLevel;
      }
    }
    battleItemData.fDmg = Info.GetItemPower((int) pData.nLv, weapon.fDmg, (float) pData.fPower) * (float) (1.0 + (double) numArray[1] * 0.00999999977648258);
    if (Info.CheckResearch(ResearchID.eRelic))
    {
      if (Info.currentSave.bAfterRelicChange)
        battleItemData.fDmg *= 1f + Mathf.Min(Info.GetResearchFac(ResearchID.eRelic) * 0.01f * (float) (int) battleItemData.nLv, 1f);
      else
        battleItemData.fDmg *= (float) (1.0 + 1.0 / 500.0 * (double) (int) battleItemData.nLv);
    }
    battleItemData.fDmg *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eModifySum) * 0.00999999977648258 * (double) num1);
    if ((int) (byte) battleItemData.byGrade == 4)
      battleItemData.fDmg *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eLegendary) * 0.00999999977648258);
    battleItemData.fDmg *= (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eWeaponDmg) * 0.00999999977648258);
    if (battleItemData.eWeapon == WeaponType.eWand || battleItemData.eWeapon == WeaponType.eStaff || battleItemData.eWeapon == WeaponType.eMonster)
      battleItemData.fDmg *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eEmpower) * 0.00999999977648258);
    else
      battleItemData.fDmg *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eSteel) * 0.00999999977648258);
    battleItemData.fDmg *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eBattleTraining) * 0.00999999977648258);
    battleItemData.fRate = weapon.fRate / (float) (1.0 + (double) numArray[4] * 0.00999999977648258 + (double) Info.GetRebirthFac(RebirthID.eAttackSpd) * 0.00999999977648258);
    battleItemData.fReload = weapon.fReload / (float) (1.0 + (double) numArray[2] * 0.00999999977648258 + (double) Info.GetRebirthFac(RebirthID.eReloadSpd) * 0.00999999977648258);
    battleItemData.fvsArmor = (float) ((double) weapon.fvsArmor * (1.0 + (double) numArray[7] * 0.00999999977648258) * (1.0 + (double) Info.GetElementalFac(ElementalID.eWaterAmrDmg, 0) * 0.00999999977648258));
    battleItemData.fvsMagic = (float) ((double) weapon.fvsMagic * (1.0 + (double) numArray[8] * 0.00999999977648258) * (1.0 + (double) Info.GetElementalFac(ElementalID.eLightAntiMagic, 0) * 0.00999999977648258));
    battleItemData.fAcc = weapon.fAcc * (float) (1.0 + (double) numArray[0] * 0.00999999977648258);
    battleItemData.fSpd = weapon.fSpd * (float) (1.0 + (double) numArray[9] * 0.00999999977648258);
    battleItemData.fRange = weapon.fRange;
    battleItemData.nSpread = weapon.nSpread;
    battleItemData.fCool = (float) (1.0 + (double) numArray[5] * 0.00999999977648258);
    battleItemData.fCri = numArray[6] + Info.GetRebirthFac(RebirthID.eCriRate);
    battleItemData.fCriDmg = (float) (2.0 + (double) Info.GetRebirthFac(RebirthID.eCriDmg) * 0.00999999977648258);
    battleItemData.nAmmo = (int) ((double) weapon.nAmmo * (1.0 + (double) numArray[3] * 0.00999999977648258)) + (weapon.eWeapon == WeaponType.eBow ? 0 : Info.GetResearchFacInt(ResearchID.eSupply));
    battleItemData.nPen = weapon.nPen;
    float num2 = battleItemData.nAmmo != 1 ? (float) battleItemData.nAmmo * battleItemData.fRate + battleItemData.fReload : ((double) battleItemData.fRate <= (double) battleItemData.fReload ? battleItemData.fReload : battleItemData.fRate);
    battleItemData.fDPS = (float) ((double) battleItemData.fDmg * (double) battleItemData.nAmmo / (double) num2 * (1.0 + (double) battleItemData.fCri * 0.00999999977648258)) * (float) battleItemData.nSpread;
    if (Info.dictBattleItem.ContainsKey((long) pData.UID))
      Info.dictBattleItem.Remove((long) pData.UID);
    Info.dictBattleItem.Add((long) pData.UID, battleItemData);
  }

  public static int GetModCost(long uid, int nSlot)
  {
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(uid);
    int num = 0;
    if (nSlot != -1 && playerWeapon.arrMod[nSlot] != null)
      num = (int) playerWeapon.arrMod[nSlot].nModLevel;
    return Mathf.RoundToInt((float) (((double) Mathf.Pow((float) num, (float) ((int) (byte) playerWeapon.byGrade + 1)) * 8.0 + 100.0) * (1.0 - (double) Info.GetAcvReward(AcvRewardType.eModDC) * 0.00999999977648258) * (1.0 - (double) Info.GetPartySkillFac(SkillKey.eMiner) * 0.00999999977648258) * (1.0 - (double) Info.GetResearchFac(ResearchID.eMine) * 0.00999999977648258)));
  }

  public static int GetEnchantCost(long uid)
  {
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(uid);
    return Mathf.RoundToInt((float) ((double) Info.GetItemPrice(playerWeapon) * (1.0 + (double) ((float) ((int) playerWeapon.nLv * (int) playerWeapon.nLv) * 0.5f) / (50000.0 + (double) ((int) playerWeapon.nLv * (int) playerWeapon.nLv) * 0.150000005960464)) * (1.0 + (double) (byte) playerWeapon.byGrade * 0.25) * (1.0 - (double) Info.GetAcvReward(AcvRewardType.eEnchantDC) * 0.00999999977648258) * (1.0 - (double) Info.GetPartySkillFac(SkillKey.eMiner) * 0.00999999977648258) * (1.0 - (double) Info.GetResearchFac(ResearchID.eMine) * 0.00999999977648258)));
  }

  public static int GetSellPrice(int nLv, byte byGrade)
  {
    return Mathf.RoundToInt((float) ((double) Info.GetItemPriceByLv(nLv) * (1.0 + (double) Info.GetRebirthFac(RebirthID.eSellPrice) * 0.00999999977648258) * (1.0 + (double) Info.GetResearchFac(ResearchID.eAuction) * 0.00999999977648258 * (double) byGrade)));
  }

  public static int GetItemPurchasePrice(int nLv, byte byGrade)
  {
    return Mathf.RoundToInt((float) (Info.GetItemPriceByLv(nLv) * 8 * (1 + (int) byGrade)));
  }

  public static ItemModData GetRandomMod(long uid, int nSlot)
  {
    return Info.GetRandomMod(Info.GetPlayerWeapon(uid), nSlot, true);
  }

  public static ItemModData GetRandomMod(PlayerItemData pData, int nSlot = -1, bool bSmith = false)
  {
    ItemData weapon = BData.GetWeapon((short) pData.sID);
    List<ModType> modTypeList = new List<ModType>();
    for (int index = 0; index < 64; ++index)
    {
      ModData mod = BData.GetMod((ModType) index);
      if (mod.listTarget.Contains(weapon.eItem) && mod.bUse)
        modTypeList.Add(mod.eID);
    }
    if (weapon.eWeapon == WeaponType.eBow)
      modTypeList.Remove(ModType.eAmmo);
    ModType modType = modTypeList[UnityEngine.Random.Range(0, modTypeList.Count)];
    ItemModData itemModData1 = new ItemModData();
    itemModData1.eMod = modType;
    itemModData1.nModLevel = (ObscuredInt) 1;
    itemModData1.fBonus = (ObscuredFloat) 1f;
    if (bSmith)
    {
      ItemModData itemModData2 = itemModData1;
      ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) itemModData2.fBonus + Info.GetPartySkillFac(SkillKey.eBlacksmith) * 0.01f);
      itemModData2.fBonus = obscuredFloat;
      int num1 = 0;
      if (nSlot != -1 && pData.arrMod[nSlot] != null)
      {
        num1 = (int) pData.arrMod[nSlot].nModLevel;
        modTypeList.Remove(pData.arrMod[nSlot].eMod);
        itemModData1.eMod = modTypeList[UnityEngine.Random.Range(0, modTypeList.Count)];
      }
      float num2 = UnityEngine.Random.Range(0.0f, 100f);
      int num3 = 10 + Info.GetResearchFacInt(ResearchID.eForge) + Info.GetRebirthFacToInt(RebirthID.eModLevel);
      float num4 = (float) (100.0 + (double) (Info.GetResearchFacInt(ResearchID.eForge) * 5) - (double) num1 * 8.0);
      if (num1 < num3 && (double) num4 <= 10.0)
        num4 = 10f;
      float num5 = (float) (115.0 - (double) num1 * 5.0);
      if (Info.CheckRebirth(RebirthID.ePreventModFail))
      {
        num5 = 120f;
        if ((double) num4 < 30.0)
          num4 = 30f;
      }
      if (num1 >= num3)
        num4 = 0.0f;
      if (num1 < num3 && (double) num5 < 50.0)
        num5 = 50f;
      itemModData1.nModLevel = (double) num2 >= (double) num4 ? ((double) num2 <= (double) num5 ? (ObscuredInt) num1 : (ObscuredInt) (num1 - 1)) : (ObscuredInt) (num1 + 1);
    }
    else
    {
      for (int index = 0; index < 9; ++index)
      {
        if (UnityEngine.Random.Range(0, 100) < 20)
          ++itemModData1.nModLevel;
      }
      itemModData1.nModLevel = (ObscuredInt) Mathf.Clamp((int) itemModData1.nModLevel, 1, 10);
      ItemModData itemModData2 = itemModData1;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) itemModData2.nModLevel + Info.GetResearchFacInt(ResearchID.eForge));
      itemModData2.nModLevel = obscuredInt;
    }
    return itemModData1;
  }

  public static void CheckAcvSurvive()
  {
    if ((int) Info.currentSave.nDay >= 10)
      Info.CheckAchievement(AchievementType.eSurvive10);
    if ((int) Info.currentSave.nDay >= 20)
      Info.CheckAchievement(AchievementType.eSurvive20);
    if ((int) Info.currentSave.nDay >= 30)
      Info.CheckAchievement(AchievementType.eSurvive30);
    if ((int) Info.currentSave.nDay >= 50)
      Info.CheckAchievement(AchievementType.eSurvive50);
    if ((int) Info.currentSave.nDay >= 75)
      Info.CheckAchievement(AchievementType.eSurvive75);
    if ((int) Info.currentSave.nDay >= 100)
      Info.CheckAchievement(AchievementType.eSurvive100);
    if ((int) Info.currentSave.nDay >= 150)
      Info.CheckAchievement(AchievementType.eSurvive150);
    if ((int) Info.currentSave.nDay >= 200)
      Info.CheckAchievement(AchievementType.eSurvive200);
    if ((int) Info.currentSave.nDay >= 300)
      Info.CheckAchievement(AchievementType.eSurvive300);
    if ((int) Info.currentSave.nDay >= 500)
      Info.CheckAchievement(AchievementType.eSurvive500);
    if ((int) Info.currentSave.nDiff >= 2)
    {
      if ((int) Info.currentSave.nDay >= 10)
        Info.CheckAchievement(AchievementType.eSurviveHard10);
      if ((int) Info.currentSave.nDay >= 20)
        Info.CheckAchievement(AchievementType.eSurviveHard20);
      if ((int) Info.currentSave.nDay >= 30)
        Info.CheckAchievement(AchievementType.eSurviveHard30);
      if ((int) Info.currentSave.nDay >= 50)
        Info.CheckAchievement(AchievementType.eSurviveHard50);
      if ((int) Info.currentSave.nDay >= 75)
        Info.CheckAchievement(AchievementType.eSurviveHard75);
      if ((int) Info.currentSave.nDay >= 100)
        Info.CheckAchievement(AchievementType.eSurviveHard100);
      if ((int) Info.currentSave.nDay >= 150)
        Info.CheckAchievement(AchievementType.eSurviveHard150);
      if ((int) Info.currentSave.nDay >= 200)
        Info.CheckAchievement(AchievementType.eSurviveHard200);
      if ((int) Info.currentSave.nDay >= 300)
        Info.CheckAchievement(AchievementType.eSurviveHard300);
      if ((int) Info.currentSave.nDay >= 500)
        Info.CheckAchievement(AchievementType.eSurviveHard500);
    }
    if ((int) Info.currentSave.nDiff >= 4)
    {
      if ((int) Info.currentSave.nDay >= 10)
        Info.CheckAchievement(AchievementType.eSurviveEnd10);
      if ((int) Info.currentSave.nDay >= 25)
        Info.CheckAchievement(AchievementType.eSurviveEnd25);
      if ((int) Info.currentSave.nDay >= 50)
        Info.CheckAchievement(AchievementType.eSurviveEnd50);
      if ((int) Info.currentSave.nDay >= 100)
        Info.CheckAchievement(AchievementType.eSurviveEnd100);
      if ((int) Info.currentSave.nDay >= 200)
        Info.CheckAchievement(AchievementType.eSurviveEnd200);
      if ((int) Info.currentSave.nDay >= 300)
        Info.CheckAchievement(AchievementType.eSurviveEnd300);
      if ((int) Info.currentSave.nDay >= 500)
        Info.CheckAchievement(AchievementType.eSurviveEnd500);
      if ((int) Info.currentSave.nDay >= 1000)
        Info.CheckAchievement(AchievementType.eSurviveEnd1000);
    }
    if ((int) Info.currentSave.nDiff >= 5)
    {
      if ((int) Info.currentSave.nDay >= 10)
        Info.CheckAchievement(AchievementType.eSurviveGod10);
      if ((int) Info.currentSave.nDay >= 25)
        Info.CheckAchievement(AchievementType.eSurviveGod25);
      if ((int) Info.currentSave.nDay >= 50)
        Info.CheckAchievement(AchievementType.eSurviveGod50);
      if ((int) Info.currentSave.nDay >= 100)
        Info.CheckAchievement(AchievementType.eSurviveGod100);
      if ((int) Info.currentSave.nDay >= 200)
        Info.CheckAchievement(AchievementType.eSurviveGod200);
      if ((int) Info.currentSave.nDay >= 300)
        Info.CheckAchievement(AchievementType.eSurviveGod300);
      if ((int) Info.currentSave.nDay >= 500)
        Info.CheckAchievement(AchievementType.eSurviveGod500);
      if ((int) Info.currentSave.nDay >= 1000)
        Info.CheckAchievement(AchievementType.eSurviveGod1000);
    }
    Info.TrySaveAchievement();
    Info.TrySaveRebirth();
  }

  public static bool IsAchievement(AchievementType eID)
  {
    return Info.achievement.listAcv.Contains(eID);
  }

  public static void CheckAchievement(AchievementType eID)
  {
    if (Info.achievement.listAcv.Contains(eID))
      return;
    Info.achievement.listAcv.Add(eID);
    Info.listCheck.Add(eID);
    SavedData currentSave = Info.currentSave;
    string str = currentSave.strSummary + "\n" + BData.GetString("UI0124").Replace("[1]", BData.GetString(BData.GetAchievement(eID).strName));
    currentSave.strSummary = str;
    AchievementData achievement = BData.GetAchievement(eID);
    if (achievement.eReward == AcvRewardType.eAccessory && !Info.CheckAchieveAcc((short) achievement.nReward))
    {
      Info.SetAchieveAcc((short) achievement.nReward);
      PlayerAccData newAcc = Info.GetNewAcc((short) achievement.nReward);
      Info.listGetAcc.Add(newAcc);
      Info.rebirth.dictAcc.Add(newAcc.UID, newAcc);
    }
    Info.bAcvChanged = true;
  }

  public static void TrySaveAchievement()
  {
    if (!Info.bAcvChanged)
      return;
    Info.RefreshAcvReward();
    SaveManager.SaveAchievement();
    Info.bAcvChanged = false;
    if (!((UnityEngine.Object) PageLobby.obj != (UnityEngine.Object) null))
      return;
    PageLobby.obj.RefreshAlarm();
  }

  public static void TrySaveRebirth()
  {
    if (!Info.bRebirthChanged)
      return;
    SaveManager.SaveRebirth();
    Info.bRebirthChanged = false;
  }

  public static void RefreshAcvReward()
  {
    Info.dictAcvReward.Clear();
    for (int index = 0; index < 10; ++index)
      Info.dictAcvReward.Add((AcvRewardType) index, (ObscuredInt) 0);
    for (int index = 0; index < Info.achievement.listAcv.Count; ++index)
    {
      AchievementData achievement = BData.GetAchievement(Info.achievement.listAcv[index]);
      Dictionary<AcvRewardType, ObscuredInt> dictAcvReward;
      AcvRewardType eReward;
      (dictAcvReward = Info.dictAcvReward)[eReward = achievement.eReward] = (ObscuredInt) ((int) dictAcvReward[eReward] + achievement.nReward);
    }
  }

  public static int GetAcvReward(AcvRewardType eID)
  {
    return (int) Info.dictAcvReward[eID];
  }

  public static string GetAcvRewardDesc(AcvRewardType eID, int nReward)
  {
    if (eID != AcvRewardType.eAccessory)
      return "(" + BData.GetString(eID != AcvRewardType.ePotential ? "UI0" + (object) (111 + eID) : "UI0242").Replace("[1]", nReward.ToString()) + ")";
    AccData accessory = BData.GetAccessory((short) nReward);
    return "\n<" + BData.GetString("UI0236") + ">\n" + BData.GetString(accessory.strName) + "\n" + Info.GetGradeString((byte) accessory.nGrade, true) + Info.GetAccDesc(accessory.sID, 0);
  }

  public static void CheckOneShotAcv(int nKill)
  {
    if (nKill >= 7)
      Info.CheckAchievement(AchievementType.eOneShot25);
    else if (nKill >= 5)
    {
      Info.CheckAchievement(AchievementType.eOneShot10);
    }
    else
    {
      if (nKill < 3)
        return;
      Info.CheckAchievement(AchievementType.eOneShot5);
    }
  }

  public static int GetNeedExp(int nPos)
  {
    return Info.GetNeedExpByLv((int) Info.GetPlayerMon(nPos).nLv);
  }

  public static int GetNeedExpByLv(int nLv)
  {
    return 50 + Mathf.RoundToInt((float) nLv * 2.6f);
  }

  public static bool CheckResearch(ResearchID eID)
  {
    return Info.currentSave.listResearch.Contains(eID);
  }

  public static bool LearnableResearch(ResearchID eID)
  {
    ResearchData research = BData.GetResearch(eID);
    if (research.listPre.Count == 0)
      return true;
    for (int index = 0; index < research.listPre.Count; ++index)
    {
      if (!Info.CheckResearch(research.listPre[index]))
        return false;
    }
    return true;
  }

  public static void RefreshResearchPower()
  {
    Info.fResearchPower = (ObscuredFloat) Info.GetDungeonFactor(DungeonType.eLab, -1);
  }

  public static float GetResearchFac(ResearchID eID)
  {
    if (!Info.CheckResearch(eID))
      return 0.0f;
    return BData.GetResearch(eID).fFactor;
  }

  public static int GetResearchFacInt(ResearchID eID)
  {
    return Mathf.RoundToInt(Info.GetResearchFac(eID));
  }

  public static bool CheckRebirth(RebirthID eID)
  {
    return Info.rebirth.dictRebirth.ContainsKey(eID);
  }

  public static int GetRebirth(RebirthID eID)
  {
    if (!Info.rebirth.dictRebirth.ContainsKey(eID))
      return 0;
    return (int) Info.rebirth.dictRebirth[eID];
  }

  public static float GetRebirthFac(RebirthID eID)
  {
    int rebirth = Info.GetRebirth(eID);
    if (rebirth == 0)
      return 0.0f;
    return Info.GetRebirthFac(eID, rebirth);
  }

  public static float GetRebirthFac(RebirthID eID, int nLv)
  {
    return (float) ((double) BData.GetRebirth(eID).fBase + (double) BData.GetRebirth(eID).fGrow * (double) nLv + (double) BData.GetRebirth(eID).fFactorial * (double) (nLv * (nLv + 1)) / 2.0);
  }

  public static int GetRebirthFacToInt(RebirthID eID)
  {
    return Mathf.RoundToInt(Info.GetRebirthFac(eID));
  }

  public static int GetCostRebirth(RebirthID eID)
  {
    return Info.GetCostRebirth(eID, Info.GetRebirth(eID));
  }

  public static int GetCostRebirth(RebirthID eID, int nLv)
  {
    RebirthData rebirth = BData.GetRebirth(eID);
    return rebirth.nCost + rebirth.nCostAdd * nLv + rebirth.nCostGrow * (nLv * (nLv + 1)) / 2;
  }

  public static void UpgRebirth(RebirthID eID, int nPlus = 1)
  {
    if (!Info.rebirth.dictRebirth.ContainsKey(eID))
      Info.rebirth.dictRebirth.Add(eID, (ObscuredInt) 0);
    Info.rebirth.dictRebirth[eID] = (ObscuredInt) (Info.GetRebirth(eID) + nPlus);
  }

  public static bool CheckShop(ShopID eID)
  {
    return Info.rebirth.listPurchase.Contains(eID);
  }

  public static float GetDamage(Monster pMon)
  {
    if (!Info.dictBattleItem.ContainsKey(pMon.nEquip))
      return 0.0f;
    return Info.GetDamage(pMon, (Enemy) null, Info.GetBattleItem(pMon.nEquip));
  }

  public static float GetDamage(Monster pMon, Enemy em, BattleItemData bData)
  {
    if (bData == null)
      return 0.0f;
    float num = bData.fDmg * (float) Info.fAtkBonus;
    if ((UnityEngine.Object) pMon != (UnityEngine.Object) null)
      num *= pMon.fFixAtkBonus;
    if ((UnityEngine.Object) em != (UnityEngine.Object) null)
      num = em.eArmor != ArmorType.eArmored ? (em.eArmor != ArmorType.eMagical ? num * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eSlaughterer) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eDarkNormalDmg, 0) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eNormalDmgParty) * 0.00999999977648258) : num * (bData.fvsMagic * (!((UnityEngine.Object) pMon != (UnityEngine.Object) null) ? 1f : (float) ((1.0 + (double) PageBattle.obj.GetSkillFac(pMon.nPos, SkillKey.eMagicIgnore) * 0.00999999977648258) * (1.0 + (double) Info.GetAccModFac(pMon.nPos, ModType.eVsM) * 0.00999999977648258)))) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eMagic) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eMagicDmgParty) * 0.00999999977648258)) : num * (bData.fvsArmor * (!((UnityEngine.Object) pMon != (UnityEngine.Object) null) ? 1f : (float) ((1.0 + (double) PageBattle.obj.GetSkillFac(pMon.nPos, SkillKey.eArmorIgnore) * 0.00999999977648258) * (1.0 + (double) Info.GetAccModFac(pMon.nPos, ModType.eVsA) * 0.00999999977648258)))) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eArmor) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eArmorDmgParty) * 0.00999999977648258);
    bool flag = bData.eWeapon != WeaponType.eWand && bData.eWeapon != WeaponType.eStaff && bData.eWeapon != WeaponType.eMonster;
    if (PageBattle.CheckMutation(MutateType.eBlock) && flag)
      num *= (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.eBlock) * 0.00999999977648258);
    if (PageBattle.CheckMutation(MutateType.eBarrier) && !flag)
      num *= (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.eBarrier) * 0.00999999977648258);
    return num;
  }

  public static void Rebirth(SavedData savedata, short sNewChar, int nNewDiff, bool bMain, List<PlayerItemData> listInherit)
  {
    Info.Rebirth(nNewDiff, (int) savedata.nDiff, sNewChar, savedata.bySlot, bMain, (int) savedata.nDay, savedata.uRebirthID, listInherit, (int) savedata.nMaxEndless, savedata.listResearch.Contains(ResearchID.eElementalExp));
  }

  public static void Rebirth(int nNewDiff, int nDiff, short sID, byte bySlot, bool bMain, int nDay, long uID, List<PlayerItemData> listInherit, int nMaxEndless = 0, bool bElmAddExp = false)
  {
    int stone = Info.GetStone(nDay, nDiff);
    Info.RefreshAcvReward();
    Info.currentSave = new SavedData();
    Info.currentSave.bAfterAmulet = true;
    Info.currentSave.bAfterEndless = true;
    Info.currentSave.bBatched = true;
    Info.currentSave.bAfterRebirth = true;
    Info.currentSave.bDeleted = false;
    Info.currentSave.nDiff = (ObscuredInt) nNewDiff;
    Info.currentSave.bySlot = bySlot;
    Info.currentSave.bNewBalance = true;
    Info.currentSave.bAfterRelicChange = true;
    Info.currentSave.bAfterDiffHpChange = true;
    Info.currentSave.bAfterMonHpIncrease = true;
    Info.currentSave.bNamelessCriFix = true;
    Info.currentSave.bPreResearch = false;
    SavedData currentSave = Info.currentSave;
    ObscuredLong obscuredLong1 = (ObscuredLong) ((long) currentSave.nNewGold + (long) (Info.GetAcvReward(AcvRewardType.eStartGold) + Mathf.RoundToInt(Info.GetRebirthFac(RebirthID.eStartGold))));
    currentSave.nNewGold = obscuredLong1;
    Info.HireMonster(sID);
    for (int index = 0; index < Info.GetAcvReward(AcvRewardType.ePotential); ++index)
      Info.LearnSkill(0, SkillKey.ePotential);
    if (Info.GetAcvReward(AcvRewardType.eActiveSkill) > 0)
    {
      for (int index1 = 0; index1 < BData.GetMonster((short) Info.currentSave.arrPlayerMon[0].sID).listLearnSkill.Count; ++index1)
      {
        if (BData.GetSkill(BData.GetMonster((short) Info.currentSave.arrPlayerMon[0].sID).listLearnSkill[index1]).eType == SkillType.eActive)
        {
          for (int index2 = 0; index2 < Info.GetAcvReward(AcvRewardType.eActiveSkill); ++index2)
            Info.LearnSkill(0, BData.GetMonster((short) Info.currentSave.arrPlayerMon[0].sID).listLearnSkill[index1]);
          break;
        }
      }
    }
    for (int index = 0; index < Info.GetAcvReward(AcvRewardType.eRandomSkill); ++index)
    {
      List<SkillKey> learnableSkill = Info.GetLearnableSkill(0);
      Info.LearnSkill(0, learnableSkill[UnityEngine.Random.Range(0, learnableSkill.Count)]);
    }
    Info.RefreshHireMonster();
    Info.HireMonster(Info.currentSave.pHireMonster);
    Info.OnAutoAccEquip();
    Info.RefreshAccMod();
    Info.RefreshDungeonHP();
    Info.RefreshResearchPower();
    Info.RefreshPartySkill();
    Info.currentSave.fDunCurHP = Info.fDunMaxHP;
    Info.eBattle = BattleType.eSurvial;
    Info.currentSave.uRebirthID = (long) Info.rebirth.uRebirthID++;
    UIMgr.PlaySound("CharSel", false);
    if (bMain)
    {
      for (int index = 0; index < listInherit.Count; ++index)
      {
        listInherit[index].UID = (ObscuredLong) Info.currentSave.uItem++;
        listInherit[index].nLv = (ObscuredInt) (1 + Info.GetRebirthFacToInt(RebirthID.eInheritLevel));
        listInherit[index].bProtected = (ObscuredBool) true;
        Info.currentSave.dictItem.Add(listInherit[index].UID, listInherit[index]);
      }
      Info.RefreshBattleItemData();
      Info.OnAutoEquip();
      int num1 = Info.GetRuby(nMaxEndless, nDiff);
      if (nDay < 100)
        num1 = 0;
      else
        ++Info.rebirth.nRebirth;
      SavedRebirth rebirth1 = Info.rebirth;
      ObscuredLong obscuredLong2 = (ObscuredLong) ((long) rebirth1.nNewStone + (long) stone);
      rebirth1.nNewStone = obscuredLong2;
      SavedRebirth rebirth2 = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth2.nRuby + num1);
      rebirth2.nRuby = obscuredInt;
      Info.rebirth.listRebirthID.Add((ObscuredLong) uID);
      if (!Info.rebirth.dictRebirthHistory.ContainsKey((ObscuredInt) nDiff))
        Info.rebirth.dictRebirthHistory.Add((ObscuredInt) nDiff, new List<ObscuredInt>());
      Info.rebirth.dictRebirthHistory[(ObscuredInt) nDiff].Add((ObscuredInt) nDay);
      int num2 = (nDiff >= 2 ? nDiff * nDay : nDay) + nMaxEndless * 2 + Info.GetTrialClear(uID) * 10;
      if (bElmAddExp)
        num2 *= 2;
      Info.AddElementalExp((int) Info.rebirth.nEquippedElemental, (long) num2);
      if ((int) Info.rebirth.nEquippedElemental != 1 && Info.CheckElementalTrait(ElementalID.eFireSeed))
        Info.AddElementalExp(1, (long) (num2 / 2));
      if ((int) Info.rebirth.nEquippedElemental != 2 && Info.CheckElementalTrait(ElementalID.eWaterSeed))
        Info.AddElementalExp(2, (long) (num2 / 2));
      if ((int) Info.rebirth.nEquippedElemental != 3 && Info.CheckElementalTrait(ElementalID.eNatureSeed))
        Info.AddElementalExp(3, (long) (num2 / 2));
      if ((int) Info.rebirth.nEquippedElemental != 4 && Info.CheckElementalTrait(ElementalID.eLightSeed))
        Info.AddElementalExp(4, (long) (num2 / 2));
      if ((int) Info.rebirth.nEquippedElemental != 5 && Info.CheckElementalTrait(ElementalID.eDarkSeed))
        Info.AddElementalExp(5, (long) (num2 / 2));
      Info.rebirth.dictTrialClear.Remove((ObscuredLong) uID);
      SaveManager.Save(bySlot);
      GPGSMgr.single.CheckAchievementRebirth();
      SaveManager.SaveRebirth();
      Info.nNewStone = stone;
      Info.nNewRuby = num1;
      UIMgr.LoadLevel("Main", 5f, 2f, Color.white);
    }
    else
    {
      SaveManager.Save(bySlot);
      SaveManager.SaveRebirth();
      UIMgr.LoadLevel("Battle", 2f, 1f, Color.black);
    }
  }

  public static void CheckLevelAchievement()
  {
    if ((int) Info.GetPlayerMon(0).nLv < 20)
      return;
    switch ((short) Info.GetPlayerMon(0).sID)
    {
      case 0:
        Info.CheckAchievement(AchievementType.eSkeleton);
        break;
      case 1:
        Info.CheckAchievement(AchievementType.eGoblin);
        break;
      case 2:
        Info.CheckAchievement(AchievementType.eOgre);
        break;
      case 3:
        Info.CheckAchievement(AchievementType.eOrc);
        break;
      case 4:
        Info.CheckAchievement(AchievementType.eSlime);
        break;
      case 5:
        Info.CheckAchievement(AchievementType.eWraith);
        break;
      case 6:
        Info.CheckAchievement(AchievementType.eSnake);
        break;
      case 7:
        Info.CheckAchievement(AchievementType.eSword);
        break;
      case 8:
        Info.CheckAchievement(AchievementType.eNecromancer);
        break;
      case 9:
        Info.CheckAchievement(AchievementType.eMagicalGirl);
        break;
      case 10:
        if ((int) Info.GetPlayerMon(0).nLv >= 200)
        {
          Info.CheckAchievement(AchievementType.eDarkKnight);
          break;
        }
        break;
    }
    Info.TrySaveAchievement();
  }

  public static float GetMuation1(MutateType eType, int nDay)
  {
    MutationData mutate = BData.GetMutate(eType);
    if ((double) mutate.fGrow1 < 0.0)
      return Mathf.Max(mutate.fMax1, mutate.fFac1 + mutate.fGrow1 * (float) nDay);
    return Mathf.Min(mutate.fMax1, mutate.fFac1 + mutate.fGrow1 * (float) nDay);
  }

  public static float GetMuation2(MutateType eType, int nDay)
  {
    MutationData mutate = BData.GetMutate(eType);
    if ((double) mutate.fGrow1 < 0.0)
      return Mathf.Max(mutate.fMax2, mutate.fFac2 + mutate.fGrow2 * (float) nDay);
    return Mathf.Min(mutate.fMax2, mutate.fFac2 + mutate.fGrow2 * (float) nDay);
  }

  public static string GetMutationDesc(MutateType eType, int nDay)
  {
    return BData.GetString(BData.GetMutate(eType).strDesc).Replace("[1]", Info.GetMuation1(eType, nDay).ToString()).Replace("[2]", Info.GetMuation2(eType, nDay).ToString());
  }

  public static string GetMutationDescCustom(MutateType eType, float fFac1, float fFac2)
  {
    return BData.GetString(BData.GetMutate(eType).strDesc).Replace("[1]", fFac1.ToString()).Replace("[2]", fFac2.ToString());
  }

  public static bool IsSoloPlay(MutateType eType)
  {
    if (eType != MutateType.eReflection)
      return eType == MutateType.eGemini;
    return true;
  }

  public static PlayerAccData GetNewAcc(short sID)
  {
    return new PlayerAccData() { UID = Info.rebirth.uAccUID++, sID = (ObscuredShort) sID, nLv = (ObscuredInt) 0 };
  }

  public static PlayerAccData GetNewAcc(int nDropMin, int nDropMax, bool bRing)
  {
    float max = 0.0f;
    for (int index = nDropMin; index <= nDropMax; ++index)
      max += Info.fAccDropFactor[index];
    float num1 = UnityEngine.Random.Range(0.0f, max);
    int num2 = 0;
    for (int index = nDropMax; index >= nDropMin; --index)
    {
      if ((double) num1 < (double) Info.fAccDropFactor[index])
      {
        num2 = index;
        break;
      }
      num1 -= Info.fAccDropFactor[index];
    }
    List<short> shortList1 = new List<short>((IEnumerable<short>) BData.dictAcc.Keys);
    List<short> shortList2 = new List<short>();
    for (int index = 0; index < shortList1.Count; ++index)
    {
      AccData accessory = BData.GetAccessory(shortList1[index]);
      if (accessory.eDrop == AccDropType.eDrop && accessory.nGrade == num2 && (!bRing || accessory.eType == ItemType.eRing) && (bRing || accessory.eType == ItemType.eAmulet))
        shortList2.Add(shortList1[index]);
    }
    return Info.GetNewAcc(shortList2[UnityEngine.Random.Range(0, shortList2.Count)]);
  }

  public static string GetAccDesc(short sID, int nLv = 0)
  {
    AccData accessory = BData.GetAccessory(sID);
    string str = string.Empty;
    if (accessory.eStat1 != ModType.eNone)
      str = str + "\n" + BData.GetString(BData.GetMod(accessory.eStat1).strDesc).Replace("[1]", (accessory.fStat1 + accessory.fGrow1 * (float) nLv).ToString("###0.##")).Replace("+-", "-");
    if (accessory.eStat2 != ModType.eNone)
      str = str + "\n" + BData.GetString(BData.GetMod(accessory.eStat2).strDesc).Replace("[1]", (accessory.fStat2 + accessory.fGrow2 * (float) nLv).ToString("###0.##")).Replace("+-", "-");
    if (accessory.eStat3 != ModType.eNone)
      str = str + "\n" + BData.GetString(BData.GetMod(accessory.eStat3).strDesc).Replace("[1]", (accessory.fStat3 + accessory.fGrow3 * (float) nLv).ToString("###0.##")).Replace("+-", "-");
    return str;
  }

  public static void RefreshAccMod()
  {
    Info.fPlayerAccMod = new ObscuredFloat[5, 64];
    for (int index = 0; index < 64; ++index)
      Info.fAllAccMod[index] = (ObscuredFloat) 0.0f;
    for (int index1 = 0; index1 < Info.currentSave.arrPlayerMon.Length; ++index1)
    {
      for (int index2 = 0; index2 < 64; ++index2)
        Info.fPlayerAccMod[index1, index2] = (ObscuredFloat) 0.0f;
      if (Info.currentSave.arrPlayerMon[index1] != null)
      {
        if ((long) Info.currentSave.arrPlayerMon[index1].nAmulet != -1L)
        {
          if (!Info.rebirth.dictAcc.ContainsKey(Info.currentSave.arrPlayerMon[index1].nAmulet))
          {
            Info.currentSave.arrPlayerMon[index1].nAmulet = (ObscuredLong) -1L;
            continue;
          }
          PlayerAccData playerAcc = Info.GetPlayerAcc((long) Info.currentSave.arrPlayerMon[index1].nAmulet);
          AccData accessory = BData.GetAccessory((short) playerAcc.sID);
          if (accessory.eType != ItemType.eAmulet)
          {
            Info.currentSave.arrPlayerMon[index1].nAmulet = (ObscuredLong) -1L;
            continue;
          }
          if (accessory.eStat1 != ModType.eNone)
          {
            // ISSUE: variable of a reference type
            ObscuredFloat& local1 = Info.fPlayerAccMod.Address(index1, (int) accessory.eStat1);
            // ISSUE: explicit reference operation
            ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) (^local1) + (accessory.fStat1 + accessory.fGrow1 * (float) (int) playerAcc.nLv));
            // ISSUE: explicit reference operation
            ^local1 = obscuredFloat1;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            ObscuredFloat& local2 = @Info.fAllAccMod[(int) accessory.eStat1];
            // ISSUE: explicit reference operation
            ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) (^local2) + (accessory.fStat1 + accessory.fGrow1 * (float) (int) playerAcc.nLv));
            // ISSUE: explicit reference operation
            ^local2 = obscuredFloat2;
          }
          if (accessory.eStat2 != ModType.eNone)
          {
            // ISSUE: variable of a reference type
            ObscuredFloat& local1 = Info.fPlayerAccMod.Address(index1, (int) accessory.eStat2);
            // ISSUE: explicit reference operation
            ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) (^local1) + (accessory.fStat2 + accessory.fGrow2 * (float) (int) playerAcc.nLv));
            // ISSUE: explicit reference operation
            ^local1 = obscuredFloat1;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            ObscuredFloat& local2 = @Info.fAllAccMod[(int) accessory.eStat2];
            // ISSUE: explicit reference operation
            ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) (^local2) + (accessory.fStat2 + accessory.fGrow2 * (float) (int) playerAcc.nLv));
            // ISSUE: explicit reference operation
            ^local2 = obscuredFloat2;
          }
          if (accessory.eStat3 != ModType.eNone)
          {
            // ISSUE: variable of a reference type
            ObscuredFloat& local1 = Info.fPlayerAccMod.Address(index1, (int) accessory.eStat3);
            // ISSUE: explicit reference operation
            ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) (^local1) + (accessory.fStat3 + accessory.fGrow3 * (float) (int) playerAcc.nLv));
            // ISSUE: explicit reference operation
            ^local1 = obscuredFloat1;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            ObscuredFloat& local2 = @Info.fAllAccMod[(int) accessory.eStat3];
            // ISSUE: explicit reference operation
            ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) (^local2) + (accessory.fStat3 + accessory.fGrow3 * (float) (int) playerAcc.nLv));
            // ISSUE: explicit reference operation
            ^local2 = obscuredFloat2;
          }
        }
        if ((long) Info.currentSave.arrPlayerMon[index1].nRing != -1L)
        {
          if (!Info.rebirth.dictAcc.ContainsKey(Info.currentSave.arrPlayerMon[index1].nRing))
          {
            Info.currentSave.arrPlayerMon[index1].nRing = (ObscuredLong) -1L;
          }
          else
          {
            PlayerAccData playerAcc = Info.GetPlayerAcc((long) Info.currentSave.arrPlayerMon[index1].nRing);
            AccData accessory = BData.GetAccessory((short) playerAcc.sID);
            if (accessory.eType != ItemType.eRing)
            {
              Info.currentSave.arrPlayerMon[index1].nRing = (ObscuredLong) -1L;
            }
            else
            {
              if (accessory.eStat1 != ModType.eNone)
              {
                // ISSUE: variable of a reference type
                ObscuredFloat& local1 = Info.fPlayerAccMod.Address(index1, (int) accessory.eStat1);
                // ISSUE: explicit reference operation
                ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) (^local1) + (accessory.fStat1 + accessory.fGrow1 * (float) (int) playerAcc.nLv));
                // ISSUE: explicit reference operation
                ^local1 = obscuredFloat1;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                ObscuredFloat& local2 = @Info.fAllAccMod[(int) accessory.eStat1];
                // ISSUE: explicit reference operation
                ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) (^local2) + (accessory.fStat1 + accessory.fGrow1 * (float) (int) playerAcc.nLv));
                // ISSUE: explicit reference operation
                ^local2 = obscuredFloat2;
              }
              if (accessory.eStat2 != ModType.eNone)
              {
                // ISSUE: variable of a reference type
                ObscuredFloat& local1 = Info.fPlayerAccMod.Address(index1, (int) accessory.eStat2);
                // ISSUE: explicit reference operation
                ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) (^local1) + (accessory.fStat2 + accessory.fGrow2 * (float) (int) playerAcc.nLv));
                // ISSUE: explicit reference operation
                ^local1 = obscuredFloat1;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                ObscuredFloat& local2 = @Info.fAllAccMod[(int) accessory.eStat2];
                // ISSUE: explicit reference operation
                ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) (^local2) + (accessory.fStat2 + accessory.fGrow2 * (float) (int) playerAcc.nLv));
                // ISSUE: explicit reference operation
                ^local2 = obscuredFloat2;
              }
              if (accessory.eStat3 != ModType.eNone)
              {
                // ISSUE: variable of a reference type
                ObscuredFloat& local1 = Info.fPlayerAccMod.Address(index1, (int) accessory.eStat3);
                // ISSUE: explicit reference operation
                ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) (^local1) + (accessory.fStat3 + accessory.fGrow3 * (float) (int) playerAcc.nLv));
                // ISSUE: explicit reference operation
                ^local1 = obscuredFloat1;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                ObscuredFloat& local2 = @Info.fAllAccMod[(int) accessory.eStat3];
                // ISSUE: explicit reference operation
                ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) (^local2) + (accessory.fStat3 + accessory.fGrow3 * (float) (int) playerAcc.nLv));
                // ISSUE: explicit reference operation
                ^local2 = obscuredFloat2;
              }
            }
          }
        }
      }
    }
    Info.RefreshPartySkill();
    Info.RefreshDungeonHP();
    Info.RefreshResearchPower();
  }

  public static int GetTrialClear(long uid)
  {
    if (!Info.rebirth.dictTrialClear.ContainsKey((ObscuredLong) uid))
      return 0;
    return (int) Info.rebirth.dictTrialClear[(ObscuredLong) uid];
  }

  public static void SetTrialClear(long uid, int nClear)
  {
    if (!Info.rebirth.dictTrialClear.ContainsKey((ObscuredLong) uid))
      Info.rebirth.dictTrialClear.Add((ObscuredLong) uid, (ObscuredInt) nClear);
    Info.rebirth.dictTrialClear[(ObscuredLong) uid] = (ObscuredInt) nClear;
    Info.bRebirthChanged = true;
  }

  public static bool CheckAchieveAcc(short sID)
  {
    return Info.rebirth.listAchievementAccReward.Contains((ObscuredShort) sID);
  }

  public static void SetAchieveAcc(short sID)
  {
    Info.rebirth.listAchievementAccReward.Add((ObscuredShort) sID);
    Info.bRebirthChanged = true;
  }

  public static void OnSpecialEnchant(int nLv, int nInc)
  {
    if (!Info.CheckRebirth(RebirthID.eEnchantManage))
      return;
    PlayerItemData playerWeapon = Info.GetPlayerWeapon((long) Info.currentSave.uSpecialEnchant);
    if (playerWeapon == null || (int) playerWeapon.nLv >= nLv - nInc)
      return;
    PlayerItemData playerItemData = playerWeapon;
    ObscuredInt obscuredInt = (ObscuredInt) ((int) playerItemData.nLv + nInc);
    playerItemData.nLv = obscuredInt;
    SavedData currentSave = Info.currentSave;
    string str = currentSave.strSummary + "\n" + BData.GetString("UI0254") + " Lv." + (object) ((int) playerWeapon.nLv - nInc) + " -> " + (object) playerWeapon.nLv;
    currentSave.strSummary = str;
    Info.RefreshBattleItemData(playerWeapon);
  }

  public static void OnWeaponEnchant(long uid)
  {
    if (uid == -1L)
      return;
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(uid);
    if (playerWeapon == null)
      return;
    ItemData weapon = BData.GetWeapon((short) playerWeapon.sID);
    int enchantCost = Info.GetEnchantCost(uid);
    if ((long) Info.currentSave.nNewGold < (long) enchantCost)
      UIMgr.NotEnoughGold();
    else if ((int) Info.currentSave.nEnchant >= Info.nMaxEnchant)
    {
      UIMgr.OnErrorPopup("UI0128");
    }
    else
    {
      int nInc = 1 + Info.GetResearchFacInt(ResearchID.eStone) + Info.GetRebirthFacToInt(RebirthID.eItemEnchantPlus);
      if (Info.IsEquipped(uid))
      {
        for (int nPos = 0; nPos < 5; ++nPos)
        {
          if (Info.GetPlayerMon(nPos) != null && (long) Info.GetPlayerMon(nPos).nEquip == uid && (Info.GetPlayerMon(nPos).dictSkill.ContainsKey(weapon.eMastery) && (int) Info.GetPlayerMon(nPos).dictSkill[weapon.eMastery] < Info.CalcMasteryLv((int) playerWeapon.nLv + nInc)))
          {
            UIMgr.PlaySound("Negative", false);
            return;
          }
        }
      }
      SavedData currentSave1 = Info.currentSave;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave1.nNewGold - (long) enchantCost);
      currentSave1.nNewGold = obscuredLong;
      ++Info.currentSave.nEnchant;
      ++Info.achievement.nEnchant;
      PlayerItemData playerItemData = playerWeapon;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) playerItemData.nLv + nInc);
      playerItemData.nLv = obscuredInt;
      SavedData currentSave2 = Info.currentSave;
      string str = currentSave2.strSummary + "\n" + BData.GetString("UI0254") + " Lv." + (object) ((int) playerWeapon.nLv - nInc) + " -> " + (object) playerWeapon.nLv;
      currentSave2.strSummary = str;
      Info.RefreshBattleItemData(playerWeapon);
      Info.OnSpecialEnchant((int) playerWeapon.nLv, nInc);
      Info.OnAfterEnchant(false);
    }
  }

  public static void OnWeaponSimpleEnchant(long uid, bool bAuto = false)
  {
    if (uid == -1L)
      return;
    PlayerItemData playerWeapon = Info.GetPlayerWeapon(uid);
    if (playerWeapon == null)
      return;
    bool flag1 = false;
    ItemData weapon = BData.GetWeapon((short) playerWeapon.sID);
    bool flag2 = Info.IsEquipped(uid);
    int nInc = 1 + Info.GetResearchFacInt(ResearchID.eStone) + Info.GetRebirthFacToInt(RebirthID.eItemEnchantPlus);
    int nLv = (int) playerWeapon.nLv;
    while ((int) Info.currentSave.nEnchant < Info.nMaxEnchant)
    {
      bool flag3 = false;
      if (flag2)
      {
        for (int nPos = 0; nPos < 5; ++nPos)
        {
          if (Info.GetPlayerMon(nPos) != null && (long) Info.GetPlayerMon(nPos).nEquip == uid && (Info.GetPlayerMon(nPos).dictSkill.ContainsKey(weapon.eMastery) && Info.GetSkill(nPos, weapon.eMastery) < Info.CalcMasteryLv((int) playerWeapon.nLv + nInc)))
            flag3 = true;
        }
      }
      if (!flag3)
      {
        int enchantCost = Info.GetEnchantCost(uid);
        if ((long) Info.currentSave.nNewGold < (long) enchantCost)
        {
          if (!bAuto)
          {
            UIMgr.NotEnoughGold();
            break;
          }
          break;
        }
        flag1 = true;
        SavedData currentSave = Info.currentSave;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave.nNewGold - (long) enchantCost);
        currentSave.nNewGold = obscuredLong;
        ++Info.currentSave.nEnchant;
        ++Info.achievement.nEnchant;
        PlayerItemData playerItemData = playerWeapon;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) playerItemData.nLv + nInc);
        playerItemData.nLv = obscuredInt;
        Info.RefreshBattleItemData(playerWeapon);
        Info.OnSpecialEnchant((int) playerWeapon.nLv, nInc);
      }
      else
        break;
    }
    if (!flag1)
      return;
    SavedData currentSave1 = Info.currentSave;
    string str = currentSave1.strSummary + "\n" + BData.GetString("UI0254") + " Lv." + (object) nLv + " -> " + (object) playerWeapon.nLv;
    currentSave1.strSummary = str;
    Info.OnAfterEnchant(bAuto);
  }

  public static void OnWeaponEqualEnchant(bool bAuto = false)
  {
    bool flag = false;
    int nInc = 1 + Info.GetResearchFacInt(ResearchID.eStone) + Info.GetRebirthFacToInt(RebirthID.eItemEnchantPlus);
    while ((int) Info.currentSave.nEnchant < Info.nMaxEnchant)
    {
      int num = 0;
      for (int nPos = 0; nPos < Info.currentSave.arrPlayerMon.Length && (int) Info.currentSave.nEnchant < Info.nMaxEnchant; ++nPos)
      {
        if (Info.currentSave.arrPlayerMon[nPos] != null)
        {
          PlayerMonsterData playerMonsterData = Info.currentSave.arrPlayerMon[nPos];
          long nEquip = (long) playerMonsterData.nEquip;
          if (nEquip != -1L)
          {
            PlayerItemData playerWeapon = Info.GetPlayerWeapon(nEquip);
            if (playerWeapon != null)
            {
              ItemData weapon = BData.GetWeapon((short) playerWeapon.sID);
              int nLv = (int) playerWeapon.nLv;
              if (Info.GetSkill(nPos, weapon.eMastery) >= Info.CalcMasteryLv((int) playerWeapon.nLv + nInc))
              {
                int enchantCost = Info.GetEnchantCost(nEquip);
                if ((long) Info.currentSave.nNewGold >= (long) enchantCost)
                {
                  ++num;
                  flag = true;
                  SavedData currentSave1 = Info.currentSave;
                  ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave1.nNewGold - (long) enchantCost);
                  currentSave1.nNewGold = obscuredLong;
                  ++Info.currentSave.nEnchant;
                  ++Info.achievement.nEnchant;
                  PlayerItemData playerItemData = playerWeapon;
                  ObscuredInt obscuredInt = (ObscuredInt) ((int) playerItemData.nLv + nInc);
                  playerItemData.nLv = obscuredInt;
                  Info.RefreshBattleItemData(playerWeapon);
                  SavedData currentSave2 = Info.currentSave;
                  string str = currentSave2.strSummary + "\n<" + BData.GetString(BData.GetMonster((short) playerMonsterData.sID).strName) + "> : " + BData.GetString("UI0254") + " Lv." + (object) nLv + " -> " + (object) playerWeapon.nLv;
                  currentSave2.strSummary = str;
                  Info.OnSpecialEnchant((int) playerWeapon.nLv, nInc);
                }
              }
            }
          }
        }
      }
      if (num == 0)
        break;
    }
    if (!flag)
      return;
    Info.OnAfterEnchant(bAuto);
  }

  public static void OnAfterEnchant(bool bAuto = false)
  {
    if (!bAuto)
      UIMgr.PlaySound("Hire", false);
    Info.bAcvChanged = true;
    if ((int) Info.achievement.nEnchant >= 10)
      Info.CheckAchievement(AchievementType.eEnchant10);
    if ((int) Info.achievement.nEnchant >= 30)
      Info.CheckAchievement(AchievementType.eEnchant30);
    if ((int) Info.achievement.nEnchant >= 50)
      Info.CheckAchievement(AchievementType.eEnchant50);
    if ((int) Info.achievement.nEnchant >= 75)
      Info.CheckAchievement(AchievementType.eEnchant75);
    if ((int) Info.achievement.nEnchant >= 100)
      Info.CheckAchievement(AchievementType.eEnchant100);
    if ((int) Info.achievement.nEnchant >= 300)
      Info.CheckAchievement(AchievementType.eEnchant300);
    if ((int) Info.achievement.nEnchant >= 500)
      Info.CheckAchievement(AchievementType.eEnchant500);
    if ((int) Info.achievement.nEnchant >= 1000)
      Info.CheckAchievement(AchievementType.eEnchant1000);
    Info.TrySaveAchievement();
  }

  public static int GetContinueWave(int nWave)
  {
    if (nWave < 1)
      return 0;
    return Mathf.Max(1, nWave - nWave / 10);
  }

  public static bool IsOwnedAcc(short sID)
  {
    List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    for (int index = 0; index < playerAccDataList.Count; ++index)
    {
      if ((int) (short) playerAccDataList[index].sID == (int) sID)
        return true;
    }
    return false;
  }

  public static bool OnSellAll()
  {
    int num = 0;
    List<long> longList = new List<long>();
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    for (int index = 0; index < playerItemDataList.Count; ++index)
    {
      if (!Info.IsEquipped((long) playerItemDataList[index].UID) && !(bool) playerItemDataList[index].bProtected)
      {
        num += Info.GetSellPrice((int) playerItemDataList[index].nLv, (byte) playerItemDataList[index].byGrade);
        longList.Add((long) playerItemDataList[index].UID);
      }
    }
    for (int index = 0; index < longList.Count; ++index)
      Info.currentSave.dictItem.Remove((ObscuredLong) longList[index]);
    SavedData currentSave = Info.currentSave;
    ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave.nNewGold + (long) num);
    currentSave.nNewGold = obscuredLong;
    bool flag = false;
    if (num > 0)
    {
      UIMgr.PlaySound("Sell", false);
      flag = true;
    }
    return flag;
  }

  public static bool OnSellAllWithoutLengend()
  {
    int num = 0;
    List<long> longList = new List<long>();
    List<PlayerItemData> playerItemDataList = new List<PlayerItemData>((IEnumerable<PlayerItemData>) Info.currentSave.dictItem.Values);
    for (int index = 0; index < playerItemDataList.Count; ++index)
    {
      PlayerItemData playerItemData = playerItemDataList[index];
      if (!Info.IsEquipped((long) playerItemDataList[index].UID) && !(bool) playerItemData.bProtected && (int) (byte) playerItemData.byGrade < 4)
      {
        num += Info.GetSellPrice((int) playerItemData.nLv, (byte) playerItemData.byGrade);
        longList.Add((long) playerItemData.UID);
      }
    }
    for (int index = 0; index < longList.Count; ++index)
      Info.currentSave.dictItem.Remove((ObscuredLong) longList[index]);
    SavedData currentSave = Info.currentSave;
    ObscuredLong obscuredLong = (ObscuredLong) ((long) currentSave.nNewGold + (long) num);
    currentSave.nNewGold = obscuredLong;
    bool flag = false;
    if (num > 0)
    {
      UIMgr.PlaySound("Sell", false);
      flag = true;
    }
    return flag;
  }

  public static bool OnAutoEquip()
  {
    bool flag = false;
    List<BattleItemData> battleItemDataList = new List<BattleItemData>((IEnumerable<BattleItemData>) Info.dictBattleItem.Values);
    for (int index1 = 0; index1 < Info.currentSave.arrPlayerMon.Length; ++index1)
    {
      if (Info.currentSave.arrPlayerMon[index1] != null)
      {
        float num1 = 0.0f;
        byte num2 = 0;
        if ((long) Info.currentSave.arrPlayerMon[index1].nEquip != -1L)
        {
          BattleItemData battleItem = Info.GetBattleItem((long) Info.currentSave.arrPlayerMon[index1].nEquip);
          num1 = battleItem.fDPS;
          num2 = (byte) battleItem.byGrade;
        }
        for (int index2 = 0; index2 < battleItemDataList.Count; ++index2)
        {
          if (Info.currentSave.dictItem.ContainsKey(battleItemDataList[index2].UID) && !Info.IsEquipped((long) battleItemDataList[index2].UID) && ((long) battleItemDataList[index2].UID != (long) Info.currentSave.arrPlayerMon[index1].nEquip && Info.currentSave.arrPlayerMon[index1].dictSkill.ContainsKey(battleItemDataList[index2].eMastery)) && ((int) Info.currentSave.arrPlayerMon[index1].dictSkill[battleItemDataList[index2].eMastery] >= battleItemDataList[index2].nMastery && (double) battleItemDataList[index2].fDPS >= (double) num1 && (!Info.option.bAutoItemEnchant || (int) (byte) battleItemDataList[index2].byGrade >= (int) num2)))
          {
            Info.currentSave.arrPlayerMon[index1].nEquip = battleItemDataList[index2].UID;
            num1 = battleItemDataList[index2].fDPS;
            num2 = (byte) battleItemDataList[index2].byGrade;
            flag = true;
          }
        }
        if ((long) Info.currentSave.arrPlayerMon[index1].nEquip == (long) Info.currentSave.uSpecialEnchant)
          Info.currentSave.uSpecialEnchant = (ObscuredLong) -1L;
      }
    }
    return flag;
  }

  public static bool OnAutoAccEquip()
  {
    bool flag = false;
    List<PlayerAccData> playerAccDataList = new List<PlayerAccData>((IEnumerable<PlayerAccData>) Info.rebirth.dictAcc.Values);
    for (int index1 = 0; index1 < Info.currentSave.arrPlayerMon.Length; ++index1)
    {
      if (Info.currentSave.arrPlayerMon[index1] != null)
      {
        int num1 = 0;
        for (int index2 = 0; index2 < playerAccDataList.Count; ++index2)
        {
          AccData accessory = BData.GetAccessory((short) playerAccDataList[index2].sID);
          if (accessory.eType == ItemType.eAmulet && (int) accessory.sOnly == (int) (short) Info.currentSave.arrPlayerMon[index1].sID && (!Info.IsEquippedAcc((long) playerAccDataList[index2].UID) && (long) playerAccDataList[index2].UID != (long) Info.currentSave.arrPlayerMon[index1].nAmulet) && (int) playerAccDataList[index2].nLv >= num1)
          {
            Info.currentSave.arrPlayerMon[index1].nAmulet = playerAccDataList[index2].UID;
            num1 = (int) playerAccDataList[index2].nLv;
            flag = true;
          }
        }
        int num2 = 0;
        for (int index2 = 0; index2 < playerAccDataList.Count && Info.CheckRebirth(RebirthID.eRingUnlock); ++index2)
        {
          AccData accessory = BData.GetAccessory((short) playerAccDataList[index2].sID);
          if (accessory.eType == ItemType.eRing && (int) accessory.sOnly == (int) (short) Info.currentSave.arrPlayerMon[index1].sID && (!Info.IsEquippedAcc((long) playerAccDataList[index2].UID) && (long) playerAccDataList[index2].UID != (long) Info.currentSave.arrPlayerMon[index1].nRing) && (int) playerAccDataList[index2].nLv >= num2)
          {
            Info.currentSave.arrPlayerMon[index1].nRing = playerAccDataList[index2].UID;
            num2 = (int) playerAccDataList[index2].nLv;
            flag = true;
          }
        }
      }
    }
    return flag;
  }

  public static bool isAwaken(int nPos)
  {
    return Info.isAwaken(Info.GetPlayerMon(nPos));
  }

  public static bool isAwaken(PlayerMonsterData pData)
  {
    if (!(bool) pData.bAwaken)
      return Info.CheckRebirth(BData.GetMonster((short) pData.sID).eAwaken);
    return true;
  }

  public static int GetCostHire(PlayerMonsterData pData)
  {
    return (int) pData.nLv * 50 + Info.GetSellPrice((int) pData.nLv, (byte) 4);
  }

  public static string GetDiffText(int nDiff, bool bShowPercent)
  {
    if (nDiff <= 5)
      return BData.GetString("UI00" + (object) (33 + nDiff)).Replace("[1]", !bShowPercent ? string.Empty : "-" + (Info.fDiffFac[nDiff] * 100f).ToString("N0") + "%");
    return "<color='#ff1500'><" + BData.GetString("UI0337") + BData.GetString("UI0" + (object) (342 + (nDiff - 6))) + (!bShowPercent ? string.Empty : "-???%") + "></color>";
  }

  public static int[] GetAllClearHellStone(int nDiff)
  {
    int[] numArray = new int[10];
    for (int nNum = 0; nNum < 10; ++nNum)
      numArray[nNum] = Info.GetClearHellStone(nDiff, nNum);
    return numArray;
  }

  public static int GetClearHellStone(int nDiff, int nNum)
  {
    if (!Info.rebirth.dictHellQuest.ContainsKey((ObscuredInt) nDiff))
      Info.rebirth.dictHellQuest.Add((ObscuredInt) nDiff, new Dictionary<ObscuredInt, ObscuredInt>());
    if (!Info.rebirth.dictHellQuest[(ObscuredInt) nDiff].ContainsKey((ObscuredInt) nNum))
      Info.rebirth.dictHellQuest[(ObscuredInt) nDiff].Add((ObscuredInt) nNum, (ObscuredInt) 0);
    return (int) Info.rebirth.dictHellQuest[(ObscuredInt) nDiff][(ObscuredInt) nNum];
  }

  public static void AddClearHellStone(int nDiff, int nNum)
  {
    int clearHellStone = Info.GetClearHellStone(nDiff, nNum);
    Info.rebirth.dictHellQuest[(ObscuredInt) nDiff][(ObscuredInt) nNum] = (ObscuredInt) (clearHellStone + 1);
  }

  public static int GetRebirthTime(int nDiff, int nDay)
  {
    if (!Info.rebirth.dictRebirthHistory.ContainsKey((ObscuredInt) nDiff))
      return 0;
    int num = 0;
    for (int index = 0; index < Info.rebirth.dictRebirthHistory[(ObscuredInt) nDiff].Count; ++index)
    {
      if ((int) Info.rebirth.dictRebirthHistory[(ObscuredInt) nDiff][index] >= nDay)
        ++num;
    }
    return num;
  }

  public static long GetElementalExp(int i)
  {
    if (!Info.rebirth.dictElementalExp.ContainsKey((ObscuredInt) i))
      Info.rebirth.dictElementalExp.Add((ObscuredInt) i, (ObscuredLong) 0L);
    return (long) Info.rebirth.dictElementalExp[(ObscuredInt) i];
  }

  public static void AddElementalExp(int i, long nExp)
  {
    if (i <= 0)
      return;
    nExp += Info.GetElementalExp(i);
    Info.rebirth.dictElementalExp[(ObscuredInt) i] = (ObscuredLong) nExp;
  }

  public static bool CheckElementalTrait(ElementalID eID)
  {
    return Info.GetElementalTrait(eID) > 0;
  }

  public static int GetElementalTrait(ElementalID eID)
  {
    if (!Info.rebirth.dictElementalTrait.ContainsKey(eID))
      return 0;
    return (int) Info.rebirth.dictElementalTrait[eID];
  }

  public static void UpgElementalTrait(ElementalID eID)
  {
    if (!Info.rebirth.dictElementalTrait.ContainsKey(eID))
      Info.rebirth.dictElementalTrait.Add(eID, (ObscuredInt) 0);
    ++Info.rebirth.dictElementalTrait[eID];
    if (eID != ElementalID.eFireChar)
    {
      if (eID != ElementalID.eWaterChar)
      {
        if (eID != ElementalID.eNatureChar)
        {
          if (eID != ElementalID.eLightChar)
          {
            if (eID != ElementalID.eDarkChar || Info.CheckRebirth(RebirthID.eDarkElemental))
              return;
            Info.UpgRebirth(RebirthID.eDarkElemental, 1);
          }
          else
          {
            if (Info.CheckRebirth(RebirthID.eLightElemental))
              return;
            Info.UpgRebirth(RebirthID.eLightElemental, 1);
          }
        }
        else
        {
          if (Info.CheckRebirth(RebirthID.eNatureElemental))
            return;
          Info.UpgRebirth(RebirthID.eNatureElemental, 1);
        }
      }
      else
      {
        if (Info.CheckRebirth(RebirthID.eWaterElemental))
          return;
        Info.UpgRebirth(RebirthID.eWaterElemental, 1);
      }
    }
    else
    {
      if (Info.CheckRebirth(RebirthID.eFireElemental))
        return;
      Info.UpgRebirth(RebirthID.eFireElemental, 1);
    }
  }

  public static bool CanUpgElementalTrait(ElementalID eID, bool bCheckAvailable = true)
  {
    ElementalData elemental = BData.GetElemental(eID);
    int traitNumberByElement = Info.GetTraitNumberByElement(elemental.eElm);
    return traitNumberByElement >= elemental.nNeed && (traitNumberByElement < Info.GetElementalLevel((int) elemental.eElm) || !bCheckAvailable) && (elemental.eNeed == ElementalID.eNone || Info.CheckElementalTrait(elemental.eNeed));
  }

  public static int GetTraitNumberByElement(int n)
  {
    return Info.GetTraitNumberByElement((Element) n);
  }

  public static int GetTraitNumberByElement(Element eID)
  {
    int num = 0;
    foreach (KeyValuePair<ElementalID, ObscuredInt> keyValuePair in Info.rebirth.dictElementalTrait)
    {
      if (BData.GetElemental(keyValuePair.Key).eElm == eID)
        num += (int) keyValuePair.Value;
    }
    return num;
  }

  public static int GetElementalLevel(int nElm)
  {
    long elementalExp = Info.GetElementalExp(nElm);
    long num1 = 0;
    int num2 = 0;
    if (elementalExp == 0L)
    {
      switch (nElm)
      {
        case 1:
          if (!Info.CheckRebirth(RebirthID.eFireDungeon))
            return 0;
          break;
        case 2:
          if (!Info.CheckRebirth(RebirthID.eWaterDungeon))
            return 0;
          break;
        case 3:
          if (!Info.CheckRebirth(RebirthID.eNatureDungeon))
            return 0;
          break;
        case 4:
          if (!Info.CheckRebirth(RebirthID.eLightDungeon))
            return 0;
          break;
        case 5:
          if (!Info.CheckRebirth(RebirthID.eDarkDungeon))
            return 0;
          break;
      }
    }
    while (elementalExp >= num1)
    {
      ++num2;
      num1 += (long) (num2 * (num2 + 1) / 2 * 100);
    }
    return num2;
  }

  public static long[] GetElementalAllExp(int nElement)
  {
    long elementalExp = Info.GetElementalExp(nElement);
    long num1 = 0;
    int num2 = 0;
    long num3 = 0;
    while (elementalExp >= num1)
    {
      ++num2;
      num3 = num1;
      num1 += (long) (num2 * (num2 + 1) / 2 * 100);
    }
    return new long[4]{ num3, num1, elementalExp, num1 - elementalExp };
  }

  public static ElementalID GetElementalBase(int nElement)
  {
    switch (nElement)
    {
      case 1:
        return ElementalID.eFireBase1;
      case 2:
        return ElementalID.eWaterBase1;
      case 3:
        return ElementalID.eNatureBase1;
      case 4:
        return ElementalID.eLightBase1;
      case 5:
        return ElementalID.eDarkBase1;
      default:
        return ElementalID.eNone;
    }
  }

  public static ElementalID GetElementalBase2(int nElement)
  {
    switch (nElement)
    {
      case 1:
        return ElementalID.eFireBase2;
      case 2:
        return ElementalID.eWaterBase2;
      case 3:
        return ElementalID.eNatureBase2;
      case 4:
        return ElementalID.eLightBase2;
      case 5:
        return ElementalID.eDarkBase2;
      default:
        return ElementalID.eNone;
    }
  }

  public static ElementalID GetElementalBase3(int nElement)
  {
    switch (nElement)
    {
      case 1:
        return ElementalID.eFireBase3;
      case 2:
        return ElementalID.eWaterBase3;
      case 3:
        return ElementalID.eNatureBase3;
      case 4:
        return ElementalID.eLightBase3;
      case 5:
        return ElementalID.eDarkBase3;
      default:
        return ElementalID.eNone;
    }
  }

  public static void RefreshElementalFac()
  {
    Info.dictElementalFac.Clear();
    foreach (KeyValuePair<ElementalID, ObscuredInt> keyValuePair in Info.rebirth.dictElementalTrait)
    {
      ElementalData elemental = BData.GetElemental(keyValuePair.Key);
      ElementalID key = keyValuePair.Key;
      if (elemental.eElm == (Element) (int) Info.rebirth.nEquippedElemental && (!Info.rebirth.dictElementalTrait.ContainsKey(Info.GetElementalBase3((int) Info.rebirth.nEquippedElemental)) || key != Info.GetElementalBase((int) Info.rebirth.nEquippedElemental) && key != Info.GetElementalBase2((int) Info.rebirth.nEquippedElemental)) && (!Info.rebirth.dictElementalTrait.ContainsKey(Info.GetElementalBase2((int) Info.rebirth.nEquippedElemental)) || key != Info.GetElementalBase((int) Info.rebirth.nEquippedElemental)))
      {
        if (key == Info.GetElementalBase2((int) Info.rebirth.nEquippedElemental) || key == Info.GetElementalBase3((int) Info.rebirth.nEquippedElemental))
        {
          key = Info.GetElementalBase((int) Info.rebirth.nEquippedElemental);
          if (Info.dictElementalFac.ContainsKey(key))
            Info.dictElementalFac.Remove(key);
        }
        if (!Info.dictElementalFac.ContainsKey(key))
          Info.dictElementalFac.Add(key, new ObscuredFloat[3]
          {
            (ObscuredFloat) (elemental.fBase1 + elemental.fGrow1 * (float) (int) keyValuePair.Value),
            (ObscuredFloat) (elemental.fBase2 + elemental.fGrow2 * (float) (int) keyValuePair.Value),
            (ObscuredFloat) (elemental.fBase3 + elemental.fGrow3 * (float) (int) keyValuePair.Value)
          });
      }
    }
  }

  public static float GetElementalFac(ElementalID eID, int n = 0)
  {
    if (!Info.dictElementalFac.ContainsKey(eID))
      return 0.0f;
    return (float) Info.dictElementalFac[eID][n];
  }

  public static int GetNeedMedalPromote(int nLv)
  {
    ++nLv;
    return nLv * (nLv + 1) * (50 + 10 * nLv);
  }

  public static int GetPromoteLevel(short sID)
  {
    if (!Info.rebirth.dictUnitPromote.ContainsKey((ObscuredShort) sID))
      Info.rebirth.dictUnitPromote.Add((ObscuredShort) sID, (ObscuredInt) 0);
    return (int) Info.rebirth.dictUnitPromote[(ObscuredShort) sID];
  }

  public static void UpgPromoteLevel(short sID)
  {
    int promoteLevel = Info.GetPromoteLevel(sID);
    Info.rebirth.dictUnitPromote[(ObscuredShort) sID] = (ObscuredInt) (promoteLevel + 1);
  }

  public static void InitPromoteLevel(short sID)
  {
    Info.rebirth.dictUnitPromote.Remove((ObscuredShort) sID);
  }

  public static int GetRepeatResearch(ResearchID eID)
  {
    if (!Info.currentSave.dictRepeatResearch.ContainsKey(eID))
      Info.currentSave.dictRepeatResearch.Add(eID, (ObscuredInt) 0);
    return (int) Info.currentSave.dictRepeatResearch[eID];
  }

  public static void UpgRepeatResearch(ResearchID eID)
  {
    int repeatResearch = Info.GetRepeatResearch(eID);
    Info.currentSave.dictRepeatResearch[eID] = (ObscuredInt) (repeatResearch + 1);
  }

  public static int GetResearchCost(ResearchID eID)
  {
    ResearchData research = BData.GetResearch(eID);
    if (research.bRepeat)
      return research.nCost + 200 * Info.GetRepeatResearch(eID);
    return research.nCost;
  }
}
