// Decompiled with JetBrains decompiler
// Type: DataMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
