// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.ReorderableListAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class ReorderableListAttribute : PropertyAttribute
  {
    public string Tooltip { get; private set; }

    public ReorderableListAttribute(string tooltip)
    {
      this.Tooltip = tooltip;
    }
  }
}
