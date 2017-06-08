// Decompiled with JetBrains decompiler
// Type: CC.SavedAchievement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
