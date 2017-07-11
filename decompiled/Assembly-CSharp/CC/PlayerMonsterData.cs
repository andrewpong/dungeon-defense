// Decompiled with JetBrains decompiler
// Type: CC.PlayerMonsterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;

namespace CC
{
  [Serializable]
  public class PlayerMonsterData
  {
    public ObscuredShort sID = (ObscuredShort) (short) -1;
    public ObscuredInt nLv = (ObscuredInt) 1;
    public ObscuredInt nExp = (ObscuredInt) 0;
    public Dictionary<SkillKey, ObscuredInt> dictSkill = new Dictionary<SkillKey, ObscuredInt>();
    public ObscuredLong nEquip = (ObscuredLong) -1L;
    public ObscuredLong nAmulet = (ObscuredLong) -1L;
    public ObscuredFloat fActive = (ObscuredFloat) 0.0f;
    public ObscuredLong nRing = (ObscuredLong) -1L;
    public ObscuredBool bAwaken = (ObscuredBool) false;
    public ObscuredBool bFocused = (ObscuredBool) false;
    public SkillKey eFocusedSkill = SkillKey.eNone;
    public byte byBatch;
  }
}
