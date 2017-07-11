// Decompiled with JetBrains decompiler
// Type: DataElemental
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataElemental : ScriptableObject
{
  public List<DataElemental.Sheet> sheets = new List<DataElemental.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataElemental.Param> list = new List<DataElemental.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Name;
    public string Desc;
    public string Icon;
    public string Elemental;
    public string PreNeed;
    public int DunLv;
    public int Need;
    public int MaxLv;
    public float Base;
    public float Grow;
    public float Base2;
    public float Grow2;
    public float Base3;
    public float Grow3;
  }
}
