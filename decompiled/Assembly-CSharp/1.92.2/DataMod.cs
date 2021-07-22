// Decompiled with JetBrains decompiler
// Type: DataMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataMod : ScriptableObject
{
  public List<DataMod.Sheet> sheets = new List<DataMod.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataMod.Param> list = new List<DataMod.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Name;
    public string Desc;
    public string Target;
    public bool Use;
    public float Base;
    public float PerLv;
  }
}
