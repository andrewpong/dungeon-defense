// Decompiled with JetBrains decompiler
// Type: DataEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataEnemy : ScriptableObject
{
  public List<DataEnemy.Sheet> sheets = new List<DataEnemy.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataEnemy.Param> list = new List<DataEnemy.Param>();
  }

  [Serializable]
  public class Param
  {
    public int Index;
    public string Controller;
    public string Armor;
    public string Move;
    public int Exp;
    public int Factor;
    public float Power;
    public float AttackRate;
    public float SpeedMin;
    public float SpeedMax;
    public int HP;
    public float Range;
    public int SpawnMin;
    public int SpawnMax;
    public bool Use;
    public bool BeBoss;
    public bool OnlyBoss;
  }
}
