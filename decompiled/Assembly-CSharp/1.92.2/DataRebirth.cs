﻿// Decompiled with JetBrains decompiler
// Type: DataRebirth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataRebirth : ScriptableObject
{
  public List<DataRebirth.Sheet> sheets = new List<DataRebirth.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataRebirth.Param> list = new List<DataRebirth.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Desc;
    public bool Only;
    public bool Lock;
    public string Currency;
    public float Base;
    public float Grow;
    public float Factorial;
    public int Max;
    public int CostBase;
    public int CostAdd;
    public int CostGrow;
  }
}
