// Decompiled with JetBrains decompiler
// Type: BattleCoinElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class BattleCoinElt : MonoBehaviour
{
  public GameObject goCoin;
  public GameObject goItem;
  public GameObject goHP;
  private float fGold;
  [HideInInspector]
  public BattleCoinElt.Type eType;

  public float fEarnGold
  {
    get
    {
      return this.fGold;
    }
  }

  public bool isGold
  {
    get
    {
      return this.eType == BattleCoinElt.Type.eGold;
    }
  }

  public bool isItem
  {
    get
    {
      return this.eType == BattleCoinElt.Type.eItem;
    }
  }

  public bool isHP
  {
    get
    {
      return this.eType == BattleCoinElt.Type.eHP;
    }
  }

  public void SetGold(BattleCoinElt.Type _eType, float _fGold, Vector3 vOri, float x, float y)
  {
    this.eType = _eType;
    this.fGold = _fGold;
    this.goCoin.SetActive(this.isGold);
    this.goItem.SetActive(this.isItem);
    this.goHP.SetActive(this.isHP);
    this.StartCoroutine(this.MoveGold(vOri, x, y));
  }

  [DebuggerHidden]
  private IEnumerator MoveGold(Vector3 vOri, float fMoveX, float fMoveY)
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new BattleCoinElt.\u003CMoveGold\u003Ec__Iterator0()
    {
      vOri = vOri,
      fMoveY = fMoveY,
      \u0024this = this
    };
  }

  public void Reach()
  {
    PageBattle.obj.OnGoldReach(this);
  }

  public enum Type
  {
    eGold,
    eItem,
    eHP,
  }
}
