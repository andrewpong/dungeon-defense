// Decompiled with JetBrains decompiler
// Type: BattleLaserElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

public class BattleLaserElt : MonoBehaviour
{
  [HideInInspector]
  public float fSize = 10f;
  public LineRenderer line;
  [HideInInspector]
  public bool bCreated;
  private float fOriSize;

  private void Awake()
  {
    this.line.sortingOrder = 5000;
  }

  private void Update()
  {
    if (this.bCreated)
    {
      this.bCreated = false;
    }
    else
    {
      this.fSize = Mathf.Clamp(this.fSize - (float) ((double) Time.deltaTime * (double) this.fOriSize * 4.0), 0.0f, this.fSize);
      if ((double) this.fSize <= 0.0)
        this.gameObject.SetActive(false);
      LineRenderer line = this.line;
      float fSize = this.fSize;
      this.line.endWidth = fSize;
      double num = (double) fSize;
      line.startWidth = (float) num;
    }
  }

  public void OnCreated(float _fSize, Vector3 vStart, Vector3 vEnd)
  {
    this.fOriSize = this.fSize = _fSize;
    this.bCreated = true;
    vStart.z = vEnd.z = 10f;
    this.line.SetPosition(0, vStart);
    this.line.SetPosition(1, vEnd);
    LineRenderer line = this.line;
    float fSize = this.fSize;
    this.line.endWidth = fSize;
    double num = (double) fSize;
    line.startWidth = (float) num;
  }
}
