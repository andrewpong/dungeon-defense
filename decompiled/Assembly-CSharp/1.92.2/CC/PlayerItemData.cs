﻿// Decompiled with JetBrains decompiler
// Type: CC.PlayerItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CodeStage.AntiCheat.ObscuredTypes;
using System;

namespace CC
{
  [Serializable]
  public class PlayerItemData
  {
    public ObscuredLong UID = (ObscuredLong) 0L;
    public ObscuredShort sID = (ObscuredShort) (short) -1;
    public ObscuredInt nLv = (ObscuredInt) 1;
    public ObscuredFloat fPower = (ObscuredFloat) 1f;
    public ObscuredByte byGrade = (ObscuredByte) (byte) 0;
    public ObscuredInt nMod = (ObscuredInt) 0;
    public ItemModData[] arrMod = new ItemModData[6];
    public ObscuredBool bProtected = (ObscuredBool) false;
  }
}
