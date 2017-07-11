// Decompiled with JetBrains decompiler
// Type: DataDungeon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataDungeon : ScriptableObject
{
  public List<DataDungeon.Sheet> sheets = new List<DataDungeon.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataDungeon.Param> list = new List<DataDungeon.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Name;
    public string Desc;
    public string Icon;
    public float Base;
    public float Grow;
    public int Max;
    public float Cost;
    public float CostGrow;
    public float CostMul;
    public float CostAdd;
  }
}
