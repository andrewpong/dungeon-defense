// Decompiled with JetBrains decompiler
// Type: EnemyBullet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
  private Vector3 vMove = Vector3.zero;
  [HideInInspector]
  public float fDmg;
  [HideInInspector]
  public Enemy em;

  public void SetBullet(float _fDmg, float _fSpd, Enemy _em)
  {
    this.em = _em;
    this.fDmg = _fDmg;
    this.vMove.x = -_fSpd;
  }

  private void Update()
  {
    this.transform.Translate(this.vMove * Time.deltaTime);
    if ((double) this.transform.position.x >= -230.0)
      return;
    PageBattle.obj.OnEnemyBulletCollision(this);
  }
}
