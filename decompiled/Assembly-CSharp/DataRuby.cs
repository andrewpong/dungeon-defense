// Decompiled with JetBrains decompiler
// Type: DataRuby
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataRuby : ScriptableObject
{
  public List<DataRuby.Sheet> sheets = new List<DataRuby.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataRuby.Param> list = new List<DataRuby.Param>();
  }

  [Serializable]
  public class Param
  {
    public int Index;
    public float Normal;
    public float Easy;
    public float Hard;
    public float Insane;
    public float End;
    public float God;
    public float Hell1;
    public float Hell2;
    public float Hell3;
    public float Hell4;
    public float Hell5;
    public float Hell6;
    public float Hell7;
    public float Hell8;
    public float Hell9;
    public float Hell10;
    public float Mul;
  }
}
