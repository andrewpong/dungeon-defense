// Decompiled with JetBrains decompiler
// Type: DataQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataQuest : ScriptableObject
{
  public List<DataQuest.Sheet> sheets = new List<DataQuest.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataQuest.Param> list = new List<DataQuest.Param>();
  }

  [Serializable]
  public class Param
  {
    public string Index;
    public string Desc;
    public int Max;
    public int Reward;
  }
}
