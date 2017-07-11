// Decompiled with JetBrains decompiler
// Type: CC.PlayerAccData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CodeStage.AntiCheat.ObscuredTypes;
using System;

namespace CC
{
  [Serializable]
  public class PlayerAccData
  {
    public ObscuredLong UID = (ObscuredLong) 0L;
    public ObscuredShort sID = (ObscuredShort) (short) -1;
    public ObscuredInt nLv = (ObscuredInt) 0;
    public ObscuredBool bProtected = (ObscuredBool) false;
    public ObscuredInt nSpecial = (ObscuredInt) 0;
  }
}
