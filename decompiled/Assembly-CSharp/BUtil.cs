﻿// Decompiled with JetBrains decompiler
// Type: BUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class BUtil : MonoBehaviour
{
  public static RectTransform SetParent(RectTransform rtChild, Transform trParent)
  {
    rtChild.SetParent(trParent);
    rtChild.localPosition = Vector3.zero;
    rtChild.anchoredPosition = Vector2.zero;
    rtChild.localRotation = Quaternion.identity;
    rtChild.localScale = Vector3.one;
    return rtChild;
  }

  public static Vector3 WorldToCanvas(Camera camera, RectTransform rt, Vector3 pos)
  {
    Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(camera, pos);
    Vector3 worldPoint;
    RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, screenPoint, camera, out worldPoint);
    return worldPoint;
  }

  public static Color Alpha(MaskableGraphic text, float fAlpha = 0.0f)
  {
    Color color = text.color;
    color.a = fAlpha;
    text.color = color;
    return color;
  }
}
