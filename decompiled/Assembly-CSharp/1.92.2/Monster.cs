// Decompiled with JetBrains decompiler
// Type: Monster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof (SpriteRenderer))]
public class Monster : MonoBehaviour
{
  private static float fMaxRecoil = 30f;
  private static float fMinRecoil = 3f;
  private static float fIncRecoil = 1f;
  public ObscuredInt nCharge = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredFloat fRecoil = (ObscuredFloat) 3f;
  [HideInInspector]
  public ObscuredFloat fFrenzyBonus = (ObscuredFloat) 1f;
  private ObscuredFloat fRdcRecoil = (ObscuredFloat) -12f;
  private float fAddRecoil = 3f;
  private ObscuredFloat fCri = (ObscuredFloat) 5f;
  private ObscuredFloat fCriDmg = (ObscuredFloat) 2f;
  private float fRageGetBonus = 1f;
  private ObscuredInt nAssCnt = (ObscuredInt) 0;
  private ObscuredInt nRicCnt = (ObscuredInt) 0;
  private ObscuredInt nCriCnt = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustMultishot = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustBigshot = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustFireball = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustFirelance = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustRandomDmg = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustRicochet = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustSoulBall = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustStrongKick = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustTripleSword = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustSubLaser = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustCri = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustFrost = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustBigSlash = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustChain = (ObscuredInt) 0;
  [HideInInspector]
  public ObscuredInt nMustElementalExposion = (ObscuredInt) 0;
  public SpriteRenderer reload;
  public SpriteRenderer reloadBack;
  public SpriteRenderer sprite;
  public GameObject goAtkBuff;
  public GameObject goAspBuff;
  public GameObject goReloadBuff;
  public GameObject goDarkBuff;
  [HideInInspector]
  public short sWeapon;
  [HideInInspector]
  public long nEquip;
  [HideInInspector]
  public bool bNPC;
  [HideInInspector]
  public ObscuredInt nAmmo;
  [HideInInspector]
  public ObscuredInt nMaxAmmo;
  [HideInInspector]
  public Enemy target;
  [HideInInspector]
  public ObscuredFloat fCool;
  [HideInInspector]
  public ObscuredFloat fAccBonus;
  [HideInInspector]
  public double fDmgDealt;
  public ParticleElt psRage;
  public ParticleElt psWarcry;
  public ParticleElt psSwift;
  public ParticleElt psConcen;
  private ObscuredFloat fAtkBonus;
  private ObscuredFloat fAfterAtkBonus;
  private ObscuredFloat fRageAtkBonus;
  private ObscuredFloat fAspBonus;
  private ObscuredFloat fAfterAspBonus;
  private ObscuredFloat fRageAspBonus;
  private ObscuredFloat fReloadBonus;
  private ObscuredFloat fRageReloadBonus;
  [HideInInspector]
  public ObscuredFloat fRange;
  [HideInInspector]
  public short sID;
  [HideInInspector]
  public int nPos;
  private Animator animator;
  private float fTime;
  private float fRageChg;
  private float fRageDur;
  private float fReloadBuffTime;
  private float fSwiftBuffTime;
  private float fSwiftFactor;
  private float fWarcryBuffTime;
  private float fWarcryFactor;
  private float fDarkBuffTime;
  private float fDarkFactor;
  private float fRageCriRate;
  private float fRageCriDmg;
  private WeaponType eWeapon;
  private bool bReload;
  private Coroutine cr;
  private float fStunTime;
  private float fStunDur;
  private Coroutine crStun;

  public PlayerMonsterData pData
  {
    get
    {
      return Info.GetPlayerMon(this.nPos);
    }
  }

  public bool bRage
  {
    get
    {
      return (double) this.fRageDur > 0.0;
    }
  }

  public float fRage
  {
    get
    {
      return this.fRageChg;
    }
    set
    {
      this.fRageChg = value;
      if ((double) this.fRageChg < 60.0)
        return;
      this.OnRageStart();
    }
  }

  public float fFixAtkBonus
  {
    get
    {
      return (float) ((double) (float) this.fAtkBonus * (1.0 + (double) (float) this.fRageAtkBonus) * (1.0 + (double) this.fWarcryFactor) * (1.0 + (double) this.fDarkFactor)) * (float) this.fAfterAtkBonus;
    }
  }

  public float fFixAspBonus
  {
    get
    {
      return ((float) this.fAspBonus + this.fSwiftFactor + (float) this.fRageAspBonus) * (float) this.fAfterAspBonus;
    }
  }

  public float fFixReloadBonus
  {
    get
    {
      return (float) this.fReloadBonus + this.fSwiftFactor + (float) this.fRageReloadBonus;
    }
  }

  public bool bInstantReload
  {
    get
    {
      return (double) this.fReloadBuffTime > 0.0;
    }
  }

  public float fCriRate
  {
    get
    {
      return (float) ((double) (float) this.fCri + (!this.bRage ? 0.0 : (double) this.fRageCriRate + (double) Info.GetPartySkillFac(SkillKey.eRageCrit)) - (double) PageBattle.GetMutation1(MutateType.eCriDown) + ((int) this.nMustCri <= 0 ? 0.0 : 500.0));
    }
  }

  public float fFixCriDmg
  {
    get
    {
      return (float) this.fCriDmg + (!this.bRage ? 0.0f : this.fRageCriDmg);
    }
  }

  public bool isLaser
  {
    get
    {
      return this.eWeapon == WeaponType.eMonster;
    }
  }

  public bool canShoot
  {
    get
    {
      return (double) this.fTime >= (double) (float) this.fCool;
    }
  }

  public int nAtkTime
  {
    get
    {
      int num = 0;
      while ((double) this.fTime >= (double) (float) this.fCool)
      {
        this.fTime -= (float) this.fCool;
        ++num;
      }
      return num;
    }
  }

  public bool isStun
  {
    get
    {
      return (double) this.fStunTime < (double) this.fStunDur;
    }
  }

  public bool isReloading
  {
    get
    {
      return this.bReload;
    }
  }

  public float fAssinatePower
  {
    get
    {
      return Mathf.Min(PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eKillPower) * 0.01f, PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eKillPower) * 0.01f * (float) (int) this.nAssCnt);
    }
  }

  public float fRicochetPower
  {
    get
    {
      return Mathf.Min(PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eRicochetPower) * 0.01f, PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eRicochetPower) * 0.01f * (float) (int) this.nRicCnt);
    }
  }

  public float fCriPower
  {
    get
    {
      return Mathf.Min(PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eCriPower) * 0.01f, PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eCriPower) * 0.01f * (float) (int) this.nCriCnt);
    }
  }

  public bool isHugeWeapon
  {
    get
    {
      if ((int) this.nMustBigshot <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eBigShot) + (!this.bRage ? 0.0 : (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eRageBigShot)) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isFireBall
  {
    get
    {
      if ((int) this.nMustFireball <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eFireBall) + (!this.bRage ? 0.0 : (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eRageFireBall)) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isFireLance
  {
    get
    {
      if ((int) this.nMustFirelance <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eFireLance) + (!this.bRage ? 0.0 : (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eRageFireLance)) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isSoulBomb
  {
    get
    {
      if ((int) this.nMustSoulBall <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eSoulBall) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isMultiShot
  {
    get
    {
      if ((int) this.nMustMultishot <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eMultiShot) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isTripleSword
  {
    get
    {
      if ((int) this.nMustTripleSword <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eTripleSword) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isStrongKick
  {
    get
    {
      if ((int) this.nMustStrongKick <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eHighKick) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isBigSlash
  {
    get
    {
      if ((int) this.nMustBigSlash <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eBigSlash) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isSubLaser
  {
    get
    {
      if ((int) this.nMustSubLaser <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eSubLaser) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isFrost
  {
    get
    {
      if ((int) this.nMustFrost <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eFrostBall) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isChainLightning
  {
    get
    {
      if ((int) this.nMustChain <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eChainLightning) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isRicochet
  {
    get
    {
      if ((int) this.nMustRicochet <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eRicochet) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isExplosion
  {
    get
    {
      if ((int) this.nMustElementalExposion <= 0)
        return (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eElementalBomb) > (double) Random.Range(0.0f, 100f);
      return true;
    }
  }

  public bool isRandomDmg
  {
    get
    {
      return (int) this.nMustRandomDmg > 0;
    }
  }

  private void Awake()
  {
    this.animator = this.GetComponent<Animator>();
  }

  private void OnRageStart()
  {
    if (PageBattle.obj.eTrial == MutateType.eSanctuary)
      return;
    UIMgr.PlaySound("RageOn", false);
    this.psRage.Play(false);
    this.fRageChg -= 60f;
    this.fRageDur = 5f;
    this.fRageDur *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eRage) * 0.00999999977648258);
    this.fRageDur *= (float) (1.0 + (double) Info.GetAccModFac(this.nPos, ModType.eLongRage) * 0.00999999977648258);
    if (PageBattle.CheckMutation(MutateType.eInhibitor))
      this.fRageDur *= (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.eInhibitor) * 0.00999999977648258);
    this.sprite.color = Color.red;
    this.fRageAtkBonus = (ObscuredFloat) ((float) (0.5 + (double) Info.GetPartySkillFac(SkillKey.eRageAtkParty) * 0.00999999977648258));
    Monster monster1 = this;
    ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) monster1.fRageAtkBonus * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eFireRageAtk, 0) * 0.00999999977648258));
    monster1.fRageAtkBonus = obscuredFloat1;
    Monster monster2 = this;
    ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) monster2.fRageAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetPartyMonTrait(MonTraitID.eRageCharDmg) * 0.00999999977648258));
    monster2.fRageAtkBonus = obscuredFloat2;
    this.fRageAspBonus = this.fRageReloadBonus = (ObscuredFloat) 1f;
    Monster monster3 = this;
    ObscuredFloat obscuredFloat3 = (ObscuredFloat) ((float) monster3.fRageAspBonus + (float) this.fFrenzyBonus);
    monster3.fRageAspBonus = obscuredFloat3;
  }

  private void OnRageEnd()
  {
    this.psRage.Stop();
    this.fRageDur = 0.0f;
    this.fRageAtkBonus = this.fRageAspBonus = this.fRageReloadBonus = (ObscuredFloat) 0.0f;
    this.sprite.color = Color.white;
  }

  public void SetCharacter(int _nPos, bool _bNPC)
  {
    this.bNPC = _bNPC;
    this.nPos = _nPos;
    this.Reload(false, 0.0f);
    PlayerMonsterData pData = this.pData;
    if (pData == null)
    {
      this.gameObject.SetActive(false);
    }
    else
    {
      this.gameObject.SetActive(true);
      this.sID = (short) pData.sID;
      this.nEquip = (long) pData.nEquip;
      this.nCharge = (ObscuredInt) 0;
      if (this.nPos == 0 && (PageBattle.obj.eTrial == MutateType.eNoMainMagical || PageBattle.obj.eTrial == MutateType.eNoMainPhysical))
        this.nEquip = -1L;
      this.sWeapon = Info.GetPlayerWeapon((long) pData.nEquip) != null ? (short) Info.GetPlayerWeapon((long) pData.nEquip).sID : (short) -1;
      this.gameObject.SetActive(true);
      MonsterData monster1 = BData.GetMonster(this.sID);
      int promoteLevel = Info.GetPromoteLevel(this.sID);
      this.animator.runtimeAnimatorController = RSMgr.GetController(!Info.isAwaken(this.pData) ? monster1.strController : monster1.strControllerAwk);
      this.animator.SetInteger("Health", 1);
      this.animator.Play("Idle");
      this.fCri = (ObscuredFloat) (5f + PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eEagleEye) + Info.GetAccModFac(this.nPos, ModType.eCri) + Info.GetElementalFac(ElementalID.eFireCrRate, 0));
      this.fRageCriRate += PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eBerserk);
      this.nCriCnt = this.nRicCnt = this.nAssCnt = (ObscuredInt) 0;
      this.fDmgDealt = 0.0;
      this.fRdcRecoil = (ObscuredFloat) ((float) (-12.0 * (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eCool) * 0.00999999977648258) * (1.0 + (double) Info.GetAccModFac(this.nPos, ModType.eCool) * 0.00999999977648258)));
      this.fAccBonus = (ObscuredFloat) ((float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eLeader) * 0.00999999977648258 - (double) PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eFirerate) * 0.00999999977648258 + (double) Info.GetAccModFac(this.nPos, ModType.eAcc) * 0.00999999977648258));
      this.fAtkBonus = (ObscuredFloat) ((float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eSnipe) * 0.00999999977648258));
      Monster monster2 = this;
      ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) monster2.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eBasicTraining) * 0.00999999977648258));
      monster2.fAtkBonus = obscuredFloat1;
      Monster monster3 = this;
      ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) monster3.fAtkBonus * (float) (1.0 + (double) Info.GetAccModFac(this.nPos, ModType.eDmg) * 0.00999999977648258));
      monster3.fAtkBonus = obscuredFloat2;
      Monster monster4 = this;
      ObscuredFloat obscuredFloat3 = (ObscuredFloat) ((float) monster4.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eWindWeapon) * 0.00999999977648258));
      monster4.fAtkBonus = obscuredFloat3;
      Monster monster5 = this;
      ObscuredFloat obscuredFloat4 = (ObscuredFloat) ((float) monster5.fAtkBonus * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eRubyCharDmg) * 0.00999999977648258));
      monster5.fAtkBonus = obscuredFloat4;
      Monster monster6 = this;
      ObscuredFloat obscuredFloat5 = (ObscuredFloat) ((float) monster6.fAtkBonus * (float) (1.0 + (double) Info.GetRepeatResearch(ResearchID.eUnlimitedPower) * 0.00999999977648258));
      monster6.fAtkBonus = obscuredFloat5;
      if (promoteLevel >= 200)
      {
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAtkBonus * (float) (3.0 + (double) promoteLevel * 0.00999999977648258));
        monster7.fAtkBonus = obscuredFloat6;
      }
      else if (promoteLevel >= 100)
      {
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAtkBonus * (float) (1.5 + (double) promoteLevel * 0.00999999977648258));
        monster7.fAtkBonus = obscuredFloat6;
      }
      else
      {
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAtkBonus * (float) (1.0 + (double) promoteLevel * 0.00999999977648258));
        monster7.fAtkBonus = obscuredFloat6;
      }
      if ((double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eElementalForce) > 0.0)
      {
        float num = 0.0f;
        for (int nPos = 0; nPos < Info.currentSave.arrPlayerMon.Length; ++nPos)
        {
          if (Info.GetPlayerMon(nPos) != null)
          {
            short sId = (short) Info.GetPlayerMon(nPos).sID;
            if ((int) sId >= 15 && (int) sId <= 19)
              ++num;
          }
        }
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eElementalForce) * 0.00999999977648258 * (double) num));
        monster7.fAtkBonus = obscuredFloat6;
        Monster monster8 = this;
        ObscuredFloat obscuredFloat7 = (ObscuredFloat) ((float) monster8.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eElementalForce) * 0.00999999977648258 * (double) num * (double) PageBattle.obj.GetMonTrait(this.nPos, MonTraitID.eElementalForcePlus) * 0.00999999977648258));
        monster8.fAtkBonus = obscuredFloat7;
      }
      if (Info.isAwaken(this.pData))
      {
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAtkBonus * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eAwaken) * 0.00999999977648258));
        monster7.fAtkBonus = obscuredFloat6;
      }
      if (this.nPos == 0)
      {
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAtkBonus * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eAcientBlood) * 0.00999999977648258));
        monster7.fAtkBonus = obscuredFloat6;
        Monster monster8 = this;
        ObscuredFloat obscuredFloat7 = (ObscuredFloat) ((float) monster8.fAtkBonus * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eMainCharDmg) * 0.00999999977648258));
        monster8.fAtkBonus = obscuredFloat7;
        Monster monster9 = this;
        ObscuredFloat obscuredFloat8 = (ObscuredFloat) ((float) monster9.fAtkBonus * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eDarkMainDmg, 0) * 0.00999999977648258));
        monster9.fAtkBonus = obscuredFloat8;
      }
      else
      {
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetMonTrait(this.nPos, MonTraitID.eMecernaryPlus) * 0.00999999977648258));
        monster7.fAtkBonus = obscuredFloat6;
        Monster monster8 = this;
        ObscuredFloat obscuredFloat7 = (ObscuredFloat) ((float) monster8.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetMonTrait(0, MonTraitID.eMecernaryKing) * 0.00999999977648258));
        monster8.fAtkBonus = obscuredFloat7;
        Monster monster9 = this;
        ObscuredFloat obscuredFloat8 = (ObscuredFloat) ((float) monster9.fAtkBonus * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eMecenaryTraining) * 0.00999999977648258));
        monster9.fAtkBonus = obscuredFloat8;
        Monster monster10 = this;
        ObscuredFloat obscuredFloat9 = (ObscuredFloat) ((float) monster10.fAtkBonus * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eMercenaryDmg) * 0.00999999977648258));
        monster10.fAtkBonus = obscuredFloat9;
        Monster monster11 = this;
        ObscuredFloat obscuredFloat10 = (ObscuredFloat) ((float) monster11.fAtkBonus * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eLightMercernary, 0) * 0.00999999977648258));
        monster11.fAtkBonus = obscuredFloat10;
      }
      Monster monster12 = this;
      ObscuredFloat obscuredFloat11 = (ObscuredFloat) ((float) monster12.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetMonTrait(this.nPos, MonTraitID.eCompressShot) * 0.00999999977648258));
      monster12.fAtkBonus = obscuredFloat11;
      this.SetNpcAtkBonus(this.bNPC);
      this.fCriDmg = (ObscuredFloat) 2f;
      this.fFrenzyBonus = (ObscuredFloat) (PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eFrenzy) * 0.01f);
      this.fAspBonus = (ObscuredFloat) ((float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eFirerate) * 0.00999999977648258 - (double) PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eSnipe) * 0.00999999977648258));
      Monster monster13 = this;
      ObscuredFloat obscuredFloat12 = (ObscuredFloat) ((float) monster13.fAspBonus * (float) (1.0 + (double) Info.GetAccModFac(this.nPos, ModType.eAsp) * 0.00999999977648258));
      monster13.fAspBonus = obscuredFloat12;
      this.fRageGetBonus = (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eMoreRage) * 0.00999999977648258);
      this.fAfterAspBonus = (ObscuredFloat) 1f;
      if (PageBattle.CheckMutation(MutateType.eSlow))
      {
        Monster monster7 = this;
        ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) monster7.fAfterAspBonus * (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.eSlow) * 0.00999999977648258));
        monster7.fAfterAspBonus = obscuredFloat6;
      }
      this.fReloadBonus = (ObscuredFloat) ((float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eReloading) * 0.00999999977648258));
      Monster monster14 = this;
      ObscuredFloat obscuredFloat13 = (ObscuredFloat) ((float) monster14.fReloadBonus * (float) (1.0 + (double) Info.GetAccModFac(ModType.eReload) * 0.00999999977648258));
      monster14.fReloadBonus = obscuredFloat13;
      this.fCriDmg = (ObscuredFloat) ((float) ((double) Info.GetAccModFac(this.nPos, ModType.eCriDmg) * 0.00999999977648258 + (double) Info.GetPartySkillFac(SkillKey.eCriDmgParty) * 0.00999999977648258 + (double) Info.GetElementalFac(ElementalID.eFireCrDmg, 0) * 0.00999999977648258));
      this.fRageCriDmg += PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eBerserk) * 0.01f;
      this.fRageCriDmg += Info.GetElementalFac(ElementalID.eFireRageCrDmg, 0) * 0.01f;
      this.fRageCriDmg += PageBattle.obj.GetPartyMonTrait(MonTraitID.eRageCritDmg) * 0.01f;
      this.goAtkBuff.SetActive(false);
      this.goAspBuff.SetActive(false);
      this.goReloadBuff.SetActive(false);
      this.goDarkBuff.SetActive(false);
      if (this.nEquip == -1L)
        return;
      BattleItemData battleItem = Info.GetBattleItem(this.nEquip);
      this.eWeapon = battleItem.eWeapon;
      this.nMaxAmmo = (ObscuredInt) battleItem.nAmmo;
      this.nAmmo = this.nMaxAmmo = (ObscuredInt) Mathf.RoundToInt((float) ((double) (int) this.nMaxAmmo * (1.0 + (double) Info.GetAccModFac(this.nPos, ModType.eAmmo) * 0.00999999977648258) * (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eAmmoSupply) * 0.00999999977648258) * (1.0 - (double) PageBattle.obj.GetMonTrait(this.nPos, MonTraitID.eCompressShot) * 0.00999999977648258)));
      if (BData.GetWeapon((short) battleItem.sID).eWeapon == WeaponType.eBow)
        this.nAmmo = this.nMaxAmmo = (ObscuredInt) (1 + (int) PageBattle.obj.GetMonTrait(this.nPos, MonTraitID.eBigQuiver));
      this.fCool = (ObscuredFloat) battleItem.fRate;
      this.fTime = 0.0f;
      this.fRange = (ObscuredFloat) battleItem.fRange;
      Monster monster15 = this;
      ObscuredFloat obscuredFloat14 = (ObscuredFloat) ((float) monster15.fCri + battleItem.fCri);
      monster15.fCri = obscuredFloat14;
      Monster monster16 = this;
      ObscuredFloat obscuredFloat15 = (ObscuredFloat) ((float) monster16.fCriDmg + battleItem.fCriDmg);
      monster16.fCriDmg = obscuredFloat15;
      Monster monster17 = this;
      ObscuredFloat obscuredFloat16 = (ObscuredFloat) ((float) monster17.fAtkBonus * (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eTrainedKnight) * 0.00999999977648258));
      monster17.fAtkBonus = obscuredFloat16;
      Monster monster18 = this;
      ObscuredFloat obscuredFloat17 = (ObscuredFloat) ((float) monster18.fAspBonus * (float) (1.0 + (double) PageBattle.obj.GetSkillFac2(this.nPos, SkillKey.eTrainedKnight) * 0.00999999977648258));
      monster18.fAspBonus = obscuredFloat17;
      if (Info.CheckResearch(ResearchID.eScope))
        this.fRange = (ObscuredFloat) 800f;
      this.SetSpeed(this.nEquip);
    }
  }

  public void Update()
  {
    if ((bool) PageBattle.obj.bBattleOver)
      return;
    if ((double) this.fDarkBuffTime > 0.0)
    {
      this.fDarkBuffTime -= Time.deltaTime;
      if ((double) this.fDarkBuffTime <= 0.0)
      {
        this.fDarkFactor = 0.0f;
        this.goDarkBuff.SetActive(false);
      }
    }
    if ((double) this.fWarcryBuffTime > 0.0)
    {
      this.fWarcryBuffTime -= Time.deltaTime;
      if ((double) this.fWarcryBuffTime <= 0.0)
      {
        this.fWarcryFactor = 0.0f;
        this.goAtkBuff.SetActive(false);
      }
    }
    if ((double) this.fSwiftBuffTime > 0.0)
    {
      this.fSwiftBuffTime -= Time.deltaTime;
      if ((double) this.fSwiftBuffTime <= 0.0)
      {
        this.fSwiftFactor = 0.0f;
        this.goAspBuff.SetActive(false);
      }
    }
    if ((double) this.fReloadBuffTime > 0.0)
    {
      this.fReloadBuffTime -= Time.deltaTime;
      if ((double) this.fReloadBuffTime <= 0.0)
        this.goReloadBuff.SetActive(false);
    }
    this.fRecoil = (ObscuredFloat) Mathf.Clamp((float) this.fRecoil + (float) this.fRdcRecoil * Time.deltaTime, Monster.fMinRecoil, Monster.fMaxRecoil);
    if ((double) this.fRageDur > 0.0)
    {
      this.fRageDur -= Time.deltaTime;
      if ((double) this.fRageDur <= 0.0)
        this.OnRageEnd();
    }
    else
      this.fRageChg += (Info.GetElementalFac(ElementalID.eFireRageFill, 0) + Info.GetResearchFac(ResearchID.eFlag)) * Time.deltaTime;
    if (this.nEquip == -1L)
      return;
    if ((double) this.fTime < (double) (float) this.fCool)
      this.fTime = this.fTime + Time.deltaTime * this.fFixAspBonus;
    if ((int) this.nAmmo <= 0)
    {
      if (this.isReloading)
        return;
      if ((double) Random.Range(0.0f, 100f) < (double) Info.GetPartySkillFac(SkillKey.eFastReloading))
      {
        this.OnReloadComplete();
      }
      else
      {
        if (this.nPos == 0)
          UIMgr.PlaySound("ReloadStart", false);
        this.Reload(true, Info.GetBattleItem(this.nEquip).fReload);
      }
    }
    else
    {
      if (!this.bNPC || this.isStun || ((Object) this.target == (Object) null || this.target.isDead) || !this.target.isActiveAndEnabled)
        return;
      if (this.eWeapon == WeaponType.eMonster)
      {
        PageBattle.obj.OnShooting(this, this.target.vPos, this.nEquip, true, this.nAtkTime);
        this.animator.SetTrigger("TriggerAttack");
      }
      else
      {
        if (!this.canShoot)
          return;
        PageBattle.obj.OnShooting(this, this.target.vPos, this.nEquip, true, this.nAtkTime);
        this.animator.SetTrigger("TriggerAttack");
      }
    }
  }

  public void Reload(bool _bReload, float fTime = 0.0f)
  {
    if (this.cr != null)
      this.StopCoroutine(this.cr);
    this.reloadBack.gameObject.SetActive(_bReload);
    this.bReload = _bReload;
    if (!this.bReload || this.nEquip == -1L)
      return;
    this.cr = this.StartCoroutine(this.Reload(fTime));
  }

  public void Reload()
  {
    if (!this.bNPC || this.bReload || ((int) this.nAmmo >= (int) this.nMaxAmmo || this.nEquip == -1L))
      return;
    this.Reload(true, Info.GetBattleItem(this.nEquip).fReload);
  }

  [DebuggerHidden]
  private IEnumerator Reload(float fTime)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new Monster.\u003CReload\u003Ec__Iterator0()
    {
      fTime = fTime,
      \u0024this = this
    };
  }

  public void SetStun(float fTime)
  {
    if (this.crStun != null)
      this.StopCoroutine(this.crStun);
    this.sprite.flipX = true;
    this.fStunDur = fTime;
    this.animator.SetBool("TriggerHurt", true);
    this.crStun = this.StartCoroutine(this.StartStun());
  }

  [DebuggerHidden]
  private IEnumerator StartStun()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new Monster.\u003CStartStun\u003Ec__Iterator1()
    {
      \u0024this = this
    };
  }

  private void OnReloadComplete()
  {
    this.nAmmo = this.nMaxAmmo;
    PageBattle.obj.OnReload(this);
  }

  public void Animate(string strName)
  {
    this.animator.SetTrigger(strName);
  }

  public void SetSpeed(long uid)
  {
    float fRate = Info.GetBattleItem(uid).fRate;
    this.fAddRecoil = fRate * 15f;
    this.animator.SetFloat("AnimSpeed", 1f / fRate);
  }

  public void Shoot()
  {
  }

  public void OnWarcryBuff(float fTime, float fFactor)
  {
    this.psWarcry.Play(false);
    this.fWarcryBuffTime = fTime;
    this.fWarcryFactor = fFactor;
    this.goAtkBuff.SetActive(true);
  }

  public void OnDarkBuff(float fTime, float fFactor)
  {
    this.goDarkBuff.SetActive(true);
    this.fDarkBuffTime = fTime;
    this.fDarkFactor = fFactor;
  }

  public void OnSwiftBuff(float fTime, float fFactor)
  {
    this.psSwift.Play(false);
    this.fSwiftBuffTime = fTime;
    this.fSwiftFactor = fFactor;
    this.goAspBuff.SetActive(true);
  }

  public void OnReloadBuff(float fTime)
  {
    this.psConcen.Play(false);
    this.fReloadBuffTime = fTime;
    this.goReloadBuff.SetActive(true);
  }

  public void OnCastComplete()
  {
  }

  public void OnCastEffect()
  {
  }

  public void OnCrit()
  {
    ++this.nCriCnt;
    --this.nMustCri;
    this.AddRage(1f);
  }

  public void OnKill()
  {
    this.AddRage(6f);
    if ((double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eResummon) <= (double) Random.Range(0.0f, 100f))
      return;
    ++this.nAmmo;
  }

  public void AddRage(float fFac)
  {
    if (this.bRage)
      return;
    this.fRage += fFac * this.fRageGetBonus;
  }

  public void OnShootEnd(int nShot, int nAtkTime)
  {
    if ((double) PageBattle.obj.GetSkillFac(this.nPos, SkillKey.eMemorial) + (double) Info.GetPartySkillFac(SkillKey.eMemorizeParty) <= (double) Random.Range(0.0f, 100f))
    {
      Monster monster1 = this;
      ObscuredInt obscuredInt1 = (ObscuredInt) ((int) monster1.nAmmo - nAtkTime);
      monster1.nAmmo = obscuredInt1;
      if (PageBattle.CheckMutation(MutateType.eWaste) && (double) Random.Range(0.0f, 100f) < (double) PageBattle.GetMutation1(MutateType.eWaste))
      {
        Monster monster2 = this;
        ObscuredInt obscuredInt2 = (ObscuredInt) ((int) monster2.nAmmo - nAtkTime);
        monster2.nAmmo = obscuredInt2;
      }
    }
    Monster monster3 = this;
    ObscuredInt obscuredInt3 = (ObscuredInt) ((int) monster3.nMustMultishot - nAtkTime);
    monster3.nMustMultishot = obscuredInt3;
    Monster monster4 = this;
    ObscuredInt obscuredInt4 = (ObscuredInt) ((int) monster4.nMustBigshot - nAtkTime);
    monster4.nMustBigshot = obscuredInt4;
    Monster monster5 = this;
    ObscuredInt obscuredInt5 = (ObscuredInt) ((int) monster5.nMustFireball - nAtkTime);
    monster5.nMustFireball = obscuredInt5;
    Monster monster6 = this;
    ObscuredInt obscuredInt6 = (ObscuredInt) ((int) monster6.nMustFirelance - nAtkTime);
    monster6.nMustFirelance = obscuredInt6;
    Monster monster7 = this;
    ObscuredInt obscuredInt7 = (ObscuredInt) ((int) monster7.nMustRandomDmg - nAtkTime);
    monster7.nMustRandomDmg = obscuredInt7;
    Monster monster8 = this;
    ObscuredInt obscuredInt8 = (ObscuredInt) ((int) monster8.nMustRicochet - nAtkTime);
    monster8.nMustRicochet = obscuredInt8;
    Monster monster9 = this;
    ObscuredInt obscuredInt9 = (ObscuredInt) ((int) monster9.nMustSoulBall - nAtkTime);
    monster9.nMustSoulBall = obscuredInt9;
    Monster monster10 = this;
    ObscuredInt obscuredInt10 = (ObscuredInt) ((int) monster10.nMustStrongKick - nAtkTime);
    monster10.nMustStrongKick = obscuredInt10;
    Monster monster11 = this;
    ObscuredInt obscuredInt11 = (ObscuredInt) ((int) monster11.nMustTripleSword - nAtkTime);
    monster11.nMustTripleSword = obscuredInt11;
    Monster monster12 = this;
    ObscuredInt obscuredInt12 = (ObscuredInt) ((int) monster12.nMustSubLaser - nAtkTime);
    monster12.nMustSubLaser = obscuredInt12;
    Monster monster13 = this;
    ObscuredInt obscuredInt13 = (ObscuredInt) ((int) monster13.nMustFrost - nAtkTime);
    monster13.nMustFrost = obscuredInt13;
    Monster monster14 = this;
    ObscuredInt obscuredInt14 = (ObscuredInt) ((int) monster14.nMustBigSlash - nAtkTime);
    monster14.nMustBigSlash = obscuredInt14;
    Monster monster15 = this;
    ObscuredInt obscuredInt15 = (ObscuredInt) ((int) monster15.nMustChain - nAtkTime);
    monster15.nMustChain = obscuredInt15;
    Monster monster16 = this;
    ObscuredInt obscuredInt16 = (ObscuredInt) ((int) monster16.nMustElementalExposion - nAtkTime);
    monster16.nMustElementalExposion = obscuredInt16;
    if ((int) this.nAmmo < 0)
      this.nAmmo = (ObscuredInt) 0;
    this.fRecoil = (ObscuredFloat) Mathf.Clamp((float) this.fRecoil + Monster.fIncRecoil * (float) nShot + this.fAddRecoil, Monster.fMinRecoil, Monster.fMaxRecoil);
  }

  public void OnAssasinate()
  {
    ++this.nAssCnt;
  }

  public void OnRicochet()
  {
    ++this.nRicCnt;
  }

  public void SetNpcAtkBonus(bool _bNpc)
  {
    this.bNPC = _bNpc;
    this.fAfterAtkBonus = (ObscuredFloat) 1f;
    if (PageBattle.CheckMutation(MutateType.eSpotlight))
    {
      Monster monster = this;
      ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) monster.fAfterAtkBonus * (this.nPos != 0 ? (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.eSpotlight) * 0.00999999977648258) : (float) (1.0 + (double) PageBattle.GetMutation2(MutateType.eSpotlight) * 0.00999999977648258)));
      monster.fAfterAtkBonus = obscuredFloat;
    }
    Monster monster1 = this;
    ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) monster1.fAfterAtkBonus * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eFireBase1, 0) * 0.00999999977648258));
    monster1.fAfterAtkBonus = obscuredFloat1;
  }
}
