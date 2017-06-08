// Decompiled with JetBrains decompiler
// Type: FireProjectile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class FireProjectile : MonoBehaviour
{
  public float speed = 1000f;
  private RaycastHit hit;
  public GameObject[] projectiles;
  public Transform spawnPosition;
  [HideInInspector]
  public int currentProjectile;
  private ButtonScript selectedProjectileButton;

  private void Start()
  {
    this.selectedProjectileButton = GameObject.Find("Button").GetComponent<ButtonScript>();
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      this.nextEffect();
      this.selectedProjectileButton.getProjectileNames();
    }
    if (Input.GetKeyDown(KeyCode.D))
    {
      this.nextEffect();
      this.selectedProjectileButton.getProjectileNames();
    }
    if (Input.GetKeyDown(KeyCode.A))
    {
      this.previousEffect();
      this.selectedProjectileButton.getProjectileNames();
    }
    else if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      this.previousEffect();
      this.selectedProjectileButton.getProjectileNames();
    }
    if (Input.GetKeyDown(KeyCode.Mouse0) && !this.selectedProjectileButton.overButton() && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.hit, 100f))
    {
      GameObject gameObject = Object.Instantiate<GameObject>(this.projectiles[this.currentProjectile], this.spawnPosition.position, Quaternion.identity);
      gameObject.transform.LookAt(this.hit.point);
      gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * this.speed);
      gameObject.GetComponent<ProjectileScript>().impactNormal = this.hit.normal;
    }
    Debug.DrawRay(Camera.main.ScreenPointToRay(Input.mousePosition).origin, Camera.main.ScreenPointToRay(Input.mousePosition).direction * 100f, Color.yellow);
  }

  public void nextEffect()
  {
    if (this.currentProjectile < this.projectiles.Length - 1)
      ++this.currentProjectile;
    else
      this.currentProjectile = 0;
  }

  public void previousEffect()
  {
    if (this.currentProjectile > 0)
      --this.currentProjectile;
    else
      this.currentProjectile = this.projectiles.Length - 1;
  }

  public void AdjustSpeed(float newSpeed)
  {
    this.speed = newSpeed;
  }
}
