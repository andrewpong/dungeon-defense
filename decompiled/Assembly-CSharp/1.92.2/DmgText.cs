// Decompiled with JetBrains decompiler
// Type: DmgText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class DmgText : MonoBehaviour
{
  private Vector2 vDiffPos = Vector2.zero;
  private float fFloatY = 32f;
  private float fMoveX = 32f;
  public TextMesh text;
  public MeshRenderer ms;
  private Vector2 vOriPos;
  private Coroutine cr;
  private float fMaxPos;
  private Color cl;
  private Color clAlpha;

  public void SetText(Vector2 vPos, string strText, Color _cl, float fDist = 80f)
  {
    this.ms.sortingOrder = 1000;
    this.gameObject.SetActive(true);
    vPos.y += 16f;
    Vector3 vector3 = (Vector3) vPos;
    this.transform.localPosition = vector3;
    this.vOriPos = (Vector2) vector3;
    this.text.text = strText;
    this.clAlpha = this.cl = _cl;
    this.clAlpha.a = 0.0f;
    this.text.color = this.cl;
    this.fMoveX = Random.Range(fDist * 0.5f, fDist);
    this.fFloatY = Random.Range(60f, 96f);
    this.vDiffPos = Vector2.zero;
    this.fMaxPos = (float) ((double) PageBattle.obj.vScreen.x - (double) this.vOriPos.x - 10.0);
    if (this.cr != null)
      this.StopCoroutine(this.cr);
    this.cr = this.StartCoroutine(this.UpdateText());
  }

  [DebuggerHidden]
  private IEnumerator UpdateText()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new DmgText.\u003CUpdateText\u003Ec__Iterator0()
    {
      \u0024this = this
    };
  }
}
