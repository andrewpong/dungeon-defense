// Decompiled with JetBrains decompiler
// Type: CC.ItemModData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
