// Decompiled with JetBrains decompiler
// Type: BeamScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;
using UnityEngine.UI;

public class BeamScript : MonoBehaviour
{
  [Header("Adjustable Variables")]
  public float beamEndOffset = 1f;
  public float textureScrollSpeed = 8f;
  public float textureLengthScale = 3f;
  [Header("Prefabs")]
  public GameObject[] beamLineRendererPrefab;
  public GameObject[] beamStartPrefab;
  public GameObject[] beamEndPrefab;
  private int currentBeam;
  private GameObject beamStart;
  private GameObject beamEnd;
  private GameObject beam;
  private LineRenderer line;
  [Header("Put Sliders here (Optional)")]
  public Slider endOffSetSlider;
  public Slider scrollSpeedSlider;
  [Header("Put UI Text object here to show beam name")]
  public Text textBeamName;

  private void Start()
  {
    if ((bool) ((Object) this.textBeamName))
      this.textBeamName.text = this.beamLineRendererPrefab[this.currentBeam].name;
    if ((bool) ((Object) this.endOffSetSlider))
      this.endOffSetSlider.value = this.beamEndOffset;
    if (!(bool) ((Object) this.scrollSpeedSlider))
      return;
    this.scrollSpeedSlider.value = this.textureScrollSpeed;
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
      Application.Quit();
    if (Input.GetMouseButtonDown(0))
    {
      this.beamStart = Object.Instantiate<GameObject>(this.beamStartPrefab[this.currentBeam], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
      this.beamEnd = Object.Instantiate<GameObject>(this.beamEndPrefab[this.currentBeam], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
      this.beam = Object.Instantiate<GameObject>(this.beamLineRendererPrefab[this.currentBeam], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
      this.line = this.beam.GetComponent<LineRenderer>();
    }
    if (Input.GetMouseButtonUp(0))
    {
      Object.Destroy((Object) this.beamStart);
      Object.Destroy((Object) this.beamEnd);
      Object.Destroy((Object) this.beam);
    }
    if (Input.GetMouseButton(0))
    {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hitInfo;
      if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        this.ShootBeamInDir(this.transform.position, hitInfo.point - this.transform.position);
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
      this.nextBeam();
    if (Input.GetKeyDown(KeyCode.D))
      this.nextBeam();
    if (Input.GetKeyDown(KeyCode.A))
    {
      this.previousBeam();
    }
    else
    {
      if (!Input.GetKeyDown(KeyCode.LeftArrow))
        return;
      this.previousBeam();
    }
  }

  public void nextBeam()
  {
    if (this.currentBeam < this.beamLineRendererPrefab.Length - 1)
      ++this.currentBeam;
    else
      this.currentBeam = 0;
    if (!(bool) ((Object) this.textBeamName))
      return;
    this.textBeamName.text = this.beamLineRendererPrefab[this.currentBeam].name;
  }

  public void previousBeam()
  {
    if (this.currentBeam > 0)
      --this.currentBeam;
    else
      this.currentBeam = this.beamLineRendererPrefab.Length - 1;
    if (!(bool) ((Object) this.textBeamName))
      return;
    this.textBeamName.text = this.beamLineRendererPrefab[this.currentBeam].name;
  }

  public void UpdateEndOffset()
  {
    this.beamEndOffset = this.endOffSetSlider.value;
  }

  public void UpdateScrollSpeed()
  {
    this.textureScrollSpeed = this.scrollSpeedSlider.value;
  }

  private void ShootBeamInDir(Vector3 start, Vector3 dir)
  {
    this.line.positionCount = 2;
    this.line.SetPosition(0, start);
    this.beamStart.transform.position = start;
    Vector3 zero = Vector3.zero;
    RaycastHit hitInfo;
    Vector3 vector3 = !Physics.Raycast(start, dir, out hitInfo) ? this.transform.position + dir * 100f : hitInfo.point - dir.normalized * this.beamEndOffset;
    this.beamEnd.transform.position = vector3;
    this.line.SetPosition(1, vector3);
    this.beamStart.transform.LookAt(this.beamEnd.transform.position);
    this.beamEnd.transform.LookAt(this.beamStart.transform.position);
    this.line.sharedMaterial.mainTextureScale = new Vector2(Vector3.Distance(start, vector3) / this.textureLengthScale, 1f);
    this.line.sharedMaterial.mainTextureOffset -= new Vector2(Time.deltaTime * this.textureScrollSpeed, 0.0f);
  }
}
