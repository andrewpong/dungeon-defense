// Decompiled with JetBrains decompiler
// Type: DragMouseOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse drag Orbit with zoom")]
public class DragMouseOrbit : MonoBehaviour
{
  public float distance = 5f;
  public float xSpeed = 120f;
  public float ySpeed = 120f;
  public float yMinLimit = -20f;
  public float yMaxLimit = 80f;
  public float distanceMin = 0.5f;
  public float distanceMax = 15f;
  public float smoothTime = 2f;
  public Transform target;
  private float rotationYAxis;
  private float rotationXAxis;
  private float velocityX;
  private float velocityY;

  private void Start()
  {
    Vector3 eulerAngles = this.transform.eulerAngles;
    this.rotationYAxis = eulerAngles.y;
    this.rotationXAxis = eulerAngles.x;
    if (!(bool) ((Object) this.GetComponent<Rigidbody>()))
      return;
    this.GetComponent<Rigidbody>().freezeRotation = true;
  }

  private void LateUpdate()
  {
    if (!(bool) ((Object) this.target))
      return;
    if (Input.GetMouseButton(1))
    {
      this.velocityX += (float) ((double) this.xSpeed * (double) Input.GetAxis("Mouse X") * (double) this.distance * 0.0199999995529652);
      this.velocityY += (float) ((double) this.ySpeed * (double) Input.GetAxis("Mouse Y") * 0.0199999995529652);
    }
    this.rotationYAxis += this.velocityX;
    this.rotationXAxis -= this.velocityY;
    this.rotationXAxis = DragMouseOrbit.ClampAngle(this.rotationXAxis, this.yMinLimit, this.yMaxLimit);
    Quaternion quaternion = Quaternion.Euler(this.rotationXAxis, this.rotationYAxis, 0.0f);
    this.distance = Mathf.Clamp(this.distance - Input.GetAxis("Mouse ScrollWheel") * 5f, this.distanceMin, this.distanceMax);
    RaycastHit hitInfo;
    if (Physics.Linecast(this.target.position, this.transform.position, out hitInfo))
      this.distance -= hitInfo.distance;
    Vector3 vector3_1 = new Vector3(0.0f, 0.0f, -this.distance);
    Vector3 vector3_2 = quaternion * vector3_1 + this.target.position;
    this.transform.rotation = quaternion;
    this.transform.position = vector3_2;
    this.velocityX = Mathf.Lerp(this.velocityX, 0.0f, Time.deltaTime * this.smoothTime);
    this.velocityY = Mathf.Lerp(this.velocityY, 0.0f, Time.deltaTime * this.smoothTime);
  }

  public static float ClampAngle(float angle, float min, float max)
  {
    if ((double) angle < -360.0)
      angle += 360f;
    if ((double) angle > 360.0)
      angle -= 360f;
    return Mathf.Clamp(angle, min, max);
  }
}
