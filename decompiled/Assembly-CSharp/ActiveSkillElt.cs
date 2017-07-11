// Decompiled with JetBrains decompiler
// Type: ActiveSkillElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class ActiveSkillElt : MonoBehaviour
{
  public Image imgIcon;
  public Image imgCool;
  public Image imgHighlight;
  private int nPos;
  private float fMax;
  private float fTime;
  private SkillKey eSkill;

  private bool bActive
  {
    get
    {
      return this.imgIcon.enabled;
    }
    set
    {
      this.imgIcon.enabled = value;
      this.imgCool.enabled = value;
      this.imgHighlight.enabled = false;
    }
  }

  public void SetSkill(int _nPos, SkillKey _eSkill)
  {
    this.nPos = _nPos;
    this.eSkill = _eSkill;
    if (this.eSkill == SkillKey.eNone)
    {
      this.bActive = false;
    }
    else
    {
      SkillData skill = BData.GetSkill(this.eSkill);
      this.imgIcon.sprite = RSMgr.GetSprite(skill.strIcon);
      this.bActive = true;
      this.fMax = skill.fGuage;
    }
  }

  private void ActiveElt(bool bEnable)
  {
    this.bActive = bEnable;
    this.imgIcon.enabled = bEnable;
    this.imgCool.enabled = bEnable;
    this.imgHighlight.enabled = bEnable;
  }

  public void UpdateGuage(float fG, bool bUpdate, bool bAuto = false)
  {
    if (!this.bActive)
      return;
    if (PageBattle.obj.eTrial == MutateType.eSanctuary)
      fG = 0.0f;
    if (bUpdate)
      fG *= (float) ((1.0 + (double) Info.GetPartySkillFac(SkillKey.eCheer) * 0.00999999977648258) * (1.0 + (double) Info.GetResearchFac(ResearchID.eMeditate) * 0.00999999977648258) * (1.0 + (double) Info.GetAccModFac(this.nPos, ModType.eSpecial) * 0.00999999977648258));
    float num;
    if (Info.eBattle == BattleType.eSurvial)
    {
      PlayerMonsterData playerMon = Info.GetPlayerMon(this.nPos);
      ObscuredFloat obscuredFloat1;
      ObscuredFloat obscuredFloat2 = obscuredFloat1 = (ObscuredFloat) ((float) playerMon.fActive + fG);
      playerMon.fActive = obscuredFloat1;
      num = (float) obscuredFloat2;
    }
    else
    {
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      ObscuredFloat& local = @Info.fTrialCharge[this.nPos];
      ObscuredFloat obscuredFloat1;
      // ISSUE: explicit reference operation
      ObscuredFloat obscuredFloat2 = obscuredFloat1 = (ObscuredFloat) ((float) (^local) + fG);
      // ISSUE: explicit reference operation
      ^local = obscuredFloat1;
      num = (float) obscuredFloat2;
    }
    this.imgCool.fillAmount = 1f - Mathf.Clamp(num / this.fMax, 0.0f, 1f);
    this.imgIcon.color = (double) this.imgCool.fillAmount != 0.0 ? Color.gray : Color.white;
    this.imgHighlight.enabled = (double) this.imgCool.fillAmount == 0.0;
    if (!bAuto || (double) this.imgCool.fillAmount != 0.0 || (!Info.option.bAutoSkill || !PageBattle.obj.CanUseAutoSkill()))
      return;
    this.OnClick();
  }

  public void OnClick()
  {
    if (!this.bActive || Info.eBattle == BattleType.eSurvial && (double) (float) Info.GetPlayerMon(this.nPos).fActive < (double) this.fMax || (Info.eBattle == BattleType.eTrial && (double) (float) Info.fTrialCharge[this.nPos] < (double) this.fMax || Info.eBattle == BattleType.eEndless && (double) (float) Info.fTrialCharge[this.nPos] < (double) this.fMax))
      return;
    PageBattle.obj.OnActiveSkill(this.nPos, this.eSkill);
  }

  public void OnUsed()
  {
    if (Info.eBattle == BattleType.eSurvial)
      Info.GetPlayerMon(this.nPos).fActive = (ObscuredFloat) 0.0f;
    else
      Info.fTrialCharge[this.nPos] = (ObscuredFloat) 0.0f;
    this.UpdateGuage(0.0f, false, false);
  }
}
