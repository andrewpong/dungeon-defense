// Decompiled with JetBrains decompiler
// Type: DataMonster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataMonster : ScriptableObject
{
  public List<DataMonster.Sheet> sheets = new List<DataMonster.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataMonster.Param> list = new List<DataMonster.Param>();
  }

  [Serializable]
  public class Param
  {
    public int Index;
    public string Controller;
    public string Controller2;
    public string Sprite;
    public string Sprite2;
    public string AwkRebirth;
    public string Name;
    public string JobName;
    public string Desc;
    public int StartItem;
    public int NeedAcv;
    public string NeedRbt;
    public string AwkNeedSkill;
    public string StartSkill;
    public string LearnSkill;
    public string AwkLearnSkill;
    public int PrmCost;
    public string PrmSkl1;
    public float PrmFac1;
    public float PrmDmg1;
    public string PrmSkl2;
    public float PrmFac2;
    public float PrmDmg2;
  }
}
