// Decompiled with JetBrains decompiler
// Type: PopupBatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class PopupBatch : UIPage
{
  public Image[] imgMon;
  public Image[] imgDown;
  public Image[] imgUp;
  public Text textTitle;

  protected override void Awake()
  {
    base.Awake();
    this.textTitle.text = BData.GetString("UI0153");
    this.RefreshImage();
  }

  protected override void Update()
  {
    base.Update();
    if (!Input.GetKeyDown(KeyCode.Escape) || !((Object) UIMgr.focused == (Object) this))
      return;
    this.OnClose();
  }

  public void OnChangeDown(int nPos)
  {
    UIMgr.PlaySound("Character", false);
    this.ChangePos(nPos, nPos + 1);
    this.RefreshImage();
  }

  public void OnChangeUp(int nPos)
  {
    UIMgr.PlaySound("Character", false);
    this.ChangePos(nPos, nPos - 1);
    this.RefreshImage();
  }

  private void ChangePos(int nPre, int nNext)
  {
    for (int nPos = 0; nPos < Info.currentSave.arrPlayerMon.Length; ++nPos)
    {
      if (Info.GetPlayerMon(nPos) != null)
      {
        if ((int) Info.GetPlayerMon(nPos).byBatch == (int) (byte) nPre)
          Info.GetPlayerMon(nPos).byBatch = (byte) nNext;
        else if ((int) Info.GetPlayerMon(nPos).byBatch == (int) (byte) nNext)
          Info.GetPlayerMon(nPos).byBatch = (byte) nPre;
      }
    }
  }

  private void RefreshImage()
  {
    for (int index = 0; index < this.imgMon.Length; ++index)
    {
      Image image = this.imgUp[index];
      bool flag1 = false;
      this.imgMon[index].enabled = flag1;
      bool flag2 = flag1;
      this.imgDown[index].enabled = flag2;
      int num = flag2 ? 1 : 0;
      image.enabled = num != 0;
    }
    for (int nPos = 0; nPos < Info.currentSave.arrPlayerMon.Length; ++nPos)
    {
      if (Info.GetPlayerMon(nPos) != null)
      {
        PlayerMonsterData playerMon = Info.GetPlayerMon(nPos);
        MonsterData monster = BData.GetMonster((short) playerMon.sID);
        bool flag1 = (bool) playerMon.bAwaken || Info.CheckRebirth(monster.eAwaken);
        int byBatch = (int) playerMon.byBatch;
        Image image = this.imgMon[byBatch];
        bool flag2 = true;
        this.imgDown[byBatch].enabled = flag2;
        bool flag3 = flag2;
        this.imgUp[byBatch].enabled = flag3;
        int num = flag3 ? 1 : 0;
        image.enabled = num != 0;
        this.imgMon[(int) playerMon.byBatch].sprite = RSMgr.GetSprite(!flag1 ? monster.strSprite : monster.strSpriteAwk);
      }
    }
  }

  public void OnClose()
  {
    UIMgr.RemoveTop();
  }
}
