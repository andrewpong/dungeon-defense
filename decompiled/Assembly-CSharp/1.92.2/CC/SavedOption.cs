﻿// Decompiled with JetBrains decompiler
// Type: CC.SavedOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;

namespace CC
{
  [Serializable]
  public class SavedOption
  {
    public float fMusic = 0.8f;
    public float fSound = 0.8f;
    public List<DungeonType> listAutoBuildOrder = new List<DungeonType>();
    public List<int> listAutoBuildCount = new List<int>();
    public int nBuildRepeat = 1;
    public List<ResearchID> listResearchOrder = new List<ResearchID>();
    public bool bReview;
    public bool bSelectLang;
    public int nLanguage;
    public bool bAutoBattle;
    public bool bDoubleSpeed;
    public bool bAutoLogin;
    public bool bFastSpawn;
    public bool bLeftSpecial;
    public bool bOptimize;
    public bool bCriFlashOff;
    public bool bHideDamageOutput;
    public bool bAutoResearch;
    public bool bAutoItemSell;
    public bool bAutoSkillSelect;
    public bool bAutoItemEnchant;
    public bool bAutoSkill;
    public bool bAutoRepair;
    public bool bAutoBattleStart;
    public bool bAutoItemManage;
    public bool bShowWeaponSell;
    public bool bShowWeaponPurchase;
    public bool bShowWeaponMod;
    public bool bShowWeaponEnchant;
    public bool bShowAccSell;
    public bool bShowAccEnchant;
    public byte byAutoEnchantType;
    public byte byAutoItemSellType;
    public bool bMuteMusic;
    public bool bMuteSound;
    public bool bAIBuild;
    public bool bQuickOver;
    public byte byItemFilter;
    public bool bAllFXOff;
    public byte byAutoResearchType;
  }
}
