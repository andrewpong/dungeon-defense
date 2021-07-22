// Decompiled with JetBrains decompiler
// Type: BattleClockElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;
using UnityEngine.UI;

public class BattleClockElt : MonoBehaviour
{
  public Text textClock;
  public RectTransform rt;
  private float fTime;
  private float fMax;
  private int nHit;

  private void Awake()
  {
    this.fTime = 0.0f;
    this.fMax = 0.0f;
    this.ResetClock();
  }

  private void Update()
  {
    this.fTime = Mathf.Clamp(this.fTime + Time.deltaTime, 0.0f, this.fMax);
    this.textClock.text = (this.fMax - this.fTime).ToString("#0.00");
    if ((double) this.fTime < (double) this.fMax)
      return;
    this.nHit /= 2;
    UIMgr.PlaySound("Explosion" + (object) Random.Range(0, 2), false);
    PageBattle.obj.OnClockOver();
    this.ResetClock();
  }

  private void ResetClock()
  {
    this.rt.anchoredPosition = new Vector2(Random.Range(-200f, 300f), Random.Range(-250f, 250f));
    this.fTime = 0.0f;
    this.fMax = (float) (100 / (10 + this.nHit));
    this.fMax = Random.Range(this.fMax / 2f, this.fMax);
  }

  public void OnClick()
  {
    ++this.nHit;
    UIMgr.PlaySound("Hire", false);
    this.ResetClock();
  }
}
