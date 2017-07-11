// Decompiled with JetBrains decompiler
// Type: DataSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataSkill : ScriptableObject
{
  public List<DataSkill.Sheet> sheets = new List<DataSkill.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataSkill.Param> list = new List<DataSkill.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Key;
    public string Name;
    public string Desc;
    public string Summary;
    public string Type;
    public string Icon;
    public float Factor;
    public float Scale;
    public float Fac2;
    public float Scale2;
    public int Max;
    public float Guage;
  }
}
