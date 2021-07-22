// Decompiled with JetBrains decompiler
// Type: AwakenSkillElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class AwakenSkillElt : MonoBehaviour
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
      this.fMax = skill.fGuage * (float) (1.0 - (double) Info.GetResearchFac(ResearchID.eAwakenSkill) * 0.00999999977648258);
    }
  }

  private void ActiveElt(bool bEnable)
  {
    this.bActive = bEnable;
    this.imgIcon.enabled = bEnable;
    this.imgCool.enabled = bEnable;
    this.imgHighlight.enabled = bEnable;
  }

  public void UpdateGuage(float fG)
  {
    if (!this.bActive)
      return;
    float num;
    if (Info.eBattle == BattleType.eSurvial)
    {
      SavedData currentSave = Info.currentSave;
      ObscuredFloat obscuredFloat1;
      ObscuredFloat obscuredFloat2 = obscuredFloat1 = (ObscuredFloat) ((float) currentSave.fAwakenCharge + fG);
      currentSave.fAwakenCharge = obscuredFloat1;
      num = (float) obscuredFloat2;
    }
    else
      num = (float) (Info.fTrialAwakenCharge = (ObscuredFloat) ((float) Info.fTrialAwakenCharge + fG));
    this.imgCool.fillAmount = 1f - Mathf.Clamp(num / this.fMax, 0.0f, 1f);
    this.imgIcon.color = (double) this.imgCool.fillAmount != 0.0 ? Color.gray : Color.white;
    this.imgHighlight.enabled = (double) this.imgCool.fillAmount == 0.0;
    if ((double) this.imgCool.fillAmount != 0.0 || !Info.option.bAutoSkill || !PageBattle.obj.CanUseAutoSkill())
      return;
    this.OnClick();
  }

  public void OnClick()
  {
    if (!this.bActive || Info.eBattle == BattleType.eSurvial && (double) (float) Info.currentSave.fAwakenCharge < (double) this.fMax || (Info.eBattle == BattleType.eTrial && (double) (float) Info.fTrialAwakenCharge < (double) this.fMax || Info.eBattle == BattleType.eEndless && (double) (float) Info.fTrialAwakenCharge < (double) this.fMax))
      return;
    PageBattle.obj.OnAwakenSkill(this.nPos, this.eSkill, this);
  }

  public void OnUsed()
  {
    if (Info.eBattle == BattleType.eSurvial)
      Info.currentSave.fAwakenCharge = (ObscuredFloat) 0.0f;
    else
      Info.fTrialAwakenCharge = (ObscuredFloat) 0.0f;
    this.UpdateGuage(0.0f);
  }
}
