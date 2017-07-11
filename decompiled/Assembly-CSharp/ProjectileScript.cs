// Decompiled with JetBrains decompiler
// Type: ProjectileScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
  public GameObject impactParticle;
  public GameObject projectileParticle;
  public GameObject[] trailParticles;
  [HideInInspector]
  public Vector3 impactNormal;
  private bool hasCollided;

  private void Start()
  {
    this.projectileParticle = Object.Instantiate<GameObject>(this.projectileParticle, this.transform.position, this.transform.rotation);
    this.projectileParticle.transform.parent = this.transform;
  }

  private void OnCollisionEnter(Collision hit)
  {
    if (this.hasCollided)
      return;
    this.hasCollided = true;
    this.impactParticle = Object.Instantiate<GameObject>(this.impactParticle, this.transform.position, Quaternion.FromToRotation(Vector3.up, this.impactNormal));
    if (hit.gameObject.tag == "Destructible")
      Object.Destroy((Object) hit.gameObject);
    foreach (Object trailParticle in this.trailParticles)
    {
      GameObject gameObject = this.transform.Find(this.projectileParticle.name + "/" + trailParticle.name).gameObject;
      gameObject.transform.parent = (Transform) null;
      Object.Destroy((Object) gameObject, 3f);
    }
    Object.Destroy((Object) this.projectileParticle, 3f);
    Object.Destroy((Object) this.impactParticle, 5f);
    Object.Destroy((Object) this.gameObject);
  }
}
