// Decompiled with JetBrains decompiler
// Type: UIMgr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMgr : UIPage
{
  private static bool loadPackage = false;
  public static UIMgr single = (UIMgr) null;
  public static List<UIPage> listPage = new List<UIPage>();
  public static Dictionary<string, float> dictPlaylist = new Dictionary<string, float>();
  public static Camera uiCamera;
  public static UIPage focused;
  public Camera _uiCamera;
  public static AudioSource asFX;
  public static AudioSource asMusic;

  public static PopupMsg popupMsg
  {
    get
    {
      return UIMgr.AddPage("PopupMsg") as PopupMsg;
    }
  }

  protected override void Awake()
  {
    UIMgr.single = this;
    UIMgr.focused = (UIPage) this;
    this.registered = true;
    Screen.sleepTimeout = -1;
    UIMgr.uiCamera = this._uiCamera;
    UIMgr.listPage.Clear();
    UIMgr.asFX = this.GetComponent<AudioSource>();
    base.Awake();
    Time.timeScale = 1f;
    if (UIMgr.loadPackage)
      return;
    SceneManager.LoadSceneAsync("ResourcePack", LoadSceneMode.Additive);
    SceneManager.LoadSceneAsync("DataPack", LoadSceneMode.Additive);
    SceneManager.LoadSceneAsync("SavePack", LoadSceneMode.Additive);
    SceneManager.LoadSceneAsync("IAPPack", LoadSceneMode.Additive);
    UIMgr.loadPackage = true;
  }

  public static UIPage AddPage(string strName)
  {
    UIPage component = Object.Instantiate<GameObject>(RSMgr.GetPrefab(strName)).GetComponent<UIPage>();
    if ((Object) component == (Object) null)
      return (UIPage) null;
    UIMgr.Register(component);
    return component;
  }

  protected override void Update()
  {
    base.Update();
  }

  private void OnApplicationPause(bool pauseStatus)
  {
  }

  public virtual void Resume()
  {
  }

  public static void Register(UIPage page)
  {
    page.registered = true;
    for (int index = UIMgr.listPage.Count - 1; index >= -1; --index)
    {
      UIPage uiPage = index >= 0 ? UIMgr.listPage[index] : (UIPage) UIMgr.single;
      if (uiPage.enabled)
      {
        uiPage.GetComponent<GraphicRaycaster>().enabled = false;
        if (index > -1)
          uiPage.enabled = false;
      }
      else
        break;
    }
    UIMgr.focused = page;
    UIMgr.focused.GetComponent<Canvas>().sortingLayerID = UIMgr.single.GetComponent<Canvas>().sortingLayerID;
    UIMgr.focused.GetComponent<Canvas>().sortingOrder = UIMgr.listPage.Count * 10 + 10;
    UIMgr.listPage.Add(page);
  }

  public static void RemoveTop()
  {
    UIPage focused = UIMgr.focused;
    if ((Object) focused == (Object) null)
      return;
    UIMgr.listPage.Remove(focused);
    Object.Destroy((Object) focused.gameObject);
    int count = UIMgr.listPage.Count;
    UIMgr.focused = count <= 0 ? (UIPage) UIMgr.single : UIMgr.listPage[count - 1];
    for (int index = UIMgr.listPage.Count - 1; index > -2; --index)
    {
      UIPage uiPage = index >= 0 ? UIMgr.listPage[index] : (UIPage) UIMgr.single;
      uiPage.GetComponent<GraphicRaycaster>().enabled = (Object) uiPage == (Object) UIMgr.focused;
      if (!uiPage.enabled)
      {
        if (index > -1)
          uiPage.enabled = true;
      }
      else
        break;
    }
    UIMgr.focused.Focused();
  }

  public static void Shake(Vector3 pos, float fTime)
  {
  }

  public void ShowAd(Ads eAd)
  {
    bool flag = false;
    if (Info.eAds != Ads.eNone || flag)
      return;
    Info.eAds = eAd;
    this.OnAdsComplete();
  }

  private void OnAdsComplete()
  {
    if (Info.eAds == Ads.eNone)
      return;
    Info.eAds = Ads.eNone;
  }

  private void OnAdsSkipped()
  {
    this.OnAdsFailed();
  }

  private void OnAdsFailed()
  {
    Info.eAds = Ads.eNone;
  }

  public static void ShowMsg(string strMsg)
  {
  }

  public static PopupMsg GetMsg()
  {
    return UIMgr.AddPage("PopupMsg") as PopupMsg;
  }

  public static void ShowCashShop()
  {
    UIMgr.AddPage("PopupCash");
  }

  public static void CallOption()
  {
    UIMgr.AddPage("PopupOption");
  }

  public static void NotEnoughGold()
  {
    UIMgr.OnErrorPopup("UI0054");
  }

  public static void NotEnoughStone()
  {
    UIMgr.OnErrorPopup("UI0174");
  }

  public static void NotEnoughRuby()
  {
    UIMgr.OnErrorPopup("UI0280");
  }

  public static void NotEnoughHellStone()
  {
    UIMgr.OnErrorPopup("UI0341");
  }

  public static void NotEnoughMedal()
  {
    UIMgr.OnErrorPopup("UI0240");
  }

  public static void OnErrorPopup(string strMsg)
  {
    UIMgr.PlaySound("Negative", false);
    UIMgr.popupMsg.SetMsg(BData.GetString(strMsg), true, false, string.Empty);
  }

  public static void PlaySound(string strName, bool bPass = false)
  {
    if (Info.option.bMuteSound)
      return;
    if (!UIMgr.dictPlaylist.ContainsKey(strName))
      UIMgr.dictPlaylist.Add(strName, 0.0f);
    if (!bPass && (Object) PageBattle.obj != (Object) null && (double) UIMgr.dictPlaylist[strName] + 0.100000001490116 > (double) Time.timeSinceLevelLoad)
      return;
    UIMgr.dictPlaylist[strName] = Time.timeSinceLevelLoad;
    UIMgr.asFX.PlayOneShot(RSMgr.GetAudio(strName), Info.option.fSound);
  }

  public static void PlayMusic()
  {
    UIMgr.asMusic.volume = !Info.option.bMuteMusic ? Info.option.fMusic : 0.0f;
    UIMgr.asMusic.Play();
  }

  public static void PlayMusic(string strName)
  {
    UIMgr.asMusic.loop = true;
    UIMgr.asMusic.clip = RSMgr.GetAudio(strName);
    UIMgr.PlayMusic();
  }

  public static void StopMusic()
  {
    UIMgr.asMusic.Stop();
  }

  public static void LoadLevel(string strLevel, float fFadeIn, float fFadeOut, Color cl)
  {
    UIMgr.AddPage("PopupChange");
    PopupChange.obj.SetFlash(strLevel, cl, fFadeIn, fFadeOut);
  }

  public static void TooltipShow(string strMsg)
  {
    if ((Object) TooltipWindow.obj == (Object) null)
      Object.Instantiate<GameObject>(RSMgr.GetPrefab("TooltipWindow"));
    TooltipWindow.obj.gameObject.SetActive(true);
    TooltipWindow.obj.textMsg.font = Info.option.nLanguage != 2 ? (Info.option.nLanguage == 5 || Info.option.nLanguage == 6 ? RSMgr.GetFont("Zpix") : RSMgr.GetFont("DungGeunMo")) : RSMgr.GetFont("hobo");
    TooltipWindow.obj.textMsg.text = strMsg;
    TooltipWindow.obj.rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, TooltipWindow.obj.textMsg.preferredHeight + 96f);
    TooltipWindow.obj.bInit = true;
  }

  public static void TooltipHide()
  {
  }
}
