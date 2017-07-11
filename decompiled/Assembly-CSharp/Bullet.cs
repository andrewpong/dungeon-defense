// Decompiled with JetBrains decompiler
// Type: Bullet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;

[RequireComponent(typeof (SpriteRenderer))]
public class Bullet : MonoBehaviour
{
  private float fSpd = 300f;
  private Vector2 vMovePos = Vector2.zero;
  private float fSize = 1f;
  [HideInInspector]
  public float fPow;
  [HideInInspector]
  public float fDmgArmor;
  [HideInInspector]
  public float fDmgMagic;
  [HideInInspector]
  public Vector2 vPos;
  [HideInInspector]
  public BulletType eType;
  [HideInInspector]
  public WeaponType eWeapon;
  [HideInInspector]
  public TrailType eTrail;
  [HideInInspector]
  public int nPen;
  [HideInInspector]
  public int nRicochet;
  [HideInInspector]
  public Monster pMon;
  [HideInInspector]
  public bool bHuge;
  [HideInInspector]
  public bool bAssasinate;
  [HideInInspector]
  public bool bCursed;
  [HideInInspector]
  public bool bSpinning;
  [HideInInspector]
  public int nKill;
  [HideInInspector]
  public int nHit;
  [HideInInspector]
  public bool bCri;
  public GameObject[] goTrail;
  public SpriteRenderer srWeapon;
  private bool bSpin;
  [HideInInspector]
  public int nCreated;
  [HideInInspector]
  public int nDeleted;

  private void SetStat(float fDmg, float vsA, float vsM, float _fSpd, int _nPen)
  {
    this.nHit = this.nKill = 0;
    this.fSpd = _fSpd;
    this.fPow = fDmg * (float) Info.fAtkBonus;
    this.nPen = _nPen;
    if (this.eType == BulletType.eExplosionCir)
      this.nPen += Info.GetResearchFacInt(ResearchID.eFireBall);
    if ((double) Info.GetPartySkillFac(SkillKey.ePenetrateParty) > (double) Random.Range(0.0f, 100f))
      ++this.nPen;
    if ((Object) this.pMon != (Object) null)
    {
      this.fSpd *= (float) (1.0 + (double) Info.GetAccModFac(this.pMon.nPos, ModType.eBulSpd) * 0.00999999977648258);
      this.fSpd *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eWindWeapon) * 0.00999999977648258);
      if (this.bHuge)
        this.fSpd *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eMarchWeapon) * 0.00999999977648258);
      if (this.eType == BulletType.eExplosionDir)
        this.fSpd *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eBigFireLance) * 0.00999999977648258);
      if (Info.GetSkill(this.pMon.nPos, SkillKey.eSwordWill) > 0)
      {
        this.fSpd *= 1.5f;
        this.bSpin = this.bSpinning;
        this.nPen += (int) PageBattle.obj.GetMonTrait(this.pMon.nPos, MonTraitID.eSharpenEdge);
        this.nPen += Mathf.RoundToInt(PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eDarkPenetrate));
        this.fPow *= (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.ePenetratePower) * 0.00999999977648258 * (double) Mathf.RoundToInt(PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eDarkPenetrate)));
      }
    }
    this.fDmgArmor = vsA;
    this.fDmgMagic = vsM;
  }

  private void CalcMonsterBonus()
  {
    if ((Object) this.pMon == (Object) null)
      return;
    this.fPow *= this.pMon.fFixAtkBonus;
    if (this.eWeapon == WeaponType.eBow || this.eWeapon == WeaponType.eSpear)
    {
      this.nPen += (int) PageBattle.obj.GetMonTrait(this.pMon.nPos, MonTraitID.eSharpenEdge);
      this.nPen += (int) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.ePenetrate);
      this.fPow *= (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.ePenetratePower) * 0.00999999977648258 * (double) (int) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.ePenetrate));
    }
    this.fDmgArmor *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eArmorIgnore) * 0.00999999977648258);
    this.fDmgMagic *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eMagicIgnore) * 0.00999999977648258);
  }

  private void FixedUpdate()
  {
    this.transform.Translate((Vector3) (this.vMovePos * Time.fixedDeltaTime), Space.World);
    if (!this.srWeapon.gameObject.activeInHierarchy || !this.bSpin)
      return;
    this.transform.Rotate(0.0f, 0.0f, -720f * Time.fixedDeltaTime);
  }

  private void OnBecameInvisible()
  {
    if (this.nDeleted >= this.nCreated)
      return;
    PageBattle.obj.OnBulletDiabled(this);
  }

  private void ResetImage(ItemData data)
  {
    this.transform.localScale = Vector3.one * (!this.bHuge ? 150f : (float) (600.0 * (1.0 + (double) Info.GetResearchFac(ResearchID.eBigShot) * 0.00999999977648258))) * this.fSize;
    this.transform.eulerAngles = new Vector3(0.0f, 0.0f, ((double) this.vPos.y >= 0.0 ? 1f : -1f) * Vector2.Angle(new Vector2(1f, 0.0f), this.vPos));
    this.vMovePos = this.vPos * this.fSpd;
    for (int index = 0; index < this.goTrail.Length; ++index)
      this.goTrail[index].SetActive((TrailType) index == this.eTrail && !Info.option.bAllFXOff);
    if (this.srWeapon.gameObject.activeInHierarchy)
      this.srWeapon.transform.localEulerAngles = new Vector3(0.0f, 0.0f, -45f);
    if (this.eTrail != TrailType.eWeapon)
      return;
    this.srWeapon.color = !this.bCursed ? Color.white : Color.magenta;
    this.srWeapon.sprite = RSMgr.GetSprite(data.strBullet);
    this.srWeapon.enabled = !Info.option.bAllFXOff;
  }

  public Bullet SetTarget(Monster _pMon, TrailType _eTrail, BulletType _eType, Vector2 _vPos, BattleItemData data, float fDmg, bool _bCri, bool _bHuge, bool bAssasin, bool _bCursed, bool _bSpinning, int _nRicochet, float fSpdBonus = 1f)
  {
    this.pMon = _pMon;
    this.eTrail = _eTrail;
    this.eType = _eType;
    this.vPos = _vPos;
    this.bHuge = _bHuge;
    this.bCri = _bCri;
    this.bCursed = _bCursed;
    this.bSpinning = _bSpinning;
    this.fSize = 1f;
    this.bAssasinate = bAssasin;
    this.nRicochet = _nRicochet;
    ItemData weapon = BData.GetWeapon((short) data.sID);
    this.eWeapon = weapon.eWeapon;
    this.bSpin = weapon.bSpin || this.bSpinning;
    if (this.bHuge)
    {
      if ((double) Random.Range(0.0f, 100f) < (double) PageBattle.obj.GetMonTrait(this.pMon.nPos, MonTraitID.eBFShot))
      {
        this.fSize = 2f;
        fDmg *= (float) (1.0 + (double) PageBattle.obj.GetMonTrait(this.pMon.nPos, MonTraitID.eBFShot) * 0.00999999977648258);
        fDmg *= (float) (1.0 + (double) PageBattle.obj.GetMonTrait(this.pMon.nPos, MonTraitID.eBFShotPlus) * 0.00999999977648258);
      }
      if (this.pMon.bRage)
        fDmg *= (float) (1.0 + (double) PageBattle.obj.GetMonTrait(this.pMon.nPos, MonTraitID.eRageBigShot) * 0.00999999977648258);
      if (this.bHuge)
        fSpdBonus *= (float) (0.400000005960464 * (1.0 + (double) PageBattle.obj.GetMonTrait(this.pMon.nPos, MonTraitID.eBigSummonPlus) * 0.00999999977648258));
    }
    this.SetStat(fDmg, data.fvsArmor, data.fvsMagic, data.fSpd, data.nPen);
    this.fSpd *= fSpdBonus;
    this.CalcMonsterBonus();
    this.ResetImage(weapon);
    return this;
  }

  public Bullet SetTarget(Monster _pMon, TrailType _eTrail, BulletType _eType, Vector2 _vPos, ItemData data, float fDmg, bool _bHuge = false)
  {
    this.pMon = _pMon;
    this.eTrail = _eTrail;
    this.eType = _eType;
    this.vPos = _vPos;
    this.bHuge = _bHuge;
    this.bCursed = false;
    this.bSpinning = false;
    this.bCri = false;
    this.fSize = 1f;
    this.eWeapon = data.eWeapon;
    this.bSpin = data.bSpin || this.bHuge;
    this.SetStat(fDmg, data.fvsArmor, data.fvsMagic, data.fSpd * (!this.bHuge ? 1f : 0.5f), data.nPen);
    this.CalcMonsterBonus();
    this.ResetImage(data);
    return this;
  }

  public void ResetTarget(Vector2 vPos)
  {
    this.vMovePos = vPos * this.fSpd;
    this.transform.eulerAngles = new Vector3(0.0f, 0.0f, ((double) vPos.y >= 0.0 ? 1f : -1f) * Vector2.Angle(new Vector2(1f, 0.0f), vPos));
  }

  public void AddPower(float fPlus, float fMul)
  {
    this.fPow += fPlus;
    this.fPow *= 1f + fMul;
  }

  public void OnDisabled()
  {
    ++this.nDeleted;
  }

  public void OnImpact(Enemy em)
  {
    if (!this.gameObject.activeInHierarchy)
      return;
    ++this.nHit;
    bool flag = false;
    if (this.nRicochet > 0)
    {
      PageBattle.obj.OnBulletRicochet(this, em);
      --this.nRicochet;
      flag = true;
    }
    else if (this.bHuge && (double) this.transform.localScale.x > 150.0)
    {
      if ((Object) this.pMon == (Object) null || (Object) this.pMon != (Object) null && (double) Info.GetAccModFac(this.pMon.nPos, ModType.eBigShotAll) <= 0.0)
      {
        this.transform.localScale = Vector3.one * Mathf.Max(150f, this.transform.localScale.x - 25f);
        if ((double) Info.GetAccModFac(this.pMon.nPos, ModType.eBigShotAll) > 0.0)
          this.fPow *= (float) (1.0 + (double) Info.GetAccModFac(this.pMon.nPos, ModType.eBigShotAll) * 0.100000001490116);
      }
    }
    else
    {
      if (this.bSpinning)
        PageBattle.obj.OnBulletRicochet(this, em);
      --this.nPen;
    }
    if (this.bAssasinate && (Object) this.pMon != (Object) null)
      this.pMon.OnAssasinate();
    if (this.nPen < 1)
    {
      PageBattle.obj.OnBulletDiabled(this);
    }
    else
    {
      if (flag || !((Object) this.pMon != (Object) null))
        return;
      this.fPow *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.ePenetrateMaster) * 0.00999999977648258);
      if ((double) Info.GetAccModFac(this.pMon.nPos, ModType.eSwordPenetrate) <= 0.0)
        return;
      this.fPow *= (float) (1.0 + (double) Info.GetAccModFac(this.pMon.nPos, ModType.eSwordPenetrate) * 0.00999999977648258);
    }
  }

  public void OnKill()
  {
    if (!this.gameObject.activeInHierarchy || !this.bHuge)
      return;
    this.fPow *= (float) (1.0 + (double) PageBattle.obj.GetSkillFac(this.pMon.nPos, SkillKey.eWinning) * 0.00999999977648258);
  }
}
