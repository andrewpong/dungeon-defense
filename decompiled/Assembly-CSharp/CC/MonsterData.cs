// Decompiled with JetBrains decompiler
// Type: CC.MonsterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

namespace CC
{
  public class MonsterData
  {
    public short sID;
    public string strName;
    public string strDesc;
    public string strClass;
    public string strController;
    public string strControllerAwk;
    public string strSprite;
    public string strSpriteAwk;
    public RebirthID eAwaken;
    public short sStartItem;
    public int nNeedAcv;
    public RebirthID eNeedRebirth;
    public List<SkillKey> listSkill;
    public List<SkillKey> listLearnSkill;
    public List<SkillKey> listNeedSkill;
    public List<SkillKey> listAwakenLearnSkill;
    public int nPromoteMul;
    public SkillKey ePromoteSkillMain;
    public SkillKey ePromoteSkillSub;
    public float fPromoteMainFac;
    public float fPromoteMainDmg;
    public float fPromoteSubFac;
    public float fPromoteSubDmg;
  }
}
