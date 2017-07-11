// Decompiled with JetBrains decompiler
// Type: CC.PlayerAccData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
