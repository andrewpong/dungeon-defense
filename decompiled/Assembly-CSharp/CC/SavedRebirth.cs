// Decompiled with JetBrains decompiler
// Type: CC.SavedRebirth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;

namespace CC
{
  [Serializable]
  public class SavedRebirth
  {
    public Dictionary<RebirthID, ObscuredInt> dictRebirth = new Dictionary<RebirthID, ObscuredInt>();
    public List<ShopID> listPurchase = new List<ShopID>();
    public ObscuredInt nStone = (ObscuredInt) 0;
    public ObscuredInt nRebirth = (ObscuredInt) 0;
    public ObscuredLong uRebirthID = (ObscuredLong) 1L;
    public ObscuredBool bRebirthInit = (ObscuredBool) true;
    public ObscuredBool bBefore1_5 = (ObscuredBool) true;
    public List<ObscuredLong> listRebirthID = new List<ObscuredLong>();
    public ObscuredLong uAccUID = (ObscuredLong) 1L;
    public ObscuredInt nMedal = (ObscuredInt) 0;
    public ObscuredBool bPurchaseReward = (ObscuredBool) false;
    public Dictionary<ObscuredLong, PlayerAccData> dictAcc = new Dictionary<ObscuredLong, PlayerAccData>();
    public Dictionary<ObscuredLong, ObscuredInt> dictTrialClear = new Dictionary<ObscuredLong, ObscuredInt>();
    public List<ObscuredShort> listAchievementAccReward = new List<ObscuredShort>();
    public ObscuredBool bBadWarning = (ObscuredBool) false;
    public ObscuredInt nRuby = (ObscuredInt) 0;
    public List<QuestID> listMission = new List<QuestID>();
    public ObscuredInt nHell = (ObscuredInt) 0;
    public Dictionary<ObscuredInt, List<ObscuredInt>> dictRebirthHistory = new Dictionary<ObscuredInt, List<ObscuredInt>>();
    public Dictionary<ObscuredInt, Dictionary<ObscuredInt, ObscuredInt>> dictHellQuest = new Dictionary<ObscuredInt, Dictionary<ObscuredInt, ObscuredInt>>();
    public bool bAdjustHellStone = true;
    public bool bFixAppleHellStoneBug = true;
    public Dictionary<ObscuredInt, ObscuredLong> dictElementalExp = new Dictionary<ObscuredInt, ObscuredLong>();
    public Dictionary<ElementalID, ObscuredInt> dictElementalTrait = new Dictionary<ElementalID, ObscuredInt>();
    public ObscuredInt nEquippedElemental = (ObscuredInt) 0;
    public ObscuredBool bVIP = (ObscuredBool) false;
    public ObscuredInt nInitHellStone = (ObscuredInt) 0;
    public Dictionary<ObscuredShort, ObscuredInt> dictUnitPromote = new Dictionary<ObscuredShort, ObscuredInt>();
    public ObscuredInt nInitElementalTrait = (ObscuredInt) 0;
    public ObscuredLong nNewMedal = (ObscuredLong) 0L;
    public ObscuredLong nNewStone = (ObscuredLong) 0L;
    public Dictionary<ObscuredShort, Dictionary<MonTraitID, ObscuredInt>> dictMonTrait = new Dictionary<ObscuredShort, Dictionary<MonTraitID, ObscuredInt>>();
    public Dictionary<ObscuredShort, ObscuredLong> dictMonRebirthExp = new Dictionary<ObscuredShort, ObscuredLong>();
    public ObscuredInt nRebirthBonus = (ObscuredInt) 0;
    public ObscuredBool bSaveErrorReward = (ObscuredBool) false;
    public bool bAttention;
    public bool bAttentionRuby;
    public bool bAttentionHell;
  }
}
