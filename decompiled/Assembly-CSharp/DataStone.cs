// Decompiled with JetBrains decompiler
// Type: DataStone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataStone : ScriptableObject
{
  public List<DataStone.Sheet> sheets = new List<DataStone.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataStone.Param> list = new List<DataStone.Param>();
  }

  [Serializable]
  public class Param
  {
    public int Index;
    public int Normal;
    public int Easy;
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
    public int Mul;
  }
}
