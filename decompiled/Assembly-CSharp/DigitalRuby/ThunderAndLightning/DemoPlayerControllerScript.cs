// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.DemoPlayerControllerScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
  public class DemoPlayerControllerScript : MonoBehaviour
  {
    public float Speed = 3f;
    public float RotateSpeed = 3f;
    public Text SpellLabel;
    public LightningSpellScript[] Spells;
    private int spellIndex;
    private bool spellMouseButtonDown;
    private GameObject rightHand;

    private void OnCollisionEnter(Collision collision)
    {
      foreach (ContactPoint contact in collision.contacts)
      {
        Rigidbody component = contact.otherCollider.gameObject.GetComponent<Rigidbody>();
        if ((Object) component != (Object) null)
          component.velocity += this.gameObject.transform.forward * 5f;
      }
    }

    private void Start()
    {
      this.rightHand = this.gameObject.transform.Find("RightArm").Find("RightHand").gameObject;
      this.UpdateSpell();
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
        DemoScript.ReloadCurrentScene();
      }
      else
      {
        CharacterController component = this.GetComponent<CharacterController>();
        this.transform.Rotate(0.0f, Input.GetAxis("Horizontal") * this.RotateSpeed, 0.0f);
        Vector3 vector3_1 = this.transform.TransformDirection(Vector3.forward);
        float num = this.Speed * Input.GetAxis("Vertical");
        component.SimpleMove(vector3_1 * num);
        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus))
          this.NextSpell();
        else if (Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus))
          this.PreviousSpell();
        LightningSpellScript spell = this.Spells[this.spellIndex];
        if (Input.GetButton("Fire1") && (this.spellMouseButtonDown || !Input.GetMouseButton(0) || this.GuiElementShouldPassThrough()))
        {
          if ((Object) spell.SpellStart != (Object) null && (Object) spell.SpellStart.GetComponent<Rigidbody>() == (Object) null)
            spell.SpellStart.transform.position = this.rightHand.transform.position;
          if (Input.GetMouseButton(0))
          {
            this.spellMouseButtonDown = true;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            Vector3 vector3_2 = !Physics.Raycast(ray, out hitInfo, spell.MaxDistance, (int) spell.CollisionMask) ? ray.origin + ray.direction * spell.MaxDistance : hitInfo.point;
            spell.Direction = (vector3_2 - spell.SpellStart.transform.position).normalized;
          }
          else
          {
            this.spellMouseButtonDown = false;
            spell.Direction = this.gameObject.transform.forward;
          }
          spell.CastSpell();
        }
        else
        {
          this.spellMouseButtonDown = false;
          spell.StopSpell();
        }
      }
    }

    private bool GuiElementShouldPassThrough()
    {
      PointerEventData eventData = new PointerEventData(EventSystem.current);
      eventData.position = (Vector2) Input.mousePosition;
      List<RaycastResult> raycastResults = new List<RaycastResult>();
      EventSystem.current.RaycastAll(eventData, raycastResults);
      foreach (RaycastResult raycastResult in raycastResults)
      {
        if ((Object) raycastResult.gameObject.GetComponent<Button>() != (Object) null || (Object) raycastResult.gameObject.GetComponent<Text>() == (Object) null && (Object) raycastResult.gameObject.GetComponent<Image>() == (Object) null)
          return false;
      }
      return true;
    }

    private void UpdateSpell()
    {
      this.SpellLabel.text = this.Spells[this.spellIndex].name;
      this.Spells[this.spellIndex].ActivateSpell();
    }

    private void ChangeSpell(int dir)
    {
      this.Spells[this.spellIndex].StopSpell();
      this.Spells[this.spellIndex].DeactivateSpell();
      this.spellIndex += dir;
      if (this.spellIndex < 0)
        this.spellIndex = this.Spells.Length - 1;
      else if (this.spellIndex >= this.Spells.Length)
        this.spellIndex = 0;
      this.UpdateSpell();
    }

    public void PreviousSpell()
    {
      this.ChangeSpell(-1);
    }

    public void NextSpell()
    {
      this.ChangeSpell(1);
    }
  }
}
