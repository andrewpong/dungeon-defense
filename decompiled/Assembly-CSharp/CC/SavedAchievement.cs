// Decompiled with JetBrains decompiler
// Type: CC.SavedAchievement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;

namespace CC
{
  [Serializable]
  public class SavedAchievement
  {
    public ObscuredInt nEnchant = (ObscuredInt) 0;
    public List<AchievementType> listAcv = new List<AchievementType>();
    public ObscuredInt nAwaken = (ObscuredInt) 0;
  }
}
