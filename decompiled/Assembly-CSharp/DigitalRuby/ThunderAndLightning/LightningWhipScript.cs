// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningWhipScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  [RequireComponent(typeof (AudioSource))]
  public class LightningWhipScript : MonoBehaviour
  {
    private bool canWhip = true;
    public AudioClip WhipCrack;
    public AudioClip WhipCrackThunder;
    private AudioSource audioSource;
    private GameObject whipStart;
    private GameObject whipEndStrike;
    private GameObject whipHandle;
    private GameObject whipSpring;
    private Vector2 prevDrag;
    private bool dragging;

    [DebuggerHidden]
    private IEnumerator WhipForward()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new LightningWhipScript.\u003CWhipForward\u003Ec__Iterator0() { \u0024this = this };
    }

    private void Start()
    {
      this.whipStart = GameObject.Find("WhipStart");
      this.whipEndStrike = GameObject.Find("WhipEndStrike");
      this.whipHandle = GameObject.Find("WhipHandle");
      this.whipSpring = GameObject.Find("WhipSpring");
      this.audioSource = this.GetComponent<AudioSource>();
    }

    private void Update()
    {
      if (!this.dragging && Input.GetMouseButtonDown(0))
      {
        Vector2 worldPoint = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D collider2D = Physics2D.OverlapPoint(worldPoint);
        if ((Object) collider2D != (Object) null && (Object) collider2D.gameObject == (Object) this.whipHandle)
        {
          this.dragging = true;
          this.prevDrag = worldPoint;
        }
      }
      else if (this.dragging && Input.GetMouseButton(0))
      {
        Vector2 worldPoint = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 vector2 = worldPoint - this.prevDrag;
        Rigidbody2D component = this.whipHandle.GetComponent<Rigidbody2D>();
        component.MovePosition(component.position + vector2);
        this.prevDrag = worldPoint;
      }
      else
        this.dragging = false;
      if (!Input.GetKeyDown(KeyCode.Space))
        return;
      this.StartCoroutine(this.WhipForward());
    }
  }
}
