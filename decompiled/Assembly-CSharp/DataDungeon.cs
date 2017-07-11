// Decompiled with JetBrains decompiler
// Type: DataDungeon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
