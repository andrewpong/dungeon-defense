// Decompiled with JetBrains decompiler
// Type: CC.ItemModData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using System;

namespace CC
{
  [Serializable]
  public class ItemModData
  {
    public ModType eMod = ModType.eNone;
    public ObscuredInt nModLevel = (ObscuredInt) 0;
    public ObscuredFloat fBonus = (ObscuredFloat) 1f;

    public float fFactor
    {
      get
      {
        return (BData.GetMod(this.eMod).fBase + BData.GetMod(this.eMod).fGrow * (float) (int) this.nModLevel) * (float) this.fBonus;
      }
    }
  }
}
