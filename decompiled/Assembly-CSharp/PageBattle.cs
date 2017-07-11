// Decompiled with JetBrains decompiler
// Type: PageBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using DigitalRuby.ThunderAndLightning;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Thinksquirrel.CShake;
using UnityEngine;
using UnityEngine.UI;

public class PageBattle : UIMgr
{
  public static List<MutateType> listMutation = new List<MutateType>();
  public static Dictionary<MutateType, ObscuredFloat> dictMutation1 = new Dictionary<MutateType, ObscuredFloat>();
  public static Dictionary<MutateType, ObscuredFloat> dictMutation2 = new Dictionary<MutateType, ObscuredFloat>();
  public static float fDropRate = 15f;
  private static float fSpawnX = 420f;
  private static Vector3 vShakePos = new Vector3(1.6f, 1f);
  private static float[] fDegreeFireLance = new float[5]
  {
    -40f,
    -20f,
    0.0f,
    20f,
    40f
  };
  private static Vector3 vEnemyFirePos = new Vector3(-8f, 16f);
  private List<Bullet> listBulletAlive = new List<Bullet>();
  private List<Bullet> listBulletDead = new List<Bullet>();
  private List<EnemyBullet> listEnemyBulletAlive = new List<EnemyBullet>();
  private List<EnemyBullet> listEnemyBulletDead = new List<EnemyBullet>();
  private List<BattleCoinElt> listCoinAlive = new List<BattleCoinElt>();
  private List<BattleCoinElt> listCoinDead = new List<BattleCoinElt>();
  public Enemy[] emTrialBoss = new Enemy[0];
  private List<DmgText> listDmgText = new List<DmgText>();
  [HideInInspector]
  public ObscuredBool bBattleOver = (ObscuredBool) false;
  [HideInInspector]
  public ObscuredBool bGameOver = (ObscuredBool) false;
  [HideInInspector]
  public Vector2 vScreen = new Vector2();
  [HideInInspector]
  public Vector3 vGoldPos = new Vector3();
  [HideInInspector]
  public Vector3 vItemPos = new Vector3();
  [HideInInspector]
  public Vector3 vHpPos = new Vector3();
  private ObscuredFloat fInvincibleDur = (ObscuredFloat) 0.0f;
  private ObscuredInt nHarvestNum = (ObscuredInt) 0;
  private ObscuredInt nDamagedNum = (ObscuredInt) 0;
  private ObscuredFloat fBigShieldHP = (ObscuredFloat) 0.0f;
  private List<short> listRandomSpawn = new List<short>();
  private Color clScreen = Color.black;
  private float fScreenSpd = 1f;
  public ObscuredInt nMustReduced = (ObscuredInt) 0;
  public ObscuredFloat fLightShield = (ObscuredFloat) 0.0f;
  public ObscuredBool bLightShield = (ObscuredBool) false;
  public ObscuredFloat fPainKillerDur = (ObscuredFloat) 0.0f;
  public ObscuredFloat fPainKillerCool = (ObscuredFloat) 0.0f;
  public ObscuredBool bCanRevive = (ObscuredBool) false;
  public ObscuredFloat fDarkMutDmg = (ObscuredFloat) 1f;
  public float fCurrentBalanceGuage = 0.5f;
  public float fAddBalanceGuage = 0.2f;
  private ObscuredFloat fTrialHP = (ObscuredFloat) 0.0f;
  private ObscuredFloat fHPRate = (ObscuredFloat) 1f;
  private RaycastHit2D[] hits = new RaycastHit2D[100];
  private ObscuredFloat fDungeonDef = (ObscuredFloat) 1f;
  private ObscuredFloat fNatureShell = (ObscuredFloat) 1f;
  protected Dictionary<int, Dictionary<SkillKey, float[]>> dictSkillFac = new Dictionary<int, Dictionary<SkillKey, float[]>>();
  private Rect rtBox = new Rect(0.0f, 0.0f, 1f, 24f);
  private Vector3 vFirePos = new Vector3(8f, 16f);
  private Vector3 vLaserPos = new Vector3(2f, 24f);
  private Vector3 vLightningPos = new Vector3(4f, 42f);
  private int nLaserOrder = 1;
  private RaycastHit2D[] arrRayHits = new RaycastHit2D[50];
  private Vector3 vHitPos = new Vector3();
  private int[] nStoneOrder = new int[6];
  public static PageBattle obj;
  public AudioSource _asMusic;
  public List<Monster> listMonster;
  public List<Enemy> listEnemy;
  public Text textGold;
  public Text textWave;
  public Text textHP;
  public Text textItem;
  public Text textDay;
  public Text textDiff;
  public GameObject eltEnemy;
  public Transform trBattle;
  public DmgText dmgText;
  public Transform trDmgTextList;
  public GameObject goBullet;
  public GameObject goEnemyBullet;
  public Image imgFillAmmo;
  public Image imgAmmoIcon;
  public Text textAmmo;
  public ActiveSkillElt[] arrActiveSkill;
  public RectTransform rtLeftSkill;
  public GameObject goLeftSkill;
  public GameObject goBotSkill;
  public ActiveSkillElt[] arrActiveSkillLeft;
  public AwakenSkillElt eltAwakenBot;
  public AwakenSkillElt eltAwakenLeft;
  public CanvasGroup cgAlarm;
  public Text textAlarmTitle;
  public Text textAlarmSub;
  public CanvasGroup cgMutationAlarm;
  public Text textMutAlarmTitle;
  public Text textMutAlarmSub;
  public Text textMutDesc;
  public CanvasGroup cgWaveAlarm;
  public Text texWaveAlarm;
  public Image imgGoldIcon;
  public Image imgItemIcon;
  public ParticleElt psGold;
  public ParticleElt psItem;
  public ParticleElt psHp;
  public GameObject goCoin;
  public GameObject goBoss;
  public Image imgBossHP;
  public Image imgDunHP;
  public GameObject goDarkMyst;
  public GameObject goNumQuiz;
  public GameObject goClock;
  public GameObject goStone;
  public GameObject[] arrStoneActive;
  public BattleLaserElt[] arrLaser;
  public AudioSource asLaser;
  public Text[] textNumQuiz;
  public GameObject goDmgMeter;
  public Text textDmgMeter;
  public GameObject[] goDmgMeterUnit;
  public Image[] arrDmgMeterFill;
  public Text[] arrDmgMeterName;
  public Text[] arrDmgMeterAmount;
  public GameObject[] goBattleBG;
  public LightningBoltPrefabScript pLightning;
  public ParticleElt psBlizzard;
  public ParticleElt psDivine;
  public Text textAutoBattleStart;
  public GameObject goAutoBattleStart;
  public GameObject goAutoBattleStartOn;
  public SpriteRenderer srBlockGradient;
  public SpriteRenderer srBlockLeft;
  private float fShowGold;
  private float fTargetGold;
  private int nTargetItemCnt;
  private int nMainMon;
  private int nAnswer;
  private int nQuizTime;
  public short sBossID;
  public Image imgBalanceGuage;
  public GameObject goBalanceGuage;
  private float fSoulBombDps;
  private Material matLaser;
  private int nDmgText;
  public Image imgScreenFX;
  public float fSuperLaserTime;
  public float fSuperBladeTime;
  public float fSuperLightningTime;
  public MutateType eTrial;
  private ObscuredInt nDiff;
  private ObscuredInt nDay;
  private bool bMutate;
  private bool bBossMutate;
  private string strMutation;
  private string strMutationDesc;
  private Monster pSoulMon;
  private Vector3 vTargetPos;
  private bool bSummon;
  private float fWaveTime;
  private int nWaveTarget;
  private bool bNoWeapon;
  private bool bLastEnemyAlive;
  private float fLastCheckTime;
  private Coroutine crAlarm;
  private int nNowStoneOrder;

  public Monster mainMonster
  {
    get
    {
      return this.listMonster[this.nMainMon];
    }
  }

  public static int nMutationDay
  {
    get
    {
      return (int) Info.nMutateStartDay[(int) Info.currentSave.nDiff];
    }
  }

  private bool isInvincible
  {
    get
    {
      return (double) (float) this.fInvincibleDur > 0.0;
    }
  }

  public ObscuredInt nExp
  {
    get
    {
      return Info.nBattleExp;
    }
    set
    {
      Info.nBattleExp = value;
    }
  }

  public ObscuredInt nGold
  {
    get
    {
      return Info.nBattleGold;
    }
    set
    {
      Info.nBattleGold = value;
    }
  }

  public ObscuredInt nItem
  {
    get
    {
      return (ObscuredInt) Info.listDropItem.Count;
    }
  }

  public ObscuredInt nWave
  {
    get
    {
      return Info.wave.nCurrentWave;
    }
    set
    {
      Info.wave.nCurrentWave = value;
      if (Info.eBattle == BattleType.eSurvial)
      {
        this.textDay.text = BData.GetString("UI0061").Replace("[1]", Info.currentSave.nDay.ToString()) + " Wave " + Info.wave.nCurrentWave.ToString("####0") + "/" + Info.wave.nMaxWave.ToString("##0");
        if ((int) value == 0)
          return;
        this.SetWaveAlarm(Info.wave.nCurrentWave.ToString("####0") + "/" + Info.wave.nMaxWave.ToString("##0"), 0.5f, 1f, 0.5f);
      }
      else
      {
        if (Info.eBattle != BattleType.eEndless)
          return;
        this.textDay.text = BData.GetString("UI0268") + " Wave " + (object) Info.wave.nCurrentWave + " (" + (object) Info.currentSave.nMaxEndless + ")";
        this.nDay = (ObscuredInt) (10 + (int) Info.wave.nCurrentWave * 4);
        if ((int) value == 0)
          return;
        this.SetWaveAlarm(Info.wave.nCurrentWave.ToString("####0"), 0.5f, 1f, 0.5f);
      }
    }
  }

  public ObscuredFloat fHP
  {
    get
    {
      if (Info.eBattle == BattleType.eSurvial)
        return Info.currentSave.fDunCurHP;
      return this.fTrialHP;
    }
    set
    {
      float num = Info.eBattle != BattleType.eSurvial ? (float) (this.fTrialHP = (ObscuredFloat) Mathf.Clamp((float) value, 0.0f, (float) Info.fDunMaxHP)) : (float) (Info.currentSave.fDunCurHP = (ObscuredFloat) Mathf.Clamp((float) value, 0.0f, (float) Info.fDunMaxHP));
      this.fHPRate = (ObscuredFloat) Mathf.Clamp((float) this.fHP / (float) Info.fDunMaxHP, 0.0f, 1f);
      this.imgDunHP.color = new Color(Mathf.Clamp((float) ((0.600000023841858 - (double) (float) this.fHPRate) * 5.0), 0.0f, 1f), 1f - Mathf.Clamp((float) ((0.400000005960464 - (double) (float) this.fHPRate) * 4.0), 0.0f, 1f), 0.0f, 1f);
      this.imgDunHP.fillAmount = (float) this.fHPRate;
      this.textHP.text = num.ToString("N0") + "/" + Info.fDunMaxHP.ToString("N0");
    }
  }

  private short sRandomEnemy
  {
    get
    {
      return this.listRandomSpawn[Random.Range(0, this.listRandomSpawn.Count)];
    }
  }

  private BattleItemData currentWeapon
  {
    get
    {
      return Info.GetBattleItem(this.mainMonster.nEquip);
    }
  }

  private ObscuredInt crAmmo
  {
    get
    {
      return this.mainMonster.nAmmo;
    }
  }

  private ObscuredInt crMaxAmmo
  {
    get
    {
      return this.mainMonster.nMaxAmmo;
    }
  }

  private bool isClear
  {
    get
    {
      for (int index = 0; index < this.listEnemy.Count; ++index)
      {
        if (this.listEnemy[index].gameObject.activeInHierarchy)
          return false;
      }
      return true;
    }
  }

  protected override void Awake()
  {
    base.Awake();
    Info.dictMonHP.Clear();
    PageBattle.obj = this;
    Info.bBattleFail = false;
    this.goBoss.SetActive(false);
    this.imgBossHP.fillAmount = 1f;
    UIMgr.dictPlaylist.Clear();
    Camera.main.orthographicSize = 225f + Mathf.Clamp((float) ((1.60000002384186 - (double) Screen.width / (double) Screen.height) * 168.0), 0.0f, 50f);
    if ((double) Camera.main.orthographicSize != 225.0)
      this.rtLeftSkill.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float) (800.0 - ((double) Camera.main.orthographicSize - 225.0) * 3.0));
    UIMgr.asMusic = this._asMusic;
    Info.fDoubleDayPass = (ObscuredFloat) 1f;
    this.nGold = (ObscuredInt) 0;
    this.nExp = (ObscuredInt) 0;
    this.nWave = (ObscuredInt) 0;
    this.nTargetItemCnt = 0;
    this.nDamagedNum = this.nHarvestNum = (ObscuredInt) 0;
    this.fShowGold = 0.0f;
    this.fTargetGold = 0.0f;
    this.textGold.text = "0";
    this.ClearAllEnemy();
    Info.RefreshAccMod();
    Info.RefreshBattleItemData();
    for (int index = 0; index < 50; ++index)
      this.CreateEnemy();
    this.listDmgText.Add(this.dmgText);
    this.dmgText.gameObject.SetActive(false);
    for (int index = 1; index < 100; ++index)
    {
      GameObject gameObject = Object.Instantiate<GameObject>(this.dmgText.gameObject);
      gameObject.transform.SetParent(this.trDmgTextList);
      gameObject.transform.localPosition = Vector3.zero;
      gameObject.transform.localScale = Vector3.one;
      gameObject.transform.localRotation = Quaternion.identity;
      this.listDmgText.Add(gameObject.GetComponent<DmgText>());
    }
    this.eltEnemy.gameObject.SetActive(false);
    this.goDmgMeter.SetActive(false);
    this.goAutoBattleStart.SetActive(Info.CheckRebirth(RebirthID.eStoneStatMax) && Info.eBattle != BattleType.eTrial);
    this.goAutoBattleStartOn.SetActive(Info.option.bAutoBattleStart);
    this.textAutoBattleStart.text = BData.GetString("UI0255");
    Info.RefreshResearchPower();
    Info.RefreshElementalFac();
    for (int index = 0; index < 100; ++index)
    {
      BattleCoinElt coin = this.CreateCoin();
      this.listCoinAlive.Remove(coin);
      this.listCoinDead.Add(coin);
      coin.gameObject.SetActive(false);
    }
    List<Bullet> bulletList = new List<Bullet>();
    for (int index = 0; index < 50; ++index)
      bulletList.Add(this.GetBullet(Vector3.zero));
    for (int index = 0; index < 50; ++index)
      this.OnBulletDiabled(bulletList[index]);
    this.eTrial = MutateType.eNone;
    Info.fEmAtkBonus = (ObscuredFloat) ((float) (1.0 - (double) Info.GetPartySkillFac(SkillKey.eCripple) * 0.00999999977648258));
    switch (Info.eBattle)
    {
      case BattleType.eSurvial:
        this.nDiff = Info.currentSave.nDiff;
        this.nDay = Info.currentSave.nDay;
        break;
      case BattleType.eTrial:
        TrialData trial = BData.GetTrial(Info.GetTrialClear(Info.currentSave.uRebirthID) + 1);
        this.eTrial = trial.eID;
        this.nDiff = Info.currentSave.nDiff;
        this.nDay = (ObscuredInt) Mathf.RoundToInt(Mathf.Max((float) trial.nDay, (float) (int) Info.currentSave.nDay * 0.9f) * Info.fDiffTrialDiffFac[(int) Info.nDiffTrial]);
        Info.fEmAtkBonus = (ObscuredFloat) ((float) Info.fEmAtkBonus * Info.fDiffTrialDiffDmg[(int) Info.nDiffTrial]);
        for (int index = 0; index < Info.fTrialCharge.Length; ++index)
          Info.fTrialCharge[index] = (ObscuredFloat) 0.0f;
        Info.fTrialAwakenCharge = (ObscuredFloat) 0.0f;
        break;
      case BattleType.eEndless:
        this.nDiff = Info.currentSave.nDiff;
        Info.wave.nCurrentWave = Info.nStartEndless;
        this.nDay = (ObscuredInt) ((int) Info.wave.nCurrentWave * 5);
        Info.wave.fWaveLenth = (ObscuredFloat) 3f;
        Info.wave.nSpawn = (ObscuredInt) 100;
        Info.wave.nMaxWave = (ObscuredInt) 9999;
        Info.fTrialAwakenCharge = (ObscuredFloat) 0.0f;
        for (int index = 0; index < Info.fTrialCharge.Length; ++index)
          Info.fTrialCharge[index] = (ObscuredFloat) 0.0f;
        break;
    }
    this.listRandomSpawn = BData.GetRandomEnemy((int) this.nDay);
    this.sBossID = BData.GetRandomBoss((int) this.nDay);
    this.bGameOver = (ObscuredBool) false;
    this.bBattleOver = (ObscuredBool) false;
    this.textItem.text = "x0";
    Info.fAtkBonus = (ObscuredFloat) 1f;
    Info.fAtkBonus = (ObscuredFloat) ((float) Info.fAtkBonus + Info.GetDungeonFactor(DungeonType.eParty, -1) * 0.01f);
    Info.listDropItem.Clear();
    PageBattle.fDropRate = (float) (18.0 - 18.0 * ((double) (int) this.nDay * 0.600000023841858) / (double) (20 + (int) this.nDay));
    Info.fEmAspBonus = (ObscuredFloat) 1f;
    this.fDarkMutDmg = (ObscuredFloat) 1f;
    PageBattle.listMutation.Clear();
    PageBattle.dictMutation1.Clear();
    PageBattle.dictMutation2.Clear();
    this.textMutDesc.text = string.Empty;
    if (Info.eBattle == BattleType.eSurvial)
    {
      this.fHP = Info.currentSave.fDunCurHP;
      this.textDiff.text = Info.GetDiffText((int) this.nDiff, false);
      this.SetMutation();
    }
    else if (Info.eBattle == BattleType.eTrial)
    {
      this.fHP = Info.fDunMaxHP;
      this.textDay.text = BData.GetString("UI0214") + " " + (Info.GetTrialClear(Info.currentSave.uRebirthID) + 1).ToString() + "F";
      this.textDiff.text = BData.GetString(BData.GetMutate(BData.GetTrial(Info.GetTrialClear(Info.currentSave.uRebirthID) + 1).eID).strName);
    }
    else if (Info.eBattle == BattleType.eEndless)
    {
      this.fHP = Info.fDunMaxHP;
      this.textDiff.text = Info.GetDiffText((int) this.nDiff, false);
    }
    this.matLaser = this.arrLaser[0].line.sharedMaterial;
    this.asLaser.volume = !Info.option.bMuteSound ? Info.option.fSound * 0.6f : 0.0f;
    Application.targetFrameRate = !Info.option.bOptimize ? 60 : 30;
    Info.bTempQuitBattle = false;
  }

  private void SetMutation()
  {
    PageBattle.listMutation.Clear();
    PageBattle.dictMutation1.Clear();
    PageBattle.dictMutation2.Clear();
    this.textMutDesc.text = string.Empty;
    if (Info.eBattle == BattleType.eSurvial && (int) this.nDay < PageBattle.nMutationDay || Info.eBattle == BattleType.eTrial)
      return;
    this.bMutate = true;
    int num1 = (int) this.nDay - PageBattle.nMutationDay;
    int num2 = 1;
    this.bBossMutate = false;
    if (Info.eBattle == BattleType.eSurvial)
    {
      int max;
      if ((int) this.nDay >= PageBattle.nMutationDay * 4)
      {
        max = 4;
        this.bBossMutate = true;
      }
      else if ((int) this.nDay >= PageBattle.nMutationDay * 3)
      {
        max = 3;
        if (Random.Range(0, PageBattle.nMutationDay) < (int) this.nDay - PageBattle.nMutationDay * 3)
          ++max;
        this.bBossMutate = (int) this.nDay % 2 == 0;
      }
      else if ((int) this.nDay >= PageBattle.nMutationDay * 2)
      {
        max = 2;
        this.bBossMutate = (int) this.nDay % 3 == 0;
        if (Random.Range(0, PageBattle.nMutationDay) < (int) this.nDay - PageBattle.nMutationDay * 2)
          ++max;
      }
      else
      {
        this.bBossMutate = (int) this.nDay % 5 == 0;
        max = 1;
        if (Random.Range(0, PageBattle.nMutationDay) < (int) this.nDay - PageBattle.nMutationDay)
          ++max;
      }
      num2 = Mathf.Clamp(max - Info.GetResearchFacInt(ResearchID.eConsecration), 1, max);
    }
    else if (Info.eBattle == BattleType.eEndless)
      num2 = Mathf.Clamp(num2 + (int) this.nDay / (int) Info.nEndlessMutationDay[(int) this.nDiff] - Info.GetResearchFacInt(ResearchID.eConsecration), 1, 5);
    if ((double) Random.Range(0.0f, 100f) < (double) Info.GetElementalFac(ElementalID.eLightRemoveMut, 0))
      --num2;
    this.bMutate = num2 > 0;
    float num3 = (float) ((double) ((float) num1 / ((float) (9 + num2) / 10f) * Info.fDiffMutGrow[(int) this.nDiff]) * (1.0 - (double) Info.GetResearchFac(ResearchID.eVaccine) * 0.00999999977648258) * (1.0 - (double) Info.GetPartySkillFac(SkillKey.eMutant) * 0.00999999977648258)) / (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eMutationInhibit) * 0.00999999977648258);
    List<MutateType> mutateTypeList = new List<MutateType>((IEnumerable<MutateType>) BData.listMutation);
    this.strMutation = num2 <= 0 ? string.Empty : BData.GetString("UI0141") + " : ";
    this.strMutationDesc = string.Empty;
    for (int index1 = 0; index1 < num2; ++index1)
    {
      MutateType index2 = mutateTypeList[Random.Range(0, mutateTypeList.Count)];
      MutationData mutate = BData.GetMutate(index2);
      PageBattle.dictMutation1.Add(index2, (ObscuredFloat) Mathf.Min(mutate.fMax1, mutate.fFac1 + mutate.fGrow1 * num3));
      PageBattle.dictMutation2.Add(index2, (ObscuredFloat) Mathf.Min(mutate.fMax2, mutate.fFac2 + mutate.fGrow2 * num3));
      PageBattle.listMutation.Add(index2);
      mutateTypeList.Remove(index2);
      if (index2 == MutateType.eDivine)
      {
        mutateTypeList.Remove(MutateType.eBarrier);
        mutateTypeList.Remove(MutateType.eBlock);
      }
      else if (index2 == MutateType.eBarrier || index2 == MutateType.eBlock)
        mutateTypeList.Remove(MutateType.eDivine);
      PageBattle pageBattle1 = this;
      string str1 = pageBattle1.strMutation + BData.GetString(mutate.strName) + (index1 != num2 - 1 ? ", " : string.Empty);
      pageBattle1.strMutation = str1;
      PageBattle pageBattle2 = this;
      string str2 = pageBattle2.strMutationDesc + BData.GetString(mutate.strDesc).Replace("[1]", PageBattle.dictMutation1[index2].ToString("N0")).Replace("[2]", PageBattle.dictMutation2[index2].ToString("N0")) + (index1 != num2 - 1 ? "\n" : string.Empty);
      pageBattle2.strMutationDesc = str2;
    }
    this.textMutDesc.text = this.strMutation;
    if (this.bBossMutate)
    {
      MutateType index = BData.listBossMutation[Random.Range(0, BData.listBossMutation.Count)];
      MutationData mutate = BData.GetMutate(index);
      PageBattle.dictMutation1.Add(index, (ObscuredFloat) ((double) mutate.fGrow1 >= 0.0 ? Mathf.Min(mutate.fMax1, mutate.fFac1 + mutate.fGrow1 * num3) : Mathf.Max(mutate.fMax1, mutate.fFac1 + mutate.fGrow1 * num3)));
      PageBattle.dictMutation2.Add(index, (ObscuredFloat) ((double) mutate.fGrow2 >= 0.0 ? Mathf.Min(mutate.fMax2, mutate.fFac2 + mutate.fGrow2 * num3) : Mathf.Max(mutate.fMax2, mutate.fFac2 + mutate.fGrow2 * num3)));
      PageBattle.listMutation.Add(index);
      PageBattle pageBattle1 = this;
      string str1 = pageBattle1.strMutation + ", " + BData.GetString(mutate.strName);
      pageBattle1.strMutation = str1;
      PageBattle pageBattle2 = this;
      string str2 = pageBattle2.strMutationDesc + "\n " + BData.GetString(mutate.strDesc).Replace("[1]", PageBattle.dictMutation1[index].ToString("N0")).Replace("[2]", PageBattle.dictMutation2[index].ToString("N0"));
      pageBattle2.strMutationDesc = str2;
    }
    Text textMutDesc = this.textMutDesc;
    string str = textMutDesc.text + "\n" + this.strMutationDesc;
    textMutDesc.text = str;
    if (PageBattle.CheckMutation(MutateType.eSwift))
      Info.fEmAspBonus = (ObscuredFloat) ((float) Info.fEmAspBonus + PageBattle.GetMutation1(MutateType.eSwift) * 0.01f);
    if (Info.eBattle == BattleType.eEndless && num2 > 0)
      this.SetMutationAlarm(this.strMutation, this.strMutationDesc, 0.0f, 2f, 1f);
    this.fDarkMutDmg = (ObscuredFloat) ((float) (1.0 + (double) num2 * (double) Info.GetElementalFac(ElementalID.eDarkMutDmg, 0) * 0.00999999977648258));
  }

  private Enemy CreateEnemy()
  {
    GameObject gameObject = Object.Instantiate<GameObject>(this.eltEnemy);
    Enemy component = gameObject.GetComponent<Enemy>();
    gameObject.transform.SetParent(this.trBattle);
    gameObject.transform.localPosition = Vector3.zero;
    gameObject.transform.localScale = Vector3.one * 200f;
    gameObject.transform.localRotation = Quaternion.identity;
    gameObject.SetActive(false);
    this.listEnemy.Add(component);
    return component;
  }

  private BattleCoinElt CreateCoin()
  {
    GameObject gameObject = Object.Instantiate<GameObject>(this.goCoin);
    BattleCoinElt component = gameObject.GetComponent<BattleCoinElt>();
    gameObject.transform.SetParent(this.trBattle);
    gameObject.transform.localPosition = Vector3.zero;
    gameObject.transform.localScale = Vector3.one;
    gameObject.transform.localRotation = Quaternion.identity;
    gameObject.SetActive(false);
    this.listCoinAlive.Add(component);
    return component;
  }

  protected override void Start()
  {
    base.Start();
    this.bNoWeapon = (long) Info.currentSave.arrPlayerMon[0].nEquip == -1L;
    if (!this.bNoWeapon)
      this.imgAmmoIcon.sprite = RSMgr.GetSprite(BData.GetWeapon((short) Info.GetBattleItem((long) Info.currentSave.arrPlayerMon[0].nEquip).sID).strBullet);
    this.vGoldPos = this.psGold.transform.position;
    this.vItemPos = this.psItem.transform.position;
    this.vHpPos = this.psHp.transform.position;
    this.vScreen = (Vector2) Camera.main.ScreenToWorldPoint((Vector3) new Vector2((float) Screen.width, (float) Screen.height));
    PageBattle.fSpawnX = this.vScreen.x;
    SpriteRenderer srBlockGradient1 = this.srBlockGradient;
    Color color1 = new Color(0.0f, 0.0f, 0.0f);
    this.srBlockLeft.color = color1;
    Color color2 = color1;
    srBlockGradient1.color = color2;
    if ((int) Info.rebirth.nEquippedElemental != 0)
    {
      int num = 0;
      foreach (KeyValuePair<ElementalID, ObscuredInt> keyValuePair in Info.rebirth.dictElementalTrait)
      {
        ElementalData elemental = BData.GetElemental(keyValuePair.Key);
        if (elemental.eElm == (Element) (int) Info.rebirth.nEquippedElemental && elemental.nDunLv > num)
          num = elemental.nDunLv;
      }
      if (num != 0)
        num = 5 * ((int) Info.rebirth.nEquippedElemental - 1) + num;
      for (int index = 0; index < this.goBattleBG.Length; ++index)
        this.goBattleBG[index].SetActive(index == num);
      switch (num)
      {
        case 1:
          SpriteRenderer srBlockGradient2 = this.srBlockGradient;
          Color color3 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color3;
          Color color4 = color3;
          srBlockGradient2.color = color4;
          break;
        case 2:
        case 3:
          SpriteRenderer srBlockGradient3 = this.srBlockGradient;
          Color color5 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color5;
          Color color6 = color5;
          srBlockGradient3.color = color6;
          break;
        case 4:
        case 5:
          SpriteRenderer srBlockGradient4 = this.srBlockGradient;
          Color color7 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color7;
          Color color8 = color7;
          srBlockGradient4.color = color8;
          break;
        case 6:
          SpriteRenderer srBlockGradient5 = this.srBlockGradient;
          Color color9 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color9;
          Color color10 = color9;
          srBlockGradient5.color = color10;
          break;
        case 7:
        case 8:
          SpriteRenderer srBlockGradient6 = this.srBlockGradient;
          Color color11 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color11;
          Color color12 = color11;
          srBlockGradient6.color = color12;
          break;
        case 9:
        case 10:
          SpriteRenderer srBlockGradient7 = this.srBlockGradient;
          Color color13 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color13;
          Color color14 = color13;
          srBlockGradient7.color = color14;
          break;
        case 11:
          SpriteRenderer srBlockGradient8 = this.srBlockGradient;
          Color color15 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color15;
          Color color16 = color15;
          srBlockGradient8.color = color16;
          break;
        case 12:
        case 13:
          SpriteRenderer srBlockGradient9 = this.srBlockGradient;
          Color color17 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color17;
          Color color18 = color17;
          srBlockGradient9.color = color18;
          break;
        case 14:
        case 15:
          SpriteRenderer srBlockGradient10 = this.srBlockGradient;
          Color color19 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color19;
          Color color20 = color19;
          srBlockGradient10.color = color20;
          break;
        case 16:
          SpriteRenderer srBlockGradient11 = this.srBlockGradient;
          Color color21 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color21;
          Color color22 = color21;
          srBlockGradient11.color = color22;
          break;
        case 17:
        case 18:
          SpriteRenderer srBlockGradient12 = this.srBlockGradient;
          Color color23 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color23;
          Color color24 = color23;
          srBlockGradient12.color = color24;
          break;
        case 19:
        case 20:
          SpriteRenderer srBlockGradient13 = this.srBlockGradient;
          Color color25 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color25;
          Color color26 = color25;
          srBlockGradient13.color = color26;
          break;
        case 21:
          SpriteRenderer srBlockGradient14 = this.srBlockGradient;
          Color color27 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color27;
          Color color28 = color27;
          srBlockGradient14.color = color28;
          break;
        case 22:
        case 23:
          SpriteRenderer srBlockGradient15 = this.srBlockGradient;
          Color color29 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color29;
          Color color30 = color29;
          srBlockGradient15.color = color30;
          break;
        case 24:
        case 25:
          SpriteRenderer srBlockGradient16 = this.srBlockGradient;
          Color color31 = new Color(0.0f, 0.0f, 0.0f);
          this.srBlockLeft.color = color31;
          Color color32 = color31;
          srBlockGradient16.color = color32;
          break;
      }
    }
    for (int _nPos = 0; _nPos < 5; ++_nPos)
    {
      this.listMonster[_nPos].SetCharacter(-1, false);
      this.arrActiveSkill[_nPos].SetSkill(_nPos, SkillKey.eNone);
      this.arrActiveSkillLeft[_nPos].SetSkill(_nPos, SkillKey.eNone);
    }
    this.eltAwakenBot.SetSkill(0, SkillKey.eNone);
    this.eltAwakenLeft.SetSkill(0, SkillKey.eNone);
    this.dictSkillFac.Clear();
    for (int index1 = 0; index1 < 5; ++index1)
    {
      SkillKey _eSkill = SkillKey.eNone;
      PlayerMonsterData playerMon = Info.GetPlayerMon(index1);
      if (playerMon != null && (Info.eBattle != BattleType.eTrial || !Info.IsSoloPlay(this.eTrial) || index1 <= 0))
      {
        MonsterData monster = BData.GetMonster((short) playerMon.sID);
        int promoteLevel = Info.GetPromoteLevel((short) playerMon.sID);
        int byBatch = (int) playerMon.byBatch;
        if (index1 == 0)
          this.nMainMon = byBatch;
        this.dictSkillFac.Add(index1, new Dictionary<SkillKey, float[]>());
        foreach (KeyValuePair<SkillKey, ObscuredInt> keyValuePair in playerMon.dictSkill)
          this.dictSkillFac[index1].Add(keyValuePair.Key, new float[3]
          {
            Info.GetSkillFac(index1, keyValuePair.Key),
            Info.GetSkillFac2(index1, keyValuePair.Key),
            0.0f
          });
        if (this.dictSkillFac[index1].ContainsKey(monster.ePromoteSkillMain))
        {
          if (promoteLevel >= 120)
            this.dictSkillFac[index1][monster.ePromoteSkillMain][0] += monster.fPromoteMainFac * 3f;
          else if (promoteLevel >= 20)
            this.dictSkillFac[index1][monster.ePromoteSkillMain][0] += monster.fPromoteMainFac;
          if (promoteLevel >= 160)
            this.dictSkillFac[index1][monster.ePromoteSkillMain][2] += monster.fPromoteMainDmg * 4f;
          else if (promoteLevel >= 60)
            this.dictSkillFac[index1][monster.ePromoteSkillMain][2] += monster.fPromoteMainDmg;
        }
        if (this.dictSkillFac[index1].ContainsKey(monster.ePromoteSkillSub))
        {
          if (promoteLevel >= 140)
            this.dictSkillFac[index1][monster.ePromoteSkillSub][0] += monster.fPromoteSubFac * 3f;
          else if (promoteLevel >= 40)
            this.dictSkillFac[index1][monster.ePromoteSkillSub][0] += monster.fPromoteSubFac;
          if (promoteLevel >= 180)
            this.dictSkillFac[index1][monster.ePromoteSkillSub][2] += monster.fPromoteSubDmg * 4f;
          else if (promoteLevel >= 80)
            this.dictSkillFac[index1][monster.ePromoteSkillSub][2] += monster.fPromoteSubDmg;
        }
        this.listMonster[byBatch].SetCharacter(index1, index1 != 0 || Info.option.bAutoBattle);
        List<SkillKey> skillKeyList = new List<SkillKey>((IEnumerable<SkillKey>) Info.GetPlayerMon(index1).dictSkill.Keys);
        for (int index2 = 0; index2 < skillKeyList.Count; ++index2)
        {
          if (BData.GetSkill(skillKeyList[index2]).eType == SkillType.eActive)
          {
            _eSkill = skillKeyList[index2];
            break;
          }
        }
        if (index1 == 0)
        {
          for (int index2 = 0; index2 < skillKeyList.Count; ++index2)
          {
            if (BData.GetSkill(skillKeyList[index2]).eType == SkillType.eAwaken)
            {
              this.eltAwakenBot.SetSkill(0, skillKeyList[index2]);
              this.eltAwakenLeft.SetSkill(0, skillKeyList[index2]);
              break;
            }
          }
        }
        this.arrActiveSkill[index1].SetSkill(index1, _eSkill);
        this.arrActiveSkillLeft[byBatch].SetSkill(index1, _eSkill);
      }
    }
    this.goBotSkill.SetActive(!Info.option.bLeftSpecial);
    this.goLeftSkill.SetActive(Info.option.bLeftSpecial);
    if (!this.bNoWeapon)
      this.RefreshAmmo();
    if (Info.eBattle == BattleType.eSurvial)
      this.SetAlarm(BData.GetString("UI0061").Replace("[1]", this.nDay.ToString()), BData.GetString("UI0073"), 0.0f, 3f, 1f);
    else if (Info.eBattle == BattleType.eTrial)
      this.SetAlarm(BData.GetString("UI0214") + " " + (Info.GetTrialClear(Info.currentSave.uRebirthID) + 1).ToString() + "F", BData.GetString(BData.GetMutate(BData.GetTrial(Info.GetTrialClear(Info.currentSave.uRebirthID) + 1).eID).strName), 0.0f, 3f, 1f);
    else if (Info.eBattle == BattleType.eEndless)
      this.SetAlarm(BData.GetString("UI0268"), string.Empty, 0.0f, 3f, 1f);
    if (this.bMutate)
      this.SetMutationAlarm(this.strMutation, this.strMutationDesc, 0.0f, 3f, 1f);
    else
      this.cgMutationAlarm.alpha = 0.0f;
    for (int index = 0; index < 5; ++index)
    {
      if (this.listMonster[index].gameObject.activeInHierarchy && Info.GetSkill(this.listMonster[index].nPos, SkillKey.eSoulBomb) > 0)
      {
        this.pSoulMon = this.listMonster[index];
        if (Info.dictBattleItem.ContainsKey(this.listMonster[index].nEquip))
          this.fSoulBombDps = (float) ((double) Info.GetDamage(this.listMonster[index], (Enemy) null, Info.GetBattleItem(this.listMonster[index].nEquip)) * (double) this.GetSkillFac2(this.listMonster[index].nPos, SkillKey.eSoulBomb) * 0.00999999977648258 * (double) Info.GetAccModFac(this.listMonster[index].nPos, ModType.eSoulBombParty) * 0.00999999977648258);
      }
    }
    this.cgWaveAlarm.alpha = 0.0f;
    switch (Info.eBattle)
    {
      case BattleType.eEndless:
        UIMgr.PlayMusic("Battle2");
        break;
      case BattleType.eSurvial:
        if (this.bBossMutate)
        {
          UIMgr.PlayMusic("Battle2");
          break;
        }
        UIMgr.PlayMusic();
        break;
      case BattleType.eTrial:
        UIMgr.PlayMusic("Battle2");
        break;
    }
    PageBattle pageBattle1 = this;
    ObscuredFloat obscuredFloat1 = (ObscuredFloat) ((float) pageBattle1.fDungeonDef * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eFireBase1, 1) * 0.00999999977648258));
    pageBattle1.fDungeonDef = obscuredFloat1;
    PageBattle pageBattle2 = this;
    ObscuredFloat obscuredFloat2 = (ObscuredFloat) ((float) pageBattle2.fDungeonDef * (float) (1.0 - (double) Info.GetResearchFac(ResearchID.eHardened) * 0.00999999977648258));
    pageBattle2.fDungeonDef = obscuredFloat2;
    PageBattle pageBattle3 = this;
    ObscuredFloat obscuredFloat3 = (ObscuredFloat) ((float) pageBattle3.fDungeonDef * (float) (1.0 - (double) Info.GetRebirthFac(RebirthID.eGuardian) * 0.00999999977648258));
    pageBattle3.fDungeonDef = obscuredFloat3;
    PageBattle pageBattle4 = this;
    ObscuredFloat obscuredFloat4 = (ObscuredFloat) ((float) pageBattle4.fDungeonDef * (float) (1.0 - (double) Info.GetRebirthFac(RebirthID.eRebirthDef) * 0.00999999977648258));
    pageBattle4.fDungeonDef = obscuredFloat4;
    for (int nPos = 0; nPos < 5; ++nPos)
    {
      PageBattle pageBattle5 = this;
      ObscuredFloat obscuredFloat5 = (ObscuredFloat) ((float) pageBattle5.fDungeonDef * (float) (1.0 - (double) Info.GetAccModFac(nPos, ModType.eDef) * 0.00999999977648258));
      pageBattle5.fDungeonDef = obscuredFloat5;
    }
    PageBattle pageBattle6 = this;
    ObscuredFloat obscuredFloat6 = (ObscuredFloat) ((float) pageBattle6.fDungeonDef * (float) (1.0 - (double) Info.GetRebirthFac(RebirthID.eDamageReduce) * 0.00999999977648258));
    pageBattle6.fDungeonDef = obscuredFloat6;
    PageBattle pageBattle7 = this;
    ObscuredFloat obscuredFloat7 = (ObscuredFloat) ((float) pageBattle7.fDungeonDef * (float) (1.0 - (double) Info.GetElementalFac(ElementalID.eNatureBase1, 0) * 0.00999999977648258));
    pageBattle7.fDungeonDef = obscuredFloat7;
    PageBattle pageBattle8 = this;
    ObscuredFloat obscuredFloat8 = (ObscuredFloat) ((float) pageBattle8.fDungeonDef / (float) (1.0 + (double) Info.GetRepeatResearch(ResearchID.eUnlimitedShield) * 0.00999999977648258));
    pageBattle8.fDungeonDef = obscuredFloat8;
    this.bCanRevive = (ObscuredBool) ((double) Info.GetElementalFac(ElementalID.eLightProtector, 0) > 0.0);
    if ((double) Info.GetElementalFac(ElementalID.eNatureBigShield, 0) > 0.0)
      this.fBigShieldHP = (ObscuredFloat) ((float) ((double) (float) Info.fDunMaxHP * (double) Info.GetElementalFac(ElementalID.eNatureBigShield, 0) * 0.00999999977648258));
    float num1 = 0.0f;
    for (int index = 0; index < 5; ++index)
    {
      if (this.listMonster[index].isActiveAndEnabled)
        num1 += this.listMonster[index].fCriRate;
    }
    if ((double) num1 > 500.0)
      num1 = 500f;
    PageBattle pageBattle9 = this;
    ObscuredFloat obscuredFloat9 = (ObscuredFloat) ((float) pageBattle9.fDungeonDef * (float) (1.0 - (double) Info.GetElementalFac(ElementalID.eFireCrDef, 0) * 0.00999999977648258 * (double) num1));
    pageBattle9.fDungeonDef = obscuredFloat9;
    Time.timeScale = (float) ((!Info.option.bDoubleSpeed ? 1.0 : 2.0) * (1.0 + (double) Info.GetElementalFac(ElementalID.eFireHaste, 0) * 0.00999999977648258 + (double) Info.GetPartySkillFac(SkillKey.eHaste) * 0.00999999977648258));
    Time.fixedDeltaTime = !Info.option.bOptimize ? 0.02f : 0.033f;
    this.StartCoroutine(this.UpdateWave());
    if ((double) Info.GetElementalFac(ElementalID.eWaterObs1, 0) > 0.0 || (double) Info.GetElementalFac(ElementalID.eWaterObs2, 0) > 0.0)
      this.StartCoroutine(this.StartWaterMoat());
    if ((double) Info.GetElementalFac(ElementalID.eNatureAutoHeal, 0) > 0.0 || (double) Info.GetPartySkillFac(SkillKey.eAutoHeal) > 0.0)
      this.StartCoroutine(this.StartAutoHeal());
    if ((double) Info.GetElementalFac(ElementalID.eNatureObs2, 0) <= 0.0)
      return;
    this.StartCoroutine(this.StartNatureMoat2());
  }

  public float GetSkillFac(int i, SkillKey eKey)
  {
    if (!this.dictSkillFac.ContainsKey(i) || !this.dictSkillFac[i].ContainsKey(eKey))
      return 0.0f;
    return this.dictSkillFac[i][eKey][0];
  }

  public float GetSkillFac2(int i, SkillKey eKey)
  {
    if (!this.dictSkillFac.ContainsKey(i) || !this.dictSkillFac[i].ContainsKey(eKey))
      return 0.0f;
    return this.dictSkillFac[i][eKey][1];
  }

  public float GetSkillFac3(int i, SkillKey eKey)
  {
    if (!this.dictSkillFac.ContainsKey(i) || !this.dictSkillFac[i].ContainsKey(eKey))
      return 0.0f;
    return this.dictSkillFac[i][eKey][2];
  }

  [DebuggerHidden]
  private IEnumerator StartNatureMoat2()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartNatureMoat2\u003Ec__Iterator0() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartAutoHeal()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartAutoHeal\u003Ec__Iterator1() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartWaterMoat()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartWaterMoat\u003Ec__Iterator2() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartCountDown()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartCountDown\u003Ec__Iterator3() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartNumQuiz()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartNumQuiz\u003Ec__Iterator4() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartTFNumQuiz()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartTFNumQuiz\u003Ec__Iterator5() { \u0024this = this };
  }

  public void nChooseAnswer(int nNum)
  {
    if ((bool) this.bBattleOver || !this.emTrialBoss[0].gameObject.activeInHierarchy)
    {
      this.goNumQuiz.SetActive(false);
    }
    else
    {
      if (nNum == this.nAnswer)
      {
        this.emTrialBoss[0].SetInvincible(-100f);
        this.SetAlarm(BData.GetString("UI0225"), string.Empty, 0.0f, 2f, 1f);
        UIMgr.PlaySound("Hire", false);
      }
      else
      {
        this.DungeonDamage(Info.GetMonDmg((int) this.nDay) * 5f);
        this.SetAlarm(BData.GetString("UI0226"), string.Empty, 0.0f, 2f, 1f);
        UIMgr.PlaySound("CharSel", false);
      }
      this.goNumQuiz.SetActive(false);
    }
  }

  protected override void Update()
  {
    base.Update();
    if ((double) this.imgScreenFX.color.a != 0.0)
    {
      this.clScreen = this.imgScreenFX.color;
      this.clScreen.a = Mathf.Clamp(this.clScreen.a - Time.deltaTime * this.fScreenSpd, 0.0f, 1f);
      this.imgScreenFX.color = this.clScreen;
    }
    this.matLaser.mainTextureOffset -= new Vector2(Time.deltaTime * 6f, 0.0f);
    if ((double) this.fShowGold != (double) this.fTargetGold)
    {
      this.fShowGold = Mathf.Min((float) ((double) this.fShowGold + 1.0 + ((double) this.fTargetGold - (double) this.fShowGold) * 5.0 * (double) Time.deltaTime), this.fTargetGold);
      this.textGold.text = this.fShowGold.ToString("N0");
    }
    if (this.textGold.rectTransform.localScale != Vector3.one)
    {
      RectTransform rectTransform = this.textGold.rectTransform;
      Vector3 vector3 = rectTransform.localScale - Vector3.one * Time.deltaTime;
      rectTransform.localScale = vector3;
      if ((double) this.textGold.rectTransform.localScale.x < 1.0)
        this.textGold.rectTransform.localScale = Vector3.one;
    }
    if (this.textItem.rectTransform.localScale != Vector3.one)
    {
      RectTransform rectTransform = this.textItem.rectTransform;
      Vector3 vector3 = rectTransform.localScale - Vector3.one * Time.deltaTime;
      rectTransform.localScale = vector3;
      if ((double) this.textItem.rectTransform.localScale.x < 1.0)
        this.textItem.rectTransform.localScale = Vector3.one;
    }
    if (this.textHP.rectTransform.parent.localScale != Vector3.one)
    {
      this.textHP.rectTransform.parent.localScale -= Vector3.one * Time.deltaTime;
      if ((double) this.textHP.rectTransform.parent.localScale.x < 1.0)
        this.textHP.rectTransform.parent.localScale = Vector3.one;
    }
    if ((double) this.fSuperLaserTime > 0.0)
      this.fSuperLaserTime = Mathf.Max(this.fSuperLaserTime - Time.deltaTime, 0.0f);
    if ((double) this.fSuperBladeTime > 0.0)
      this.fSuperBladeTime = Mathf.Max(this.fSuperBladeTime - Time.deltaTime, 0.0f);
    if ((double) this.fSuperLightningTime > 0.0)
    {
      this.fSuperLightningTime = Mathf.Max(this.fSuperLightningTime - Time.deltaTime, 0.0f);
      if ((double) this.fSuperLightningTime == 0.0)
      {
        this.pLightning.GlowTintColor = Color.yellow;
        this.pLightning.TrunkWidthRange.Maximum = this.pLightning.TrunkWidthRange.Minimum = 5f;
      }
    }
    if ((double) (float) this.fInvincibleDur > 0.0)
    {
      PageBattle pageBattle = this;
      ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) pageBattle.fInvincibleDur - Time.deltaTime);
      pageBattle.fInvincibleDur = obscuredFloat;
      if ((double) (float) this.fInvincibleDur <= 0.0)
        this.psDivine.Stop();
    }
    if (Input.GetKeyDown(KeyCode.Escape) && (Object) UIMgr.focused == (Object) this)
    {
      this.OnPause();
    }
    else
    {
      if ((bool) this.bBattleOver || (Object) UIMgr.focused != (Object) this)
        return;
      for (int index = 0; index < this.arrActiveSkill.Length; ++index)
      {
        if (this.goLeftSkill.activeInHierarchy)
          this.arrActiveSkillLeft[index].UpdateGuage(Time.deltaTime, true, true);
        else
          this.arrActiveSkill[index].UpdateGuage(Time.deltaTime, true, true);
      }
      if (this.goLeftSkill.activeInHierarchy)
        this.eltAwakenLeft.UpdateGuage(Time.deltaTime);
      else
        this.eltAwakenBot.UpdateGuage(Time.deltaTime);
      if ((double) Info.GetElementalFac(ElementalID.eLightShield, 0) > 0.0 && !(bool) this.bLightShield)
      {
        PageBattle pageBattle = this;
        ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) pageBattle.fLightShield + Time.deltaTime);
        pageBattle.fLightShield = obscuredFloat;
        if ((double) (float) this.fLightShield >= (double) Info.GetElementalFac(ElementalID.eLightShield, 0))
        {
          this.bLightShield = (ObscuredBool) true;
          this.fLightShield = (ObscuredFloat) 0.0f;
        }
      }
      if ((double) Info.GetElementalFac(ElementalID.eLightPainkiller, 0) > 0.0)
      {
        if ((double) (float) this.fPainKillerDur > 0.0)
        {
          PageBattle pageBattle = this;
          ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) pageBattle.fPainKillerDur - Time.deltaTime);
          pageBattle.fPainKillerDur = obscuredFloat;
        }
        else if ((double) (float) this.fPainKillerCool > 0.0)
        {
          PageBattle pageBattle = this;
          ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) pageBattle.fPainKillerCool - Time.deltaTime);
          pageBattle.fPainKillerCool = obscuredFloat;
        }
      }
      if (!Input.GetMouseButton(0) || (Object) UIMgr.focused != (Object) this || Info.option.bLeftSpecial && (double) Input.mousePosition.x < 60.0 || ((double) Input.mousePosition.y < (double) Screen.height * 0.100000001490116 || ((double) Input.mousePosition.y > (double) Screen.height * 0.899999976158142 || this.mainMonster.nEquip == -1L || (this.mainMonster.isReloading || this.mainMonster.isStun) || !this.mainMonster.canShoot && !this.mainMonster.isLaser)))
        return;
      this.vTargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      this.vTargetPos.z = 0.0f;
      this.OnShooting(this.mainMonster, this.vTargetPos, this.mainMonster.nEquip, false, this.mainMonster.nAtkTime);
      this.mainMonster.Animate("TriggerAttack");
    }
  }

  [DebuggerHidden]
  private IEnumerator UpdateTarget()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CUpdateTarget\u003Ec__Iterator6() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator UpdateWave()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CUpdateWave\u003Ec__Iterator7() { \u0024this = this };
  }

  public void MoveToDropItem()
  {
    Info.CalcLevelUp();
    if (Info.listDropItem.Count > 0)
    {
      int num = 0;
      if ((double) Info.GetPartySkillFac(SkillKey.eScavenger) > 0.0)
        num = Mathf.Max(1, Mathf.RoundToInt((float) ((double) Info.listDropItem.Count * (double) Info.GetPartySkillFac(SkillKey.eScavenger) * 0.00999999977648258)));
      for (int index = 0; index < num; ++index)
        Info.AddRandomDropWeapon();
      for (int index = 0; index < Info.listDropItem.Count; ++index)
        Info.RefreshBattleItemData(Info.listDropItem[index]);
      for (int index = 0; index < Info.listDropItem.Count; ++index)
        Info.AddWeaponToInventory(Info.listDropItem[index]);
      UIMgr.AddPage("PopupWeaponSelect");
      PopupWeaponSelect.obj.LootItemMode(true);
    }
    else
      this.MoveToNextDay();
  }

  private void ClearMutation()
  {
    PageBattle.listMutation.Clear();
    PageBattle.dictMutation1.Clear();
    PageBattle.dictMutation2.Clear();
  }

  private void AddMutation(MutateType eID, float fFac1, float fFac2)
  {
    PageBattle.listMutation.Add(eID);
    PageBattle.dictMutation1.Add(eID, (ObscuredFloat) fFac1);
    PageBattle.dictMutation2.Add(eID, (ObscuredFloat) fFac2);
  }

  public void MoveToNextDay()
  {
    if (Info.eBattle == BattleType.eSurvial)
      Info.NextDay();
    UIMgr.LoadLevel("Lobby", 0.75f, 0.75f, Color.black);
  }

  private void SpawnEnemyWave(short sID, int nDiff, int nDay)
  {
    this.SpawnEnemy(sID, PageBattle.fSpawnX, (float) Random.Range(-160, 130), nDiff, nDay, false);
  }

  private Enemy SpawnEnemy(short sID, float fX, float fY, int nDiff, int nDay, bool bBoss)
  {
    Enemy enemy = this.GetEnemy();
    Vector3 zero = Vector3.zero;
    zero.y = fY;
    zero.x = fX;
    enemy.transform.localPosition = zero;
    enemy.gameObject.SetActive(true);
    enemy.SetEnemy(sID, nDiff, nDay, bBoss);
    return enemy;
  }

  private DmgText GetDmgText()
  {
    if (this.nDmgText >= this.listDmgText.Count)
      this.nDmgText = 0;
    return this.listDmgText[this.nDmgText++];
  }

  private Enemy GetEnemy()
  {
    for (int index = 0; index < this.listEnemy.Count; ++index)
    {
      if (!this.listEnemy[index].gameObject.activeInHierarchy)
        return this.listEnemy[index];
    }
    return this.CreateEnemy();
  }

  private void MakeCoin(BattleCoinElt.Type eType, float fGold, Vector3 vOri, float fSize)
  {
    BattleCoinElt battleCoinElt = this.listCoinDead.Count != 0 ? this.listCoinDead[0] : this.CreateCoin();
    battleCoinElt.gameObject.SetActive(true);
    battleCoinElt.transform.localScale = Vector3.one * fSize;
    battleCoinElt.SetGold(eType, fGold, vOri, (float) Random.Range(-90, 90), (float) Random.Range(64, 128));
    if (!this.listCoinAlive.Contains(battleCoinElt))
      this.listCoinAlive.Add(battleCoinElt);
    this.listCoinDead.Remove(battleCoinElt);
  }

  private void ClearAllEnemy()
  {
    for (int index = 0; index < this.listEnemy.Count; ++index)
      this.listEnemy[index].gameObject.SetActive(false);
  }

  private void ClearAllEnemyByDamage()
  {
    for (int index = 0; index < this.listEnemy.Count; ++index)
    {
      if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
      {
        this.listEnemy[index].SetInvincible(-200f);
        this.MonsterDamage(this.listEnemy[index], (float) this.listEnemy[index].maxhp * 2f, true, (Monster) null, true, true);
      }
    }
  }

  private void NextWave()
  {
    ++this.nWave;
    ++Info.wave.nCurrentWave;
  }

  public void OnCollisionBullet(Bullet bul, Enemy em)
  {
    if (em.isHide && (double) Random.Range(0.0f, 100f) < (double) PageBattle.GetMutation1(MutateType.eStealth) - (double) Info.GetPartySkillFac(SkillKey.eEnemyEvadeParty))
      return;
    bul.OnImpact(em);
    int num = 0;
    int nNum = 1;
    switch (bul.eType)
    {
      case BulletType.eNormal:
        if (!Info.option.bOptimize)
        {
          switch (bul.eTrail)
          {
            case TrailType.eFire:
              ParticleMgr.Play("HitFire", bul.transform);
              break;
            case TrailType.eIce:
              ParticleMgr.Play("HitIce", bul.transform);
              em.SetSlow(50f);
              break;
            case TrailType.eWind:
            case TrailType.eEnergy:
              ParticleMgr.Play("HitWind", bul.transform);
              break;
            case TrailType.eWater:
              ParticleMgr.Play("HitWater", bul.transform);
              break;
            case TrailType.eEarth:
              ParticleMgr.Play("HitEarth", bul.transform);
              break;
            case TrailType.eElectric:
              ParticleMgr.Play("HitElectric", bul.transform);
              break;
            case TrailType.eWeapon:
              ParticleMgr.Play("Slash", bul.transform);
              break;
          }
        }
        bool flag = this.MonsterDamage(em, bul, 1f);
        if (flag || (double) Time.timeScale == 1.0)
        {
          UIMgr.PlaySound(!flag ? "Hit" + (object) Random.Range(0, 5) : "Critical", false);
          break;
        }
        break;
      case BulletType.eExplosionCir:
        float fAddSize1 = (float) (1.0 + (!((Object) bul.pMon != (Object) null) ? 0.0 : (double) Info.GetAccModFac(bul.pMon.nPos, ModType.eFireBallRange) * 0.00999999977648258 + (double) this.GetSkillFac2(bul.pMon.nPos, SkillKey.eBigFireBall) * 0.00999999977648258));
        UIMgr.PlaySound("Explosion" + (object) Random.Range(0, 2), false);
        CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 2, PageBattle.vShakePos, Vector3.zero, 1f, 90f, 0.9f, 0.0f, true);
        if ((Object) bul.pMon != (Object) null)
          nNum = (double) this.GetSkillFac(bul.pMon.nPos, SkillKey.eChainFireBall) <= (double) Random.Range(0.0f, 100f) ? 1 : 5;
        this.StartCoroutine(this.CheckFireBall(nNum, (Vector2) bul.transform.localPosition, fAddSize1, em, bul));
        break;
      case BulletType.eExplosionDir:
        UIMgr.PlaySound("Explosion" + (object) Random.Range(0, 2), false);
        float fAddSize2 = (float) (1.0 + (!((Object) bul.pMon != (Object) null) ? 0.0 : (double) Info.GetAccModFac(bul.pMon.nPos, ModType.eFireLanceRange) * 0.00999999977648258 + (double) this.GetSkillFac2(bul.pMon.nPos, SkillKey.eBigFireLance) * 0.00999999977648258));
        CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 2, PageBattle.vShakePos, Vector3.zero, 1f, 90f, 0.9f, 0.0f, true);
        if ((Object) bul.pMon != (Object) null)
          nNum = (double) this.GetSkillFac(bul.pMon.nPos, SkillKey.eCornFireLance) <= (double) Random.Range(0.0f, 100f) ? 1 : 5;
        this.StartCoroutine(this.CheckFireLance(nNum, (Vector2) bul.transform.localPosition, fAddSize2, em, bul));
        break;
      case BulletType.eFrostExplosionCir:
        float fAddSize3 = (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eFrostBall) * 0.00999999977648258 + (!((Object) bul.pMon != (Object) null) ? 0.0 : (double) Info.GetAccModFac(bul.pMon.nPos, ModType.eBigSnowBall) * 0.00999999977648258));
        UIMgr.PlaySound("Explosion" + (object) Random.Range(0, 2), false);
        this.StartCoroutine(this.CheckSnowBall(nNum, (Vector2) bul.transform.localPosition, fAddSize3, em, bul));
        break;
      case BulletType.eSoulBomb:
        this.OnSoulExplosion(bul.fPow, bul.transform.position);
        break;
    }
    if (num == 0)
      return;
    for (int index = 0; index < num; ++index)
    {
      if (!(this.hits[index].transform.tag != "Enemy"))
      {
        Enemy component = this.hits[index].transform.GetComponent<Enemy>();
        if (!((Object) component == (Object) null))
          this.MonsterDamage(component, bul, 1f);
      }
    }
  }

  [DebuggerHidden]
  private IEnumerator CheckFireBall(int nNum, Vector2 vPos, float fAddSize, Enemy em, Bullet bul)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CCheckFireBall\u003Ec__Iterator8() { vPos = vPos, nNum = nNum, fAddSize = fAddSize, bul = bul, \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator CheckSnowBall(int nNum, Vector2 vPos, float fAddSize, Enemy em, Bullet bul)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CCheckSnowBall\u003Ec__Iterator9() { vPos = vPos, nNum = nNum, fAddSize = fAddSize, bul = bul, \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator CheckFireLance(int nNum, Vector2 vPos, float fAddSize, Enemy em, Bullet bul)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CCheckFireLance\u003Ec__IteratorA() { bul = bul, nNum = nNum, fAddSize = fAddSize, vPos = vPos, em = em, \u0024this = this };
  }

  public void OnShooting(Monster mon, Vector3 targetPos, long nEquip, bool bAuto, int nAtkTime)
  {
    if (!Info.CheckBattleItem(mon.nEquip))
      return;
    bool flag1 = false;
    BattleItemData battleItem = Info.GetBattleItem(nEquip);
    ItemData weapon = BData.GetWeapon((short) battleItem.sID);
    TrailType _eTrail = weapon.eTrail;
    BulletType _eType = BulletType.eNormal;
    float num1 = 1f;
    int nShot = battleItem.nSpread;
    bool flag2 = false;
    bool bDmg = nAtkTime > 0;
    if (bDmg)
    {
      float num2 = num1 * (float) nAtkTime;
      if (weapon.eWeapon == WeaponType.eShriken)
        nShot += (int) this.GetSkillFac(mon.nPos, SkillKey.eShriken);
      else if (weapon.eWeapon == WeaponType.eSpear)
        num2 *= (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eSpearMaster) * 0.00999999977648258);
      if (bAuto)
      {
        if (mon.nPos == 0)
          num2 *= (float) (0.5 + 0.5 * ((double) Info.GetRebirthFac(RebirthID.eManager) * 0.00999999977648258));
        else
          num2 *= 0.6f;
      }
      if ((int) mon.nAmmo == 1)
        num2 *= (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eLastShot) * 0.00999999977648258);
      if ((int) mon.nAmmo == (int) mon.nMaxAmmo)
        num2 *= (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eFirstShot) * 0.00999999977648258);
      if (Info.GetSkill(mon.nPos, SkillKey.eKillPower) > 0)
        num2 *= 1f + mon.fAssinatePower;
      if (Info.GetSkill(mon.nPos, SkillKey.eRicochetPower) > 0)
        num2 *= 1f + mon.fRicochetPower;
      if (Info.GetSkill(mon.nPos, SkillKey.eCriPower) > 0)
        num2 *= 1f + mon.fCriPower;
      if (Info.GetSkill(mon.nPos, SkillKey.eHarvestPower) > 0)
        num2 *= 1f + Mathf.Min(this.GetSkillFac2(mon.nPos, SkillKey.eHarvestPower) * 0.01f, this.GetSkillFac(mon.nPos, SkillKey.eHarvestPower) * 0.01f * (float) (int) this.nHarvestNum);
      if (Info.GetSkill(mon.nPos, SkillKey.eRevenge) > 0)
        num2 *= 1f + Mathf.Min(this.GetSkillFac2(mon.nPos, SkillKey.eRevenge) * 0.01f, this.GetSkillFac(mon.nPos, SkillKey.eRevenge) * 0.01f * (float) (int) this.nDamagedNum);
      if (Info.GetSkill(mon.nPos, SkillKey.eLowPower) > 0)
        num2 *= (float) (1.0 + (1.0 - (double) Mathf.Clamp((float) (int) mon.nAmmo / (float) (int) mon.nMaxAmmo, 0.0f, 1f)) * (double) this.GetSkillFac(mon.nPos, SkillKey.eLowPower) * 0.00999999977648258);
      float num3 = num2 * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eNatureAtkHP, 0) * 0.00999999977648258 * (double) (float) this.fHPRate);
      if ((double) Random.Range(0.0f, 100f) < (double) this.GetSkillFac(mon.nPos, SkillKey.eDoubleAttack))
        num3 *= 2f;
      if (mon.isRandomDmg)
        num3 += Random.Range(0.0f, 10f);
      num1 = num3 + Random.Range(0.0f, this.GetSkillFac(mon.nPos, SkillKey.eLuckShot) * 0.01f);
      flag2 = (double) Random.Range(0.0f, 100f) < (double) mon.fCriRate;
      if (flag2)
      {
        num1 *= mon.fFixCriDmg;
        if (!Info.currentSave.bNamelessCriFix && (int) mon.sID <= 10)
          num1 *= mon.fFixCriDmg;
      }
    }
    float max1 = (float) ((double) (float) mon.fRecoil * (3.0 / 500.0) * (12.0 + (double) nShot * 0.5));
    bool _bHuge = false;
    float fPlus;
    if (Info.GetSkill(mon.nPos, SkillKey.eBasicLaser) > 0)
    {
      if (Info.option.bOptimize && !bDmg)
        return;
      float num2 = 24f;
      fPlus = num1 * (this.GetSkillFac(mon.nPos, SkillKey.eBasicLaser) * 0.01f) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eBasicLaser) * 0.00999999977648258) * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eLaserTraining) * 0.00999999977648258);
      float fSize1 = num2 * (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eLaserTraining) * 0.00999999977648258);
      if ((double) this.fSuperLaserTime > 0.0)
      {
        fSize1 *= (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eSuperLaser) * 0.00999999977648258);
        fPlus *= (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eSuperLaser) * 0.00999999977648258);
      }
      this.OnShootLaser(mon, mon.transform.position + this.vLaserPos, targetPos, fSize1, fPlus, 0, bDmg, flag2);
      if (bDmg)
      {
        float fSize2 = (float) ((double) fSize1 * 0.600000023841858 * (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eSubLaserEmpower) * 0.00999999977648258));
        fPlus = fPlus * (this.GetSkillFac2(mon.nPos, SkillKey.eSubLaser) * 0.01f) * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eSubLaserEmpower) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eSubLaser) * 0.00999999977648258);
        int num3 = 0;
        if (mon.isSubLaser)
        {
          num3 += 1 + Info.GetAccModFacToInt(mon.nPos, ModType.eAddSubLaser);
          fPlus *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eSubLaser);
        }
        if ((double) Random.Range(0.0f, 100f) < (double) this.GetSkillFac(mon.nPos, SkillKey.eAnotherLaser))
        {
          ++num3;
          fPlus *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eAnotherLaser);
        }
        List<Enemy> listAlready = new List<Enemy>();
        for (int index = 0; index < num3; ++index)
        {
          Enemy randomEnemy = this.GetRandomEnemy(listAlready);
          if ((Object) randomEnemy != (Object) null)
          {
            listAlready.Add(randomEnemy);
            this.OnShootLaser(mon, mon.transform.position + this.vLaserPos, randomEnemy.vPos, fSize2, fPlus, this.nLaserOrder, true, flag2);
            ++this.nLaserOrder;
            if (this.nLaserOrder >= this.arrLaser.Length)
              this.nLaserOrder = 1;
          }
        }
      }
    }
    else if (Info.GetSkill(mon.nPos, SkillKey.eLightning) > 0)
    {
      if (Info.option.bOptimize && !bDmg)
        return;
      fPlus = num1 * (this.GetSkillFac(mon.nPos, SkillKey.eLightning) * 0.01f);
      Vector2 vLastPos = (Vector2) targetPos;
      Vector2 origin = (Vector2) (mon.transform.position + this.vLightningPos);
      Vector2 normalized = (vLastPos - origin).normalized;
      if ((double) this.fSuperLightningTime > 0.0)
      {
        fPlus *= (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eBlueLightning) * 0.00999999977648258);
        this.pLightning.GlowTintColor = Color.blue;
        this.pLightning.TrunkWidthRange.Maximum = this.pLightning.TrunkWidthRange.Minimum = 9f;
      }
      bool bThunder = (double) Random.Range(0.0f, 100f) < (double) this.GetSkillFac(mon.nPos, SkillKey.eThunder);
      bool flag3 = mon.isChainLightning;
      if (flag3)
        fPlus = fPlus * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eChainLightning) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eChainLightning));
      this.arrRayHits = Physics2D.RaycastAll(origin, normalized, 900f, 256);
      bool flag4 = false;
      Enemy em = (Enemy) null;
      for (int index = 0; index < this.arrRayHits.Length; ++index)
      {
        if (!(this.arrRayHits[index].transform.tag != "Enemy"))
        {
          em = this.arrRayHits[index].transform.GetComponent<Enemy>();
          if (!((Object) em == (Object) null) && !em.isDead)
          {
            if (bDmg)
            {
              if (flag3 && (Object) this.GetRandomEnemy(em) == (Object) null)
              {
                flag3 = false;
                fPlus *= (float) (1.0 + (double) Mathf.FloorToInt(this.GetSkillFac2(mon.nPos, SkillKey.eChainLightning)) * (double) this.GetSkillFac(mon.nPos, SkillKey.eAmplify) * 0.00999999977648258);
              }
              if (bThunder || (double) Info.GetAccModFac(ModType.eFirstThunder) > 0.0)
              {
                this.HitThunder((Vector2) em.vPos, mon, battleItem, fPlus, flag2);
              }
              else
              {
                flag4 = em.isDead;
                this.MonsterDamage(em, Info.GetDamage(mon, em, battleItem) * fPlus, flag2, mon, false, true);
                if (!Info.option.bOptimize)
                  ParticleMgr.Play("HitLightning", em.vPos);
              }
            }
            vLastPos = (Vector2) em.vPos;
            break;
          }
        }
      }
      if (!Info.option.bAllFXOff)
        this.pLightning.Trigger(new Vector3?((Vector3) origin), new Vector3?((Vector3) vLastPos));
      if (bDmg && flag3)
        this.StartCoroutine(this.StartChainLightning(mon, em, battleItem, vLastPos, fPlus, bThunder, flag2, Mathf.FloorToInt(this.GetSkillFac2(mon.nPos, SkillKey.eChainLightning))));
    }
    else if (Info.GetSkill(mon.nPos, SkillKey.eDimensionKick) > 0)
    {
      float num2 = num1 * (this.GetSkillFac(mon.nPos, SkillKey.eDimensionKick) * 0.01f);
      string strFX = "HitPink";
      bool bBig = false;
      float fHitSize = 20f;
      float fAddSize = (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eKickArea) * 0.00999999977648258);
      if (mon.isStrongKick)
      {
        bBig = true;
        strFX = "ExplosionLight";
        num2 = num2 * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eHighKick) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eStrongKick) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eHighKick));
        fHitSize = 80f;
        fAddSize = 1f;
      }
      if ((double) this.GetSkillFac(mon.nPos, SkillKey.eTripleKick) > (double) Random.Range(0.0f, 100f))
      {
        nShot += 2;
        num2 *= this.GetSkillFac2(mon.nPos, SkillKey.eTripleKick) * 0.01f;
      }
      if ((double) Info.GetResearchFac(ResearchID.eMoreKick) > 0.0)
        ++nShot;
      if ((double) this.GetSkillFac(mon.nPos, SkillKey.eDoubleKick) > (double) Random.Range(0.0f, 100f))
      {
        nShot *= 2;
        num2 *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eDoubleKick);
      }
      if (this.eTrial == MutateType.eJustOne)
        nShot = 1;
      fPlus = num2 * (float) (1.0 + (double) nShot * (double) this.GetSkillFac(mon.nPos, SkillKey.eManyWeapon) * 0.00999999977648258);
      float max2 = (float) ((double) (float) mon.fRecoil * (3.0 / 500.0) * 100.0);
      float num3 = Info.GetBattleItem(nEquip).fRate * 0.3334f;
      for (int index = 0; index < nShot; ++index)
      {
        Vector2 v2Pos = (Vector2) targetPos;
        v2Pos.x += Random.Range(-max2, max2);
        v2Pos.y += Random.Range(-max2, max2);
        if (index == nShot - 1)
        {
          fPlus *= (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eLastKick) * 0.00999999977648258);
          if (Info.GetSkill(mon.nPos, SkillKey.eHighKick) > 0 && (double) Info.GetAccModFac(mon.nPos, ModType.eLastStrongKick) > 0.0)
          {
            if (bBig)
            {
              fPlus *= (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eLastStrongKick) * 0.00999999977648258);
            }
            else
            {
              bBig = true;
              strFX = "ExplosionLight";
              fPlus = fPlus * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eHighKick) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eLastStrongKick) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eStrongKick) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eHighKick));
              fHitSize = 80f;
              fAddSize = 1f;
            }
          }
        }
        this.StartCoroutine(this.HitArea(v2Pos, mon, nEquip, fPlus, flag2, strFX, fHitSize, fAddSize, num3 * (float) index, bBig, false));
      }
    }
    else if (Info.GetSkill(mon.nPos, SkillKey.eDimensionSlash) > 0)
    {
      float num2 = num1 * (this.GetSkillFac(mon.nPos, SkillKey.eDimensionSlash) * 0.01f);
      bool bBig = false;
      string strFX = "DimSlashBlue";
      float fHitSize = 28f;
      if (mon.isBigSlash)
      {
        strFX = "BigSlashBlue";
        num2 = num2 * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eBigSlash) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eBigSlash)) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eMoonSlash) * 0.00999999977648258);
        fHitSize = 100f;
        bBig = true;
      }
      if ((double) this.fSuperBladeTime > 0.0)
      {
        strFX = strFX.Replace("Blue", "Red");
        num2 *= (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eBladeStorm) * 0.00999999977648258);
      }
      if (Info.GetSkill(mon.nPos, SkillKey.eHexaSlash) > 0)
      {
        nShot += 5 + Info.GetResearchFacInt(ResearchID.eHexaSlash);
        num2 *= this.GetSkillFac(mon.nPos, SkillKey.eHexaSlash) * 0.01f;
      }
      if (this.eTrial == MutateType.eJustOne)
        nShot = 1;
      fPlus = num2 * (float) (1.0 + (double) nShot * (double) this.GetSkillFac(mon.nPos, SkillKey.eManyWeapon) * 0.00999999977648258);
      float max2 = (float) ((double) (float) mon.fRecoil * (3.0 / 500.0) * 100.0);
      float num3 = Info.GetBattleItem(nEquip).fRate * 0.16667f;
      Vector2 zero = Vector2.zero;
      for (int index = 0; index < nShot; ++index)
      {
        Vector2 v2Pos = (Vector2) targetPos;
        v2Pos.x += Random.Range(-max2, max2);
        v2Pos.y += Random.Range(-max2, max2);
        float fAddSize = (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eStrongerSlash) * 0.00999999977648258 * (double) index);
        if (index == nShot - 1 && (double) Info.GetAccModFac(mon.nPos, ModType.eLastBigSlash) > 0.0)
        {
          if (!bBig)
          {
            strFX = "BigSlash" + ((double) this.fSuperBladeTime <= 0.0 ? "Blue" : "Red");
            fPlus = fPlus * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eBigSlash) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eBigSlash));
            fHitSize = 100f;
          }
          fPlus *= (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eLastBigSlash) * 0.00999999977648258);
        }
        this.StartCoroutine(this.HitArea(v2Pos, mon, nEquip, fPlus * (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eStrongerSlash) * 0.00999999977648258 * (double) index), flag2, strFX, fHitSize, fAddSize, num3 * (float) index, bBig, true));
      }
    }
    else if (Info.GetSkill(mon.nPos, SkillKey.eElementalShot) > 0)
    {
      float max2 = (float) ((double) (float) mon.fRecoil * (3.0 / 500.0) * 100.0);
      Vector2 zero = Vector2.zero;
      string strFX = "DimSlashBlue";
      bool isExplosion = mon.isExplosion;
      float fHitSize = !isExplosion ? 36f : 100f;
      float fAddSize = (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eElementalShot) * 0.00999999977648258);
      fPlus = num1 * (this.GetSkillFac(mon.nPos, SkillKey.eElementalShot) * 0.01f);
      if (isExplosion)
      {
        fPlus = fPlus * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eElementalBomb) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eElementalBomb) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eElementalBomb));
        if ((double) Info.GetAccModFac(mon.nPos, ModType.eElementalBombDmg) > 0.0)
          fPlus *= (float) (1.0 + (double) Random.Range(0.0f, Info.GetAccModFac(mon.nPos, ModType.eElementalBombDmg)) * 0.00999999977648258);
      }
      switch (mon.sID)
      {
        case 15:
          strFX = !isExplosion ? "FireShot" : "FireBomb";
          break;
        case 16:
          strFX = !isExplosion ? "WaterShot" : "WaterBomb";
          break;
        case 17:
          strFX = !isExplosion ? "NatureShot" : "NatureBomb";
          break;
        case 18:
          strFX = !isExplosion ? "LightShot" : "LightBomb";
          break;
        case 19:
          strFX = !isExplosion ? "DarkShot" : "DarkBomb";
          break;
      }
      if ((double) Random.Range(0.0f, 100f) < (double) this.GetSkillFac(mon.nPos, SkillKey.eChainBomb))
      {
        nShot += (int) this.GetSkillFac2(mon.nPos, SkillKey.eChainBomb);
        fPlus *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eChainBomb);
      }
      for (int index = 0; index < nShot; ++index)
      {
        Vector2 v2Pos = (Vector2) targetPos;
        if (index == 0)
        {
          v2Pos.x += Random.Range(-max2, max2);
          v2Pos.y += Random.Range(-max2, max2);
        }
        else
        {
          v2Pos.x += Random.Range((float) (-(double) fHitSize * 0.600000023841858), fHitSize * 0.6f);
          v2Pos.y += Random.Range((float) (-(double) fHitSize * 0.600000023841858), fHitSize * 0.6f);
        }
        this.StartCoroutine(this.HitArea(v2Pos, mon, nEquip, fPlus, flag2, strFX, fHitSize, fAddSize, (float) index * 0.1f, isExplosion, false));
        fPlus *= (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eChainBombDmg) * 0.00999999977648258);
      }
    }
    else if (Info.GetSkill(mon.nPos, SkillKey.eSwordWill) > 0)
    {
      bool bThree = false;
      float num2 = num1 * (this.GetSkillFac(mon.nPos, SkillKey.eSwordWill) * 0.01f);
      if ((double) this.GetSkillFac(mon.nPos, SkillKey.eSevenSword) > (double) Random.Range(0.0f, 100f))
      {
        nShot += 6;
        flag1 = true;
        num2 *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eSevenSword);
      }
      if (mon.isTripleSword)
      {
        bThree = true;
        nShot += 2;
        if ((double) Info.GetAccModFac(mon.nPos, ModType.eTripleSwordPlus) > 0.0)
          nShot += Info.GetAccModFacToInt(mon.nPos, ModType.eTripleSwordPlus);
        num2 *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eTripleSword);
      }
      if ((double) Random.Range(0.0f, 100f) < (double) Info.GetResearchFac(ResearchID.eMoreSword))
        ++nShot;
      if (this.eTrial == MutateType.eJustOne)
        nShot = 1;
      fPlus = num2 * (float) (1.0 + (double) nShot * (double) this.GetSkillFac(mon.nPos, SkillKey.eManyWeapon) * 0.00999999977648258);
      this.StartCoroutine(this.StartSummonSword(mon, targetPos, battleItem, Info.GetBattleItem(nEquip).fDmg * fPlus, nShot, flag2, bThree, flag1, flag1));
    }
    else
    {
      if (weapon.eWeapon == WeaponType.eBow)
        nShot += Info.GetAccModFacToInt(mon.nPos, ModType.eAddArrow);
      if (weapon.eWeapon == WeaponType.eSpear)
        nShot += Info.GetAccModFacToInt(mon.nPos, ModType.eJavelinAddShot);
      if (mon.isMultiShot)
      {
        nShot += 4 + Info.GetResearchFacInt(ResearchID.eMultiShot);
        num1 *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eMultiShot);
      }
      if ((double) this.GetSkillFac(mon.nPos, SkillKey.eAddShot) > (double) Random.Range(0.0f, 100f))
      {
        nShot += 2;
        num1 = num1 * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eAddShot) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eAddShot));
      }
      if (mon.isHugeWeapon)
      {
        _bHuge = true;
        num1 = num1 * (this.GetSkillFac2(mon.nPos, SkillKey.eBigShot) * 0.01f) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eBigShot)) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eBigShot) * 0.00999999977648258) * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eMarchWeapon) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eHugeWeapon) * 0.00999999977648258);
      }
      if (mon.isFireBall)
      {
        _eTrail = TrailType.eFireBall;
        _eType = BulletType.eExplosionCir;
        num1 = num1 * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eFireBall) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eFireBall)) * (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eFireBallDmg) * 0.00999999977648258) * (float) (1.0 + (double) this.GetSkillFac(mon.nPos, SkillKey.eBigFireBall) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eFireBall) * 0.00999999977648258);
      }
      else if (mon.isFireLance)
      {
        _eTrail = TrailType.eFireLance;
        _eType = BulletType.eExplosionDir;
        num1 = num1 * (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eFireLance) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eFireLance)) * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eFireLance) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eFireLanceDmg) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eFireLance) * 0.00999999977648258);
      }
      else if (mon.isSoulBomb)
      {
        _eTrail = TrailType.eSoulBomb;
        _eType = BulletType.eSoulBomb;
        num1 = num1 * (this.GetSkillFac2(mon.nPos, SkillKey.eSoulBomb) * 0.01f) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eSoulBall)) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eSoulBomb) * 0.00999999977648258);
      }
      if ((double) this.GetSkillFac(mon.nPos, SkillKey.eIceBolt) > (double) Random.Range(0.0f, 100f) || (double) Info.GetAccModFac(mon.nPos, ModType.eAlwaysIce) > 0.0)
      {
        _eTrail = TrailType.eIce;
        num1 = num1 * (this.GetSkillFac2(mon.nPos, SkillKey.eIceBolt) * 0.01f) * (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eAlwaysIce) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eIceBolt));
      }
      if (mon.isFrost)
      {
        _eTrail = TrailType.eFrost;
        _eType = BulletType.eFrostExplosionCir;
        num1 = num1 * (this.GetSkillFac2(mon.nPos, SkillKey.eFrostBall) * 0.01f) * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eFrostBall) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetAccModFac(mon.nPos, ModType.eBigSnowBall) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eFrostBall));
      }
      int _nRicochet = 0;
      if (mon.isRicochet)
      {
        _nRicochet = (int) this.GetSkillFac2(mon.nPos, SkillKey.eRicochet);
        num1 *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eRicochet);
      }
      if ((double) Info.GetPartySkillFac(SkillKey.eRicochetParty) > 0.0 && (double) Random.Range(0.0f, 100f) < (double) Info.GetPartySkillFac(SkillKey.eRicochetParty))
        _nRicochet += 3;
      bool bAssasin = (double) Random.Range(0.0f, 100f) < (double) this.GetSkillFac(mon.nPos, SkillKey.eAssasinate) + (double) Info.GetAccModFac(mon.nPos, ModType.eCriAssasinate) * 0.00999999977648258 * (double) mon.fCriRate;
      if (bAssasin)
        num1 = num1 * 25f * (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eAssasinate) * 0.00999999977648258) * (1f + this.GetSkillFac3(mon.nPos, SkillKey.eAssasinate));
      if (this.eTrial == MutateType.eJustOne)
        nShot = battleItem.nSpread;
      fPlus = num1 * (float) (1.0 + (double) nShot * (double) this.GetSkillFac(mon.nPos, SkillKey.eManyWeapon) * 0.00999999977648258);
      float fDmg = Info.GetBattleItem(nEquip).fDmg * fPlus;
      float[] numArray = new float[nShot];
      float num2 = Random.Range(-max1, max1);
      if (nShot != 1)
      {
        if (nShot == 2)
        {
          numArray[0] = num2 - 2.5f;
          numArray[1] = num2 + 2.5f;
        }
        else
        {
          float num3 = (float) Mathf.Max(6 - (int) ((double) nShot * 0.5), 3);
          float num4 = (float) ((double) num2 + (double) (nShot - 1) * 0.5 * -(double) num3 + (nShot % 2 != 0 ? 0.0 : -(double) num3 * 0.5));
          for (int index = 0; index < nShot; ++index)
            numArray[index] = num4 + (float) index * num3;
        }
      }
      else
        numArray[0] = num2;
      Vector2 vector2 = (Vector2) (targetPos - (mon.transform.localPosition + this.vFirePos));
      for (int index = 0; index < numArray.Length; ++index)
        this.GetBullet(mon.transform.position + this.vFirePos).SetTarget(mon, _eTrail, _eType, (Vector2) (Quaternion.Euler(0.0f, 0.0f, numArray[index]) * (Vector3) vector2).normalized, battleItem, fDmg, flag2, _bHuge, bAssasin, _nRicochet, 1f);
      if ((double) this.GetSkillFac(mon.nPos, SkillKey.eCloneArrow) > (double) Random.Range(0.0f, 100f))
      {
        for (int index = 0; index < numArray.Length; ++index)
          this.GetBullet(mon.transform.position + this.vFirePos).SetTarget(mon, _eTrail, _eType, (Vector2) (Quaternion.Euler(0.0f, 0.0f, numArray[index]) * (Vector3) vector2).normalized, battleItem, fDmg, flag2, _bHuge, bAssasin, _nRicochet, 0.7f);
      }
      if (Info.GetAccModFacToInt(mon.nPos, ModType.eRandomShot) > 0)
        this.GetBullet(mon.transform.position + this.vFirePos).SetTarget(mon, _eTrail, _eType, (Vector2) (Quaternion.Euler(0.0f, 0.0f, (float) Random.Range(-35, 35)) * (Vector3) vector2).normalized, battleItem, fDmg, flag2, _bHuge, bAssasin, _nRicochet, 1f);
    }
    if (bDmg && (double) Random.Range(0.0f, 100f) < (double) Info.GetElementalFac(ElementalID.eFireStorm, 0))
    {
      for (int index = 0; index < this.listEnemy.Count; ++index)
      {
        if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
          this.MonsterDamage(this.listEnemy[index], (float) ((double) Info.GetDamage(mon, this.listEnemy[index], battleItem) * (double) fPlus * (double) Info.GetElementalFac(ElementalID.eFireStorm, 1) * 0.00999999977648258), true, mon, false, true);
      }
    }
    if (!flag1)
      this.PlayWeaponThrowSound(weapon.eWeapon);
    if (!bDmg)
      return;
    mon.OnShootEnd(nShot, nAtkTime);
    this.RefreshAmmo();
  }

  private void PlayWeaponThrowSound(WeaponType eWeapon)
  {
    switch (eWeapon)
    {
      case WeaponType.eAxe:
      case WeaponType.eMace:
      case WeaponType.eShield:
        UIMgr.PlaySound("SwingVeryLarge" + (object) Random.Range(0, 3), false);
        break;
      case WeaponType.eBow:
        UIMgr.PlaySound("Shoot" + (object) Random.Range(0, 2), false);
        break;
      case WeaponType.eDagger:
      case WeaponType.eWand:
      case WeaponType.eShriken:
        UIMgr.PlaySound("Throw" + (object) Random.Range(0, 4), false);
        break;
      case WeaponType.eSword:
      case WeaponType.eStaff:
      case WeaponType.eSpear:
        UIMgr.PlaySound("SwingMedium" + (object) Random.Range(0, 3), false);
        break;
    }
  }

  [DebuggerHidden]
  private IEnumerator StartChainLightning(Monster mon, Enemy em, BattleItemData bData, Vector2 vLastPos, float fPlus, bool bThunder, bool bCri, int nTimes)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartChainLightning\u003Ec__IteratorB() { em = em, nTimes = nTimes, mon = mon, fPlus = fPlus, bThunder = bThunder, bData = bData, bCri = bCri, vLastPos = vLastPos, \u0024this = this };
  }

  private void HitThunder(Vector2 v2Pos, Monster mon, BattleItemData bData, float fPlus, bool bCri)
  {
    float num1 = (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eThunder) * 0.00999999977648258);
    Vector3 vSca = Vector3.one * num1;
    UIMgr.PlaySound("Explosion" + (object) Random.Range(0, 2), false);
    CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 2, PageBattle.vShakePos, Vector3.zero, 1f, 90f, 0.9f, 0.0f, true);
    ParticleMgr.Play("Thunder", (Vector3) v2Pos, Quaternion.identity, vSca);
    fPlus *= (float) (1.0 + (double) this.GetSkillFac2(mon.nPos, SkillKey.eThunder) * 0.00999999977648258);
    fPlus *= (float) (1.0 + (double) Info.GetAccModFac(ModType.eFirstThunder) * 0.00999999977648258);
    fPlus *= 1f + this.GetSkillFac3(mon.nPos, SkillKey.eThunder);
    int num2 = Physics2D.CircleCastNonAlloc(v2Pos, 50f * num1, Vector2.zero, this.hits);
    bool flag = false;
    if (num2 == 0)
      return;
    for (int index = 0; index < num2; ++index)
    {
      if (!(this.hits[index].transform.tag != "Enemy"))
      {
        Enemy component = this.hits[index].transform.GetComponent<Enemy>();
        if (!((Object) component == (Object) null) && component.gameObject.activeInHierarchy && !component.isDead)
        {
          flag = component.isDead;
          this.MonsterDamage(component, Info.GetDamage(mon, component, bData) * fPlus, bCri, mon, false, true);
        }
      }
    }
  }

  [DebuggerHidden]
  private IEnumerator StartUnlimitedSword(Monster mon, BattleItemData bData, float fDmg, int nTimes)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartUnlimitedSword\u003Ec__IteratorC() { nTimes = nTimes, mon = mon, bData = bData, fDmg = fDmg, \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartSummonSword(Monster mon, Vector3 vTgtPos, BattleItemData bData, float fDmg, int nShot, bool bCri, bool bThree, bool bLeft, bool bGap)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartSummonSword\u003Ec__IteratorD() { nShot = nShot, bLeft = bLeft, bThree = bThree, mon = mon, vTgtPos = vTgtPos, bData = bData, fDmg = fDmg, bCri = bCri, bGap = bGap, \u0024this = this };
  }

  private void RefreshAmmo()
  {
    this.textAmmo.text = this.crAmmo.ToString() + "/" + this.crMaxAmmo.ToString();
    this.imgFillAmmo.fillAmount = Mathf.Clamp((float) (int) this.crAmmo / (float) (int) this.crMaxAmmo, 0.0f, 1f);
  }

  [DebuggerHidden]
  private IEnumerator HitArea(Vector2 v2Pos, Monster mon, long nEquip, float fPlus, bool bCri, string strFX, float fHitSize, float fAddSize, float fTimeGap, bool bBig, bool bSlash = false)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CHitArea\u003Ec__IteratorE() { fTimeGap = fTimeGap, fAddSize = fAddSize, fHitSize = fHitSize, bBig = bBig, bCri = bCri, bSlash = bSlash, strFX = strFX, v2Pos = v2Pos, mon = mon, nEquip = nEquip, fPlus = fPlus, \u0024this = this };
  }

  public void OnShootLaser(Monster mon, Vector3 vStart, Vector3 vEnd, float fSize, float fPlus, int nLaserNum, bool bDmg, bool bCri)
  {
    vEnd = vStart + (vEnd - vStart).normalized * 1000f;
    if (!Info.option.bAllFXOff)
    {
      if (!this.arrLaser[nLaserNum].gameObject.activeInHierarchy)
        this.arrLaser[nLaserNum].gameObject.SetActive(true);
      this.arrLaser[nLaserNum].OnCreated(fSize, vStart, vEnd);
    }
    if (!bDmg)
      return;
    Rect rect = new Rect(0.0f, 0.0f, 2000f, fSize);
    Vector2 normalized = (Vector2) (vEnd - vStart).normalized;
    Vector3 vector3 = new Vector3(0.0f, 0.0f, ((double) normalized.y >= 0.0 ? 1f : -1f) * Vector2.Angle(new Vector2(1f, 0.0f), normalized));
    int num1 = Physics2D.BoxCastNonAlloc((Vector2) vStart, rect.size, vector3.z, Vector2.zero, this.hits);
    if (num1 == 0)
      return;
    BattleItemData battleItem = Info.GetBattleItem(mon.nEquip);
    float num2 = 1f;
    bool flag = false;
    for (int index = 0; index < num1; ++index)
    {
      if (!(this.hits[index].transform.tag != "Enemy"))
      {
        Enemy component = this.hits[index].transform.GetComponent<Enemy>();
        if (!((Object) component == (Object) null))
        {
          flag = component.isDead;
          this.MonsterDamage(component, Info.GetDamage(mon, component, battleItem) * fPlus * num2, bCri, mon, false, true);
        }
      }
    }
  }

  public Bullet GetBullet(Vector3 vPos)
  {
    Bullet bullet = (Bullet) null;
    if (this.listBulletDead.Count != 0)
    {
      bullet = this.listBulletDead[0];
      this.listBulletDead.Remove(bullet);
    }
    if ((Object) bullet == (Object) null)
      bullet = Object.Instantiate<GameObject>(this.goBullet).GetComponent<Bullet>();
    bullet.transform.position = vPos;
    bullet.transform.localRotation = Quaternion.identity;
    bullet.gameObject.SetActive(true);
    ++bullet.nCreated;
    this.listBulletAlive.Add(bullet);
    return bullet;
  }

  public EnemyBullet GetEnemyBullet(Vector3 vPos)
  {
    EnemyBullet enemyBullet = (EnemyBullet) null;
    if (this.listEnemyBulletDead.Count != 0)
    {
      enemyBullet = this.listEnemyBulletDead[0];
      this.listEnemyBulletDead.Remove(enemyBullet);
    }
    if ((Object) enemyBullet == (Object) null)
      enemyBullet = Object.Instantiate<GameObject>(this.goEnemyBullet).GetComponent<EnemyBullet>();
    enemyBullet.transform.position = vPos;
    enemyBullet.transform.localRotation = Quaternion.identity;
    enemyBullet.gameObject.SetActive(true);
    this.listEnemyBulletAlive.Add(enemyBullet);
    return enemyBullet;
  }

  public void OnBulletDiabled(Bullet bul)
  {
    bul.OnDisabled();
    bul.gameObject.SetActive(false);
    this.listBulletAlive.Remove(bul);
    this.listBulletDead.Add(bul);
  }

  public void OnBulletRicochet(Bullet bul, Enemy pPreEnemy)
  {
    List<Enemy> enemyList = new List<Enemy>();
    for (int index = 0; index < this.listEnemy.Count; ++index)
    {
      if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead && !((Object) this.listEnemy[index] == (Object) pPreEnemy))
        enemyList.Add(this.listEnemy[index]);
    }
    if (enemyList.Count == 0)
      return;
    Enemy enemy = enemyList[Random.Range(0, enemyList.Count)];
    bul.ResetTarget((Vector2) (enemy.vPos - bul.transform.localPosition).normalized);
    bul.fPow *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eRicochet) * 0.00999999977648258);
    bul.fDmgArmor *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eRicochet) * 0.00999999977648258);
    bul.fDmgMagic *= (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eRicochet) * 0.00999999977648258);
    if (!((Object) bul.pMon != (Object) null))
      return;
    bul.pMon.OnRicochet();
  }

  private bool MonsterDamage(Enemy em, Bullet bul, float fDmgPlus = 1f)
  {
    float fPow = bul.fPow;
    bool flag = bul.eWeapon != WeaponType.eWand && bul.eWeapon != WeaponType.eStaff && bul.eWeapon != WeaponType.eMonster;
    float num;
    switch (em.eArmor)
    {
      case ArmorType.eArmored:
        num = fPow * (bul.fDmgArmor * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eArmor) * 0.00999999977648258)) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eArmorDmgParty) * 0.00999999977648258);
        break;
      case ArmorType.eMagical:
        num = fPow * (bul.fDmgMagic * (float) (1.0 + (double) Info.GetResearchFac(ResearchID.eMagic) * 0.00999999977648258)) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eMagicDmgParty) * 0.00999999977648258);
        break;
      default:
        num = fPow * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eSlaughterer) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eDarkNormalDmg, 0) * 0.00999999977648258) * (float) (1.0 + (double) Info.GetPartySkillFac(SkillKey.eNormalDmgParty) * 0.00999999977648258);
        break;
    }
    if (PageBattle.CheckMutation(MutateType.eBlock) && flag)
      num *= (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.eBlock) * 0.00999999977648258);
    if (PageBattle.CheckMutation(MutateType.eBarrier) && !flag)
      num *= (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.eBarrier) * 0.00999999977648258);
    if ((Object) bul.pMon != (Object) null && bul.nHit == 1 && bul.bHuge)
      num *= (float) (1.0 + (double) this.GetSkillFac(bul.pMon.nPos, SkillKey.eDeathStrike) * 0.00999999977648258);
    bool isDead = em.isDead;
    this.MonsterDamage(em, num * fDmgPlus, bul.bCri, bul.pMon, false, true);
    if (em.bBoss && bul.gameObject.activeInHierarchy && (PageBattle.CheckMutation(MutateType.eAbsorb) && (double) Random.Range(0.0f, 100f) < (double) PageBattle.GetMutation1(MutateType.eAbsorb)))
      this.OnBulletDiabled(bul);
    if (!isDead && em.isDead && bul.gameObject.activeInHierarchy)
    {
      bul.OnKill();
      Info.CheckOneShotAcv(bul.nKill++);
    }
    return bul.bCri;
  }

  private void OnSoulExplosion(float fDmg, Vector3 vPos)
  {
    UIMgr.PlaySound("Explosion" + (object) Random.Range(0, 2), false);
    ParticleMgr.Play("ExplosionCirGreen", vPos);
    CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 2, PageBattle.vShakePos, Vector3.zero, 1f, 90f, 0.9f, 0.0f, true);
    int num = Physics2D.CircleCastNonAlloc((Vector2) vPos, 90f, Vector2.zero, this.hits);
    if (num == 0)
      return;
    for (int index = 0; index < num; ++index)
    {
      if (!(this.hits[index].transform.tag != "Enemy"))
      {
        Enemy component = this.hits[index].transform.GetComponent<Enemy>();
        if (!((Object) component == (Object) null) && component.gameObject.activeInHierarchy && !component.isDead)
        {
          this.MonsterDamage(component, fDmg, false, this.pSoulMon, false, true);
          if (component.isDead && Info.CheckResearch(ResearchID.eSoulBomb))
          {
            if (Info.option.bOptimize)
              this.OnItemReach(BattleCoinElt.Type.eHP, -1f);
            else
              this.MakeCoin(BattleCoinElt.Type.eHP, 0.0f, component.transform.position, 1f);
          }
        }
      }
    }
  }

  private void MonsterDamage(Enemy em, float fDmg, bool bCri, Monster pMon = null, bool bForce = false, bool bCalc = true)
  {
    if ((double) fDmg > 0.0 && bCalc)
    {
      if (em.bBoss)
      {
        fDmg *= (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eBossDmg) * 0.00999999977648258);
        fDmg *= (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eRubyBossDmg) * 0.00999999977648258);
      }
      fDmg *= em.fTakeDmg * em.fTakeDmg2;
      if ((double) Info.GetElementalFac(ElementalID.eDarkLowHPDmg, 0) > 0.0)
        fDmg *= (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eDarkLowHPDmg, 0) * (1.0 - (double) (float) this.fHPRate) * 0.00999999977648258);
      if ((double) Info.GetElementalFac(ElementalID.eDarkDmgEmHP, 0) > 0.0)
        fDmg *= (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eDarkDmgEmHP, 0) * (1.0 - (double) em.fHPRate) * 0.00999999977648258);
      if (em.isEntangle)
        fDmg *= 2f;
      if (em.bAtkDungeon)
        fDmg *= (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eLightObs2, 0) * 0.00999999977648258);
      if (this.eTrial == MutateType.eHeatManage)
        fDmg *= (float) ((1.0 - (double) Mathf.Abs((float) ((double) this.fCurrentBalanceGuage * 2.0 - 1.0))) * 3.0);
      if ((Object) pMon != (Object) null)
      {
        float num1 = (float) ((double) this.GetSkillFac(pMon.nPos, SkillKey.eExcute) * 0.00999999977648258 * (1.0 - (double) em.fHPRate));
        if ((double) num1 > 0.0)
          fDmg += fDmg * num1;
        float num2 = this.GetSkillFac(pMon.nPos, SkillKey.eLongshot) * 0.01f;
        if ((double) num2 > 0.0)
        {
          float num3 = Vector2.Distance((Vector2) pMon.transform.position, (Vector2) em.transform.position);
          fDmg += fDmg * Mathf.Clamp(num3 * 0.0018f, 0.0f, 1f) * num2;
        }
        float num4 = this.GetSkillFac(pMon.nPos, SkillKey.eSmash) * 0.01f;
        if ((double) num4 > 0.0)
          fDmg += fDmg * (1f - Mathf.Clamp((float) ((210.0 + (double) em.transform.position.x) * 0.00179999996908009), 0.0f, 1f)) * num4;
        if ((double) Random.Range(0, 100) < (double) this.GetSkillFac(pMon.nPos, SkillKey.eSmite))
          em.SetStun(3f);
        if (em.isStun)
          fDmg *= (float) (1.0 + (double) this.GetSkillFac(pMon.nPos, SkillKey.eWeakHunt) * 0.00999999977648258);
        float skillFac = this.GetSkillFac(pMon.nPos, SkillKey.eSuppress);
        if ((double) skillFac > 0.0)
          em.SetSlow(skillFac);
      }
    }
    if ((Object) pMon != (Object) null && bCalc)
    {
      if ((double) Random.Range(0.0f, 100f) < (double) Info.GetElementalFac(ElementalID.eWaterHitStun, 0))
      {
        em.SetStun(1f);
        if (!Info.option.bOptimize)
          ParticleMgr.Play("HitIce", em.transform);
      }
      if ((double) Random.Range(0.0f, 100f) < (double) Info.GetElementalFac(ElementalID.eNatureEntangle, 0))
        em.SetEntangle(2f);
      if ((double) Random.Range(0.0f, 100f) < (double) Info.GetElementalFac(ElementalID.eWaterHitSlow, 0))
      {
        em.SetSlow(Info.GetElementalFac(ElementalID.eWaterAtkSlow, 1));
        fDmg *= 2f;
        if (!Info.option.bOptimize)
          ParticleMgr.Play("HitWater", em.transform);
      }
      if ((double) Random.Range(0.0f, 100f) < (double) Info.GetElementalFac(ElementalID.eWaterCrushWave, 0))
        fDmg *= (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eWaterCrushWave, 1) * 0.00999999977648258);
      if (em.isStun)
        fDmg *= (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eWaterStunDmg, 0) * 0.00999999977648258);
      if ((double) Info.GetElementalFac(ElementalID.eWaterSlowCr, 0) > 0.0)
        fDmg *= (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eWaterSlowCr, 0) * (double) Mathf.Max(0.0f, 1f - em.fSlowRate) * 0.00999999977648258);
      if (!em.bBoss && (double) fDmg > 0.0)
        fDmg += (float) (em.hp * (double) this.GetSkillFac(pMon.nPos, SkillKey.eHpRateStrike) * 0.00999999977648258);
    }
    if (em.isDivine)
      fDmg = !bCri ? 1f : 2f;
    if ((em.isInvincible || em.isProtected) && !bForce)
      fDmg = 0.0f;
    if ((this.eTrial == MutateType.eWeakPoint || this.eTrial == MutateType.eOnlyCri) && !bCri)
      fDmg = 1f;
    bool isDead = em.isDead;
    em.SetDamage((double) fDmg);
    if ((Object) pMon != (Object) null)
    {
      pMon.fDmgDealt += (double) fDmg;
      if (bCri)
        pMon.OnCrit();
    }
    if (em.isReflect && !this.isInvincible)
      this.DungeonDamage(Info.GetMonDmg((int) this.nDay));
    for (int index = 0; index < this.emTrialBoss.Length; ++index)
    {
      if (!((Object) this.emTrialBoss[index] == (Object) null) && !((Object) this.emTrialBoss[index] != (Object) em))
        this.imgBossHP.fillAmount = Mathf.Clamp(em.fHPRate, 0.0f, 1f);
    }
    if (!isDead && em.isDead)
    {
      bool flag1 = PageBattle.CheckMutation(MutateType.eRedMyst);
      bool flag2 = PageBattle.CheckMutation(MutateType.eLifeBloom);
      bool flag3 = this.eTrial == MutateType.eSacrifice;
      if (flag1 || flag2 || flag3)
      {
        for (int index = 0; index < this.listEnemy.Count; ++index)
        {
          if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead && (!((Object) this.listEnemy[index] == (Object) em) && (double) Vector2.Distance((Vector2) this.listEnemy[index].transform.position, (Vector2) em.transform.position) <= 100.0))
          {
            if (flag1)
              this.listEnemy[index].SetSlow(-PageBattle.GetMutation1(MutateType.eRedMyst));
            if (flag2)
            {
              float num = PageBattle.GetMutation1(MutateType.eLifeBloom) * 0.01f * (float) em.maxhp;
              this.listEnemy[index].SetDamage(-(double) num);
            }
            if (flag3)
              this.listEnemy[index].SetInvincible(0.5f);
          }
        }
      }
      if ((Object) pMon != (Object) null)
      {
        pMon.OnKill();
        if ((double) this.GetSkillFac(pMon.nPos, SkillKey.eKillRegen) > 0.0)
          this.DungeonHeal(this.GetSkillFac(pMon.nPos, SkillKey.eKillRegen), false);
        if (this.goLeftSkill.activeInHierarchy)
          this.arrActiveSkillLeft[(int) Info.GetPlayerMon(pMon.nPos).byBatch].UpdateGuage(5f, false, false);
        else
          this.arrActiveSkill[pMon.nPos].UpdateGuage(5f, false, false);
        bool flag4 = 0.0 < (double) this.GetSkillFac(pMon.nPos, SkillKey.eSoulBomb);
        if (flag4 || (double) this.fSoulBombDps > 0.0)
          this.OnSoulExplosion(!flag4 ? this.fSoulBombDps : (float) ((double) Info.GetDamage(pMon) * (double) this.GetSkillFac2(pMon.nPos, SkillKey.eSoulBomb) * 0.00999999977648258), em.transform.localPosition);
      }
    }
    else if ((double) fDmg > 0.0)
    {
      if (PageBattle.CheckMutation(MutateType.eBerserk) && !em.bBoss)
        em.SetSlow(-PageBattle.GetMutation1(MutateType.eBerserk));
      if (!em.bBoss && PageBattle.CheckMutation(MutateType.eShift) && (double) Random.Range(0.0f, 100f) < (double) PageBattle.GetMutation1(MutateType.eShift))
        em.transform.position = new Vector3(em.transform.position.x, (float) Random.Range(160, -130));
      if ((Object) pMon != (Object) null)
      {
        if (bCri && Info.GetSkill(pMon.nPos, SkillKey.eHunting) > 0)
          em.SetTakeDmg2(Mathf.Min(em.fTakeDmg2 + this.GetSkillFac(pMon.nPos, SkillKey.eHunting) * 0.01f, this.GetSkillFac2(pMon.nPos, SkillKey.eHunting) * 0.01f));
        if ((double) this.GetSkillFac(pMon.nPos, SkillKey.eWeakSpot) > 0.0)
          em.SetTakeDmg(Mathf.Clamp(em.fTakeDmg + this.GetSkillFac(pMon.nPos, SkillKey.eWeakSpot) * 0.01f, 1f, 2f));
        if ((double) this.GetSkillFac(pMon.nPos, SkillKey.eWeakShot) > 0.0)
          em.fGiveDmg = Mathf.Max(em.fGiveDmg * (float) (1.0 - (double) this.GetSkillFac(pMon.nPos, SkillKey.eWeakShot) * (!em.bBoss ? 0.00999999977648258 : 0.00499999988824129)), (float) (1.0 - (double) this.GetSkillFac2(pMon.nPos, SkillKey.eWeakShot) * 0.00999999977648258));
      }
    }
    string strMsg = fDmg.ToString("N0");
    if ((double) fDmg > 1000000.0)
      strMsg = (fDmg * 1E-06f).ToString("##0.#") + "M";
    else if ((double) fDmg > 1000.0)
      strMsg = (fDmg * (1f / 1000f)).ToString("##0.#") + "K";
    this.ShowText(em.transform.localPosition, strMsg, !bCri ? Color.white : Color.red, 80f);
  }

  private void ShowText(Vector3 vPos, string strMsg, Color clText, float fDist = 80f)
  {
    if (Info.option.bHideDamageOutput)
      return;
    this.GetDmgText().SetText((Vector2) vPos, strMsg, clText, fDist);
  }

  public void SetFlash(float r, float g, float b, float a = 0.25f, float fSpd = 2f)
  {
    this.clScreen.r = r;
    this.clScreen.g = g;
    this.clScreen.b = b;
    this.clScreen.a = a;
    this.fScreenSpd = fSpd;
    this.imgScreenFX.color = this.clScreen;
  }

  public void OnEnemyDead(Enemy em)
  {
    for (int index = 0; index < this.listMonster.Count; ++index)
    {
      if (this.listMonster[index].isActiveAndEnabled && (Object) this.listMonster[index].target == (Object) em)
        this.listMonster[index].target = (Enemy) null;
    }
    for (int index = 0; index < this.listEnemyBulletAlive.Count; ++index)
    {
      if ((Object) this.listEnemyBulletAlive[index].em == (Object) em)
        this.listEnemyBulletAlive[index].em = (Enemy) null;
    }
    PageBattle pageBattle1 = this;
    ObscuredInt obscuredInt1 = (ObscuredInt) ((int) pageBattle1.nGold + em.nDropGold);
    pageBattle1.nGold = obscuredInt1;
    PageBattle pageBattle2 = this;
    ObscuredInt obscuredInt2 = (ObscuredInt) ((int) pageBattle2.nExp + em.nExp);
    pageBattle2.nExp = obscuredInt2;
    if (this.eTrial == MutateType.eSplit && (double) em.transform.localScale.x > 150.0)
    {
      List<Enemy> enemyList = new List<Enemy>();
      for (int index = 0; index < this.emTrialBoss.Length; ++index)
      {
        if (!((Object) this.emTrialBoss[index] == (Object) null) && !((Object) this.emTrialBoss[index] == (Object) em) && (this.emTrialBoss[index].gameObject.activeInHierarchy && !this.emTrialBoss[index].isDead))
          enemyList.Add(this.emTrialBoss[index]);
      }
      Enemy enemy1 = this.SpawnEnemy(em.sID, em.transform.position.x + (float) Random.Range(-30, 30), em.transform.position.y + 30f, (int) this.nDiff, (int) this.nDay, true);
      enemy1.transform.localScale = Vector3.one * em.transform.localScale.x * 0.8f;
      enemyList.Add(enemy1);
      enemy1.SetInvincible(0.2f);
      Enemy enemy2 = this.SpawnEnemy(em.sID, em.transform.position.x + (float) Random.Range(-30, 30), em.transform.position.y - 30f, (int) this.nDiff, (int) this.nDay, true);
      enemy2.transform.localScale = Vector3.one * em.transform.localScale.x * 0.8f;
      enemyList.Add(enemy2);
      enemy2.SetInvincible(0.2f);
      this.emTrialBoss = new Enemy[enemyList.Count];
      for (int index = 0; index < this.emTrialBoss.Length; ++index)
        this.emTrialBoss[index] = enemyList[index];
    }
    bool flag1 = false;
    for (int index = 0; index < this.emTrialBoss.Length; ++index)
    {
      if (!((Object) this.emTrialBoss[index] == (Object) null) && (Object) em == (Object) this.emTrialBoss[index])
        flag1 = true;
    }
    if (flag1 && this.bSummon)
    {
      bool flag2 = true;
      for (int index = 0; index < this.emTrialBoss.Length; ++index)
      {
        if (!((Object) this.emTrialBoss[index] == (Object) null) && this.emTrialBoss[index].gameObject.activeInHierarchy && !this.emTrialBoss[index].isDead)
        {
          if (this.eTrial == MutateType.eGemini)
            Info.fEmAspBonus = (ObscuredFloat) ((float) Info.fEmAspBonus + 1f);
          flag2 = false;
        }
      }
      if (flag2)
      {
        this.goClock.SetActive(false);
        this.goNumQuiz.SetActive(false);
        this.goStone.SetActive(false);
        this.bBattleOver = (ObscuredBool) true;
        this.ClearAllEnemyByDamage();
      }
    }
    if (em.nDropGold > 0)
    {
      if (Info.option.bOptimize)
        this.OnItemReach(BattleCoinElt.Type.eGold, (float) em.nDropGold);
      else
        this.MakeCoin(BattleCoinElt.Type.eGold, (float) em.nDropGold, em.transform.position, 1f);
    }
    UIMgr.PlaySound("Dead" + (object) Random.Range(0, 3), false);
    if ((double) Random.Range(0.0f, 100f) < (double) Info.GetPartySkillFac(SkillKey.eHarvest))
    {
      if (Info.option.bOptimize)
        this.OnItemReach(BattleCoinElt.Type.eHP, -1f);
      else
        this.MakeCoin(BattleCoinElt.Type.eHP, 0.0f, em.transform.position, 1f);
    }
    if (Info.eBattle != BattleType.eSurvial || (double) Random.Range(0.0f, 100f) > (double) PageBattle.fDropRate)
      return;
    Info.AddRandomDropWeapon();
    if (Info.option.bOptimize)
      this.OnItemReach(BattleCoinElt.Type.eItem, -1f);
    else
      this.MakeCoin(BattleCoinElt.Type.eItem, 0.0f, em.transform.position, 1f);
  }

  public void OnEnemyDisable(Enemy em)
  {
    em.gameObject.SetActive(false);
  }

  public void OnEnemyShooting(Enemy em)
  {
    this.GetEnemyBullet(em.transform.position + PageBattle.vEnemyFirePos).SetBullet(em.fDmg * em.fGiveDmg, 700f, em);
  }

  public void DungeonDamage(float fDmg)
  {
    if ((bool) this.bBattleOver)
      return;
    if ((double) fDmg < 1.0)
      fDmg = 1f;
    if ((double) Info.GetElementalFac(ElementalID.eNatureShell, 0) > 0.0)
      this.fNatureShell = (ObscuredFloat) Mathf.Max((float) this.fNatureShell - Info.GetElementalFac(ElementalID.eNatureShell, 0) * 0.01f, (float) (1.0 - (double) Info.GetElementalFac(ElementalID.eNatureShell, 1) * 0.00999999977648258));
    if ((double) Info.GetElementalFac(ElementalID.eLightPainkiller, 0) > 0.0 && (double) (float) this.fPainKillerCool <= 0.0)
    {
      this.fPainKillerDur = (ObscuredFloat) Info.GetElementalFac(ElementalID.eLightPainkiller, 0);
      this.fPainKillerCool = (ObscuredFloat) Info.GetElementalFac(ElementalID.eLightPainkiller, 2);
    }
    ++this.nDamagedNum;
    CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 3, PageBattle.vShakePos, Vector3.zero, 2f, 140f, 0.7f, 0.0f, true);
    PageBattle pageBattle = this;
    ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) pageBattle.fHP - fDmg);
    pageBattle.fHP = obscuredFloat;
    if (!Info.option.bCriFlashOff)
      this.SetFlash(1f, 0.0f, 0.0f, 0.25f, 2f);
    UIMgr.PlaySound("PlayerHit" + (object) Random.Range(0, 3), false);
    if ((double) (float) this.fHP <= 0.0)
    {
      if ((bool) this.bCanRevive)
      {
        this.fHP = Info.fDunMaxHP;
        this.bCanRevive = (ObscuredBool) false;
      }
      else
      {
        CameraShake.instance.CancelShake();
        this.goNumQuiz.SetActive(false);
        this.goClock.SetActive(false);
        this.goStone.SetActive(false);
        this.bBattleOver = (ObscuredBool) true;
        this.bGameOver = (ObscuredBool) true;
        this.StopAllCoroutines();
        Time.timeScale = 1f;
        if (Info.eBattle == BattleType.eEndless)
        {
          UIMgr.AddPage("PopupEndlessResult");
        }
        else
        {
          UIMgr.PlaySound("GameOver", false);
          UIMgr.AddPage("PopupGameOver");
          Info.bBattleFail = true;
        }
        for (int index = 0; index < this.listMonster.Count; ++index)
        {
          if (this.listMonster[index].isActiveAndEnabled)
            this.listMonster[index].Reload(false, 0.0f);
        }
        for (int index = 0; index < this.listEnemy.Count; ++index)
        {
          if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
            this.listEnemy[index].OnSleep();
        }
        List<Bullet> bulletList = new List<Bullet>((IEnumerable<Bullet>) this.listBulletAlive);
        for (int index = 0; index < bulletList.Count; ++index)
          this.OnBulletDiabled(bulletList[index]);
      }
    }
    else
    {
      for (int index = 0; index < this.listMonster.Count; ++index)
      {
        if (this.listMonster[index].gameObject.activeInHierarchy)
          this.listMonster[index].AddRage(Info.GetPartySkillFac(SkillKey.eGuardman));
      }
    }
  }

  public void DungeonHeal(float fHeal, bool isRegen = false)
  {
    if ((bool) this.bBattleOver)
      return;
    fHeal *= (float) (1.0 + (double) Info.GetElementalFac(ElementalID.eNatureRegen, 0) * 0.00999999977648258);
    PageBattle pageBattle = this;
    ObscuredFloat obscuredFloat = (ObscuredFloat) ((float) pageBattle.fHP + fHeal * (!isRegen ? (float) (1.0 + (double) Info.GetRebirthFac(RebirthID.eRegen) * 0.00999999977648258) : 1f));
    pageBattle.fHP = obscuredFloat;
  }

  public void OnEnemyBulletCollision(EnemyBullet bul)
  {
    float reducedDamage = this.GetReducedDamage(bul.em, bul.fDmg);
    float num = (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.ePrecision) * 0.00999999977648258);
    bool flag1 = false;
    bool flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetPartySkillFac(SkillKey.eNegativeAttack) * (double) num;
    if (!flag2)
      flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetAcvReward(AcvRewardType.eEvade) * (double) num;
    if (!flag2)
      flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetResearchFac(ResearchID.eAcientWall) * (double) num;
    for (int nPos = 0; nPos < 5; ++nPos)
    {
      if (!flag2)
        flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetAccModFac(nPos, ModType.eEvade) * (double) num;
    }
    if (!flag2)
      flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetElementalFac(ElementalID.eLightShine, 0);
    if (!flag2 && (bool) this.bLightShield)
    {
      flag1 = (bool) this.bLightShield;
      this.bLightShield = (ObscuredBool) false;
    }
    if (this.isInvincible)
      flag1 = this.isInvincible;
    if (!flag2 && !flag1)
    {
      this.ShowText(bul.transform.position, Mathf.Max(1f, reducedDamage).ToString("N0"), Color.red, -80f);
      ParticleMgr.Play("HitFire", bul.transform);
      this.DungeonDamage(reducedDamage);
      if ((Object) bul.em != (Object) null)
      {
        if ((double) Info.GetElementalFac(ElementalID.eDarkObs2, 0) > 0.0)
          bul.em.SetStun(Info.GetElementalFac(ElementalID.eDarkObs2, 0));
        if ((double) Info.GetElementalFac(ElementalID.eLightObs2, 0) > 0.0)
          bul.em.bAtkDungeon = true;
        if ((double) Info.GetElementalFac(ElementalID.eFireObs2, 0) > 0.0)
        {
          float fDmg = (float) (bul.em.hp * (double) Info.GetElementalFac(ElementalID.eFireObs2, 0) * 0.00999999977648258);
          if (bul.em.bBoss)
            fDmg *= 0.1f;
          this.MonsterDamage(bul.em, fDmg, false, (Monster) null, false, false);
        }
      }
    }
    else
      this.ShowText(bul.transform.position, !flag1 ? "Miss" : "Immune", Color.white, 0.0f);
    bul.gameObject.SetActive(false);
    this.listEnemyBulletAlive.Remove(bul);
    this.listEnemyBulletDead.Add(bul);
  }

  public void OnEnemyAttack(Enemy em)
  {
    this.vHitPos = em.transform.position;
    this.vHitPos.x -= 20f;
    bool flag1 = false;
    float num = (float) (1.0 - (double) PageBattle.GetMutation1(MutateType.ePrecision) * 0.00999999977648258);
    bool flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetPartySkillFac(SkillKey.eNegativeAttack) * (double) num;
    if (!flag2)
      flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetAcvReward(AcvRewardType.eEvade) * (double) num;
    if (!flag2)
      flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetResearchFac(ResearchID.eAcientWall) * (double) num;
    for (int nPos = 0; nPos < 5; ++nPos)
    {
      if (!flag2)
        flag2 = (double) Random.Range(0.0f, 100f) < (double) Info.GetAccModFac(nPos, ModType.eEvade) * (double) num;
    }
    if (!flag2 && (bool) this.bLightShield)
    {
      flag1 = (bool) this.bLightShield;
      this.bLightShield = (ObscuredBool) false;
    }
    if (this.isInvincible)
      flag1 = this.isInvincible;
    if (!flag2 && !flag1)
    {
      float reducedDamage = this.GetReducedDamage(em, em.fDmg * em.fGiveDmg);
      this.DungeonDamage(reducedDamage);
      this.ShowText(this.vHitPos, Mathf.Max(1f, reducedDamage).ToString("N0"), Color.red, -80f);
      if ((double) Info.GetElementalFac(ElementalID.eDarkObs1, 0) > 0.0 || (double) Info.GetElementalFac(ElementalID.eDarkObs2, 0) > 0.0)
        em.SetStun(Info.GetElementalFac(ElementalID.eDarkObs1, 0) + Info.GetElementalFac(ElementalID.eDarkObs2, 0));
      if ((double) Info.GetElementalFac(ElementalID.eLightObs2, 0) > 0.0)
        em.bAtkDungeon = true;
      if ((double) Info.GetElementalFac(ElementalID.eFireObs1, 0) > 0.0)
      {
        float fDmg = (float) em.hp * (float) ((double) Info.GetElementalFac(ElementalID.eFireObs1, 0) * 0.00999999977648258 + (double) Info.GetElementalFac(ElementalID.eFireObs2, 0) * 0.00999999977648258);
        if (em.bBoss)
          fDmg *= 0.1f;
        this.MonsterDamage(em, fDmg, false, (Monster) null, false, false);
        this.ShowText(em.vPos, fDmg.ToString("N0"), Color.red, 80f);
      }
    }
    else
      this.ShowText(this.vHitPos, !flag1 ? "Miss" : "Immune", Color.white, 0.0f);
    ParticleMgr.Play("HitEarth", this.vHitPos);
    if (em.bBoss || (double) Random.Range(0.0f, 100f) >= (double) Info.GetPartySkillFac(SkillKey.eReturn))
      return;
    em.transform.localPosition = new Vector3(100f, em.transform.localPosition.y);
  }

  public float GetReducedDamage(Enemy em, float fDmg)
  {
    if ((double) fDmg > 0.0)
    {
      if ((Object) em != (Object) null && em.isClose)
        fDmg *= (float) (1.0 - (double) Info.GetElementalFac(ElementalID.eLightObs1, 0) * 0.00999999977648258);
      if ((double) (float) this.fPainKillerDur > 0.0)
        fDmg *= (float) (1.0 - (double) Info.GetElementalFac(ElementalID.eLightPainkiller, 1) * 0.00999999977648258);
      if ((double) Info.GetElementalFac(ElementalID.eDarkReduceDmg, 0) > 0.0)
        fDmg *= (float) (1.0 - (1.0 - (double) (float) this.fHPRate) * (double) Info.GetElementalFac(ElementalID.eDarkReduceDmg, 0) * 0.00999999977648258);
      fDmg *= (float) this.fDungeonDef * (float) this.fNatureShell;
      if ((int) this.nMustReduced > 0)
      {
        fDmg *= 0.25f;
        --this.nMustReduced;
      }
      if ((double) Info.GetElementalFac(ElementalID.eNatureBigShield, 0) > 0.0 && (double) fDmg > (double) (float) this.fBigShieldHP)
        fDmg -= Mathf.Min(fDmg - (float) this.fBigShieldHP, (float) Info.fDunMaxHP);
    }
    return fDmg;
  }

  public void OnReload(Monster mon)
  {
    if ((bool) this.bBattleOver)
      return;
    if (mon.nPos == 0)
      this.RefreshAmmo();
    UIMgr.PlaySound("ReloadEnd", false);
    mon.Reload(false, 0.0f);
  }

  public void OnMainReloading(float fFill)
  {
    if ((bool) this.bBattleOver)
      return;
    this.imgFillAmmo.fillAmount = fFill;
  }

  private float GetMonDPS(int nPos)
  {
    float num = 1f;
    if ((long) Info.GetPlayerMon(nPos).nEquip != -1L)
      num = Info.GetBattleItem((long) Info.GetPlayerMon(nPos).nEquip).fDPS;
    return num;
  }

  public bool CanUseAutoSkill()
  {
    if ((double) this.fLastCheckTime + 0.100000001490116 <= (double) Time.timeSinceLevelLoad)
    {
      this.bLastEnemyAlive = false;
      for (int index = 0; index < this.listEnemy.Count; ++index)
      {
        if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
        {
          this.bLastEnemyAlive = true;
          break;
        }
      }
      this.fLastCheckTime = Time.timeSinceLevelLoad;
    }
    return this.bLastEnemyAlive;
  }

  public void OnActiveSkill(int nPos, SkillKey eSkill)
  {
    if ((bool) this.bBattleOver)
      return;
    float monDps = this.GetMonDPS(nPos);
    float skillFac1 = this.GetSkillFac(nPos, eSkill);
    float skillFac2 = this.GetSkillFac2(nPos, eSkill);
    float num1 = (float) ((double) skillFac1 * (1.0 + (double) Info.GetResearchFac(ResearchID.eAcientPower) * 0.00999999977648258) * (1.0 + (double) Info.GetPartySkillFac(SkillKey.eSpecialParty) * 0.00999999977648258));
    float num2 = (float) ((double) skillFac2 * (1.0 + (double) Info.GetResearchFac(ResearchID.eAcientPower) * 0.00999999977648258) * (1.0 + (double) Info.GetPartySkillFac(SkillKey.eSpecialParty) * 0.00999999977648258));
    int byBatch = (int) Info.GetPlayerMon(nPos).byBatch;
    Monster monster = this.listMonster[byBatch];
    SkillData skill = BData.GetSkill(eSkill);
    switch (eSkill)
    {
      case SkillKey.eWarCry:
        for (int index = 0; index < this.listMonster.Count; ++index)
        {
          if (this.listMonster[index].gameObject.activeInHierarchy)
          {
            this.listMonster[index].OnWarcryBuff(num1, num2 * 0.01f);
            if ((double) Info.GetAccModFac(nPos, ModType.eWarRage) > 0.0)
              this.listMonster[index].AddRage(60f);
          }
        }
        UIMgr.PlaySound("WarCry", false);
        this.SetFlash(1f, 0.0f, 0.0f, 0.25f, 2f);
        break;
      case SkillKey.ePowerSlam:
        for (int index = 0; index < this.listEnemy.Count; ++index)
        {
          if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
            this.listEnemy[index].SetStun(num1);
        }
        UIMgr.PlaySound("PowerSlam", false);
        this.SetFlash(0.5f, 0.0f, 0.0f, 0.25f, 2f);
        CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 3, PageBattle.vShakePos, Vector3.zero, 4f, 100f, 0.25f, 0.0f, true);
        break;
      case SkillKey.eSwift:
        this.listMonster[byBatch].OnSwiftBuff(num1, num2 * 0.01f);
        float fFactor = (float) ((double) num2 * 0.00999999977648258 * (double) Info.GetAccModFac(nPos, ModType.ePartySwift) * 0.00999999977648258);
        if ((double) fFactor > 0.0)
        {
          for (int index = 0; index < this.listMonster.Count; ++index)
          {
            if (this.listMonster[index].gameObject.activeInHierarchy && index != byBatch)
              this.listMonster[index].OnSwiftBuff(num1, fFactor);
          }
        }
        this.SetFlash(1f, 0.0f, 1f, 0.25f, 2f);
        UIMgr.PlaySound("Swift", false);
        break;
      case SkillKey.eDeathShadow:
        this.SetFlash(0.0f, 0.0f, 0.0f, 0.25f, 2f);
        for (int index = 0; index < this.listEnemy.Count; ++index)
        {
          if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead && !this.listEnemy[index].bBoss)
            this.MonsterDamage(this.listEnemy[index], monDps * monster.fFixAtkBonus * Random.Range(0.01f, num1 * 0.01f), true, monster, false, true);
        }
        UIMgr.PlaySound("DeathShadow", false);
        break;
      case SkillKey.eBornParty:
        this.StartCoroutine(this.ThrowBoneParty(this.listMonster[byBatch], (int) num1, (float) ((double) monDps * (double) num2 * 0.00999999977648258) * monster.fFixAtkBonus));
        this.SetFlash(1f, 1f, 1f, 0.25f, 2f);
        UIMgr.PlaySound("BoneParty", false);
        break;
      case SkillKey.eHighSlash:
        this.SetFlash(0.0f, 1f, 1f, 0.25f, 2f);
        this.StartCoroutine(this.HighSlash((double) Info.GetAccModFac(ModType.eSlashAll) > 0.0, byBatch, (int) num1, (float) ((double) monDps * (double) num2 * 0.00999999977648258) * monster.fFixAtkBonus));
        break;
      case SkillKey.eConcentrate:
        for (int index = 0; index < this.listMonster.Count; ++index)
        {
          if (this.listMonster[index].gameObject.activeInHierarchy)
            this.listMonster[index].OnReloadBuff(num1);
        }
        UIMgr.PlaySound("Concentrate", false);
        this.SetFlash(1f, 1f, 0.0f, 0.25f, 2f);
        break;
      case SkillKey.eFireStorm:
        float fDmg1 = (float) ((double) monDps * (double) num1 * 0.00999999977648258) * monster.fFixAtkBonus;
        for (int index = 0; index < this.listEnemy.Count; ++index)
        {
          if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
            this.MonsterDamage(this.listEnemy[index], fDmg1, true, monster, false, true);
        }
        UIMgr.PlaySound("FireStorm", false);
        this.StartCoroutine(this.ShowFireStorm("ExplosionCir"));
        break;
      case SkillKey.ePoisonNova:
        float fDmg2 = (float) ((double) monDps * (double) num1 * 0.00999999977648258) * monster.fFixAtkBonus;
        UIMgr.PlaySound("PoisonNova", false);
        this.StartCoroutine(this.StartPoisonMyst(monster, fDmg2, num2));
        break;
      case SkillKey.eDarkCrystalPower:
        float fDmg3 = (float) ((double) monDps * (double) num1 * 0.00999999977648258) * monster.fFixAtkBonus;
        for (int index = 0; index < this.listEnemy.Count; ++index)
        {
          if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
            this.MonsterDamage(this.listEnemy[index], fDmg3, true, monster, false, true);
        }
        this.DungeonHeal(num2 * (float) (1.0 + (double) this.GetSkillFac(nPos, SkillKey.eHealCrystal) * 0.00999999977648258), false);
        this.StartCoroutine(this.ShowMoonCrystal());
        float skillFac3 = this.GetSkillFac(nPos, SkillKey.eCrystalize);
        for (int index = 0; index < this.arrActiveSkill.Length && (double) skillFac3 > 0.0; ++index)
        {
          if (this.goLeftSkill.activeInHierarchy)
          {
            if (index != byBatch)
              this.arrActiveSkillLeft[index].UpdateGuage(skillFac3, false, false);
          }
          else if (index != nPos)
            this.arrActiveSkill[index].UpdateGuage(skillFac3, false, false);
        }
        break;
      default:
        switch (eSkill - 177)
        {
          case SkillKey.eReloading:
            this.SetFlash(1f, 0.0f, 0.0f, 0.25f, 2f);
            this.StartCoroutine(this.StartFireExplosion(monster, (int) num2, num1));
            break;
          case SkillKey.eBasicTraining:
            this.SetFlash(0.0f, 1f, 1f, 0.25f, 2f);
            num1 *= 0.01f;
            if (Info.CheckBattleItem(monster.nEquip))
            {
              for (int index = 0; index < this.listEnemy.Count; ++index)
              {
                if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
                {
                  if (monster.nEquip != -1L)
                    this.MonsterDamage(this.listEnemy[index], Info.GetDamage(monster, this.listEnemy[index], Info.GetBattleItem(monster.nEquip)) * num1, false, monster, false, true);
                  this.listEnemy[index].SetStun(num2);
                }
              }
            }
            UIMgr.PlaySound("PoisonNova", false);
            this.psBlizzard.Play(false);
            break;
          case SkillKey.ePenetrate:
            this.SetFlash(0.0f, 1f, 0.0f, 0.5f, 2f);
            num1 = skillFac1;
            float num3 = skillFac1 * 0.01f;
            for (int index = 0; index < this.listEnemy.Count; ++index)
            {
              if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
                this.listEnemy[index].SetPolymorph((double) num3);
            }
            break;
          case SkillKey.eFirerate:
            this.SetFlash(1f, 1f, 0.0f, 0.25f, 2f);
            this.DungeonHeal((float) ((double) (float) Info.fDunMaxHP * (double) num1 * 0.00999999977648258), false);
            this.fInvincibleDur = (ObscuredFloat) num2;
            this.psDivine.Play(false);
            break;
          case SkillKey.eSnipe:
            this.DungeonDamage((float) this.fHP * 0.3f);
            for (int index = 0; index < this.listMonster.Count; ++index)
            {
              if (this.listMonster[index].gameObject.activeInHierarchy)
                this.listMonster[index].OnDarkBuff(num1, num2 * 0.01f);
            }
            UIMgr.PlaySound("WarCry", false);
            this.SetFlash(1f, 0.0f, 1f, 0.25f, 2f);
            break;
          default:
            if (eSkill != SkillKey.eUnlimitedSwords)
            {
              if (eSkill != SkillKey.eSuperLaser)
              {
                if (eSkill != SkillKey.eBlizzard)
                {
                  if (eSkill != SkillKey.eBladeStorm)
                  {
                    if (eSkill == SkillKey.eBlueLightning)
                    {
                      this.SetFlash(1f, 0.0f, 0.0f, 0.25f, 2f);
                      this.fSuperLightningTime = (float) (7.0 * (1.0 + (double) Info.GetAccModFac(ModType.eSpecialDuration) * 0.00999999977648258));
                      break;
                    }
                    break;
                  }
                  this.SetFlash(1f, 0.0f, 0.0f, 0.25f, 2f);
                  this.fSuperBladeTime = 7f;
                  break;
                }
                float fDmg4 = (float) ((double) monDps * (double) num1 * 0.00999999977648258) * monster.fFixAtkBonus;
                for (int index = 0; index < this.listEnemy.Count; ++index)
                {
                  if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead)
                  {
                    this.MonsterDamage(this.listEnemy[index], fDmg4, true, monster, false, true);
                    this.listEnemy[index].SetSlow(80f);
                  }
                }
                UIMgr.PlaySound("PoisonNova", false);
                this.StartCoroutine(this.ShowFireStorm("FrostImpact"));
                break;
              }
              this.SetFlash(1f, 0.0f, 1f, 0.25f, 2f);
              this.fSuperLaserTime = (float) (8.0 * (1.0 + (double) Info.GetAccModFac(ModType.eSuperLaserDur) * 0.00999999977648258));
              break;
            }
            float fDmg5 = (float) ((double) monDps * (double) num1 * 0.00999999977648258);
            if ((long) Info.GetPlayerMon(nPos).nEquip != -1L)
            {
              this.StartCoroutine(this.StartUnlimitedSword(this.listMonster[byBatch], Info.GetBattleItem((long) Info.GetPlayerMon(nPos).nEquip), fDmg5, (int) num1));
              break;
            }
            break;
        }
    }
    if (Info.GetPlayerMon(nPos) != null)
      this.listMonster[byBatch].Animate("TriggerCast");
    if ((double) Random.Range(0.0f, 100f) >= (double) Info.GetResearchFac(ResearchID.eAcientCall))
    {
      if (this.goLeftSkill.activeInHierarchy)
        this.arrActiveSkillLeft[(int) Info.GetPlayerMon(nPos).byBatch].OnUsed();
      else
        this.arrActiveSkill[nPos].OnUsed();
    }
    this.SetAlarm(BData.GetString(skill.strName), BData.GetString(skill.strSummary).Replace("[1]", num1.ToString("N0")).Replace("[2]", num2.ToString("N0")), 0.0f, 0.75f, 0.75f);
  }

  public void OnAwakenSkill(int nPos, SkillKey eSkill, AwakenSkillElt elt)
  {
    if ((bool) this.bBattleOver)
      return;
    float f = (float) ((double) this.GetSkillFac(nPos, eSkill) * (1.0 + (double) Info.GetResearchFac(ResearchID.eAcientPower) * 0.00999999977648258) * (1.0 + (double) Info.GetPartySkillFac(SkillKey.eSpecialParty) * 0.00999999977648258));
    float num1 = (float) ((double) this.GetSkillFac2(nPos, eSkill) * (1.0 + (double) Info.GetResearchFac(ResearchID.eAcientPower) * 0.00999999977648258) * (1.0 + (double) Info.GetPartySkillFac(SkillKey.eSpecialParty) * 0.00999999977648258));
    Monster monster = this.listMonster[(int) Info.GetPlayerMon(nPos).byBatch];
    SkillData skill = BData.GetSkill(eSkill);
    int num2 = Mathf.RoundToInt(f);
    switch (eSkill)
    {
      case SkillKey.eMultiShotAwk:
        monster.nMustMultishot = (ObscuredInt) num2;
        break;
      case SkillKey.eCriRateAwk:
        monster.nMustCri = (ObscuredInt) num2;
        break;
      case SkillKey.eBigShotAwk:
        monster.nMustBigshot = (ObscuredInt) num2;
        break;
      case SkillKey.eShieldAwk:
        this.nMustReduced = (ObscuredInt) num2;
        break;
      case SkillKey.eFireBallAwk:
        monster.nMustFireball = (ObscuredInt) num2;
        break;
      case SkillKey.eFireLanceAwk:
        monster.nMustFirelance = (ObscuredInt) num2;
        break;
      case SkillKey.eLuckShotAwk:
        monster.nMustRandomDmg = (ObscuredInt) num2;
        break;
      case SkillKey.eRicochetAwk:
        monster.nMustRicochet = (ObscuredInt) num2;
        break;
      case SkillKey.eSoulBallAwk:
        monster.nMustSoulBall = (ObscuredInt) num2;
        break;
      case SkillKey.eStrongKickAwk:
        monster.nMustStrongKick = (ObscuredInt) num2;
        break;
      case SkillKey.eTripleSwordAwk:
        monster.nMustTripleSword = (ObscuredInt) num2;
        break;
      case SkillKey.eSubLaserAwk:
        monster.nMustSubLaser = (ObscuredInt) num2;
        break;
      case SkillKey.eFrostAwk:
        monster.nMustFrost = (ObscuredInt) num2;
        break;
      case SkillKey.eSlashAwk:
        monster.nMustBigSlash = (ObscuredInt) num2;
        break;
      default:
        if (eSkill != SkillKey.eChainAwk)
        {
          if (eSkill == SkillKey.eExplosionAwk)
          {
            monster.nMustElementalExposion = (ObscuredInt) num2;
            break;
          }
          break;
        }
        monster.nMustChain = (ObscuredInt) num2;
        break;
    }
    this.SetAlarm(BData.GetString(skill.strName), BData.GetString(skill.strSummary).Replace("[1]", f.ToString("N0")).Replace("[2]", num1.ToString("N0")), 0.0f, 0.75f, 0.75f);
    elt.OnUsed();
  }

  [DebuggerHidden]
  private IEnumerator ShowFireStorm(string strFX)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CShowFireStorm\u003Ec__IteratorF() { strFX = strFX, \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator ShowMoonCrystal()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CShowMoonCrystal\u003Ec__Iterator10() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartPoisonMyst(Monster mon, float fDmg, float fDur)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartPoisonMyst\u003Ec__Iterator11() { fDmg = fDmg, mon = mon, fDur = fDur, \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator ShowPoisonMyst()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    PageBattle.\u003CShowPoisonMyst\u003Ec__Iterator12 poisonMystCIterator12 = new PageBattle.\u003CShowPoisonMyst\u003Ec__Iterator12();
    return (IEnumerator) poisonMystCIterator12;
  }

  [DebuggerHidden]
  private IEnumerator ThrowBoneParty(Monster mon, int nNum, float fDmg)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CThrowBoneParty\u003Ec__Iterator13() { nNum = nNum, mon = mon, fDmg = fDmg, \u0024this = this };
  }

  public void SetAlarm(string strTitle, string strSub, float fFadeIn, float fShow, float fFadeOut)
  {
    this.textAlarmTitle.text = strTitle;
    this.textAlarmSub.text = strSub;
    if (this.crAlarm != null)
      this.StopCoroutine(this.crAlarm);
    this.crAlarm = this.StartCoroutine(this.ShowAlarm(this.cgAlarm, fFadeIn, fShow, fFadeOut));
  }

  public void SetMutationAlarm(string strTitle, string strSub, float fFadeIn, float fShow, float fFadeOut)
  {
    this.textMutAlarmTitle.text = strTitle;
    this.textMutAlarmSub.text = strSub;
    this.StartCoroutine(this.ShowAlarm(this.cgMutationAlarm, fFadeIn, fShow, fFadeOut));
  }

  public void SetWaveAlarm(string strWave, float fFadeIn, float fShow, float fFadeOut)
  {
    this.texWaveAlarm.text = strWave;
    this.StartCoroutine(this.ShowAlarm(this.cgWaveAlarm, fFadeIn, fShow, fFadeOut));
  }

  [DebuggerHidden]
  private IEnumerator ShowBalanceGuage()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CShowBalanceGuage\u003Ec__Iterator14() { \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator ShowAlarm(CanvasGroup cg, float fFadeIn, float fShow, float fFadeOut)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CShowAlarm\u003Ec__Iterator15() { cg = cg, fFadeIn = fFadeIn, fShow = fShow, fFadeOut = fFadeOut };
  }

  [DebuggerHidden]
  private IEnumerator HighSlash(bool bAll, int nPos, int nMax, float fDmg)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CHighSlash\u003Ec__Iterator16() { nPos = nPos, nMax = nMax, bAll = bAll, fDmg = fDmg, \u0024this = this };
  }

  [DebuggerHidden]
  private IEnumerator StartFireExplosion(Monster mon, int nMax, float fPlus)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new PageBattle.\u003CStartFireExplosion\u003Ec__Iterator17() { fPlus = fPlus, nMax = nMax, mon = mon, \u0024this = this };
  }

  private Enemy GetRandomEnemy(Enemy em)
  {
    return this.GetRandomEnemy(new List<Enemy>() { em });
  }

  private Enemy GetRandomEnemy(List<Enemy> listAlready)
  {
    List<Enemy> enemyList = new List<Enemy>();
    enemyList.Clear();
    for (int index = 0; index < this.listEnemy.Count; ++index)
    {
      if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead && !listAlready.Contains(this.listEnemy[index]))
        enemyList.Add(this.listEnemy[index]);
    }
    if (enemyList.Count == 0)
      return (Enemy) null;
    return enemyList[Random.Range(0, enemyList.Count)];
  }

  public static bool CheckMutation(MutateType eType)
  {
    return PageBattle.listMutation.Contains(eType);
  }

  public static float GetMutation1(MutateType eType)
  {
    if (!PageBattle.dictMutation1.ContainsKey(eType))
      return 0.0f;
    return (float) PageBattle.dictMutation1[eType];
  }

  public static float GetMutation2(MutateType eType)
  {
    if (!PageBattle.dictMutation2.ContainsKey(eType))
      return 0.0f;
    return (float) PageBattle.dictMutation2[eType];
  }

  public void OnGoldReach(BattleCoinElt elt)
  {
    elt.gameObject.SetActive(false);
    this.OnItemReach(elt.eType, elt.fEarnGold);
    this.listCoinAlive.Remove(elt);
    this.listCoinDead.Add(elt);
  }

  public void OnItemReach(BattleCoinElt.Type eType, float fGold = -1f)
  {
    if (eType != BattleCoinElt.Type.eGold)
    {
      if (eType != BattleCoinElt.Type.eItem)
      {
        if (eType != BattleCoinElt.Type.eHP)
          return;
        ++this.nHarvestNum;
        this.DungeonHeal((float) (1.0 * (1.0 + (double) Info.GetAccModFac(ModType.eHarvestHeal) * 0.00999999977648258)), false);
        if (!Info.option.bOptimize)
        {
          this.psHp.Play(false);
          UIMgr.PlaySound("ItemGet", false);
        }
        this.textHP.rectTransform.parent.localScale = Vector3.one * 1.3f;
      }
      else
      {
        ++this.nTargetItemCnt;
        this.textItem.text = "x" + this.nTargetItemCnt.ToString();
        if (!Info.option.bOptimize)
        {
          this.psItem.Play(false);
          UIMgr.PlaySound("ItemGet", false);
        }
        this.textItem.rectTransform.localScale = Vector3.one * 1.3f;
      }
    }
    else
    {
      this.fTargetGold += fGold;
      if (!Info.option.bOptimize)
      {
        this.psGold.Play(false);
        UIMgr.PlaySound("Coin" + (object) Random.Range(0, 3), false);
      }
      this.textGold.rectTransform.localScale = Vector3.one * 1.3f;
    }
  }

  public void OnPause()
  {
    if ((bool) this.bGameOver || (bool) this.bBattleOver)
      return;
    UIMgr.CallOption();
    Time.timeScale = 0.0f;
    for (int index = 0; index < this.listEnemy.Count; ++index)
      this.listEnemy[index].OnSleep();
  }

  public void OnToggleAutoBattleStart()
  {
    Info.option.bAutoBattleStart = !Info.option.bAutoBattleStart;
    this.goAutoBattleStartOn.SetActive(Info.option.bAutoBattleStart);
    SaveManager.SaveOption();
  }

  public void OnResume()
  {
    this.asLaser.volume = !Info.option.bMuteSound ? Info.option.fSound * 0.6f : 0.0f;
    Time.timeScale = (float) ((!Info.option.bDoubleSpeed ? 1.0 : 2.0) * (1.0 + (double) Info.GetElementalFac(ElementalID.eFireHaste, 0) * 0.00999999977648258 + (double) Info.GetPartySkillFac(SkillKey.eHaste) * 0.00999999977648258));
    Time.fixedDeltaTime = !Info.option.bOptimize ? 0.02f : 0.033f;
    this.goAutoBattleStartOn.SetActive(Info.option.bAutoBattleStart);
    for (int index = 0; index < this.listEnemy.Count; ++index)
      this.listEnemy[index].OnWakeUp();
    this.listMonster[(int) Info.currentSave.arrPlayerMon[0].byBatch].SetNpcAtkBonus(Info.option.bAutoBattle);
    this.goLeftSkill.SetActive(Info.option.bLeftSpecial);
    this.goBotSkill.SetActive(!Info.option.bLeftSpecial);
  }

  public void OnHealerActive(Enemy em)
  {
    for (int index = 0; index < this.listEnemy.Count; ++index)
    {
      if (this.listEnemy[index].gameObject.activeInHierarchy && !this.listEnemy[index].isDead && !((Object) this.listEnemy[index] == (Object) em) && (this.eTrial != MutateType.eGuardian || em.bBoss))
      {
        float num = PageBattle.GetMutation1(MutateType.eHealer) * 0.01f * (float) this.listEnemy[index].maxhp;
        this.listEnemy[index].SetDamage(-(double) num);
      }
    }
  }

  public void OnCorruptActive(Enemy em)
  {
    if ((bool) this.bBattleOver)
      return;
    bool isInvincible = this.isInvincible;
    if (!this.isInvincible)
      this.DungeonDamage(PageBattle.GetMutation1(MutateType.eDrain));
    this.vHitPos.x = -240f;
    this.vHitPos.y = (float) Random.Range(160, -130);
    ParticleMgr.Play("HitGreen", this.vHitPos);
    this.ShowText(this.vHitPos, !isInvincible ? PageBattle.GetMutation1(MutateType.eDrain).ToString("N0") : "Immune", Color.red, 0.0f);
  }

  public void OnForceReloadActive(Enemy em)
  {
    if ((bool) this.bBattleOver)
      return;
    this.SetFlash(0.0f, 0.0f, 0.0f, 0.4f, 2f);
    for (int index = 0; index < this.listMonster.Count; ++index)
    {
      if (this.listMonster[index].gameObject.activeInHierarchy)
        this.listMonster[index].nAmmo = (ObscuredInt) 0;
    }
    this.RefreshAmmo();
  }

  public void OnClockOver()
  {
    if ((bool) this.bBattleOver)
      return;
    CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 2, PageBattle.vShakePos, Vector3.zero, 1f, 90f, 0.9f, 0.0f, true);
    PageBattle.obj.SetFlash(1f, 0.0f, 0.0f, 0.4f, 2f);
    for (int index = 0; index < this.listMonster.Count; ++index)
    {
      if (this.listMonster[index].gameObject.activeInHierarchy)
        this.listMonster[index].SetStun(5f);
    }
  }

  public void OnStoneClick(int nStone)
  {
    if (nStone == this.nStoneOrder[this.nNowStoneOrder])
    {
      UIMgr.PlaySound("Hire", false);
      ++this.nNowStoneOrder;
    }
    else
    {
      UIMgr.PlaySound("Negative", false);
      PageBattle.obj.SetFlash(1f, 0.0f, 0.0f, 0.4f, 2f);
      CameraShake.instance.Shake(CameraShake.ShakeType.LocalPosition, 2, PageBattle.vShakePos, Vector3.zero, 1f, 90f, 0.9f, 0.0f, true);
      this.nNowStoneOrder = 0;
    }
    this.RefreshStone();
  }

  private void RefreshStone()
  {
    for (int index = 0; index < 6; ++index)
      this.arrStoneActive[this.nStoneOrder[index]].SetActive(index < this.nNowStoneOrder);
    if (this.nNowStoneOrder < 6)
      return;
    this.goStone.SetActive(false);
    if (this.emTrialBoss.Length <= 0)
      return;
    this.emTrialBoss[0].SetInvincible(-600000f);
  }

  public void OnMoveBalance(bool bUp)
  {
    float num = Random.Range(0.15f, 0.4f);
    if (bUp)
    {
      if ((double) this.fAddBalanceGuage > 0.0)
        this.fAddBalanceGuage += num;
      else
        this.fAddBalanceGuage = num;
    }
    else if ((double) this.fAddBalanceGuage < 0.0)
      this.fAddBalanceGuage -= num;
    else
      this.fAddBalanceGuage = -num;
  }
}
