// Decompiled with JetBrains decompiler
// Type: PopupTrialBrief
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class PopupTrialBrief : UIPage
{
  public int nMaxFloor = 30;
  public Text textTitle;
  public Text textName;
  public Text textDescTop;
  public Text textDesc;
  public Text textDropTop;
  public Text textDrop;
  public Text textStart;
  public Text textDiffEasy;
  public Text textDiffNormal;
  public Text textDiffHard;
  public Text textDiffInsane;
  public Button btnStart;
  public GameObject goLeft;
  public GameObject goRight;
  public GameObject[] goDiffChecker;
  public GameObject[] goMonster;
  private int nFloor;

  protected override void Awake()
  {
    base.Awake();
    this.nFloor = Info.GetTrialClear(Info.currentSave.uRebirthID) + 1;
    this.goRight.SetActive(this.nFloor < this.nMaxFloor);
    this.goLeft.SetActive(this.nFloor > 1);
    this.textDescTop.text = BData.GetString("UI0215");
    this.textDropTop.text = BData.GetString("UI0216");
    this.textDiffEasy.text = BData.GetString("UI0034").Replace("[1]", string.Empty);
    this.textDiffNormal.text = BData.GetString("UI0033").Replace("[1]", string.Empty);
    this.textDiffHard.text = BData.GetString("UI0035").Replace("[1]", string.Empty);
    this.textDiffInsane.text = BData.GetString("UI0036").Replace("[1]", string.Empty);
    this.nFloor = 0;
    this.MoveTrial(Info.GetTrialClear(Info.currentSave.uRebirthID) + 1);
  }

  private void RefreshDetail()
  {
    TrialData trial = BData.GetTrial(this.nFloor);
    MutationData mutate = BData.GetMutate(trial.eID);
    Mathf.Max((int) Info.currentSave.nDay, trial.nDay);
    Mathf.RoundToInt((float) trial.nDay * Info.fDiffTrialDiffFac[(int) Info.nDiffTrial]);
    int num1;
    int num2;
    if ((double) Info.fDiffTrialDiffFac[(int) Info.nDiffTrial] > 1.0)
    {
      num1 = Mathf.RoundToInt(Mathf.Max((float) trial.nDay * Info.fDiffTrialDiffFac[(int) Info.nDiffTrial], (float) (int) Info.currentSave.nDay * Info.fDiffTrialDayFac)) + Info.nDiffTrialDiffDay[(int) Info.nDiffTrial];
      num2 = Mathf.RoundToInt((float) trial.nDay * Info.fDiffTrialDiffFac[(int) Info.nDiffTrial]) + Info.nDiffTrialDiffDay[(int) Info.nDiffTrial];
    }
    else
    {
      num1 = Mathf.RoundToInt(Mathf.Max((float) trial.nDay, (float) (int) Info.currentSave.nDay * Info.fDiffTrialDayFac) * Info.fDiffTrialDiffFac[(int) Info.nDiffTrial]);
      num2 = Mathf.RoundToInt((float) trial.nDay * Info.fDiffTrialDiffFac[(int) Info.nDiffTrial]);
    }
    bool flag = (int) Info.nDiffTrial >= 2 && (int) Info.currentSave.nDay <= num2;
    this.textName.text = BData.GetString(mutate.strName);
    this.textDesc.text = "- " + BData.GetString(mutate.strDesc);
    this.textStart.text = Info.GetTrialClear(Info.currentSave.uRebirthID) < this.nFloor ? BData.GetString("UI0140") : BData.GetString("UI0222");
    this.btnStart.interactable = Info.GetTrialClear(Info.currentSave.uRebirthID) < this.nFloor;
    int num3 = Mathf.RoundToInt((float) (trial.dictMedal[(int) Info.currentSave.nDiff] * (!flag ? 1 : 2)) * Info.fDiffTrialReward[(int) Info.nDiffTrial]);
    int num4 = Mathf.RoundToInt((float) (Info.GetStone(100 + trial.nDay, (int) Info.currentSave.nDiff) / 100L * (!flag ? 1L : 2L)) * Info.fDiffTrialReward[(int) Info.nDiffTrial]);
    MutateType eId = trial.eID;
    switch (eId)
    {
      case MutateType.eGoliat:
        Text textDesc1 = this.textDesc;
        string str1 = textDesc1.text + "\n- " + Info.GetMutationDescCustom(MutateType.eGiant, 100f, 0.0f);
        textDesc1.text = str1;
        break;
      case MutateType.eHusk:
        Text textDesc2 = this.textDesc;
        string str2 = textDesc2.text + "\n- " + Info.GetMutationDescCustom(MutateType.eDivine, (float) (10 + num1 / 10), 0.0f);
        textDesc2.text = str2;
        Text textDesc3 = this.textDesc;
        string str3 = textDesc3.text + "\n- " + Info.GetMutationDescCustom(MutateType.eBerserk, 20f, 0.0f);
        textDesc3.text = str3;
        Text textDesc4 = this.textDesc;
        string str4 = textDesc4.text + "\n- " + Info.GetMutationDescCustom(MutateType.eSwift, 50f, 0.0f);
        textDesc4.text = str4;
        break;
      case MutateType.eReflection:
        Text textDesc5 = this.textDesc;
        string str5 = textDesc5.text + "\n- " + Info.GetMutationDesc(MutateType.eSoloPlay, Mathf.Max((int) Info.currentSave.nDay, trial.nDay));
        textDesc5.text = str5;
        break;
      case MutateType.eLastChance:
        Text textDesc6 = this.textDesc;
        string str6 = textDesc6.text + "\n- " + Info.GetMutationDescCustom(MutateType.eWaste, 100f, 0.0f);
        textDesc6.text = str6;
        Text textDesc7 = this.textDesc;
        string str7 = textDesc7.text + "\n- " + Info.GetMutationDescCustom(MutateType.eNoAmmo, 300f, 0.0f);
        textDesc7.text = str7;
        Text textDesc8 = this.textDesc;
        string str8 = textDesc8.text + "\n- " + Info.GetMutationDescCustom(MutateType.eReload, 10f, 5f);
        textDesc8.text = str8;
        break;
      case MutateType.eTanker:
        Text textDesc9 = this.textDesc;
        string str9 = textDesc9.text + "\n- " + Info.GetMutationDescCustom(MutateType.eInvincible, 10f, 5f);
        textDesc9.text = str9;
        Text textDesc10 = this.textDesc;
        string str10 = textDesc10.text + "\n- " + Info.GetMutationDescCustom(MutateType.eTaunt, 10f, 5f);
        textDesc10.text = str10;
        Text textDesc11 = this.textDesc;
        string str11 = textDesc11.text + "\n- " + Info.GetMutationDescCustom(MutateType.eAbsorb, 100f, 0.0f);
        textDesc11.text = str11;
        Text textDesc12 = this.textDesc;
        string str12 = textDesc12.text + "\n- " + Info.GetMutationDescCustom(MutateType.eBombard, 100f, 0.0f);
        textDesc12.text = str12;
        break;
      case MutateType.eFitness:
        Text textDesc13 = this.textDesc;
        string str13 = textDesc13.text + "\n- " + Info.GetMutationDescCustom(MutateType.eGiant, 100f, 0.0f);
        textDesc13.text = str13;
        Text textDesc14 = this.textDesc;
        string str14 = textDesc14.text + "\n- " + Info.GetMutationDesc(MutateType.eDrain, Mathf.Max((int) Info.currentSave.nDay, trial.nDay));
        textDesc14.text = str14;
        break;
      case MutateType.eGemini:
        Text textDesc15 = this.textDesc;
        string str15 = textDesc15.text + "\n- " + Info.GetMutationDesc(MutateType.eSoloPlay, Mathf.Max((int) Info.currentSave.nDay, trial.nDay));
        textDesc15.text = str15;
        break;
      default:
        switch (eId - 58)
        {
          case MutateType.eBerserk:
            Text textDesc16 = this.textDesc;
            string str16 = textDesc16.text + "\n- " + Info.GetMutationDescCustom(MutateType.eBarrier, 100f, 0.0f);
            textDesc16.text = str16;
            break;
          case MutateType.eRedMyst:
            Text textDesc17 = this.textDesc;
            string str17 = textDesc17.text + "\n- " + Info.GetMutationDescCustom(MutateType.eBlock, 100f, 0.0f);
            textDesc17.text = str17;
            break;
          case MutateType.eLifeBloom:
            Text textDesc18 = this.textDesc;
            string str18 = textDesc18.text + "\n- " + Info.GetMutationDescCustom(MutateType.eWeakPoint, 100f, 0.0f);
            textDesc18.text = str18;
            Text textDesc19 = this.textDesc;
            string str19 = textDesc19.text + "\n- " + Info.GetMutationDescCustom(MutateType.eCriDown, 100f, 0.0f);
            textDesc19.text = str19;
            break;
          default:
            if (eId != MutateType.eIronKnights)
            {
              if (eId == MutateType.eAntiMagic)
              {
                Text textDesc20 = this.textDesc;
                string str20 = textDesc20.text + "\n- " + Info.GetMutationDescCustom(MutateType.eBarrier, 66f, 0.0f);
                textDesc20.text = str20;
                break;
              }
              break;
            }
            Text textDesc21 = this.textDesc;
            string str21 = textDesc21.text + "\n- " + Info.GetMutationDescCustom(MutateType.eBlock, 66f, 0.0f);
            textDesc21.text = str21;
            break;
        }
    }
    for (int index = 0; index < this.goDiffChecker.Length; ++index)
      this.goDiffChecker[index].SetActive(index == (int) Info.nDiffTrial);
    string str22 = !flag ? "<Color='white'>" : "<Color='#00EB2EFF'>";
    string str23 = "</color>";
    this.textDrop.text = "- " + BData.GetString("UI0217") + " x " + str22 + (object) num3 + str23 + "\n- " + BData.GetString("UI0227") + " x " + str22 + (object) num4 + str23 + "\n- (" + str22 + (trial.fDropRate * (!flag ? 1f : 2f) * Info.fDiffTrialReward[(int) Info.nDiffTrial]).ToString("N0") + str23 + "%)" + (!trial.bDropRing ? BData.GetString("UI0218") : BData.GetString("UI0283")).Replace("[1]", Info.GetGradeString((byte) trial.nDropMin, false)).Replace("[2]", Info.GetGradeString((byte) trial.nDropMax, false)) + "\n" + ((int) Info.nDiffTrial < 2 ? string.Empty : "- " + BData.GetString("UI0219").Replace("[1]", num2.ToString()));
  }

  public void BattleStart()
  {
    if (Info.GetTrialClear(Info.currentSave.uRebirthID) >= this.nMaxFloor)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0220"), true, false, string.Empty);
    }
    else if (Info.GetTrialClear(Info.currentSave.uRebirthID) + 1 < this.nFloor)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0221"), true, false, string.Empty);
    }
    else if (Info.currentSave.bChallengeTrial)
    {
      UIMgr.PlaySound("Negative", false);
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0224").Replace("[1]", BData.GetString("UI0214")), true, false, string.Empty);
    }
    else
    {
      Info.eBattle = BattleType.eTrial;
      UIMgr.PlaySound("BattleBegin", false);
      UIMgr.LoadLevel("Battle", 2f, 1f, Color.black);
    }
  }

  public void MoveTrial(int n)
  {
    UIMgr.PlaySound("Character", false);
    this.nFloor = Mathf.Clamp(this.nFloor + n, 1, this.nMaxFloor);
    this.goRight.SetActive(this.nFloor < this.nMaxFloor);
    this.goLeft.SetActive(this.nFloor > 1);
    this.textTitle.text = BData.GetString("UI0214") + " " + this.nFloor.ToString() + "F";
    this.RefreshDetail();
    this.RefreshMonster(this.nFloor);
  }

  public void SelDiff(int n)
  {
    Info.nDiffTrial = (ObscuredInt) n;
    UIMgr.PlaySound("Character", false);
    this.RefreshDetail();
  }

  public void RefreshMonster(int nMon)
  {
    for (int index = 0; index < this.goMonster.Length; ++index)
      this.goMonster[index].SetActive(index == nMon - 1);
  }

  public void OnClose()
  {
    UIMgr.RemoveTop();
  }
}
