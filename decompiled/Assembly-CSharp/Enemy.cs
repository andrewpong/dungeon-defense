// Decompiled with JetBrains decompiler
// Type: Enemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
[RequireComponent(typeof (SpriteRenderer))]
public class Enemy : MonoBehaviour
{
  private static Vector3 vAddPos = new Vector3(0.0f, 16f, 0.0f);
  private static Color colorHide = new Color(1f, 1f, 1f, 0.4f);
  [HideInInspector]
  public float fTakeDmg = 1f;
  [HideInInspector]
  public float fTakeDmg2 = 1f;
  [HideInInspector]
  public float fGiveDmg = 1f;
  private float fStunReduce = 1f;
  private float fEntangleReduce = 1f;
  [HideInInspector]
  public float fSlowRate = 1f;
  private MutateType eGuageMut = MutateType.eNone;
  private List<MutateType> listMut = new List<MutateType>();
  private Dictionary<MutateType, float> dictMutTimer = new Dictionary<MutateType, float>();
  private Dictionary<MutateType, float> dictMutActive = new Dictionary<MutateType, float>();
  private Dictionary<MutateType, float> dictMutDur = new Dictionary<MutateType, float>();
  private Dictionary<MutateType, float> dictMutTime = new Dictionary<MutateType, float>();
  private Vector2 vKnockback = new Vector2(10f, 0.0f);
  private Vector2 vMove = Vector2.zero;
  public Rigidbody2D rigid;
  public SpriteRenderer hpbar;
  public SpriteRenderer hpbarBack;
  public ParticleElt psInvincible;
  public SpriteRenderer sr;
  private Animator animator;
  private Vector2 movePos;
  private Vector2 moveZigPos;
  [HideInInspector]
  public double hp;
  [HideInInspector]
  public double maxhp;
  private bool bDead;
  private float fDeadTime;
  private float fSpeed;
  private float fZigSpd;
  private bool bAttack;
  private bool bRange;
  private bool bZigZag;
  [HideInInspector]
  public bool bBoss;
  [HideInInspector]
  public bool bAtkDungeon;
  private float fAtkTimer;
  private float fAtkCool;
  private float fMoveTimer;
  private float fStopTimer;
  [HideInInspector]
  public float fRange;
  [HideInInspector]
  public int nDropGold;
  [HideInInspector]
  public int nExp;
  [HideInInspector]
  public MoveType eMove;
  [HideInInspector]
  public float fDmg;
  [HideInInspector]
  public ArmorType eArmor;
  [HideInInspector]
  public short sID;
  private bool bDivine;
  private bool bHide;
  private bool bTryAttack;
  public Transform trCastGuage;
  public GameObject goCastGuage;
  public SpriteRenderer srCastFill;
  private float fInvincibleDur;
  private int nProtect;
  public bool bNatureObs;
  public bool bCursed;
  public float fHPRate;
  private double dMaxHPDivider;
  private bool bClose;
  private float fStunDur;
  private Coroutine cr;
  private float fEntangleDur;

  public Vector3 vPos
  {
    get
    {
      return this.transform.localPosition + Enemy.vAddPos;
    }
  }

  public bool isDivine
  {
    get
    {
      return this.bDivine;
    }
  }

  public bool isHide
  {
    get
    {
      return this.bHide;
    }
  }

  public bool isInvincible
  {
    get
    {
      if (!this.CheckMutate(MutateType.eInvincible))
        return (double) this.fInvincibleDur > 0.0;
      return true;
    }
  }

  public bool isProtected
  {
    get
    {
      return this.nProtect > 0;
    }
  }

  public bool isTaunt
  {
    get
    {
      return this.CheckMutate(MutateType.eTaunt);
    }
  }

  public bool isReflect
  {
    get
    {
      return this.CheckMutate(MutateType.eReflection);
    }
  }

  public bool isDead
  {
    get
    {
      return this.bDead;
    }
  }

  public bool isClose
  {
    get
    {
      return (double) this.transform.localPosition.x <= -210.0;
    }
  }

  public bool isStun
  {
    get
    {
      if ((double) this.fStunDur <= 0.0)
        return (double) this.fEntangleDur > 0.0;
      return true;
    }
  }

  public bool isEntangle
  {
    get
    {
      return (double) this.fEntangleDur > 0.0;
    }
  }

  private void Awake()
  {
    this.movePos = new Vector2(-30f, 0.0f);
    this.animator = this.GetComponent<Animator>();
  }

  public void SetEnemy(short _sID, int nDiff, int nDay, bool _bBoss = false)
  {
    if (nDiff > 4)
      nDay += 15;
    else if (nDiff > 3)
      nDay += 3;
    this.sID = _sID;
    EnemyData enemy = BData.GetEnemy(this.sID);
    this.bBoss = _bBoss;
    this.bDead = false;
    this.bNatureObs = false;
    this.bAtkDungeon = false;
    this.bCursed = false;
    this.fDeadTime = 0.0f;
    this.fTakeDmg = 1f;
    this.fTakeDmg2 = 1f;
    this.fSlowRate = 1f;
    this.EndEntangle();
    this.EndStun();
    this.animator.runtimeAnimatorController = RSMgr.GetController(enemy.strController);
    this.animator.SetInteger("Health", 1);
    this.animator.Play("Idle");
    this.bDivine = PageBattle.CheckMutation(MutateType.eDivine) && !this.bBoss;
    this.maxhp = !this.bDivine ? (this.hp = Info.GetMonHP(nDay) * ((double) enemy.fMaxHP + (!this.bBoss ? 0.0 : 2.0)) * (!this.bBoss ? 1.0 : 11.0) * Info.fDiffEmHpFac[nDiff]) : (this.hp = (double) PageBattle.GetMutation1(MutateType.eDivine));
    if (nDiff > 4 && this.bBoss)
      this.maxhp = this.hp = this.hp * (double) nDiff;
    else if (nDiff > 3 && this.bBoss)
      this.maxhp = this.hp = this.hp * 2.0;
    if (PageBattle.obj.eTrial == MutateType.eHusk)
    {
      if (this.bBoss)
      {
        this.bDivine = true;
        this.maxhp = this.hp = (double) (25 * nDiff + nDay);
      }
      else
        this.maxhp = (this.hp += (double) nDay * 0.1);
    }
    this.rigid.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    if (PageBattle.CheckMutation(MutateType.eGiant) && !this.bBoss)
      this.maxhp = this.hp = this.maxhp * (1.0 + (double) PageBattle.GetMutation1(MutateType.eGiant) * 0.01);
    this.fSpeed = Random.Range(-enemy.fMinSpd, -enemy.fMaxSpd) * (!this.bBoss ? 1f : 0.5f);
    this.fSpeed *= Info.fDiffSpd[nDiff];
    if (PageBattle.obj.eTrial == MutateType.eTanker && !this.bBoss)
      this.fSpeed *= 0.25f;
    if (PageBattle.CheckMutation(MutateType.eHaste))
      this.fSpeed *= (float) (1.0 + (double) PageBattle.GetMutation1(MutateType.eHaste) * 0.00999999977648258);
    this.fZigSpd = (float) (-(double) this.fSpeed * 0.5);
    this.movePos.x = this.fSpeed;
    this.SetSlow(Info.GetPartySkillFac(SkillKey.eThreaten));
    this.SetSlow(Info.GetElementalFac(ElementalID.eWaterBase1, 0));
    this.fRange = enemy.fRange - 210f;
    this.fStopTimer = 0.0f;
    this.nDropGold = this.nExp = 0;
    if (Info.eBattle == BattleType.eSurvial)
    {
      this.nDropGold = (int) Random.Range((float) (20.0 + (double) nDay * 2.0), (float) (40.0 + (double) nDay * 3.0)) * (!this.bBoss ? 1 : 50);
      this.nExp = 10 * (!this.bBoss ? 1 : 10);
    }
    this.fDmg = (float) ((double) Info.GetMonDmg(nDay) * (double) enemy.fPow * (!this.bBoss ? 1.0 : 2.0)) * (float) Info.fEmAtkBonus * Info.fDiffEmDmgFac[nDiff];
    this.fAtkCool = (float) ((double) enemy.fAsp * (1.0 + (double) Info.GetPartySkillFac(SkillKey.eFear) * 0.00999999977648258) * (1.0 + (double) Info.GetElementalFac(ElementalID.eWaterAtkSlow, 0) * 0.00999999977648258));
    this.fAtkTimer = Random.Range(0.0f, this.fAtkCool);
    this.animator.SetFloat("AnimSpeed", Mathf.Max(1f, 1f / this.fAtkCool * (float) Info.fEmAspBonus));
    this.bRange = enemy.bRange;
    if (this.bRange)
      this.fDmg *= (float) (1.0 - (double) Info.GetPartySkillFac(SkillKey.eFog) * 0.00999999977648258);
    if (this.bRange && PageBattle.CheckMutation(MutateType.eBombard) && !this.bBoss)
      this.fDmg *= (float) (1.0 + (double) PageBattle.GetMutation1(MutateType.eBombard) * 0.00999999977648258);
    if (!this.bRange && PageBattle.CheckMutation(MutateType.eStrength) && !this.bBoss)
      this.fDmg *= (float) (1.0 + (double) PageBattle.GetMutation1(MutateType.eStrength) * 0.00999999977648258);
    this.fDmg *= (float) (1.0 - (double) Info.GetElementalFac(ElementalID.eLightBase1, 0) * 0.00999999977648258);
    this.eMove = enemy.eMove;
    this.bAttack = this.eMove == MoveType.eTeleport;
    this.fMoveTimer = this.eMove == MoveType.eTeleport ? 0.0f : Random.Range(1f, 2f);
    this.moveZigPos = Vector2.zero;
    this.listMut.Clear();
    this.dictMutTime.Clear();
    this.dictMutTimer.Clear();
    this.dictMutDur.Clear();
    this.dictMutActive.Clear();
    this.fInvincibleDur = 0.0f;
    this.fEntangleReduce = this.fStunReduce = 1f;
    this.psInvincible.gameObject.SetActive(false);
    if (this.bBoss)
    {
      if (PageBattle.CheckMutation(MutateType.eDash))
      {
        this.fSpeed *= (float) (1.0 + (double) PageBattle.GetMutation1(MutateType.eDash) * 0.00999999977648258);
        this.movePos.x = this.fSpeed;
        this.fZigSpd = (float) (-(double) this.fSpeed * 0.5);
      }
      if (PageBattle.CheckMutation(MutateType.eInvincible))
        this.AddMutation(MutateType.eInvincible, PageBattle.GetMutation1(MutateType.eInvincible), PageBattle.GetMutation2(MutateType.eInvincible));
      if (PageBattle.CheckMutation(MutateType.eHealer))
        this.AddMutation(MutateType.eHealer, PageBattle.GetMutation2(MutateType.eHealer), 0.0f);
      if (PageBattle.CheckMutation(MutateType.eTaunt))
        this.AddMutation(MutateType.eTaunt, PageBattle.GetMutation1(MutateType.eTaunt), PageBattle.GetMutation2(MutateType.eTaunt));
      if (PageBattle.CheckMutation(MutateType.eDrain))
        this.AddMutation(MutateType.eDrain, 1f, 0.0f);
      if (PageBattle.CheckMutation(MutateType.eAbsorb))
      {
        this.psInvincible.gameObject.SetActive(true);
        this.psInvincible.Play(false);
      }
      if (PageBattle.CheckMutation(MutateType.eReload))
        this.AddMutation(MutateType.eReload, PageBattle.GetMutation1(MutateType.eReload), 0.0f);
      if (PageBattle.obj.eTrial == MutateType.eReflection)
        this.AddMutation(MutateType.eReflection, 12f, 4f);
    }
    if (PageBattle.CheckMutation(MutateType.eRegen) && !this.bBoss)
    {
      this.listMut.Add(MutateType.eRegen);
      this.dictMutDur.Add(MutateType.eRegen, 0.0f);
      this.dictMutTimer.Add(MutateType.eRegen, 0.0f);
      this.dictMutTime.Add(MutateType.eRegen, 0.0f);
      this.dictMutActive.Add(MutateType.eRegen, 1f);
    }
    this.bHide = PageBattle.CheckMutation(MutateType.eStealth) && !this.bRange && !this.bBoss;
    if (PageBattle.obj.eTrial == MutateType.eShadow)
      this.bHide = this.bBoss;
    else if (PageBattle.obj.eTrial == MutateType.eDarkMyst)
      this.bHide = true;
    this.sr.color = !this.bHide ? Color.white : Enemy.colorHide;
    this.transform.localScale = Vector3.one * (!this.bBoss ? (!PageBattle.CheckMutation(MutateType.eGiant) ? 225f : 350f) : 450f);
    if (PageBattle.obj.eTrial == MutateType.eGoliat && this.bBoss)
      this.transform.localScale = Vector3.one * 100f;
    if (PageBattle.obj.eTrial == MutateType.eGodBless)
      this.nProtect = 5 + (!this.bBoss ? 0 : 10);
    this.hpbarBack.transform.localScale = Vector3.one * (!this.bBoss ? 0.5f : 0.75f);
    this.GetComponent<BoxCollider2D>().enabled = true;
    this.eArmor = enemy.eArmor;
    for (int index = 0; index < this.listMut.Count; ++index)
      this.dictMutTimer[this.listMut[index]] = this.dictMutActive[this.listMut[index]] * 0.5f;
    this.goCastGuage.SetActive(PageBattle.obj.eTrial == MutateType.eNone ? this.listMut.Contains(this.eGuageMut) : (int) Info.nDiffTrial < 2 && this.listMut.Contains(this.eGuageMut));
    this.dMaxHPDivider = 1.0 / this.maxhp;
    if ((double) Info.GetElementalFac(ElementalID.eDarkLowEmHP, 0) > 0.0)
      this.hp = this.maxhp * (1.0 - (double) Info.GetElementalFac(ElementalID.eDarkLowEmHP, 0) * (!this.bBoss ? 0.01 : 0.002));
    this.UpdateHealthbar();
  }

  public void SetStop()
  {
    this.eMove = MoveType.eStop;
    this.fSpeed = 0.0f;
    this.movePos = Vector2.zero;
    this.fZigSpd = 0.0f;
  }

  public Enemy AddMutation(MutateType eID, float fActive, float fTime = 0.0f)
  {
    if (this.bBoss && PageBattle.obj.eTrial == MutateType.eGuardian)
      return this;
    switch (eID)
    {
      case MutateType.eInvincible:
      case MutateType.eHealer:
      case MutateType.eTaunt:
      case MutateType.eDrain:
      case MutateType.eReload:
        this.eGuageMut = eID;
        break;
      default:
        if (eID == MutateType.eReflection)
          goto case MutateType.eInvincible;
        else
          break;
    }
    this.listMut.Add(eID);
    this.dictMutDur.Add(eID, 0.0f);
    this.dictMutTimer.Add(eID, 0.0f);
    this.dictMutTime.Add(eID, fTime);
    this.dictMutActive.Add(eID, fActive);
    this.goCastGuage.SetActive(this.listMut.Contains(this.eGuageMut));
    return this;
  }

  private void Update()
  {
    if (this.bDead)
    {
      this.fDeadTime += Time.deltaTime;
      this.rigid.velocity = new Vector2((float) ((1.0 - (double) this.fDeadTime) * 220.0), 0.0f);
      if ((double) this.fDeadTime <= 1.0)
        return;
      PageBattle.obj.OnEnemyDisable(this);
    }
    else
    {
      if ((bool) PageBattle.obj.bBattleOver)
        return;
      if (!this.bDead)
      {
        if ((double) this.fEntangleDur > 0.0)
        {
          this.fEntangleDur -= Time.deltaTime;
          if ((double) this.fEntangleDur <= 0.0)
            this.EndEntangle();
        }
        if ((double) this.fStunDur > 0.0)
        {
          this.fStunDur -= Time.deltaTime;
          if ((double) this.fStunDur <= 0.0)
            this.EndStun();
        }
        if ((double) this.fInvincibleDur > 0.0)
        {
          this.fInvincibleDur -= Time.deltaTime;
          if ((double) this.fInvincibleDur <= 0.0)
          {
            this.fInvincibleDur = 0.0f;
            this.psInvincible.gameObject.SetActive(false);
            this.psInvincible.Stop();
          }
        }
        for (int index1 = 0; index1 < this.listMut.Count; ++index1)
        {
          if ((double) this.dictMutActive[this.listMut[index1]] != 0.0)
          {
            if ((double) this.dictMutDur[this.listMut[index1]] <= 0.0)
            {
              Dictionary<MutateType, float> dictMutTimer;
              MutateType index2;
              (dictMutTimer = this.dictMutTimer)[index2 = this.listMut[index1]] = dictMutTimer[index2] + Time.deltaTime;
              if ((double) this.dictMutTimer[this.listMut[index1]] >= (double) this.dictMutActive[this.listMut[index1]])
              {
                this.dictMutTimer[this.listMut[index1]] = 0.0f;
                this.dictMutDur[this.listMut[index1]] = this.dictMutTime[this.listMut[index1]];
                this.srCastFill.color = Color.red;
                this.OnActiveMut(this.listMut[index1]);
              }
            }
            else
            {
              Dictionary<MutateType, float> dictMutDur;
              MutateType index2;
              (dictMutDur = this.dictMutDur)[index2 = this.listMut[index1]] = dictMutDur[index2] - Time.deltaTime;
              if ((double) this.dictMutDur[this.listMut[index1]] <= 0.0)
              {
                this.dictMutDur[this.listMut[index1]] = 0.0f;
                this.OnDeactiveMut(this.listMut[index1]);
                this.srCastFill.color = Color.yellow;
              }
            }
            if (this.listMut[index1] == this.eGuageMut)
              this.trCastGuage.localScale = (double) this.dictMutDur[this.listMut[index1]] <= 0.0 ? new Vector3(Mathf.Clamp(this.dictMutTimer[this.listMut[index1]] / Mathf.Max(this.dictMutActive[this.listMut[index1]], 1f), 0.0f, 1f), 1f) : new Vector3(Mathf.Clamp(this.dictMutDur[this.listMut[index1]] / Mathf.Max(this.dictMutTime[this.listMut[index1]], 1f), 0.0f, 1f), 1f);
          }
        }
      }
      if ((double) this.transform.localPosition.x < -210.0)
      {
        this.transform.localPosition = new Vector3(-210f, this.transform.localPosition.y);
        this.Stop();
      }
      if (this.isStun || this.isEntangle)
        return;
      this.sr.sortingOrder = 400 - (int) this.transform.localPosition.y;
      this.hpbarBack.sortingOrder = this.sr.sortingOrder + 1;
      this.hpbar.sortingOrder = this.hpbarBack.sortingOrder + 1;
      this.bClose = (double) this.transform.localPosition.x <= -210.0;
      if ((double) Info.GetElementalFac(ElementalID.eNatureObs1, 0) > 0.0 && this.bClose && !this.bNatureObs)
      {
        this.bNatureObs = true;
        this.SetEntangle(3f);
      }
      if (this.bHide && PageBattle.obj.eTrial != MutateType.eShadow)
      {
        this.bHide = (double) this.transform.localPosition.x > -30.0;
        if (!this.bHide)
          this.sr.color = Color.white;
      }
      if (!this.bAttack)
      {
        if (this.bClose)
        {
          this.bAttack = true;
          this.Stop();
        }
        else
        {
          if (this.eMove == MoveType.eInterval || this.eMove == MoveType.eTeleport)
          {
            this.fMoveTimer -= Time.deltaTime;
            if ((double) this.fMoveTimer <= 0.0)
            {
              this.fStopTimer = !this.bRange ? (this.eMove != MoveType.eTeleport ? Random.Range(0.5f, 1f) : Random.Range(1f, 3f)) : ((double) this.transform.localPosition.x <= (double) this.fRange ? Random.Range(this.fAtkCool, this.fAtkCool * 2f) : Random.Range(0.0f, 2f));
              this.Stop();
              this.bAttack = true;
              return;
            }
          }
          else if (this.eMove == MoveType.eZigZag)
          {
            this.fMoveTimer -= Time.deltaTime;
            if ((double) this.fMoveTimer <= 0.0)
            {
              this.bZigZag = !this.bZigZag;
              this.fStopTimer = !this.bRange ? 0.0f : ((double) this.transform.localPosition.x <= (double) this.fRange ? Random.Range(this.fAtkCool, this.fAtkCool * 2f) : Random.Range(0.0f, 2f));
              this.Stop();
              this.bAttack = true;
              return;
            }
            if ((double) this.transform.position.y > 120.0)
              this.bZigZag = false;
            if ((double) this.transform.position.y < -140.0)
              this.bZigZag = true;
            this.moveZigPos.y = this.fZigSpd * (!this.bZigZag ? -1f : 1f);
          }
          else if (this.eMove == MoveType.eStop)
          {
            this.Stop();
            this.bAttack = true;
          }
          if (this.eMove == MoveType.eTeleport)
            return;
          this.animator.SetFloat("VelocityX", (float) (-(double) this.rigid.velocity.x * 1000.0));
          this.rigid.velocity = this.movePos + this.moveZigPos;
        }
      }
      else
      {
        if ((double) this.fStopTimer > 0.0)
          this.fStopTimer -= Time.deltaTime;
        if ((double) this.fStopTimer <= 0.0 && ((double) this.transform.localPosition.x > (double) this.fRange || !this.bClose))
        {
          this.bAttack = false;
          if (this.eMove == MoveType.eTeleport && !this.bClose)
            this.transform.localPosition = new Vector3(Mathf.Max(-210f, this.transform.localPosition.x + Random.Range(this.fSpeed * 0.5f, this.fSpeed)), (float) Random.Range(-150, 130));
          if (this.eMove == MoveType.eInterval || this.eMove == MoveType.eZigZag)
            this.fMoveTimer = Random.Range(2f, 4f);
        }
        if ((double) this.transform.localPosition.x > (double) this.fRange)
          return;
        this.fAtkTimer += Time.deltaTime * (float) Info.fEmAspBonus;
        if ((double) this.fAtkTimer < (double) this.fAtkCool)
          return;
        this.fAtkTimer -= this.fAtkCool;
        if (this.bTryAttack)
        {
          if (this.bClose)
            PageBattle.obj.OnEnemyAttack(this);
          else
            PageBattle.obj.OnEnemyShooting(this);
        }
        this.bTryAttack = true;
        this.animator.SetTrigger(!this.bClose ? "TriggerCast" : "TriggerAttack");
      }
    }
  }

  public bool CheckMutate(MutateType eID)
  {
    return this.listMut.Contains(eID) && (double) this.dictMutDur[eID] > 0.0;
  }

  public void SetCursed(bool _bCursed)
  {
    this.bCursed = _bCursed;
    this.sr.color = Color.magenta;
  }

  public void OnActiveMut(MutateType eID)
  {
    switch (eID)
    {
      case MutateType.eInvincible:
      case MutateType.eTaunt:
        this.psInvincible.gameObject.SetActive(true);
        this.psInvincible.Play(true);
        break;
      case MutateType.eHealer:
        PageBattle.obj.OnHealerActive(this);
        break;
      case MutateType.eDrain:
        PageBattle.obj.OnCorruptActive(this);
        break;
      case MutateType.eRegen:
        this.SetDamage(-this.maxhp * ((double) PageBattle.GetMutation1(MutateType.eRegen) * 0.01));
        break;
      case MutateType.eReload:
        PageBattle.obj.OnForceReloadActive(this);
        break;
      default:
        if (eID != MutateType.eReflection)
          break;
        goto case MutateType.eInvincible;
    }
  }

  public void OnDeactiveMut(MutateType eID)
  {
    if (eID != MutateType.eInvincible && eID != MutateType.eTaunt && eID != MutateType.eReflection)
      return;
    this.psInvincible.gameObject.SetActive(false);
    this.psInvincible.Stop();
  }

  public void SetInvincible(float fTime)
  {
    this.fInvincibleDur = fTime;
    if ((double) fTime > 0.0)
    {
      this.psInvincible.gameObject.SetActive(true);
      this.psInvincible.Play(true);
    }
    else
    {
      this.psInvincible.gameObject.SetActive(false);
      this.psInvincible.Stop();
      this.nProtect = 0;
      this.bDivine = false;
    }
  }

  public void Shoot()
  {
    this.bTryAttack = false;
    if (this.bRange)
      PageBattle.obj.OnEnemyShooting(this);
    else
      PageBattle.obj.OnEnemyAttack(this);
  }

  public void OnCastComplete()
  {
    this.bTryAttack = false;
    if (this.bRange)
      PageBattle.obj.OnEnemyShooting(this);
    else
      PageBattle.obj.OnEnemyAttack(this);
  }

  public void OnCastEffect()
  {
  }

  private void Stop()
  {
    this.animator.SetFloat("VelocityX", 0.0f);
    this.rigid.velocity = (Vector2) Vector3.zero;
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    if (this.isDead || !(col.tag == "Bullet"))
      return;
    PageBattle.obj.OnCollisionBullet(col.GetComponent<Bullet>(), this);
  }

  public void SetDamage(double fDmg)
  {
    if (fDmg == 0.0 && this.nProtect > 0)
      --this.nProtect;
    if (fDmg > 0.0)
      this.animator.SetBool("TriggerHurt", true);
    if (fDmg < 0.0)
    {
      fDmg *= 1.0 - (double) Info.GetPartySkillFac(SkillKey.eEnemyRegenParty) * 0.00999999977648258;
      fDmg *= 1.0 - (double) Info.GetElementalFac(ElementalID.eWaterRegenSlow, 0) * 0.00999999977648258;
    }
    this.hp -= fDmg;
    if (this.hp > this.maxhp)
      this.hp = this.maxhp;
    else if (this.hp < 0.0)
      this.hp = 0.0;
    this.animator.SetInteger("Health", this.hp <= 0.0 ? 0 : 1);
    if (this.hp <= 0.0)
    {
      this.rigid.velocity = Vector2.zero;
      this.rigid.collisionDetectionMode = CollisionDetectionMode2D.None;
      this.bDead = true;
      this.goCastGuage.SetActive(false);
      this.psInvincible.gameObject.SetActive(false);
      this.psInvincible.Stop();
      this.bHide = false;
      this.sr.color = Color.white;
      this.GetComponent<BoxCollider2D>().enabled = false;
      PageBattle.obj.OnEnemyDead(this);
      this.hp = 0.0;
      this.EndStun();
      this.EndEntangle();
      if (this.cr != null)
        this.StopCoroutine(this.cr);
    }
    this.UpdateHealthbar();
  }

  public void SetKnockback(float fKnockback)
  {
    if (this.bBoss)
      return;
    this.vKnockback.x = fKnockback;
    if ((double) this.rigid.velocity.x >= (double) this.vKnockback.x)
      return;
    this.rigid.AddForce(this.vKnockback, ForceMode2D.Impulse);
  }

  public void SetStun(float fTime)
  {
    if (this.cr != null)
      this.StopCoroutine(this.cr);
    this.Stop();
    if (this.bBoss)
      fTime *= 0.2f;
    if (Info.eBattle == BattleType.eTrial && this.bBoss)
      fTime *= 0.5f;
    if ((double) fTime > 0.0)
      this.fStunReduce *= 0.92f;
    this.fStunDur = fTime * this.fStunReduce;
    this.animator.SetBool("TriggerHurt", true);
    if ((double) this.fStunDur > 0.0)
      this.animator.speed = 0.0f;
    else
      this.animator.speed = 1f;
  }

  public void SetEntangle(float fTime)
  {
    this.Stop();
    if (this.bBoss)
      fTime *= 0.2f;
    if (Info.eBattle == BattleType.eTrial && this.bBoss)
      fTime *= 0.5f;
    if ((double) fTime > 0.0)
      this.fEntangleReduce *= 0.92f;
    this.fEntangleDur = fTime * this.fEntangleReduce;
    this.animator.SetBool("TriggerHurt", true);
    if ((double) this.fEntangleDur <= 0.0)
      return;
    this.animator.speed = 0.0f;
  }

  public void SetPolymorph(double fFac)
  {
    if (fFac < 0.0 || this.hp < 0.0)
      return;
    if (this.bBoss)
      fFac *= 0.100000001490116;
    if (Info.eBattle == BattleType.eTrial)
      fFac *= 0.100000001490116;
    this.hp *= 1.0 - fFac;
    this.maxhp *= 1.0 - fFac;
    if (this.hp < 0.0)
      this.hp = 1.0;
    this.fSpeed *= 1f - (float) fFac;
    this.fAtkCool *= 1f + (float) fFac;
    this.SetSlow(0.0f);
    this.animator.runtimeAnimatorController = RSMgr.GetController("willow_controller");
  }

  public void EndStun()
  {
    this.fStunDur = 0.0f;
    this.animator.speed = !this.isEntangle ? 1f : 0.0f;
  }

  public void EndEntangle()
  {
    this.fEntangleDur = 0.0f;
    this.animator.speed = !this.isStun ? 1f : 0.0f;
  }

  public void SetSlow(float fFac)
  {
    if (this.bClose || Info.eBattle == BattleType.eTrial && this.bBoss || this.eMove == MoveType.eTeleport)
      return;
    if (this.bBoss && (double) fFac > 0.0)
      fFac *= 0.1f;
    if ((double) fFac > 0.0)
      this.fSlowRate = this.fSlowRate * (float) (1.0 - (double) fFac * 0.00999999977648258);
    else
      this.fSpeed = Mathf.Clamp((float) ((double) this.fSpeed * 1.0 - (double) fFac * 0.00999999977648258), -10000f, 0.0f);
    this.fSlowRate = Mathf.Clamp(this.fSlowRate, 0.05f, 1f);
    this.movePos.x = Mathf.Clamp(this.fSpeed * this.fSlowRate, -2000f, -10f);
  }

  public void UpdateHealthbar()
  {
    this.fHPRate = Mathf.Clamp((float) (this.hp * this.dMaxHPDivider), 0.0f, 1f);
    SpriteRenderer hpbarBack = this.hpbarBack;
    bool flag = (double) this.fHPRate != 1.0 && (double) this.fHPRate != 0.0;
    this.hpbar.enabled = flag;
    int num = flag ? 1 : 0;
    hpbarBack.enabled = num != 0;
    this.hpbar.color = new Color(Mathf.Clamp((float) ((0.600000023841858 - (double) this.fHPRate) * 5.0), 0.0f, 1f), 1f - Mathf.Clamp((float) ((0.400000005960464 - (double) this.fHPRate) * 4.0), 0.0f, 1f), 0.0f, 1f);
    this.hpbar.transform.localScale = new Vector3(this.fHPRate, 1f);
  }

  public void SetTakeDmg(float fAdd)
  {
    this.fTakeDmg = Mathf.Max(this.fTakeDmg, fAdd);
  }

  public void SetTakeDmg2(float fAdd)
  {
    this.fTakeDmg2 = Mathf.Max(this.fTakeDmg2, fAdd);
  }

  public void OnSleep()
  {
    this.vMove = this.rigid.velocity;
    this.rigid.Sleep();
  }

  public void OnWakeUp()
  {
    this.rigid.WakeUp();
    this.rigid.velocity = this.vMove;
  }
}
