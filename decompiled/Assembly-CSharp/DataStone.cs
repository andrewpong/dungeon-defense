// Decompiled with JetBrains decompiler
// Type: DataStone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
    public double Normal;
    public double Easy;
    public double Hard;
    public double Insane;
    public double End;
    public double God;
    public double Hell1;
    public double Hell2;
    public double Hell3;
    public double Hell4;
    public double Hell5;
    public double Hell6;
    public double Hell7;
    public double Hell8;
    public double Hell9;
    public double Hell10;
    public double Hell11;
    public double Hell12;
    public double Hell13;
    public double Hell14;
    public double Hell15;
    public double Mul;
  }
}
