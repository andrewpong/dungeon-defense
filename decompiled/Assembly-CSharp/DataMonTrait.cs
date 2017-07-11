﻿// Decompiled with JetBrains decompiler
// Type: DataMonTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataMonTrait : ScriptableObject
{
  public List<DataMonTrait.Sheet> sheets = new List<DataMonTrait.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataMonTrait.Param> list = new List<DataMonTrait.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Name;
    public string Desc;
    public string Icon;
    public int Max;
    public float Fac1;
    public float Grow1;
    public float Fac2;
    public float Grow2;
    public float Fac3;
    public float Grow3;
  }
}