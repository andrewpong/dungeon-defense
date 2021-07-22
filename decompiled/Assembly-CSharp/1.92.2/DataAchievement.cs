// Decompiled with JetBrains decompiler
// Type: DataAchievement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataAchievement : ScriptableObject
{
  public List<DataAchievement.Sheet> sheets = new List<DataAchievement.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataAchievement.Param> list = new List<DataAchievement.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Name;
    public string Desc;
    public string RewardType;
    public int RewardFactor;
  }
}
