// Decompiled with JetBrains decompiler
// Type: CC.MonsterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
