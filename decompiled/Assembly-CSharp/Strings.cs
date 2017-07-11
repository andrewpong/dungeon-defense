// Decompiled with JetBrains decompiler
// Type: Strings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class Strings : ScriptableObject
{
  public List<Strings.Sheet> sheets = new List<Strings.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<Strings.Param> list = new List<Strings.Param>();
  }

  [Serializable]
  public class Param
  {
    public string ID;
    public string Kor;
    public string Jpn;
    public string Eng;
    public string Ger;
    public string Rus;
    public string zhCN;
    public string zhTW;
    public string Frc;
  }
}
