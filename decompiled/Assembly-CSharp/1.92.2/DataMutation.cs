// Decompiled with JetBrains decompiler
// Type: DataMutation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataMutation : ScriptableObject
{
  public List<DataMutation.Sheet> sheets = new List<DataMutation.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataMutation.Param> list = new List<DataMutation.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Name;
    public string Desc;
    public bool Boss;
    public bool Use;
    public float Fac1;
    public float Grow1;
    public float Max1;
    public float Fac2;
    public float Grow2;
    public float Max2;
  }
}
