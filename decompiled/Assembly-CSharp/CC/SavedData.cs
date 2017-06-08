// Decompiled with JetBrains decompiler
// Type: CC.SavedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;

namespace CC
{
  [Serializable]
  public class SavedData
  {
    public long uItem = 1;
    public ObscuredInt nDay = (ObscuredInt) 1;
    public ObscuredInt nGold = (ObscuredInt) 0;
    public ObscuredInt nPerfect = (ObscuredInt) 0;
    public ObscuredInt nMod = (ObscuredInt) 0;
    public ObscuredLong[] nEquipWeapon = new ObscuredLong[5]{ (ObscuredLong) -1L, (ObscuredLong) -1L, (ObscuredLong) -1L, (ObscuredLong) -1L, (ObscuredLong) -1L };
    public ObscuredFloat fDunCurHP = (ObscuredFloat) 100f;
    public PlayerMonsterData[] arrPlayerMon = new PlayerMonsterData[5];
    public List<PlayerItemData> listShopItem = new List<PlayerItemData>();
    public Dictionary<ObscuredLong, PlayerItemData> dictItem = new Dictionary<ObscuredLong, PlayerItemData>();
    public Dictionary<DungeonType, ObscuredInt> dictDun = new Dictionary<DungeonType, ObscuredInt>();
    public string strSummary = string.Empty;
    public ObscuredInt nDiff = (ObscuredInt) 0;
    public ObscuredInt nEnchant = (ObscuredInt) 0;
    public List<ResearchID> listResearch = new List<ResearchID>();
    public ObscuredInt nClearTrial = (ObscuredInt) 0;
    public ObscuredInt nMaxEndless = (ObscuredInt) 0;
    public ObscuredLong nNewGold = (ObscuredLong) 0L;
    public ObscuredFloat fAwakenCharge = (ObscuredFloat) 0.0f;
    public ObscuredLong uSpecialEnchant = (ObscuredLong) -1L;
    public Dictionary<ResearchID, ObscuredInt> dictRepeatResearch = new Dictionary<ResearchID, ObscuredInt>();
    public bool bProgressResearch = true;
    public byte bySlot;
    public long uRebirthID;
    public PlayerMonsterData pHireMonster;
    public bool bBatched;
    public bool bClear;
    public ResearchID eResearch;
    public float fResearch;
    public float fResearchProgress;
    public bool bPreResearch;
    public bool bHireMonster;
    public bool bAfterRebirth;
    public bool bDeleted;
    public bool bChallengeTrial;
    public bool bAfterAmulet;
    public int nLastTrialDiff;
    public bool bNewBalance;
    public bool bChallengeEndless;
    public bool bAfterEndless;
    public bool bAfterRelicChange;
    public bool bAfterDiffHpChange;
    public bool bAfterMonHpIncrease;
    public bool bNamelessCriFix;
  }
}
