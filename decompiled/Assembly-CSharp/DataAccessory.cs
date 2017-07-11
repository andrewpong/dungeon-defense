// Decompiled with JetBrains decompiler
// Type: DataAccessory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataAccessory : ScriptableObject
{
  public List<DataAccessory.Sheet> sheets = new List<DataAccessory.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataAccessory.Param> list = new List<DataAccessory.Param>();
  }

  [Serializable]
  public class Param
  {
    public int Index;
    public string Name;
    public string Sprite;
    public string Type;
    public int Only;
    public string DropType;
    public string Achieve;
    public bool Sell;
    public int Price;
    public int Grade;
    public string StatType1;
    public float StatFac1;
    public float StatGrow1;
    public string StatType2;
    public float StatFac2;
    public float StatGrow2;
    public string StatType3;
    public float StatFac3;
    public float StatGrow3;
    public string SpecialSkill;
  }
}
