// Decompiled with JetBrains decompiler
// Type: DataResearch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
