// Decompiled with JetBrains decompiler
// Type: RSMgr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections.Generic;
using UnityEngine;

public class RSMgr : MonoBehaviour
{
  public static bool created = false;
  public static bool loaded = false;
  protected static Dictionary<string, Texture> dicTexture = new Dictionary<string, Texture>();
  protected static Dictionary<string, Sprite> dicSprite = new Dictionary<string, Sprite>();
  protected static Dictionary<string, GameObject> dicPrefab = new Dictionary<string, GameObject>();
  protected static Dictionary<string, AudioClip> dicAudio = new Dictionary<string, AudioClip>();
  protected static Dictionary<string, Font> dicfont = new Dictionary<string, Font>();
  protected static Dictionary<string, RuntimeAnimatorController> dicController = new Dictionary<string, RuntimeAnimatorController>();
  public List<Texture> listTexture = new List<Texture>();
  public List<Sprite> listUnitSprite = new List<Sprite>();
  public List<Sprite> listWeaponSprite = new List<Sprite>();
  public List<Sprite> listSkillSprite = new List<Sprite>();
  public List<Sprite> listBGSprite = new List<Sprite>();
  public List<Sprite> listGUISprite = new List<Sprite>();
  public List<GameObject> listPrefab = new List<GameObject>();
  public List<GameObject> listEffect = new List<GameObject>();
  public List<AudioClip> listAudio = new List<AudioClip>();
  public List<Font> listFont = new List<Font>();
  public List<RuntimeAnimatorController> listController = new List<RuntimeAnimatorController>();
  public static RSMgr single;

  private void Awake()
  {
    if (RSMgr.created)
    {
      Object.Destroy((Object) this.gameObject);
    }
    else
    {
      RSMgr.single = this;
      RSMgr.created = true;
      foreach (Texture texture in this.listTexture)
        RSMgr.dicTexture.Add(texture.name.ToLower(), texture);
      foreach (Sprite sprite in this.listUnitSprite)
        RSMgr.dicSprite.Add(sprite.name.ToLower(), sprite);
      foreach (Sprite sprite in this.listWeaponSprite)
        RSMgr.dicSprite.Add(sprite.name.ToLower(), sprite);
      foreach (Sprite sprite in this.listSkillSprite)
        RSMgr.dicSprite.Add(sprite.name.ToLower(), sprite);
      foreach (Sprite sprite in this.listBGSprite)
        RSMgr.dicSprite.Add(sprite.name.ToLower(), sprite);
      foreach (Sprite sprite in this.listGUISprite)
        RSMgr.dicSprite.Add(sprite.name.ToLower(), sprite);
      foreach (GameObject gameObject in this.listPrefab)
        RSMgr.dicPrefab.Add(gameObject.name.ToLower(), gameObject);
      foreach (AudioClip audioClip in this.listAudio)
        RSMgr.dicAudio.Add(audioClip.name.ToLower(), audioClip);
      foreach (Font font in this.listFont)
        RSMgr.dicfont.Add(font.name.ToLower(), font);
      foreach (RuntimeAnimatorController animatorController in this.listController)
        RSMgr.dicController.Add(animatorController.name.ToLower(), animatorController);
      foreach (GameObject original in this.listEffect)
      {
        Object.Destroy((Object) Object.Instantiate<GameObject>(original));
        RSMgr.dicPrefab.Add(original.name.ToLower(), original);
      }
      RSMgr.loaded = true;
    }
  }

  private void Start()
  {
    if (!RSMgr.loaded)
      return;
    Object.Destroy((Object) this.gameObject);
  }

  public static Sprite GetSprite(string strName)
  {
    if (!RSMgr.dicSprite.ContainsKey(strName.ToLower()))
      return (Sprite) null;
    return RSMgr.dicSprite[strName.ToLower()];
  }

  public static Texture GetTexture(string strName)
  {
    if (!RSMgr.dicTexture.ContainsKey(strName.ToLower()))
      return (Texture) null;
    return RSMgr.dicTexture[strName.ToLower()];
  }

  public static GameObject GetPrefab(string strName)
  {
    if (!RSMgr.dicPrefab.ContainsKey(strName.ToLower()))
      return (GameObject) null;
    return RSMgr.dicPrefab[strName.ToLower()];
  }

  public static AudioClip GetAudio(string strName)
  {
    if (!RSMgr.dicAudio.ContainsKey(strName.ToLower()))
      return (AudioClip) null;
    return RSMgr.dicAudio[strName.ToLower()];
  }

  public static Font GetFont(string strName)
  {
    return RSMgr.dicfont[strName.ToLower()];
  }

  public static RuntimeAnimatorController GetController(string strName)
  {
    if (!RSMgr.dicController.ContainsKey(strName.ToLower()))
      return (RuntimeAnimatorController) null;
    return RSMgr.dicController[strName.ToLower()];
  }

  public static RuntimeAnimatorController GetRandomController()
  {
    List<string> stringList = new List<string>((IEnumerable<string>) RSMgr.dicController.Keys);
    return RSMgr.dicController[stringList[Random.Range(0, stringList.Count)]];
  }
}
