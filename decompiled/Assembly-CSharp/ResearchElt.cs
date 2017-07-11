// Decompiled with JetBrains decompiler
// Type: ResearchElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using UnityEngine;
using UnityEngine.UI;

public class ResearchElt : MonoBehaviour
{
  private static Color clLearn = new Color(0.1f, 0.1f, 0.1f);
  public Image imgIcon;
  public GameObject goProgress;
  public GameObject goHighlight;
  public GameObject goDone;
  public ResearchID eID;

  public void Refresh()
  {
    ResearchData research = BData.GetResearch(this.eID);
    this.imgIcon.sprite = RSMgr.GetSprite(research.strIcon);
    bool flag1 = Info.currentSave.listResearch.Contains(this.eID);
    bool flag2 = true;
    for (int index = 0; index < research.listPre.Count; ++index)
    {
      if (!Info.currentSave.listResearch.Contains(research.listPre[index]))
        flag2 = false;
    }
    this.goDone.SetActive(flag1);
    this.imgIcon.color = !flag1 ? (flag2 ? Color.white : ResearchElt.clLearn) : Color.gray;
  }

  public void SetHighlight(bool bEnable)
  {
    this.goHighlight.SetActive(bEnable);
  }

  public void SetProgress(bool bEnable)
  {
    this.goProgress.SetActive(bEnable);
  }

  public void OnClick()
  {
    UIMgr.PlaySound("Character", false);
    PageLobby.obj.OnResearchSelected(this);
  }
}
