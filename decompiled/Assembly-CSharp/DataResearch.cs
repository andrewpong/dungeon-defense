// Decompiled with JetBrains decompiler
// Type: DataResearch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataResearch : ScriptableObject
{
  public List<DataResearch.Sheet> sheets = new List<DataResearch.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataResearch.Param> list = new List<DataResearch.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Name;
    public string Desc;
    public string Icon;
    public string PreLearn;
    public int Cost;
    public float Factor;
    public bool Repeat;
  }
}
