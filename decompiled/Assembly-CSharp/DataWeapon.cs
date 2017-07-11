// Decompiled with JetBrains decompiler
// Type: DataWeapon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class DataWeapon : ScriptableObject
{
  public List<DataWeapon.Sheet> sheets = new List<DataWeapon.Sheet>();

  [Serializable]
  public class Sheet
  {
    public string name = string.Empty;
    public List<DataWeapon.Param> list = new List<DataWeapon.Param>();
  }

  [Serializable]
  public class Param
  {
    public int Index;
    public string Name;
    public string ItemType;
    public string Sprite;
    public string BulletSprite;
    public string Type;
    public string Trail;
    public string Mastery;
    public int DropMin;
    public int DropMax;
    public int Grade;
    public float Dmg;
    public float FireRate;
    public int Ammo;
    public int Reload;
    public float Speed;
    public int Spread;
    public float vsArmor;
    public float vsMagic;
    public float Acc;
    public int Pen;
    public bool Spin;
    public float Range;
  }
}
