// Decompiled with JetBrains decompiler
// Type: ButtonScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
  public GameObject Button;
  private Text MyButtonText;
  private string projectileParticleName;
  private FireProjectile effectScript;
  private ProjectileScript projectileScript;
  public float buttonsX;
  public float buttonsY;
  public float buttonsSizeX;
  public float buttonsSizeY;
  public float buttonsDistance;

  private void Start()
  {
    this.effectScript = GameObject.Find("FireProjectile").GetComponent<FireProjectile>();
    this.getProjectileNames();
    this.MyButtonText = this.Button.transform.Find("Text").GetComponent<Text>();
    this.MyButtonText.text = this.projectileParticleName;
  }

  private void Update()
  {
    this.MyButtonText.text = this.projectileParticleName;
  }

  public void getProjectileNames()
  {
    this.projectileScript = this.effectScript.projectiles[this.effectScript.currentProjectile].GetComponent<ProjectileScript>();
    this.projectileParticleName = this.projectileScript.projectileParticle.name;
  }

  public bool overButton()
  {
    return new Rect(this.buttonsX, this.buttonsY, this.buttonsSizeX, this.buttonsSizeY).Contains(new Vector2(Input.mousePosition.x, (float) Screen.height - Input.mousePosition.y)) || new Rect(this.buttonsX + this.buttonsDistance, this.buttonsY, this.buttonsSizeX, this.buttonsSizeY).Contains(new Vector2(Input.mousePosition.x, (float) Screen.height - Input.mousePosition.y));
  }

  public void LoadStage1()
  {
    SceneManager.LoadScene("magic_projectiles");
  }

  public void LoadStage2()
  {
    SceneManager.LoadScene("magic_sprays");
  }

  public void LoadStage3()
  {
    SceneManager.LoadScene("magic_aura");
  }

  public void LoadStage4()
  {
    SceneManager.LoadScene("magic_modular");
  }

  public void LoadStage5()
  {
    SceneManager.LoadScene("magic_domes");
  }

  public void LoadStage6()
  {
    SceneManager.LoadScene("magic_shields");
  }

  public void LoadStage7()
  {
    SceneManager.LoadScene("magic_sphereblast");
  }
}
