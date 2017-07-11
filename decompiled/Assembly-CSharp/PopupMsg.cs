// Decompiled with JetBrains decompiler
// Type: PopupMsg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMsg : UIPage
{
  private string strCmd = string.Empty;
  public Text textMsg;
  public GameObject goConfirm;
  public GameObject goYes;
  public GameObject goNo;
  public GameObject goClose;
  public RectTransform rtPanel;

  public void SetMsg(string strMsg, bool bConfirm = true, bool bClose = false, string cmd = "")
  {
    this.goConfirm.SetActive(bConfirm);
    this.goYes.SetActive(false);
    this.goNo.SetActive(false);
    this.goClose.SetActive(bClose);
    this.textMsg.text = strMsg;
    this.rtPanel.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.textMsg.preferredHeight + 96f);
    this.strCmd = cmd;
  }

  public void SetYesNo(string cmd, string strMsg, bool canClose = false)
  {
    this.strCmd = cmd;
    this.goYes.SetActive(true);
    this.goNo.SetActive(true);
    this.goClose.SetActive(canClose);
    this.goConfirm.SetActive(false);
    this.textMsg.text = strMsg;
    this.rtPanel.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.textMsg.preferredHeight + 96f);
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    if (this.goClose.activeInHierarchy)
      this.Close();
    else if (this.goNo.activeInHierarchy)
      this.ClickNo();
    else
      this.ClickYes();
  }

  public void ClickYes()
  {
    UIMgr.PlaySound("MainButton", false);
    string strCmd = this.strCmd;
    if (strCmd != null)
    {
      // ISSUE: reference to a compiler-generated field
      if (PopupMsg.\u003C\u003Ef__switch\u0024map0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        PopupMsg.\u003C\u003Ef__switch\u0024map0 = new Dictionary<string, int>(25)
        {
          {
            "InitPromote",
            0
          },
          {
            "InitTrait",
            1
          },
          {
            "InitHellStone",
            2
          },
          {
            "ElementalSelect",
            3
          },
          {
            "100DayAgo",
            4
          },
          {
            "RealMod",
            5
          },
          {
            "LowDifficult",
            6
          },
          {
            "AskInherit",
            7
          },
          {
            "overwrite",
            8
          },
          {
            "WhyNotResearch",
            9
          },
          {
            "RepairPart",
            10
          },
          {
            "ToggleItemManage",
            11
          },
          {
            "Quit",
            12
          },
          {
            "BattleQuit",
            13
          },
          {
            "LobbyQuit",
            14
          },
          {
            "LobbySave",
            15
          },
          {
            "Dismiss",
            16
          },
          {
            "SellAll",
            17
          },
          {
            "SellAuto",
            18
          },
          {
            "Review",
            19
          },
          {
            "ResearchComplete",
            20
          },
          {
            "LoginGoogle",
            21
          },
          {
            "CloudSave",
            22
          },
          {
            "CloudLoad",
            23
          },
          {
            "TrialWarning",
            24
          }
        };
      }
      int num;
      // ISSUE: reference to a compiler-generated field
      if (PopupMsg.\u003C\u003Ef__switch\u0024map0.TryGetValue(strCmd, out num))
      {
        switch (num)
        {
          case 0:
            UIMgr.RemoveTop();
            PopupPromote.obj.OnRealInit();
            return;
          case 1:
            UIMgr.RemoveTop();
            PopupElementalTrait.obj.OnRealInit();
            return;
          case 2:
            UIMgr.RemoveTop();
            PopupHellShop.obj.OnRealInit();
            return;
          case 3:
            UIMgr.RemoveTop();
            PopupElementalSelect.obj.OnRealSelect();
            return;
          case 4:
            UIMgr.RemoveTop();
            UIMgr.AddPage("PopupRebirthDiff");
            return;
          case 5:
            UIMgr.RemoveTop();
            if (!(bool) ((Object) PopupWeaponSelect.obj))
              return;
            PopupWeaponSelect.obj.OnRealMod();
            return;
          case 6:
            if (!(bool) ((Object) PopupGameOver.obj))
              return;
            PopupGameOver.obj.OnLowRestart();
            return;
          case 7:
            if (!(bool) ((Object) PopupWeaponSelect.obj))
              return;
            PopupWeaponSelect.obj.OnRealRebirth();
            return;
          case 8:
            PageMain.obj.OnClick(3);
            UIMgr.RemoveTop();
            return;
          case 9:
            UIMgr.RemoveTop();
            PageLobby.obj.MoveToBattle();
            return;
          case 10:
            PageLobby.obj.OnDungeonRepairPart();
            UIMgr.RemoveTop();
            return;
          case 11:
            if ((bool) ((Object) PopupOption.obj))
              PopupOption.obj.ToggleAutoItemManagement();
            UIMgr.RemoveTop();
            return;
          case 12:
            this.StopAllCoroutines();
            Application.Quit();
            return;
          case 13:
            Info.bTempQuitBattle = true;
            SavedData savedData = SaveManager.Load((byte) Info.byCurrentSaveSlot);
            if (savedData != null)
            {
              Info.currentSave = savedData;
              if (Info.eBattle == BattleType.eEndless)
              {
                if ((int) Info.currentSave.nDay < 1000)
                  Info.currentSave.bChallengeEndless = true;
                if ((int) Info.wave.nCurrentWave > (int) Info.currentSave.nMaxEndless)
                  Info.currentSave.nMaxEndless = Info.wave.nCurrentWave;
              }
              if ((int) Info.currentSave.nDay == 1)
              {
                UIMgr.LoadLevel("Main", 1f, 1f, Color.black);
                return;
              }
              UIMgr.LoadLevel("Lobby", 1f, 1f, Color.black);
              return;
            }
            UIMgr.LoadLevel("Main", 1f, 1f, Color.black);
            return;
          case 14:
            UIMgr.LoadLevel("Main", 1f, 1f, Color.black);
            return;
          case 15:
            SavedData currentSave = Info.currentSave;
            string strSummary = currentSave.strSummary;
            string str1 = "\n\n";
            string str2 = BData.GetString("UI0083");
            string oldValue = "[1]";
            num = (int) (byte) Info.byCurrentSaveSlot + 1;
            string newValue = num.ToString("0");
            string str3 = str2.Replace(oldValue, newValue);
            string str4 = strSummary + str1 + str3;
            currentSave.strSummary = str4;
            SaveManager.Save();
            PageLobby.obj.RefreshAction();
            UIMgr.RemoveTop();
            return;
          case 16:
            UIMgr.PlaySound("Negative", false);
            Info.DismissMonster((int) Info.nSelectedMonster);
            Info.RefreshAccMod();
            if ((bool) ((Object) PageLobby.obj))
            {
              PageLobby.obj.RefreshCharTab();
              PageLobby.obj.RefreshCharUnitInfo(0);
              PageLobby.obj.RefreshHighlightCharTab();
            }
            UIMgr.RemoveTop();
            return;
          case 17:
            if ((bool) ((Object) PopupWeaponSelect.obj))
              PopupWeaponSelect.obj.OnSellAll();
            UIMgr.RemoveTop();
            return;
          case 18:
            if ((bool) ((Object) PopupWeaponSelect.obj))
              PopupWeaponSelect.obj.OnSellAuto();
            UIMgr.RemoveTop();
            return;
          case 19:
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.GameCoaster.ProtectDungeon");
            UIMgr.RemoveTop();
            return;
          case 20:
            if ((bool) ((Object) PageLobby.obj))
              PageLobby.obj.OnMoveMenu(6);
            UIMgr.RemoveTop();
            return;
          case 21:
            if (!GPGSMgr.single.bInit)
              GPGSMgr.single.InitializeGPGS();
            else
              GPGSMgr.single.LoginGPGS();
            UIMgr.RemoveTop();
            return;
          case 22:
            UIMgr.RemoveTop();
            GPGSMgr.single.ShowCloudData(true);
            return;
          case 23:
            UIMgr.RemoveTop();
            GPGSMgr.single.ShowCloudData(false);
            return;
          case 24:
            UIMgr.RemoveTop();
            UIMgr.LoadLevel("Main", 0.5f, 0.5f, Color.black);
            return;
        }
      }
    }
    UIMgr.RemoveTop();
  }

  public void ClickNo()
  {
    UIMgr.PlaySound("Negative", false);
    string strCmd = this.strCmd;
    if (strCmd != null)
    {
      if (!(strCmd == string.Empty))
      {
        if (!(strCmd == "WhyNotResearch"))
        {
          if (strCmd == "overwrite")
          {
            PageMain.obj.OnClick(0);
            UIMgr.RemoveTop();
            return;
          }
        }
        else
        {
          UIMgr.RemoveTop();
          PageLobby.obj.OnMoveMenu(6);
          return;
        }
      }
      else
      {
        UIMgr.RemoveTop();
        return;
      }
    }
    UIMgr.RemoveTop();
  }

  public void Close()
  {
    UIMgr.RemoveTop();
  }
}
