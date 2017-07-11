// Decompiled with JetBrains decompiler
// Type: lightScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class lightScript : MonoBehaviour
{
  private bool Impact;
  public float Sqr;

  private void Start()
  {
    this.Impact = true;
    this.gameObject.GetComponent<Light>().intensity = 7f;
    this.Sqr = (float) ((double) this.gameObject.GetComponent<Light>().intensity * (double) this.gameObject.GetComponent<Light>().intensity * ((double) this.gameObject.GetComponent<Light>().intensity >= 0.0 ? 1.0 : -1.0));
  }

  private void Update()
  {
    if (!this.Impact)
      return;
    this.gameObject.GetComponent<Light>().intensity -= (float) (1.0 / (double) Time.deltaTime * (double) this.Sqr * 9.99999974737875E-05);
    if ((double) this.gameObject.GetComponent<Light>().intensity > 0.0)
      return;
    Object.Destroy((Object) this.gameObject);
  }
}
