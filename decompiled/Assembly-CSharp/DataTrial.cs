// Decompiled with JetBrains decompiler
// Type: DataTrial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataTrial : ScriptableObject
{
  public List<DataTrial.Sheet> sheets = new List<DataTrial.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataTrial.Param> list = new List<DataTrial.Param>();
  }

  [Serializable]
  public class Param
  {
    public int Floor;
    public string Mutate;
    public int Day;
    public bool Ring;
    public int DropMin;
    public int DropMax;
    public float DropRate;
    public int Easy;
    public int Normal;
    public int Hard;
    public int Insane;
    public int End;
    public int God;
    public int Hell1;
    public int Hell2;
    public int Hell3;
    public int Hell4;
    public int Hell5;
    public int Hell6;
    public int Hell7;
    public int Hell8;
    public int Hell9;
    public int Hell10;
  }
}
