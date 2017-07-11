// Decompiled with JetBrains decompiler
// Type: PopupMercenarySkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMercenarySkill : UIPage
{
  public Image imgMon;
  public CharSkillElt[] arrSkillElt;
  public static PopupMercenarySkill obj;

  protected override void Awake()
  {
    base.Awake();
    PopupMercenarySkill.obj = this;
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void OnClose()
  {
    UIMgr.PlaySound("Negative", false);
    UIMgr.RemoveTop();
  }

  public void ShowSkill(PlayerMonsterData pData)
  {
    MonsterData monster = BData.GetMonster((short) pData.sID);
    this.imgMon.sprite = RSMgr.GetSprite(!Info.isAwaken(pData) ? monster.strSprite : monster.strSpriteAwk);
    List<SkillKey> skillKeyList1 = new List<SkillKey>((IEnumerable<SkillKey>) pData.dictSkill.Keys);
    List<SkillKey> skillKeyList2 = new List<SkillKey>((IEnumerable<SkillKey>) monster.listLearnSkill);
    skillKeyList2.AddRange((IEnumerable<SkillKey>) monster.listAwakenLearnSkill);
    skillKeyList1.Sort();
    skillKeyList1.Reverse();
    int index1 = 0;
    for (int index2 = 0; index2 < skillKeyList1.Count; ++index2)
    {
      this.arrSkillElt[index1].gameObject.SetActive(true);
      this.arrSkillElt[index1].SetSkillElt(skillKeyList1[index2], Info.GetSkill(pData, skillKeyList1[index2], false), monster.listAwakenLearnSkill.Contains(skillKeyList1[index2]), false);
      skillKeyList2.Remove(skillKeyList1[index2]);
      ++index1;
    }
    for (int index2 = 0; index2 < skillKeyList2.Count; ++index2)
    {
      this.arrSkillElt[index1].gameObject.SetActive(true);
      this.arrSkillElt[index1].SetSkillElt(skillKeyList2[index2], Info.GetSkill(pData, skillKeyList2[index2], false), monster.listAwakenLearnSkill.Contains(skillKeyList2[index2]), false);
      ++index1;
    }
    for (; index1 < this.arrSkillElt.Length; ++index1)
      this.arrSkillElt[index1].gameObject.SetActive(false);
  }
}
