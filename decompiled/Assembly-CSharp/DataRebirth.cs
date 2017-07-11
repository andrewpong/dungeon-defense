// Decompiled with JetBrains decompiler
// Type: DataRebirth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
