// Decompiled with JetBrains decompiler
// Type: BData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BData : MonoBehaviour
{
  public static Dictionary<short, MonsterData> dictMonster = new Dictionary<short, MonsterData>();
  public static Dictionary<short, ItemData> dictWeapon = new Dictionary<short, ItemData>();
  public static Dictionary<short, EnemyData> dictEnemy = new Dictionary<short, EnemyData>();
  public static Dictionary<SkillKey, SkillData> dictSkill = new Dictionary<SkillKey, SkillData>();
  public static Dictionary<DungeonType, DungeonData> dictDungeon = new Dictionary<DungeonType, DungeonData>();
  public static Dictionary<ModType, ModData> dictMod = new Dictionary<ModType, ModData>();
  public static Dictionary<MutateType, MutationData> dictMutation = new Dictionary<MutateType, MutationData>();
  public static Dictionary<AchievementType, AchievementData> dictAcv = new Dictionary<AchievementType, AchievementData>();
  public static Dictionary<ResearchID, ResearchData> dictRsc = new Dictionary<ResearchID, ResearchData>();
  public static Dictionary<RebirthID, RebirthData> dictRebirth = new Dictionary<RebirthID, RebirthData>();
  public static Dictionary<ShopID, ShopData> dictShop = new Dictionary<ShopID, ShopData>();
  public static Dictionary<int, StoneData> dictStone = new Dictionary<int, StoneData>();
  public static Dictionary<short, AccData> dictAcc = new Dictionary<short, AccData>();
  public static Dictionary<int, RubyData> dictRuby = new Dictionary<int, RubyData>();
  public static Dictionary<QuestID, QuestData> dictQuest = new Dictionary<QuestID, QuestData>();
  public static Dictionary<ElementalID, ElementalData> dictElemental = new Dictionary<ElementalID, ElementalData>();
  public static Dictionary<int, TrialData> dictTrial = new Dictionary<int, TrialData>();
  public static Dictionary<string, List<string>> dictString = new Dictionary<string, List<string>>();
  public static List<MutateType> listMutation = new List<MutateType>();
  public static List<MutateType> listBossMutation = new List<MutateType>();
  public static bool bLoaded = false;
  public static BData single;
  public DataMonster _monster;
  public DataEnemy _enemy;
  public DataWeapon _weapon;
  public DataSkill _skill;
  public DataDungeon _dungeon;
  public DataMod _mod;
  public DataMutation _mutation;
  public DataAchievement _achievement;
  public DataResearch _research;
  public DataRebirth _rebirth;
  public DataShop _shop;
  public DataStone _stone;
  public DataTrial _trial;
  public DataAccessory _acc;
  public DataRuby _ruby;
  public DataQuest _quest;
  public DataElemental _elemental;
  public Strings _string;

  public void Awake()
  {
    if (BData.bLoaded)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    }
    else
    {
      BData.single = this;
      this.LoadData();
    }
  }

  private void Start()
  {
    if (!BData.bLoaded)
      return;
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  private void LoadData()
  {
    if (BData.bLoaded)
      return;
    for (int index1 = 0; index1 < this._monster.sheets[0].list.Count; ++index1)
    {
      DataMonster.Param obj = this._monster.sheets[0].list[index1];
      MonsterData monsterData = new MonsterData();
      monsterData.sID = (short) obj.Index;
      monsterData.strController = obj.Controller;
      monsterData.strControllerAwk = obj.Controller2;
      monsterData.strName = obj.Name;
      monsterData.strDesc = obj.Desc;
      monsterData.strClass = obj.JobName;
      monsterData.strSprite = obj.Sprite;
      monsterData.strSpriteAwk = obj.Sprite2;
      monsterData.sStartItem = (short) obj.StartItem;
      monsterData.eNeedRebirth = (RebirthID) Enum.Parse(typeof (RebirthID), obj.NeedRbt);
      monsterData.eAwaken = (RebirthID) Enum.Parse(typeof (RebirthID), obj.AwkRebirth);
      monsterData.nNeedAcv = obj.NeedAcv;
      string[] strArray1 = obj.StartSkill.Split(',');
      monsterData.listSkill = new List<SkillKey>();
      for (int index2 = 0; index2 < strArray1.Length; ++index2)
        monsterData.listSkill.Add((SkillKey) Enum.Parse(typeof (SkillKey), strArray1[index2]));
      string[] strArray2 = obj.LearnSkill.Split(',');
      monsterData.listLearnSkill = new List<SkillKey>();
      for (int index2 = 0; index2 < strArray2.Length; ++index2)
        monsterData.listLearnSkill.Add((SkillKey) Enum.Parse(typeof (SkillKey), strArray2[index2]));
      string[] strArray3 = obj.AwkNeedSkill.Split(',');
      monsterData.listNeedSkill = new List<SkillKey>();
      for (int index2 = 0; index2 < strArray3.Length; ++index2)
        monsterData.listNeedSkill.Add((SkillKey) Enum.Parse(typeof (SkillKey), strArray3[index2]));
      string[] strArray4 = obj.AwkLearnSkill.Split(',');
      monsterData.listAwakenLearnSkill = new List<SkillKey>();
      for (int index2 = 0; index2 < strArray4.Length; ++index2)
        monsterData.listAwakenLearnSkill.Add((SkillKey) Enum.Parse(typeof (SkillKey), strArray4[index2]));
      monsterData.nPromoteMul = obj.PrmCost;
      monsterData.ePromoteSkillMain = (SkillKey) Enum.Parse(typeof (SkillKey), obj.PrmSkl1);
      monsterData.fPromoteMainFac = obj.PrmFac1;
      monsterData.fPromoteMainDmg = obj.PrmDmg1;
      monsterData.ePromoteSkillSub = (SkillKey) Enum.Parse(typeof (SkillKey), obj.PrmSkl2);
      monsterData.fPromoteSubFac = obj.PrmFac2;
      monsterData.fPromoteSubDmg = obj.PrmDmg2;
      BData.dictMonster.Add(monsterData.sID, monsterData);
    }
    for (int index = 0; index < this._enemy.sheets[0].list.Count; ++index)
    {
      DataEnemy.Param obj = this._enemy.sheets[0].list[index];
      EnemyData enemyData = new EnemyData();
      enemyData.sID = (short) obj.Index;
      enemyData.strController = obj.Controller;
      enemyData.eArmor = (ArmorType) Enum.Parse(typeof (ArmorType), obj.Armor);
      enemyData.eMove = (MoveType) Enum.Parse(typeof (MoveType), obj.Move);
      enemyData.bRange = (double) obj.Range > 0.0;
      enemyData.bCanBoss = obj.BeBoss;
      enemyData.bOnlyBoss = obj.OnlyBoss;
      enemyData.bUse = obj.Use;
      enemyData.fPow = obj.Power;
      enemyData.fAsp = obj.AttackRate;
      enemyData.fMinSpd = obj.SpeedMin;
      enemyData.fMaxSpd = obj.SpeedMax;
      enemyData.fMaxHP = (float) obj.HP;
      enemyData.fRange = obj.Range;
      enemyData.nFactor = obj.Factor;
      enemyData.nMinSpawn = obj.SpawnMin;
      enemyData.nMaxSpawn = obj.SpawnMax;
      BData.dictEnemy.Add(enemyData.sID, enemyData);
    }
    for (int index = 0; index < this._weapon.sheets[0].list.Count; ++index)
    {
      DataWeapon.Param obj = this._weapon.sheets[0].list[index];
      ItemData itemData = new ItemData();
      itemData.sID = (short) obj.Index;
      itemData.strName = obj.Name;
      itemData.strSprite = obj.Sprite;
      itemData.strBullet = obj.BulletSprite;
      itemData.fDmg = obj.Dmg;
      itemData.fRate = obj.FireRate;
      itemData.fReload = (float) obj.Reload;
      itemData.nSpread = obj.Spread;
      itemData.fvsArmor = obj.vsArmor;
      itemData.fvsMagic = obj.vsMagic;
      itemData.fAcc = obj.Acc;
      itemData.fSpd = obj.Speed;
      itemData.nDropMin = obj.DropMin;
      itemData.nDropMax = obj.DropMax;
      itemData.nAmmo = obj.Ammo;
      itemData.nPen = obj.Pen;
      itemData.bSpin = obj.Spin;
      itemData.fRange = obj.Range;
      itemData.eItem = (ItemType) Enum.Parse(typeof (ItemType), obj.ItemType);
      itemData.eTrail = (TrailType) Enum.Parse(typeof (TrailType), obj.Trail);
      itemData.eWeapon = (WeaponType) Enum.Parse(typeof (WeaponType), obj.Type);
      itemData.eMastery = (SkillKey) Enum.Parse(typeof (SkillKey), obj.Mastery);
      BData.dictWeapon.Add(itemData.sID, itemData);
    }
    for (int index = 0; index < this._skill.sheets[0].list.Count; ++index)
    {
      DataSkill.Param obj = this._skill.sheets[0].list[index];
      SkillData skillData = new SkillData();
      skillData.strName = obj.Name;
      skillData.strDesc = obj.Desc;
      skillData.strSummary = obj.Summary;
      skillData.strIcon = obj.Icon;
      skillData.eKey = (SkillKey) Enum.Parse(typeof (SkillKey), obj.Key);
      skillData.eType = (SkillType) Enum.Parse(typeof (SkillType), obj.Type);
      skillData.fFactor = obj.Factor;
      skillData.fGrow = obj.Scale;
      skillData.fFactor2 = obj.Fac2;
      skillData.fGrow2 = obj.Scale2;
      skillData.fGuage = obj.Guage;
      skillData.nMax = obj.Max;
      BData.dictSkill.Add(skillData.eKey, skillData);
    }
    for (int index = 0; index < this._dungeon.sheets[0].list.Count; ++index)
    {
      DataDungeon.Param obj = this._dungeon.sheets[0].list[index];
      DungeonData dungeonData = new DungeonData();
      dungeonData.eID = (DungeonType) Enum.Parse(typeof (DungeonType), obj.Index);
      dungeonData.strName = obj.Name;
      dungeonData.strDesc = obj.Desc;
      dungeonData.strIcon = obj.Icon;
      dungeonData.fBase = obj.Base;
      dungeonData.fGrow = obj.Grow;
      dungeonData.fCost = obj.Cost;
      dungeonData.fCostGrow = obj.CostGrow;
      dungeonData.fCostAdd = obj.CostAdd;
      dungeonData.fCostMul = obj.CostMul;
      dungeonData.nMax = obj.Max;
      BData.dictDungeon.Add(dungeonData.eID, dungeonData);
    }
    for (int index = 0; index < this._mod.sheets[0].list.Count; ++index)
    {
      DataMod.Param obj = this._mod.sheets[0].list[index];
      ModData modData = new ModData();
      modData.eID = (ModType) Enum.Parse(typeof (ModType), obj.Index);
      modData.strName = obj.Name;
      modData.strDesc = obj.Desc;
      modData.bUse = obj.Use;
      modData.fBase = obj.Base;
      modData.fGrow = obj.PerLv;
      modData.listTarget = new List<ItemType>();
      string target = obj.Target;
      char[] chArray = new char[1]{ ',' };
      foreach (string str in target.Split(chArray))
        modData.listTarget.Add((ItemType) Enum.Parse(typeof (ItemType), str));
      BData.dictMod.Add(modData.eID, modData);
    }
    for (int index = 0; index < this._mutation.sheets[0].list.Count; ++index)
    {
      DataMutation.Param obj = this._mutation.sheets[0].list[index];
      MutationData mutationData = new MutationData();
      mutationData.eID = (MutateType) Enum.Parse(typeof (MutateType), obj.Index);
      mutationData.strName = obj.Name;
      mutationData.strDesc = obj.Desc;
      mutationData.bBoss = obj.Boss;
      mutationData.bUse = obj.Use;
      mutationData.fFac1 = obj.Fac1;
      mutationData.fGrow1 = obj.Grow1;
      mutationData.fMax1 = obj.Max1;
      mutationData.fFac2 = obj.Fac2;
      mutationData.fGrow2 = obj.Grow2;
      mutationData.fMax2 = obj.Max2;
      BData.dictMutation.Add(mutationData.eID, mutationData);
      if (mutationData.bUse)
      {
        if (mutationData.bBoss)
          BData.listBossMutation.Add(mutationData.eID);
        else
          BData.listMutation.Add(mutationData.eID);
      }
    }
    for (int index = 0; index < this._achievement.sheets[0].list.Count; ++index)
    {
      DataAchievement.Param obj = this._achievement.sheets[0].list[index];
      AchievementData achievementData = new AchievementData();
      achievementData.eID = (AchievementType) Enum.Parse(typeof (AchievementType), obj.Index);
      achievementData.strName = obj.Name;
      achievementData.strDesc = obj.Desc;
      achievementData.eReward = (AcvRewardType) Enum.Parse(typeof (AcvRewardType), obj.RewardType);
      achievementData.nReward = obj.RewardFactor;
      BData.dictAcv.Add(achievementData.eID, achievementData);
    }
    for (int index = 0; index < this._research.sheets[0].list.Count; ++index)
    {
      DataResearch.Param obj = this._research.sheets[0].list[index];
      ResearchData researchData = new ResearchData();
      researchData.eID = (ResearchID) Enum.Parse(typeof (ResearchID), obj.Index);
      researchData.strName = obj.Name;
      researchData.strDesc = obj.Desc;
      researchData.strIcon = obj.Icon;
      researchData.fFactor = obj.Factor;
      researchData.nCost = obj.Cost;
      researchData.bRepeat = obj.Repeat;
      researchData.listPre = new List<ResearchID>();
      if (obj.PreLearn != "eNone")
      {
        string preLearn = obj.PreLearn;
        char[] chArray = new char[1]{ ',' };
        foreach (string str in preLearn.Split(chArray))
          researchData.listPre.Add((ResearchID) Enum.Parse(typeof (ResearchID), str));
      }
      BData.dictRsc.Add(researchData.eID, researchData);
    }
    for (int index = 0; index < this._rebirth.sheets[0].list.Count; ++index)
    {
      DataRebirth.Param obj = this._rebirth.sheets[0].list[index];
      RebirthData rebirthData = new RebirthData();
      rebirthData.eID = (RebirthID) Enum.Parse(typeof (RebirthID), obj.Index);
      rebirthData.strDesc = obj.Desc;
      rebirthData.bOnly = obj.Only;
      rebirthData.bLock = obj.Lock;
      rebirthData.eCurrency = (CurrencyType) Enum.Parse(typeof (CurrencyType), obj.Currency);
      rebirthData.nMax = obj.Max;
      rebirthData.fBase = obj.Base;
      rebirthData.fGrow = obj.Grow;
      rebirthData.fFactorial = obj.Factorial;
      rebirthData.nCost = obj.CostBase;
      rebirthData.nCostAdd = obj.CostAdd;
      rebirthData.nCostGrow = obj.CostGrow;
      BData.dictRebirth.Add(rebirthData.eID, rebirthData);
    }
    for (int index = 0; index < this._shop.sheets[0].list.Count; ++index)
    {
      DataShop.Param obj = this._shop.sheets[0].list[index];
      ShopData shopData = new ShopData();
      shopData.eID = (ShopID) Enum.Parse(typeof (ShopID), obj.Index);
      shopData.strName = obj.Name;
      shopData.strDesc = obj.Desc;
      shopData.bOnly = obj.Only;
      shopData.nBonus = obj.Bonus;
      BData.dictShop.Add(shopData.eID, shopData);
    }
    for (int index = 0; index < this._stone.sheets[0].list.Count; ++index)
    {
      DataStone.Param obj = this._stone.sheets[0].list[index];
      StoneData stoneData = new StoneData();
      stoneData.nDay = obj.Index;
      stoneData.nStone = new int[16];
      stoneData.nStone[0] = obj.Normal;
      stoneData.nStone[1] = obj.Easy;
      stoneData.nStone[2] = obj.Hard;
      stoneData.nStone[3] = obj.Insane;
      stoneData.nStone[4] = obj.End;
      stoneData.nStone[5] = obj.God;
      stoneData.nStone[6] = obj.Hell1;
      stoneData.nStone[7] = obj.Hell2;
      stoneData.nStone[8] = obj.Hell3;
      stoneData.nStone[9] = obj.Hell4;
      stoneData.nStone[10] = obj.Hell5;
      stoneData.nStone[11] = obj.Hell6;
      stoneData.nStone[12] = obj.Hell7;
      stoneData.nStone[13] = obj.Hell8;
      stoneData.nStone[14] = obj.Hell9;
      stoneData.nStone[15] = obj.Hell10;
      BData.dictStone.Add(stoneData.nDay, stoneData);
    }
    for (int index = 0; index < this._ruby.sheets[0].list.Count; ++index)
    {
      DataRuby.Param obj = this._ruby.sheets[0].list[index];
      RubyData rubyData = new RubyData();
      rubyData.nWave = obj.Index;
      rubyData.nRuby = new int[16];
      rubyData.nRuby[0] = Mathf.FloorToInt(obj.Normal);
      rubyData.nRuby[1] = Mathf.FloorToInt(obj.Easy);
      rubyData.nRuby[2] = Mathf.FloorToInt(obj.Hard);
      rubyData.nRuby[3] = Mathf.FloorToInt(obj.Insane);
      rubyData.nRuby[4] = Mathf.FloorToInt(obj.End);
      rubyData.nRuby[5] = Mathf.FloorToInt(obj.God);
      rubyData.nRuby[6] = Mathf.FloorToInt(obj.Hell1);
      rubyData.nRuby[7] = Mathf.FloorToInt(obj.Hell2);
      rubyData.nRuby[8] = Mathf.FloorToInt(obj.Hell3);
      rubyData.nRuby[9] = Mathf.FloorToInt(obj.Hell4);
      rubyData.nRuby[10] = Mathf.FloorToInt(obj.Hell5);
      rubyData.nRuby[11] = Mathf.FloorToInt(obj.Hell6);
      rubyData.nRuby[12] = Mathf.FloorToInt(obj.Hell7);
      rubyData.nRuby[13] = Mathf.FloorToInt(obj.Hell8);
      rubyData.nRuby[14] = Mathf.FloorToInt(obj.Hell9);
      rubyData.nRuby[15] = Mathf.FloorToInt(obj.Hell10);
      BData.dictRuby.Add(rubyData.nWave, rubyData);
    }
    for (int index = 0; index < this._quest.sheets[0].list.Count; ++index)
    {
      DataQuest.Param obj = this._quest.sheets[0].list[index];
      QuestData questData = new QuestData();
      questData.eID = (QuestID) Enum.Parse(typeof (QuestID), obj.Index);
      questData.strDesc = obj.Desc;
      questData.nMax = obj.Max;
      questData.nReward = obj.Reward;
      BData.dictQuest.Add(questData.eID, questData);
    }
    for (int index = 0; index < this._elemental.sheets[0].list.Count; ++index)
    {
      DataElemental.Param obj = this._elemental.sheets[0].list[index];
      ElementalData elementalData = new ElementalData();
      elementalData.eID = (ElementalID) Enum.Parse(typeof (ElementalID), obj.Index);
      elementalData.strName = obj.Name;
      elementalData.strDesc = obj.Desc;
      elementalData.strIcon = obj.Icon;
      elementalData.nDunLv = obj.DunLv;
      elementalData.nMaxLv = obj.MaxLv;
      elementalData.eNeed = (ElementalID) Enum.Parse(typeof (ElementalID), obj.PreNeed);
      elementalData.nNeed = obj.Need;
      elementalData.eElm = (Element) Enum.Parse(typeof (Element), obj.Elemental);
      elementalData.fBase1 = obj.Base;
      elementalData.fGrow1 = obj.Grow;
      elementalData.fBase2 = obj.Base2;
      elementalData.fGrow2 = obj.Grow2;
      elementalData.fBase3 = obj.Base3;
      elementalData.fGrow3 = obj.Grow3;
      BData.dictElemental.Add(elementalData.eID, elementalData);
    }
    for (int index = 0; index < this._trial.sheets[0].list.Count; ++index)
    {
      DataTrial.Param obj = this._trial.sheets[0].list[index];
      TrialData trialData = new TrialData();
      trialData.nFloor = obj.Floor;
      trialData.eID = (MutateType) Enum.Parse(typeof (MutateType), obj.Mutate);
      trialData.bDropRing = obj.Ring;
      trialData.nDay = obj.Day;
      trialData.fDropRate = obj.DropRate;
      trialData.nDropMin = obj.DropMin;
      trialData.nDropMax = obj.DropMax;
      trialData.dictMedal = new Dictionary<int, int>();
      trialData.dictMedal.Add(0, obj.Normal);
      trialData.dictMedal.Add(1, obj.Easy);
      trialData.dictMedal.Add(2, obj.Hard);
      trialData.dictMedal.Add(3, obj.Insane);
      trialData.dictMedal.Add(4, obj.End);
      trialData.dictMedal.Add(5, obj.God);
      trialData.dictMedal.Add(6, obj.Hell1);
      trialData.dictMedal.Add(7, obj.Hell2);
      trialData.dictMedal.Add(8, obj.Hell3);
      trialData.dictMedal.Add(9, obj.Hell4);
      trialData.dictMedal.Add(10, obj.Hell5);
      trialData.dictMedal.Add(11, obj.Hell6);
      trialData.dictMedal.Add(12, obj.Hell7);
      trialData.dictMedal.Add(13, obj.Hell8);
      trialData.dictMedal.Add(14, obj.Hell9);
      trialData.dictMedal.Add(15, obj.Hell10);
      BData.dictTrial.Add(trialData.nFloor, trialData);
    }
    for (int index = 0; index < this._acc.sheets[0].list.Count; ++index)
    {
      DataAccessory.Param obj = this._acc.sheets[0].list[index];
      AccData accData = new AccData();
      accData.sID = (short) obj.Index;
      accData.strName = obj.Name;
      accData.strSprite = obj.Sprite;
      accData.eDrop = (AccDropType) Enum.Parse(typeof (AccDropType), obj.DropType);
      accData.eType = (ItemType) Enum.Parse(typeof (ItemType), obj.Type);
      accData.eAchieve = (AchievementType) Enum.Parse(typeof (AchievementType), obj.Achieve);
      accData.bSell = obj.Sell;
      accData.nPrice = obj.Price;
      accData.sOnly = (short) obj.Only;
      accData.eStat1 = (ModType) Enum.Parse(typeof (ModType), obj.StatType1);
      accData.eStat2 = (ModType) Enum.Parse(typeof (ModType), obj.StatType2);
      accData.eStat3 = (ModType) Enum.Parse(typeof (ModType), obj.StatType3);
      accData.nGrade = obj.Grade;
      accData.fStat1 = obj.StatFac1;
      accData.fStat2 = obj.StatFac2;
      accData.fStat3 = obj.StatFac3;
      accData.fGrow1 = obj.StatGrow1;
      accData.fGrow2 = obj.StatGrow2;
      accData.fGrow3 = obj.StatGrow3;
      accData.eSpecial = (SkillKey) Enum.Parse(typeof (SkillKey), obj.SpecialSkill);
      BData.dictAcc.Add(accData.sID, accData);
    }
    for (int index1 = 0; index1 < this._string.sheets.Count; ++index1)
    {
      for (int index2 = 0; index2 < this._string.sheets[index1].list.Count; ++index2)
      {
        Strings.Param obj = this._string.sheets[index1].list[index2];
        BData.dictString.Add(obj.ID, new List<string>()
        {
          obj.Kor,
          obj.Eng,
          obj.Jpn,
          obj.Ger,
          obj.Rus,
          obj.zhCN,
          obj.zhTW,
          obj.Frc
        });
      }
    }
    BData.bLoaded = true;
  }

  public static MonsterData GetMonster(short sID)
  {
    return BData.dictMonster[sID];
  }

  public static EnemyData GetEnemy(short sID)
  {
    return BData.dictEnemy[sID];
  }

  public static ItemData GetWeapon(short sID)
  {
    return BData.dictWeapon[sID];
  }

  public static SkillData GetSkill(SkillKey eSkill)
  {
    return BData.dictSkill[eSkill];
  }

  public static DungeonData GetDungeon(DungeonType eID)
  {
    return BData.dictDungeon[eID];
  }

  public static AchievementData GetAchievement(AchievementType eID)
  {
    return BData.dictAcv[eID];
  }

  public static ModData GetMod(ModType eID)
  {
    return BData.dictMod[eID];
  }

  public static MutationData GetMutate(MutateType eID)
  {
    return BData.dictMutation[eID];
  }

  public static string GetString(string strName)
  {
    if (!BData.dictString.ContainsKey(strName))
      return strName;
    return BData.dictString[strName][Info.option.nLanguage];
  }

  public static List<short> GetRandomEnemy(int nDay)
  {
    List<short> shortList = new List<short>();
    List<EnemyData> enemyDataList = new List<EnemyData>((IEnumerable<EnemyData>) BData.dictEnemy.Values);
    for (int index = 0; index < enemyDataList.Count; ++index)
    {
      if (enemyDataList[index].nMinSpawn <= nDay && enemyDataList[index].nMaxSpawn >= nDay && (!enemyDataList[index].bOnlyBoss && enemyDataList[index].bUse))
        shortList.Add(enemyDataList[index].sID);
    }
    return shortList;
  }

  public static short GetRandomBoss(int nDay)
  {
    List<short> shortList = new List<short>();
    List<EnemyData> enemyDataList = new List<EnemyData>((IEnumerable<EnemyData>) BData.dictEnemy.Values);
    for (int index = 0; index < enemyDataList.Count; ++index)
    {
      if (enemyDataList[index].nMinSpawn <= nDay && enemyDataList[index].nMaxSpawn >= nDay && enemyDataList[index].bCanBoss && ((nDay < 50 ? 1 : (enemyDataList[index].bOnlyBoss ? 1 : 0)) != 0 && enemyDataList[index].bUse))
        shortList.Add(enemyDataList[index].sID);
    }
    return shortList[UnityEngine.Random.Range(0, shortList.Count)];
  }

  public static ResearchData GetResearch(ResearchID eID)
  {
    return BData.dictRsc[eID];
  }

  public static RebirthData GetRebirth(RebirthID eID)
  {
    return BData.dictRebirth[eID];
  }

  public static ShopData GetShop(ShopID eID)
  {
    return BData.dictShop[eID];
  }

  public static StoneData GetStone(int nDay)
  {
    return BData.dictStone[nDay];
  }

  public static RubyData GetRuby(int nWave)
  {
    return BData.dictRuby[nWave];
  }

  public static TrialData GetTrial(int nFloor)
  {
    return BData.dictTrial[nFloor];
  }

  public static AccData GetAccessory(short sID)
  {
    return BData.dictAcc[sID];
  }

  public static QuestData GetQuest(QuestID eID)
  {
    return BData.dictQuest[eID];
  }

  public static ElementalData GetElemental(ElementalID eID)
  {
    return BData.dictElemental[eID];
  }
}
